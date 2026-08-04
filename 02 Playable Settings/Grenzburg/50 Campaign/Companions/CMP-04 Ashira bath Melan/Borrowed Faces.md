---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Upper Grenz"]
culture: ["Jirahar", "Eclessian"]
related_factions: ["Blackjack Corps"]
appears_in: ["Grenzburg"]
needs: []
tags: [companion-campaign]
quest_class: companion
act: act-3
availability_window: ["Spring Reclamation"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["ashira_borrowed_face_caches", "blackjack_likeness_policy", "field_copy_state", "tannbruck_relief_convoy_state", "ashira_direction"]
reward_unlocks: ["No Human Shadow preparation"]
required_locations: ["Blackjack Yard", "Upper Grenz", "Tannbruck Road"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-operation
companion_campaign_stage: act-3
quest_owner: "Ashira bath Melan"
quest_sequence: 8
companion_id: "CMP-04"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: preparation
relationship_variant: ""
preparation_inputs: []
preparation_threshold: ""
grounded_rewrite_status: approved
external_stakes: ["a Tannbruck relief convoy", "three missing route runners", "field identification during the dead march", "dangerous copied likeness plates"]
banter_priority: contextual
player_interest_gate: none
missed_arc_treatment: changed-reentry
encounter_deck: []
postgame_season: ""
estimated_hours: 1
gameplay_pillars: [investigation, escort, defence, pursuit, field-identification]
required_states: ["ashira_act2_resolution"]
optional_state_inputs: ["copied_imprint_method_state", "blackjack_internal_alignment", "neda_available", "tannbruck_reclaimed"]
companion_required: "Ashira bath Melan"
duo_quest: false
pause_points: ["First Runner Verified", "Convoy Reached"]
autonomous_deadline: "The Deep Muster Main Quest"
autonomous_resolution: "See Companion Autonomy and Act Convergence; untracked content uses stable-colleague treatment."
changed_reentry: "No Human Shadow gains one additional field-copy phase; untracked Ashira remains a stable colleague."
ensemble_inputs: ["Elara Velescar", "Bernard Valeon", "Dismas Raben", "Ilyana Veshkar", "Tavio Meran", "Zafir ibn Samad", "Ylva Winter-Track"]
identity_hooks: ["Military", "Scholarly", "Underworld", "Peasant/Labour"]
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
archetype_pressure: "Ashira's expertise is indispensable but insufficient: living colleagues must control their likeness and field teams must verify people by more than appearance."
emotional_function: "Turn the human-likeness issue into a tense convoy and identification job with named current colleagues, not a policy seminar."
pleasure_beat: "The party learns to defeat false formations through passwords, boot marks, bad jokes, and ordinary habits no plate copied."
care_beat: "Ashira destroys a tactically useful likeness immediately when its living subject revokes permission."
player_archetype_hooks: []
persistence_scope: regional-persistent
---
# Borrowed Faces

## Quest Function

A relief convoy from reclaimed Tannbruck is overdue. Three Blackjack route runners have been seen on the same road at impossible intervals. Some sightings are living people, some are copied field likenesses, and some are non-conscious Muster repetitions wearing recent shapes.

The normal party must find the real runners, keep the convoy moving, and recover copied plates before friendly teams begin shooting one another.

## Current Cast

- **Mara Venn:** a living Blackjack scout who consented to one winter decoy and now wants every copy destroyed.
- **Jannik Holt:** convoy quartermaster, suspicious of Medium practice and more concerned with flour than theory.
- **Sef Tallow:** a route runner copied by his squad lead without being asked.
- **Neda Volk:** optional recovery hand who knows the runners' ordinary habits.

## Hook

The first false Mara reaches the Yard with a correct uniform, blood on the right sleeve, and a plausible warning that the convoy turned east. It cannot answer which boot Mara repaired with red thread.

Ashira identifies the figure as a shallow field copy. She also recognizes the crude plate work as an adaptation of a winter method used around the Quarry Galleries. Her first reaction is anger at the incompetent technique. Brina points out that the convoy is still missing.

## Road Verification

The party follows three sightings along the Tannbruck road. Each can be tested through at least two current facts:

- route passwords and countersigns;
- fresh weight, breath, and ground disturbance;
- personal habits known through company work;
- the fixed cadence and limited responses of a copy;
- whether the figure can revise a plan after new information.

No single failed check causes the party to kill a living runner. Uncertainty changes approach distance, surprise, and who gets away.

### First Runner

Mara is alive and pinned in a drainage cut while her likeness draws residue toward the road. She revokes permission for every plate carrying her face, including one the party could use to clear the next rise.

Destroying it forces a harder route. Keeping it after her refusal is a major Ashira conflict and changes Mara's future company service.

### Second Runner

Sef has followed his own likeness, believing it will lead him to the squad lead who copied him. Ashira initially treats the repeated figure as the trail and misses Sef's deliberately reversed boot marks. Neda or an attentive player catches the mistake.

Sef wants the plate as proof. He does not want it used, displayed, or stored in Ashira's private collection.

### Pause Point: First Runner Verified

The quest may pause after one living runner is safe and the convoy route is identified.

## Convoy Set Piece

The convoy is trapped between a washed cart cut and residue formations attacking projected doubles. Jannik Holt has begun using flour thrown across faces and boots as a crude verification method. It works, wastes food, and infuriates Ashira because it is inelegant.

The party can:

- destroy the plate network and fight the full residue formation;
- invert one nonhuman decoy to draw the dead off the road;
- establish a password and touch-verification line;
- move the convoy through the drainage cut;
- pursue the human squad lead who retained the plates.

Ashira's technical reading opens routes, but Jannik controls when the convoy moves. Mara and Sef control their own likenesses.

### Pause Point: Convoy Reached

The quest may pause after the living convoy is secured and before the plate pursuit.

## End: Burn Pit or Evidence Locker

At the Yard, Brina needs an immediate field rule, not a philosophical settlement. The operational choices are:

- destroy all human plates after recording their provenance;
- hold coerced plates as sealed evidence with destruction dates;
- return a plate only if its subject requests custody;
- retain useful likenesses under expert or command discretion;
- replace the network with nonhuman movement patterns and ordinary verification.

Ashira may support the rule, comply while objecting, or hide one high-quality plate. The meeting lasts minutes because the next convoy is already leaving.

## Fail-Forward

- An escaped plate reinforces one phase of [[No Human Shadow]].
- Destroyed proof weakens action against the responsible squad lead but stops tactical spread.
- A misidentified living runner is wounded and rescued rather than killed through one check.
- Convoy loss reduces Act III food and medicine without blocking the campaign.
- If the human copier escapes, the later finale gains an active field-copy cache rather than a recurring mastermind.

## Outputs

Set `ashira_borrowed_face_caches`, `blackjack_likeness_policy`, `field_copy_state`, `tannbruck_relief_convoy_state`, and possible `ashira_direction` movement.

## Navigation

- [[Ashira Companion Campaign]]
- [[No Human Shadow]]
- [[Blackjack Corps]]
- [[Fort Tannbruck|Tannbruck]]
