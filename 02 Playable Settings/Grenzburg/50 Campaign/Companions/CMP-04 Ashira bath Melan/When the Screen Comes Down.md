---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Lantern Ward", "Quarry Galleries"]
culture: ["Jirahar", "Eclessian"]
related_factions: ["Blackjack Corps"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-2
availability_window: ["Siege Winter"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["yard_screen_state", "copied_imprint_method_state", "ashira_act2_resolution", "ashira_direction", "yard_captive_roster"]
reward_unlocks: ["Witness Circle", "relationship commitment access"]
required_locations: ["Blackjack Yard", "Quarry Galleries", "Lantern Ward"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-finale
companion_campaign_stage: act-2
quest_owner: "Ashira bath Melan"
quest_sequence: 6
companion_id: "CMP-04"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: confrontation
relationship_variant: ""
encounter_deck: []
postgame_season: ""
estimated_hours: 1.5
gameplay_pillars: [siege, rescue, traversal, investigation, boss]
required_states: ["ashira_act1_resolution"]
optional_state_inputs: ["ashira_breach_casualty_map", "ashira_missing_blackjacks_identified", "ashira_brina_stop_authority", "ashira_private_identification_protocol", "ashira_quarry_shadow_route"]
companion_required: "Ashira bath Melan"
duo_quest: true
pause_points: ["Yard Evacuated", "Quarry Route Open"]
preparation_inputs: ["ashira_breach_casualty_map", "ashira_missing_blackjacks_identified", "ashira_brina_stop_authority", "ashira_private_identification_protocol", "ashira_quarry_shadow_route"]
preparation_threshold: "2 participate; 3 all material objectives; 4 one safeguard"
autonomous_deadline: "Ghor at the Gate"
autonomous_resolution: "Ashira saves the trapped debtors under Brina's imposed custody and accepts supervision without surrendering the roster."
changed_reentry: "After the Screen"
ensemble_inputs: ["Elara Velescar"]
identity_hooks: ["Underworld", "Military", "Scholarly", "Peasant/Labour"]
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
archetype_pressure: "Ashira must reveal enough of her method to seek help without turning the endangered company into research material."
emotional_function: "Make connection and bounded disclosure necessary to save the people who currently know her."
pleasure_beat: "Defending the Yard, navigating shadowed quarry machinery, and coordinating a precise two-person rescue."
care_beat: "Let debtors stop the use of their likeness and still receive rescue."
player_archetype_hooks: ["Cheerleader", "Tomboy", "Goth", "Bohemian", "Jock", "Nerd", "Rebel", "Goofball", "Grey"]
persistence_scope: district-persistent
---
# When the Screen Comes Down

## Premise

During a winter bombardment, copied notes from Ashira's screened practice are used to produce crude decoy Blackjacks. The decoys lead debtors into the Quarry Galleries, where a local opportunist intends to sell the method to Koss.

Ashira did not authorize the copies. She did, however, keep undocumented human media in the Yard and train behind a screen that prevented meaningful company oversight.

## Duo Structure

The player and Ashira remain the only full party members.

### Phase 1: The Yard

Defend the screened corner, identify real debtors among visual repetitions, and evacuate the wounded. Ashira can solve it quickly only by disclosing:

- what the human roster contains;
- how her labels work;
- which decoys are derived from living company members.

She may tell Brina, Neda, affected debtors, or only the player. Narrow disclosure can protect privacy if preparation exists; secrecy costs rescue time.

### Phase 2: Quarry Galleries

Approaches:

- casualty map route;
- shadow maintenance path;
- direct haulage stair.

Threats are human guards, collapsing industrial spaces, copied visual loops, and one genuine residue formation. Every vocation can distinguish real people through touch, timing, breath, snow, or agreed signals.

### Phase 3: The Screen Engine

The local copier, **Merrik Voss**, uses rotating lamps and stolen media to make captives appear in several passages at once. The duo must:

- break the projector without burning the captives;
- locate the original people;
- prevent method notes leaving;
- decide who holds Ashira's disclosed roster.

Merrik may be captured, killed in justified resistance, or escape without becoming a recurring personal villain.

## Choice

Affected Blackjacks demand the right to refuse future human-likeness use. Ashira may:

- accept a company stop rule and divided oversight;
- accept temporary supervision while arguing later;
- keep private control because only she understands the risk;
- destroy the copied method but conceal her original roster.

No one asks her to renounce Medium practice.

## Failure

- A mistaken decoy costs time, not instant death.
- Lost notes create Act III field caches.
- Destroyed projectors may also destroy identification evidence.
- Defeat results in Neda sealing the Yard while captives move deeper; the climax remains playable.

## Outcomes and Rewards

Record `yard_screen_state`, `copied_imprint_method_state`, individual captives, `ashira_act2_resolution`, and `ashira_direction`.

Unlock **Witness Circle** and the relationship commitment conversation. Missing the finale permanently closes romance, bond, and the reward for that playthrough.

## Navigation

- [[Ashira Companion Campaign]]
- [[What the Ruins Repeated]]
- [[The Garden Under Rain]]
- [[What We Keep Closed]]
- [[Borrowed Faces]]
