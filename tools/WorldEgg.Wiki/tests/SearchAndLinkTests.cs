using WorldEgg.Wiki.Core;
using Xunit;

namespace WorldEgg.Wiki.Tests;

public sealed class SearchAndLinkTests
{
    [Fact] public async Task Search_ranks_names_above_headings_and_bodies_with_accents_and_phrases()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        vault.Write("99 Templates/Example.md", "# A template\n\nA broken bowl survives here too. Ättar & Oaths.");
        vault.Write("90 Archive & Drafts/Alias.md", "---\naliases: [broken bowl]\n---\n# An old working name\n\nA discarded account.");
        vault.Write("01 Canon Reference/Test/Heading.md", "# A witness\n\n## Broken bowl\n\nThe household rebuilt.");
        await vault.Catalogue.RefreshAsync();
        using var index = new LibraryIndex(vault.Catalogue, vault.Links, new(vault.Catalogue));
        Assert.Equal("Ättar & Oaths", index.Search("attar & oaths").Hits[0].Document.Title);
        Assert.Equal("An old working name", index.Search("broken bowl").Hits[0].Document.Title);
        Assert.Equal("A witness", index.Search("broken bowl").Hits[1].Document.Title);
        Assert.Contains(index.Search("\"broken bowl\"").Hits, h => h.Document.Id.StartsWith("99 Templates/"));
        Assert.Contains(index.Search("broken bowl").Hits, h => h.Document.Archived);
        Assert.Equal(0, index.Search("\"bowl broken\"").Total);
        Assert.Single(index.Search("broken bowl", new Dictionary<string, string> { ["area"] = "99 Templates" }).Hits);
        Assert.Contains("bowl", index.Search("broken bowl").Hits.Last().Snippet, StringComparison.OrdinalIgnoreCase);
    }
    [Fact] public async Task All_six_filters_use_source_values_and_do_not_infer_missing_fields()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        vault.Write("01 Canon Reference/Test/Filtered.md", "---\ntype: myth\nstatus: disputed\nera: Long Frontier\nregion: [North, South]\nculture: [Ättar, Folk]\n---\n# Hearth tale\n\nThe bowl survived.");
        await vault.Catalogue.RefreshAsync(); using var index = new LibraryIndex(vault.Catalogue, vault.Links, new(vault.Catalogue));
        var filters = new Dictionary<string, string> { ["area"] = "01 Canon Reference", ["type"] = "myth", ["status"] = "disputed", ["era"] = "Long Frontier", ["region"] = "south", ["culture"] = "ATTAR" };
        Assert.Equal("Hearth tale", Assert.Single(index.Search("bowl", filters).Hits).Document.Title);
        Assert.Contains("North", index.Facet("region")); filters["region"] = "West"; Assert.Empty(index.Search("bowl", filters).Hits);
    }
    [Fact] public async Task Graph_includes_explicit_metadata_but_not_ambiguous_missing_code_or_guessed_relationships()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        vault.Write(FixtureVault.Source, "---\nrelated: ['[[The Hill Folk]]']\nculture: A current version\n---\n# Links\n\n[[Shared]] [[Missing]] [[Ättar & Oaths#No such heading]]\n\n`[[Hidden in code]]`\n\n[Unsafe](javascript:alert)\n\n[This note](#links)");
        await vault.Catalogue.RefreshAsync(); using var index = new LibraryIndex(vault.Catalogue, vault.Links, new(vault.Catalogue));
        var graph = index.Current;
        Assert.Equal(new[] { "01 Canon Reference/Test/Ättar & Oaths.md" }, graph.Outgoing[FixtureVault.Source]);
        Assert.Contains(FixtureVault.Source, graph.Incoming["01 Canon Reference/Test/Ättar & Oaths.md"]);
        Assert.Contains(graph.Issues, i => i.Kind == "ambiguous" && i.Target == "Shared");
        Assert.Contains(graph.Issues, i => i.Kind == "missing" && i.Target == "Missing");
        Assert.Contains(graph.Issues, i => i.Kind == "missing-anchor"); Assert.Contains(graph.Issues, i => i.Kind == "blocked");
        Assert.DoesNotContain(graph.Issues, i => i.Target.Contains("Hidden in code"));
    }
    [Fact] public async Task Refresh_rebuilds_search_links_and_bases_after_edits_renames_and_deletes()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        var id = "01 Canon Reference/Remote/Unique.md";
        vault.Write(id, "---\nstatus: canon\n---\n# Unique\n\nA zebra arrives.");
        vault.Write(FixtureVault.Source, "# Witness\n\n[[Unique]]");
        var baseId = "00 Start Here/Bases/Changing.base";
        vault.Write(baseId, "filters: 'status == \"canon\"'\nviews:\n  - type: table\n    name: Canon\n    order: [file.name]");
        await vault.Catalogue.RefreshAsync(); var bases = new BaseLibrary(vault.Catalogue); using var index = new LibraryIndex(vault.Catalogue, vault.Links, bases);
        Assert.Single(index.Search("zebra").Hits); Assert.Contains(id, index.Current.Outgoing[FixtureVault.Source]); Assert.Contains(bases.Read(baseId).Rows, r => r.Id == id);
        vault.Write("90 Archive & Drafts/Unique.md", "# Other Unique\n\nAnother zebra."); await vault.Catalogue.RefreshAsync();
        Assert.Equal(2, index.Search("zebra").Total); Assert.False(index.Current.Outgoing.ContainsKey(FixtureVault.Source));
        vault.Write(id, "---\nstatus: draft\n---\n# Unique\n\nAn otter stays."); await vault.Catalogue.RefreshAsync();
        Assert.Single(index.Search("otter").Hits); Assert.DoesNotContain(bases.Read(baseId).Rows, r => r.Id == id);
        File.Move(Path.Combine(vault.Root, id), Path.Combine(vault.Root, "01 Canon Reference/Remote/Renamed.md"));
        File.Delete(Path.Combine(vault.Root, "90 Archive & Drafts/Unique.md")); await vault.Catalogue.RefreshAsync();
        Assert.Empty(index.Search("zebra").Hits); Assert.EndsWith("Renamed.md", index.Search("otter").Hits[0].Document.Id);
        Assert.Contains(index.Current.Issues, i => i.Target == "Unique" && i.Kind == "missing");
        vault.Write(baseId, "filters: 'status == \"draft\"'\nviews:\n  - type: table\n    name: Drafts"); await vault.Catalogue.RefreshAsync();
        Assert.Contains(bases.Read(baseId).Rows, r => r.Id.EndsWith("Renamed.md"));
        File.Delete(Path.Combine(vault.Root, baseId)); await vault.Catalogue.RefreshAsync(); Assert.NotEmpty(bases.Read(baseId).Warnings);
    }
    [Fact] public async Task File_watcher_publishes_search_and_relationship_changes_without_manual_refresh()
    {
        await using var vault = new FixtureVault(); await vault.Seed(); using var index = new LibraryIndex(vault.Catalogue, vault.Links, new(vault.Catalogue)); _ = index.Current;
        await vault.Catalogue.StartAsync(CancellationToken.None); await Task.Delay(100);
        vault.Write("01 Canon Reference/Test/Watcher.md", "# A new explorer\n\nA wombat follows [[The Hill Folk]].");
        var deadline = DateTime.UtcNow.AddSeconds(8);
        while (index.Search("wombat").Total != 1 && DateTime.UtcNow < deadline) await Task.Delay(100);
        Assert.Single(index.Search("wombat").Hits); Assert.Contains("01 Canon Reference/Test/Watcher.md", index.Current.Incoming["01 Canon Reference/Test/Ättar & Oaths.md"]);
    }
}
