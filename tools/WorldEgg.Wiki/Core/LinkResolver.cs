using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;

namespace WorldEgg.Wiki.Core;

public enum LinkState { Found, Missing, Ambiguous, Blocked, External }
public sealed record LinkResult(LinkState State, string Target, string Fragment, string[] Candidates)
{
    public string? Id => State == LinkState.Found ? Candidates[0] : null;
}

public sealed class LinkResolver(VaultPaths paths, VaultCatalogue catalogue)
{
    private sealed record Lookup(Dictionary<string, string[]> Files, Dictionary<string, string[]> Aliases);
    private readonly ConditionalWeakTable<CatalogueSnapshot, Lookup> _lookups = new();
    public LinkResult Resolve(string target, string sourceId, CatalogueSnapshot? snapshot = null)
    {
        var current = snapshot ?? catalogue.Current;
        var hash = target.IndexOf('#');
        var fragment = hash < 0 ? "" : Uri.UnescapeDataString(target[(hash + 1)..]);
        var name = Uri.UnescapeDataString(hash < 0 ? target : target[..hash]).Replace('\\', '/');
        if (name.StartsWith("https://", StringComparison.OrdinalIgnoreCase) || name.StartsWith("http://", StringComparison.OrdinalIgnoreCase) || name.StartsWith("mailto:", StringComparison.OrdinalIgnoreCase))
            return new(LinkState.External, target, fragment, []);
        if (name.Length == 0) return current.Documents.ContainsKey(sourceId) ? new(LinkState.Found, target, fragment, [sourceId]) : new(LinkState.Missing, target, fragment, []);
        name = Regex.Replace(name, @"(?<=\.md):\d+$", "", RegexOptions.IgnoreCase);
        if (Path.IsPathRooted(name))
        {
            var id = paths.ToId(name);
            return id is null ? new(LinkState.Blocked, target, fragment, []) : Exact(id, target, fragment, current);
        }
        if (name.Contains(':') || name.StartsWith("//", StringComparison.Ordinal)) return new(LinkState.Blocked, target, fragment, []);
        var folder = sourceId.Contains('/') ? sourceId[..sourceId.LastIndexOf('/')] : "";
        if (name.Contains('/'))
        {
            // Vault-root paths are explicit; ordinary Markdown paths are relative to their source.
            var rootPath = VaultPaths.ContentRoots.Any(r => name.StartsWith(r + "/", StringComparison.OrdinalIgnoreCase));
            var combined = rootPath ? name : folder + "/" + name;
            var full = paths.SafeFullPath(combined);
            return full is null ? new(LinkState.Blocked, target, fragment, []) : Exact(paths.ToId(full)!, target, fragment, current);
        }
        var local = Exact(folder + "/" + name, target, fragment, current);
        if (local.State == LinkState.Found) return local;
        var lookup = _lookups.GetValue(current, s => new(
            s.Documents.Keys.Concat(s.Assets).SelectMany(id => id.EndsWith(".md", StringComparison.OrdinalIgnoreCase) ? new[] { (Name: System.IO.Path.GetFileName(id), Id: id), (Name: System.IO.Path.GetFileNameWithoutExtension(id), Id: id) } : [(Name: System.IO.Path.GetFileName(id), Id: id)]).GroupBy(p => p.Name, StringComparer.OrdinalIgnoreCase).ToDictionary(g => g.Key, g => g.Select(p => p.Id).Distinct(StringComparer.OrdinalIgnoreCase).ToArray(), StringComparer.OrdinalIgnoreCase),
            s.Documents.Values.SelectMany(d => d.Aliases.Select(a => (Alias: a, d.Id))).GroupBy(p => p.Alias, StringComparer.OrdinalIgnoreCase).ToDictionary(g => g.Key, g => g.Select(p => p.Id).Distinct(StringComparer.OrdinalIgnoreCase).ToArray(), StringComparer.OrdinalIgnoreCase)));
        var matches = lookup.Files.GetValueOrDefault(name) ?? lookup.Aliases.GetValueOrDefault(name) ?? [];
        return new(matches.Length switch { 0 => LinkState.Missing, 1 => LinkState.Found, _ => LinkState.Ambiguous }, target, fragment, matches.Order().ToArray());
    }

    private static LinkResult Exact(string id, string target, string fragment, CatalogueSnapshot current)
    {
        if (current.Documents.ContainsKey(id) || current.Assets.Contains(id)) return new(LinkState.Found, target, fragment, [id]);
        if (current.Documents.ContainsKey(id + ".md")) return new(LinkState.Found, target, fragment, [id + ".md"]);
        return new(LinkState.Missing, target, fragment, []);
    }

    public string Href(LinkResult result, string sourceId)
    {
        if (result.State == LinkState.External) return result.Target;
        if (result.Id is { } id)
        {
            if (id.EndsWith(".base", StringComparison.OrdinalIgnoreCase)) return BaseUrl(id);
            if (!id.EndsWith(".md", StringComparison.OrdinalIgnoreCase)) return AssetUrl(id);
            var fragment = result.Fragment;
            if (fragment.StartsWith('^')) fragment = fragment[1..];
            else if (fragment.Length > 0 && catalogue.Current.Documents.TryGetValue(id, out var document))
            {
                var headings = MarkdownSupport.GetHeadings(document);
                fragment = headings.FirstOrDefault(h => h.Text.Equals(fragment, StringComparison.OrdinalIgnoreCase) || h.Id.Equals(fragment, StringComparison.OrdinalIgnoreCase))?.Id ?? fragment;
            }
            return PageUrl(id) + (fragment.Length == 0 ? "" : "#" + Uri.EscapeDataString(fragment));
        }
        return "/resolve?target=" + Uri.EscapeDataString(result.Target) + "&from=" + Uri.EscapeDataString(sourceId);
    }

    public static string PageUrl(string id) => "/wiki?path=" + Uri.EscapeDataString(id);
    public static string AssetUrl(string id) => "/asset?path=" + Uri.EscapeDataString(id);
    public static string BaseUrl(string id) => "/base?path=" + Uri.EscapeDataString(id);
}
