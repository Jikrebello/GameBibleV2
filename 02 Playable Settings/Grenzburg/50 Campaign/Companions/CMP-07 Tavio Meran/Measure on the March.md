---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Upper Grenz", "Tannbruck", "Hammer Ward"]
culture: ["Vortharan", "Sestaran", "Eclessian"]
related_factions: ["Blackjack Corps", "Ducal Marcher Service", "Great Forge", "Warlock Hall"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-3
availability_window: ["Open Thaw", "Spring Reclamation"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["tavio_field_inspection_ledger", "march_equipment_state", "old_river_arsenal_safety", "named_worker_stop_state", "tavio_direction"]
reward_unlocks: ["Road Proof", "Field Yield"]
required_locations: ["Great Forge", "Fort Tannbruck", "Old River Arsenal", "Upper Grenz"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-operation
companion_campaign_stage: act-3
quest_owner: "Tavio Meran"
quest_sequence: 8
companion_id: "CMP-07"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: preparation
estimated_hours: 0.75
gameplay_pillars: [inspection, travel, defence, logistics, moral-pressure]
required_states: ["tavio_act2_chapter_resolved", "open_thaw_active"]
optional_state_inputs: ["tannbruck_state", "old_river_arsenal_state", "red_brass_exposure", "ducal_charter_state", "blackjack_reform_state"]
field_experience_gate: []
companion_required: "Tavio Meran"
duo_quest: false
pause_points: ["Tannbruck Inspection Filed"]
relationship_gate: ""
relationship_variant: ""
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "The Deep Muster"
autonomous_resolution: "Tavio files most unsafe equipment but allows one emergency batch to continue under external supervision"
changed_reentry: ""
ensemble_inputs: ["Ilyana Veshkar", "Bernard Valeon", "Ylva Winter-Track"]
identity_hooks: ["Military", "Merchant/Craft", "Peasant/Labour", "Warlock", "Lancewright"]
encounter_deck: []
persistence_scope: regional-milestone
postgame_season: ""
---
# Measure on the March

## Quest Function

This Act III operation inspects unstable military and reconstruction equipment moving from Grenzburg through Tannbruck to the Old River Arsenal.

The pressure is not a hidden plot. The equipment is urgently needed, some failures are ordinary wartime damage, and several officers sincerely believe stopping the column will cost lives elsewhere.

## Hook

Three field failures arrive in one morning:

- a bridge Brace cracks under a refugee cart;
- a replacement-forge collar vents blackened heat;
- a Tannbruck lifting spear throws its operator.

Hella asks Tavio to travel with the convoy and file an actual inspection ledger. Pierre's officers grant authority to stop individual devices, but not the whole reclamation column without evidence.

## Beginning: Write Before Moving

At the Great Forge, the party identifies:

- known Red Brass fittings;
- emergency local repairs;
- Muster-contaminated components;
- safe but ugly field substitutions;
- devices whose paperwork is missing but whose proof is sound.

Tavio must distinguish missing documentation from actual danger. Treating every irregularity as corruption would be as irresponsible as ignoring them all.

## Middle: Three Inspection Stops

### Upper Grenz Bridge Train

A support frame can move carts safely at lower capacity. The player may enforce a queue, reinforce it, reroute the heaviest load, or let officers overfill it.

### Tannbruck Workshops

Workers want a named stop authority before restarting captured machinery. An officer wants Tavio to sign for the whole batch. He can inspect honestly, sign blank again, or delay only the unsafe units.

### Old River Arsenal

Muster cadence contaminates one replacement forge. It is a non-conscious repeated command carried by physical script plates. The party can isolate, detune, destroy, or mark it for the later anchor operation.

## Pressure Encounter

Residue attacks while the inspection column is divided. The player must protect workers and equipment without treating continued production as the only objective.

Companions provide different advantages:

- Ilyana organizes warning and withdrawal;
- Bernard protects carers and exhausted workers;
- Ylva establishes a marked extraction line and relief change;
- every starting vocation has a route through ordinary combat and shared traversal.

## Decision

One unstable military frame could materially help the next reclamation battle. Its risk is bounded but real.

The player and Tavio may:

- stop it;
- deploy it only with informed volunteers and a named halt;
- replace it at strategic cost;
- conceal the risk;
- order debtors to carry it.

The decision affects material readiness and `tavio_direction`, but no path automatically loses the main campaign.

## Fail-Forward

- Convoy delayed: a later front receives fewer supplies.
- Bridge frame fails: the route closes and ferries replace it.
- Ledger lost: named inspection marks on equipment preserve partial state.
- Arsenal contamination spreads: [[Horn for Leak-Day]] begins with higher pressure.
- Tavio signs too broadly: Hella restricts his authority and workers distrust him.

## Outputs and Rewards

- `tavio_field_inspection_ledger`;
- state of military and reconstruction equipment;
- **Road Proof**, improving inspection dialogue and route mechanisms;
- **Field Yield**, shortening safe vent time;
- Act III finale preparation.

## Navigation

- [[Tavio Companion Campaign]]
- [[Horn for Leak-Day]]
- [[Old River Arsenal]]
- [[Fort Tannbruck]]
- [[Proof-Mistress Hella Dorn]]
- [[Lancewright]]
