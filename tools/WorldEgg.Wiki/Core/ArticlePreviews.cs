using Markdig.Syntax;

namespace WorldEgg.Wiki.Core;

public sealed record ArticlePreview(WikiDocument Document, string Excerpt, string Href, string? Section);

public sealed class ArticlePreviews(VaultCatalogue catalogue)
{
    public ArticlePreview? Get(string id, string? fragment)
    {
        if (!catalogue.Current.Documents.TryGetValue(id, out var source)) return null;
        var ast = MarkdownSupport.Parse(source.Body);
        var blocks = MarkdownSupport.AttachBlockIds(ast);
        Block? selected = null; string? section = null;
        var end = int.MaxValue;
        if (!string.IsNullOrEmpty(fragment))
        {
            if (fragment.StartsWith('^') || blocks.ContainsKey(fragment)) blocks.TryGetValue(fragment.TrimStart('^'), out selected);
            else
            {
                var headings = ast.Descendants<HeadingBlock>().ToArray();
                selected = headings.FirstOrDefault(h => Markdig.Renderers.Html.HtmlAttributesExtensions.GetAttributes(h).Id == fragment || MarkdownSupport.HeadingText(h).Equals(fragment, StringComparison.OrdinalIgnoreCase));
                if (selected is HeadingBlock heading)
                {
                    section = MarkdownSupport.HeadingText(heading);
                    end = headings.FirstOrDefault(h => h.Span.Start > heading.Span.Start && h.Level <= heading.Level)?.Span.Start ?? int.MaxValue;
                }
            }
            if (selected is null) return null;
        }
        var start = selected?.Span.Start ?? 0;
        if (selected is not null and not HeadingBlock) end = selected.Span.End + 1;
        IEnumerable<ParagraphBlock> paragraphs = selected is ParagraphBlock paragraph ? [paragraph] : ast.Descendants<ParagraphBlock>().Where(p => p.Span.Start >= start && p.Span.Start < end);
        var text = string.Join("\n\n", paragraphs.Select(p => MarkdownSupport.Plain(p.Inline).Trim()).Where(t => t.Length > 0 && !t.StartsWith("[!", StringComparison.Ordinal)).Take(2));
        if (text.Length > 520) { var stop = text.LastIndexOf(' ', 520); text = text[..(stop > 350 ? stop : 520)] + "…"; }
        if (text.Length == 0) text = "This passage has no prose excerpt. Open the source to read its table, image or other material.";
        var anchor = fragment?.TrimStart('^');
        if (section is not null) anchor = MarkdownSupport.GetHeadings(source).FirstOrDefault(h => h.Text == section)?.Id ?? anchor;
        return new(source, text, LinkResolver.PageUrl(source.Id) + (string.IsNullOrEmpty(anchor) ? "" : "#" + Uri.EscapeDataString(anchor)), section);
    }
}