using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Markdig;
using Markdig.Extensions.AutoIdentifiers;
using Markdig.Helpers;
using Markdig.Parsers;
using Markdig.Renderers;
using Markdig.Renderers.Html;
using Markdig.Syntax;
using Markdig.Syntax.Inlines;

namespace WorldEgg.Wiki.Core;

public sealed record ArticleHeading(string Id, string Text, int Level);
public sealed class WikiInline(string target, string label, bool embed) : LeafInline
{
    public string Target { get; } = target;
    public string Label { get; } = label;
    public bool Embed { get; } = embed;
}

public sealed class WikiInlineParser : InlineParser
{
    public WikiInlineParser() => OpeningCharacters = ['[', '!'];
    public override bool Match(InlineProcessor processor, ref StringSlice slice)
    {
        var text = slice.Text;
        var start = slice.Start;
        var embed = text[start] == '!';
        var opening = start + (embed ? 1 : 0);
        if (opening + 1 > slice.End || text[opening] != '[' || text[opening + 1] != '[') return false;
        var end = text.IndexOf("]]", opening + 2, StringComparison.Ordinal);
        if (end < 0 || end + 1 > slice.End) return false;
        var inner = text[(opening + 2)..end].Replace("\\|", "|");
        if (inner.Contains('\n')) return false;
        var separator = inner.IndexOf('|');
        var target = separator < 0 ? inner : inner[..separator];
        var label = separator < 0 ? inner : inner[(separator + 1)..];
        if (target.Length == 0) return false;
        processor.Inline = new WikiInline(target, label, embed);
        slice.Start = end + 2;
        return true;
    }
}

internal sealed class WikiExtension : IMarkdownExtension
{
    public void Setup(MarkdownPipelineBuilder pipeline) => pipeline.InlineParsers.Insert(0, new WikiInlineParser());
    public void Setup(MarkdownPipeline pipeline, IMarkdownRenderer renderer) { }
}

public static class MarkdownSupport
{
    private static readonly ConditionalWeakTable<WikiDocument, ArticleHeading[]> HeadingCache = new();
    private static readonly ConditionalWeakTable<WikiDocument, HashSet<string>> AnchorCache = new();
    public static readonly MarkdownPipeline Pipeline = BuildPipeline();
    private static MarkdownPipeline BuildPipeline()
    {
        var builder = new MarkdownPipelineBuilder().UsePipeTables().UseFootnotes().UseAutoIdentifiers(AutoIdentifierOptions.GitHub).UseTaskLists().UseEmphasisExtras().UseGenericAttributes().UseAutoLinks();
        builder.Extensions.Add(new WikiExtension());
        return builder.Build();
    }
    public static MarkdownDocument Parse(string body) => Markdown.Parse(body, Pipeline);
    public static ArticleHeading[] GetHeadings(WikiDocument document) => HeadingCache.GetValue(document, d => Headings(Parse(d.Body)));
    public static HashSet<string> GetAnchors(WikiDocument document) => AnchorCache.GetValue(document, d =>
    {
        var parsed = Parse(d.Body);
        var ids = AttachBlockIds(parsed).Keys.ToHashSet(StringComparer.OrdinalIgnoreCase);
        foreach (var heading in Headings(parsed)) { ids.Add(heading.Id); ids.Add(heading.Text); }
        return ids;
    });
    public static ArticleHeading[] Headings(MarkdownDocument document) => document.Descendants<HeadingBlock>().Select(h => new ArticleHeading(h.GetAttributes().Id ?? "", HeadingText(h), h.Level)).ToArray();
    public static string HeadingText(HeadingBlock heading) => Plain(heading.Inline).Trim();

    public static string Plain(ContainerInline? container)
    {
        var text = new StringBuilder();
        if (container is null) return "";
        foreach (var inline in container)
            text.Append(inline switch { LiteralInline l => l.Content.ToString(), CodeInline c => c.Content, WikiInline w => w.Label, LineBreakInline => "\n", ContainerInline c => Plain(c), _ => "" });
        return text.ToString();
    }

    // Obsidian block IDs belong to the preceding block, not to a new visible paragraph.
    public static Dictionary<string, Block> AttachBlockIds(MarkdownDocument document, string prefix = "")
    {
        var result = new Dictionary<string, Block>(StringComparer.Ordinal);
        foreach (var paragraph in document.Descendants<ParagraphBlock>().ToArray())
        {
            if (paragraph.Inline?.LastChild is not LiteralInline) continue;
            var text = Plain(paragraph.Inline);
            var literalTail = string.Concat(paragraph.Inline.Reverse().TakeWhile(i => i is LiteralInline or LineBreakInline).Reverse().Select(i => i is LiteralInline l ? l.Content.ToString() : "\n"));
            var match = Regex.Match(literalTail, @"(?:^|\s)\^[A-Za-z0-9-]+(?:\s+\^[A-Za-z0-9-]+)*\s*$");
            if (!match.Success) continue;
            var ids = Regex.Matches(match.Value, @"\^([A-Za-z0-9-]+)").Select(m => m.Groups[1].Value).ToArray();
            var standalone = text.Trim() == match.Value.Trim();
            Block owner = paragraph;
            if (standalone && paragraph.Parent is { } parent)
            {
                var index = parent.IndexOf(paragraph);
                if (index > 0) { owner = parent[index - 1]; parent.RemoveAt(index); }
            }
            else
            {
                // Literal runs may be split at '^' by another Markdown parser.
                var remaining = match.Length;
                foreach (var inline in paragraph.Inline.Reverse().ToArray())
                {
                    if (remaining == 0) break;
                    if (inline is LineBreakInline) { inline.Remove(); remaining--; }
                    else if (inline is LiteralInline literal)
                    {
                        if (literal.Content.Length <= remaining) { remaining -= literal.Content.Length; literal.Remove(); }
                        else { literal.Content = new StringSlice(literal.Content.ToString()[..^remaining]); remaining = 0; }
                    }
                    else break;
                }
            }
            var newIds = ids.Where(id => result.TryAdd(id, owner)).ToArray();
            if (newIds.Length > 0 && owner.Parent is { } container)
            {
                // Several Atlas anchors may name one passage. Give each a real target
                // without overwriting that passage's own heading ID.
                var html = string.Join("\n", newIds.Select(id => $"<div class=\"block-anchor\" id=\"{prefix}{id}\" aria-hidden=\"true\"></div>"));
                var anchorDocument = Parse(html);
                var anchor = anchorDocument[0];
                anchorDocument.RemoveAt(0);
                container.Insert(container.IndexOf(owner), anchor);
            }
        }
        return result;
    }
}
