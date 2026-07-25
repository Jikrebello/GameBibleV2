---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Upper Grenz", "Fort Tannbruck"]
culture: ["Eclessian", "Grobi"]
related_factions: ["Duchy of Grenzburg", "Marcher Vanguard", "Blackjack Corps", "Bloody-Sun Host"]
appears_in: ["Grenzburg"]
needs: []
aliases: []
tags: [game-ready]
quest_class: main
act: act-1
availability_window: ["Late Autumn"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["tannbruck_survivors", "tannbruck_material", "tannbruck_denial", "tannbruck_fallen"]
required_locations: ["Fort Tannbruck", "Watch Hill", "Tann Bridge", "Withdrawal Road"]
blocking_status: blocked
quest_owner: "Grenzburg Main Campaign"
quest_sequence: 0
companion_id: ""
faction_line: ""
faction_branch: ""
chapter_id: "MQ-08"
main_sequence: 8
story_gate: operation
estimated_hours: 2.0
gameplay_pillars: [combat, defense, rescue, traversal]
required_states: ["last_convoy_people", "last_convoy_material"]
optional_state_inputs: ["watch_hill_signals", "tann_bridge_winch", "smuggler_route_state", "ghor_route_intelligence", "autumn_road_support", "all_companion_states", "all_faction_states"]
---
# Tannbruck Falls

## Chapter Function

This is Act I's fixed defeat and first major military set piece. The player cannot save an exposed fort from Ghor's full host, but can determine who escapes, what survives, what is denied to the enemy, and how much of the winter defense remains possible.

## Trigger and Commitment

Gerhold convenes a final defense briefing after the convoy arrives. Scouts confirm attacks on the Upper Grenz, Tuskway, and Fenn corridors. The fort will hold long enough to evacuate, not await relief that cannot arrive.

The start warning closes Late Autumn content, advances weather during the operation, and names every fort service or person that may transform. The player chooses three active companions and cannot change party until the withdrawal reaches Tann Field.

## Hook and Immediate Stake

Ghor attacks before dawn with several thousand fighters and separate goblin food-rushes. Watch Hill is the first target; the lower camp and bridge follow. Hedda commands the fort, Gerhold coordinates the wider withdrawal, and Liese gives the Blackjack unit successive objectives.

## Beginning: Watch Hill

The player reaches Watch Hill through the wall path or Old Route Gallery. The objective is to keep the signal alive long enough for southern patrols and the last farm holdfast to withdraw.

Restored signals provide clear friendly positions. Improvised signals require manual relays. A failed MQ-05 response means the hill begins partially occupied.

The player may rescue the signal crew, recover route rolls, and destroy the observation frame. Holding too long saves more patrols but allows Grobi to reach the Lower Bailey before the party returns.

## Middle: Lower Bailey and Bridge

Back at the fort, three crises become active:

- civilians and wounded cross from Autumn Camp;
- stores and military fittings must be loaded or destroyed;
- Horn-Captain Ruk's fighters reach the bridge machinery through the smuggler route or a direct wall breach.

The player moves between the lower gate, Service Row, and bridge winch. Strong convoy and fort states provide enough people to perform parallel tasks. Weak states force delegation or loss.

The bridge outcome depends on MQ-05:

- a durable repair permits controlled withdrawal and removal;
- the rapid metal repair works but overheats under sustained use;
- the manual release requires defenders to hold the mechanism while the final column crosses.

The player may withdraw the span, drop it under an enemy crossing, or leave it intact to save a late group. The choice defines `tannbruck_denial`, not whether the fort falls.

## End: The Withdrawal Road

Liese leads survivors through two delay positions:

1. **Tann Crossing Farms:** recover stranded convoy survivors or destroy remaining winter stores.
2. **Black Fir Bend:** hold a narrow road while engineers fell prepared trees and the column clears the river track.

Hedda's survival depends on whether she was relieved at the bridge. Gerhold remains with the formal rear guard and escapes by the military road; the player does not need to rescue him from a scripted mistake.

At Black Fir Bend, the party defeats Ruk or forces his withdrawal, then crosses the final prepared obstruction. Ghor appears only as the distant commander of an army, not an early boss who is inexplicably spared.

The survivors reach Tann Field during the first snow. Behind them, the fort burns, is occupied, or remains stripped according to denial choices. `tannbruck_fallen` becomes true in every result.

## Encounters and Opposition

- Watch Hill defense and evacuation;
- fighting return through the fort;
- Lower Bailey multi-objective battle;
- bridge mechanism defense and physical denial choice;
- two-stage moving rearguard;
- Horn-Captain Ruk confrontation.

## Information Paths

Signals, route intelligence, scout reports, and visible enemy movement make each pressure legible. The game never announces that the player can save the fort and then removes that possibility. The briefing states that the objective is evacuation and denial.

## Choices and State Changes

- `tannbruck_survivors` records patrols, civilians, wounded, engineers, Hedda, and named regional figures.
- `tannbruck_material` records food, medicine, fuel, artillery fittings, bridge gear, and route rolls.
- `tannbruck_denial` records bridge, signal frame, stores, gallery, and fort damage.
- `tannbruck_fallen` becomes true.

## Fail-Forward Results

- Losing Watch Hill accelerates the Lower Bailey breach but surviving scouts still reach a farm holdfast.
- A failed bridge defense moves the crossing to boats and the riverbank at higher casualty cost.
- If the player falls during a delay position, Liese orders a rescue and the column loses distance or material.
- Missed captives and holdfast survivors become winter rescue or prisoner states rather than unexplained deaths.
- Ruk may escape if the player prioritizes the final column; Ghor's siege gains a veteran captain.

## Companion Intersections

All recruited companions receive a fort-fall reaction whether active or not. Active companions offer field solutions suited to vocation and current arc state. No companion can negate the fall. Ilyana and Dismas receive their principal command-and-retreat reversal; Ylva must publish a distress call and accept a replacement on one rearguard route; Bernard organizes witnessed dead and wounded.

## Faction Advantages

Faction work supplies additional teams, routes, triage, local warnings, or covert movement. It converts apparent binary losses into simultaneous successes but never prevents the army-scale defeat.

## Cutoff and Unlocks

Completion advances the world to **Early Winter**, transforms Tannbruck and the southern roads into occupied or damaged states, moves refugees into Grenzburg, and starts [[Winter's Teeth]]. The player regains open-world control after winter intake.

## Navigation

- [[Fort Tannbruck]]
- [[The Last Convoy]]
- [[Winter's Teeth]]
- [[ACT I THE CLOSING ROADS]]
- [[Main Campaign MOC]]
- [[Main Campaign State Matrix]]
