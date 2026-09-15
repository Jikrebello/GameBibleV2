using System.Diagnostics;
using System.Security.Cryptography;
using System.Text.Json;

namespace WorldEgg.Wiki.Core;

public static class CompatibilityAudit
{
    public static async Task<string> RunAsync(VaultPaths paths, VaultCatalogue catalogue, ArticleRenderer renderer, LibraryIndex index, BaseLibrary bases)
    {
        var clock = Stopwatch.StartNew();
        var before = Fingerprints(paths);
        var derived = index.Current;
        var canonEntries = derived.Entries.Where(e => e.Document.Id.StartsWith("01 Canon Reference/", StringComparison.OrdinalIgnoreCase)).ToArray();
        var canonIds = canonEntries.Select(e => e.Document.Id).ToHashSet(StringComparer.OrdinalIgnoreCase);
        static string Visibility(LibraryEntry entry) => entry.Document.Metadata.GetValueOrDefault("visibility", ["unspecified"]).FirstOrDefault() ?? "unspecified";
        static int WordCount(LibraryEntry entry) => LibraryIndex.Tokens(entry.Text).Count();
        int CanonOutgoing(LibraryEntry entry) => (derived.Outgoing.GetValueOrDefault(entry.Document.Id) ?? []).Count(canonIds.Contains);
        int CanonIncoming(LibraryEntry entry) => (derived.Incoming.GetValueOrDefault(entry.Document.Id) ?? []).Count(canonIds.Contains);
        var readerEntries = canonEntries.Where(e => Visibility(e) is "public" or "restricted" or "secret").ToArray();
        var readerLengths = readerEntries.Select(e => new { e.Document.Id, Words = WordCount(e), Links = CanonOutgoing(e), Backlinks = CanonIncoming(e) }).OrderByDescending(e => e.Words).ToArray();
        var collections = catalogue.Current.Bases.Values.OrderBy(b => b.Id).Select(b => new { b.Id, Warnings = bases.Definition(b).Warnings, Views = bases.Definition(b).Views.Select(v => { var result = bases.Read(b.Id, v.Name); return new { v.Name, Rows = result.Rows.Length, v.Columns, v.Sort, v.Group, result.Warnings }; }).ToArray() }).ToArray();
        var samples = new List<double>();
        var queries = new[] { "Atherian", "Ättar", "Great Unbinding", "Glass", "\"broken bowl\"", "Saint", "Grenzburg", "repentance", "World Historical Atlas", "companion" };
        foreach (var query in queries) index.Search(query);
        for (var n = 0; n < 20; n++) foreach (var query in queries) { var timer = Stopwatch.StartNew(); index.Search(query); samples.Add(timer.Elapsed.TotalMilliseconds); }
        var pages = new List<AuditPage>();
        foreach (var document in catalogue.Current.Documents.Values.OrderBy(d => d.Id))
        {
            try
            {
                var rendered = renderer.Render(document);
                pages.Add(new(document.Id, document.Error, rendered.Issues.Distinct().ToArray(), null));
            }
            catch (Exception ex) { pages.Add(new(document.Id, document.Error, [], ex.ToString())); }
        }
        var after = Fingerprints(paths);
        var changed = before.Keys.Union(after.Keys).Where(key => before.GetValueOrDefault(key) != after.GetValueOrDefault(key)).ToArray();
        var report = new
        {
            GeneratedUtc = DateTime.UtcNow,
            Pass = 3,
            Articles = pages.Count,
            Attachments = catalogue.Current.Assets.Count,
            FatalReaderErrors = pages.Count(p => p.Fatal is not null),
            MetadataWarnings = pages.Count(p => p.MetadataWarning is not null),
            IssuesByKind = pages.SelectMany(p => p.Issues).GroupBy(i => i.Kind).ToDictionary(g => g.Key, g => g.Count()),
            SourceFilesHashed = before.Count,
            SourceFilesChangedDuringAudit = changed,
            CatalogueErrors = catalogue.Current.Errors,
            CatalogueMilliseconds = catalogue.LastRefreshMilliseconds,
            DerivedIndexMilliseconds = derived.BuildMilliseconds,
            Search = new { Samples = samples.Count, MedianMilliseconds = samples.Order().ElementAt(samples.Count / 2), P95Milliseconds = samples.Order().ElementAt((int)(samples.Count * .95)), MaximumMilliseconds = samples.Max(), TargetMilliseconds = 300 },
            ResolvedArticleEdges = derived.Outgoing.Values.Sum(v => v.Length),
            CanonUsability = new
            {
                Articles = canonEntries.Length,
                ReaderFacingArticles = readerEntries.Length,
                Visibility = canonEntries.GroupBy(Visibility).OrderBy(g => g.Key).ToDictionary(g => g.Key, g => g.Count()),
                MedianReaderWords = readerLengths.Length == 0 ? 0 : readerLengths.OrderBy(e => e.Words).ElementAt(readerLengths.Length / 2).Words,
                ReaderArticlesOver3000Words = readerLengths.Count(e => e.Words > 3000),
                ReaderArticlesOver6000Words = readerLengths.Count(e => e.Words > 6000),
                LongestReaderArticles = readerLengths.Take(15),
                ReaderArticlesAtLeast400WordsWithFewerThan4CanonLinks = readerLengths.Where(e => e.Words >= 400 && e.Links < 4).Select(e => new { e.Id, e.Words, e.Links }).ToArray(),
                ReaderArticlesWithoutCanonBacklinks = readerLengths.Where(e => e.Backlinks == 0).Select(e => e.Id).Order().ToArray()
            },
            IndexIssuesByKind = derived.Issues.GroupBy(i => i.Kind).ToDictionary(g => g.Key, g => g.Count()),
            IndexIssues = derived.Issues,
            Collections = collections,
            ElapsedSeconds = Math.Round(clock.Elapsed.TotalSeconds, 2),
            Pages = pages
        };
        return await Task.FromResult(JsonSerializer.Serialize(report, new JsonSerializerOptions { WriteIndented = true }));
    }

    private static Dictionary<string, string> Fingerprints(VaultPaths paths) => paths.EnumerateFiles().ToDictionary(f => paths.ToId(f)!, f => Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(f))), StringComparer.OrdinalIgnoreCase);

    private sealed record AuditPage(string Id, string? MetadataWarning, RenderIssue[] Issues, string? Fatal);
}
