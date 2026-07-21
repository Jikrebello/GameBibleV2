---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Grenz Lowlands", "Longlake Country", "Wolfsmere Woods", "Southwood Barrowlands", "Highlake Uplands", "Upper Grenz", "Frostfenn March"]
culture: ["Eclessian", "Folk", "Grobi"]
related_factions: ["Duchy of Grenzburg", "Blackjack Corps", "Church of the Redeemer", "Folk kindreds"]
appears_in: ["Grenzburg"]
needs: []
aliases: []
tags: [game-ready]
quest_class: aftermath
act: summer
availability_window: ["Summer Aftermath"]
repeatability: one-shot
cutoff_result: persists
world_state_outputs: ["reconstruction_priority", "summer_regional_access", "summer_postgame_open"]
required_locations: ["Grenz Lowlands", "Upper Grenz", "Longlake Country", "Highlake Uplands", "Frostfenn March"]
blocking_status: blocked
quest_owner: "Grenzburg Main Campaign"
quest_sequence: 0
companion_id: ""
faction_line: ""
faction_branch: ""
chapter_id: "SQ-02"
main_sequence: 23
story_gate: postgame-open
estimated_hours: 2.5
gameplay_pillars: [travel, consequence, reconstruction, combat, choice]
required_states: ["political_settlement_composed"]
optional_state_inputs: ["all_region_states", "grobi_aftermath_state", "emerald_law_gem_custody", "deep_muster_site_state", "companion_destinations_locked"]
---
# The First Summer Road

## Quest Function

This quest carries the ending back into the world. The player travels a physically changed corridor, solves one immediate reconstruction problem, and chooses where Grenzburg commits its first major summer effort. Completion opens persistent summer play; it is not a disguised credits sequence.

## Trigger and Commitment

After the memorial, Liese asks the protagonist to travel with the first public reconstruction convoy. The player may prepare freely and chooses one of four corridors. The unchosen routes remain available in summer with fewer immediate resources; no region is permanently deleted.

## Beginning: Through the Funnel

Every version leaves Grenzburg through the Grenz Lowlands. The convoy passes repaired, ruined, or occupied traces of the opening campaign: Funnel Camp, the Three Mills road, Broken Tollworks, and the Black Road approach.

A compact gameplay problem establishes the summer tone. Depending on state, the player clears a collapsed bridge, settles a returning household dispute, escorts released prisoners, drives off ordinary predators, or recovers a missing supply cart. The world no longer waits for apocalypse, but action still matters.

## Middle: Four Reconstruction Corridors

### River and Fort Road

Travel through Timberfalls to Tannbruck. The core problem is choosing between bridge and transport repair, permanent homes, or military restoration. Muster and siege damage, saved fort material, and ducal terms alter the available work.

### Lake, Wood, and Barrow Road

Travel through Lakewatch toward Wolfsmere's outer boundary and Southwood. The core problem is balancing ferries and fuel with sanctuary limits and the ecological aftermath of the Drake. Law-gem custody supplies a distinct visible intervention without becoming a universal solution.

### Highlake and Tuskway Road

Travel to Highlake and the upland redoubt. The core problem is reopening extraction and safe passage without conscripting seasonal carriers or ignoring mine casualties. Cold-Iron damage and Folk relations determine the route.

### Fenn and Last Hearth Road

Travel along the recovering southern line toward Last Hearth. The core problem is restoring refuge and clean passage through contaminated ground while accounting for Grobi dependents, splinters, and the Deep Muster's closure state. This is the hardest corridor and may prioritize safety over resettlement.

Each corridor includes one changed settlement, one persistent campaign ruin, one human dispute, one gameplay-forward repair or defense objective, and one scene showing an earlier companion or faction consequence.

## End: The First Commitment

At the corridor's terminal hub, the player chooses the first funded commitment:

- homes and civilian return;
- roads, bridges, ferries, and public travel;
- food, fuel, mines, and productive work;
- forts, refuges, and defensive readiness;
- graves, contamination, and long-term closure.

The chosen corridor receives immediate crews, restored service, visual construction, prices, and follow-up jobs. Unchosen needs remain present and can be addressed through later open-world content.

## Encounters

The route uses ordinary summer threats, unresolved human violence, surviving Grobi actors, changed wildlife, residue cleanup, or damaged infrastructure according to state. Local testimony, visible damage, prior records, and companions provide redundant understanding. No corridor introduces a new universal villain.

## Information Paths

Local testimony, visible damage, campaign records, route services, and companion knowledge provide redundant understanding of each reconstruction choice. Missing one witness or record changes confidence and available compromise, not access to a corridor or commitment.

## Choices and State Changes

- `reconstruction_priority` records both corridor and first funded commitment.
- `summer_regional_access` records transport, waystone, service, and danger states across all seven regions.
- `summer_postgame_open` becomes true.

The choice changes first access and visible investment, not the future-setting canon. It never reactivates the General Below, respawns named dungeons, or assumes an outcome for independent adventures.

## Fail-Forward Results

- Lost convoy material reduces the first visible construction stage but does not block the decision.
- A failed negotiation creates tolls, delay, or a follow-up dispute rather than closing the region.
- A damaged transport route forces a local detour and unlocks its repair job.
- If the terminal hub was devastated, a survivor camp or roadhead receives the commitment instead.
- A companion or faction absence changes who witnesses the choice, not whether the road can be opened.

## Companion Intersections

Available companions may travel, visit their destinations, or meet the convoy at a relevant stop. The protagonist remains the field specialist making a consequential recommendation, not the unquestioned ruler of reconstruction.

## Faction Intersections

Faction settlement terms alter labor, authority, ceremony, and who pays for the first commitment. No faction can make an unsafe route safe merely by winning its line, and no reconstruction choice becomes automatic allegiance.

## Completion and Persistent Summer

The final scene returns control at the rebuilt or provisional hub. There is no formal credits point. Surviving quests, authored summer transformations, recurring jobs, relationships, exploration, and unresolved regional dangers remain playable under the established postgame rules.

## Navigation

- [[Accounts of the Living]]
- [[SUMMER AFTERMATH]]
- [[Grenzburg Seasonal Worldspace Matrix]]
- [[Season and World-State Constitution]]
- [[Main Campaign MOC]]
