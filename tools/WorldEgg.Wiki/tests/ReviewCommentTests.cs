using WorldEgg.Wiki.Core;
using Xunit;

namespace WorldEgg.Wiki.Tests;

public sealed class ReviewCommentTests
{
    [Fact]
    public async Task Comments_persist_resolve_and_delete_without_entering_the_vault_catalogue()
    {
        await using var vault = new FixtureVault();
        await vault.Seed();
        var reviewPath = System.IO.Path.Combine(vault.Root, "private", "review-comments.json");
        var anchor = new ReviewAnchor("ordinary beginning", "ordinary beginning", "An ", ".", 3, 21);

        var first = new ReviewCommentStore(reviewPath, vault.Catalogue);
        var added = await first.AddAsync(FixtureVault.Source, anchor, "Clarify the consequence.");
        Assert.True(File.Exists(reviewPath));

        var reopened = new ReviewCommentStore(reviewPath, vault.Catalogue);
        var loaded = Assert.Single(await reopened.ListAsync(FixtureVault.Source, false));
        Assert.Equal(added.Id, loaded.Id);
        Assert.Equal("Clarify the consequence.", loaded.Comment);

        await reopened.SetResolvedAsync(added.Id, true);
        Assert.Empty(await reopened.ListAsync(FixtureVault.Source, false));
        Assert.True(await reopened.DeleteAsync(added.Id));
        Assert.Empty(await reopened.ListAsync());
        Assert.DoesNotContain(vault.Catalogue.Current.Documents.Keys, x => x.Contains("review-comments", StringComparison.OrdinalIgnoreCase));
    }
}
