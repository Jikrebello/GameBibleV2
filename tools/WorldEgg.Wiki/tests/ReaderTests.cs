using System.Security.Cryptography;
using WorldEgg.Wiki.Core;
using Xunit;

namespace WorldEgg.Wiki.Tests;

public sealed class ReaderTests
{
    [Fact] public async Task Metadata_aliases_and_accents_are_preserved()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        Assert.Contains(vault.Catalogue.FindTitles("attar"), d => d.Title == "Ättar & Oaths");
        Assert.Single(vault.Catalogue.FindTitles("The Hill Folk"));
        Assert.Equal(2, vault.Catalogue.FindTitles("version").Count());
    }
    [Fact] public async Task Ambiguity_never_silently_selects_an_archive()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        Assert.Equal(LinkState.Ambiguous, vault.Links.Resolve("Shared", FixtureVault.Source).State);
        Assert.Equal(LinkState.Found, vault.Links.Resolve("01 Canon Reference/Other/Shared", FixtureVault.Source).State);
        vault.Write("01 Canon Reference/Test/Shared.md", "# Local source"); await vault.Catalogue.RefreshAsync();
        Assert.Equal("01 Canon Reference/Test/Shared.md", vault.Links.Resolve("Shared", FixtureVault.Source).Id);
    }
    [Fact] public async Task Explicit_missing_paths_do_not_fall_back_to_unrelated_names()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        Assert.Equal(LinkState.Missing, vault.Links.Resolve("missing/Shared.md", FixtureVault.Source).State);
    }
    [Theory]
    [InlineData("javascript:alert(1)")]
    [InlineData("data:text/html,secret")]
    [InlineData("../../.git/config")]
    [InlineData("../../../../outside.md")]
    [InlineData("C:/Windows/win.ini")]
    public async Task Unsafe_targets_are_blocked(string target)
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        Assert.Equal(LinkState.Blocked, vault.Links.Resolve(target, FixtureVault.Source).State);
    }
    [Fact] public async Task Aliases_headings_block_ids_and_unicode_paths_work()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        var result = vault.Links.Resolve("The Hill Folk#A difficult promise", FixtureVault.Source);
        Assert.EndsWith("#a-difficult-promise", vault.Links.Href(result, FixtureVault.Source));
        Assert.Contains("%C3%84ttar", vault.Links.Href(result, FixtureVault.Source));
        var block = vault.Links.Resolve("Ättar & Oaths#^garden-g01", FixtureVault.Source);
        Assert.EndsWith("#garden-g01", vault.Links.Href(block, FixtureVault.Source));
        var rendered = vault.Renderer.Render(vault.Catalogue.Current.Documents[block.Id!]);
        Assert.Contains("id=\"garden-g01\"", rendered.Html);
        Assert.DoesNotContain("^garden-g01", rendered.Html);
    }
    [Fact] public async Task Absolute_vault_paths_and_relative_images_work()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        var absolute = Path.Combine(vault.Root, FixtureVault.Source).Replace('\\', '/');
        Assert.Equal(FixtureVault.Source, vault.Links.Resolve(absolute + ":57", FixtureVault.Source).Id);
        var result = await vault.Render("![A map](attachments/map.svg)");
        Assert.Contains("<img", result.Html); Assert.Contains("/asset?path=", result.Html);
    }
    [Fact] public async Task Markdown_tables_callouts_diagrams_and_footnotes_render()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        var result = await vault.Render("| Name | Tale |\n|---|---|\n| One | A bowl |\n\n> [!warning]+ A dangerous gift\n> Do not leave it behind.\n\n```mermaid\nflowchart LR\n A --> B\n```\n\nA witness.[^1]\n\n[^1]: A later account.");
        Assert.Contains("<table", result.Html); Assert.Contains("<details", result.Html); Assert.Contains("A dangerous gift", result.Html); Assert.Contains("Do not leave it behind.", result.Html);
        Assert.Contains("class=\"mermaid\"", result.Html); Assert.DoesNotContain("[!warning]", result.Html); Assert.Contains("A later account.", result.Html);
    }
    [Fact] public async Task Code_is_not_rewritten_as_links_or_embeds()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        var result = await vault.Render("`[[Missing]]`\n\n```text\n![[Shared]]\n```\n\n`^example-id`");
        Assert.Empty(result.Issues); Assert.Contains("[[Missing]]", result.Html); Assert.Contains("![[Shared]]", result.Html);
        Assert.Contains("^example-id", result.Html);
    }
    [Fact] public async Task Embeds_support_sections_blocks_and_cycle_boundaries()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        var section = await vault.Render("![[Ättar & Oaths#A difficult promise]]");
        Assert.Contains("broken bowl", section.Html); Assert.DoesNotContain("The remainder.", section.Html);
        var block = await vault.Render("![[Ättar & Oaths#^garden-g01]]");
        Assert.Contains("broken bowl", block.Html);
        var cycle = await vault.Render("![[Source]]"); Assert.Contains(cycle.Issues, x => x.Kind == "cycle");
    }
    [Fact] public async Task Bases_mount_collection_components_not_configuration_dumps()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        var result = await vault.Render("![[Test.base]]");
        Assert.Contains("data-base-id=", result.Html); Assert.DoesNotContain("filters:", result.Html);
    }
    [Fact] public async Task Missing_heading_does_not_hide_a_working_article()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        var result = await vault.Render("[[Ättar & Oaths#An unwritten ending|The ending]]");
        Assert.Contains(result.Issues, i => i.Kind == "missing-anchor"); Assert.Contains("The ending</a>", result.Html);
    }
    [Fact] public async Task Inline_block_ids_and_table_image_sizes_work()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        var result = await vault.Render("A **broken** bowl. ^bowl-id\n\n| A map |\n|---|\n| ![[map.svg\\|220]] |");
        Assert.Contains("id=\"bowl-id\"", result.Html); Assert.DoesNotContain("^bowl-id", result.Html);
        Assert.Contains("width=\"220\"", result.Html); Assert.DoesNotContain("missing-link", result.Html);
    }
    [Fact] public async Task Nested_embeds_have_a_finite_limit()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        for (var i = 1; i <= 6; i++) vault.Write($"01 Canon Reference/Test/Layer{i}.md", $"# Layer {i}\n\n![[Layer{i + 1}]]");
        var result = await vault.Render("![[Layer1]]");
        Assert.Contains(result.Issues, i => i.Kind == "limit");
    }
    [Theory]
    [InlineData("One shared passage.\n^atlas-first\n^atlas-second")]
    [InlineData("One shared passage.\n\n^atlas-first\n^atlas-second")]
    [InlineData("## A named passage\n\n^atlas-first\n\n^atlas-second")]
    public async Task Several_anchors_can_name_the_same_passage(string body)
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        var rendered = await vault.Render(body);
        Assert.Contains("id=\"atlas-first\"", rendered.Html); Assert.Contains("id=\"atlas-second\"", rendered.Html);
        Assert.DoesNotContain("^atlas-first", rendered.Html); Assert.DoesNotContain("^atlas-second", rendered.Html);
        if (body.StartsWith("##")) Assert.Contains("id=\"a-named-passage\"", rendered.Html);
    }
    [Fact] public async Task Source_html_cannot_execute_or_fetch_remote_images()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        var result = await vault.Render("<script>alert(1)</script>\n\n<img src=\"x\" onerror=\"alert(2)\">\n\n<a href=\"javascript:alert(3)\">unsafe</a>\n\n![remote](https://example.org/tracker.png)");
        Assert.DoesNotContain("<script", result.Html); Assert.DoesNotContain("onerror", result.Html); Assert.DoesNotContain("javascript:", result.Html);
        Assert.DoesNotContain("src=\"https://", result.Html); Assert.Contains("External image not loaded", result.Html);
    }
    [Fact] public async Task Bad_metadata_and_missing_attachments_do_not_break_reading()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        vault.Write("01 Canon Reference/Test/Bad.md", "---\naliases: [broken\n---\n# Still readable\n\nThe story survives."); await vault.Catalogue.RefreshAsync();
        var doc = vault.Catalogue.Current.Documents["01 Canon Reference/Test/Bad.md"];
        Assert.NotNull(doc.Error); Assert.Contains("The story survives.", vault.Renderer.Render(doc).Html);
        var missing = await vault.Render("![[missing.png]]"); Assert.Contains("Missing or ambiguous embed", missing.Html);
    }
    [Fact] public async Task Reading_never_changes_source_bytes()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        var before = vault.Paths.EnumerateFiles().ToDictionary(f => f, f => Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(f))));
        foreach (var document in vault.Catalogue.Current.Documents.Values) vault.Renderer.Render(document);
        await vault.Catalogue.RefreshAsync();
        foreach (var pair in before) Assert.Equal(pair.Value, Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(pair.Key))));
    }
    [Fact] public async Task Watcher_handles_edits_additions_renames_and_deletions()
    {
        await using var vault = new FixtureVault(); await vault.Seed(); await vault.Catalogue.StartAsync(CancellationToken.None);
        await Task.Delay(100);
        vault.Write("01 Canon Reference/Test/New.md", "# New witness");
        await Eventually(() => vault.Catalogue.Current.Documents.ContainsKey("01 Canon Reference/Test/New.md"));
        vault.Write("01 Canon Reference/Test/New.md", "# A changed witness\n\nA different account.");
        await Eventually(() => vault.Catalogue.Current.Documents["01 Canon Reference/Test/New.md"].Title == "A changed witness");
        File.Move(Path.Combine(vault.Root, "01 Canon Reference/Test/New.md"), Path.Combine(vault.Root, "01 Canon Reference/Test/Moved.md"));
        await Eventually(() => vault.Catalogue.Current.Documents.ContainsKey("01 Canon Reference/Test/Moved.md") && !vault.Catalogue.Current.Documents.ContainsKey("01 Canon Reference/Test/New.md"));
        File.Delete(Path.Combine(vault.Root, "01 Canon Reference/Test/Moved.md"));
        await Eventually(() => !vault.Catalogue.Current.Documents.ContainsKey("01 Canon Reference/Test/Moved.md"));
    }
    private static async Task Eventually(Func<bool> condition)
    {
        var until = DateTime.UtcNow.AddSeconds(8);
        while (!condition() && DateTime.UtcNow < until) await Task.Delay(100);
        Assert.True(condition(), "The catalogue did not update within eight seconds.");
    }
}
