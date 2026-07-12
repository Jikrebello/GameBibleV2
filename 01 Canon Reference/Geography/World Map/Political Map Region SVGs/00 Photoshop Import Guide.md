---
type: reference
status: draft
canon_level: core
visibility: author-only
era: ["Present Day", "1360 AR"]
region: ["Known World"]
culture: []
related_factions: ["Ahl-e-Ahd", "Thalmyric Empire", "Sestaran Concord", "Eclessia", "Ättar", "Enaidfae"]
appears_in: []
needs: ["replace proof coordinates with creator-adjusted Photoshop placements"]
tags: ["needs-review"]
---
# Photoshop Import Guide

This folder contains one transparent SVG for every political block in [[Political World Map - Border Proof]]. Every SVG uses the same **2273 × 1091** artboard as `World Map (Southern Hemisphere).png`. No file contains the parchment base map, number label, context label, legend, or another territory.

## Import

1. Open `World Map (Southern Hemisphere).png` as the Photoshop document at its native 2273 × 1091 size.
2. Use **File → Place Embedded** or **Place Linked** for each SVG.
3. Import at 100% scale and align the placed layer to the document's upper-left corner (`X: 0`, `Y: 0`).
4. Do not trim transparent pixels or rasterize to the visible shape's bounding box before placement.
5. Move and reshape each territory as needed, keeping every political unit on its own named layer.

The filenames begin with the same IDs used by [[Political Map Border Proof Key]]. The IDs are sorting tools only and are not drawn inside the SVGs.

## File Groups

- `A1–A5`: Ahl-e-Ahd and the disputed Velian belt
- `T1–T6`: Thalmyria
- `C1–C5`: Sestaran Concord
- `E1–E9`: Eclessia
- `AT1–AT4`: Ättar customary ranges
- `F1–F4`: Folk and Enaidfae customary territories

`T4 - Saronika.svg` includes Saronika's mainland/coastal shape and both associated island pieces. `C3 - Sermora.svg` includes Sermora's principal shape and associated island. `A5 - Velian States.svg` retains its disputed hatch. Ättar and Folk files retain dashed customary-frontier strokes.

## Reassembly

Once the blocks are positioned, export one transparent political overlay at exactly 2273 × 1091. That corrected overlay can replace the proof geometry in the editable master before capitals, cities, labels, roads, and the final legend are added.

## Navigation

- [[Political Map Border Proof Key]]
- [[Gazetteer of the Known World]]
- [[Geography Atlas]]
