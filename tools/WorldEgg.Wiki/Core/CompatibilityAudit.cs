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