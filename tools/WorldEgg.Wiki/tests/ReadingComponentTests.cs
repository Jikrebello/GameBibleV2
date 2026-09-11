using Bunit;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using WorldEgg.Wiki.Components;
using WorldEgg.Wiki.Components.Layout;
using WorldEgg.Wiki.Components.Pages;
using WorldEgg.Wiki.Core;
using Xunit;

namespace WorldEgg.Wiki.Tests;

public sealed class ReadingComponentTests
{
    private static BunitContext Context(FixtureVault vault, string route = "/", ReadingSnapshot? saved = null)
    {
        var context = new BunitContext(); context.JSInterop.Mode = JSRuntimeMode.Loose;
        context.Services.AddMudServices(); context.Services.AddSingleton(vault.Catalogue); context.Services.AddSingleton(vault.Links); context.Services.AddSingleton(vault.Paths); context.Services.AddSingleton(vault.Renderer);
        context.Services.AddSingleton<BaseLibrary>(); context.Services.AddSingleton<LibraryIndex>(); context.Services.AddScoped<ReadingLibrary>(); context.Services.AddSingleton<ArticlePreviews>();
        context.Services.AddSingleton(new ReviewCommentStore(System.IO.Path.Combine(vault.Root, "review-comments.json"), vault.Catalogue));
        context.JSInterop.Setup<ReadingSnapshot?>("worldEgg.reading.load", _ => true).SetResult(saved ?? new());
        context.JSInterop.Setup<bool>("worldEgg.reading.save", _ => true).SetResult(true);
        context.Services.GetRequiredService<NavigationManager>().NavigateTo(route); return context;
    }
    [Fact] public async Task Preferences_are_loaded_once_clamped_saved_and_restored_in_a_new_circuit()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        using var context = Context(vault, saved: new() { Preferences = new() { Theme = "bad", TextSize = 99, Width = "impossible" } });
        var reading = context.Services.GetRequiredService<ReadingLibrary>(); await reading.InitializeAsync(); await reading.InitializeAsync();
        Assert.Equal("system", reading.Current.Preferences.Theme); Assert.Equal(24, reading.Current.Preferences.TextSize); Assert.Equal("standard", reading.Current.Preferences.Width);
        Assert.Single(context.JSInterop.Invocations["worldEgg.reading.load"]);
        await reading.SetPreferencesAsync(new() { Theme = "dark", TextSize = 21, Width = "wide", RestorePosition = true });
        var saved = (ReadingSnapshot)context.JSInterop.Invocations["worldEgg.reading.save"].Last().Arguments[1]!;
        using var reloaded = Context(vault, saved: saved); var restored = reloaded.Services.GetRequiredService<ReadingLibrary>(); await restored.InitializeAsync();
        Assert.Equal(saved.Preferences, restored.Current.Preferences); Assert.True(restored.Current.Preferences.RestorePosition);
    }
    [Fact] public async Task Reading_settings_controls_update_browser_preferences()
    {
        await using var vault = new FixtureVault(); await vault.Seed(); using var context = Context(vault);
        var reading = context.Services.GetRequiredService<ReadingLibrary>(); await reading.InitializeAsync(); var component = context.Render<ReadingSettings>();
        component.FindAll("select")[0].Change("dark"); component.Find("input[type=range]").Change("22"); component.FindAll("select")[1].Change("narrow"); component.FindAll("input[type=checkbox]")[0].Change(true);
        component.WaitForAssertion(() => { Assert.Equal("dark", reading.Current.Preferences.Theme); Assert.Equal(22, reading.Current.Preferences.TextSize); Assert.Equal("narrow", reading.Current.Preferences.Width); Assert.True(reading.Current.Preferences.RestorePosition); });
    }
    [Fact] public async Task Bookmark_button_and_recent_history_change_no_source_bytes()
    {
        await using var vault = new FixtureVault(); await vault.Seed(); var before = File.ReadAllBytes(Path.Combine(vault.Root, FixtureVault.Source));
        using var context = Context(vault, LinkResolver.PageUrl(FixtureVault.Source)); var component = context.Render<Read>();
        component.FindAll("button").Single(b => b.TextContent.Trim() == "Bookmark").Click();
        var reading = context.Services.GetRequiredService<ReadingLibrary>(); component.WaitForAssertion(() => Assert.True(reading.IsBookmarked(FixtureVault.Source)));
        Assert.Equal(FixtureVault.Source, Assert.Single(reading.Current.Recent).Id);
        component.FindAll("button").Single(b => b.TextContent.Trim() == "Bookmarked").Click(); component.WaitForAssertion(() => Assert.Empty(reading.Current.Bookmarks));
        Assert.Equal(before, File.ReadAllBytes(Path.Combine(vault.Root, FixtureVault.Source)));
        Assert.Contains("worldEgg.articleReady", context.JSInterop.Invocations.Select(i => i.Identifier));
    }
    [Fact] public async Task Renamed_and_deleted_saved_pages_are_not_silently_reassigned()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        var saved = new ReadingSnapshot { Bookmarks = [new(FixtureVault.Source, "A starting place", DateTime.UtcNow), new("01 Canon Reference/Test/Gone.md", "A lost tale", DateTime.UtcNow)] };
        using var context = Context(vault, "/reading-list", saved); var component = context.Render<ReadingShelf>();
        component.WaitForAssertion(() => Assert.Contains("A lost tale", component.Markup)); Assert.Contains("moved or been removed", component.Markup);
        File.Move(Path.Combine(vault.Root, FixtureVault.Source), Path.Combine(vault.Root, "01 Canon Reference/Test/NewName.md")); await vault.Catalogue.RefreshAsync();
        component.WaitForAssertion(() => Assert.Equal(2, component.FindAll("a[href^='/find?q=']").Count));
        component.FindAll("button").First().Click(); component.WaitForAssertion(() => Assert.Single(context.Services.GetRequiredService<ReadingLibrary>().Current.Bookmarks));
    }
    [Fact] public async Task Preview_is_an_excerpt_of_the_requested_passage_and_ignores_stale_open_requests()
    {
        await using var vault = new FixtureVault(); await vault.Seed(); using var context = Context(vault); var component = context.Render<LinkPreview>();
        const string id = "01 Canon Reference/Test/Ättar & Oaths.md";
        await component.InvokeAsync(() => component.Instance.ShowPreview(id, "a-difficult-promise", 2));
        Assert.Contains("They carried the broken bowl home.", component.Markup); Assert.DoesNotContain("The remainder.", component.Markup);
        await component.InvokeAsync(() => component.Instance.HidePreview(3)); await component.InvokeAsync(() => component.Instance.ShowPreview(id, "", 2)); Assert.Empty(component.FindAll("#article-preview"));
        await component.InvokeAsync(() => component.Instance.ShowPreview("../../secret.md", "", 4)); Assert.Empty(component.FindAll("#article-preview"));
        await context.Services.GetRequiredService<ReadingLibrary>().SetPreferencesAsync(new() { Previews = false }); await component.InvokeAsync(() => component.Instance.ShowPreview(id, "", 5)); Assert.Empty(component.FindAll("#article-preview"));
    }
    [Fact] public async Task Image_viewer_accepts_only_catalogued_images_and_exposes_keyboard_controls()
    {
        await using var vault = new FixtureVault(); await vault.Seed(); using var context = Context(vault); var component = context.Render<ImageViewer>();
        await component.InvokeAsync(() => component.Instance.ShowImage(FixtureVault.Source, "not an image")); Assert.Empty(component.FindAll("img"));
        await component.InvokeAsync(() => component.Instance.ShowImage("01 Canon Reference/Test/attachments/map.svg", "A map"));
        Assert.Contains("map.svg", component.Find("img").GetAttribute("src")); Assert.Equal("0", component.Find("#image-viewport").GetAttribute("tabindex"));
        component.Find("button[aria-label='Zoom in']").Click(); Assert.Single(context.JSInterop.Invocations["worldEgg.images.zoom"]);
        component.Find("button[aria-label='Close image viewer']").Click(); component.WaitForAssertion(() => Assert.Empty(component.FindAll("img")));
    }
    [Fact] public async Task Navigation_collapse_updates_accessible_state_and_stays_distinct_from_mobile_menu()
    {
        await using var vault = new FixtureVault(); await vault.Seed(); await using var context = Context(vault); var component = context.Render<MainLayout>();
        component.Find("button.desktop-menu-toggle").Click();
        component.WaitForAssertion(() => Assert.Equal("collapsed", component.Find(".site-shell").GetAttribute("data-nav")));
        Assert.Equal("false", component.Find("button.desktop-menu-toggle").GetAttribute("aria-expanded"));
        component.Find("button.menu-toggle").Click(); Assert.Contains("is-open", component.Find("#library-navigation").ClassList);
        await component.InvokeAsync(() => context.Services.GetRequiredService<NavigationManager>().NavigateTo("/articles"));
        component.WaitForAssertion(() => Assert.DoesNotContain("is-open", component.Find("#library-navigation").ClassList));
    }
    [Fact] public async Task Section_permalinks_source_copy_and_print_are_available()
    {
        await using var vault = new FixtureVault(); await vault.Seed(); const string id = "01 Canon Reference/Test/Ättar & Oaths.md";
        using var context = Context(vault, LinkResolver.PageUrl(id)); context.JSInterop.Setup<bool>("worldEgg.reading.copy", _ => true).SetResult(true);
        var component = context.Render<Read>(); Assert.Equal(2, component.FindAll("a.section-permalink").Count);
        Assert.EndsWith("#a-difficult-promise", component.Find("a.section-permalink").GetAttribute("href"));
        component.FindAll("button").Single(b => b.TextContent.Trim() == "Copy source path").Click(); component.WaitForAssertion(() => Assert.Contains("Source path copied.", component.Markup));
        component.FindAll("button").Single(b => b.TextContent.Trim() == "Print").Click(); Assert.Single(context.JSInterop.Invocations["worldEgg.reading.print"]);
        Assert.Contains(id, component.Find(".print-source").TextContent);
    }
    [Fact] public async Task Selected_prose_can_receive_a_persistent_comment_without_changing_markdown()
    {
        await using var vault = new FixtureVault(); await vault.Seed(); var sourcePath = System.IO.Path.Combine(vault.Root, FixtureVault.Source); var before = File.ReadAllBytes(sourcePath);
        using var context = Context(vault, LinkResolver.PageUrl(FixtureVault.Source)); var component = context.Render<Read>();
        await component.InvokeAsync(() => component.Instance.SelectionChanged(new ReviewSelection
        {
            ExactText = "ordinary beginning", SelectedText = "ordinary beginning", Prefix = "An ", Suffix = ".", StartOffset = 3, EndOffset = 21, X = 40, Y = 50
        }));
        component.FindAll("button").Single(x => x.TextContent.Trim() == "Comment").Click();
        component.Find("textarea").Input("Explain who made this decision and what it cost.");
        component.FindAll("button").Single(x => x.TextContent.Trim() == "Add comment").Click();
        component.WaitForAssertion(() => Assert.Contains("Explain who made this decision", component.Markup));
        var stored = await context.Services.GetRequiredService<ReviewCommentStore>().ListAsync(FixtureVault.Source, false);
        Assert.Single(stored); Assert.Equal("ordinary beginning", stored[0].Anchor.SelectedText); Assert.Equal(before, File.ReadAllBytes(sourcePath));
        Assert.Contains("worldEgg.annotations.attach", context.JSInterop.Invocations.Select(x => x.Identifier));
    }

    [Fact] public async Task Comment_composer_keeps_its_anchor_and_multiline_draft_when_browser_selection_clears()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        using var context = Context(vault, LinkResolver.PageUrl(FixtureVault.Source)); var component = context.Render<Read>();
        await component.InvokeAsync(() => component.Instance.SelectionChanged(new ReviewSelection
        {
            ExactText = "ordinary beginning", SelectedText = "ordinary beginning", Prefix = "An ", Suffix = ".", StartOffset = 3, EndOffset = 21, X = 40, Y = 50
        }));
        component.FindAll("button").Single(x => x.TextContent.Trim() == "Comment").Click();
        component.Find("textarea").Input("Clarify the first sentence.\nThen explain the consequence.");

        await component.InvokeAsync(() => component.Instance.SelectionChanged(null));

        component.WaitForAssertion(() =>
        {
            Assert.Single(component.FindAll(".review-composer"));
            Assert.Equal("Clarify the first sentence.\nThen explain the consequence.", component.Find("textarea").GetAttribute("value"));
        });
        component.FindAll("button").Single(x => x.TextContent.Trim() == "Add comment").Click();
        var stored = await context.Services.GetRequiredService<ReviewCommentStore>().ListAsync(FixtureVault.Source, false);
        Assert.Single(stored);
        Assert.Equal("Clarify the first sentence.\nThen explain the consequence.", stored[0].Comment);
        Assert.Equal("ordinary beginning", stored[0].Anchor.SelectedText);
    }

    [Fact] public async Task Review_inbox_groups_notes_and_links_back_to_their_exact_article_comment()
    {
        await using var vault = new FixtureVault(); await vault.Seed(); using var context = Context(vault, "/reviews");
        var store = context.Services.GetRequiredService<ReviewCommentStore>();
        var note = await store.AddAsync(FixtureVault.Source, new("ordinary beginning", "ordinary beginning", "An ", ".", 3, 21), "Give this paragraph a clearer opening.");
        var component = context.Render<Reviews>();
        Assert.Contains("Give this paragraph a clearer opening.", component.Markup);
        Assert.Contains("review=" + note.Id, component.Find("a.review-open-article").GetAttribute("href"));
        component.FindAll("button").Single(x => x.TextContent.Trim() == "Resolve").Click();
        component.WaitForAssertion(() => Assert.Contains("There are no open review comments", component.Markup));
    }
    [Fact] public async Task Block_previews_do_not_include_later_paragraphs_or_invent_a_missing_passage()
    {
        await using var vault = new FixtureVault(); await vault.Seed(); var previews = new ArticlePreviews(vault.Catalogue);
        var preview = previews.Get("01 Canon Reference/Test/Ättar & Oaths.md", "^garden-g01"); Assert.NotNull(preview); Assert.Equal("They carried the broken bowl home.", preview.Excerpt);
        Assert.Null(previews.Get("01 Canon Reference/Test/Ättar & Oaths.md", "nonexistent"));
    }
    [Fact] public async Task A_full_bookmark_shelf_does_not_silently_discard_an_existing_bookmark()
    {
        await using var vault = new FixtureVault(); await vault.Seed(); var saved = new ReadingSnapshot { Bookmarks = Enumerable.Range(1,100).Select(i => new SavedReading($"01 Canon Reference/Test/Keep{i}.md", "Saved " + i, DateTime.UtcNow)).ToArray() };
        using var context = Context(vault, saved: saved); var reading = context.Services.GetRequiredService<ReadingLibrary>(); await reading.ToggleBookmarkAsync(vault.Catalogue.Current.Documents[FixtureVault.Source]);
        Assert.Equal(100, reading.Current.Bookmarks.Length); Assert.False(reading.IsBookmarked(FixtureVault.Source)); Assert.Contains("Remove one", reading.Notice);
    }
    [Fact] public async Task Wide_article_tables_have_keyboard_scroll_regions_and_linked_images_keep_their_link()
    {
        await using var vault = new FixtureVault(); await vault.Seed(); var rendered = await vault.Render("| One | Two |\n|---|---|\n| A | B |\n\n[![Map](attachments/map.svg)](https://example.com)");
        using var context = Context(vault); var article = context.Render<ArticleBody>(p => p.Add(c => c.Html, rendered.Html));
        Assert.Equal("0", article.Find(".prose-table-scroll").GetAttribute("tabindex")); Assert.Equal("https://example.com", article.Find("a:has(img)").GetAttribute("href")); Assert.Empty(article.FindAll("a.image-enlarge"));
    }
}
