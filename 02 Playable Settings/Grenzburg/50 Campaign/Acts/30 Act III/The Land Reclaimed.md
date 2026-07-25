---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Upper Grenz", "Highlake Uplands", "Frostfenn March"]
culture: ["Eclessian", "Folk", "Qianglong"]
related_factions: ["Duchy of Grenzburg", "Blackjack Corps", "Folk kindreds", "Church of the Redeemer"]
appears_in: ["Grenzburg"]
needs: []
aliases: []
tags: [game-ready]
quest_class: main
act: act-3
availability_window: ["Early Spring", "Open Spring"]
repeatability: one-shot
cutoff_result: persists
world_state_outputs: ["tannbruck_reclaimed", "muster_anchor_campaign_open", "spring_settlement_access", "elara_living_claims_indexed", "bernard_reclaimed_patient_routes", "ilyana_muster_cadence_sampled", "tavio_muster_cadence_reading"]
required_locations: ["Fort Tannbruck", "Upper Grenz", "Old River Arsenal", "Tuskway Redoubt", "White Mud Causeway"]
blocking_status: blocked
quest_owner: "Grenzburg Main Campaign"
quest_sequence: 0
companion_id: ""
faction_line: ""
faction_branch: ""
chapter_id: "MQ-17"
main_sequence: 17
story_gate: open-world-window
estimated_hours: 2.0
gameplay_pillars: [reclamation, exploration, rescue, combat, investigation]
required_states: ["muster_known", "cold_iron_anchor"]
optional_state_inputs: ["tannbruck_survivors", "tannbruck_material", "tannbruck_denial", "grobi_aftermath_state", "autumn_road_support"]
---
# The Land Reclaimed

## Chapter Function

This chapter turns spring reclamation into the map-wide anchor campaign. Reclaiming Tannbruck supplies a human and geographic center; the four remaining anchors then become player-paced subordinate operations. The chapter is not complete because the player paints flags on a map: it is complete when living settlement resumes and the routes to the recurrence network are understood.

## Trigger and Commitment

Cold-Iron records identify Watch Hill as the nearest connected relay. Pierre authorizes a return to Tannbruck while Liese assembles engineers, burial teams, and former residents. The player chooses when the reclaiming column leaves. No other spring quest is cut off.

## Beginning: Return to Tannbruck

The approach reflects Act I and II outcomes:

- saved civilians identify stores, passages, and homes;
- denied assets leave fewer Grobi fortifications and less usable salvage;
- surviving splinter bands may be absent, withdrawing, scavenging, or trapped;
- an intact bridge winch opens one direct route;
- lost records force the column to clear and verify every refuge.

The party clears living holdouts and ordinary hazards before meeting organized residue. Grobi remnants and the Muster are not allied: both may attack each other, flee, or create a three-sided rescue.

## Middle: The Watch-Hill Command Crypt

Recent dead from the fort have been enrolled beneath older unit names. The command crypt uses casualty tablets, drill space, and battlefield residue to print reinforcement files. The player must:

1. rescue or recover people sheltering in the Lower Bailey;
2. prevent the crypt from adding the reclaiming column to its roll;
3. identify the four routes encoded in its command table;
4. decide whether to destroy the Watch-Hill anchor immediately or leave it as an open subordinate operation.

The chapter can proceed once Tannbruck is secure even if this anchor remains active. Leaving it creates stronger local pressure and counts against the finale until destroyed.

## End: Four Roads Open

The surviving settlement gathers at Service Row. Tannbruck becomes a spring reclamation hub rather than an instantly rebuilt fort. The player opens four anchor operations in any order:

- **Watch-Hill Command Crypt** beneath Tannbruck;
- **River Arsenal Replacement Forge** in [[Old River Arsenal]];
- **Tuskway Banner Vault** beneath Tuskway Redoubt;
- **Fen Ossuary** beyond White Mud Causeway.

Each operation receives a map lead, a local problem, a destruction method, and a persistent regional result through [[Muster Anchor Matrix]]. These are subordinate main-path operations, not additional numbered chapters.

## Anchor Operation Standard

Every operation contains:

- an inhabited or socially consequential approach;
- two independent routes to identify the anchor function;
- one rescue, evacuation, or remains problem;
- at least two destruction approaches available to every party composition;
- a clear warning before irreversible destruction;
- a changed regional site after completion.

The player must destroy any two of the four to reach three total anchors and unlock MQ-18. Destroying all four produces the strongest final campaign state.

## Encounters and Opposition

- physically altered Tannbruck return;
- Grobi remnants, stranded civilians, and ordinary ruin danger;
- recent-dead formation around Watch Hill;
- command-crypt relay defense;
- settlement restart and map-board activation;
- optional first anchor operation during the same expedition.

## Information Paths

Cold-Iron plates identify relay names; Watch Hill provides route bearings; Tannbruck survivors identify physical access; ducal and Folk route knowledge locate modern approaches. Missing one source changes travel and danger, not access to the campaign.

## Choices and State Changes

- `tannbruck_reclaimed` becomes true.
- `muster_anchor_campaign_open` becomes true.
- `spring_settlement_access` records which roads, services, refugees, ferries, and local hubs return.

Each anchor updates `muster_anchor_count`, its region, its finale power, and its summer contamination independently.

## Fail-Forward Results

- A failed entry damages the reclaiming column and forces a different fort approach.
- Missed survivors appear as captives, residue casualties, or later recovery tasks according to prior evidence.
- If Watch Hill is not destroyed now, its recent-dead patrols begin on the Upper Grenz road.
- A damaged but not destroyed anchor reduces local pressure temporarily but does not count toward progression.
- Tannbruck can be reclaimed as a reduced camp even after severe casualties; services and support remain correspondingly poor.

## Companion Intersections

All companion histories can react to return, remains, and rebuilding. Ilyana and Dismas carry especially strong responsibility scenes around command and withdrawal; Svala and Bernard support the living settlement; Ashira clarifies recurrence; Tavio and Zafir open specialist routes. No companion is mandatory.

[[Elara Velescar]] can compare recovered stores, service rolls, makers' marks, and refugee testimony before salvage is redistributed. Giving copies to the living claimants rather than merely cataloguing valuable objects records `elara_living_claims_indexed`, one preparation asset for [[No Lady of Velescar]]. Ordinary clerks can complete the reclamation without her.

[[Bernard Valeon]] can mark casualty collection points, return corridors, and shelter handoffs while the reclaimed road is still being cleared. Completing the route with named carriers records `bernard_reclaimed_patient_routes` for [[The Open Hospice]]. Reclamation remains fully viable without him.

[[Ilyana Veshkar]] can record one Muster cadence at a disabled command point and distinguish its non-conscious repetition from any living person's assent. A clean sample records `ilyana_muster_cadence_sampled` for [[The Last Common Measure]]. Warlock counters and physical destruction remain available without her.

[[Tavio Meran]] can compare the same cadence against physical proof scars in the recovered lifting and forge equipment. Filing which carriers repeat, which can be Yielded, and which must be destroyed records `tavio_muster_cadence_reading` for [[Horn for Leak-Day]]. Warlock counter-scripts and ordinary mechanical isolation remain available without him.

## Faction Advantages

Faction progress determines who provides the reclamation column and what they try to claim afterward. The player remains able to refuse improper claims. No faction owns the anchor campaign or becomes required for destroying one.

## Cutoff and Unlocks

Reclaiming Tannbruck opens Open Spring side content. Destroying any three total anchors unlocks [[The Unending Muster Main Quest|The Unending Muster]]. Remaining anchors stay available until the player begins [[The Dead March]].

## Navigation

- [[Fort Tannbruck]]
- [[Muster Anchor Matrix]]
- [[The Unending Muster Main Quest|The Unending Muster]]
- [[Grenzburg Worldspace Location Register]]
- [[Main Campaign MOC]]
