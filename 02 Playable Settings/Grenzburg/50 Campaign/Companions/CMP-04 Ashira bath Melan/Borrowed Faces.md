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
tags: [game-ready]
quest_class: companion
act: act-3
availability_window: ["Spring Reclamation"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["ashira_borrowed_face_caches", "blackjack_likeness_policy", "field_copy_state", "ashira_company_consent_drill"]
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
encounter_deck: []
postgame_season: ""
estimated_hours: 1
gameplay_pillars: [investigation, escort, defense, infiltration, choice]
required_states: ["ashira_act2_resolution"]
optional_state_inputs: ["copied_imprint_method_state", "blackjack_internal_alignment", "neda_available"]
companion_required: "Ashira bath Melan"
duo_quest: false
pause_points: ["First Cache Found", "Convoy Secured"]
autonomous_deadline: "The Deep Muster Main Quest"
autonomous_resolution: "Ashira contains the field copies but keeps exclusive authority over the original roster."
changed_reentry: "No Human Shadow gains one additional field-copy phase."
ensemble_inputs: ["Elara Velescar", "Bernard Valeon", "Dismas Raben", "Ilyana Veshkar", "Tavio Meran", "Zafir ibn Samad", "Ylva Winter-Track"]
identity_hooks: ["Military", "Scholarly", "Underworld", "Peasant/Labour"]
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
archetype_pressure: "Blackjacks voluntarily copied their own faces for tactical use; Ashira must accept that consent remains revocable and expertise remains shared."
emotional_function: "Move the likeness problem into present company relationships rather than distant victims."
pleasure_beat: "Counter-ambushes in which false formations can be read, inverted, and turned against the Muster."
care_beat: "Let living Blackjacks withdraw their faces even when the copy is useful."
player_archetype_hooks: ["Cheerleader", "Tomboy", "Goth", "Bohemian", "Jock", "Nerd", "Rebel", "Goofball", "Grey"]
persistence_scope: regional-persistent
---
# Borrowed Faces

## Premise

During early Muster operations, several Blackjacks copied Ashira's crude winter method. Some gave consent in an emergency. Others were copied by squad leaders. Field plates now make living soldiers appear in the wrong place, confusing both the dead and rescue teams.

The normal party follows three caches along the Tannbruck road.

## Play

Each cache presents a different problem:

- a willing scout now revokes consent after seeing her face continue without her;
- a dead Blackjack left no instruction, and his squad wants the decoy;
- a commander argues that company service already includes tactical likeness.

The player can destroy, seal, reassign, or temporarily use each copy. Ashira can classify contamination but does not own the decision.

The middle set piece defends a living convoy from residue attacking its projected doubles. Players may invert the plates, physically shield the convoy, draw residue into terrain, or destroy the entire network.

## Company Drill

Back at the Yard, Brina requires a field rule. The strongest policy establishes:

- specific, revocable consent;
- no human likeness as default equipment;
- named custody and destruction;
- a nonhuman substitute library;
- stop authority held by the copied person.

Ashira may support it, tolerate it, or argue for expert discretion.

## Failure

- Escaped plates reinforce the finale.
- Destroyed proof weakens legal action but stops tactical spread.
- A coerced copy creates a major conflict.
- Convoy losses alter Act III supplies without blocking progress.

## Outputs

Set `ashira_borrowed_face_caches`, `blackjack_likeness_policy`, `field_copy_state`, `ashira_company_consent_drill`, and possible `ashira_direction` movement.

## Navigation

- [[Ashira Companion Campaign]]
- [[No Human Shadow]]
- [[Blackjack Corps]]
