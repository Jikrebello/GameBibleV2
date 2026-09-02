using Microsoft.JSInterop;
using System.Security.Cryptography;
using System.Text;

namespace WorldEgg.Wiki.Core;

public sealed record ReadingPreferences
{
    public string Theme { get; init; } = "system";
    public int TextSize { get; init; } = 18;
    public string Width { get; init; } = "standard";
    public bool RestorePosition { get; init; }
    public bool NavigationCollapsed { get; init; }
    public bool Previews { get; init; } = true;
    public ReadingPreferences Normalize() => this with { Theme = Theme is "light" or "dark" ? Theme : "system", TextSize = Math.Clamp(TextSize, 16, 24), Width = Width is "narrow" or "wide" ? Width : "standard" };
}
public sealed record SavedReading(string Id, string Title, DateTime UpdatedUtc);
public sealed record ReadingSnapshot
{
    public ReadingPreferences Preferences { get; init; } = new();
    public SavedReading[] Bookmarks { get; init; } = [];
    public SavedReading[] Recent { get; init; } = [];
    public bool StorageAvailable { get; init; } = true;
}

// Scoped to one interactive circuit. Only the browser persists these preferences and lists.
public sealed class ReadingLibrary(IJSRuntime js, VaultPaths paths)
{
    private readonly SemaphoreSlim _gate = new(1);
    public string StorageKey { get; } = "worldegg.reading." + Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(paths.Root.ToUpperInvariant())))[..16].ToLowerInvariant();
    public ReadingSnapshot Current { get; private set; } = new();
    public bool Initialized { get; private set; }
    public string? Notice { get; private set; }

    public event Action? Changed;

    public bool IsBookmarked(string id) => Current.Bookmarks.Any(b => b.Id.Equals(id, StringComparison.OrdinalIgnoreCase));

    public async Task InitializeAsync()
    {
        await _gate.WaitAsync();
        try
        {
            if (Initialized) return;
            var loaded = await js.InvokeAsync<ReadingSnapshot?>("worldEgg.reading.load", StorageKey) ?? new();
            Current = loaded with { Preferences = (loaded.Preferences ?? new()).Normalize(), Bookmarks = Clean(loaded.Bookmarks, 100), Recent = Clean(loaded.Recent, 40) };
            Initialized = true;
        }
        finally { _gate.Release(); }
        Changed?.Invoke();
    }

    public Task SetPreferencesAsync(ReadingPreferences preferences) => Change(s => s with { Preferences = preferences.Normalize() });

    public async Task ToggleBookmarkAsync(WikiDocument document)
    {
        await InitializeAsync();
        if (!IsBookmarked(document.Id) && Current.Bookmarks.Length >= 100) { Notice = "This browser shelf holds 100 bookmarks. Remove one before adding another."; Changed?.Invoke(); return; }
        Notice = null;
        await Change(s => s with
        {
            Bookmarks = s.Bookmarks.Any(b => b.Id.Equals(document.Id, StringComparison.OrdinalIgnoreCase))
            ? s.Bookmarks.Where(b => !b.Id.Equals(document.Id, StringComparison.OrdinalIgnoreCase)).ToArray()
            : new[] { new SavedReading(document.Id, document.Title, DateTime.UtcNow) }.Concat(s.Bookmarks).ToArray()
        });
    }

    public Task RemoveBookmarkAsync(string id) => Change(s => s with { Bookmarks = s.Bookmarks.Where(b => !b.Id.Equals(id, StringComparison.OrdinalIgnoreCase)).ToArray() });

    public Task VisitAsync(WikiDocument document) => Change(s => s with { Recent = new[] { new SavedReading(document.Id, document.Title, DateTime.UtcNow) }.Concat(s.Recent.Where(b => !b.Id.Equals(document.Id, StringComparison.OrdinalIgnoreCase))).Take(40).ToArray() });

    public Task ClearRecentAsync() => Change(s => s with { Recent = [] });

    private async Task Change(Func<ReadingSnapshot, ReadingSnapshot> change)
    {
        await InitializeAsync(); await _gate.WaitAsync();
        try
        {
            Current = change(Current);
            var saved = await js.InvokeAsync<bool>("worldEgg.reading.save", StorageKey, Current);
            Current = Current with { StorageAvailable = saved };
        }
        finally { _gate.Release(); }
        Changed?.Invoke();
    }

    private SavedReading[] Clean(SavedReading[]? entries, int limit) => (entries ?? []).Where(b => b is not null && b.Id is { Length: > 0 and <= 1024 } && b.Title is { Length: > 0 and <= 400 } && b.Id.EndsWith(".md", StringComparison.OrdinalIgnoreCase) && paths.SafeFullPath(b.Id) is not null).DistinctBy(b => b.Id, StringComparer.OrdinalIgnoreCase).Take(limit).ToArray();
}