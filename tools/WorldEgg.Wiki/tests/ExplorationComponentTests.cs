using Bunit;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using WorldEgg.Wiki.Components;
using WorldEgg.Wiki.Components.Pages;
using WorldEgg.Wiki.Core;
using Xunit;

namespace WorldEgg.Wiki.Tests;

public sealed class ExplorationComponentTests
{
    private static BunitContext Context(FixtureVault vault, string route = "/")
    {
        var context = new BunitContext(); context.JSInterop.Mode = JSRuntimeMode.Loose;
        context.Services.AddMudServices(); context.Services.AddSingleton(vault.Catalogue); context.Services.AddSingleton(vault.Links); context.Services.AddSingleton(vault.Paths); context.Services.AddSingleton(vault.Renderer); context.Services.AddSingleton<BaseLibrary>(); context.Services.AddSingleton<LibraryIndex>();
        context.Services.AddScoped<ReadingLibrary>(); context.Services.AddSingleton<ArticlePreviews>();
        context.Services.GetRequiredService<NavigationManager>().NavigateTo(route); return context;
    }
    [Fact] public async Task Collection_has_named_views_pagination_numeric_sort_and_live_refresh_without_writes()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        const string id = "00 Start Here/Bases/Numbers.base";
        vault.Write(id, "filters: 'count > 0'\nviews:\n - type: table\n   name: All numbers\n   order: [file.name, count]\n   sort: [{property: count, direction: ASC}]\n - type: table\n   name: High numbers\n   filters: 'count > 20'\n   order: [file.name, count]\n   sort: [{property: count, direction: DESC}]");
        for (var n = 1; n <= 27; n++) vault.Write($"01 Canon Reference/Test/Number{n:D2}.md", $"---\ncount: {n}\n---\n# Number {n}");
        await vault.Catalogue.RefreshAsync();
        var original = File.ReadAllText(Path.Combine(vault.Root, id)); using var context = Context(vault);
        var component = context.Render<BaseTable>(p => p.Add(c => c.Id, id));
        Assert.Equal(25, component.FindAll("tbody tr").Count); Assert.Contains("Number01.md", component.Find("tbody tr").TextContent);
        component.FindAll("button").Single(b => b.TextContent == "Next").Click(); Assert.Equal(2, component.FindAll("tbody tr").Count);
        component.Find("select").Change("High numbers"); Assert.Equal(7, component.FindAll("tbody tr").Count); Assert.Contains("Number27.md", component.Find("tbody tr").TextContent);
        component.FindAll("button.table-sort").Last().Click(); Assert.Contains("Number21.md", component.Find("tbody tr").TextContent);
        component.FindAll("button.table-sort").Last().Click(); Assert.Contains("Number27.md", component.Find("tbody tr").TextContent);
        component.FindAll("button").Single(b => b.TextContent == "Restore source order").Click(); Assert.Contains("Number27.md", component.Find("tbody tr").TextContent);
        Assert.Equal(original, File.ReadAllText(Path.Combine(vault.Root, id)));
        vault.Write("01 Canon Reference/Test/Number28.md", "---\ncount: 28\n---\n# Another number"); await vault.Catalogue.RefreshAsync();
        component.WaitForAssertion(() => Assert.Contains("Number28.md", component.Find("tbody tr").TextContent));
        File.Delete(Path.Combine(vault.Root, id)); await vault.Catalogue.RefreshAsync();
        component.WaitForAssertion(() => Assert.Contains("Collection not found", component.Markup));
    }
    [Fact] public async Task Embedded_base_mounts_a_real_table_inside_existing_article_markup()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        vault.Write("00 Start Here/Bases/Test.base", "filters: 'status == \"canon\"'\nviews:\n - type: table\n   name: Sources\n   order: [file.name, status]");
        vault.Write(FixtureVault.Source, "# Starting place\n\n- ![[Test.base]]\n\nAn ordinary ending.\n\n<script>evil()</script>"); await vault.Catalogue.RefreshAsync();
        using var context = Context(vault, LinkResolver.PageUrl(FixtureVault.Source)); var component = context.Render<Read>();
        Assert.Single(component.FindAll(".base-table")); Assert.NotEmpty(component.FindAll(".base-table tbody tr")); Assert.Contains("Sources", component.Find("select").TextContent);
        Assert.Contains("An ordinary ending.", component.Markup); Assert.DoesNotContain("<script", component.Markup); Assert.DoesNotContain("filters:", component.Markup);
        Assert.NotNull(component.Find("article ul li .base-table"));
    }
    [Fact] public async Task Search_filters_refresh_and_encode_source_excerpts()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        vault.Write("99 Templates/Bowl.md", "# Template bowl\n\nA broken bowl. `<script>evil()</script>`"); await vault.Catalogue.RefreshAsync();
        using var context = Context(vault, "/find?q=broken%20bowl&area=99%20Templates"); var component = context.Render<Find>();
        Assert.Single(component.FindAll(".article-list section")); Assert.Contains("Template bowl", component.Markup); Assert.DoesNotContain("<script>", component.Markup);
        var selection = component.Find("select[aria-label='Source area']"); Assert.Equal("99 Templates", selection.GetAttribute("value") ?? ((AngleSharp.Html.Dom.IHtmlSelectElement)selection).Value);
        vault.Write("99 Templates/Second.md", "# Another bowl\n\nThe broken bowl returns."); await vault.Catalogue.RefreshAsync();
        component.WaitForAssertion(() => Assert.Equal(2, component.FindAll(".article-list section").Count));
        component.Find("select[aria-label='Source area']").Change("01 Canon Reference"); component.Find("form").Submit();
        Assert.Contains("area=01%20Canon%20Reference", context.Services.GetRequiredService<NavigationManager>().Uri);
    }
    [Fact] public async Task Relationships_and_maintenance_keep_ambiguous_links_out_of_the_graph()
    {
        await using var vault = new FixtureVault(); await vault.Seed(); await vault.Render("[[The Hill Folk]] [[Shared]]");
        using var context = Context(vault, "/maintenance?kind=ambiguous");
        var related = context.Render<RelatedArticles>(p => p.Add(c => c.Id, FixtureVault.Source));
        Assert.Contains("Linked articles (1)", related.Markup); Assert.Contains("resolved links", related.Markup); Assert.Contains("unresolved or unsupported", related.Markup);
        var maintenance = context.Render<Maintenance>(); Assert.Contains("Shared", maintenance.Markup); Assert.Contains("Inspect reference", maintenance.Markup);
    }
    [Fact] public async Task Alphabetical_index_treats_accented_names_as_their_base_letter()
    {
        await using var vault = new FixtureVault(); await vault.Seed(); using var context = Context(vault, "/articles?letter=A");
        var component = context.Render<Articles>(); Assert.Contains("Ättar &amp; Oaths", component.Markup); Assert.Contains("An archived version", component.Markup);
    }
    [Fact] public async Task Collection_cells_resolve_explicit_wikilinks_without_guessing_ambiguous_destinations()
    {
        await using var vault = new FixtureVault(); await vault.Seed(); using var context = Context(vault);
        var value = new BaseValue(new[] { new BaseValue("[[The Hill Folk|Hill folk]]"), new BaseValue("[[Shared]]"), new BaseValue("<script>not markup</script>") });
        var component = context.Render<CollectionValue>(p => p.Add(c => c.Value, value).Add(c => c.SourceId, FixtureVault.Source));
        Assert.Equal(2, component.FindAll("a").Count); Assert.StartsWith("/wiki?", component.FindAll("a")[0].GetAttribute("href")); Assert.StartsWith("/resolve?", component.FindAll("a")[1].GetAttribute("href")); Assert.DoesNotContain("<script>", component.Markup);
    }
}
