# Pass One — delivery verification

Checked on 2 September 2026. This is an application report, not a change to setting canon.

## Completed

- Release build: **zero warnings, zero errors**.
- Automated tests: **27 passed, zero failed, zero skipped**. Unit, component and HTTP tests use disposable fixture vaults.
- Full-vault rendering: **1,802 Markdown articles and 139 attachments indexed; zero fatal rendering errors**.
- Source integrity: SHA-256 checked **1,941 files before and after the audit; zero changes**.
- All **75 Garden block anchors** are present in the served article. Multiple Atlas anchors sharing one passage are also preserved.
- Representative HTTP checks passed for the World Historical Atlas, Garden, Ättar overview, Grenzburg map package, Under-Caleran diagram and Mythic and Sacred History research index.
- Production-mode HTTP checks passed for local CSS, JavaScript, MudBlazor assets, the Blazor framework and bundled Mermaid. Blazor connection negotiation succeeded.
- Launchers tested: start, repeat start without duplication, verified stop and restart. An occupied port was refused without changing its existing process; the stop launcher left a manually started instance alone.
- JavaScript and PowerShell syntax checks passed. Git whitespace checks passed.

Tests cover aliases and accents, local versus ambiguous names, explicit missing paths, headings and block IDs, multiple anchors, Markdown tables, image sizes, callouts, diagrams, footnotes, code preservation, note/section/block embeds, cycle and depth limits, Base placeholders, malformed metadata, unsafe schemes, path traversal, cross-origin requests, attachment restrictions, source integrity, file changes/renames/deletions, source labels and opt-in refresh of open articles.

## Existing source notices

The report retains these as source-level notices, not fatal reader errors:

| Notice | Count | Behaviour |
|---|---:|---|
| Ambiguous source/target pairs | 893 | Present a source choice; do not select an archived duplicate silently. |
| Missing source/target pairs | 28 | Keep the reference visible and explain that the target is missing. |
| Missing heading/block references | 7 | Open the existing article while reporting the unmatched anchor. |
| Metadata warnings | 48 | Keep article text readable and show the warning. |

Counts are unique target notices within each source article, not unique names across the vault. The metadata warnings are in older archived files; inspected examples contain unescaped Windows backslashes in double-quoted YAML values. No source repair was attempted. The full per-article report is in the ignored `App_Data/pass-one-compatibility.json` and can be regenerated with the README command.

## Author review still required

No browser screenshots, DOM inspection or automated browser interaction were performed. Please review typography, theme contrast, narrow-window layouts, diagrams and navigation using the route in the README. If the initial preview is still open, refresh it to load the final scripts and styles.

The server is intentionally left running on `http://localhost:5271` for that review. Use **Stop Wiki.cmd** afterward.

## Pass boundary

Pass Two's full-text search, metadata filters, live Base tables, backlinks and maintenance screen remain unimplemented. Pass Three's previews, bookmarks, reading-position preferences, map zoom and printing refinements also remain unimplemented. The site-building guidance was used for the article-first layout and staged local preview; no hosting or cloud publication was performed.
