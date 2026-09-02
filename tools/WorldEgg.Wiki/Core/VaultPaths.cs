namespace WorldEgg.Wiki.Core;

public sealed class VaultPaths
{
    public static readonly string[] ContentRoots = ["00 Start Here", "01 Canon Reference", "02 Playable Settings", "03 Stories & In-World Texts", "90 Archive & Drafts", "99 Templates"];
    public static readonly HashSet<string> AssetExtensions = new(StringComparer.OrdinalIgnoreCase) { ".png", ".jpg", ".jpeg", ".gif", ".webp", ".svg", ".pdf", ".base" };
    public string Root { get; }
    public string Name => System.IO.Path.GetFileName(Root);

    public VaultPaths(string root) => Root = System.IO.Path.TrimEndingDirectorySeparator(System.IO.Path.GetFullPath(root));

    // Never follow a junction/symlink, including one placed inside an allowed tree.
    public string? SafeFullPath(string relative)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(relative) || relative.Contains('\0') || System.IO.Path.IsPathRooted(relative)) return null;
            var full = System.IO.Path.GetFullPath(System.IO.Path.Combine(Root, relative.Replace('/', System.IO.Path.DirectorySeparatorChar)));
            if (!full.StartsWith(Root + System.IO.Path.DirectorySeparatorChar, StringComparison.OrdinalIgnoreCase)) return null;
            var id = System.IO.Path.GetRelativePath(Root, full).Replace('\\', '/');
            if (!ContentRoots.Any(r => id.StartsWith(r + "/", StringComparison.OrdinalIgnoreCase))) return null;
            var cursor = full;
            while (!cursor.Equals(Root, StringComparison.OrdinalIgnoreCase))
            {
                if ((File.Exists(cursor) || Directory.Exists(cursor)) && (File.GetAttributes(cursor) & FileAttributes.ReparsePoint) != 0) return null;
                cursor = System.IO.Path.GetDirectoryName(cursor)!;
            }
            return full;
        }
        catch (Exception ex) when (ex is ArgumentException or IOException or UnauthorizedAccessException or NotSupportedException) { return null; }
    }

    public string? ToId(string full)
    {
        try
        {
            var id = System.IO.Path.GetRelativePath(Root, full).Replace('\\', '/');
            return SafeFullPath(id) is null ? null : id;
        }
        catch (Exception ex) when (ex is ArgumentException or IOException) { return null; }
    }

    public IEnumerable<string> EnumerateFiles()
    {
        foreach (var root in ContentRoots)
        {
            var directory = System.IO.Path.Combine(Root, root);
            if (!Directory.Exists(directory) || (File.GetAttributes(directory) & FileAttributes.ReparsePoint) != 0) continue;
            foreach (var file in Directory.EnumerateFiles(directory, "*", new EnumerationOptions { RecurseSubdirectories = true, AttributesToSkip = FileAttributes.ReparsePoint, IgnoreInaccessible = true }))
                if (file.EndsWith(".md", StringComparison.OrdinalIgnoreCase) || AssetExtensions.Contains(System.IO.Path.GetExtension(file))) yield return file;
        }
    }
}
