# Pass Three — final reader verification

Checked on 2 September 2026. All three planned implementation passes are now present. This is an application report, not a change to setting canon.

## Completed

- An unobtrusive Reading panel: warm paper, night or device-following theme; 16–24 px prose; three line widths; optional position restoration; optional link previews.
- Persistent desktop navigation collapse, a separate narrow-window menu, readable prose widths, keyboard-scrollable wide tables and more room for maps.
- Source-excerpt previews after deliberate hover or keyboard focus. Previews are dismissible, can be hovered themselves, and never replace an unresolved-reference chooser with a guessed source.
- Browser-local bookmarks, recent articles and reading positions. Missing or renamed bookmarked files remain visible with a title-search route. A full bookmark shelf gives a notice instead of discarding an earlier bookmark.
- Local image/SVG-map enlargement with zoom, fit, actual size, pointer panning, wheel zoom, arrow controls, keyboard shortcuts and focus return. Existing source-authored image hyperlinks keep their original destination.
- Section permalinks, copyable source paths and an article-focused print layout. Closed article callouts open for printing and close afterward; selected Base pages are explicitly labelled collection excerpts.
- Visible focus, labelled controls, native modal focus handling, reduced-motion styles and contrast checks for text, muted text, links and accent colours in both themes.

The site-building guidance was used to extend the accepted encyclopedia design. There is no cloud deployment, tracking, new artwork, account system or change to the writing workflow.

## Verification

| Check | Result |
|---|---|
| Release build | Zero warnings; zero errors |
| .NET unit/component/HTTP tests | **83 passed**, zero failed/skipped |
| JavaScript helper/storage/style tests | **10 passed**, zero failed/skipped |
| Whole-vault rendering | **1,802 articles**, zero fatal errors |
| Source integrity | **1,941 files** hashed before/after; **zero changes** |
| Collections | All **12 Bases / 37 views** still pass fixture and live HTTP checks |
| Source relationships | **13,912** resolved article edges retained |
| Garden | All **75 stable anchors** retained in the served article |
| Release routes/assets | Home, shelf, search, collections, diagnostics, local reader assets and Blazor framework respond successfully |
| Blazor connection | Negotiation succeeds |
| JavaScript syntax | All three local reader scripts pass syntax checks |

New component tests cover preference persistence/clamping, theme/width/size controls, bookmarks and recent history, moved/deleted saved pages, a full bookmark shelf, exact section/block excerpts, stale-preview cancellation, preview disabling, restricted image targets, keyboard controls, desktop/mobile navigation states, section permalinks, copy/print actions and scrollable tables. JavaScript tests use pure helpers and mocked browser storage, not browser automation. They cover saved-state validation, vault separation, blocked storage, legacy-theme migration, preview URL restrictions, zoom mathematics, position-restoration precedence, print rules, reduced motion and normal-text contrast.

Representative real articles were checked over HTTP: the Garden, Grenzburg Map Package and Primarch Function Atlas. The checks confirm rendering and expected markup, not visual appearance or browser interaction.

## Performance and source notices

Release audit measurements:

- Initial catalogue: **1.57 s**.
- Derived search/link/Base index: **2.09 s**.
- Launcher to ready: approximately **7.7 s**, including its incremental build and polling.
- 200 warm searches: median **0.48 ms**, 95th percentile **0.75 ms**, maximum **0.97 ms**. These are search-operation timings, not browser paint timings.

The source notices remain unchanged: **893 ambiguous pairs, 28 missing pairs, 7 missing anchors and 48 archived metadata warnings**. They remain diagnostics; no lore was repaired or silently reclassified. No current Base produces an unsupported-expression warning.

The detailed report is `App_Data/pass-three-compatibility.json`. Earlier pass reports remain available as historical baselines.

## Browser-local storage and limits

The browser stores preferences, up to 100 bookmarks, 40 recent articles and positions for 80 articles, under a vault-specific key. This is not a content database or synchronization service. Clearing site data clears these conveniences; other browsers have separate shelves. Existing theme preferences migrate on first use. Blocked storage produces a visible warning, while readable saved data is retained.

Position restoration is opt-in. Explicit section links win over a saved position, and loading a revised open article does not trigger a saved-position jump. A heading-relative position is preferred; proportional restoration is the fallback when that heading no longer exists. Major source edits or late-loading media may change the exact line reached.

Very wide printed tables may need landscape paper. Printed Base collections contain the selected view/current page and say so. The image viewer enlarges local raster images and SVG maps; PDFs retain their original viewer link. No extra browser editing or full Obsidian-plugin emulation has been added.

## Short visual review route

Please refresh the existing tab at **http://localhost:5271** before reviewing. No screenshots, browser DOM inspection, automated clicking or resizing were performed.

1. **Long prose:** History → Historical Seed Garden. Try both themes, larger text and each width. Collapse the sidebar, bookmark the page, then reload and check the shelf.
2. **Dense table:** Collections → Bestiary Registry → By Origin. Try keyboard scrolling and print preview; the surrounding navigation should disappear in print.
3. **Map:** Playable settings → Grenzburg → Maps → Grenzburg Map Package. Click a map, zoom/pan with mouse and keyboard, then Escape; focus should return to its image link.
4. **Research:** Research & archives → Mythic and Sacred History → Primarch Function Atlas and World Egg Translation. Pause on a resolved article link, move into its excerpt, then dismiss it with Escape.
5. **Ambiguity:** Reader maintenance → ambiguous → Inspect reference. It should still offer source choices, never a misleading preview of an arbitrarily chosen duplicate.
6. **Narrow window:** Repeat an article, settings, a table and the image viewer. Enable position restoration, leave a long article partway through, and return without a section fragment.

The launcher-owned Release reader is intentionally left running for this review. **Stop Wiki.cmd** stops only its own recorded process. All planned passes are implemented; visual acceptance and any follow-up adjustments remain with the author.
