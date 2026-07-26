---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Hammer Ward", "Old Market", "Highlake Uplands"]
culture: ["Vortharan", "Sestaran", "Eclessian"]
related_factions: ["Blackjack Corps", "Red Brass Bench", "Great Forge"]
appears_in: ["Grenzburg"]
needs: []
tags: [narrative-rewrite]
quest_class: companion
act: act-1
availability_window: ["Open Autumn"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["tavio_signed_batch_register", "unsafe_lancewright_fittings_state", "injured_apprentice_state", "seraf_pellan_state", "tavio_direction"]
reward_unlocks: ["Batch Recall", "Measured Marking"]
required_locations: ["Great Forge", "Hammer Ward", "Old Market", "Highlake Depot"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-operation
companion_campaign_stage: act-1
quest_owner: "Tavio Meran"
quest_sequence: 2
companion_id: "CMP-07"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: preparation
estimated_hours: 0.75
gameplay_pillars: [investigation, recall-operation, pursuit, worker-rescue]
required_states: ["tavio_campaign_tracked"]
optional_state_inputs: ["tavio_fifth_ring_evidence", "hella_dorn_trust", "low_lantern_access", "highlake_services"]
field_experience_gate: []
companion_required: "Tavio Meran"
duo_quest: false
pause_points: ["Batch Routes Identified"]
relationship_gate: ""
relationship_variant: ""
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "The Last Convoy"
autonomous_resolution: "Most fittings are recalled, but one apprentice is injured when Tavio accepts a hurried live test"
changed_reentry: "The Cracked Batch"
ensemble_inputs: ["Elara Velescar", "Ilyana Veshkar", "Bernard Valeon"]
identity_hooks: ["Sestaran", "Merchant/Craft", "Underworld", "Military", "Warlock"]
encounter_deck: []
persistence_scope: regional-milestone
postgame_season: ""
emotional_rewrite_status: reframe
dialogue_status: pending-rewrite
archetype_pressure: "Competition becomes worth: test whether Tavio can stop, lose, or need help without surrendering athletic joy."
emotional_function: "Keep dangerous endorsements; replace register-heavy play with teams using gear because Tavio's name made them trust it"
pleasure_beat: "Competition, crowds, food, physical effort, ridiculous prizes, and celebrating improvement."
care_beat: "Tavio trains beside people, celebrates their effort, and calls a halt before glory spends their bodies."
player_archetype_hooks: []
---
# The Signed Measure

## Quest Function

This Act I operation recalls unsafe Lancewright fittings sold under blank endorsements Tavio knowingly signed during his championship career.

It proves that accountability is not limited to the one ring he used.

## Hook

Hella finds Tavio's signature on a Grenzburg batch certificate dated after the championship. Tavio admits he signed stacks of blank endorsements for touring fees and sponsor convenience.

Three unsafe fittings are already in use:

- a quarry brace at the Highlake depot;
- a Hammer Ward testing collar;
- a private demonstration gauntlet being auctioned in Old Market.

The master batch register is moving with [[Seraf Pellan]].

## Beginning: Name the Recall

At the Great Forge, the player and Tavio choose how to announce the recall:

- public stop notice;
- quiet workshop collection;
- ducal equipment seizure;
- Low Lantern warning through workers;
- Red Brass voluntary notice.

A public notice protects users but alerts Seraf. A quiet route preserves surprise but leaves more people at risk. Preparation and companion methods can reduce the tradeoff.

## Middle: Three Fittings

The player may address the fittings in any order.

### Quarry Brace

Miners will stop if shown a credible control measure. Without it, the party must inspect the brace during a suspended load or evacuate the cut.

### Testing Collar

An apprentice is preparing a live proof. Tavio may invoke celebrity, admit the recall, or physically Yield the load. Concealment causes the avoidable injury used by his autonomous default.

### Auction Gauntlet

The item can be withdrawn lawfully, bought, stolen with Low Lantern help, or disabled during the demonstration. A buyer's guards resist only if the party attempts an unfiled seizure.

## Pursuit

Seraf leaves with the master register by a workshop cart disguised as salvage. The pursuit crosses Hammer Ward hoists, Old Market service lanes, and the Highlake freight ramp.

The party may:

- stop the cart;
- copy the register during a moving boarding;
- follow it to a Red Brass cache;
- save bystanders when a false fitting ruptures;
- let Seraf escape while securing the batch list.

Seraf's survival is never required later.

## Tavio's Test

At the final fitting, Tavio can save time by relying on his signature as authority. The safer route requires naming that his signature is unreliable and giving workers independent stop authority.

This choice moves `tavio_direction`.

## Fail-Forward

- Seraf escapes: the register or a partial copy remains.
- Register burns: batch stamps on recovered fittings reconstruct the routes.
- Apprentice injured: the injury persists and opens changed winter repair.
- Quarry closes: Highlake supply slows, but no story gate closes.
- Auction item leaves town: it returns through the field inspection chain in Act III.

## Outputs and Rewards

- `tavio_signed_batch_register`;
- state of three unsafe fittings;
- Seraf's live, arrested, dead, or escaped state;
- **Batch Recall**, improving unsafe-equipment detection;
- **Measured Marking**, reducing Tavio's wasted marks;
- Act I finale readiness.

## Navigation

- [[Tavio Companion Campaign]]
- [[The False Ring]]
- [[Proof Under Load]]
- [[Seraf Pellan]]
- [[Proof-Mistress Hella Dorn]]
- [[Red Brass Bench]]

