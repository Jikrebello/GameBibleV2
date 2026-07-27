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
archive_reason: "Pre-pass control snapshot"
archived_from: "02 Playable Settings/Grenzburg/10 Production Bible/Narrative State Register.md"
archived_on: 2026-07-27
superseded_by: "Active controlling note at the archived path"
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
| CMP-02 | [[Ilyana Veshkar]] | woman | [[Bard]] |
| CMP-03 | [[Ylva Winter-Track]] | woman | [[Hunter]] - Rescue Scout package |
| CMP-04 | [[Ashira bath Melan]] | woman | [[Medium]] |
| CMP-05 | [[Bernard Valeon]] | man | [[Paladin]] |
| CMP-06 | [[Dismas Raben]] | man | [[Hunter]] |
| CMP-07 | [[Tavio Meran]] | man | [[Lancewright]] |
| CMP-08 | [[Zafir ibn Samad]] | man | [[Binder]] |

Each ID owns eleven authored content slots through [[Companion Campaign Expansion Register]]: nine non-exclusive pieces, one romance episode, and one sworn-bond episode. At most ten pieces can appear for one companion in a playthrough. Each ID also owns eight to twelve embedded opportunities, three act-specific autonomous routes, and one main-campaign contribution per act.

## Player Temperament State

[[Player Temperament and Chemistry]] owns a rolling authored-signal ledger distinct from approval, virtue, reputation, background, and vocation.

| Field | Controlled values |
|---|---|
| player_temperament_ledger | latest twelve authored tendency signals with one- or two-signal weight |
| player_temperament_primary | one sex-linked tendency or empty |
| player_temperament_secondary | one different sex-linked tendency or empty |
| player_temperament_profile | grey, primary, or primary-secondary |
| player_temperament_locked | false until [[Ghor at the Gate]] completes, then true until a postgame reset |
| player_temperament_quiz_state | skipped, accepted, overridden, or open |
| second_nature_draught_available | false or true after [[The First Summer Road]] |

Accepted creation leaning supplies three opening signals. A primary requires four signals and a two-signal lead; a secondary requires three. Grey remains a complete authored profile. The Draught of Second Nature clears the ledger and future temperament reactions only. It does not alter virtue, approval, memories, relationships, completed scenes, or world outcomes.

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
| `player_temperament_ledger` | player temperament | Player Character | 0 | [[Player Temperament and Chemistry]] |
| `player_temperament_primary` | player temperament | Player Character | 0 | [[Player Temperament and Chemistry]] |
| `player_temperament_secondary` | player temperament | Player Character | 0 | [[Player Temperament and Chemistry]] |
| `player_temperament_profile` | player temperament | Player Character | 0 | [[Player Temperament and Chemistry]] |
| `player_temperament_quiz_state` | player temperament | Player Character | 0 | [[Character Creation and Identity]] |
| `player_temperament_locked` | player temperament | Player Character | 15 | [[Ghor at the Gate]] |
| `second_nature_draught_available` | postgame player temperament | Player Character | 23 | [[The First Summer Road]] |
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
| `bernard_recruited` | companion gate | Bernard Valeon | 0 | [[Bernard Valeon]] |
| `bernard_first_outing_complete` | companion gate | Bernard Valeon | 0 | [[Bernard Companion Campaign]] |
| `bernard_direction` | companion direction | Bernard Valeon | 0 | [[Bernard Companion Campaign]] |
| `bernard_act1_readiness_viable` | companion readiness | Bernard Valeon | 0 | [[Bernard Companion Campaign]] |
| `bernard_act2_readiness_viable` | companion readiness | Bernard Valeon | 0 | [[Bernard Companion Campaign]] |
| `bernard_act3_readiness_viable` | companion readiness | Bernard Valeon | 0 | [[Bernard Companion Campaign]] |
| `things_not_mine_count` | companion system | Bernard Valeon | 0 | [[Bernard Compulsion and Accountability System]] |
| `bernard_self_report_state` | companion system | Bernard Valeon | 0 | [[Bernard Compulsion and Accountability System]] |
| `bernard_incident_consequence` | companion system | Bernard Valeon | 0 | [[Bernard Compulsion and Accountability System]] |
| `bernard_hunger_named_early` | companion preparation | Bernard Valeon | 0 | [[Bernard Compulsion and Accountability System#The Spare Blanket|The Spare Blanket]] |
| `bernard_open_store_procedure_practiced` | companion preparation | Bernard Valeon | 0 | [[Bernard Compulsion and Accountability System#Open-Store Practice|Open-Store Practice]] |
| `bernard_named_store_custodians` | companion preparation | Bernard Valeon | 0 | [[Bernard Compulsion and Accountability System#Open-Store Practice|Open-Store Practice]] |
| `bernard_longlake_route_secured` | companion preparation | Bernard Valeon | 0 | [[Roads Worth Saving]] |
| `bernard_service_injury_claim_supported` | companion preparation | Bernard Valeon | 0 | [[A Debt That Grew Wounded]] |
| `bernard_pikehook_snare_line_mapped` | companion preparation | Bernard Valeon | 0 | [[Grenzburg Worldspace Location Register#Bernard Embedded Care Routes|Pikehook snare line]] |
| `bernard_breach_casualty_lane_secured` | companion preparation | Bernard Valeon | 0 | [[The City in Siege]] |
| `bernard_mercy_heat_plan` | companion preparation | Bernard Valeon | 0 | [[Mercy in Winter]] |
| `bernard_reclaimed_patient_routes` | companion preparation | Bernard Valeon | 0 | [[The Land Reclaimed]] |
| `bernard_mixed_carer_pledge` | companion preparation | Bernard Valeon | 0 | [[The Four-Hearth Winter]] |
| `bernard_underways_evacuation_route` | companion preparation | Bernard Valeon | 0 | [[Grenzburg Worldspace Location Register#Bernard Embedded Care Routes|West Refuge underways]] |
| `bernard_introduction_complete` | companion | Bernard Valeon | 1 | [[Little Things Missing]] |
| `bernard_compulsion_disclosed` | companion | Bernard Valeon | 1 | [[Little Things Missing]] |
| `bernard_accountability_plan` | companion | Bernard Valeon | 1 | [[Little Things Missing]] |
| `little_things_returned` | companion | Bernard Valeon | 1 | [[Little Things Missing]] |
| `kitchen_helper_state` | companion | Bernard Valeon | 1 | [[Little Things Missing]] |
| `koss_bernard_leverage` | companion | Bernard Valeon | 1 | [[Little Things Missing]] |
| `bernard_road_school_wagon_recovered` | companion preparation | Bernard Valeon | 2 | [[The Wagon in the Reeds]] |
| `road_school_wagon_state` | companion | Bernard Valeon | 2 | [[The Wagon in the Reeds]] |
| `refuge_bell_state` | companion | Bernard Valeon | 2 | [[The Wagon in the Reeds]] |
| `road_school_pack_state` | companion | Bernard Valeon | 2 | [[The Wagon in the Reeds]] |
| `wagon_driver_state` | companion | Bernard Valeon | 2 | [[The Wagon in the Reeds]] |
| `reed_road_bandits_state` | companion | Bernard Valeon | 2 | [[The Wagon in the Reeds]] |
| `bernard_act1_chapter_resolved` | companion chapter | Bernard Valeon | 3 | [[Little Hands, Long Road]] |
| `bernard_act1_result` | companion | Bernard Valeon | 3 | [[Little Hands, Long Road]] |
| `road_school_state` | companion | Bernard Valeon | 3 | [[Little Hands, Long Road]] |
| `chapel_children_state` | companion | Bernard Valeon | 3 | [[Little Hands, Long Road]] |
| `mika_food_state` | companion | Bernard Valeon | 3 | [[Little Hands, Long Road]] |
| `wounded_bear_state` | companion | Bernard Valeon | 3 | [[Little Hands, Long Road]] |
| `bent_oak_refuge_state` | companion | Bernard Valeon | 3 | [[Little Hands, Long Road]] |
| `bernard_friendship_episode` | friendship | Bernard Valeon | 4 | [[A Blade Freely Given]] |
| `bernard_owned_sword_state` | companion | Bernard Valeon | 4 | [[A Blade Freely Given]] |
| `bernard_child_portion_scene` | relationship | Bernard Valeon | 4 | [[A Blade Freely Given]] |
| `bernard_long_watch_kit_provenance` | companion preparation | Bernard Valeon | 4 | [[A Blade Freely Given]] |
| `bernard_four_fires_plan` | companion preparation | Bernard Valeon | 5 | [[Four Fires]] |
| `four_shelters_state` | companion | Bernard Valeon | 5 | [[Four Fires]] |
| `winter_fuel_state` | companion | Bernard Valeon | 5 | [[Four Fires]] |
| `warming_routes_state` | companion | Bernard Valeon | 5 | [[Four Fires]] |
| `four_fires_distribution_state` | companion | Bernard Valeon | 5 | [[Four Fires]] |
| `bernard_act2_chapter_resolved` | companion chapter | Bernard Valeon | 6 | [[Embers Without Excuse]] |
| `bernard_act2_result` | companion | Bernard Valeon | 6 | [[Embers Without Excuse]] |
| `bernard_act2_finale_played` | companion gate | Bernard Valeon | 6 | [[Embers Without Excuse]] |
| `bernard_paladin_unlocked` | progression | Bernard Valeon | 6 | [[Embers Without Excuse]] |
| `bernard_relationship_commitment` | relationship | Bernard Valeon | 6 | [[Embers Without Excuse]] |
| `bernard_relationship_paths_closed` | relationship | Bernard Valeon | 6 | [[Embers Without Excuse]] |
| `bernard_white_flame_kindling` | companion | Bernard Valeon | 6 | [[Embers Without Excuse]] |
| `petra_ilev_response` | companion | Bernard Valeon | 6 | [[Embers Without Excuse]] |
| `long_watch_return_open` | companion | Bernard Valeon | 6 | [[Embers Without Excuse]] |
| `lantern_relief_mission_state` | companion | Bernard Valeon | 6 | [[Embers Without Excuse]] |
| `bernard_romance_episode` | relationship | Bernard Valeon | 7 | [[Enough for Two]] |
| `bernard_romance_move_upgrade` | relationship | Bernard Valeon | 7 | [[Enough for Two]] |
| `bernard_table_received` | companion preparation | Bernard Valeon | 7 | [[Enough for Two]] |
| `private_feast_state` | relationship | Bernard Valeon | 7 | [[Enough for Two]] |
| `bernard_bond_episode` | relationship | Bernard Valeon | 7 | [[Watch Until Morning]] |
| `bernard_bond_move_upgrade` | relationship | Bernard Valeon | 7 | [[Watch Until Morning]] |
| `bernard_second_bearer_practiced` | companion preparation | Bernard Valeon | 7 | [[Watch Until Morning]] |
| `cairnside_shelter_state` | companion | Bernard Valeon | 7 | [[Watch Until Morning]] |
| `bernard_west_refuge_neutral_claim` | companion preparation | Bernard Valeon | 8 | [[Beds Before Banners]] |
| `west_refuge_hall_state` | companion | Bernard Valeon | 8 | [[Beds Before Banners]] |
| `west_refuge_sponsor_terms` | companion | Bernard Valeon | 8 | [[Beds Before Banners]] |
| `first_patient_groups_state` | companion | Bernard Valeon | 8 | [[Beds Before Banners]] |
| `west_refuge_rank_tablet_state` | companion | Bernard Valeon | 8 | [[Beds Before Banners]] |
| `bernard_act3_chapter_resolved` | companion chapter | Bernard Valeon | 9 | [[The Open Hospice]] |
| `bernard_act3_result` | companion | Bernard Valeon | 9 | [[The Open Hospice]] |
| `bernard_act3_finale_played` | companion gate | Bernard Valeon | 9 | [[The Open Hospice]] |
| `bernard_arc_outcome` | companion | Bernard Valeon | 9 | [[The Open Hospice]] |
| `bernard_sacrifice_state` | companion fate | Bernard Valeon | 9 | [[The Open Hospice]] |
| `bernard_future_path` | companion | Bernard Valeon | 9 | [[The Open Hospice]] |
| `open_lamp_hospice_state` | companion | Bernard Valeon | 9 | [[The Open Hospice]] |
| `paladin_capstone_unlocked` | progression | Bernard Valeon | 9 | [[The Open Hospice]] |
| `long_watch_field_form_blueprint` | progression | Bernard Valeon | 9 | [[The Open Hospice]] |
| `bernard_relationship_perk` | relationship | Bernard Valeon | 9 | [[The Open Hospice]] |
| `bernard_duo_move_upgrade` | relationship | Bernard Valeon | 9 | [[The Open Hospice]] |
| `bernard_owned_greatsword_name` | companion | Bernard Valeon | 9 | [[The Open Hospice]] |
| `bernard_summer_destination` | companion | Bernard Valeon | 9 | [[The Open Hospice]] |
| `bernard_summer_coda` | companion | Bernard Valeon | 10 | [[The First Open Table]] |
| `first_open_table_state` | companion | Bernard Valeon | 10 | [[The First Open Table]] |
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
| `elara_romance_episode` | relationship | Elara Velescar | 4 | [[Raven Shelf at Dawn]] |
| `elara_romance_move_upgrade` | relationship | Elara Velescar | 4 | [[Raven Shelf at Dawn]] |
| `elara_raven_line_practiced` | companion bonus | Elara Velescar | 4 | [[Raven Shelf at Dawn]] |
| `raven_signal_runner_state` | companion | Elara Velescar | 4 | [[Raven Shelf at Dawn]] |
| `elara_bond_episode` | relationship | Elara Velescar | 4 | [[Two Names on the Rope]] |
| `elara_bond_move_upgrade` | relationship | Elara Velescar | 4 | [[Two Names on the Rope]] |
| `elara_two_names_line_practiced` | companion bonus | Elara Velescar | 4 | [[Two Names on the Rope]] |
| `windcut_return_route_state` | companion | Elara Velescar | 4 | [[Two Names on the Rope]] |
| `elara_wager_scene` | relationship | Elara Velescar | 1 | [[Elara Field Familiarity and Relationships]] |
| `elara_friendship_episode` | relationship | Elara Velescar | 2 | [[A Better Wager]] |
| `elara_rooftop_wager_result` | relationship | Elara Velescar | 2 | [[A Better Wager]] |
| `elara_without_powder_scene` | relationship | Elara Velescar | 2 | [[A Better Wager]] |
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
| `elara_duo_move_upgrade` | relationship | Elara Velescar | 4 | [[No Lady of Velescar]] |
| `delver_duelist_blueprint` | progression | Elara Velescar | 4 | [[No Lady of Velescar]] |
| `elara_summer_coda` | companion | Elara Velescar | 5 | [[The First Honest Find]] |
| `ropehouse_find_state` | companion | Elara Velescar | 5 | [[The First Honest Find]] |
| `ropehouse_custody_state` | companion | Elara Velescar | 5 | [[The First Honest Find]] |
| `elara_provenance_board` | companion | Elara Velescar | 5 | [[The First Honest Find]] |
| `elara_scarred_mounds_state` | companion re-entry | Elara Velescar | 3 | [[Elara Companion Campaign]] |
| `elara_cabinet_after_snow_state` | companion re-entry | Elara Velescar | 4 | [[Elara Companion Campaign]] |
| `ilyana_direction` | companion direction | Ilyana Veshkar | 1-4 | [[Ilyana Companion Campaign]] |
| `ilyana_introduction_complete` | companion | Ilyana Veshkar | 1 | [[Five Cases at Customs]] |
| `ilyana_cases_secured` | companion preparation | Ilyana Veshkar | 1-2 | [[Five Cases at Customs]] |
| `ilyana_forgery_admitted` | companion | Ilyana Veshkar | 1 | [[Five Cases at Customs]] |
| `salt_reed_property_state` | companion | Ilyana Veshkar | 1 | [[Five Cases at Customs]] |
| `customs_case_thief_state` | character | Pell One-Thumb | 1 | [[Five Cases at Customs]] |
| `morante_claim_known` | companion | Ilyana Veshkar | 1 | [[Five Cases at Customs]] |
| `ilyana_celia_safe` | companion preparation | Ilyana Veshkar | 2 | [[The Road Without a Conductor]] |
| `celia_orsani_state` | character | Celia Orsani | 2-5 | [[The Road Without a Conductor]] |
| `celia_viol_state` | companion property | Celia Orsani | 2-4 | [[The Road Without a Conductor]] |
| `reed_cart_state` | local | Grenz Lowlands | 2 | [[The Road Without a Conductor]] |
| `lowlands_bandit_state` | regional | Grenz Lowlands | 2 | [[The Road Without a Conductor]] |
| `ilyana_eel_bridge_route_known` | companion preparation | Ilyana Veshkar | 2 | [[Ilyana Companion Campaign]] |
| `ilyana_individual_ownership_recorded` | companion preparation | Ilyana Veshkar | 2 | [[Ilyana Companion Campaign]] |
| `ilyana_voluntary_signal_support` | companion preparation | Ilyana Veshkar | 2 | [[Ilyana Companion Campaign]] |
| `ilyana_voluntary_signal_drill` | companion embedded | Ilyana Veshkar | 2 | [[Terms of Service]] |
| `ilyana_act1_readiness` | companion readiness | Ilyana Veshkar | 2 | [[Ilyana Companion Campaign]] |
| `ilyana_act1_chapter_resolved` | companion | Ilyana Veshkar | 2 | [[No Song by Command]] |
| `ilyana_act1_result` | companion | Ilyana Veshkar | 2 | [[No Song by Command]] |
| `ilyana_act1_finale_played` | companion | Ilyana Veshkar | 2 | [[No Song by Command]] |
| `nereo_valdo_state` | character | Nereo Valdo | 2-5 | [[No Song by Command]] |
| `nereo_drum_state` | companion property | Nereo Valdo | 2-4 | [[No Song by Command]] |
| `eel_bridge_households_state` | regional | Longlake Country | 2 | [[No Song by Command]] |
| `reedknife_band_state` | regional | Longlake Country | 2 | [[No Song by Command]] |
| `ilyana_echoes_at_eel_bridge_state` | companion re-entry | Ilyana Veshkar | 3 | [[Ilyana Companion Campaign]] |
| `ilyana_friendship_episode` | relationship | Ilyana Veshkar | 2 | [[A Tune with No Owner]] |
| `ilyana_common_tune_state` | relationship | Ilyana Veshkar | 2 | [[A Tune with No Owner]] |
| `ilyana_bridgehold_refrain_known` | companion preparation | Ilyana Veshkar | 2-3 | [[A Tune with No Owner]] |
| `ilyana_relationship_interest` | relationship | Ilyana Veshkar | 2 | [[A Tune with No Owner]] |
| `ilyana_instruments_returned` | companion preparation | Ilyana Veshkar | 3 | [[Reeds Under Ice]] |
| `mirella_corsi_state` | character | Mirella Corsi | 3-5 | [[Reeds Under Ice]] |
| `tomas_marin_state` | character | Tomas Marin | 3-5 | [[Reeds Under Ice]] |
| `salt_reed_roster_in_grenzburg` | companion | Ilyana Veshkar | 3 | [[Reeds Under Ice]] |
| `winter_instrument_state` | companion property | The Salt-Reed Company | 3 | [[Reeds Under Ice]] |
| `quay_lifeboat_state` | city | Ledger Quays | 3 | [[Reeds Under Ice]] |
| `morante_factor_state` | character | Ilyana Veshkar | 3 | [[Reeds Under Ice]] |
| `ilyana_breach_casualty_lane_mapped` | companion preparation | Ilyana Veshkar | 3 | [[The City in Siege]] |
| `ilyana_counter_tuning_prepared` | companion preparation | Ilyana Veshkar | 3 | [[Ilyana Companion Campaign]] |
| `ilyana_performer_pledges_recorded` | companion preparation | Ilyana Veshkar | 3 | [[Ilyana Companion Campaign]] |
| `ilyana_refuge_acoustics_known` | companion preparation | Ilyana Veshkar | 3 | [[Ilyana Companion Campaign]] |
| `ilyana_hospital_breathing_plan` | companion embedded | Ilyana Veshkar | 3 | [[Mercy in Winter]] |
| `ilyana_act2_readiness` | companion readiness | Ilyana Veshkar | 3 | [[Ilyana Companion Campaign]] |
| `ilyana_act2_chapter_resolved` | companion | Ilyana Veshkar | 3 | [[The Free Refrain]] |
| `ilyana_act2_result` | companion | Ilyana Veshkar | 3 | [[The Free Refrain]] |
| `ilyana_act2_finale_played` | companion | Ilyana Veshkar | 3 | [[The Free Refrain]] |
| `ilyana_bard_unlocked` | progression | Ilyana Veshkar | 3 | [[The Free Refrain]] |
| `bard_account_unlock` | progression | Bard | 3 | [[The Free Refrain]] |
| `ilyana_relationship_commitment` | relationship | Ilyana Veshkar | 3 | [[The Free Refrain]] |
| `ilyana_relationship_paths_closed` | relationship | Ilyana Veshkar | 3 | [[The Free Refrain]] |
| `salt_reed_winter_consent` | companion | The Salt-Reed Company | 3 | [[The Free Refrain]] |
| `winter_casualty_refrain_state` | city | Grenzburg | 3 | [[The Free Refrain]] |
| `morante_state` | character | Caterina Morante | 3-4 | [[The Free Refrain]] |
| `ilyana_refrain_after_snow_state` | companion re-entry | Ilyana Veshkar | 4 | [[Ilyana Companion Campaign]] |
| `ilyana_romance_episode` | relationship | Ilyana Veshkar | 3 | [[One Private Song]] |
| `ilyana_romance_move_upgrade` | relationship | Ilyana Veshkar | 3 | [[One Private Song]] |
| `ilyana_private_cadence_practiced` | companion bonus | Ilyana Veshkar | 4 | [[One Private Song]] |
| `private_song_state` | relationship | Ilyana Veshkar | 3 | [[One Private Song]] |
| `ilyana_bond_episode` | relationship | Ilyana Veshkar | 3 | [[Duet Without a Conductor]] |
| `ilyana_bond_move_upgrade` | relationship | Ilyana Veshkar | 3 | [[Duet Without a Conductor]] |
| `ilyana_equal_cadence_practiced` | companion bonus | Ilyana Veshkar | 4 | [[Duet Without a Conductor]] |
| `bridgehold_duet_state` | relationship | Ilyana Veshkar | 3 | [[Duet Without a Conductor]] |
| `ilyana_releases_protected` | companion preparation | Ilyana Veshkar | 4 | [[Every Case Its Owner]] |
| `salt_reed_authorship_state` | companion | The Salt-Reed Company | 4 | [[Every Case Its Owner]] |
| `salt_reed_instrument_state` | companion property | The Salt-Reed Company | 4 | [[Every Case Its Owner]] |
| `mirella_release_state` | character | Mirella Corsi | 4 | [[Every Case Its Owner]] |
| `nereo_release_state` | character | Nereo Valdo | 4 | [[Every Case Its Owner]] |
| `celia_release_state` | character | Celia Orsani | 4 | [[Every Case Its Owner]] |
| `tomas_release_state` | character | Tomas Marin | 4 | [[Every Case Its Owner]] |
| `morante_claim_state` | character | Caterina Morante | 4 | [[Every Case Its Owner]] |
| `ilyana_muster_cadence_sampled` | companion preparation | Ilyana Veshkar | 4 | [[The Land Reclaimed]] |
| `ilyana_boom_tower_route_known` | companion preparation | Ilyana Veshkar | 4 | [[Ilyana Companion Campaign]] |
| `ilyana_common_score_partitioned` | companion preparation | Ilyana Veshkar | 4 | [[Ilyana Companion Campaign]] |
| `ilyana_ensemble_destinations_secured` | companion preparation | Ilyana Veshkar | 4 | [[Ilyana Companion Campaign]] |
| `ilyana_act3_readiness` | companion readiness | Ilyana Veshkar | 4 | [[Ilyana Companion Campaign]] |
| `ilyana_act3_chapter_resolved` | companion | Ilyana Veshkar | 4 | [[The Last Common Measure]] |
| `ilyana_act3_result` | companion | Ilyana Veshkar | 4 | [[The Last Common Measure]] |
| `ilyana_act3_finale_played` | companion | Ilyana Veshkar | 4 | [[The Last Common Measure]] |
| `ilyana_arc_outcome` | companion | Ilyana Veshkar | 4 | [[The Last Common Measure]] |
| `ilyana_summer_destination` | companion | Ilyana Veshkar | 4-5 | [[The Last Common Measure]] |
| `salt_reed_settlement` | companion | The Salt-Reed Company | 4 | [[The Last Common Measure]] |
| `river_boom_cadence_state` | regional | Grenzburg | 4 | [[The Last Common Measure]] |
| `ilyana_relationship_perk` | relationship | Ilyana Veshkar | 4 | [[The Last Common Measure]] |
| `ilyana_duo_move` | relationship | Ilyana Veshkar | 3-4 | [[Ilyana Field Familiarity and Relationships]] |
| `ilyana_duo_move_upgrade` | relationship | Ilyana Veshkar | 3-4 | [[Ilyana Field Familiarity and Relationships]] |
| `sermoran_field_bard_blueprint` | progression | Ilyana Veshkar | 4 | [[The Last Common Measure]] |
| `ilyana_summer_coda_complete` | companion | Ilyana Veshkar | 5 | [[The Road Takes the Song]] |
| `salt_reed_summer_state` | companion | The Salt-Reed Company | 5 | [[The Road Takes the Song]] |
| `first_road_song_state` | companion | Ilyana Veshkar | 5 | [[The Road Takes the Song]] |
| `ylva_recruited` | companion gate | Ylva Winter-Track | 1 | [[The Fourth Marker]] |
| `ylva_campaign_tracked` | companion | Ylva Winter-Track | 1 | [[The Fourth Marker]] |
| `ylva_direction` | companion direction | Ylva Winter-Track | 1-9 | [[Ylva Companion Campaign]] |
| `ylva_approval` | companion approval | Ylva Winter-Track | 1-10 | [[Ylva Field Familiarity and Relationships]] |
| `ylva_act1_readiness` | companion readiness | Ylva Winter-Track | 2-3 | [[Ylva Companion Campaign]] |
| `ylva_act2_readiness` | companion readiness | Ylva Winter-Track | 5-6 | [[Ylva Companion Campaign]] |
| `ylva_act3_readiness` | companion readiness | Ylva Winter-Track | 8-9 | [[Ylva Companion Campaign]] |
| `ylva_black_fir_route_survey` | companion preparation | Ylva Winter-Track | 0-3 | [[Ylva Companion Campaign]] |
| `ylva_three_log_bridge_repair` | companion preparation | Ylva Winter-Track | 0-3 | [[Ylva Companion Campaign]] |
| `ylva_upper_grenz_relief_roster` | companion preparation | Ylva Winter-Track | 0-3 | [[Ylva Companion Campaign]] |
| `ylva_western_breach_route_known` | companion preparation | Ylva Winter-Track | 0-6 | [[The City in Siege]] |
| `ylva_longlake_ice_soundings` | companion preparation | Ylva Winter-Track | 0-6 | [[Ylva Companion Campaign]] |
| `ylva_winter_field_arrow_stock` | companion preparation | Ylva Winter-Track | 0-6 | [[Ylva Rescue Hunter Package]] |
| `ylva_receiving_shelters_staffed` | companion preparation | Ylva Winter-Track | 0-6 | [[Ylva Companion Campaign]] |
| `ylva_collective_loss_precedent` | companion embedded | Ylva Winter-Track | 0-8 | [[The Blackjacks Koss Lost]] |
| `ylva_tannbruck_scout_post_restored` | companion preparation | Ylva Winter-Track | 0-9 | [[Routes for the Living]] |
| `ylva_fenn_lantern_fuel` | companion preparation | Ylva Winter-Track | 0-9 | [[Routes for the Living]] |
| `ylva_last_hearth_relief_roster` | companion preparation | Ylva Winter-Track | 0-9 | [[Routes for the Living]] |
| `ylva_white_mud_extraction_line` | companion preparation | Ylva Winter-Track | 0-9 | [[Routes for the Living]] |
| `ylva_fourth_marker_restored` | companion preparation | Ylva Winter-Track | 1-3 | [[The Fourth Marker]] |
| `ylva_injury_disclosed` | companion | Ylva Winter-Track | 1 | [[The Fourth Marker]] |
| `southbound_watch_roster_state` | regional | Upper Grenz | 1 | [[The Fourth Marker]] |
| `diverted_carters_state` | regional | Upper Grenz | 1 | [[The Fourth Marker]] |
| `ylva_shared_signal_code` | companion preparation | Ylva Winter-Track | 2-3 | [[A Signal Shared]] |
| `fellwater_signal_state` | regional | Upper Grenz | 2 | [[A Signal Shared]] |
| `black_fir_watch_state` | regional | Upper Grenz | 2 | [[A Signal Shared]] |
| `tann_crossing_relay_state` | regional | Upper Grenz | 2 | [[A Signal Shared]] |
| `road_spoofers_state` | regional | Upper Grenz | 2 | [[A Signal Shared]] |
| `all_weather_flare_arrow_unlocked` | progression | Hunter | 2 | [[A Signal Shared]] |
| `reinforced_blunt_head_unlocked` | progression | Hunter | 2 | [[A Signal Shared]] |
| `ylva_act1_finale_played` | companion chapter | Ylva Winter-Track | 3 | [[The Rearguard Road]] |
| `three_log_households_state` | regional | Upper Grenz | 3 | [[The Rearguard Road]] |
| `river_teeth_workers_state` | regional | Upper Grenz | 3 | [[The Rearguard Road]] |
| `rearguard_cargo_state` | regional | Upper Grenz | 3 | [[The Rearguard Road]] |
| `ylva_distress_call_state` | companion | Ylva Winter-Track | 3 | [[The Rearguard Road]] |
| `line_arrow_unlocked` | progression | Hunter | 3 | [[The Rearguard Road]] |
| `ylva_friendship_episode` | friendship | Ylva Winter-Track | 4 | [[No Quarry Today]] |
| `ylva_first_snow_course_state` | companion | Ylva Winter-Track | 4 | [[No Quarry Today]] |
| `ylva_shared_meal_state` | friendship | Ylva Winter-Track | 4 | [[No Quarry Today]] |
| `ylva_lantern_ward_signal_chain` | companion preparation | Ylva Winter-Track | 5-6 | [[Signals Over Lantern Ward]] |
| `lantern_rooftop_stations_state` | city | Lantern Ward | 5 | [[Signals Over Lantern Ward]] |
| `debtors_row_warning_state` | city | Lantern Ward | 5 | [[Signals Over Lantern Ward]] |
| `west_alley_receivers_state` | city | Lantern Ward | 5 | [[Signals Over Lantern Ward]] |
| `smoke_arrow_unlocked` | progression | Hunter | 5 | [[Signals Over Lantern Ward]] |
| `ylva_act2_finale_played` | companion chapter | Ylva Winter-Track | 6 | [[What the Ice Takes]] |
| `longlake_evacuees_state` | regional | Longlake Country | 6 | [[What the Ice Takes]] |
| `ice_food_state` | regional | Longlake Country | 6 | [[What the Ice Takes]] |
| `shared_liability_filing` | companion | Ylva Winter-Track | 6 | [[What the Ice Takes]] |
| `ylva_relationship_commitment_available` | relationship | Ylva Winter-Track | 6 | [[What the Ice Takes]] |
| `ylva_relationship_commitment` | relationship | Ylva Winter-Track | 6 | [[Ylva Field Familiarity and Relationships]] |
| `ylva_relationship_paths_closed` | relationship | Ylva Winter-Track | 6 | [[Ylva Companion Campaign]] |
| `ylva_rescue_scout_doctrine` | progression | Ylva Winter-Track | 6 | [[What the Ice Takes]] |
| `ylva_relay_after_frost_state` | companion re-entry | Ylva Winter-Track | 5 | [[Ylva Companion Campaign]] |
| `ylva_ice_after_thaw_state` | companion re-entry | Ylva Winter-Track | 8 | [[Ylva Companion Campaign]] |
| `ylva_romance_episode` | relationship | Ylva Winter-Track | 7 | [[A Hearth Chosen]] |
| `ylva_romance_move_unlocked` | relationship | Ylva Winter-Track | 7 | [[A Hearth Chosen]] |
| `ylva_homeward_route_practiced` | companion bonus | Ylva Winter-Track | 7-9 | [[A Hearth Chosen]] |
| `chosen_hearth_state` | relationship | Ylva Winter-Track | 7 | [[A Hearth Chosen]] |
| `ylva_bond_episode` | relationship | Ylva Winter-Track | 7 | [[The Sister Watch]] |
| `ylva_bond_move_unlocked` | relationship | Ylva Winter-Track | 7 | [[The Sister Watch]] |
| `ylva_sister_watch_practiced` | companion bonus | Ylva Winter-Track | 7-9 | [[The Sister Watch]] |
| `east_watch_cairn_state` | relationship | Ylva Winter-Track | 7 | [[The Sister Watch]] |
| `ylva_living_route_atlas` | companion preparation | Ylva Winter-Track | 8-9 | [[Routes for the Living]] |
| `upper_grenz_route_team_state` | regional | Upper Grenz | 8 | [[Routes for the Living]] |
| `tuskway_route_team_state` | regional | Highlake Uplands | 8 | [[Routes for the Living]] |
| `frostfenn_route_team_state` | regional | Frostfenn March | 8 | [[Routes for the Living]] |
| `duplicated_stores_state` | regional | Grenzburg | 8 | [[Routes for the Living]] |
| `controlled_blast_arrow_unlocked` | progression | Hunter | 8 | [[Routes for the Living]] |
| `ylva_act3_finale_played` | companion chapter | Ylva Winter-Track | 9 | [[The Last Marker]] |
| `ylva_final_outcome` | companion | Ylva Winter-Track | 9 | [[The Last Marker]] |
| `ylva_fate` | companion | Ylva Winter-Track | 9 | [[The Last Marker]] |
| `fenn_lantern_state` | regional | Frostfenn March | 9 | [[The Last Marker]] |
| `white_mud_causeway_state` | regional | Frostfenn March | 9 | [[The Last Marker]] |
| `last_hearth_evacuated` | regional | Frostfenn March | 9 | [[The Last Marker]] |
| `last_marker_relief_state` | companion | Ylva Winter-Track | 9 | [[The Last Marker]] |
| `ylva_relationship_perk` | relationship | Ylva Winter-Track | 9 | [[The Last Marker]] |
| `winter_track_fieldcraft_unlocked` | progression | Hunter | 9 | [[The Last Marker]] |
| `ylva_summer_coda` | companion | Ylva Winter-Track | 10 | [[The Road She Chooses]] |
| `ylva_destination` | companion | Ylva Winter-Track | 10 | [[The Road She Chooses]] |
| `ylva_postwar_route_state` | regional | Grenzburg | 10 | [[The Road She Chooses]] |
| `ylva_memorial_state` | companion | Ylva Winter-Track | 10 | [[The Road She Chooses]] |
| `tavio_recruited` | companion gate | Tavio Meran | 0 | [[Tavio Meran]] |
| `tavio_first_outing_complete` | companion gate | Tavio Meran | 0 | [[Tavio Companion Campaign]] |
| `tavio_direction` | companion direction | Tavio Meran | 0 | [[Tavio Companion Campaign]] |
| `tavio_act1_readiness_viable` | companion readiness | Tavio Meran | 0 | [[Tavio Companion Campaign]] |
| `tavio_act2_readiness_viable` | companion readiness | Tavio Meran | 0 | [[Tavio Companion Campaign]] |
| `tavio_act3_readiness_viable` | companion readiness | Tavio Meran | 0 | [[Tavio Companion Campaign]] |
| `tavio_cold_iron_control_sample` | companion preparation | Tavio Meran | 0 | [[Tavio Companion Campaign]] |
| `tavio_warlock_counterproof` | companion preparation | Tavio Meran | 0 | [[Tavio Companion Campaign]] |
| `tavio_workers_stop_authority` | companion preparation | Tavio Meran | 0-2 | [[The Equipment Account]] or [[Holdfast Without Orders]] |
| `tavio_bout_rules_filed` | companion preparation | Tavio Meran | 0 | [[Tavio Companion Campaign]] |
| `tavio_neutral_officials_secured` | companion preparation | Tavio Meran | 0 | [[Tavio Companion Campaign]] |
| `tavio_red_brass_witness` | companion preparation | Tavio Meran | 0 | [[Tavio Companion Campaign]] |
| `tavio_bookmaker_ledger` | companion preparation | Tavio Meran | 0 | [[Tavio Companion Campaign]] |
| `tavio_leak_horn_drill` | companion preparation | Tavio Meran | 0 | [[Tavio Companion Campaign]] |
| `tavio_mobile_vent_frame` | companion preparation | Tavio Meran | 0 | [[Tavio Companion Campaign]] |
| `tavio_muster_cadence_reading` | companion preparation | Tavio Meran | 8 | [[The Land Reclaimed]] |
| `tavio_worker_consent_roster` | companion preparation | Tavio Meran | 0 | [[Tavio Companion Campaign]] |
| `tavio_campaign_tracked` | companion | Tavio Meran | 1 | [[The False Ring]] |
| `tavio_fifth_ring_evidence` | companion preparation | Tavio Meran | 1 | [[The False Ring]] |
| `tavio_cheating_admitted` | companion | Tavio Meran | 1 | [[The False Ring]] |
| `tavio_insert_state` | companion | Tavio Meran | 1 | [[The False Ring]] |
| `koss_fifth_ring_interest` | companion | Tavio Meran | 1 | [[The False Ring]] |
| `hella_dorn_trust` | companion | Tavio Meran | 1 | [[The False Ring]] |
| `tavio_signed_batch_register` | companion preparation | Tavio Meran | 2 | [[The Signed Measure]] |
| `unsafe_lancewright_fittings_state` | companion | Tavio Meran | 2 | [[The Signed Measure]] |
| `injured_apprentice_state` | companion | Tavio Meran | 2 | [[The Signed Measure]] |
| `seraf_pellan_state` | character | Seraf Pellan | 2-6 | [[The Signed Measure]] |
| `tavio_act1_chapter_resolved` | companion chapter | Tavio Meran | 3 | [[Proof Under Load]] |
| `tavio_act1_result` | companion | Tavio Meran | 3 | [[Proof Under Load]] |
| `tavio_act1_finale_played` | companion | Tavio Meran | 3 | [[Proof Under Load]] |
| `cold_iron_supply` | regional | Highlake | 3 | [[Proof Under Load]] |
| `red_brass_substitution_proven` | faction | Red Brass Bench | 3 | [[Proof Under Load]] |
| `mine_workers_state` | companion | Tavio Meran | 3 | [[Proof Under Load]] |
| `act1_field_antagonist_state` | character | Red Brass Bench | 3 | [[Proof Under Load]] |
| `tavio_friendship_episode` | friendship | Tavio Meran | 4 | [[Games Without a Crown]] |
| `yard_fair_state` | companion | Tavio Meran | 4 | [[Games Without a Crown]] |
| `tavio_prize_state` | companion | Tavio Meran | 4 | [[Games Without a Crown]] |
| `tavio_approval` | companion approval | Tavio Meran | 0-5 | [[Tavio Field Familiarity and Relationships]] |
| `tavio_lio_brace_intact` | companion preparation | Tavio Meran | 5 | [[The Challenger's Road]] |
| `lio_varcen_arrival_state` | character | Lio Varcen | 5 | [[The Challenger's Road]] |
| `crucible_evidence_state` | faction | The Crucible | 5 | [[The Challenger's Road]] |
| `red_brass_road_attack_state` | faction | Red Brass Bench | 5 | [[The Challenger's Road]] |
| `tavio_act2_chapter_resolved` | companion chapter | Tavio Meran | 6 | [[The Fair Defeat]] |
| `tavio_act2_result` | companion | Tavio Meran | 6 | [[The Fair Defeat]] |
| `tavio_act2_finale_played` | companion | Tavio Meran | 6 | [[The Fair Defeat]] |
| `tavio_fair_bout_result` | companion | Tavio Meran | 6 | [[The Fair Defeat]] |
| `lio_varcen_state` | character | Lio Varcen | 6 | [[The Fair Defeat]] |
| `red_brass_exposure` | faction | Red Brass Bench | 6 | [[The Fair Defeat]] |
| `tavio_lancewright_unlocked` | progression | Tavio Meran | 6 | [[The Fair Defeat]] |
| `tavio_relationship_commitment` | relationship | Tavio Meran | 6 | [[The Fair Defeat]] |
| `tavio_relationship_paths_closed` | relationship | Tavio Meran | 6 | [[The Fair Defeat]] |
| `maro_vezan_state` | character | Maro Vezan | 6 | [[The Fair Defeat]] |
| `tavio_romance_episode` | relationship | Tavio Meran | 7 | [[No Wager Between Us]] |
| `tavio_romance_move_upgrade` | relationship | Tavio Meran | 7 | [[No Wager Between Us]] |
| `tavio_courtship_measure_practiced` | companion preparation | Tavio Meran | 7 | [[No Wager Between Us]] |
| `festival_courtship_state` | relationship | Tavio Meran | 7 | [[No Wager Between Us]] |
| `tavio_bond_episode` | relationship | Tavio Meran | 7 | [[After the Last Lantern]] |
| `tavio_bond_move_upgrade` | relationship | Tavio Meran | 7 | [[After the Last Lantern]] |
| `tavio_seconds_halt_practiced` | companion preparation | Tavio Meran | 7 | [[After the Last Lantern]] |
| `last_lantern_state` | relationship | Tavio Meran | 7 | [[After the Last Lantern]] |
| `tavio_field_inspection_ledger` | companion preparation | Tavio Meran | 8 | [[Measure on the March]] |
| `march_equipment_state` | regional | Grenzburg | 8 | [[Measure on the March]] |
| `old_river_arsenal_safety` | regional | Upper Grenz | 8 | [[Measure on the March]] |
| `named_worker_stop_state` | companion | Tavio Meran | 8 | [[Measure on the March]] |
| `tavio_act3_chapter_resolved` | companion chapter | Tavio Meran | 9 | [[Horn for Leak-Day]] |
| `tavio_act3_result` | companion | Tavio Meran | 9 | [[Horn for Leak-Day]] |
| `tavio_act3_finale_played` | companion | Tavio Meran | 9 | [[Horn for Leak-Day]] |
| `tavio_arc_outcome` | companion | Tavio Meran | 9 | [[Horn for Leak-Day]] |
| `great_forge_state` | regional | Hammer Ward | 9 | [[Horn for Leak-Day]] |
| `forge_workers_state` | regional | Hammer Ward | 9 | [[Horn for Leak-Day]] |
| `leak_horn_state` | companion | Tavio Meran | 9 | [[Horn for Leak-Day]] |
| `tavio_summer_destination` | companion | Tavio Meran | 9-10 | [[Horn for Leak-Day]] |
| `tavio_relationship_perk` | relationship | Tavio Meran | 9 | [[Horn for Leak-Day]] |
| `tavio_summer_coda_complete` | companion | Tavio Meran | 10 | [[The Road Takes the Measure]] |
| `road_examiner_state` | companion | Tavio Meran | 10 | [[The Road Takes the Measure]] |
| `summer_proof_route_state` | regional | Upper Grenz | 10 | [[The Road Takes the Measure]] |
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
- [[Player Temperament and Chemistry]]
- [[Main Campaign MOC]]
- [[Grenzburg MOC]]
