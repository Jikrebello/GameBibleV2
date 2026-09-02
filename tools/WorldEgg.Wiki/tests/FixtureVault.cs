using Microsoft.Extensions.Logging.Abstractions;
using WorldEgg.Wiki.Core;
using Xunit;

[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace WorldEgg.Wiki.Tests;

public sealed class FixtureVault : IAsyncDisposable
{
    public const string Source = "01 Canon Reference/Test/Source.md";
    public string Root { get; } = Path.Combine(Path.GetTempPath(), "worldegg-tests-" + Guid.NewGuid().ToString("N"));
    public VaultPaths Paths { get; }
    public VaultCatalogue Catalogue { get; }
    public LinkResolver Links { get; }
    public ArticleRenderer Renderer { get; }
    public FixtureVault()
    {
        Directory.CreateDirectory(Root);
        foreach (var directory in VaultPaths.ContentRoots) Directory.CreateDirectory(Path.Combine(Root, directory));
        Paths = new(Root);
        Catalogue = new(Paths, NullLogger<VaultCatalogue>.Instance);
        Links = new(Paths, Catalogue);
        Renderer = new(Catalogue, Links);
    }
    public void Write(string id, string source)
    {
        var path = Path.Combine(Root, id);
        Directory.CreateDirectory(Path.GetDirectoryName(path)!);
        File.WriteAllText(path, source);
    }
    public async Task Seed()
    {
        Write(Source, "---\nstatus: canon\nvisibility: author-only\n---\n# A starting place\n\nAn ordinary beginning.");
        Write("01 Canon Reference/Other/Shared.md", "# A current version");
        Write("90 Archive & Drafts/Past/Shared.md", "---\nstatus: canon\n---\n# An archived version");
        Write("01 Canon Reference/Test/Ättar & Oaths.md", "---\naliases: [The Hill Folk]\n---\n# Ättar & Oaths\n\n## A difficult promise\n\nThey carried the broken bowl home.\n\n^garden-g01\n\n## Afterward\n\nThe remainder.");
        Write("01 Canon Reference/Test/attachments/map.svg", "<svg xmlns=\"http://www.w3.org/2000/svg\" viewBox=\"0 0 10 10\"><path d=\"M0 0L10 10\"/></svg>");
        Write("00 Start Here/Bases/Test.base", "filters: 'status == \"canon\"'\nviews: []");
        await Catalogue.RefreshAsync();
    }
    public async Task<RenderedArticle> Render(string body)
    {
        Write(Source, "# Test article\n\n" + body);
        await Catalogue.RefreshAsync();
        return Renderer.Render(Catalogue.Current.Documents[Source]);
    }
    public async ValueTask DisposeAsync()
    {
        await Catalogue.StopAsync(CancellationToken.None);
        Catalogue.Dispose();
        var full = Path.GetFullPath(Root);
        if (Path.GetDirectoryName(full) == Path.TrimEndingDirectorySeparator(Path.GetTempPath()) && Path.GetFileName(full).StartsWith("worldegg-tests-", StringComparison.Ordinal)) Directory.Delete(full, true);
    }
}
