---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Upper Grenz"]
culture: ["Eclessian", "Grobi"]
related_factions: ["Duchy of Grenzburg", "Marcher Vanguard", "Blackjack Corps", "Bloody-Sun Host"]
appears_in: ["Grenzburg"]
needs: []
aliases: ["Fort Tannbruck Quest"]
tags: [game-ready]
quest_class: main
act: act-1
availability_window: ["Early Autumn", "Open Autumn"]
repeatability: one-shot
cutoff_result: persists
world_state_outputs: ["watch_hill_signals", "tann_bridge_winch", "smuggler_route_state", "ghor_route_intelligence"]
required_locations: ["Fort Tannbruck", "Watch Hill", "Old Route Gallery"]
blocking_status: blocked
quest_owner: "Grenzburg Main Campaign"
quest_sequence: 0
companion_id: ""
faction_line: ""
faction_branch: ""
chapter_id: "MQ-05"
main_sequence: 5
story_gate: operation
estimated_hours: 1.25
gameplay_pillars: [investigation, dungeon, combat, defense]
required_states: ["tannbruck_access"]
optional_state_inputs: ["southbound_convoy", "grobi_scout_warning", "folk_road_claim", "svala_recruited"]
---
# Fort Tannbruck

## Chapter Function

This chapter teaches the fort as a persistent, revisitable space before its loss. It establishes its local ensemble, repairs two systems later used during the withdrawal, and exposes a human smuggling route that Ghor has begun exploiting for military intelligence.

## Trigger and Commitment

Captain Hedda Rann briefs the player after the Southbound convoy settles. Watch Hill's shutter signal no longer reaches the fort, and the Tann Bridge's removable-span winch jams under load. The player may explore Tannbruck and Upper Grenz before beginning. Entering the Old Route Gallery becomes a closed operation.

## Hook and Immediate Stake

Without Watch Hill, southern patrols cannot warn the fort. Without the winch, the bridge cannot be withdrawn during an attack. The repair crew sent to the hill has disappeared, and someone used the bridge mechanism after curfew.

## Beginning: A Fort That Must Work

The player inspects both failures:

- the bridge winch contains fresh grit, a cut retaining pin, and lamp grease used by Service Row workers;
- Watch Hill's signal shutters have been removed intact rather than broken;
- ration tallies show six soldiers listed on patrol after they deserted.

Hedda wants the systems restored before arrests begin. Gerhold, visiting the fort, argues for sealing Service Row and questioning everyone. Liese supports a targeted search. The player decides the immediate method, affecting trust but not the evidence's existence.

## Middle: Old Route Gallery

The missing shutters were carried into an Atherian road gallery beneath Watch Hill. The gallery is ordinary imperial infrastructure, unrelated to the Qianglong Muster. It contains drainage rooms, a collapsed courier passage, and an old road counter that still responds mechanically to weighted plates.

Corporal Merten Bale and five deserters use the gallery to trade lamp oil, nails, and route sketches for food and safe guidance. Their contacts began as independent Grobi traders. Ghor's scouts recently coerced the exchange and demanded bridge measurements.

The player can enter through Watch Hill, a drainage outlet, or the Service Row store. Inside, the party rescues two bound repair workers, navigates the counter mechanism, and discovers the next exchange time.

## End: The Measured Bridge

At the gallery's southern mouth, Bale meets a mixed Grobi party carrying food and a Bloody-Sun horn-token. The traders attempt to flee when Ghor's armed observer orders the route sketches seized.

The player may ambush the meeting, separate Bale from the observer, or follow the scouts to their viewing position. Bale can surrender after the repair workers and measurements are secured. He knowingly sold military material, but evidence shows the first trades were for food rather than allegiance.

Returning the shutters restores Watch Hill. Repairing the winch requires choosing which scarce convoy load is used: bridge timber creates a durable repair, fuel and forge work create a faster metal repair, and insufficient supplies create a manual emergency release that needs more defenders during MQ-08.

## Encounters and Opposition

- fort inspection and targeted search;
- three-route entry into the Old Route Gallery;
- Atherian weight-counter traversal hazard;
- deserter confrontation and prisoner rescue;
- Grobi observer fight and pursuit to the southern overlook.

## Information Paths

Grease, duty rolls, and Service Row witnesses point to Bale. Trade scratches, discarded food wrappings, and the horn-token distinguish early barter from Ghor's later coercion. Bridge measurements, a scout sketch, and the overlook prove military reconnaissance.

## Choices and State Changes

- `watch_hill_signals` becomes restored, improvised, or delayed.
- `tann_bridge_winch` becomes durable, rapid-metal, or manual-release.
- `smuggler_route_state` becomes sealed, watched, or escaped-remnant.
- `ghor_route_intelligence` becomes full, partial, or absent depending on recovered sketches and observers.

## Fail-Forward Results

- If the repair workers die during an exposed assault, Hedda supplies less experienced replacements and repairs take longer.
- If Bale escapes, his cached measurements are still recovered; he later guides a Grobi side force.
- If the observer escapes, Ghor receives the full bridge timings and MQ-08 gains an extra pressure phase.
- Failure to restore Watch Hill immediately leads to a patrol casualty, after which soldiers finish an improvised signal.

## Companion Intersections

- Ilyana challenges Gerhold's willingness to seal a civilian quarter for speed.
- Dismas understands Bale's desertion without excusing sale of the bridge.
- Svala can force a yielded deserter scene that tests whether she follows her recall discipline.
- Tavio can diagnose the winch without making his presence mandatory.

## Faction Advantages

Ducal service grants a patrol for the overlook. Blackjack equipment state provides replacement pins. Folk route knowledge reveals the drainage outlet. Church work provides witnessed prisoner handling. Underworld access identifies the food intermediary. The baseline gallery route always exists.

## Cutoff and Unlocks

Completion opens **Open Autumn**, [[Roads Worth Saving]], full public access to Longlake and Highlake, and optional negotiated entry toward Wolfsmere and Southwood. The quest displays which fort systems were restored and how they will function if Tannbruck is attacked.

## Navigation

- [[Fort Tannbruck]]
- [[ACT I THE CLOSING ROADS]]
- [[Roads Worth Saving]]
- [[Main Campaign MOC]]
- [[Main Campaign State Matrix]]
