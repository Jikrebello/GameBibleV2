using System.Globalization;
using System.Text.RegularExpressions;
using YamlDotNet.Core;
using YamlDotNet.RepresentationModel;

namespace WorldEgg.Wiki.Core;

// Values stay typed: a missing field is not an empty string, and a one-item list is not a scalar.
public sealed record BaseValue(object? Raw) : IComparable<BaseValue>
{
    public static BaseValue Null { get; } = new((object?)null);
    public bool Truth => Raw switch { bool b => b, string s => s.Length > 0, decimal n => n != 0, BaseValue[] l => l.Length > 0, _ => false };
    public BaseValue Length => Raw switch { string s => new((decimal)s.Length), BaseValue[] l => new((decimal)l.Length), _ => Null };
    public bool Contains(BaseValue value) => Raw switch { string s when value.Raw is string t => s.Contains(t, StringComparison.Ordinal), BaseValue[] l => l.Any(v => v.Same(value)), _ => false };
    public bool Same(BaseValue other) => Raw is BaseValue[] a && other.Raw is BaseValue[] b ? a.Length == b.Length && a.Zip(b).All(p => p.First.Same(p.Second)) : Equals(Raw, other.Raw);
    public override string ToString() => Raw switch { null => "—", bool b => b ? "true" : "false", decimal n => n.ToString(CultureInfo.InvariantCulture), BaseValue[] l => string.Join(", ", l.Select(v => v.ToString())), _ => Raw.ToString() ?? "" };
    public int CompareTo(BaseValue? other)
    {
        if (other is null) return -1;
        if (Raw is null) return other.Raw is null ? 0 : 1;
        if (other.Raw is null) return -1;
        if (Raw is decimal a && other.Raw is decimal b) return a.CompareTo(b);
        if (Raw is BaseValue[] x && other.Raw is BaseValue[] y)
        { for (var i = 0; i < Math.Min(x.Length, y.Length); i++) { var c = x[i].CompareTo(y[i]); if (c != 0) return c; } return x.Length.CompareTo(y.Length); }
        return StringComparer.OrdinalIgnoreCase.Compare(ToString(), other.ToString());
    }
    public static BaseValue FromYaml(YamlNode node)
    {
        if (node is YamlSequenceNode list) return new(list.Children.Select(FromYaml).ToArray());
        if (node is not YamlScalarNode scalar) return new(node.ToString());
        var value = scalar.Value;
        if (scalar.Style is ScalarStyle.SingleQuoted or ScalarStyle.DoubleQuoted) return new(value ?? "");
        if (value is null or "" or "~" || value.Equals("null", StringComparison.OrdinalIgnoreCase)) return Null;
        if (bool.TryParse(value, out var flag)) return new(flag);
        if (decimal.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out var number)) return new(number);
        return new(value);
    }
}

public sealed class BaseContext(string id, WikiDocument? document, IReadOnlyDictionary<string, BaseExpression> formulas)
{
    private readonly HashSet<string> _evaluating = new(StringComparer.Ordinal);
    private readonly Dictionary<string, BaseValue> _computed = new(StringComparer.Ordinal);
    public string Id { get; } = id;

    public bool InFolder(string folder) => Id.StartsWith(folder.Trim('/') + "/", StringComparison.OrdinalIgnoreCase);

    public BaseValue Get(string property)
    {
        if (property.StartsWith("formula.", StringComparison.Ordinal))
        {
            var name = property[8..];
            if (_computed.TryGetValue(name, out var value)) return value;
            if (!formulas.TryGetValue(name, out var formula)) throw new FormatException("Unknown formula: " + name);
            if (!_evaluating.Add(name)) throw new FormatException("Formula cycle: " + name);
            try { return _computed[name] = formula.Evaluate(this); } finally { _evaluating.Remove(name); }
        }
        if (property.StartsWith("file.", StringComparison.Ordinal)) return property switch
        {
            "file.name" => new(Path.GetFileName(Id)),
            "file.basename" => new(Path.GetFileNameWithoutExtension(Id)),
            "file.path" => new(Id),
            "file.folder" => new(Id.Contains('/') ? Id[..Id.LastIndexOf('/')] : ""),
            "file.ext" => new(Path.GetExtension(Id).TrimStart('.')),
            _ => throw new FormatException("Unsupported file property: " + property)
        };
        return document?.Values.GetValueOrDefault(property.StartsWith("note.", StringComparison.Ordinal) ? property[5..] : property) ?? BaseValue.Null;
    }
}

public sealed record BaseExpression(Func<BaseContext, BaseValue> Evaluate, string[] References)
{
    public static BaseExpression True { get; } = new(_ => new(true), []);
    public static BaseExpression Parse(string source) => new Parser(source).Parse();
    public static BaseExpression Filter(YamlNode? node) => FilterAt(node, 0);
    private static BaseExpression FilterAt(YamlNode? node, int depth)
    {
        if (depth >= 64) throw new FormatException("Boolean groups exceed the reader’s 64-level limit.");
        if (node is null) return True;
        if (node is YamlScalarNode scalar) return Parse(scalar.Value ?? "");
        if (node is not YamlMappingNode map || map.Children.Count != 1) throw new FormatException("A filter must be an expression or one and/or/not group.");
        var pair = map.Children.Single();
        var operation = pair.Key.ToString();
        if (operation is not ("and" or "or" or "not") || pair.Value is not YamlSequenceNode sequence) throw new FormatException("Unsupported Boolean filter group: " + operation);
        var children = sequence.Children.Select(n => FilterAt(n, depth + 1)).ToArray(); // Validate every branch, including unreachable branches.
        return new(c => new(operation switch { "and" => children.All(e => e.Evaluate(c).Truth), "or" => children.Any(e => e.Evaluate(c).Truth), _ => !children.Any(e => e.Evaluate(c).Truth) }), children.SelectMany(e => e.References).Distinct().ToArray());
    }
    public static void ValidateProperty(string name)
    {
        if (!Regex.IsMatch(name, @"^(?:(?:note|formula|file)\.)?[\p{L}_][\p{L}\p{N}_-]*$")) throw new FormatException("Unsupported property: " + name);
        if (name.StartsWith("file.", StringComparison.Ordinal) && name is not ("file.name" or "file.basename" or "file.path" or "file.folder" or "file.ext")) throw new FormatException("Unsupported file property: " + name);
    }

    private sealed class Parser
    {
        private readonly string _source;
        private int _position;
        private int _depth;
        private readonly HashSet<string> _references = new(StringComparer.Ordinal);
        public Parser(string source) { if (source.Length > 4096) throw new FormatException("Expression exceeds the reader’s 4096-character limit."); _source = source; }
        public BaseExpression Parse() { var function = Or(); White(); if (_position != _source.Length) throw Error(); return new(function, _references.ToArray()); }
        private FormatException Error() => new("Unsupported or malformed expression at character " + (_position + 1) + ": " + _source);
        private void White() { while (_position < _source.Length && char.IsWhiteSpace(_source[_position])) _position++; }
        private bool Take(string token) { White(); if (!_source.AsSpan(_position).StartsWith(token, StringComparison.Ordinal)) return false; _position += token.Length; return true; }
        private void Need(string token) { if (!Take(token)) throw Error(); }
        private Func<BaseContext, BaseValue> Or()
        {
            var left = And(); while (Take("||")) { var a = left; var b = And(); left = c => new(a(c).Truth || b(c).Truth); }
            return left;
        }
        private Func<BaseContext, BaseValue> And()
        {
            var left = Compare(); while (Take("&&")) { var a = left; var b = Compare(); left = c => new(a(c).Truth && b(c).Truth); }
            return left;
        }
        private Func<BaseContext, BaseValue> Compare()
        {
            var left = Unary();
            foreach (var op in new[] { "==", "!=", ">=", "<=", ">", "<" })
                if (Take(op))
                {
                    var right = Unary(); return c =>
                    {
                        var a = left(c); var b = right(c); return new(op switch
                        { "==" => a.Same(b), "!=" => !a.Same(b), ">" => Ordered(a, b) && a.CompareTo(b) > 0, "<" => Ordered(a, b) && a.CompareTo(b) < 0, ">=" => Ordered(a, b) && a.CompareTo(b) >= 0, _ => Ordered(a, b) && a.CompareTo(b) <= 0 });
                    };
                }
            return left;
        }
        private static bool Ordered(BaseValue a, BaseValue b) => a.Raw is not null && b.Raw is not null && a.Raw.GetType() == b.Raw.GetType();
        private Func<BaseContext, BaseValue> Unary()
        {
            if (++_depth > 64) throw new FormatException("Expression nesting exceeds the reader’s 64-level limit.");
            try { if (Take("!")) { var operand = Unary(); return c => new(!operand(c).Truth); } return Atom(); }
            finally { _depth--; }
        }
        private Func<BaseContext, BaseValue> Atom()
        {
            White(); if (_position >= _source.Length) throw Error();
            if (Take("(")) { var inner = Or(); Need(")"); return inner; }
            if (_source[_position] is '"' or '\'')
            {
                var quote = _source[_position++]; var text = new System.Text.StringBuilder(); var closed = false;
                while (_position < _source.Length) { var ch = _source[_position++]; if (ch == quote) { closed = true; break; } if (ch == '\\') { if (_position == _source.Length) throw Error(); ch = _source[_position++]; ch = ch switch { 'n' => '\n', 'r' => '\r', 't' => '\t', '\\' => '\\', '"' => '"', '\'' => '\'', _ => throw Error() }; } text.Append(ch); }
                if (!closed) throw Error(); var value = new BaseValue(text.ToString()); return _ => value;
            }
            var number = Regex.Match(_source[_position..], @"^-?\d+(?:\.\d+)?");
            if (number.Success) { _position += number.Length; var value = new BaseValue(decimal.Parse(number.Value, CultureInfo.InvariantCulture)); return _ => value; }
            var name = Identifier();
            if (name is "true" or "false" or "null") { var value = name == "null" ? BaseValue.Null : new BaseValue(name == "true"); return _ => value; }
            if (name is "file" or "note" or "formula") { Need("."); name += "." + Identifier(); }
            if (name == "file.inFolder") { Need("("); var arg = Or(); Need(")"); return c => new(arg(c).Raw is string folder && c.InFolder(folder)); }
            ValidateProperty(name); _references.Add(name);
            Func<BaseContext, BaseValue> get = c => c.Get(name);
            while (Take("."))
            {
                var member = Identifier(); var previous = get;
                if (member == "length") get = c => previous(c).Length;
                else if (member == "contains") { Need("("); var argument = Or(); Need(")"); get = c => new(previous(c).Contains(argument(c))); }
                else throw new FormatException("Unsupported member: " + member);
            }
            return get;
        }
        private string Identifier()
        {
            White(); var match = Regex.Match(_source[_position..], @"^[\p{L}_][\p{L}\p{N}_-]*"); if (!match.Success) throw Error(); _position += match.Length; return match.Value;
        }
    }
}