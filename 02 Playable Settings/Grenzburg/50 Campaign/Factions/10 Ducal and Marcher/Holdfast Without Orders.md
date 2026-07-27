---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg"]
culture: ["Eclessian"]
related_factions: ["Duchy of Grenzburg", "Marcher Vanguard"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: faction
act: act-1
availability_window: ["Late Autumn"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["tann_holdfast_survivors", "seed_grain_state", "field_initiative_precedent", "tavio_workers_stop_authority", "zafir_worker_stop_authority"]
required_locations: ["Fort Tannbruck", "Tann Crossing Farms", "Upper Grenz Military Road"]
blocking_status: outlined
quest_owner: "Ducal and Marcher Service"
quest_sequence: 5
companion_id: ""
faction_line: "ducal-marcher"
faction_branch: ""
---
# Holdfast Without Orders

## Line Position

This is Ducal and Marcher Service quest 5. It belongs to the Service movement and is available during Late Autumn.

## Hook and Immediate Stake

During Tannbruck's withdrawal, a village holdfast has no valid order because its courier died. Waiting means capture; acting means exceeding the warrant.

Save civilians and soldiers while showing what initiative under civil command actually requires.

## Player Actions

Reconstruct the lost order, organize a local defense, choose which stores to deny, and escort survivors to the withdrawal road.

## Opposition and Institutional Pressure

Grobi outriders press the holdfast; an officer refuses to move without a seal; villagers will not abandon seed grain without compensation.

## Information Paths

The courier tube, signal flags, and Liese's route map establish the intended withdrawal.

At least two routes establish every required fact. Social skill, cultural familiarity, background knowledge, and prior faction work change cost or interpretation rather than deciding whether the story continues.

## Choice or Mastery Point

Issue a recorded field order, persuade local speakers to authorize movement, or hold until formal relief.

## Tavio Embedded Opportunity

With [[Tavio Meran]] present, the holdfast's lifting brace begins carrying more weight than its filed repair. The officer wants it kept moving until the last military cart crosses; workers want authority to stop it before collapse.

Tavio can identify the real threshold, but the player must decide who may call the halt. Recording local stop authority supplies `tavio_workers_stop_authority` for [[Proof Under Load]]. Every vocation retains an ordinary route through unloading, shoring, rerouting, or abandoning the frame.

## Zafir Embedded Opportunity

With [[Zafir ibn Samad]] present, the same withdrawal plan can use prepared release rings to move the village's carts through the failing gate. The officer asks Zafir for one master release. The carters instead propose a ring on every team and the right to alter the sequence as loads change.

Giving the users their own halt and release authority supplies `zafir_worker_stop_authority` for [[The Ninth Lever]]. A central master key may still save the immediate convoy, but it pressures Zafir toward procedural or mastering conduct. Ordinary signals, wedges, and manual releases keep the quest viable without him.

## Fail-Forward Results

If the holdfast falls, survivors break out through farm drains. Lost stores strengthen one winter siege position but do not fail the line.

Failure changes casualties, evidence, access, services, institutional stance, or the next mission. It never deletes the faction line without an authored result.

## Lock-In Consequences

No exclusive commitment.

The warning screen names affected quests, leaders, services, and political-settlement terms before any exclusive commitment.

## World-State Outputs

- `tann_holdfast_survivors`
- `seed_grain_state`
- `field_initiative_precedent`
- `tavio_workers_stop_authority` when local halt authority is recorded
- `zafir_worker_stop_authority` when the people operating a deployed relation retain their own halt and release

## Rewards and Return Value

Contributes survivors, supplies, and trust to Tannbruck's fixed fall.

Rewards include a faction rank or stance change, service access, equipment or training, and a visible world-state consequence. Exact numerical values remain provisional.

## Seasonal Cutoff

At the next season gate, unresolved work transforms into a named institutional response, casualty, closure, or harder route and remains legible in the journal.

## Navigation

- [[Ducal and Marcher Service]]
- [[Zafir Companion Campaign]]
- [[Faction Questlines MOC]]
- [[Factions Overview]]
- [[Narrative State Register]]
- [[Quest and Content Architecture]]
- [[Grenzburg MOC]]
