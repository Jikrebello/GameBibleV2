using System.Security.Cryptography;
using WorldEgg.Wiki.Core;
using Xunit;
using YamlDotNet.Serialization;

namespace WorldEgg.Wiki.Tests;

// The actual twelve definitions are read, then evaluated only against disposable synthetic notes.
// Expected membership and order are hand-authored; the expectation never calls the expression engine.
public sealed class ProductionBasesTests
{
    [Theory]
    [InlineData("Apocrypha & In-World Sources")]
    [InlineData("Authorial Secrets")]
    [InlineData("Bestiary Registry")]
    [InlineData("Canon Index")]
    [InlineData("Companions")]
    [InlineData("Factions")]
    [InlineData("Game-Ready Content")]
    [InlineData("Grenzburg Worldspace")]
    [InlineData("Main Campaign")]
    [InlineData("Needs Work")]
    [InlineData("Player Systems")]
    [InlineData("Source Reliability")]
    public async Task Production_definition_has_expected_membership_and_order_in_every_named_view(string name)
    {
        await using var vault = new FixtureVault();
        var file = Path.Combine(FindVault(), "00 Start Here", "Bases", name + ".base");
        var source = await File.ReadAllTextAsync(file); var before = SHA256.HashData(await File.ReadAllBytesAsync(file));
        var id = "00 Start Here/Bases/" + name + ".base"; vault.Write(id, source);
        var notes = new Dictionary<string, Dictionary<string, object?>>();
        void Add(string title, params (string Key, object? Value)[] fields)
        {
            var values = new Dictionary<string, object?> { ["status"] = "canon", ["type"] = "misc", ["needs"] = Array.Empty<string>(), ["appears_in"] = new[] { "Grenzburg" }, ["companion_id"] = "", ["faction_line"] = "", ["map_id"] = "" };
            foreach (var (key, value) in fields) values[key] = value;
            notes[title] = values;
        }
        var expected = new Dictionary<string, string[]>();
        void Expect(string view, params string[] titles) => expected[view] = titles;
        switch (name)
        {
            case "Apocrypha & In-World Sources":
                Add("Disputed", ("canon_level", "disputed")); Add("Apocryphal", ("canon_level", "apocryphal")); Add("Other", ("canon_level", "history"));
                Expect(name, "Apocryphal", "Disputed"); break;
            case "Authorial Secrets":
                Add("Author", ("visibility", "author-only")); Add("SecretA", ("visibility", "secret")); Add("SecretZ", ("visibility", "secret"));
                Add("ExcludedQuest", ("visibility", "secret"), ("type", "quest")); Add("Public", ("visibility", "public")); Add("Draft", ("status", "draft"), ("visibility", "secret"));
                Expect(name, "Author", "SecretZ", "SecretA"); break;
            case "Canon Index":
                Add("A"); Add("Z"); Add("Draft", ("status", "draft")); Expect(name, "A", "Z"); break;
            case "Bestiary Registry":
                foreach (var (title, origin) in new[] { ("Astral", "astral"), ("Crafted", "crafted"), ("Devil", "hell"), ("Draft", "material"), ("Shadow", "shadowlands"), ("Shell", "shell") })
                    Add(title, ("type", "creature"), ("origin_layer", origin), ("continuity", title == "Devil" ? "infrastructure-office" : "person"), ("encounter_tier", "one"), ("intelligence", "clever"), ("catalogued_forms", new[] { "one", "two" }), ("status", title == "Draft" ? "draft" : "canon"), ("needs", title == "Draft" ? new[] { "review" } : Array.Empty<string>()), ("appears_in", title is "Devil" or "Shell" ? new[] { "Grenzburg" } : Array.Empty<string>()), ("shell_affinity", "fire"), ("animating_principle", "craft"), ("idol_affinity", "wrath"), ("astral_niche", "wanderer"));
                Add("NotCreature");
                foreach (var view in new[] { "Coverage", "By Origin", "By Threat Tier", "By Intelligence" }) Expect(view, "Astral", "Crafted", "Devil", "Draft", "Shadow", "Shell");
                Expect("Quest Ready", "Astral", "Crafted", "Devil", "Shadow", "Shell"); Expect("By Continuity", "Devil", "Astral", "Crafted", "Draft", "Shadow", "Shell");
                Expect("Adventure Demand", "Devil", "Shell"); Expect("Devil Bearers", "Devil"); Expect("Shell Affinity", "Shell"); Expect("Construct Principle", "Crafted"); Expect("Shadowlands Ecology", "Shadow"); Expect("Astral Niche", "Astral"); Expect("Unfinished Creature Work", "Draft"); break;
            case "Companions":
                Add("Roster", ("type", "character"), ("companion_id", "C01"));
                foreach (var (title, sequence) in new[] { ("Bad", 1), ("Clean", 2), ("Remote", 3), ("Relationship", 10) })
                    Add(title, ("type", "quest"), ("quest_class", "companion"), ("companion_id", "C01"), ("quest_owner", "One owner"), ("quest_sequence", sequence), ("architecture_status", title == "Bad" ? "pending-migration" : "migrated"), ("remote_claim_status", title == "Remote" ? "pending-migration" : "cleared"), ("emotional_rewrite_status", title == "Bad" ? "reframe" : "cleared"), ("dialogue_status", title == "Bad" ? "draft" : "approved"), ("grounded_rewrite_status", title == "Bad" ? "draft" : "approved"), ("companion_content_role", title == "Relationship" ? "relationship" : "quest"));
                Add("Excluded", ("type", "character")); Expect("Companion Roster", "Roster"); Expect("Existing Quest Sources", "Bad", "Clean", "Remote", "Relationship"); Expect("Migrated Campaign Pieces", "Clean", "Relationship"); Expect("Architecture Migration", "Bad"); Expect("Relationship Episodes", "Relationship"); Expect("Emotional Rewrite Queue", "Bad", "Remote"); Expect("Grounded Review Queue", "Bad"); break;
            case "Factions":
                Add("Authority", ("type", "faction"), ("faction_line", "A")); Add("Index", ("type", "index"), ("faction_line", "B"));
                Add("Q2", ("quest_class", "faction"), ("quest_sequence", 2), ("faction_line", "A"), ("faction_branch", "B")); Add("Q9", ("quest_class", "faction"), ("quest_sequence", 9), ("faction_line", "A"), ("faction_branch", "A")); Add("Excluded", ("type", "faction"));
                Expect("Faction Authorities", "Authority", "Index"); Expect("Faction Quest Ladders", "Q2", "Q9"); Expect("Settlement Outputs", "Q9"); break;
            case "Game-Ready Content":
                Add("Clear", ("quest_class", "companion"), ("emotional_rewrite_status", "cleared"), ("dialogue_status", "approved"), ("grounded_rewrite_status", "approved"), ("remote_claim_status", "cleared"));
                Add("Unclear", ("quest_class", "companion")); Add("Place", ("type", "place"), ("appears_in", Array.Empty<string>())); Add("Caleran", ("appears_in", new[] { "Caleran" })); Add("Other", ("appears_in", Array.Empty<string>())); Add("Draft", ("status", "draft"));
                Expect(name, "Caleran", "Clear", "Place"); break;
            case "Grenzburg Worldspace":
                Add("North", ("map_id", 2)); Add("South", ("map_id", 10)); Add("Empty"); Add("Other", ("map_id", 1), ("appears_in", new[] { "Other setting" }));
                Expect(name, "North", "South"); break;
            case "Main Campaign":
                Add("Main2", ("quest_class", "main"), ("main_sequence", 2)); Add("Main10", ("quest_class", "main"), ("main_sequence", 10)); Add("After3", ("quest_class", "aftermath"), ("main_sequence", 3)); Add("Side", ("quest_class", "side"));
                Expect("Critical Path", "Main2", "Main10"); Expect("Summer", "After3"); Expect("State Wiring", "Main2", "After3", "Main10"); break;
            case "Needs Work":
                Add("Clean"); Add("Draft", ("status", "draft")); Add("Work", ("needs", new[] { "review" }));
                // The Base file itself also matches: absent status is not the string "canon".
                Expect(name, "Draft", "Work", "@base"); break;
            case "Player Systems":
                Add("Vocation1", ("system_family", "player"), ("player_system", "vocation"), ("vocation_tier", 1)); Add("Vocation3", ("system_family", "player"), ("player_system", "vocation"), ("vocation_tier", 3), ("balance_status", "provisional"));
                Add("Training", ("system_family", "player"), ("player_system", "training")); Add("Law", ("system_family", "player"), ("player_system", "legal-treatment")); Add("Draft", ("system_family", "player"), ("player_system", "other"), ("status", "draft")); Add("Excluded");
                Expect("Player Systems", "Law", "Draft", "Training", "Vocation1", "Vocation3"); Expect("Vocations", "Vocation1", "Vocation3"); Expect("Training and Law", "Law", "Training"); Expect("Production Work", "Draft", "Vocation3"); break;
            case "Source Reliability":
                Add("A", ("type", "source-text")); Add("Z", ("type", "source-text")); Add("Other"); Expect(name, "A", "Z"); break;
        }
        var serializer = new SerializerBuilder().Build();
        foreach (var (title, values) in notes) vault.Write("01 Canon Reference/Fixture/" + title + ".md", "---\n" + serializer.Serialize(values) + "---\n# " + title);
        var first = notes.First();
        foreach (var area in new[] { "90 Archive & Drafts", "99 Templates" }) vault.Write(area + "/Excluded.md", "---\n" + serializer.Serialize(first.Value) + "---\n# Excluded copy");
        await vault.Catalogue.RefreshAsync(); var bases = new BaseLibrary(vault.Catalogue); var definition = bases.Definition(vault.Catalogue.Current.Bases[id]);
        Assert.Empty(definition.Warnings); Assert.Equal(expected.Keys.Order(), definition.Views.Select(v => v.Name).Order());
        foreach (var (view, titles) in expected)
        {
            var result = bases.Read(id, view); Assert.Empty(result.Warnings);
            Assert.Equal(titles.Select(t => t == "@base" ? id : "01 Canon Reference/Fixture/" + t + ".md"), result.Rows.Select(r => r.Id));
            Assert.All(result.Rows, row => Assert.All(result.View!.Columns, column => Assert.True(row.Cells.ContainsKey(column), name + ": " + view + ": " + column)));
        }
        Assert.Equal(before, SHA256.HashData(await File.ReadAllBytesAsync(file)));
    }
    private static string FindVault()
    {
        for (var dir = new DirectoryInfo(AppContext.BaseDirectory); dir is not null; dir = dir.Parent) if (Directory.Exists(Path.Combine(dir.FullName, "00 Start Here", "Bases"))) return dir.FullName;
        throw new InvalidOperationException("Run the tests from the application within its source vault.");
    }
}
