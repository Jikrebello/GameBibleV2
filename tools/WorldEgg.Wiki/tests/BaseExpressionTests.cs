using WorldEgg.Wiki.Core;
using Xunit;

namespace WorldEgg.Wiki.Tests;

public sealed class BaseExpressionTests
{
    private static BaseContext Context()
    {
        var doc = DocumentParser.Parse("01 Canon Reference/Test/Typed.md", "---\nstatus: canon\nempty: ''\ncount: 12\nquoted: '12'\nneeds: []\nitems: [one, two]\nscalar: a string\n---\n# Test", DateTime.UtcNow, 1);
        return new(doc.Id, doc, new Dictionary<string, BaseExpression>());
    }
    [Theory]
    [InlineData("count > 2", true)]
    [InlineData("count == 12 && quoted != 12", true)]
    [InlineData("note.items.length == 2", true)]
    [InlineData("needs.length == 0", true)]
    [InlineData("items.contains('one') && !items.contains('on')", true)]
    [InlineData("scalar.contains('string')", true)]
    [InlineData("missing == null && missing != ''", true)]
    [InlineData("missing.length > 0", false)]
    [InlineData("missing.contains('one')", false)]
    [InlineData("file.inFolder('01 Canon Reference') && file.ext == 'md'", true)]
    [InlineData("file.inFolder('01 Canon')", false)]
    [InlineData("(false || true) && !false", true)]
    public void Supported_expressions_remain_typed_and_bounded(string source, bool expected) => Assert.Equal(expected, BaseExpression.Parse(source).Evaluate(Context()).Truth);
    [Theory]
    [InlineData("false && file.delete()")]
    [InlineData("true || fetch('https://example.com')")]
    [InlineData("status.matches(/canon/)")]
    [InlineData("items.map(value)")]
    [InlineData("count + 1")]
    [InlineData("file.unknown == 1")]
    public void Unsupported_syntax_is_rejected_even_in_unreachable_branches(string source) => Assert.Throws<FormatException>(() => BaseExpression.Parse(source));
    [Fact] public void Excessively_nested_expressions_fail_without_recursing_indefinitely() => Assert.Throws<FormatException>(() => BaseExpression.Parse(new string('!', 1000) + "true"));
    [Fact] public async Task Invalid_sort_configuration_is_not_silently_ignored()
    {
        await using var vault = new FixtureVault(); await vault.Seed(); const string id = "00 Start Here/Bases/BrokenSort.base";
        vault.Write(id, "views:\n - type: table\n   name: Invalid\n   sort: count"); await vault.Catalogue.RefreshAsync();
        var result = new BaseLibrary(vault.Catalogue).Read(id); Assert.Empty(result.Rows); Assert.Contains(result.Warnings, w => w.Contains("Sort must be a list"));
    }
    [Fact] public async Task Unsupported_view_is_isolated_and_formulas_cannot_cycle()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        const string id = "00 Start Here/Bases/Safe.base";
        vault.Write(id, "views:\n - type: table\n   name: Good\n   filters: 'status == \"canon\"'\n - type: table\n   name: Bad\n   filters: 'false && file.delete()'"); await vault.Catalogue.RefreshAsync();
        var bases = new BaseLibrary(vault.Catalogue);
        Assert.Empty(bases.Read(id, "Good").Warnings); Assert.NotEmpty(bases.Read(id, "Good").Rows);
        Assert.NotEmpty(bases.Read(id, "Bad").Warnings); Assert.Empty(bases.Read(id, "Bad").Rows);
        vault.Write(id, "formulas:\n a: 'formula.b'\n b: 'formula.a'\nviews:\n - type: table\n   name: Cycle"); await vault.Catalogue.RefreshAsync();
        Assert.Contains(bases.Read(id).Warnings, w => w.Contains("cycle", StringComparison.OrdinalIgnoreCase));
    }
    [Fact] public async Task Numeric_sort_formula_grouping_widths_and_attachments_work()
    {
        await using var vault = new FixtureVault(); await vault.Seed();
        vault.Write("01 Canon Reference/Test/Ten.md", "---\ncount: 10\nitems: [one, two]\ngroup: North\n---\n# Ten");
        vault.Write("01 Canon Reference/Test/Two.md", "---\ncount: 2\nitems: [one]\ngroup: North\n---\n# Two");
        const string id = "00 Start Here/Bases/Typed.base";
        vault.Write(id, "filters: 'count > 0'\nformulas:\n size: items.length\nproperties:\n formula.size:\n  displayName: Item count\nviews:\n - type: table\n   name: Counts\n   order: [file.name, formula.size]\n   groupBy: {property: note.group, direction: ASC}\n   sort: [{property: count, direction: ASC}]\n   columnSize: {formula.size: 455}"); await vault.Catalogue.RefreshAsync();
        var bases = new BaseLibrary(vault.Catalogue); var table = bases.Read(id);
        Assert.Empty(table.Warnings); Assert.EndsWith("Two.md", table.Rows[0].Id); Assert.Equal("1", table.Rows[0].Cells["formula.size"].ToString()); Assert.Equal("North", table.Rows[0].Group.ToString());
        Assert.Equal("Item count", table.Definition.Label("formula.size")); Assert.Equal(455, table.View!.Widths["formula.size"]);
        vault.Write(id, "filters: 'file.ext == \"svg\"'\nviews:\n - type: table\n   name: Maps\n   order: [file.name, file.path]"); await vault.Catalogue.RefreshAsync();
        Assert.EndsWith("map.svg", Assert.Single(bases.Read(id).Rows).Id);
    }
}
