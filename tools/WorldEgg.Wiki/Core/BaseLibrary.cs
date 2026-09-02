using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using YamlDotNet.RepresentationModel;

namespace WorldEgg.Wiki.Core;

public sealed record BaseSort(string Property, bool Descending);
public sealed record BaseView(string Name, BaseExpression Filter, string[] Columns, BaseSort[] Sort, BaseSort? Group, IReadOnlyDictionary<string, int> Widths, int? Limit, string[] Warnings);
public sealed record BaseDefinition(string Id, BaseExpression Filter, IReadOnlyDictionary<string, BaseExpression> Formulas, IReadOnlyDictionary<string, string> Labels, BaseView[] Views, string[] Warnings)
{
    public string Label(string property) => Labels.GetValueOrDefault(property) ?? Labels.GetValueOrDefault(property.StartsWith("note.", StringComparison.Ordinal) ? property[5..] : "note." + property) ?? (property == "file.name" ? "File" : property.Replace("note.", "").Replace("formula.", "").Replace('_', ' '));
}
public sealed record BaseRow(string Id, IReadOnlyDictionary<string, BaseValue> Cells, BaseValue Group);
public sealed record BaseTableResult(BaseDefinition Definition, BaseView? View, BaseRow[] Rows, string[] Warnings);

public sealed class BaseLibrary(VaultCatalogue catalogue)
{
    private readonly ConditionalWeakTable<BaseSource, BaseDefinition> _definitions = new();
    private readonly ConditionalWeakTable<CatalogueSnapshot, ConcurrentDictionary<string, BaseTableResult>> _tables = new();
    public BaseDefinition Definition(BaseSource source) => _definitions.GetValue(source, Parse);
    public BaseTableResult Read(string id, string? viewName = null, CatalogueSnapshot? snapshot = null)
    {
        var current = snapshot ?? catalogue.Current;
        if (!current.Bases.TryGetValue(id, out var source)) return new(new(id, BaseExpression.True, new Dictionary<string, BaseExpression>(), new Dictionary<string, string>(), [], []), null, [], ["Collection not found. It may have moved or been deleted."]);
        var definition = Definition(source);
        var view = viewName is null ? definition.Views.FirstOrDefault() : definition.Views.FirstOrDefault(v => v.Name == viewName);
        var key = id + "\n" + (view?.Name ?? viewName);
        return _tables.GetValue(current, _ => new()).GetOrAdd(key, _ => Evaluate(definition, view, current));
    }
    public static BaseRow[] SortRows(IEnumerable<BaseRow> rows, BaseSort[] sorts, BaseSort? group)
    {
        var instructions = group is null ? sorts : new[] { group }.Concat(sorts).ToArray();
        return rows.Order(Comparer<BaseRow>.Create((a, b) =>
        {
            foreach (var sort in instructions)
            {
                var x = a.Cells.GetValueOrDefault(sort.Property, BaseValue.Null); var y = b.Cells.GetValueOrDefault(sort.Property, BaseValue.Null);
                var compare = x.CompareTo(y);
                if (compare != 0) return x.Raw is null || y.Raw is null ? compare : sort.Descending ? -compare : compare;
            }
            return StringComparer.OrdinalIgnoreCase.Compare(a.Id, b.Id);
        })).ToArray();
    }
    private static BaseTableResult Evaluate(BaseDefinition definition, BaseView? view, CatalogueSnapshot snapshot)
    {
        var warnings = definition.Warnings.Concat(view?.Warnings ?? []).ToList();
        if (view is null) warnings.Add("No supported named view is selected.");
        if (warnings.Count > 0 || view is null) return new(definition, view, [], warnings.ToArray());
        try
        {
            var rows = new List<BaseRow>();
            var properties = view.Columns.Concat(view.Sort.Select(s => s.Property)).Concat(view.Group is null ? [] : new[] { view.Group.Property }).Distinct().ToArray();
            // Bases include files, not just notes. Attachments have file fields and absent note fields.
            foreach (var id in snapshot.Documents.Keys.Concat(snapshot.Assets))
            {
                var context = new BaseContext(id, snapshot.Documents.GetValueOrDefault(id), definition.Formulas);
                if (!definition.Filter.Evaluate(context).Truth || !view.Filter.Evaluate(context).Truth) continue;
                var cells = properties.ToDictionary(p => p, context.Get);
                rows.Add(new(id, cells, view.Group is null ? BaseValue.Null : cells[view.Group.Property]));
            }
            var ordered = SortRows(rows, view.Sort, view.Group);
            if (view.Limit is { } limit) ordered = ordered.Take(limit).ToArray();
            return new(definition, view, ordered, []);
        }
        catch (Exception ex) when (ex is FormatException or OverflowException or ArgumentException)
        { return new(definition, view, [], ["This view cannot be evaluated safely: " + ex.Message]); }
    }
    private static BaseDefinition Parse(BaseSource source)
    {
        var filters = BaseExpression.True;
        var formulas = new Dictionary<string, BaseExpression>(StringComparer.Ordinal);
        var labels = new Dictionary<string, string>(StringComparer.Ordinal);
        var views = new List<BaseView>(); var warnings = new List<string>();
        try
        {
            if (source.Error is not null) throw new FormatException(source.Error);
            var yaml = new YamlStream(); yaml.Load(new StringReader(source.Source));
            if (yaml.Documents.Count != 1 || yaml.Documents[0].RootNode is not YamlMappingNode root) throw new FormatException("Expected one Base mapping.");
            CheckKeys(root, "Base", "filters", "formulas", "properties", "views");
            filters = BaseExpression.Filter(Get(root, "filters"));
            if (Get(root, "formulas") is { } formulaNode)
                foreach (var pair in Mapping(formulaNode).Children) formulas.Add(pair.Key.ToString(), BaseExpression.Parse(Scalar(pair.Value)));
            if (Get(root, "properties") is { } propertyNode)
                foreach (var pair in Mapping(propertyNode).Children)
                { BaseExpression.ValidateProperty(pair.Key.ToString()); var property = Mapping(pair.Value); CheckKeys(property, "property", "displayName"); if (Get(property, "displayName") is { } label) labels[pair.Key.ToString()] = Scalar(label); }
            ValidateReferences(filters.References, formulas);
            foreach (var formula in formulas.Values) ValidateReferences(formula.References, formulas);
            foreach (var name in formulas.Keys) CheckCycle(name, formulas, new HashSet<string>());
            if (Get(root, "views") is not YamlSequenceNode sequence) throw new FormatException("Expected a list of named views.");
            foreach (var viewNode in sequence.Children)
            {
                var viewName = "Unnamed view";
                try
                {
                    var view = Mapping(viewNode); viewName = Get(view, "name") is { } name ? Scalar(name) : viewName;
                    if (views.Any(v => v.Name == viewName)) throw new FormatException("Duplicate view name: " + viewName);
                    CheckKeys(view, "view", "type", "name", "filters", "order", "sort", "groupBy", "columnSize", "limit");
                    if (Get(view, "type")?.ToString() != "table") throw new FormatException("Only table views are supported.");
                    var filter = BaseExpression.Filter(Get(view, "filters"));
                    var orderNode = Get(view, "order"); var sortNode = Get(view, "sort");
                    if (orderNode is not null and not YamlSequenceNode) throw new FormatException("Column order must be a list of properties.");
                    if (sortNode is not null and not YamlSequenceNode) throw new FormatException("Sort must be a list of property/direction pairs.");
                    var columns = orderNode is YamlSequenceNode order ? order.Children.Select(Scalar).ToArray() : new[] { "file.name" };
                    var sort = sortNode is YamlSequenceNode sorts ? sorts.Children.Select(ParseSort).ToArray() : [];
                    var group = Get(view, "groupBy") is { } groupNode ? ParseSort(groupNode) : null;
                    var widths = new Dictionary<string, int>();
                    if (Get(view, "columnSize") is { } sizes)
                        foreach (var pair in Mapping(sizes).Children) { var width = int.Parse(Scalar(pair.Value), System.Globalization.CultureInfo.InvariantCulture); if (width is < 1 or > 10000) throw new FormatException("Unsupported column width."); widths[pair.Key.ToString()] = width; }
                    int? limit = Get(view, "limit") is { } limitNode ? int.Parse(Scalar(limitNode), System.Globalization.CultureInfo.InvariantCulture) : null;
                    if (limit < 0) throw new FormatException("A view limit cannot be negative.");
                    var references = columns.Concat(sort.Select(s => s.Property)).Concat(group is null ? [] : new[] { group.Property }).Concat(widths.Keys).Concat(filter.References).ToArray();
                    ValidateReferences(references, formulas);
                    views.Add(new(viewName, filter, columns, sort, group, widths, limit, []));
                }
                catch (Exception ex) when (ex is FormatException or OverflowException or ArgumentException)
                { views.Add(new(viewName, BaseExpression.True, [], [], null, new Dictionary<string, int>(), null, [ex.Message])); }
            }
            if (views.Count == 0) warnings.Add("This Base has no named views.");
        }
        catch (Exception ex) when (ex is YamlDotNet.Core.YamlException or FormatException or OverflowException or ArgumentException)
        { warnings.Add("Unsupported or malformed collection: " + ex.Message); }
        return new(source.Id, filters, formulas, labels, views.ToArray(), warnings.ToArray());
    }
    private static void CheckCycle(string name, IReadOnlyDictionary<string, BaseExpression> formulas, HashSet<string> ancestors)
    {
        if (ancestors.Count >= 64) throw new FormatException("Formula dependencies exceed the reader’s 64-level limit.");
        if (!ancestors.Add(name)) throw new FormatException("Formula cycle: " + name);
        foreach (var reference in formulas[name].References.Where(r => r.StartsWith("formula.", StringComparison.Ordinal))) CheckCycle(reference[8..], formulas, ancestors);
        ancestors.Remove(name);
    }
    private static void ValidateReferences(IEnumerable<string> references, IReadOnlyDictionary<string, BaseExpression> formulas)
    {
        foreach (var reference in references) { BaseExpression.ValidateProperty(reference); if (reference.StartsWith("formula.", StringComparison.Ordinal) && !formulas.ContainsKey(reference[8..])) throw new FormatException("Unknown formula: " + reference); }
    }
    private static BaseSort ParseSort(YamlNode node)
    { var map = Mapping(node); CheckKeys(map, "sort/group", "property", "direction"); var property = Scalar(Get(map, "property") ?? throw new FormatException("Missing sort property.")); var direction = Get(map, "direction")?.ToString() ?? "ASC"; if (direction is not ("ASC" or "DESC")) throw new FormatException("Unsupported sort direction: " + direction); return new(property, direction == "DESC"); }
    private static void CheckKeys(YamlMappingNode map, string context, params string[] allowed)
    { foreach (var key in map.Children.Keys.Select(n => n.ToString())) if (!allowed.Contains(key)) throw new FormatException("Unsupported " + context + " option: " + key); }
    private static YamlNode? Get(YamlMappingNode map, string key) => map.Children.TryGetValue(new YamlScalarNode(key), out var value) ? value : null;
    private static YamlMappingNode Mapping(YamlNode node) => node as YamlMappingNode ?? throw new FormatException("Expected a mapping.");
    private static string Scalar(YamlNode node) => node is YamlScalarNode scalar ? scalar.Value ?? "" : throw new FormatException("Expected a scalar.");
}
