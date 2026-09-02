using System.Collections.Immutable;
using YamlDotNet.RepresentationModel;

namespace WorldEgg.Wiki.Core;

public sealed record WikiDocument(string Id, string Title, string Body, ImmutableDictionary<string, string[]> Metadata, DateTime ModifiedUtc, long Length, string? Error)
{
    public ImmutableDictionary<string, BaseValue> Values { get; init; } = ImmutableDictionary<string, BaseValue>.Empty;
    public string Area => Id.Split('/')[0];
    public string Folder => Id.Contains('/') ? Id[..Id.LastIndexOf('/')] : "";
    public string[] Aliases => Metadata.GetValueOrDefault("aliases", []);
    public string Field(string key) => string.Join(", ", Metadata.GetValueOrDefault(key, []));
    public bool Archived => Area == "90 Archive & Drafts";
}

public static class DocumentParser
{
    public static WikiDocument Parse(string id, string source, DateTime modified, long length)
    {
        var metadata = ImmutableDictionary.CreateBuilder<string, string[]>(StringComparer.OrdinalIgnoreCase);
        var values = ImmutableDictionary.CreateBuilder<string, BaseValue>(StringComparer.OrdinalIgnoreCase);
        var body = source.Replace("\r\n", "\n").TrimStart('\uFEFF');
        string? error = null;
        if (body.StartsWith("---\n", StringComparison.Ordinal))
        {
            var closing = System.Text.RegularExpressions.Regex.Match(body[4..], @"(?m)^---[ \t]*$");
            var end = closing.Success ? closing.Index + 3 : -1;
            if (end < 0) error = "The frontmatter has no closing --- line. The original text is shown below.";
            else
            {
                var yaml = body[4..end];
                body = body[(end + 4)..].TrimStart('\n');
                try
                {
                    var stream = new YamlStream();
                    stream.Load(new StringReader(yaml));
                    if (stream.Documents.FirstOrDefault()?.RootNode is not YamlMappingNode map) throw new FormatException("Expected a metadata mapping.");
                    foreach (var entry in map.Children)
                    {
                        var key = ((YamlScalarNode)entry.Key).Value ?? "";
                        metadata[key] = entry.Value is YamlSequenceNode list ? list.Children.Select(Value).ToArray() : [Value(entry.Value)];
                        values[key] = BaseValue.FromYaml(entry.Value);
                    }
                }
                catch (Exception ex) when (ex is YamlDotNet.Core.YamlException or FormatException or InvalidCastException or ArgumentException)
                {
                    error = "The metadata could not be read. Article text remains available. " + ex.Message;
                }
            }
        }
        var title = metadata.GetValueOrDefault("title")?.FirstOrDefault();
        if (string.IsNullOrWhiteSpace(title))
        {
            // Only a true H1 outside fenced code can override the filename.
            var heading = MarkdownSupport.Parse(body).OfType<Markdig.Syntax.HeadingBlock>().FirstOrDefault(h => h.Level == 1);
            title = heading is null ? Path.GetFileNameWithoutExtension(id) : MarkdownSupport.HeadingText(heading);
        }
        return new(id, title!, body, metadata.ToImmutable(), modified, length, error) { Values = values.ToImmutable() };
    }

    private static string Value(YamlNode node) => node is YamlScalarNode scalar ? scalar.Value ?? "" : node.ToString();
}

public sealed record CatalogueSnapshot(ImmutableDictionary<string, WikiDocument> Documents, ImmutableHashSet<string> Assets, string[] Errors, long Version)
{
    public ImmutableDictionary<string, BaseSource> Bases { get; init; } = ImmutableDictionary.Create<string, BaseSource>(StringComparer.OrdinalIgnoreCase);
    public static CatalogueSnapshot Empty { get; } = new(ImmutableDictionary.Create<string, WikiDocument>(StringComparer.OrdinalIgnoreCase), ImmutableHashSet.Create<string>(StringComparer.OrdinalIgnoreCase), [], 0);
}

public sealed record BaseSource(string Id, string Source, DateTime ModifiedUtc, long Length, string? Error = null);
