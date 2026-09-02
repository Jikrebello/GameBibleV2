using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Markdig.Syntax;
using Markdig.Syntax.Inlines;

namespace WorldEgg.Wiki.Core;

public sealed record LibraryIssue(string Kind, string Source, string Target, string Detail);
public sealed record LibraryEntry(WikiDocument Document, string Text, string FoldedText, string[] Names, string Headings, string[] Tokens, string[] Targets, string[] Unsupported);
public sealed record LibrarySnapshot(CatalogueSnapshot Catalogue, LibraryEntry[] Entries, IReadOnlyDictionary<string, int[]> Terms,
    IReadOnlyDictionary<string, string[]> Outgoing, IReadOnlyDictionary<string, string[]> Incoming, LibraryIssue[] Issues, double BuildMilliseconds);
public sealed record SearchHit(WikiDocument Document, string Snippet, int Score);
public sealed record SearchPage(SearchHit[] Hits, int Total, int Page, int PageSize, double Milliseconds);

public sealed class LibraryIndex : IDisposable
{
    public static readonly string[] FilterFields = ["area", "type", "status", "era", "region", "culture"];
    private readonly VaultCatalogue _catalogue;
    private readonly LinkResolver _links;
    private readonly BaseLibrary _bases;
    private readonly object _gate = new();
    private readonly ConditionalWeakTable<WikiDocument, LibraryEntry> _entries = new();
    private LibrarySnapshot? _snapshot;
    public event Action? Changed;
    public LibraryIndex(VaultCatalogue catalogue, LinkResolver links, BaseLibrary bases)
    { _catalogue = catalogue; _links = links; _bases = bases; catalogue.Changed += Updated; }
    public LibrarySnapshot Current
    {
        get
        {
            var current = _catalogue.Current;
            lock (_gate)
            {
                if (_snapshot is null || _snapshot.Catalogue.Version != current.Version) _snapshot = Build(current);
                return _snapshot;
            }
        }
    }
    private void Updated() { _ = Current; Changed?.Invoke(); }
    public void Dispose() => _catalogue.Changed -= Updated;

    private LibrarySnapshot Build(CatalogueSnapshot catalogue)
    {
        var timer = Stopwatch.StartNew();
        var entries = catalogue.Documents.Values.OrderBy(d => d.Id, StringComparer.OrdinalIgnoreCase).Select(d => _entries.GetValue(d, SafeExtract)).ToArray();
        var terms = new Dictionary<string, List<int>>(StringComparer.Ordinal);
        var outgoing = new Dictionary<string, HashSet<string>>(StringComparer.OrdinalIgnoreCase);
        var incoming = new Dictionary<string, HashSet<string>>(StringComparer.OrdinalIgnoreCase);
        var issues = new List<LibraryIssue>();
        foreach (var error in catalogue.Errors) issues.Add(new("indexing", "", "", error));
        for (var i = 0; i < entries.Length; i++)
        {
            var entry = entries[i]; var id = entry.Document.Id;
            foreach (var token in entry.Tokens) { if (!terms.TryGetValue(token, out var list)) terms[token] = list = []; list.Add(i); }
            if (entry.Document.Error is { } error) issues.Add(new("metadata", id, "", error));
            foreach (var syntax in entry.Unsupported) issues.Add(new("unsupported", id, syntax, "This plugin syntax is displayed as source, not executed."));
            foreach (var target in entry.Targets)
            {
                var resolved = _links.Resolve(target, id, catalogue);
                if (resolved.State == LinkState.External) continue;
                if (resolved.State != LinkState.Found) { issues.Add(new(resolved.State.ToString().ToLowerInvariant(), id, target, resolved.State == LinkState.Ambiguous ? string.Join(" · ", resolved.Candidates) : "No resolved relationship is created.")); continue; }
                if (resolved.Id is not { } destination || !catalogue.Documents.TryGetValue(destination, out var document)) continue;
                if (resolved.Fragment.Length > 0 && !MarkdownSupport.GetAnchors(document).Contains(resolved.Fragment.TrimStart('^')))
                { issues.Add(new("missing-anchor", id, target, "The article exists, but the referenced section or block does not.")); continue; }
                if (destination.Equals(id, StringComparison.OrdinalIgnoreCase)) continue;
                if (!outgoing.TryGetValue(id, out var outSet)) outgoing[id] = outSet = new(StringComparer.OrdinalIgnoreCase);
                if (!incoming.TryGetValue(destination, out var inSet)) incoming[destination] = inSet = new(StringComparer.OrdinalIgnoreCase);
                outSet.Add(destination); inSet.Add(id);
            }
        }
        foreach (var source in catalogue.Bases.Values)
        {
            var definition = _bases.Definition(source);
            foreach (var warning in definition.Warnings) issues.Add(new("collection", source.Id, "", warning));
            foreach (var view in definition.Views)
                foreach (var warning in _bases.Read(source.Id, view.Name, catalogue).Warnings) issues.Add(new("collection", source.Id, view.Name, warning));
        }
        timer.Stop();
        return new(catalogue, entries, terms.ToDictionary(p => p.Key, p => p.Value.ToArray()), outgoing.ToDictionary(p => p.Key, p => p.Value.Order().ToArray(), StringComparer.OrdinalIgnoreCase), incoming.ToDictionary(p => p.Key, p => p.Value.Order().ToArray(), StringComparer.OrdinalIgnoreCase), issues.Distinct().OrderBy(i => i.Kind).ThenBy(i => i.Source).ToArray(), timer.Elapsed.TotalMilliseconds);
    }
    private static LibraryEntry Extract(WikiDocument document)
    {
        var ast = MarkdownSupport.Parse(document.Body);
        var text = Regex.Replace(string.Join("\n", ast.Descendants<LeafBlock>().Select(b => b.Inline is { } inline ? MarkdownSupport.Plain(inline) : b is HtmlBlock html ? new AngleSharp.Html.Parser.HtmlParser().ParseDocument(html.Lines.ToString()).Body?.TextContent ?? "" : b is CodeBlock code ? code.Lines.ToString() : "")), @"\s+", " ").Trim();
        var names = document.Aliases.Append(document.Title).Append(Path.GetFileNameWithoutExtension(document.Id)).Select(VaultCatalogue.Fold).Distinct().ToArray();
        var headings = VaultCatalogue.Fold(string.Join("\n", MarkdownSupport.GetHeadings(document).Select(h => h.Text)));
        var targets = ast.Descendants<WikiInline>().Select(w => w.Target).Concat(ast.Descendants<LinkInline>().Select(l => l.Url ?? ""))
            .Concat(document.Metadata.Values.SelectMany(v => v).SelectMany(v => Regex.Matches(v, @"\[\[([^\]|]+)(?:\|[^\]]+)?\]\]").Select(m => m.Groups[1].Value)))
            .Where(t => t.Length > 0).Distinct().ToArray();
        var unsupported = ast.Descendants<FencedCodeBlock>().Where(b => b.Info?.Trim() is "dataview" or "dataviewjs" or "base" or "tasks").Select(b => b.Info!).Distinct().ToArray();
        var folded = VaultCatalogue.Fold(text);
        return new(document, text, folded, names, headings, Tokens(string.Join(' ', names) + " " + headings + " " + folded).Distinct().ToArray(), targets, unsupported);
    }
    private static LibraryEntry SafeExtract(WikiDocument document)
    {
        try { return Extract(document); }
        catch (Exception ex) when (ex is not OutOfMemoryException)
        {
            var text = Regex.Replace(document.Body, @"\s+", " "); var folded = VaultCatalogue.Fold(text); var names = document.Aliases.Append(document.Title).Select(VaultCatalogue.Fold).ToArray();
            return new(document, text, folded, names, "", Tokens(folded + " " + string.Join(' ', names)).Distinct().ToArray(), [], ["Article indexing failed; searchable source text is retained. " + ex.Message]);
        }
    }
    public static IEnumerable<string> Tokens(string value) => Regex.Matches(value, @"[\p{L}\p{N}]+").Select(m => m.Value);
    public string[] Facet(string field) => Current.Entries.SelectMany(e => Values(e.Document, field)).Where(v => !string.IsNullOrWhiteSpace(v)).Distinct(StringComparer.OrdinalIgnoreCase).OrderBy(VaultCatalogue.Fold).ToArray();
    public static string[] Values(WikiDocument document, string field) => field == "area" ? [document.Area] : document.Metadata.GetValueOrDefault(field, []);
    public static bool Matches(WikiDocument document, IReadOnlyDictionary<string, string>? filters) => filters is null || filters.All(f => string.IsNullOrWhiteSpace(f.Value) || Values(document, f.Key).Any(v => VaultCatalogue.Fold(v) == VaultCatalogue.Fold(f.Value)));

    public SearchPage Search(string? query, IReadOnlyDictionary<string, string>? filters = null, int page = 1, int pageSize = 25)
    {
        var snapshot = Current; var timer = Stopwatch.StartNew();
        var q = VaultCatalogue.Fold((query ?? "").Trim());
        var phraseMatches = Regex.Matches(q, "\"([^\"]+)\"").Select(m => m.Groups[1].Value).ToArray();
        var words = Tokens(q).Distinct().ToArray(); var titleQuery = q.Trim('"');
        HashSet<int>? candidates = null;
        foreach (var word in words)
        {
            var matches = snapshot.Terms.GetValueOrDefault(word) ?? [];
            if (candidates is null) candidates = new(matches); else candidates.IntersectWith(matches);
        }
        if (candidates is null) candidates = q.Length == 0 ? new(Enumerable.Range(0, snapshot.Entries.Length)) : [];
        // Partial names remain findable, while body queries use the token index rather than a corpus scan.
        if (q.Length > 0) for (var i = 0; i < snapshot.Entries.Length; i++) if (snapshot.Entries[i].Names.Any(n => n.Contains(titleQuery, StringComparison.Ordinal))) candidates.Add(i);
        var found = candidates.Select(i => snapshot.Entries[i]).Where(e => Matches(e.Document, filters) && phraseMatches.All(p => e.FoldedText.Contains(p, StringComparison.Ordinal) || e.Names.Any(n => n.Contains(p, StringComparison.Ordinal))))
            .Select(e => (Entry: e, Score: Score(e, titleQuery, words))).OrderByDescending(x => x.Score).ThenBy(x => VaultCatalogue.Fold(x.Entry.Document.Title)).ThenBy(x => x.Entry.Document.Id).ToArray();
        pageSize = Math.Clamp(pageSize, 1, 100); page = Math.Clamp(page, 1, Math.Max(1, (found.Length + pageSize - 1) / pageSize));
        var hits = found.Skip((page - 1) * pageSize).Take(pageSize).Select(x => new SearchHit(x.Entry.Document, Snippet(x.Entry, words), x.Score)).ToArray();
        return new(hits, found.Length, page, pageSize, timer.Elapsed.TotalMilliseconds);
    }
    private static int Score(LibraryEntry entry, string q, string[] words)
    {
        if (q.Length == 0) return 0;
        var name = entry.Names.Max(n => n == q ? 10000 : n.StartsWith(q, StringComparison.Ordinal) ? 7000 : n.Contains(q, StringComparison.Ordinal) ? 5000 : 0);
        var heading = entry.Headings.Contains(q, StringComparison.Ordinal) ? 1500 : 0;
        return name + heading + Math.Min(400, words.Sum(w => entry.FoldedText.Contains(w, StringComparison.Ordinal) ? 10 : 0) + (entry.FoldedText.Contains(q, StringComparison.Ordinal) ? 100 : 0));
    }
    private static string Snippet(LibraryEntry entry, string[] words)
    {
        var position = words.Select(w => entry.FoldedText.IndexOf(w, StringComparison.Ordinal)).Where(i => i >= 0).DefaultIfEmpty(0).Min();
        var start = Math.Min(entry.Text.Length, Math.Max(0, position - 65)); var end = Math.Min(entry.Text.Length, start + 260);
        if (start > 0) { var space = entry.Text.IndexOf(' ', start); if (space >= 0 && space < end) start = space + 1; }
        return (start > 0 ? "…" : "") + entry.Text[start..end] + (end < entry.Text.Length ? "…" : "");
    }
}
