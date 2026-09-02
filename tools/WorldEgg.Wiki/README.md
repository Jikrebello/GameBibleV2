# World Egg Wiki — Complete Reader

A private, read-only encyclopedia over the existing Obsidian vault. Canon, playable material, stories, research, archives and templates are all included. Markdown stays where it is and remains the only content source.

## Start and stop

Double-click **Start Wiki.cmd** in this folder. It builds the reader, opens `http://localhost:5271`, and keeps the local server running in the background. Double-click **Stop Wiki.cmd** when finished. The stop launcher verifies the recorded process, start time and application path before stopping anything.

The .NET 10 SDK is required. The first dependency restore needs Internet access. Once restored, the launcher's builds and the local reader work offline. External source websites naturally still require a connection. Fonts use local Georgia and Segoe UI/Arial; MudBlazor and Mermaid are served locally. There is no CDN request at runtime.

From PowerShell in this folder:

```powershell
.\Start-Wiki.ps1
.\Stop-Wiki.ps1
# Optional: another local port, without opening a browser
.\Start-Wiki.ps1 -Port 5272 -NoBrowser
```

For foreground development:

```powershell
dotnet restore WorldEgg.Wiki.slnx --locked-mode
dotnet run --project WorldEgg.Wiki.csproj --no-launch-profile
```

Stop a foreground instance with Ctrl+C. The stop launcher deliberately does not kill instances it did not start. Do not run the foreground and launcher instances on the same port. An occupied port is an error, not permission to terminate its owner.

If package references change, run the restore command again before the launcher. Runtime logs and process identity live in ignored `App_Data`; generated build outputs and test results are also ignored. Nothing starts automatically when Windows starts.

## Read and navigate

- Begin with the home page or World Historical Atlas. The left navigation also reaches every source folder.
- The top search covers titles, aliases, filenames, headings and article bodies, including archives and templates. Press **Ctrl+K** (or **⌘K**) to focus it; **/** also works outside a text field. Press Enter to search.
- Exact titles and aliases outrank partial names, heading matches and body matches. Searching is case- and accent-tolerant. Put a phrase in quotation marks to require that phrase. Unquoted words must all occur, or match a partial title/alias.
- Filter by source area, type, status, era, region or culture. Filters use existing metadata only; the absence of a field is not a guessed classification. Clear filters to search everything again.
- **Articles A–Z** provides a complete title index. **Collections** lists the twelve Bases, metadata groupings and existing index pages. **Linked articles / Backlinks** appears beneath each article and contains only explicit, resolved source references.
- Source labels keep folder location, declared status, canon level and visibility separate. They are not authentication or an assessment of truth.
- Ambiguous references open a choice of source paths. Broken references remain visible; the reader never creates or repairs lore files.
- A change notice appears when the vault changes. Choose **Load latest version** to refresh an open article; automatic indexing does not replace text underneath you.
- **Open in Obsidian** hands the original article to the installed Obsidian application.

## Supported in this pass

Markdown prose, tables, footnotes, callouts, wikilinks and aliases, relative Markdown links, vault-local absolute links, heading links, stable Obsidian block IDs, local images/SVG maps/PDF links, Mermaid diagrams, and note/heading/block embeds. Embeds stop at cycles, four nested documents or a per-article budget of thirty expansions. Missing sections and unsupported attachments are reported explicitly.

All twelve existing `.base` files render as read-only MudBlazor tables, with all 37 named views, source filters, columns, grouping, sorting and the coverage formula. Tables work inside index-page embeds and on their own collection pages. Select another view, page through results, or click a column header for temporary sorting; **Restore source order** returns to the definition. No action writes to the Base.

The Base interpreter follows the supported subset of [Obsidian’s documented syntax](https://obsidian.md/help/bases/syntax) and [functions](https://obsidian.md/help/bases/functions): typed comparisons, Boolean groups/operators, folder membership, list/string containment, lengths and named formula references. It never evaluates JavaScript or runs Obsidian plugins. Unsupported or malformed expressions produce warnings and no results for the affected view, rather than an unfiltered fallback. Circular formulas are rejected. Formula/expression nesting is limited to 64 levels.

Bases consider every file in the six approved content trees, including allowed attachments, not only Markdown. Missing metadata is null, distinct from an explicitly empty string; `field != ""` therefore does not require that the field exist. Numeric YAML values sort numerically; quoted numeric strings remain strings. Null sort values are placed last. These rules are deliberately not rewritten to infer the author's intended query. Metadata wikilinks remain clickable and preserve ambiguity handling.

**Reader maintenance** lists malformed metadata, missing/ambiguous references, missing sections, unsupported plugin syntax and Base evaluation errors. It never repairs source files or declares a version canonical. Search, collections, diagnostics and relationships refresh on file changes; article prose retains its opt-in reload notice.

Source HTML is sanitized. External images are not fetched automatically. SVG/PDF assets are sandboxed; Git internals, settings, application code, out-of-vault files and symlinked content are not served.

Names identify articles for reading, but lossless vault-relative paths identify URLs. A rename therefore changes the page URL; no source files are rewritten to add permanent website IDs.

## Reading comforts

- **Reading** in the header opens the theme, text-size and line-width settings. The desktop menu button collapses the left navigation; narrow windows have their own temporary menu. Light, dark and device-following themes are supported.
- **Bookmark** beside an article keeps it on **Your reading shelf**. The shelf also holds the last forty distinct articles read. It can hold one hundred bookmarks; reaching that limit produces a notice rather than deleting an older bookmark. A renamed or deleted file remains visible with a title-search link, never an automatic guess at its replacement.
- Enable **Resume articles where I left off** to save positions for the last eighty articles. Positions use a nearby heading where possible, with proportional fallback if it disappears. Explicit section links take precedence; **Load latest version** does not apply a saved-position jump.
- Pause on a resolved article link or focus it with the keyboard for a source excerpt. Move into the preview to follow its link; move away or press Escape to dismiss it. Ambiguous references retain their chooser instead. Previews can be disabled in Reading settings.
- Click an unlinked local image or map to enlarge it. Drag or use arrow controls to pan; use **+ / −**, the zoom buttons or the wheel to zoom. **0 / Fit** restores the whole image; **Actual size** uses its intrinsic size. Escape closes the viewer and returns focus to the image link. Images which are already part of a source-authored hyperlink keep that original destination.
- The **¶** beside each section heading is a normal permalink. **Copy source path** copies the vault-relative Markdown path. **Print** produces article-focused output with the source path, expanded callouts, footnotes and images, without navigation or reading controls. Collection tables print their selected view/current page, labelled as excerpts. Very wide tables may benefit from landscape paper.

Preferences, bookmarks, recent pages and reading positions persist only in this browser's local storage, separately for each vault. They are not written into Markdown, application files, a database or a publishing folder. Clearing site data clears them. If browser storage is blocked, the reader reports that preferences may not survive a reload. Existing light/dark preferences from earlier passes migrate on first use.

## Verification

```powershell
dotnet test WorldEgg.Wiki.slnx
node --test tests/reading.test.cjs
dotnet run --project WorldEgg.Wiki.csproj --no-launch-profile -- --audit
# Save the detailed report inside the application's ignored App_Data folder
dotnet run --project WorldEgg.Wiki.csproj --no-launch-profile -- --audit --Audit:Save true
```

The .NET tests cover units, components and HTTP routes against disposable fixture vaults. The optional Node command checks the browser-state helpers, zoom/position mathematics, mocked storage, theme contrast and print stylesheet without driving a browser; Node is not required to run the reader. The audit command reads the real vault and writes a JSON compatibility report to standard output (preceded by startup logs). It does not start another listening server or edit articles. Existing missing/ambiguous links are reported separately from fatal rendering errors. Use a separate build output or stop the foreground reader before rebuilding on Windows.

No browser screenshots, DOM inspection or automated browser interactions are part of this delivery. Visual review belongs to the author.

See **PASS-THREE-VERIFICATION.md** for current delivery checks. The earlier pass reports remain historical baselines. The regenerated report is `App_Data/pass-three-compatibility.json`; it includes all Base views, link diagnostics, indexing timings, warm-search benchmarks and before/after source hashes.

When the launcher-owned Release reader is running, use `dotnet test tests/WorldEgg.Wiki.Tests.csproj -c Debug -p:UseAppHost=false --no-restore` to test separate Debug output without interrupting it.

### Your review route

1. Home → World Historical Atlas → an age: check prose, headings and contents.
2. Peoples & cultures → Ättar: check accented names and links.
3. Playable settings → Grenzburg → Maps → Grenzburg Map Package: check maps embedded in tables.
4. Caleran → Under-Caleran Overview and Access Overlay: check the Mermaid diagram.
5. Research & archives → Mythic and Sacred History: check source labels and long research pages.
6. Find `Archive Index` or `Mother Moon`: compare similarly named current and archived sources.
7. Collections → Bestiary Registry: switch between Coverage, By Origin and Quest Ready. Check columns, groups and the Forms count. Open Canon Index to compare the embedded table.
8. Try light/dark themes and a narrow window. Edit an article normally in Obsidian and check its change notice.

9. Search a phrase from an article body; filter to archives, then clear the filter. Compare `Ättar` and `attar`.
10. Open an article’s backlinks, then Reader maintenance → ambiguous. Confirm that unresolved names are kept separate from actual relationships.

11. Change the Reading settings, bookmark an article, and reload. Check the saved shelf and optional position restoration.
12. Pause on or keyboard-focus an article link; dismiss its preview with Escape. Enlarge a map, try the arrow/zoom controls, then close it.
13. Open print preview for a long article and a dense table. Repeat the reading route in a narrow window.

All three planned passes are implemented. Browser editing, public/player-safe publishing, accounts, AI-generated summaries and automatic lore corrections remain outside this reader.

## Vendored dependency

`wwwroot/vendor/mermaid.min.js`: Mermaid 11.17.2, MIT, downloaded from the package's distribution on jsDelivr. SHA-256: `581ED7D74BD9048D0E3A91363927D72EF22942D7722546B27F7CC29E35390EB8`. Its licence is adjacent. NuGet versions are recorded in project files and package lockfiles.
