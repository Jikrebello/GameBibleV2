using System.Collections.Immutable;
using System.Globalization;
using System.Text;
using System.Threading.Channels;

namespace WorldEgg.Wiki.Core;

public sealed class VaultCatalogue(VaultPaths paths, ILogger<VaultCatalogue> logger) : BackgroundService
{
    private CatalogueSnapshot _current = CatalogueSnapshot.Empty;
    private readonly SemaphoreSlim _refreshLock = new(1);
    private readonly Channel<bool> _changes = Channel.CreateBounded<bool>(new BoundedChannelOptions(1) { FullMode = BoundedChannelFullMode.DropWrite });
    private FileSystemWatcher? _watcher;
    public CatalogueSnapshot Current => Volatile.Read(ref _current);

    public event Action? Changed;

    public double LastRefreshMilliseconds { get; private set; }

    public async Task RefreshAsync(CancellationToken cancellationToken = default)
    {
        await _refreshLock.WaitAsync(cancellationToken);
        try
        {
            var timer = System.Diagnostics.Stopwatch.StartNew();
            var old = Current;
            var documents = ImmutableDictionary.CreateBuilder<string, WikiDocument>(StringComparer.OrdinalIgnoreCase);
            var assets = ImmutableHashSet.CreateBuilder<string>(StringComparer.OrdinalIgnoreCase);
            var bases = ImmutableDictionary.CreateBuilder<string, BaseSource>(StringComparer.OrdinalIgnoreCase);
            var errors = new List<string>();
            foreach (var full in paths.EnumerateFiles())
            {
                cancellationToken.ThrowIfCancellationRequested();
                var id = paths.ToId(full);
                if (id is null) continue;
                var isBase = id.EndsWith(".base", StringComparison.OrdinalIgnoreCase);
                if (!id.EndsWith(".md", StringComparison.OrdinalIgnoreCase)) { assets.Add(id); if (!isBase) continue; }
                try
                {
                    var info = new FileInfo(full);
                    if (isBase && old.Bases.TryGetValue(id, out var priorBase) && priorBase.ModifiedUtc == info.LastWriteTimeUtc && priorBase.Length == info.Length)
                    { bases[id] = priorBase; continue; }
                    if (old.Documents.TryGetValue(id, out var prior) && prior.ModifiedUtc == info.LastWriteTimeUtc && prior.Length == info.Length)
                    { documents[id] = prior; continue; }
                    string? source = null;
                    for (var attempt = 0; attempt < 3; attempt++)
                    {
                        try { source = await File.ReadAllTextAsync(full, cancellationToken); break; }
                        catch (IOException) when (attempt < 2) { await Task.Delay(100, cancellationToken); }
                    }
                    if (isBase) bases[id] = new(id, source!, info.LastWriteTimeUtc, info.Length);
                    else documents[id] = DocumentParser.Parse(id, source!, info.LastWriteTimeUtc, info.Length);
                }
                catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
                {
                    errors.Add($"{id}: {ex.Message}");
                    if (isBase) bases[id] = new(id, "", default, 0, "This collection is temporarily unreadable: " + ex.Message);
                    if (old.Documents.TryGetValue(id, out var prior)) documents[id] = prior with { Error = "The file is temporarily unreadable; showing the last readable version." };
                }
            }
            Volatile.Write(ref _current, new CatalogueSnapshot(documents.ToImmutable(), assets.ToImmutable(), errors.ToArray(), old.Version + 1) { Bases = bases.ToImmutable() });
            LastRefreshMilliseconds = timer.Elapsed.TotalMilliseconds;
            logger.LogInformation("Indexed {Count} Markdown articles and {Assets} attachments", documents.Count, assets.Count);
            if (Changed is { } handlers)
                foreach (Action handler in handlers.GetInvocationList())
                    try { handler(); } catch (Exception ex) { logger.LogWarning(ex, "A reader could not receive the change notice"); }
        }
        finally { _refreshLock.Release(); }
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _watcher = new(paths.Root) { IncludeSubdirectories = true, NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite | NotifyFilters.Size };
        void Change(string full)
        {
            var relative = Path.GetRelativePath(paths.Root, full).Replace('\\', '/');
            if (VaultPaths.ContentRoots.Any(r => relative.Equals(r, StringComparison.OrdinalIgnoreCase) || relative.StartsWith(r + "/", StringComparison.OrdinalIgnoreCase))) _changes.Writer.TryWrite(true);
        }
        _watcher.Changed += (_, e) => Change(e.FullPath);
        _watcher.Created += (_, e) => Change(e.FullPath);
        _watcher.Deleted += (_, e) => Change(e.FullPath);
        _watcher.Renamed += (_, e) => { Change(e.OldFullPath); Change(e.FullPath); };
        _watcher.Error += (_, _) => _changes.Writer.TryWrite(true);
        _watcher.EnableRaisingEvents = true;
        try
        {
            while (await _changes.Reader.WaitToReadAsync(stoppingToken))
            {
                await Task.Delay(400, stoppingToken);
                while (_changes.Reader.TryRead(out _)) { }
                try { await RefreshAsync(stoppingToken); }
                catch (Exception ex) when (ex is not OperationCanceledException) { logger.LogError(ex, "Rescan failed; retaining the previous catalogue"); }
            }
        }
        catch (OperationCanceledException) when (stoppingToken.IsCancellationRequested) { }
        finally { _watcher.Dispose(); }
    }

    public IEnumerable<WikiDocument> FindTitles(string query, int limit = 60)
    {
        var needle = Fold(query.Trim());
        if (needle.Length == 0) return [];
        return Current.Documents.Values.Select(d => new { Document = d, Rank = Score(d, needle) })
            .Where(x => x.Rank > 0).OrderByDescending(x => x.Rank).ThenBy(x => x.Document.Title).ThenBy(x => x.Document.Id)
            .Take(limit).Select(x => x.Document).ToArray();
    }

    private static int Score(WikiDocument d, string q)
    {
        var names = d.Aliases.Append(d.Title).Append(Path.GetFileNameWithoutExtension(d.Id)).Select(Fold);
        return names.Select(n => n == q ? 3 : n.StartsWith(q, StringComparison.Ordinal) ? 2 : n.Contains(q, StringComparison.Ordinal) ? 1 : 0).Max();
    }

    public static string Fold(string value) => string.Concat(value.Normalize(NormalizationForm.FormD).Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)).Normalize().ToLowerInvariant();
}