---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Upper Grenz", "Longlake Country"]
culture: ["Ättar", "Grey-Wolf", "Eclessian", "Folk"]
related_factions: ["Blackjack Corps", "Duchy of Grenzburg"]
appears_in: ["Grenzburg"]
needs: []
tags: [narrative-rewrite]
quest_class: companion
act: summer
availability_window: ["Playable Summer", "Postwar Cycle"]
repeatability: one-shot
cutoff_result: remains-available
world_state_outputs: ["ylva_summer_coda", "ylva_destination", "ylva_postwar_route_state", "ylva_memorial_state"]
reward_unlocks: ["Ylva Summer Routine", "Postwar Route Jobs"]
required_locations: ["Blackjack Yard", "Tannbruck Scout Post", "Longlake Road"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: summer
companion_campaign_stage: summer
quest_owner: "Ylva Winter-Track"
quest_sequence: 10
companion_id: "CMP-03"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: "The First Summer Road"
estimated_hours: 0.5
gameplay_pillars: [aftermath, route-walk, companion-resolution, world-state]
required_states: ["summer_aftermath_active"]
optional_state_inputs: ["ylva_final_outcome", "ylva_fate", "ylva_relationship_commitment", "ylva_living_route_atlas", "blackjack_resolution", "ducal_resolution"]
field_experience_gate: []
companion_required: ""
duo_quest: false
pause_points: []
relationship_gate: ""
relationship_variant: ""
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: ""
autonomous_resolution: "The coda displays Ylva's fixed autonomous settlement"
changed_reentry: ""
ensemble_inputs: ["Quartermaster Brina Kest", "Tavio Meran", "Dismas Raben"]
identity_hooks: ["Ättar", "Folk", "Military", "Wilderness", "Peasant/Labour", "Hunter"]
encounter_deck: []
persistence_scope: postgame-permanent
postgame_season: summer
emotional_rewrite_status: preserve
dialogue_status: pending-rewrite
archetype_pressure: "Competence becomes self-erasure: test whether Ylva accepts shared agency without reading care as confinement."
emotional_function: "Keep the settled pathfinder outcomes and visible consequence of accepting or rejecting relief"
pleasure_beat: "Field competence, open weather, friendly contest, practical food, and quiet work done well."
care_beat: "Ylva notices strain and shares practical work while leaving the other person real authority over risk."
player_archetype_hooks: []
---
# The Road She Chooses

## Quest Function

This summer coda demonstrates Ylva's settled conduct and destination. It does not reopen [[The Last Marker]], upgrade a missed moral result, or introduce a new crisis.

The form changes according to Ylva's fate.

## Living Coda

If Ylva lives, a route notice asks the player to meet her at one of four destinations.

### Independent Pathfinder

Resolved Ylva works from a public route table shared among settlements, carriers, hunters, and relief crews. Her contracts name:

- who holds each watch;
- who may call relief;
- how liability is divided;
- what information remains local;
- and when a route closes.

She asks the player to walk one newly reopened segment. Midway, another pathfinder corrects her mark. Ylva checks it, agrees, and thanks them without taking over the route.

### Ducal Route Scout

Ylva maintains military and civilian corridors under a bounded marcher charter. In a resolved version she insists that village crews hold stop authority. In a compromised version an officer still enforces her shift limits.

### Blackjack Pathfinder

Ylva trains debtors at the Yard. A resolved version uses transparent rotations and collective loss filings. A compromised version works under Brina's direct inventory and rest authority because she has not internalized those limits.

### Solitary Departure

Broken Ylva leaves a short note and one accurate map. The player may find her at the edge of the region before she departs.

The conversation can acknowledge care, anger, friendship, romance, or bond, but it does not reverse her choice. She refuses a shared route and takes work farther south or west.

## Memorial Coda

If the player explicitly accepted Ylva's sacrifice, the coda begins at the last route board rather than with Ylva.

Her name appears among every person who held the relay, not above them. The player may:

- preserve the equal record;
- elevate her as a solitary hero;
- emphasize the lives saved and the unresolved belief that killed her;
- place her bow at the memorial;
- keep the bow in active service through the Hunter lodge.

Tavio, Dismas, Brina, and route workers receive short state-dependent reactions. The game never labels the sacrifice as Ylva's resolved ending.

## Relationship Variants

### Romance

Resolved or compromised Ylva and a committed male player discuss where a shared hearth fits around independent work. The answer may be Grenzburg, the road, or a recurring return rather than permanent cohabitation.

If [[A Hearth Chosen]] was completed, she uses the chosen-hearth language and marks a homeward route. If it was missed, the relationship remains but lacks that shared ritual.

### Sworn Bond

Resolved or compromised Ylva and a committed female player exchange the Sister Watch signal before separating for their day's work.

If [[The Sister Watch]] was completed, another trained team answers the signal, showing that sisterhood widened rather than replaced the route network.

### Friendship

A friend receives the same moral resolution scene without romance or sworn-bond language. Ylva invites the player to mark one route jointly and gives equal credit.

## Postwar Function

The coda unlocks finite and repeatable route content according to world state:

- escort and weather jobs;
- signal maintenance;
- stranded traveler rescues;
- route surveys;
- seasonal shelter restocking.

Named route discoveries remain one-shot. Repeatable work uses credible changing weather, travelers, patrols, and hazards rather than resetting Ylva's story.

Ylva remains at her settled destination through sequential postwar seasons and gains ambient seasonal dialogue, not another personal arc.

## Rewards

- `ylva_summer_coda`
- settled destination and memorial states.
- Ylva's postwar routine, if alive and available.
- route jobs appropriate to surviving settlements and organizations.

No coda reward replaces a missed recipe, relationship episode, or Act III resolution.

## Navigation

- [[Ylva Companion Campaign]]
- [[Ylva Winter-Track]]
- [[The Last Marker]]
- [[The First Summer Road]]
- [[Blackjack Yard]]
- [[Hunter]]
