---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Ledger Quays", "Underways"]
culture: ["Jirahar", "Qesheth"]
related_factions: ["Blackjack Corps", "Grenzburg Customs"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-1
availability_window: ["Early Autumn", "Open Autumn"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["ashira_introduction_complete", "ashira_spindle_recovered", "human_roster_disclosed", "customs_runner_state", "ashira_direction"]
reward_unlocks: ["Pattern Known"]
required_locations: ["Customs Hall", "Ledger Quays", "Grenzburg Underways", "Blackjack Yard"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: introduction
companion_campaign_stage: introduction
quest_owner: "Ashira bath Melan"
quest_sequence: 1
companion_id: "CMP-04"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: open-world-window
relationship_variant: ""
preparation_inputs: []
preparation_threshold: ""
grounded_rewrite_status: approved
external_stakes: ["witness safety", "captive rescue", "casualty identification", "field-method control"]
banter_priority: contextual
player_interest_gate: none
missed_arc_treatment: changed-reentry
encounter_deck: []
postgame_season: ""
estimated_hours: 1
gameplay_pillars: [investigation, pursuit, combat, protection]
required_states: ["ashira_recruited"]
optional_state_inputs: ["city_access", "underways_route_access"]
field_experience_gate: ["ashira_first_outing_complete"]
companion_required: "Ashira bath Melan"
duo_quest: false
pause_points: ["Customs Examination Complete", "Underway Route Found"]
autonomous_deadline: "The Last Convoy"
autonomous_resolution: "See Companion Autonomy and Act Convergence; untracked content uses stable-colleague treatment."
changed_reentry: "The Drowned Answer reveals the withheld roster after the Act I result."
ensemble_inputs: ["Elara Velescar", "Bernard Valeon", "Dismas Raben", "Ilyana Veshkar", "Tavio Meran", "Zafir ibn Samad", "Ylva Winter-Track"]
identity_hooks: ["Scholarly", "Underworld", "Mystic/Religious", "Peasant/Labour"]
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
archetype_pressure: "Ashira's accurate recognition is useful; the test is whether she treats the frightened owner of a likeness as intellectually inferior."
emotional_function: "Lead with unnerving competence and company care before exposing the prohibited roster."
pleasure_beat: "A strange Customs mystery, shadow pursuit, and the satisfaction of correctly classifying the impossible-looking."
care_beat: "Ashira believes a frightened runner without publishing what he saw."
player_archetype_hooks: []
persistence_scope: local-persistent
---
# The Faces She Kept

## Premise

A Customs runner named **Pavel Orr** reports that his own shadow stepped away from him, copied a dead raider's face, and stole a sealed spindle from impound. His supervisors call it panic and suspend him.

Ashira believes the event but not Pavel's explanation. The thief used a crude projector copied from one branch of her prohibited human roster. The theft leads through Ledger Quays into the underways.

## Beginning

The normal party examines:

- Pavel's living shadow, which behaves normally;
- repeated boot pressure with no matching person;
- a shutter scorched by a bounded shadow field;
- an impound list identifying the spindle as Ashira's surrendered property.

Ashira is calm with Pavel:

> “I believe what you saw.”
>
> “Then say it was a ghost.”
>
> “No. Belief is not obedience.”

The player may protect his privacy, demand a public demonstration, or let Ashira turn him into a case study. These alter trust and later testimony.

## Middle

The thief leaves three routes:

- public quay pursuit through reflected light;
- customs tunnels with locked evidence gates;
- underways path identified through displaced soot.

Human receivers hired the thief to sell a frightening security tool. Their projector repeats one recognizable approach pattern but contains no consciousness.

Encounters combine:

- ordinary hired blades;
- projector-created feints;
- dark water and moving shutters;
- a living runner used as bait.

All vocations can reveal the false figures through light, dust, water, timing, impact, or observation. Ashira is faster, not mandatory.

## End

The receiver attempts to broadcast the face across a crowded quay while escaping. The party must disable shutters, protect civilians, and recover the spindle.

Afterward, Ashira admits the copied branch came from a larger roster she retained after judgement. She can:

- disclose its existence to Brina under restricted custody;
- disclose only to the player;
- describe it as harmless technical material;
- deny the connection despite the evidence.

Pavel decides separately whether his name enters the report.

## Failure

- If the receiver escapes, the spindle remains traceable at Sunken Causeway.
- If the projector fires, public Medium fear rises and Pavel's account becomes public.
- If the spindle breaks, its unique cadence survives in the scorch pattern.
- Defeat leads to Neda recovering the party; one face circulates in criminal hands.

## Outputs and Reward

- `ashira_spindle_recovered`: intact, damaged, circulated, or lost;
- `human_roster_disclosed`: Brina, player-only, minimized, or concealed;
- `customs_runner_state`: protected, public, discredited, injured, or dead;
- `ashira_direction`;
- `ashira_introduction_complete`;
- unlock **Pattern Known**.

## Navigation

- [[Ashira Companion Campaign]]
- [[The Room That Answered]]
- [[Ashira Shadow Roster Package]]
- [[Neda Volk]]
