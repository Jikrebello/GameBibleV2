---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Crown Heights", "Ledger Quays"]
culture: ["Eclessian", "Virelian", "Fiorenzian"]
related_factions: ["Blackjack Corps", "Medori Bank"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-2
availability_window: ["Siege Winter"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["patrons_cabinet_state", "vardek_restoration_offer", "winter_relief_state", "elara_act2_resolution", "elara_direction", "elara_legal_debt_state"]
reward_unlocks: ["A Lady's Exit", "relationship commitment access"]
required_locations: ["Iron Ledger Counting-House", "Chancery House", "Grenzmark Keep", "Frozen Quays"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-finale
companion_campaign_stage: act-2
quest_owner: "Elara Velescar"
quest_sequence: 6
companion_id: "CMP-01"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: confrontation
relationship_variant: ""
encounter_deck: []
postgame_season: ""
estimated_hours: 1.75
gameplay_pillars: [social, infiltration, investigation, pursuit, choice]
required_states: ["elara_act1_resolution"]
optional_state_inputs: ["elara_winter_company_ready", "elara_roofline_route", "elara_bellandi_escrow_access", "elara_public_witnesses", "elara_bridgehold_practice"]
companion_required: "Elara Velescar"
duo_quest: true
pause_points: ["Approach Chosen", "Cabinet Located"]
preparation_inputs: ["elara_winter_company_ready", "elara_roofline_route", "elara_bellandi_escrow_access", "elara_public_witnesses", "elara_bridgehold_practice"]
preparation_threshold: "2 participate; 3 all material objectives; 4 one safeguard"
autonomous_deadline: "Ghor at the Gate"
autonomous_resolution: "Elara preserves relief and exposes part of the network but secretly keeps the restoration option."
changed_reentry: "Cabinet After Snow"
ensemble_inputs: ["Zafir ibn Samad", "Ilyana Veshkar"]
identity_hooks: ["Nobility", "Merchant/Craft", "Underworld", "Scholarly", "Peasant/Labour"]
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
archetype_pressure: "Elara faces an offer that flatters her best self and lets her curate culpability without a villain present to absorb the scene."
emotional_function: "Make remote patronage, relief, status, and confession collide inside an active heist."
pleasure_beat: "Dress, disguise, social improvisation, locked galleries, rooftops, and a frozen-quay chase."
care_beat: "Preserve genuine relief without using recipients as leverage or audience."
player_archetype_hooks: ["Cheerleader", "Tomboy", "Goth", "Bohemian", "Jock", "Nerd", "Rebel", "Goofball", "Grey"]
persistence_scope: regional-persistent
---
# The Patron's Cabinet

## Premise

Vardek's Grenzburg solicitor has placed a travelling cabinet inside Chancery House during a winter relief reception. It holds:

- grave-sale records;
- worker liabilities;
- Velescar seals;
- correspondence proving remote patronage;
- genuine grain warrants needed that night by besieged districts.

[[Claims-Factor Marco Bellandi]] separately presents Elara with Vardek's authenticated restoration offer. Vardek does not appear. His letter describes her as brave, overburdened, and uniquely capable of making restitution “with dignity.” It offers a reduced house, private reserve, and a story in which she alone was misled by disloyal factors.

Elara hates how good it sounds.

## Party and Approach

The player and Elara form a duo. Three assets make both evidence and relief achievable; fewer create material tradeoffs.

Approaches:

- **invitation:** use Elara's social status and a public reception;
- **legal seizure:** combine Bellandi escrow and public witnesses;
- **service route:** enter through kitchens, fuel halls, and roof maintenance;
- **underworld route:** cross frozen quays and a locked archive stair.

All routes converge on active gameplay and work for every vocation. Identity hooks change who trusts the player, how much exposure a mistake creates, and which room opens first.

## Beginning: The Reception

The social floor contains nobles, guild officers, relief captains, servants, debtors requesting warrants, and people treating the siege as a flattering backdrop.

Elara is brilliant. She rescues a nervous clerk from mockery, learns two guard rotations during a dance, and gives the player a title invented quickly enough to become true for five minutes.

Her shadow appears when she folds the relief captains into “our side” without asking whether they want the scandal attached to their work.

The player can build:

- a public diversion;
- a servant-led route;
- an authenticated seizure;
- a forged appointment;
- a physical breach after evacuation.

## Middle: The Three Cabinets

Three near-identical cabinets are distributed across Chancery House:

1. a public account cabinet;
2. a relief cabinet containing live warrants;
3. the patron's cabinet with evidence and the restoration seal.

The order can be learned through:

- construction marks;
- Bellandi's weights;
- servant movement;
- Elara's memory of Virelian packing sequence;
- a hidden heater needed to protect the live warrants.

Alarm does not lock the quest. It changes social movement into seizure, chase, or combat.

## Vardek's Presence Without Arrival

The restoration offer is read in a quiet records room while city bells report another fire. The letter never speaks aloud, changes magically, or controls anyone.

Elara first laughs:

> “He has remembered my favorite paper.”

Then she reaches the clause granting her authority to “settle” household claims.

The player can answer through temperament-specific chemistry, but no line solves the choice. Elara may pocket the seal, place it in Bellandi's escrow, tear the offer while preserving evidence, or keep it for the final settlement.

## Crisis and Pursuit

Local solicitor **Hadrik Venn** discovers the breach and orders the cabinet moved across the Frozen Quays while another agent releases smoke through the reception.

Objectives:

- evacuate guests and staff;
- keep grain warrants warm and dry;
- secure evidence;
- prevent the solicitor from removing the restoration seal.

Routes use the prepared roofline, public bridge, service sled, or ice stairs. A confrontation on moving sleds and frozen moorings ends the heist. Hadrik may be captured, killed in justified resistance, or escape; no later stage requires him.

## End

Bellandi records the legal result. Relief captains record whether their warrants arrived. Elara decides whether to admit:

- that Vardek financed her;
- that the offer appeals to her;
- that she is considering it;
- or that she has refused it.

The strongest scene is not a speech. In the Yard, Neda asks who saved the relief cabinet. Elara begins “we,” stops, and gives the names of the two service workers who dragged it clear while she chased the evidence.

## Fail-Forward

- Burned evidence survives through Bellandi's authenticated excerpts.
- Lost warrants can be reissued after district hunger and price consequences.
- A failed social route becomes a pursuit.
- Capture produces a legal hearing or Low Lantern extraction.
- Kept restoration terms remain repudiable through **Cabinet After Snow**, but relationship commitment closes if the finale is missed.

## Outputs

- `patrons_cabinet_state`: complete, divided, burned-copy, or lost;
- `vardek_restoration_offer`: refused, escrowed, retained, accepted, or repudiated;
- `winter_relief_state`: delivered, delayed, diverted, or lost;
- `elara_act2_resolution`: accountable, mixed, or entitled;
- `elara_legal_debt_state`: unchanged, under-review, restructured, or satisfied as evidence permits;
- `elara_direction`.

Completion unlocks **A Lady's Exit**, the post-quest relationship choice, and the appropriate romance or bond commitment gate.

## Navigation

- [[Elara Companion Campaign]]
- [[The Winter Company]]
- [[Claims-Factor Marco Bellandi]]
- [[Raven Shelf at Dawn]]
- [[Two Names on the Rope]]
- [[The Hands That Hold It]]
