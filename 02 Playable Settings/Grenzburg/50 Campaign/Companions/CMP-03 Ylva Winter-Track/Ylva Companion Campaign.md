---
type: reference
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Upper Grenz", "Longlake Country", "Frostfenn March"]
culture: ["Ättar", "Grey-Wolf"]
related_factions: ["Blackjack Corps", "Medori Bank"]
appears_in: ["Grenzburg"]
needs: []
aliases: ["CMP-03 Campaign"]
tags: [production-control, narrative-rewrite]
companion_id: "CMP-03"
architecture_status: migrated
emotional_rewrite_status: cleared
dialogue_status: approved
grounded_rewrite_status: approved
external_stakes: ["south-road safety", "civilian evacuation", "signal infrastructure", "field-arrow supply", "dead-march extraction"]
banter_priority: contextual
player_interest_gate: player-signaled
missed_arc_treatment: changed-reentry
---
# Ylva Companion Campaign

This is the controlling authority for Ylva Winter-Track's eleven authored pieces, ten-piece playthrough ceiling, preparation ladders, deterministic autonomy, changed re-entry, progression, and outcomes.

[[Ylva Winter-Track]] controls character canon. [[Ylva Field Familiarity and Relationships]] controls approval and intimacy. [[Ylva Rescue Hunter Package]] controls companion combat. [[Hunter]] controls the shared vocation.

## Grounded Campaign Identity

Ylva's work remains rescue and route craft, but the campaign no longer repeats one test of self-sacrifice. [[A Signal Shared]] makes her patronize a less experienced operator whose field judgement proves necessary. [[Signals Over Lantern Ward]] makes one of her route calls materially wrong while a local station-holder is right. [[What the Ice Takes]] confronts her contempt for somebody who withdraws earlier than she would. [[Routes for the Living]] tests teaching rather than another mapping exercise.

Only the introduction and three act finales primarily centre her personal fault. [[No Quarry Today]] preserves beauty, competition, food, and the carved spoon without crisis. Romance remains inactive until a male player explicitly signals it.

## Campaign Thesis

Ylva's campaign asks whether a rescue professional can remain courageous and dependable after accepting that her life, limits, and decisions also belong inside the team's honest plan.

Her old defence is:

> If I can still stand, the burden is mine.

The campaign tests four truths:

1. Concealed endurance is not the same as reliability.
2. A person may choose informed danger without Ylva choosing for them.
3. Shared liability permits resistance that solitary sacrifice prevents.
4. The last marker succeeds by being relieved, not by becoming a memorial.

## Formal Campaign

| Sequence | ID | Piece | Role | Party | Estimated hours |
|---:|---|---|---|---|---:|
| 1 | CMP-03-I | [[The Fourth Marker]] | introduction | normal party | 1.0 |
| 2 | CMP-03-A1-O | [[A Signal Shared]] | Act I operation | normal party | 0.75 |
| 3 | CMP-03-A1-F | [[The Rearguard Road]] | Act I finale | player and Ylva | 1.5 |
| 4 | CMP-03-FR | [[No Quarry Today]] | friendship | one-on-one | 0.5 |
| 5 | CMP-03-A2-O | [[Signals Over Lantern Ward]] | Act II operation | normal party | 0.75 |
| 6 | CMP-03-A2-F | [[What the Ice Takes]] | Act II finale | player and Ylva | 1.75 |
| 7 | CMP-03-RM | [[A Hearth Chosen]] | romance | one-on-one | 0.5 |
| 7 | CMP-03-BD | [[The Sister Watch]] | sworn bond | one-on-one | 0.5 |
| 8 | CMP-03-A3-O | [[Routes for the Living]] | Act III operation | normal party | 0.75 |
| 9 | CMP-03-A3-F | [[The Last Marker]] | Act III finale | player and Ylva | 2.25 |
| 10 | CMP-03-S | [[The Road She Chooses]] | summer coda | normal party or changed encounter | 0.5 |

The eleven authored variants total 10.75 hours. A playthrough exposes nine non-exclusive pieces and one relationship variant for approximately 10.25 hours. Only the three act finales use the fixed duo format.

## Tracking

Ylva is introduced and recruited during [[The Southbound Muster]]. Her campaign becomes tracked when the player:

- accepts [[The Fourth Marker]];
- agrees that four simultaneous watches are not a sustainable assignment;
- or manually tracks the discovered campaign.

The introduction is part of her recruitment sequence. Idling, repeatable jobs, and recycled route encounters cannot advance her campaign.

## Direction

`ylva_direction` is derived from named decisions:

- **shared:** Ylva reports limits, distributes responsibility, accepts care, and respects another person's informed risk.
- **managed:** she performs well under external limits but has not accepted shared responsibility as her own practice.
- **self-spent:** she conceals injury, centralizes danger, and treats herself as expendable.

This is not an opaque morality score. Every change is shown through a route plan, declared roster, injury report, liability decision, or authored conversation.

## Readiness Standard

| Assets | Docket state | Effect |
|---:|---|---|
| 0-1 | Unprepared | Ylva acts autonomously; the duo finale cannot be staged safely |
| 2 | Viable | the player may join with meaningful tradeoffs |
| 3 | Prepared | every principal material objective can be achieved through strong play |
| 4-5 | Strongly Prepared | one additional safeguard is available without deciding Ylva's morality |

No threshold requires a faction, relationship, origin, starting vocation, or moral alignment.

## Act I Preparation

| Asset | Source | Use in The Rearguard Road |
|---|---|---|
| `ylva_fourth_marker_restored` | [[The Fourth Marker]] | restores the warning point omitted from Koss's roster |
| `ylva_shared_signal_code` | [[A Signal Shared]] | lets separate teams report without Ylva relaying every message |
| `ylva_black_fir_route_survey` | Black Fir Watch exploration | identifies a dry bypass around one flooded cut |
| `ylva_three_log_bridge_repair` | local road work | allows litters and handcarts to cross together |
| `ylva_upper_grenz_relief_roster` | ducal, Chapel-Folk, or Blackjack support | names a team empowered to relieve Ylva |

## Act II Preparation

| Asset | Source | Use in What the Ice Takes |
|---|---|---|
| `ylva_lantern_ward_signal_chain` | [[Signals Over Lantern Ward]] | coordinates shore, roof, and ice warnings |
| `ylva_western_breach_route_known` | [[The City in Siege]] | provides a protected receiving lane |
| `ylva_longlake_ice_soundings` | Longlake exploration | reveals load-bearing and rotten sheets |
| `ylva_winter_field_arrow_stock` | Hunter preparation | preserves smoke and line tools through the full crossing |
| `ylva_receiving_shelters_staffed` | Church, Folk, ducal, or Blackjack support | lets evacuees leave the ice without waiting for Ylva |

## Act III Preparation

| Asset | Source | Use in The Last Marker |
|---|---|---|
| `ylva_living_route_atlas` | [[Routes for the Living]] | duplicates the current routes beyond any single carrier |
| `ylva_tannbruck_scout_post_restored` | spring reclamation | provides northern relay and casualty collection |
| `ylva_fenn_lantern_fuel` | Frostfenn work | keeps the final warning lit during black-mud weather |
| `ylva_last_hearth_relief_roster` | faction, settlement, or companion support | names the team authorized to take the last watch |
| `ylva_white_mud_extraction_line` | field preparation | provides a secured withdrawal from the causeway |

`ylva_homeward_route_practiced` from [[A Hearth Chosen]] and `ylva_sister_watch_practiced` from [[The Sister Watch]] are mutually exclusive bonuses outside the threshold. Either prevents one extraction or exhaustion failure in [[The Last Marker]]. They do not stack or decide Ylva's moral choice.

## Deadlines

| Chapter | Deadline | Autonomous action |
|---|---|---|
| Act I | commitment to [[The Last Convoy]] | Ylva enters the rearguard route with available local teams |
| Act II | commitment to [[Ghor at the Gate]] | Ylva conducts the Longlake ice evacuation |
| Act III | commitment to [[The Deep Muster Main Quest|The Deep Muster]] | Ylva holds the Frostfenn relay during the dead march |

Tracked campaigns show intended action, readiness, missing rewards, and relationship consequences. Untracked plans remain discoverable through the Blackjack route board, warning flags, shelter rosters, and Ylva's changing schedule.

## Tracked and Engaged Outcomes

These branches apply after the player tracks the campaign, affects Ylva's readiness, or breaks an explicit promise. They do not govern an ignored colleague.

### Act I

- **Shared and Prepared:** the households and workers are recovered through distributed teams; one cargo cache or route marker is lost.
- **Managed default:** Ylva saves everyone but calls relief late, causing one avoidable injury and additional equipment loss.
- **Self-Spent:** she conceals injury, loses the distress window, and reaches winter with a damaged route and several serious injuries.

Bernard may steady evacuees. Dismas may secure the rear trail. Neither can make Ylva issue the honest distress call.

### Act II

- **Shared and Prepared:** receiving teams choose informed risks, all people leave the ice, and cargo liability is filed collectively.
- **Managed default:** Ylva preserves the evacuation but accepts the abandoned cargo as another personal debt.
- **Self-Spent:** she holds the weakest sheet alone, loses essential food, and emerges injured under a widened surety.

Ilyana may coordinate signals. Tavio may brace a failing approach. Neither can make Ylva distribute liability.

### Act III

- **Shared and Prepared:** Ylva accepts relief at the last marker and withdraws with the final living group.
- **Managed default:** other Blackjacks recover her after she attempts to hold the final route alone; she survives under imposed shift limits.
- **Self-Spent:** she refuses relief and departs after the campaign for solitary work unless the player joins the finale and reaches a warned resolution.

Elara may preserve route records. Zafir may formalize shared liability. Neither can decide whether Ylva leaves the marker.

## Stable-Colleague Route

With no personal engagement, Ylva serves ordinary route watches under the same relief rules as other specialists. She does not secretly undertake the rearguard, assume Longlake cargo liability, or hold the final marker alone. Those events are handled through regional and main-campaign states.

She reaches summer as a capable Blackjack pathfinder who still dislikes visible need, still makes occasional bad route calls, and has not settled the White-Sled pattern. She is neither injured nor supervised because the player chose different company. Changed re-entry preserves the personal decision through a current route problem.

## Changed Re-entry

### Relay After Frost

Missing Act I opens a winter relay-repair encounter dealing with the injured traveler, lost equipment, and the damaged signal chain. It permits restitution, route repair, and practical recipe training without recreating the missed rescue or its personal rewards.

The All-Weather Flare and Reinforced Blunt-Head recipes can instead be earned through a shorter winter field test. The changed scene does not recreate the original people, danger, or narrative rewards.

### Ice After Thaw

Missing Act II opens a spring aftermath addressing surviving cargo claims, current receiving teams, and a thaw-water crossing. Ylva may reject sole liability under changed circumstances.

It can grant the Rescue Scout progression through a credible spring extraction, but it does not reopen the time-specific romance or sworn-bond opportunity. A tracked transition warning states this before confirmation.

### Act III

Missing the Act III finale fixes a settlement only if the player had tracked Ylva into a declared course and then declined the final action. An untracked Ylva reaches summer as a stable, unresolved colleague. [[The Road She Chooses]] reflects the relevant state without inventing a transformation.

## Embedded Opportunities

| ID | Context | Authored effect |
|---|---|---|
| YL-E01 | [[The Southbound Muster]] | reads the first unsafe staffing pattern and joins the company |
| YL-E02 | [[The City in Siege]] | coordinates an extraction lane through Lantern Ward |
| YL-E03 | [[The Dead March]] | identifies which route remains usable by the living |
| YL-E04 | [[Outpost Arithmetic]] | rejects a roster that treats one scout as four people |
| YL-E05 | [[The River's Two Banks]] | weighs shared ferry risk against one-sided command |
| YL-E06 | [[The Blackjacks Koss Lost]] | exposes sole-liability language in a Blackjack assignment |
| YL-E07 | Black Fir Watch | reads a failed relief change and creates a route asset |
| YL-E08 | Ashfield fieldcraft | teaches weather signs and practical field arrows |
| YL-E09 | Snowblind Rise discovery | recognizes the conditions that shaped the White-Sled Rescue |
| YL-E10 | Blackjack route board | publishes a route code and names who may relieve her |

## Progression

All progression is available through friendship and core companion stages. Romance and bond never control recipes.

| Stage | Account-wide reward |
|---|---|
| [[A Signal Shared]] | All-Weather Flare Arrow and Reinforced Blunt-Head |
| [[The Rearguard Road]] | Line Arrow |
| [[Signals Over Lantern Ward]] | Smoke Arrow |
| [[Routes for the Living]] | Controlled Blast Arrow |
| [[The Last Marker]] | Winter-Track Fieldcraft augment |

Ylva receives each unlocked tool automatically. Exact crafting costs and combat values remain provisional.

## Outcome Requirements

### Resolved

Ylva must:

- report an injury before it removes her from the route;
- publish and share a signal system;
- authorize another team to relieve her;
- preserve informed choice during the ice evacuation;
- reject sole liability for collective action;
- duplicate the living-route atlas;
- leave the final marker with the final group.

She becomes an independent pathfinder using openly shared contracts.

### Compromised

Ylva performs excellent rescue work but accepts care, rest, staffing, or liability only when an institution imposes it. She remains a ducal or Blackjack scout under supervision.

### Broken or Departed

Ylva conceals critical injuries, suppresses another team's agency, destroys the shared route record, or refuses relief after a warned repair. She leaves for solitary contracts.

### Heroic but Unresolved Sacrifice

The sacrifice exists only inside [[The Last Marker]], after every safer route and relief option is clearly presented. The player must explicitly accept it. It saves lives, but does not count as resolved.

## Navigation

- [[Ylva Winter-Track]]
- [[Ylva Field Familiarity and Relationships]]
- [[Ylva Rescue Hunter Package]]
- [[Ylva Banter and Reactivity]]
- [[The White-Sled Rescue]]
- [[Hunter]]
- [[Companion Campaign Architecture]]
- [[Companion Autonomy and Act Convergence]]
- [[Companion Campaign Expansion Register]]
- [[Narrative State Register]]
- [[Companions MOC]]
