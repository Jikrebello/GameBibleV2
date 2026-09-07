using System.Text.Json;
using System.Text.Json.Serialization;

namespace WorldEgg.Wiki.Core;

public sealed record ReviewAnchor(
    string ExactText,
    string SelectedText,
    string Prefix,
    string Suffix,
    int StartOffset,
    int EndOffset);

public sealed record ReviewComment(
    Guid Id,
    string ArticleId,
    string ArticleTitle,
    ReviewAnchor Anchor,
    string Comment,
    DateTime CreatedUtc,
    DateTime UpdatedUtc,
    DateTime SourceModifiedUtc,
    bool Resolved);

public sealed class ReviewSelection
{
    public string ExactText { get; set; } = "";
    public string SelectedText { get; set; } = "";
    public string Prefix { get; set; } = "";
    public string Suffix { get; set; } = "";
    public int StartOffset { get; set; }
    public int EndOffset { get; set; }
    public double X { get; set; }
    public double Y { get; set; }

    public ReviewAnchor ToAnchor() => new(
        ExactText.TrimTo(6000),
        SelectedText.TrimTo(6000),
        Prefix.TrimTo(240),
        Suffix.TrimTo(240),
        Math.Max(0, StartOffset),
        Math.Max(StartOffset, EndOffset));
}

public sealed class ReviewCommentStore
{
    private sealed record ReviewFile(int Version, ReviewComment[] Comments);
    private static readonly JsonSerializerOptions Json = new(JsonSerializerDefaults.Web)
    {
        WriteIndented = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };
    private readonly string _path;
    private readonly VaultCatalogue _catalogue;
    private readonly SemaphoreSlim _gate = new(1, 1);
    private ReviewComment[]? _comments;

    public string Path => _path;

    public ReviewCommentStore(string path, VaultCatalogue catalogue)
    {
        _path = System.IO.Path.GetFullPath(path);
        _catalogue = catalogue;
    }

    public async Task<ReviewComment[]> ListAsync(string? articleId = null, bool includeResolved = true)
    {
        await _gate.WaitAsync();
        try
        {
            await LoadUnsafeAsync();
            return _comments!
                .Where(x => (articleId is null || x.ArticleId.Equals(articleId, StringComparison.OrdinalIgnoreCase)) && (includeResolved || !x.Resolved))
                .OrderBy(x => x.Resolved)
                .ThenBy(x => x.ArticleId, StringComparer.OrdinalIgnoreCase)
                .ThenBy(x => x.Anchor.StartOffset)
                .ThenBy(x => x.CreatedUtc)
                .ToArray();
        }
        finally { _gate.Release(); }
    }

    public async Task<ReviewComment> AddAsync(string articleId, ReviewAnchor anchor, string comment)
    {
        if (!_catalogue.Current.Documents.TryGetValue(articleId, out var document)) throw new InvalidOperationException("The article is no longer in the catalogue.");
        var cleaned = comment.Trim();
        if (cleaned.Length is < 1 or > 12000) throw new ArgumentException("A review comment must contain between 1 and 12,000 characters.", nameof(comment));
        if (anchor.ExactText.Length is < 1 or > 6000 || anchor.EndOffset <= anchor.StartOffset) throw new ArgumentException("Select article prose before adding a review comment.", nameof(anchor));

        await _gate.WaitAsync();
        try
        {
            await LoadUnsafeAsync();
            var now = DateTime.UtcNow;
            var item = new ReviewComment(Guid.NewGuid(), document.Id, document.Title, anchor, cleaned, now, now, document.ModifiedUtc, false);
            _comments = [.. _comments!, item];
            await SaveUnsafeAsync();
            return item;
        }
        finally { _gate.Release(); }
    }

    public async Task<ReviewComment?> SetResolvedAsync(Guid id, bool resolved)
    {
        await _gate.WaitAsync();
        try
        {
            await LoadUnsafeAsync();
            var index = Array.FindIndex(_comments!, x => x.Id == id);
            if (index < 0) return null;
            _comments![index] = _comments![index] with { Resolved = resolved, UpdatedUtc = DateTime.UtcNow };
            await SaveUnsafeAsync();
            return _comments[index];
        }
        finally { _gate.Release(); }
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        await _gate.WaitAsync();
        try
        {
            await LoadUnsafeAsync();
            var next = _comments!.Where(x => x.Id != id).ToArray();
            if (next.Length == _comments!.Length) return false;
            _comments = next;
            await SaveUnsafeAsync();
            return true;
        }
        finally { _gate.Release(); }
    }

    private async Task LoadUnsafeAsync()
    {
        if (_comments is not null) return;
        if (!File.Exists(_path)) { _comments = []; return; }
        try
        {
            await using var stream = File.OpenRead(_path);
            var stored = await JsonSerializer.DeserializeAsync<ReviewFile>(stream, Json);
            _comments = stored?.Comments ?? [];
        }
        catch (Exception ex) when (ex is JsonException or IOException or UnauthorizedAccessException)
        {
            throw new InvalidOperationException($"The review-comment file could not be read: {_path}", ex);
        }
    }

    private async Task SaveUnsafeAsync()
    {
        var directory = System.IO.Path.GetDirectoryName(_path)!;
        Directory.CreateDirectory(directory);
        var temporary = System.IO.Path.Combine(directory, $".{System.IO.Path.GetFileName(_path)}.{Guid.NewGuid():N}.tmp");
        try
        {
            await using (var stream = new FileStream(temporary, FileMode.CreateNew, FileAccess.Write, FileShare.None, 16 * 1024, FileOptions.WriteThrough))
                await JsonSerializer.SerializeAsync(stream, new ReviewFile(1, _comments!), Json);
            File.Move(temporary, _path, true);
        }
        finally { if (File.Exists(temporary)) File.Delete(temporary); }
    }
}

internal static class ReviewText
{
    public static string TrimTo(this string? value, int maximum)
    {
        var text = value?.Trim() ?? "";
        return text.Length <= maximum ? text : text[..maximum];
    }
}
