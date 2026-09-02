using System.Net;
using System.Text.RegularExpressions;
using Ganss.Xss;
using Markdig.Renderers;
using Markdig.Renderers.Html;
using Markdig.Renderers.Html.Inlines;
using Markdig.Syntax;
using Markdig.Syntax.Inlines;
using AngleSharp.Dom;

namespace WorldEgg.Wiki.Core;

public sealed record RenderIssue(string Kind, string Target);
public sealed record RenderedArticle(string Html, ArticleHeading[] Headings, RenderIssue[] Issues);

public sealed class ArticleRenderer(VaultCatalogue catalogue, LinkResolver links)
{
    public RenderedArticle Render(WikiDocument document)
    {
        var context = new RenderContext(catalogue, links);
        var html = context.Render(document, "", [document.Id], false);
        var sanitizer = new HtmlSanitizer();
        foreach (var tag in new[] { "aside", "section", "details", "summary", "figure", "figcaption", "mark", "input" }) sanitizer.AllowedTags.Add(tag);
        foreach (var attribute in new[] { "class", "id", "open", "loading", "decoding", "aria-label", "aria-hidden", "role", "checked", "disabled", "type", "data-base-id" }) sanitizer.AllowedAttributes.Add(attribute);
        sanitizer.AllowedSchemes.Remove("data");
        sanitizer.AllowedAttributes.Remove("style");
        var safe = new AngleSharp.Html.Parser.HtmlParser().ParseDocument(sanitizer.Sanitize(html));
        foreach (var heading in safe.QuerySelectorAll("h2[id],h3[id],h4[id],h5[id],h6[id]"))
        {
            var link = safe.CreateElement("a"); link.ClassName = "section-permalink";
            link.SetAttribute("href", LinkResolver.PageUrl(document.Id) + "#" + Uri.EscapeDataString(heading.Id!));
            link.SetAttribute("aria-label", "Link to section: " + heading.TextContent);
            link.SetAttribute("title", "Link to this section"); link.TextContent = "¶"; heading.AppendChild(link);
        }
        return new(safe.Body!.InnerHtml, MarkdownSupport.GetHeadings(document).Where(h => h.Level > 1).ToArray(), context.Issues.ToArray());
    }

    private sealed class RenderContext(VaultCatalogue catalogue, LinkResolver links)
    {
        public LinkResolver Links { get; } = links;
        public readonly List<RenderIssue> Issues = [];
        private int _embedNumber;
        private int _embedBudget = 30;
        public static string E(string? value) => WebUtility.HtmlEncode(value ?? "");

        public string Render(WikiDocument source, string fragment, HashSet<string> ancestors, bool embedded)
        {
            var doc = MarkdownSupport.Parse(source.Body);
            var prefix = embedded ? "embed-" + (++_embedNumber) + "-" : "";
            var blocks = MarkdownSupport.AttachBlockIds(doc, prefix);
            if (fragment.Length > 0)
            {
                if (fragment.StartsWith('^'))
                {
                    if (!blocks.TryGetValue(fragment[1..], out var block)) return Notice("missing", "Embedded block not found: " + fragment);
                    return Render(source with { Body = source.Body[block.Span.Start..(block.Span.End + 1)] }, "", ancestors, embedded);
                }
                var heading = doc.OfType<HeadingBlock>().FirstOrDefault(h => MarkdownSupport.HeadingText(h).Equals(fragment, StringComparison.OrdinalIgnoreCase) || h.GetAttributes().Id == fragment);
                if (heading is null) return Notice("missing", "Embedded section not found: " + fragment);
                var start = doc.IndexOf(heading);
                var end = start + 1;
                while (end < doc.Count && (doc[end] is not HeadingBlock next || next.Level > heading.Level)) end++;
                for (var i = doc.Count - 1; i >= end; i--) doc.RemoveAt(i);
                for (var i = start - 1; i >= 0; i--) doc.RemoveAt(i);
            }
            else if (!embedded && doc.FirstOrDefault() is HeadingBlock { Level: 1 } first && MarkdownSupport.HeadingText(first) == source.Title) doc.RemoveAt(0);

            if (embedded)
            {
                foreach (var block in doc.Descendants<Block>())
                    if (block.GetAttributes().Id is { Length: > 0 } id) block.GetAttributes().Id = prefix + id;
            }
            using var writer = new StringWriter();
            var renderer = new HtmlRenderer(writer);
            MarkdownSupport.Pipeline.Setup(renderer);
            renderer.ObjectRenderers.Insert(0, new WikiRenderer(this, source, ancestors));
            renderer.ObjectRenderers.Insert(0, new LocalLinkRenderer(this, source));
            renderer.ObjectRenderers.Insert(0, new CalloutRenderer());
            renderer.ObjectRenderers.Insert(0, new DiagramRenderer());
            renderer.ObjectRenderers.Insert(0, new EmbedParagraphRenderer(this, source, ancestors));
            renderer.Render(doc);
            return writer.ToString();
        }

        public string Notice(string kind, string message)
        {
            Issues.Add(new(kind, message));
            return "<span class=\"reader-notice " + E(kind) + "\">" + E(message) + "</span>";
        }

        public string Wiki(WikiInline wiki, WikiDocument source, HashSet<string> ancestors)
        {
            var result = Links.Resolve(wiki.Target, source.Id);
            if (!wiki.Embed) return Anchor(result, source, E(wiki.Label));
            if (result.Id is not { } id) return Anchor(result, source, E("Missing or ambiguous embed: " + wiki.Label));
            if (id.EndsWith(".base", StringComparison.OrdinalIgnoreCase))
                return "<span class=\"base-embed\" data-base-id=\"" + E(id) + "\"><a href=\"" + E(LinkResolver.BaseUrl(id)) + "\">" + E(Path.GetFileNameWithoutExtension(id)) + "</a></span>";
            if (!id.EndsWith(".md", StringComparison.OrdinalIgnoreCase)) return Image(result, wiki.Label, "", !WithinLink(wiki));
            if (ancestors.Contains(id)) return Notice("cycle", "Embed cycle stopped: " + Path.GetFileNameWithoutExtension(id));
            if (ancestors.Count >= 4 || _embedBudget-- <= 0) return Notice("limit", "Embed limit reached. Open the linked article to continue.");
            var document = catalogue.Current.Documents[id];
            var nested = new HashSet<string>(ancestors, StringComparer.OrdinalIgnoreCase) { id };
            return "<section class=\"note-embed\"><div class=\"embed-source\">From " + Anchor(result, source, E(document.Title)) + "</div>" + Render(document, result.Fragment, nested, true) + "</section>";
        }

        public string Anchor(LinkResult result, WikiDocument source, string label)
        {
            CheckFragment(result);
            if (result.State == LinkState.Blocked) return Notice("blocked", "Blocked link: " + result.Target);
            if (result.State is LinkState.Missing or LinkState.Ambiguous) Issues.Add(new(result.State.ToString().ToLowerInvariant(), result.Target));
            var css = result.State switch { LinkState.Missing => " missing-link", LinkState.Ambiguous => " ambiguous-link", _ => "" };
            var external = result.State == LinkState.External ? " rel=\"noreferrer noopener\"" : "";
            return "<a class=\"wiki-link" + css + "\" href=\"" + E(Links.Href(result, source.Id)) + "\"" + external + ">" + label + "</a>";
        }

        public void CheckFragment(LinkResult result)
        {
            if (result.Id is { } id && result.Fragment.Length > 0 && catalogue.Current.Documents.TryGetValue(id, out var document) && !MarkdownSupport.GetAnchors(document).Contains(result.Fragment.TrimStart('^')))
                Issues.Add(new("missing-anchor", result.Target));
        }

        private static bool WithinLink(Inline node) { for (var parent = node.Parent; parent is not null; parent = parent.Parent) if (parent is LinkInline) return true; return false; }
        public string Image(LinkResult result, string alt, string title, bool enlarge = true)
        {
            if (result.Id is not { } id) return Notice("missing", "Image is unavailable or ambiguous: " + result.Target);
            if (id.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase)) return "<a href=\"" + E(LinkResolver.AssetUrl(id)) + "\">Open PDF: " + E(Path.GetFileName(id)) + "</a>";
            if (!new[] { ".png", ".jpg", ".jpeg", ".gif", ".webp", ".svg" }.Contains(Path.GetExtension(id).ToLowerInvariant())) return Notice("unsupported", "This attachment is not an image: " + id);
            var size = Regex.Match(alt, @"^(\d{1,4})(?:x(\d{1,4}))?$");
            var dimensions = size.Success ? " width=\"" + size.Groups[1].Value + "\"" + (size.Groups[2].Success ? " height=\"" + size.Groups[2].Value + "\"" : "") : "";
            var image = "<img loading=\"lazy\" decoding=\"async\" src=\"" + E(LinkResolver.AssetUrl(id)) + "\" alt=\"" + E(size.Success ? Path.GetFileNameWithoutExtension(id) : alt) + "\" title=\"" + E(title) + "\"" + dimensions + ">";
            return enlarge ? "<a class=\"image-enlarge\" href=\"" + E(LinkResolver.AssetUrl(id)) + "\" aria-label=\"Enlarge image: " + E(size.Success ? Path.GetFileNameWithoutExtension(id) : alt) + "\" title=\"Open image viewer\">" + image + "</a>" : image;
        }

        private sealed class WikiRenderer(RenderContext context, WikiDocument source, HashSet<string> ancestors) : HtmlObjectRenderer<WikiInline>
        {
            protected override void Write(HtmlRenderer renderer, WikiInline obj) => renderer.Write(context.Wiki(obj, source, ancestors));
        }

        private sealed class EmbedParagraphRenderer(RenderContext context, WikiDocument source, HashSet<string> ancestors) : ParagraphRenderer
        {
            protected override void Write(HtmlRenderer renderer, ParagraphBlock obj)
            {
                if (obj.Inline?.FirstChild is WikiInline { Embed: true } wiki && wiki.NextSibling is null) renderer.Write(context.Wiki(wiki, source, ancestors));
                else base.Write(renderer, obj);
            }
        }

        private sealed class LocalLinkRenderer(RenderContext context, WikiDocument source) : HtmlObjectRenderer<LinkInline>
        {
            protected override void Write(HtmlRenderer renderer, LinkInline obj)
            {
                var result = context.Links.Resolve(obj.GetDynamicUrl?.Invoke() ?? obj.Url ?? "", source.Id);
                context.CheckFragment(result);
                if (obj.IsImage)
                {
                    if (result.State == LinkState.External) renderer.Write(context.Notice("external-image", "External image not loaded automatically: " + result.Target));
                    else renderer.Write(context.Image(result, MarkdownSupport.Plain(obj), obj.Title ?? "", !WithinLink(obj)));
                    return;
                }
                if (result.State == LinkState.Blocked) { renderer.Write(context.Notice("blocked", "Blocked link: " + result.Target)); return; }
                if (result.State is LinkState.Missing or LinkState.Ambiguous) context.Issues.Add(new(result.State.ToString().ToLowerInvariant(), result.Target));
                renderer.Write("<a href=\"").Write(E(context.Links.Href(result, source.Id))).Write("\" class=\"wiki-link " + (result.State == LinkState.Missing ? "missing-link" : result.State == LinkState.Ambiguous ? "ambiguous-link" : "") + "\" rel=\"noreferrer noopener\">");
                renderer.WriteChildren(obj);
                renderer.Write("</a>");
            }
        }

        private sealed class DiagramRenderer : CodeBlockRenderer
        {
            protected override void Write(HtmlRenderer renderer, CodeBlock obj)
            {
                if (obj is FencedCodeBlock fenced && fenced.Info?.Trim().Equals("mermaid", StringComparison.OrdinalIgnoreCase) == true)
                    renderer.Write("<pre class=\"mermaid\">").Write(E(obj.Lines.ToString())).Write("</pre>");
                else base.Write(renderer, obj);
            }
        }

        private sealed class CalloutRenderer : QuoteBlockRenderer
        {
            protected override void Write(HtmlRenderer renderer, QuoteBlock obj)
            {
                if (obj.FirstOrDefault() is not ParagraphBlock paragraph || paragraph.Inline is null) { base.Write(renderer, obj); return; }
                var text = MarkdownSupport.Plain(paragraph.Inline);
                var match = Regex.Match(text, @"^\[!([A-Za-z-]+)\]([+-]?)(?:[ \t]+([^\n]*))?(?:\n|$)");
                if (!match.Success) { base.Write(renderer, obj); return; }
                var remaining = match.Length;
                foreach (var child in paragraph.Inline.ToArray())
                {
                    if (remaining == 0) break;
                    var length = child is LiteralInline literal ? literal.Content.Length : child is LineBreakInline ? 1 : 0;
                    if (length <= remaining) { child.Remove(); remaining -= length; }
                    else if (child is LiteralInline tail) { tail.Content = new(tail.Content.ToString()[remaining..]); remaining = 0; }
                }
                if (paragraph.Inline.FirstChild is null) obj.Remove(paragraph);
                var kind = match.Groups[1].Value.ToLowerInvariant();
                var title = match.Groups[3].Success ? match.Groups[3].Value : kind;
                var folding = match.Groups[2].Value;
                var tag = folding.Length == 0 ? "aside" : "details";
                renderer.Write("<" + tag + " class=\"callout callout-" + E(kind) + "\"" + (folding == "+" ? " open" : "") + ">");
                renderer.Write(folding.Length == 0 ? "<div class=\"callout-title\">" : "<summary>").Write(E(title)).Write(folding.Length == 0 ? "</div>" : "</summary>");
                renderer.WriteChildren(obj);
                renderer.Write("</" + tag + ">");
            }
        }
    }
}
