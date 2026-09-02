using MudBlazor.Services;
using WorldEgg.Wiki.Components;
using WorldEgg.Wiki.Core;

var builder = WebApplication.CreateBuilder(args.Where(a => a != "--audit").ToArray());
// The local launcher runs compiled output in Production, not a published copy.
// Load the build manifest so framework and MudBlazor assets remain available offline.
builder.WebHost.UseStaticWebAssets();
var root = builder.Configuration["Wiki:VaultRoot"];
if (string.IsNullOrWhiteSpace(root)) root = Path.GetFullPath(Path.Combine(builder.Environment.ContentRootPath, "../.."));
if (!Directory.Exists(root) || !VaultPaths.ContentRoots.Any(r => Directory.Exists(Path.Combine(root, r)))) throw new InvalidOperationException("Wiki:VaultRoot must point to the Obsidian vault, not an application or publishing directory.");
var port = builder.Configuration.GetValue<int?>("Wiki:Port") ?? 5271;
if (port is < 1024 or > 65535) throw new InvalidOperationException("Choose a local port between 1024 and 65535.");
builder.WebHost.UseUrls($"http://localhost:{port}");
builder.Services.AddRazorComponents().AddInteractiveServerComponents().AddHubOptions(options => options.MaximumReceiveMessageSize = 512 * 1024);
builder.Services.AddMudServices();
builder.Services.AddSingleton(new VaultPaths(root));
builder.Services.AddSingleton<VaultCatalogue>();
builder.Services.AddHostedService(p => p.GetRequiredService<VaultCatalogue>());
builder.Services.AddSingleton<LinkResolver>();
builder.Services.AddSingleton<ArticleRenderer>();
builder.Services.AddSingleton<BaseLibrary>();
builder.Services.AddSingleton<LibraryIndex>();
builder.Services.AddSingleton<ArticlePreviews>();
builder.Services.AddScoped<ReadingLibrary>();
var app = builder.Build();
app.Use(async (context, next) =>
{
    if (context.Connection.RemoteIpAddress is { } address && !System.Net.IPAddress.IsLoopback(address)) { context.Response.StatusCode = 403; return; }
    if (context.Request.Host.Host is not ("localhost" or "127.0.0.1" or "[::1]" or "::1")) { context.Response.StatusCode = 403; return; }
    if (context.Request.Headers.Origin is { Count: > 0 } origin && (!Uri.TryCreate(origin[0], UriKind.Absolute, out var originUri) || !originUri.IsLoopback || originUri.Port != (context.Request.Host.Port ?? 80))) { context.Response.StatusCode = 403; return; }
    context.Response.Headers["X-Content-Type-Options"] = "nosniff";
    context.Response.Headers["Referrer-Policy"] = "no-referrer";
    context.Response.Headers["Content-Security-Policy"] = "default-src 'self'; script-src 'self' 'unsafe-inline'; style-src 'self' 'unsafe-inline'; img-src 'self' data:; connect-src 'self' ws://localhost:* ws://127.0.0.1:*; object-src 'none'; base-uri 'self'; frame-ancestors 'none'";
    await next();
});
app.UseStaticFiles();
app.UseAntiforgery();
app.MapStaticAssets();
app.MapGet("/health", (VaultCatalogue catalogue) => Results.Json(new { application = "WorldEgg.Wiki", pass = 3, articles = catalogue.Current.Documents.Count, collections = catalogue.Current.Bases.Count, processId = Environment.ProcessId, instance = Environment.GetEnvironmentVariable("WORLDEGG_INSTANCE") ?? "manual" }));
app.MapGet("/asset", (string path, VaultPaths paths, VaultCatalogue catalogue, HttpContext context) =>
{
    if (!catalogue.Current.Assets.Contains(path) || paths.SafeFullPath(path) is not { } full || !File.Exists(full)) return Results.NotFound();
    var mime = Path.GetExtension(path).ToLowerInvariant() switch { ".png" => "image/png", ".jpg" or ".jpeg" => "image/jpeg", ".gif" => "image/gif", ".webp" => "image/webp", ".svg" => "image/svg+xml", ".pdf" => "application/pdf", _ => "" };
    if (mime.Length == 0) return Results.NotFound();
    context.Response.Headers["Content-Security-Policy"] = "sandbox; default-src 'none'; style-src 'unsafe-inline'";
    return Results.File(full, mime, enableRangeProcessing: true);
});
app.MapRazorComponents<App>().AddInteractiveServerRenderMode();
await app.Services.GetRequiredService<VaultCatalogue>().RefreshAsync();
_ = app.Services.GetRequiredService<LibraryIndex>().Current;
if (args.Contains("--audit"))
{
    var catalogue = app.Services.GetRequiredService<VaultCatalogue>();
    var renderer = app.Services.GetRequiredService<ArticleRenderer>();
    var json = await CompatibilityAudit.RunAsync(app.Services.GetRequiredService<VaultPaths>(), catalogue, renderer, app.Services.GetRequiredService<LibraryIndex>(), app.Services.GetRequiredService<BaseLibrary>());
    if (builder.Configuration.GetValue<bool>("Audit:Save"))
    {
        var outputDirectory = Path.Combine(builder.Environment.ContentRootPath, "App_Data");
        Directory.CreateDirectory(outputDirectory);
        var output = Path.Combine(outputDirectory, "pass-three-compatibility.json");
        await File.WriteAllTextAsync(output, json);
        Console.WriteLine("Compatibility report: " + output);
    }
    else Console.WriteLine(json);
    return;
}
await app.RunAsync();
public partial class Program { }
