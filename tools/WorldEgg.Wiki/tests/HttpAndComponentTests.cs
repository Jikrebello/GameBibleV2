using Bunit;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using WorldEgg.Wiki.Components;
using WorldEgg.Wiki.Core;
using WorldEgg.Wiki.Components.Pages;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using Xunit;

namespace WorldEgg.Wiki.Tests;

public sealed class HttpAndComponentTests
{
    private static string AppRoot()
    {
        var folder = new DirectoryInfo(AppContext.BaseDirectory);
        while (folder is not null && !File.Exists(Path.Combine(folder.FullName, "WorldEgg.Wiki.csproj"))) folder = folder.Parent;
        return folder?.FullName ?? throw new InvalidOperationException("Application root not found");
    }
    [Fact] public async Task Real_http_routes_render_and_reject_forbidden_assets()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        await using var factory = new WebApplicationFactory<Program>().WithWebHostBuilder(b => b.UseContentRoot(AppRoot()).UseEnvironment("Production").UseSetting("Wiki:VaultRoot", vault.Root));
        using var client = factory.CreateClient();
        foreach (var route in new[] { "/", "/browse", "/find?q=attar", "/reading-list", LinkResolver.PageUrl(FixtureVault.Source), "/resolve?target=Shared&from=" + Uri.EscapeDataString(FixtureVault.Source), "/health", "/wiki.css", "/wiki.js", "/reading.css", "/reading-core.js", "/reading.js", "/vendor/mermaid.min.js", "/_content/MudBlazor/MudBlazor.min.css", "/_content/MudBlazor/MudBlazor.min.js", "/_framework/blazor.web.js" })
        {
            var response = await client.GetAsync(route); Assert.True(response.IsSuccessStatusCode, route + ": " + response.StatusCode);
        }
        var article = await client.GetStringAsync(LinkResolver.PageUrl(FixtureVault.Source));
        Assert.Contains("An ordinary beginning.", article); Assert.Contains("Open in Obsidian", article); Assert.DoesNotContain("This page could not be displayed", article);
        foreach (var (route, text) in new[] { ("/find?q=broken%20bowl", "carried the broken bowl"), ("/articles?letter=A", "Articles A–Z"), ("/collections", "Saved Base collections"), ("/maintenance", "Read-only diagnostics"), (LinkResolver.BaseUrl("00 Start Here/Bases/Test.base"), "Read-only collection") })
        { var html = await client.GetStringAsync(route); Assert.Contains(text, System.Net.WebUtility.HtmlDecode(html)); Assert.DoesNotContain("This page could not be displayed", html); }
        var asset = await client.GetAsync(LinkResolver.AssetUrl("01 Canon Reference/Test/attachments/map.svg"));
        Assert.True(asset.IsSuccessStatusCode); Assert.Contains("sandbox", asset.Headers.GetValues("Content-Security-Policy").Single());
        foreach (var path in new[] { "../.git/config", FixtureVault.Source, "C:/Windows/win.ini", "00 Start Here/Bases/Test.base" })
            Assert.Equal(System.Net.HttpStatusCode.NotFound, (await client.GetAsync(LinkResolver.AssetUrl(path))).StatusCode);
        using var request = new HttpRequestMessage(HttpMethod.Get, "/health"); request.Headers.Host = "hostile.example";
        var rejected = await client.SendAsync(request); Assert.False(rejected.IsSuccessStatusCode);
        using var crossSite = new HttpRequestMessage(HttpMethod.Get, "/health"); crossSite.Headers.Add("Origin", "https://hostile.example");
        Assert.Equal(System.Net.HttpStatusCode.Forbidden, (await client.SendAsync(crossSite)).StatusCode);
    }
    [Fact] public async Task Source_label_component_keeps_archive_and_declared_status_separate()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        using var context = new BunitContext();
        var rendered = context.Render<DocumentLabels>(p => p.Add(c => c.Document, vault.Catalogue.Current.Documents["90 Archive & Drafts/Past/Shared.md"]));
        Assert.Contains("Archive / draft location", rendered.Markup); Assert.Contains("Status in source: canon", rendered.Markup);
    }
    [Fact] public async Task Open_article_waits_for_reader_before_replacing_changed_text()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        using var context = new BunitContext();
        context.Services.AddSingleton(vault.Catalogue); context.Services.AddSingleton(vault.Renderer); context.Services.AddSingleton(vault.Paths);
        context.Services.AddSingleton(vault.Links); context.Services.AddSingleton<BaseLibrary>(); context.Services.AddSingleton<LibraryIndex>();
        context.Services.AddScoped<ReadingLibrary>(); context.Services.AddSingleton<ArticlePreviews>();
        context.Services.AddMudServices(); context.JSInterop.Mode = JSRuntimeMode.Loose;
        context.Services.GetRequiredService<Microsoft.AspNetCore.Components.NavigationManager>().NavigateTo(LinkResolver.PageUrl(FixtureVault.Source));
        var rendered = context.Render<Read>();
        Assert.Contains("An ordinary beginning.", rendered.Markup);
        vault.Write(FixtureVault.Source, "# A later telling\n\nThe ending changed."); await vault.Catalogue.RefreshAsync();
        rendered.WaitForAssertion(() => Assert.Contains("The vault has changed.", rendered.Markup));
        Assert.Contains("An ordinary beginning.", rendered.Markup); Assert.DoesNotContain("The ending changed.", rendered.Markup);
        rendered.Find("button").Click();
        rendered.WaitForAssertion(() => Assert.Contains("The ending changed.", rendered.Markup));
    }
}
