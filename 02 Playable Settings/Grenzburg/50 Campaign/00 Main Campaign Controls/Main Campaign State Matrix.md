---
type: reference
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg"]
culture: []
related_factions: ["Duchy of Grenzburg", "Blackjack Corps", "Church of the Redeemer", "Folk kindreds", "Grobi"]
appears_in: ["Grenzburg"]
needs: []
aliases: ["Grenzburg Main-State Register"]
tags: [game-ready]
---
# Main Campaign State Matrix

These are authored narrative states, not one universal score. A quest may test several states while still supplying a baseline route for players who ignored parallel content.

## Chapter Outputs

| Chapter | Required outputs | Principal consumers |
|---|---|---|
| MQ-01 | `black_road_survivors`, `black_road_cargo`, `toll_band_state`, `grobi_scout_warning` | MQ-02, MQ-03, MQ-09 |
| MQ-02 | `ducal_warrant`, `city_access`, `funnel_camp_state`, `blackjack_party_formed` | all later chapters and city content |
| MQ-03 | `three_mills_road`, `broken_tollworks_state`, `road_prisoners_state` | MQ-06, MQ-07, summer |
| MQ-04 | `southbound_convoy`, `ylva_recruited`, `ylva_campaign_tracked`, `ylva_fourth_marker_restored`, `folk_road_claim`, `tannbruck_access` | MQ-05 through MQ-08; Folk line; Ylva campaign |
| MQ-05 | `watch_hill_signals`, `tann_bridge_winch`, `smuggler_route_state`, `ghor_route_intelligence` | MQ-07, MQ-08, MQ-15 |
| MQ-06 | `autumn_operations_completed`, `autumn_road_support`, `southwood_early_warning` | MQ-07 through MQ-12 |
| MQ-07 | `last_convoy_people`, `last_convoy_material`, `last_convoy_route` | MQ-08 through MQ-10 |
| MQ-08 | `tannbruck_survivors`, `tannbruck_material`, `tannbruck_denial`, `tannbruck_fallen` | MQ-09, MQ-15, MQ-17, MQ-20 |
| MQ-09 | `winter_intake_state`, `city_siege_readiness`, `winter_strands_open` | MQ-10 through MQ-15 |
| MQ-10 | `lantern_ward_damage`, `western_breach_state`, `blackjack_yard_state`, `millwheel_pumps_state` | MQ-13, MQ-15, summer |
| MQ-11 | `drake_hunt_preparations`, `drake_displacement_truth`, `heart_oak_route` | MQ-12 |
| MQ-12 | `emerald_drake_dead`, `emerald_law_gem_custody`, `southwood_winter_state` | MQ-16 through MQ-21; summer |
| MQ-13 | `winter_knives_state`, `granary_culvert_state`, `counterattack_route` | MQ-15 |
| MQ-14 | `southern_horn_state`, `uru_corridor_state`, `stone_tooth_war_state`, `skiv_intelligence_state`, `ghor_host_cohesion` | MQ-15, MQ-17, summer |
| MQ-15 | `ghor_dead`, `organized_siege_broken`, `grobi_aftermath_state`, `city_winter_survival` | MQ-16 onward |
| MQ-16 | `cold_iron_anchor`, `muster_known`, `mine_company_survivors`, `muster_anchor_count` | MQ-17 through MQ-21 |
| MQ-17 | `tannbruck_reclaimed`, `muster_anchor_campaign_open`, `spring_settlement_access` | MQ-18 through summer |
| MQ-18 | `deep_muster_approach_open`, `last_hearth_forward_base`, `remaining_anchor_access` | MQ-19 through MQ-21 |
| MQ-19 | `gerhold_command_severed`, `gerhold_fate`, `gerhold_loyalists_state`, `muster_acceleration` | MQ-20, MQ-21, summer |
| MQ-20 | `upper_grenz_front`, `tuskway_front`, `fenn_road_front`, `final_assault_strength` | MQ-21, summer |
| MQ-21 | `general_below_stopped`, `deep_muster_altar_destroyed`, `deep_muster_site_state`, `campaign_victory` | SQ-01, SQ-02, postgame |
| SQ-01 | `player_service_claim`, `campaign_casualty_record`, `companion_destinations_locked`, `political_settlement_composed` | SQ-02 and postgame |
| SQ-02 | `reconstruction_priority`, `summer_regional_access`, `summer_postgame_open` | persistent summer |

## Controlled State Families

- People and material use named outcome bundles rather than hidden morality scores.
- Route and site states use `secured`, `damaged`, `hostile`, `closed`, or a named authored exception.
- Individual survival remains a named boolean or outcome state.
- The five Muster anchors use `active`, `damaged`, or `destroyed`; only `destroyed` counts toward the final threshold.
- `muster_anchor_threshold_met` becomes true when any three regional anchors are destroyed and never becomes false afterward.
- Ghor's host uses `massed`, `strained`, `fractured`, or `routed`.
- The player service claim uses `unoffered`, `personal-release`, `collective-relief`, or `superseded-by-faction-settlement`.

## Fixed Results

`tannbruck_fallen`, `emerald_drake_dead`, `ghor_dead`, `organized_siege_broken`, `muster_known`, `gerhold_command_severed`, `general_below_stopped`, and `deep_muster_altar_destroyed` become true in every completed campaign.

## Navigation

- [[Narrative State Register]]
- [[Grenzburg Chapter and Window Matrix]]
- [[Main Campaign MOC]]
