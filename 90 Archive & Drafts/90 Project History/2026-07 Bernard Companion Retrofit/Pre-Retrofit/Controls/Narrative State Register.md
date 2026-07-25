---
type: reference
status: archived
canon_level: obsolete
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg"]
culture: []
related_factions: ["Duchy of Grenzburg", "Blackjack Corps", "Medori Bank", "Church of the Redeemer", "Folk kindreds", "Grenzburg underworld"]
appears_in: ["Grenzburg"]
needs: []
aliases: ["Grenzburg Narrative State Register"]
tags: [game-ready]
archive_reason: "Snapshot before Bernard's ten-piece companion campaign retrofit"
archived_from: "02 Playable Settings/Grenzburg/10 Production Bible/Narrative State Register.md"
archived_on: 2026-07-24
superseded_by: "[[Narrative State Register]]"
---
# Narrative State Register

This note controls companion, faction, relationship, identity-reactivity, systemic-world, postgame, and composite-settlement variables. [[Main Campaign State Matrix]] controls critical-path outputs. Implementation may store them as enums, flags, sets, or authored bundles without changing their meaning.

## Companion State

Each companion ID records:

| Field | Controlled values |
|---|---|
| field_availability | unavailable, offered, available, declined-repairable, refused, departed, dead |
| campaign_tracking | undiscovered, untracked, tracked, closed |
| campaign_stage | introduction, act-1, act-2, act-3, summer, complete |
| architecture_status | pending-migration, migrated, reserved, current, retired |
| approval | Guarded, Open, Trusted, Strained |
| shared_history | named witnessed events and credible reports; never raw time or repeatable-job count |
| preparation_inputs | named authored set for the current act chapter |
| readiness | unprepared, viable, prepared, strongly-prepared |
| autonomous_assignment | named current schedule or intended action |
| autonomous_result | unresolved or a companion-specific deterministic state |
| changed_reentry | unavailable, offered, active, complete, or companion-specific closed state |
| injury_state | none or named authored injury |
| relationship_scenes | named completed, declined, or closed scenes |
| unresolved_conflicts | named set, never a hidden number |
| personal_outcome | unresolved, resolved, compromised, broken, departed, sacrifice |
| relationship | none, interest, romance-committed, bond-committed |
| relationship_perk | none or the companion's learned permanent non-slot perk |
| duo_move | none or the committed companion's active-party move |
| duo_finale_state | inactive, offered, staged, active, paused, complete, autonomous, transformed |
| summer_destination | named authored state from the Act III finale and summer settlement |

At most one companion may occupy romance-committed, and at most one same-sex companion may occupy bond-committed. Neither relationship is mandatory. Commitment cannot occur before the Act II finale. A warned conflict and repair state precede player-caused departure. Autonomous departure uses its own legible schedule and aftermath.

Every act finale sets `duo_finale_state` to staged before dismissing the other active companions. Pausing records its named chapter break and restores normal party management; resuming reforms the duo at the staging point. Introductions and operations retain the normal party. Temporary NPC allies never write a companion field-availability or active-party slot.

## Companion IDs

| ID | Companion | Sex | Vocation |
|---|---|---|---|
| CMP-01 | [[Elara Velescar]] | woman | [[Slayer]] - Delver-Duelist variant |
| CMP-02 | [[Ilyana Veshkar]] | woman | [[Warlock]] |
| CMP-03 | [[Svala Last-Beacon]] | woman | [[Fighter]] |
| CMP-04 | [[Ashira bath Melan]] | woman | [[Medium]] |
| CMP-05 | [[Bernard Valeon]] | man | [[Paladin]] |
| CMP-06 | [[Dismas Raben]] | man | [[Hunter]] |
| CMP-07 | [[Tavio Meran]] | man | [[Rune Fist]] |
| CMP-08 | [[Zafir ibn Samad]] | man | [[Binder]] |

Each ID owns ten formal content slots through [[Companion Campaign Expansion Register]], eight to twelve embedded opportunities, three act-specific autonomous routes, and one main-campaign contribution per act.

## Systemic World State

Systemic encounter history records:

| Field | Controlled use |
|---|---|
| encounter_card_history | one-shot, finite-repeat count, repeatable cooldown, or unseen |
| local_route_condition | open, watched, threatened, obstructed, closed, or restored |
| local_patrol_state | absent, friendly, neutral, hostile, contested, or displaced |
| local_supply_pressure | stable, strained, scarce, disrupted, or recovering |
| local_population_pressure | ordinary, crowded, displaced, evacuated, or returning |
| encounter_followups | named authored cards unlocked or closed by prior results |

Systemic cards may write only bounded local state. Named deaths, major settlement destruction, faction endings, and companion outcomes require bespoke authored content.

## Postgame State

| Field | Controlled values |
|---|---|
| postgame_cycle_unlocked | false or true after [[The First Summer Road]] |
| postgame_season | summer, autumn, winter, or spring |
| postgame_advance_available | false or true at a supported rest point |
| postgame_cycle_count | implementation-only loop count with no canonical-year meaning |

Advancing `postgame_season` changes postwar traversal, ecology, services, prices, populations, and renewable jobs. It never clears campaign, faction, companion, casualty, dungeon, or political outputs.

## Faction State

Each faction line records rank, institutional stance, completed sequence, internal alignment, branch, services, leader states, and settlement result. Rank and stance are displayed qualitatively; no universal reputation number combines the lines.

| Line | Rank ladder | Late alignment |
|---|---|---|
| ducal-marcher | Probationer, Warranted Specialist, March Officer, Charter Witness | civil service, ducal discretion, martial administration |
| blackjacks-medori | Asset, Proven Hand, Company Voice, Settled Member | free company, cooperative, ducal corps, Medori reform, Koss control |
| church | Helper, Trusted Servant, Diocesan Agent, Bounds Witness | bounded diocese, episcopal court, secular restriction, dual system |
| four-hearth | Stranger, Road Friend, Hearth Witness, Compact Witness | seasonal compact, permanent compact, bilateral network, dissolution |
| underworld | Unknown, Door-Known, Route-Keeper, Night Power | Low Lantern, Black Bell, civil evidence network, splintered |

## Composite Political Settlement

The summer settlement always reads five independent terms:

- `settlement_military_authority`
- `settlement_debt_regime`
- `settlement_church_jurisdiction`
- `settlement_folk_rights`
- `settlement_underworld_power`

These combine with settlement survival, material losses, player freedom, companion outcomes, and principal-leader states. Best terms may coexist. No combination is selected as future-setting canon.

## Main Campaign Boundary

The campaign writes its own named outputs from MQ-01 through SQ-02. Companion and faction quests may read those values and supply optional advantages, but must not silently overwrite fixed results such as Tannbruck's fall, the Drake's death, Ghor's death, Gerhold's severance, or destruction of the Deep Muster altar.

Summer composition reads both registers:

- [[Main Campaign State Matrix]] supplies casualties, sites, routes, Grobi aftermath, law-gem custody, anchor state, and campaign victory;
- this register supplies companion destinations, relationships, faction terms, player debt freedom, and institutional outcomes.

Duplicate implementation keys across these authorities are prohibited unless one note explicitly delegates ownership to the other.

## Lock State

- All five faction lines can reach quest six before an exclusive internal commitment.
- Faction quest seven displays the exact alignment consequences.
- Underworld quest six opens a branch prompt; beginning either branch quest seven closes the other branch.
- Romance and sworn bond use separate slots.
- Companion act chapters converge at the act-ending main-story gate.
- Only tracked companion campaigns appear on the consolidated transition docket.
- Autonomous results are deterministic and cannot kill a companion unseen.
- Missing a finale closes its original version and writes a changed-reentry state.
- Main-story completion never requires a faction or relationship commitment.

## Authored Output Registry

| Output | Class | Owner | Sequence | Source quest |
|---|---|---|---:|---|
| `ashira_roster_custody` | companion | Ashira bath Melan | 1 | [[The Faces She Kept]] |
| `medium_public_fear` | companion | Ashira bath Melan | 1 | [[The Faces She Kept]] |
| `qesheth_judgement_found` | companion | Ashira bath Melan | 1 | [[The Faces She Kept]] |
| `ashira_terror_method` | companion | Ashira bath Melan | 2 | [[A Useful Terror]] |
| `bent_oak_families` | companion | Ashira bath Melan | 2 | [[A Useful Terror]] |
| `sunken_causeway_access` | companion | Ashira bath Melan | 2 | [[A Useful Terror]] |
| `ashira_liability_state` | companion | Ashira bath Melan | 3 | [[The Price of the Bow Tower]] |
| `ashira_relationship_commitment` | companion | Ashira bath Melan | 3 | [[The Price of the Bow Tower]] |
| `human_imprint_policy` | companion | Ashira bath Melan | 3 | [[The Price of the Bow Tower]] |
| `qesheth_charter_protected` | companion | Ashira bath Melan | 3 | [[The Price of the Bow Tower]] |
| `ashira_arc_outcome` | companion | Ashira bath Melan | 4 | [[No Human Shadow]] |
| `ashira_summer_destination` | companion | Ashira bath Melan | 4 | [[No Human Shadow]] |
| `human_roster_final_state` | companion | Ashira bath Melan | 4 | [[No Human Shadow]] |
| `medium_field_school` | companion | Ashira bath Melan | 4 | [[No Human Shadow]] |
| `bernard_care_observed` | companion gate | Bernard Valeon | 0 | [[Bernard Field Familiarity and Relationships]] |
| `bernard_property_choice_observed` | companion gate | Bernard Valeon | 0 | [[Bernard Field Familiarity and Relationships]] |
| `bernard_shared_danger_observed` | companion gate | Bernard Valeon | 0 | [[Bernard Field Familiarity and Relationships]] |
| `bernard_child_or_refuge_observed` | companion gate | Bernard Valeon | 0 | [[Bernard Field Familiarity and Relationships]] |
| `bernard_food_choice_observed` | companion gate | Bernard Valeon | 0 | [[Bernard Field Familiarity and Relationships]] |
| `bernard_self_report_observed` | companion gate | Bernard Valeon | 0 | [[Bernard Field Familiarity and Relationships]] |
| `bernard_winter_care_observed` | companion gate | Bernard Valeon | 0 | [[Bernard Field Familiarity and Relationships]] |
| `bernard_authority_choice_observed` | companion gate | Bernard Valeon | 0 | [[Bernard Field Familiarity and Relationships]] |
| `bernard_reclamation_observed` | companion gate | Bernard Valeon | 0 | [[Bernard Field Familiarity and Relationships]] |
| `things_not_mine_count` | companion system | Bernard Valeon | 0 | [[Bernard Compulsion and Accountability System]] |
| `bernard_self_report_state` | companion system | Bernard Valeon | 0 | [[Bernard Compulsion and Accountability System]] |
| `bernard_incident_consequence` | companion system | Bernard Valeon | 0 | [[Bernard Compulsion and Accountability System]] |
| `bernard_compulsion_disclosed` | companion | Bernard Valeon | 1 | [[Little Things Missing]] |
| `bernard_accountability_plan` | companion | Bernard Valeon | 1 | [[Little Things Missing]] |
| `little_things_returned` | companion | Bernard Valeon | 1 | [[Little Things Missing]] |
| `kitchen_helper_state` | companion | Bernard Valeon | 1 | [[Little Things Missing]] |
| `koss_bernard_leverage` | companion | Bernard Valeon | 1 | [[Little Things Missing]] |
| `road_school_state` | companion | Bernard Valeon | 2 | [[Little Hands, Long Road]] |
| `chapel_children_state` | companion | Bernard Valeon | 2 | [[Little Hands, Long Road]] |
| `mika_food_state` | companion | Bernard Valeon | 2 | [[Little Hands, Long Road]] |
| `wounded_bear_state` | companion | Bernard Valeon | 2 | [[Little Hands, Long Road]] |
| `bent_oak_refuge_state` | companion | Bernard Valeon | 2 | [[Little Hands, Long Road]] |
| `bernard_paladin_unlocked` | progression | Bernard Valeon | 3 | [[Embers Without Excuse]] |
| `bernard_relationship_commitment` | relationship | Bernard Valeon | 3 | [[Embers Without Excuse]] |
| `bernard_white_flame_kindling` | companion | Bernard Valeon | 3 | [[Embers Without Excuse]] |
| `petra_ilev_response` | companion | Bernard Valeon | 3 | [[Embers Without Excuse]] |
| `long_watch_return_open` | companion | Bernard Valeon | 3 | [[Embers Without Excuse]] |
| `lantern_relief_mission_state` | companion | Bernard Valeon | 3 | [[Embers Without Excuse]] |
| `bernard_arc_outcome` | companion | Bernard Valeon | 4 | [[The Open Hospice]] |
| `bernard_future_path` | companion | Bernard Valeon | 4 | [[The Open Hospice]] |
| `open_lamp_hospice_state` | companion | Bernard Valeon | 4 | [[The Open Hospice]] |
| `paladin_capstone_unlocked` | progression | Bernard Valeon | 4 | [[The Open Hospice]] |
| `long_watch_field_form_blueprint` | progression | Bernard Valeon | 4 | [[The Open Hospice]] |
| `bernard_summer_destination` | companion | Bernard Valeon | 4 | [[The Open Hospice]] |
| `bernard_relationship_perk` | relationship | Bernard Valeon | 4 | [[The Open Hospice]] |
| `bernard_duo_move` | relationship | Bernard Valeon | 4 | [[The Open Hospice]] |
| `dismas_old_crime_named` | companion | Dismas Raben | 1 | [[The Sound of Falling Stone]] |
| `dismas_rescue_response` | companion | Dismas Raben | 1 | [[The Sound of Falling Stone]] |
| `quarry_workers_state` | companion | Dismas Raben | 1 | [[The Sound of Falling Stone]] |
| `dismas_ambush_doctrine` | companion | Dismas Raben | 2 | [[The Easy Ambush]] |
| `ravine_civilian_state` | companion | Dismas Raben | 2 | [[The Easy Ambush]] |
| `winter_medicine_state` | companion | Dismas Raben | 2 | [[The Easy Ambush]] |
| `dismas_public_charge` | companion | Dismas Raben | 3 | [[The Name on the Charge]] |
| `dismas_relationship_commitment` | companion | Dismas Raben | 3 | [[The Name on the Charge]] |
| `dismas_service_terms` | companion | Dismas Raben | 3 | [[The Name on the Charge]] |
| `marta_etten_state` | companion | Dismas Raben | 3 | [[The Name on the Charge]] |
| `dismas_arc_outcome` | companion | Dismas Raben | 4 | [[The Road That Answers]] |
| `dismas_summer_destination` | companion | Dismas Raben | 4 | [[The Road That Answers]] |
| `marcher_scout_service` | companion | Dismas Raben | 4 | [[The Road That Answers]] |
| `three_horn_evacuated` | companion | Dismas Raben | 4 | [[The Road That Answers]] |
| `elara_recruited` | companion gate | Elara Velescar | 0 | [[Elara Velescar]] |
| `elara_first_outing_complete` | companion gate | Elara Velescar | 0 | [[Elara Companion Campaign]] |
| `southwood_early_warning` | main campaign | Grenzburg Main Campaign | 1 | [[Roads Worth Saving]] |
| `winter_strands_open` | main campaign | Grenzburg Main Campaign | 2 | [[Winter's Teeth]] |
| `muster_known` | main campaign | Grenzburg Main Campaign | 3 | [[The Open Thaw]] |
| `spring_settlement_access` | main campaign | Grenzburg Main Campaign | 3 | [[The Land Reclaimed]] |
| `companion_summer_codas_unlocked` | main campaign | Grenzburg Main Campaign | 5 | [[Accounts of the Living]] |
| `elara_introduction_complete` | companion campaign | Elara Velescar | 1 | [[Names Beneath Lime]] |
| `elara_direction` | companion direction | Elara Velescar | 1-4 | [[Elara Companion Campaign]] |
| `elara_act1_readiness` | companion readiness | Elara Velescar | 2 | [[Elara Companion Campaign]] |
| `elara_act2_readiness` | companion readiness | Elara Velescar | 3 | [[Elara Companion Campaign]] |
| `elara_act3_readiness` | companion readiness | Elara Velescar | 4 | [[Elara Companion Campaign]] |
| `elara_act1_readiness_viable` | companion gate | Elara Velescar | 2 | [[Elara Companion Campaign]] |
| `elara_act2_readiness_viable` | companion gate | Elara Velescar | 3 | [[Elara Companion Campaign]] |
| `elara_act3_readiness_viable` | companion gate | Elara Velescar | 4 | [[Elara Companion Campaign]] |
| `elara_act1_chapter_resolved` | companion campaign | Elara Velescar | 2 | [[A House Fed by Bones]] |
| `elara_act2_chapter_resolved` | companion campaign | Elara Velescar | 3 | [[The Patron's Cabinet]] |
| `elara_act3_finale_played` | companion campaign | Elara Velescar | 4 | [[No Lady of Velescar]] |
| `elara_act1_result` | companion campaign | Elara Velescar | 2 | [[A House Fed by Bones]] |
| `elara_act2_result` | companion campaign | Elara Velescar | 3 | [[The Patron's Cabinet]] |
| `elara_act3_result` | companion campaign | Elara Velescar | 4 | [[No Lady of Velescar]] |
| `elara_act2_finale_played` | companion gate | Elara Velescar | 3 | [[The Patron's Cabinet]] |
| `elara_relationship_closed` | relationship | Elara Velescar | 3 | [[Elara Companion Campaign]] |
| `elara_sixth_fieldbook_secured` | companion preparation | Elara Velescar | 2 | [[The Sixth Field Book]] |
| `elara_southwood_route_intelligence` | companion preparation | Elara Velescar | 2 | [[Roads Worth Saving]] |
| `elara_burial_name_support` | companion preparation | Elara Velescar | 2 | [[Bread and Burial]] |
| `elara_shoring_knowledge` | companion preparation | Elara Velescar | 2 | [[Elara Companion Campaign]] |
| `elara_living_custodian_support` | companion preparation | Elara Velescar | 2 | [[Elara Companion Campaign]] |
| `elara_warrant_casket_key` | companion preparation | Elara Velescar | 3 | [[Eight Honest Warrants]] |
| `elara_winter_roofline_proven` | companion preparation | Elara Velescar | 3 | [[The City in Siege]] |
| `elara_lucia_logistics_copy` | companion preparation | Elara Velescar | 3 | [[Lucia's Long Book]] |
| `elara_danara_authentication` | companion preparation | Elara Velescar | 3 | [[Danara Veln]] |
| `elara_bridgehold_line_practiced` | companion preparation | Elara Velescar | 3 | [[A Better Wager]] |
| `elara_household_claims_protected` | companion preparation | Elara Velescar | 4 | [[Sixty-Three Claims]] |
| `elara_living_claims_indexed` | companion preparation | Elara Velescar | 4 | [[The Land Reclaimed]] |
| `elara_kata_delegation_ready` | companion preparation | Elara Velescar | 4 | [[Kata Belyn]] |
| `elara_burial_provenance_matched` | companion preparation | Elara Velescar | 4 | [[The Names They Buried]] |
| `elara_old_tithe_route_known` | companion preparation | Elara Velescar | 4 | [[Elara Companion Campaign]] |
| `elara_raven_line_practiced` | companion bonus | Elara Velescar | 4 | [[Raven Shelf at Dawn]] |
| `elara_wager_scene` | relationship | Elara Velescar | 1 | [[Elara Field Familiarity and Relationships]] |
| `elara_friendship_episode` | relationship | Elara Velescar | 2 | [[A Better Wager]] |
| `elara_rooftop_wager_result` | relationship | Elara Velescar | 2 | [[A Better Wager]] |
| `elara_without_powder_scene` | relationship | Elara Velescar | 2 | [[A Better Wager]] |
| `elara_relationship_episode` | relationship | Elara Velescar | 4 | [[Raven Shelf at Dawn]] |
| `elara_duo_move_upgrade` | relationship | Elara Velescar | 4 | [[Raven Shelf at Dawn]] |
| `raven_signal_runner_state` | companion | Elara Velescar | 4 | [[Raven Shelf at Dawn]] |
| `elara_first_confession` | companion | Elara Velescar | 1 | [[Names Beneath Lime]] |
| `elara_names_recorded` | companion | Elara Velescar | 1 | [[Names Beneath Lime]] |
| `elara_public_culpability` | companion | Elara Velescar | 1 | [[Names Beneath Lime]] |
| `grave_goods_state` | companion | Elara Velescar | 1 | [[Names Beneath Lime]] |
| `customs_porter_state` | companion | Elara Velescar | 1 | [[Names Beneath Lime]] |
| `vasko_trace_state` | companion | Elara Velescar | 1 | [[Names Beneath Lime]] |
| `elara_worker_roll_state` | companion | Elara Velescar | 2 | [[The Sixth Field Book]] |
| `elara_seven_mounds_survey_state` | companion | Elara Velescar | 2 | [[The Sixth Field Book]] |
| `auction_runner_state` | companion | Elara Velescar | 2 | [[The Sixth Field Book]] |
| `daria_keln_identified` | companion | Elara Velescar | 2 | [[The Sixth Field Book]] |
| `seven_mounds_state` | companion | Elara Velescar | 2 | [[A House Fed by Bones]] |
| `coerced_diggers_state` | companion | Elara Velescar | 2 | [[A House Fed by Bones]] |
| `kata_belyn_state` | companion | Elara Velescar | 2 | [[A House Fed by Bones]] |
| `vasko_dren_state` | companion | Elara Velescar | 2 | [[A House Fed by Bones]] |
| `daria_keln_state` | companion | Elara Velescar | 2-4 | [[Daria Keln]] |
| `elara_fieldbook_state` | companion | Elara Velescar | 2 | [[A House Fed by Bones]] |
| `vardek_chain_proof` | companion | Elara Velescar | 2 | [[A House Fed by Bones]] |
| `elara_workers_before_proof` | companion | Elara Velescar | 2 | [[A House Fed by Bones]] |
| `eight_warrants_state` | companion | Elara Velescar | 3 | [[Eight Honest Warrants]] |
| `vardek_relief_route_state` | companion | Elara Velescar | 3 | [[Eight Honest Warrants]] |
| `hidden_payment_strip_state` | companion | Elara Velescar | 3 | [[Eight Honest Warrants]] |
| `warrant_courier_state` | companion | Elara Velescar | 3 | [[Eight Honest Warrants]] |
| `cabinet_integrity` | companion | Elara Velescar | 3 | [[The Patron's Cabinet]] |
| `elara_vardek_verdict` | companion | Elara Velescar | 3 | [[The Patron's Cabinet]] |
| `virelian_relief_state` | companion | Elara Velescar | 3 | [[The Patron's Cabinet]] |
| `danara_veln_state` | companion | Elara Velescar | 3 | [[The Patron's Cabinet]] |
| `vardek_escape_route` | companion | Elara Velescar | 3 | [[The Patron's Cabinet]] |
| `old_tithe_vault_known` | companion | Elara Velescar | 3 | [[The Patron's Cabinet]] |
| `elara_patron_refused` | companion | Elara Velescar | 3 | [[The Patron's Cabinet]] |
| `elara_relationship_commitment` | companion | Elara Velescar | 3 | [[The Patron's Cabinet]] |
| `velescar_delegate_states` | companion | Elara Velescar | 4 | [[Sixty-Three Claims]] |
| `velescar_claimant_priorities` | companion | Elara Velescar | 4 | [[Sixty-Three Claims]] |
| `claim_substitution_state` | companion | Elara Velescar | 4 | [[Sixty-Three Claims]] |
| `elara_arc_outcome` | companion | Elara Velescar | 4 | [[No Lady of Velescar]] |
| `velescar_land_state` | companion | Elara Velescar | 4 | [[No Lady of Velescar]] |
| `velescar_burial_state` | companion | Elara Velescar | 4 | [[No Lady of Velescar]] |
| `velescar_title_state` | companion | Elara Velescar | 4 | [[No Lady of Velescar]] |
| `burial_repair_fund` | companion | Elara Velescar | 4 | [[No Lady of Velescar]] |
| `old_tithe_vault_state` | companion | Elara Velescar | 4 | [[No Lady of Velescar]] |
| `elara_summer_destination` | companion | Elara Velescar | 4 | [[No Lady of Velescar]] |
| `elara_relationship_perk` | relationship | Elara Velescar | 4 | [[No Lady of Velescar]] |
| `elara_duo_move` | relationship | Elara Velescar | 4 | [[No Lady of Velescar]] |
| `delver_duelist_blueprint` | progression | Elara Velescar | 4 | [[No Lady of Velescar]] |
| `elara_summer_coda` | companion | Elara Velescar | 5 | [[The First Honest Find]] |
| `ropehouse_find_state` | companion | Elara Velescar | 5 | [[The First Honest Find]] |
| `ropehouse_custody_state` | companion | Elara Velescar | 5 | [[The First Honest Find]] |
| `elara_provenance_board` | companion | Elara Velescar | 5 | [[The First Honest Find]] |
| `elara_scarred_mounds_state` | companion re-entry | Elara Velescar | 3 | [[Elara Companion Campaign]] |
| `elara_cabinet_after_snow_state` | companion re-entry | Elara Velescar | 4 | [[Elara Companion Campaign]] |
| `ilyana_medal_state` | companion | Ilyana Veshkar | 1 | [[The Medal in the Mud]] |
| `koss_ilyana_leverage` | companion | Ilyana Veshkar | 1 | [[The Medal in the Mud]] |
| `relief_platoon_roll` | companion | Ilyana Veshkar | 1 | [[The Medal in the Mud]] |
| `ilyana_breach_method` | companion | Ilyana Veshkar | 2 | [[A Breach Too Clean]] |
| `tollworks_civilians` | companion | Ilyana Veshkar | 2 | [[A Breach Too Clean]] |
| `warlock_hall_opinion` | companion | Ilyana Veshkar | 2 | [[A Breach Too Clean]] |
| `ilyana_milen_verdict` | companion | Ilyana Veshkar | 3 | [[Names Behind the Wall]] |
| `ilyana_relationship_commitment` | companion | Ilyana Veshkar | 3 | [[Names Behind the Wall]] |
| `relief_names_public` | companion | Ilyana Veshkar | 3 | [[Names Behind the Wall]] |
| `winter_artillery_state` | companion | Ilyana Veshkar | 3 | [[Names Behind the Wall]] |
| `blackjack_specialist_doctrine` | companion | Ilyana Veshkar | 4 | [[Hold Until Relieved]] |
| `ilyana_arc_outcome` | companion | Ilyana Veshkar | 4 | [[Hold Until Relieved]] |
| `ilyana_summer_destination` | companion | Ilyana Veshkar | 4 | [[Hold Until Relieved]] |
| `tannbruck_repairs` | companion | Ilyana Veshkar | 4 | [[Hold Until Relieved]] |
| `attar_delegation_trust` | companion | Svala Last-Beacon | 1 | [[The Unpaid Champion]] |
| `champion_yield_known` | companion | Svala Last-Beacon | 1 | [[The Unpaid Champion]] |
| `svala_weregild_state` | companion | Svala Last-Beacon | 1 | [[The Unpaid Champion]] |
| `granary_civilian_state` | companion | Svala Last-Beacon | 2 | [[Yield Heard Twice]] |
| `surrendered_deserter_state` | companion | Svala Last-Beacon | 2 | [[Yield Heard Twice]] |
| `svala_recall_method` | companion | Svala Last-Beacon | 2 | [[Yield Heard Twice]] |
| `rimewing_training_state` | companion | Svala Last-Beacon | 3 | [[The Rimewing Trial]] |
| `svala_relationship_commitment` | companion | Svala Last-Beacon | 3 | [[The Rimewing Trial]] |
| `svala_trial_verdict` | companion | Svala Last-Beacon | 3 | [[The Rimewing Trial]] |
| `last_hearth_refuge_state` | companion | Svala Last-Beacon | 4 | [[Last Beacon, First Road]] |
| `svala_arc_outcome` | companion | Svala Last-Beacon | 4 | [[Last Beacon, First Road]] |
| `svala_summer_destination` | companion | Svala Last-Beacon | 4 | [[Last Beacon, First Road]] |
| `winter_road_protection` | companion | Svala Last-Beacon | 4 | [[Last Beacon, First Road]] |
| `championship_cheating_known` | companion | Tavio Meran | 1 | [[The False Ring]] |
| `forge_safety_state` | companion | Tavio Meran | 1 | [[The False Ring]] |
| `tavio_insert_state` | companion | Tavio Meran | 1 | [[The False Ring]] |
| `cold_iron_supply` | companion | Tavio Meran | 2 | [[Proof Under Load]] |
| `rune_fist_safety_doctrine` | companion | Tavio Meran | 2 | [[Proof Under Load]] |
| `tavio_rigging_network` | companion | Tavio Meran | 2 | [[Proof Under Load]] |
| `crucible_exposure` | companion | Tavio Meran | 3 | [[The Fair Defeat]] |
| `lio_varcen_state` | companion | Tavio Meran | 3 | [[The Fair Defeat]] |
| `tavio_fair_duel_result` | companion | Tavio Meran | 3 | [[The Fair Defeat]] |
| `tavio_relationship_commitment` | companion | Tavio Meran | 3 | [[The Fair Defeat]] |
| `great_forge_state` | companion | Tavio Meran | 4 | [[Horn for Leak-Day]] |
| `leak_warden_service` | companion | Tavio Meran | 4 | [[Horn for Leak-Day]] |
| `tavio_arc_outcome` | companion | Tavio Meran | 4 | [[Horn for Leak-Day]] |
| `tavio_summer_destination` | companion | Tavio Meran | 4 | [[Horn for Leak-Day]] |
| `samira_identity_known` | companion | Zafir ibn Samad | 1 | [[The Cord Returned]] |
| `zafir_cord_custody` | companion | Zafir ibn Samad | 1 | [[The Cord Returned]] |
| `zafir_prior_practice` | companion | Zafir ibn Samad | 1 | [[The Cord Returned]] |
| `debtor_workers_state` | companion | Zafir ibn Samad | 2 | [[Humane Terms]] |
| `workshop_winter_output` | companion | Zafir ibn Samad | 2 | [[Humane Terms]] |
| `zafir_humane_terms_verdict` | companion | Zafir ibn Samad | 2 | [[Humane Terms]] |
| `living_binding_doctrine` | companion | Zafir ibn Samad | 3 | [[The Copyist's Answer]] |
| `samira_status` | companion | Zafir ibn Samad | 3 | [[The Copyist's Answer]] |
| `zafir_binder_unlocked` | companion | Zafir ibn Samad | 3 | [[The Copyist's Answer]] |
| `zafir_relationship_commitment` | companion | Zafir ibn Samad | 3 | [[The Copyist's Answer]] |
| `binder_capstone_unlocked` | companion | Zafir ibn Samad | 4 | [[All Cords Cut Clean]] |
| `living_cords_final_state` | companion | Zafir ibn Samad | 4 | [[All Cords Cut Clean]] |
| `zafir_arc_outcome` | companion | Zafir ibn Samad | 4 | [[All Cords Cut Clean]] |
| `zafir_summer_destination` | companion | Zafir ibn Samad | 4 | [[All Cords Cut Clean]] |
| `blackjack_rank_admitted` | faction | Blackjacks and Medori | 1 | [[Terms of Service]] |
| `brina_trust` | faction | Blackjacks and Medori | 1 | [[Terms of Service]] |
| `induction_terms_state` | faction | Blackjacks and Medori | 1 | [[Terms of Service]] |
| `blackjack_gear_supply` | faction | Blackjacks and Medori | 2 | [[The Equipment Account]] |
| `equipment_account_rule` | faction | Blackjacks and Medori | 2 | [[The Equipment Account]] |
| `koss_predation_evidence` | faction | Blackjacks and Medori | 2 | [[The Equipment Account]] |
| `blackjack_injury_rule` | faction | Blackjacks and Medori | 3 | [[A Debt That Grew Wounded]] |
| `lucia_reform_limit` | faction | Blackjacks and Medori | 3 | [[A Debt That Grew Wounded]] |
| `wounded_debtor_state` | faction | Blackjacks and Medori | 3 | [[A Debt That Grew Wounded]] |
| `lucia_long_book_state` | faction | Blackjacks and Medori | 4 | [[Lucia's Long Book]] |
| `valuable_debtors_exposed` | faction | Blackjacks and Medori | 4 | [[Lucia's Long Book]] |
| `winter_grain_credit` | faction | Blackjacks and Medori | 4 | [[Lucia's Long Book]] |
| `collection_precedent` | faction | Blackjacks and Medori | 5 | [[Collections Day]] |
| `three_mills_debt_state` | faction | Blackjacks and Medori | 5 | [[Collections Day]] |
| `winter_flour_output` | faction | Blackjacks and Medori | 5 | [[Collections Day]] |
| `debtor_solidarity` | faction | Blackjacks and Medori | 6 | [[The Blackjacks Koss Lost]] |
| `koss_abandonment_proof` | faction | Blackjacks and Medori | 6 | [[The Blackjacks Koss Lost]] |
| `lost_blackjacks_state` | faction | Blackjacks and Medori | 6 | [[The Blackjacks Koss Lost]] |
| `blackjack_internal_alignment` | faction | Blackjacks and Medori | 7 | [[Mutiny in Debtors' Row]] |
| `koss_command_state` | faction | Blackjacks and Medori | 7 | [[Mutiny in Debtors' Row]] |
| `mutiny_casualties` | faction | Blackjacks and Medori | 7 | [[Mutiny in Debtors' Row]] |
| `blackjack_legal_form` | faction | Blackjacks and Medori | 8 | [[Purchase of Freedom]] |
| `medori_compensation` | faction | Blackjacks and Medori | 8 | [[Purchase of Freedom]] |
| `player_debt_freedom` | faction | Blackjacks and Medori | 8 | [[Purchase of Freedom]] |
| `blackjack_line_outcome` | faction | Blackjacks and Medori | 9 | [[Free Company Articles]] |
| `settlement_debt_regime` | faction | Blackjacks and Medori | 9 | [[Free Company Articles]] |
| `summer_blackjack_presence` | faction | Blackjacks and Medori | 9 | [[Free Company Articles]] |
| `camp_bread_state` | faction | Church of Grenzburg | 1 | [[Bread and Burial]] |
| `church_rank_admitted` | faction | Church of Grenzburg | 1 | [[Bread and Burial]] |
| `pauper_names_recorded` | faction | Church of Grenzburg | 1 | [[Bread and Burial]] |
| `church_record_trust` | faction | Church of Grenzburg | 2 | [[The Unquiet Name]] |
| `residue_burial_state` | faction | Church of Grenzburg | 2 | [[The Unquiet Name]] |
| `willow_grave_name` | faction | Church of Grenzburg | 2 | [[The Unquiet Name]] |
| `chapel_households` | faction | Church of Grenzburg | 3 | [[Ash at the Door]] |
| `church_search_precedent` | faction | Church of Grenzburg | 3 | [[Ash at the Door]] |
| `ignatius_restraint_state` | faction | Church of Grenzburg | 3 | [[Ash at the Door]] |
| `confessional_evidence_rule` | faction | Church of Grenzburg | 4 | [[The Chancery Key]] |
| `marcellina_network_state` | faction | Church of Grenzburg | 4 | [[The Chancery Key]] |
| `protected_informants` | faction | Church of Grenzburg | 4 | [[The Chancery Key]] |
| `cathedral_public_trust` | faction | Church of Grenzburg | 5 | [[A Relic Proven False]] |
| `delver_witness_state` | faction | Church of Grenzburg | 5 | [[A Relic Proven False]] |
| `false_relic_verdict` | faction | Church of Grenzburg | 5 | [[A Relic Proven False]] |
| `caestus_pastoral_authority` | faction | Church of Grenzburg | 6 | [[Mercy in Winter]] |
| `mercy_hospital_state` | faction | Church of Grenzburg | 6 | [[Mercy in Winter]] |
| `white_flame_miracle_witnessed` | faction | Church of Grenzburg | 6 | [[Mercy in Winter]] |
| `church_internal_alignment` | faction | Church of Grenzburg | 7 | [[Jurisdiction of Fire]] |
| `secular_case_verdict` | faction | Church of Grenzburg | 7 | [[Jurisdiction of Fire]] |
| `spiritual_case_verdict` | faction | Church of Grenzburg | 7 | [[Jurisdiction of Fire]] |
| `caestus_hospital_control` | faction | Church of Grenzburg | 8 | [[The Bishop's Bounds]] |
| `church_appeal_rule` | faction | Church of Grenzburg | 8 | [[The Bishop's Bounds]] |
| `diocesan_bounds` | faction | Church of Grenzburg | 8 | [[The Bishop's Bounds]] |
| `church_line_outcome` | faction | Church of Grenzburg | 9 | [[The Keys Returned]] |
| `settlement_church_jurisdiction` | faction | Church of Grenzburg | 9 | [[The Keys Returned]] |
| `summer_church_presence` | faction | Church of Grenzburg | 9 | [[The Keys Returned]] |
| `ducal_rank_admitted` | faction | Ducal and Marcher Service | 1 | [[A Warrant Earned]] |
| `provisional_warrant_state` | faction | Ducal and Marcher Service | 1 | [[A Warrant Earned]] |
| `tann_gate_convoy` | faction | Ducal and Marcher Service | 1 | [[A Warrant Earned]] |
| `ducal_field_seal` | faction | Ducal and Marcher Service | 2 | [[The Missing Seal]] |
| `pierre_transparency` | faction | Ducal and Marcher Service | 2 | [[The Missing Seal]] |
| `requisition_compensation` | faction | Ducal and Marcher Service | 2 | [[The Missing Seal]] |
| `highlake_carrier_terms` | faction | Ducal and Marcher Service | 3 | [[Outpost Arithmetic]] |
| `tuskway_outpost_state` | faction | Ducal and Marcher Service | 3 | [[Outpost Arithmetic]] |
| `vale_standing_marcher` | faction | Ducal and Marcher Service | 3 | [[Outpost Arithmetic]] |
| `emergency_exception_precedent` | faction | Ducal and Marcher Service | 4 | [[The Exception List]] |
| `outer_camp_population` | faction | Ducal and Marcher Service | 4 | [[The Exception List]] |
| `winter_entry_policy` | faction | Ducal and Marcher Service | 4 | [[The Exception List]] |
| `field_initiative_precedent` | faction | Ducal and Marcher Service | 5 | [[Holdfast Without Orders]] |
| `seed_grain_state` | faction | Ducal and Marcher Service | 5 | [[Holdfast Without Orders]] |
| `tann_holdfast_survivors` | faction | Ducal and Marcher Service | 5 | [[Holdfast Without Orders]] |
| `bridge_saboteur_state` | faction | Ducal and Marcher Service | 6 | [[Law Behind the Walls]] |
| `civil_review_access` | faction | Ducal and Marcher Service | 6 | [[Law Behind the Walls]] |
| `wartime_detention_rule` | faction | Ducal and Marcher Service | 6 | [[Law Behind the Walls]] |
| `ducal_internal_alignment` | faction | Ducal and Marcher Service | 7 | [[The Officers' Garden]] |
| `marcher_lock_state` | faction | Ducal and Marcher Service | 7 | [[The Officers' Garden]] |
| `officers_garden_exposed` | faction | Ducal and Marcher Service | 7 | [[The Officers' Garden]] |
| `marcher_charter_form` | faction | Ducal and Marcher Service | 8 | [[A Charter for the March]] |
| `outpost_command_state` | faction | Ducal and Marcher Service | 8 | [[A Charter for the March]] |
| `requisition_rule` | faction | Ducal and Marcher Service | 8 | [[A Charter for the March]] |
| `ducal_line_outcome` | faction | Ducal and Marcher Service | 9 | [[The Power Returned]] |
| `settlement_military_authority` | faction | Ducal and Marcher Service | 9 | [[The Power Returned]] |
| `summer_marcher_presence` | faction | Ducal and Marcher Service | 9 | [[The Power Returned]] |
| `compact_initial_trust` | faction | Four-Hearth Compact | 1 | [[Four Empty Seats]] |
| `folk_rank_admitted` | faction | Four-Hearth Compact | 1 | [[Four Empty Seats]] |
| `four_hearth_seats` | faction | Four-Hearth Compact | 1 | [[Four Empty Seats]] |
| `ducal_folk_road_trust` | faction | Four-Hearth Compact | 2 | [[Root-Witness]] |
| `grey_withy_access` | faction | Four-Hearth Compact | 2 | [[Root-Witness]] |
| `root_witness_boundary` | faction | Four-Hearth Compact | 2 | [[Root-Witness]] |
| `longlake_passage_rule` | faction | Four-Hearth Compact | 3 | [[The River's Two Banks]] |
| `netters_isle_service` | faction | Four-Hearth Compact | 3 | [[The River's Two Banks]] |
| `river_clan_trust` | faction | Four-Hearth Compact | 3 | [[The River's Two Banks]] |
| `bent_oak_sanctuary` | faction | Four-Hearth Compact | 4 | [[Bent Oak, Living]] |
| `chapel_folk_trust` | faction | Four-Hearth Compact | 4 | [[Bent Oak, Living]] |
| `fugitive_state` | faction | Four-Hearth Compact | 4 | [[Bent Oak, Living]] |
| `bellless_hold_state` | faction | Four-Hearth Compact | 5 | [[The Bellless Hold]] |
| `jorund_war_support` | faction | Four-Hearth Compact | 5 | [[The Bellless Hold]] |
| `occupation_roll_custody` | faction | Four-Hearth Compact | 5 | [[The Bellless Hold]] |
| `jorund_total_war_state` | faction | Four-Hearth Compact | 6 | [[Tusk Broken Twice]] |
| `protected_folk_households` | faction | Four-Hearth Compact | 6 | [[Tusk Broken Twice]] |
| `tuskway_access` | faction | Four-Hearth Compact | 6 | [[Tusk Broken Twice]] |
| `drowned_names_restored` | faction | Four-Hearth Compact | 7 | [[Names Under Water]] |
| `folk_internal_alignment` | faction | Four-Hearth Compact | 7 | [[Names Under Water]] |
| `wolfsmere_secret_scope` | faction | Four-Hearth Compact | 7 | [[Names Under Water]] |
| `compact_warning_network` | faction | Four-Hearth Compact | 8 | [[The Four-Hearth Winter]] |
| `folk_rights_term` | faction | Four-Hearth Compact | 8 | [[The Four-Hearth Winter]] |
| `four_hearth_compact_form` | faction | Four-Hearth Compact | 8 | [[The Four-Hearth Winter]] |
| `four_hearth_line_outcome` | faction | Four-Hearth Compact | 9 | [[When the Fires Go Out]] |
| `settlement_folk_rights` | faction | Four-Hearth Compact | 9 | [[When the Fires Go Out]] |
| `summer_folk_presence` | faction | Four-Hearth Compact | 9 | [[When the Fires Go Out]] |
| `night_house_route` | faction | Grenzburg Underworld | 1 | [[A Door After Dark]] |
| `protected_family_state` | faction | Grenzburg Underworld | 1 | [[A Door After Dark]] |
| `underworld_rank_admitted` | faction | Grenzburg Underworld | 1 | [[A Door After Dark]] |
| `lantern_relief_policy` | faction | Grenzburg Underworld | 2 | [[Bread Through Stone]] |
| `refugee_bread_state` | faction | Grenzburg Underworld | 2 | [[Bread Through Stone]] |
| `underways_route_access` | faction | Grenzburg Underworld | 2 | [[Bread Through Stone]] |
| `enzo_underworld_link` | faction | Grenzburg Underworld | 3 | [[The Rooftop Tax]] |
| `extortion_crew_state` | faction | Grenzburg Underworld | 3 | [[The Rooftop Tax]] |
| `rooftop_network_state` | faction | Grenzburg Underworld | 3 | [[The Rooftop Tax]] |
| `erased_cell_proof` | faction | Grenzburg Underworld | 4 | [[No One in the Cell]] |
| `oskar_vey_exposure` | faction | Grenzburg Underworld | 4 | [[No One in the Cell]] |
| `protected_witness_state` | faction | Grenzburg Underworld | 4 | [[No One in the Cell]] |
| `ivo_trust` | faction | Grenzburg Underworld | 5 | [[The Names They Buried]] |
| `protected_crimes_archive` | faction | Grenzburg Underworld | 5 | [[The Names They Buried]] |
| `victim_evidence_channel` | faction | Grenzburg Underworld | 5 | [[The Names They Buried]] |
| `enzo_corruption_public` | faction | Grenzburg Underworld | 6 | [[The Watchman Who Walked]] |
| `oskar_vey_verdict` | faction | Grenzburg Underworld | 6 | [[The Watchman Who Walked]] |
| `underworld_fork_open` | faction | Grenzburg Underworld | 6 | [[The Watchman Who Walked]] |
| `first_toll_verdict` | faction | Grenzburg Underworld | 7 | [[The First Toll]] |
| `night_guild_articles` | faction | Grenzburg Underworld | 7 | [[Articles Below]] |
| `private_execution_precedent` | faction | Grenzburg Underworld | 7 | [[The First Toll]] |
| `safehouse_protection` | faction | Grenzburg Underworld | 7 | [[Articles Below]] |
| `underworld_branch_black_bell` | faction | Grenzburg Underworld | 7 | [[The First Toll]] |
| `underworld_branch_low_lantern` | faction | Grenzburg Underworld | 7 | [[Articles Below]] |
| `black_bell_evidence_rule` | faction | Grenzburg Underworld | 8 | [[A Bell Behind the Walls]] |
| `false_accuser_state` | faction | Grenzburg Underworld | 8 | [[A Bell Behind the Walls]] |
| `lantern_relief_capacity` | faction | Grenzburg Underworld | 8 | [[The Store Beneath the Siege]] |
| `muster_betrayer_state` | faction | Grenzburg Underworld | 8 | [[A Bell Behind the Walls]] |
| `public_granary_restitution` | faction | Grenzburg Underworld | 8 | [[The Store Beneath the Siege]] |
| `underway_store_state` | faction | Grenzburg Underworld | 8 | [[The Store Beneath the Siege]] |
| `settlement_underworld_power` | faction | Grenzburg Underworld | 9 | [[The Hidden Tribunal]] or [[The Licensed Night]] |
| `summer_black_bell_presence` | faction | Grenzburg Underworld | 9 | [[The Hidden Tribunal]] |
| `summer_low_lantern_presence` | faction | Grenzburg Underworld | 9 | [[The Licensed Night]] |
| `underworld_line_outcome` | faction | Grenzburg Underworld | 9 | [[The Hidden Tribunal]] or [[The Licensed Night]] |

## Navigation

- [[Companions MOC]]
- [[Companion Campaign Architecture]]
- [[Companion Autonomy and Act Convergence]]
- [[Companion Campaign Expansion Register]]
- [[Faction Questlines MOC]]
- [[Companion Constitution]]
- [[Factions Overview]]
- [[Season and World-State Constitution]]
- [[World Simulation and Discovery Constitution]]
- [[Postgame Reconstruction Cycle]]
- [[Main Campaign State Matrix]]
- [[Main Campaign MOC]]
- [[Grenzburg MOC]]
