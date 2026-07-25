---
type: reference
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Kedrava"]
culture: ["Thalmyric", "Kedravan", "Chapel-Folk"]
related_factions: ["Blackjack Corps", "Order of the Long Watch", "Church of Grenzburg"]
appears_in: ["Grenzburg"]
needs: []
aliases: ["CMP-05 Campaign"]
tags: [game-ready]
companion_id: "CMP-05"
architecture_status: migrated
---
# Bernard Companion Campaign

This is the controlling authority for Bernard Valeon's eleven authored campaign pieces, ten-piece playthrough ceiling, preparation ladders, autonomous decisions, changed re-entry, embedded opportunities, and progression rewards. [[Bernard Valeon]] remains the character authority. [[Bernard Field Familiarity and Relationships]] controls approval and intimacy, [[Bernard Compulsion and Accountability System]] controls finite theft incidents, and [[Bernard Long Watch Greatsword Package]] controls combat.

## Campaign Thesis

Bernard's campaign asks whether a man formed by scarcity can receive, own, reserve, and provide without making concealment feel like safety.

His childhood explains why a full pantry still feels temporary. It does not make another person's food, medicine, key, or devotional token his. His faith gives him courage and genuine grace; it does not certify his innocence. Across the campaign he must learn:

1. an urge can be named before another person pays for it;
2. a declared reserve differs morally and practically from a secret cache;
3. personal ownership is not the same as hoarding;
4. service remains accountable even when it is heroic;
5. receiving care does not turn affection into debt.

There is no recurring villain behind Bernard's problems. Bandits, winter, Grobi attack, institutional limits, the Unending Muster, and Bernard's own choices remain distinct pressures.

## Formal Campaign

The eleven authored pieces contain mutually exclusive romance and sworn-bond episodes. A playthrough exposes nine non-exclusive pieces and no more than one sequence-7 relationship episode, preserving approximately **11.75 first-play hours**. Ordinary exploration, failed approaches, systemic incidents, and embedded opportunities may extend the campaign without padding its formal sequence.

| Sequence | ID | Piece | Role | Party | Hours | Principal function |
|---:|---|---|---|---|---:|---|
| 1 | CMP-05-I | [[Little Things Missing]] | introduction | normal party | 1.5 | expose Bernard's real relapse and establish accountable return |
| 2 | CMP-05-A1-O | [[The Wagon in the Reeds]] | Act I operation | normal party | 0.75 | recover the road-school supplies and prepare the Longlake journey |
| 3 | CMP-05-A1-F | [[Little Hands, Long Road]] | Act I finale | player and Bernard | 1.75 | protect the children and answer hunger without concealment |
| 4 | CMP-05-FR | [[A Blade Freely Given]] | friendship | one-on-one | 0.5 | make ownership healthy through an unconditional gift |
| 5 | CMP-05-A2-O | [[Four Fires]] | Act II operation | normal party | 0.75 | keep four shelters warm through practical, public provision |
| 6 | CMP-05-A2-F | [[Embers Without Excuse]] | Act II finale | player and Bernard | 2.25 | face Froststep, spend the reserve, and unlock Paladin |
| 7 | CMP-05-RM | [[Enough for Two]] | romance | one-on-one | 0.5 | accept food, romantic care, a freely given bead, and intimacy without repayment |
| 7 | CMP-05-BD | [[Watch Until Morning]] | sworn bond | one-on-one | 0.5 | repair a road shelter, share the watch, and become sworn brothers |
| 8 | CMP-05-A3-O | [[Beds Before Banners]] | Act III operation | normal party | 0.75 | establish neutral patient use of West Refuge Hall |
| 9 | CMP-05-A3-F | [[The Open Hospice]] | Act III finale | player and Bernard | 2.5 | test accountable care against the Unending Muster |
| 10 | CMP-05-S | [[The First Open Table]] | summer coda | normal party or changed encounter | 0.5 | demonstrate Bernard's settled practice and destination |

Only the three act finales invoke the formal fixed-duo rules. Friendship, romance, and sworn-bond pieces are private activities rather than combat-balanced duo quests. Romance and bond are mutually exclusive, authored separately, and never presented as alternate dialogue inside the same scene. Temporary children, carers, patients, witnesses, drivers, and soldiers remain outside the companion limit.

## Tracking and Introduction

Bernard becomes available during [[The Black Road Main Quest|The Black Road]] and joins ordinary party management after [[Warrant at the Gate]].

His campaign becomes tracked when the player accepts [[Little Things Missing]], promises to help address the property he has taken, or manually tracks the discovered campaign.

The introduction unlocks after one distinct meaningful outing with Bernard involving at least one of:

- authored care, rescue, shelter, or casualty work;
- a consequential decision about property, stores, salvage, or rightful return;
- a dangerous field sequence completed with Bernard active.

Idle time, repeatable jobs, and recycled systemic encounters do not count.

## Direction State

`bernard_direction` is qualitative and attached to named conduct:

- **truthful:** Bernard reports urges, declares reserves, accepts gifts openly, and performs concrete repair;
- **uncertain:** he performs real service but relies on external control, delays admission, or tells the truth only after pressure;
- **withholding:** he hides stores, shifts blame, falsifies a count, or uses sacred or institutional authority as immunity.

Direction is separate from approval. Kindness toward Bernard cannot erase property harm, and a stern but proportionate demand for restitution does not automatically strain friendship.

This campaign dossier owns the state. Individual formal pieces may write a new direction value at their named decisions, but no quest defines a separate Bernard morality score.

## Readiness Standard

Each act offers five named preparation assets.

| Assets held | Docket state | Effect |
|---:|---|---|
| 0-1 | Unprepared | Bernard acts autonomously; the player cannot safely stage the duo finale |
| 2 | Viable | the finale is available with meaningful material tradeoffs |
| 3 | Prepared | every principal material objective is achievable through strong play |
| 4-5 | Strongly Prepared | one additional safeguard or route is available; success is not guaranteed |

No threshold requires a particular faction, vocation, relationship, or moral alignment.

For quest gating, the docket derives `bernard_act1_readiness_viable`, `bernard_act2_readiness_viable`, and `bernard_act3_readiness_viable` when the relevant ladder reaches two assets. These are transparent readiness flags, not moral judgements.

### Act I Assets

| State | Source | Material use |
|---|---|---|
| `bernard_road_school_wagon_recovered` | [[The Wagon in the Reeds]] | complete packs, refuge bell, and a sound cart |
| `bernard_longlake_route_secured` | [[Roads Worth Saving]] | reliable crossings and an alerted road network |
| `bernard_service_injury_claim_supported` | [[A Debt That Grew Wounded]] | household trust that need will not become a hidden liability |
| `bernard_pikehook_snare_line_mapped` | [[Grenzburg Worldspace Location Register#Bernard Embedded Care Routes|Pikehook exploration]] | early bear warning and a known withdrawal line |
| `bernard_hunger_named_early` | [[Bernard Compulsion and Accountability System#The Spare Blanket|The Spare Blanket]] | Bernard recognizes the food urge before the school count |

### Act II Assets

| State | Source | Material use |
|---|---|---|
| `bernard_four_fires_plan` | [[Four Fires]] | tested fuel, consolidation, and shelter priorities |
| `bernard_breach_casualty_lane_secured` | [[The City in Siege]] | a known route through damaged Lantern Ward |
| `bernard_mercy_heat_plan` | [[Mercy in Winter]] | practical hospital heat and evacuation procedure |
| `bernard_long_watch_kit_provenance` | [[A Blade Freely Given]] | honest issue marks and a complete account of Bernard's field kit |
| `bernard_open_store_procedure_practiced` | [[Bernard Compulsion and Accountability System#Open-Store Practice|Blackjack Yard open-store drill]] | witnessed count, reserve purpose, and release conditions |

### Act III Assets

| State | Source | Material use |
|---|---|---|
| `bernard_west_refuge_neutral_claim` | [[Beds Before Banners]] | lawful mixed-patient use of West Refuge Hall |
| `bernard_reclaimed_patient_routes` | [[The Land Reclaimed]] | safe spring casualty and return corridors |
| `bernard_mixed_carer_pledge` | [[The Four-Hearth Winter]] | carers who accept the neutral admission rule |
| `bernard_underways_evacuation_route` | [[Grenzburg Worldspace Location Register#Bernard Embedded Care Routes|West Refuge exploration]] | a nonpublic withdrawal route that does not require underworld allegiance |
| `bernard_named_store_custodians` | [[Bernard Compulsion and Accountability System#Open-Store Practice|Blackjack Yard custodian drill]] | independent witnesses for every supply category |

Completing [[Enough for Two]] adds `bernard_table_received`; completing [[Watch Until Morning]] adds `bernard_second_bearer_practiced`. These mutually exclusive relationship bonuses each prevent one exhaustion-driven physical failure during [[The Open Hospice]]. They never stack and cannot declare a reserve, confess, choose patients, or set Bernard's moral outcome.

## Act Deadlines

| Chapter | Deadline | Autonomous action |
|---|---|---|
| Act I | commitment to [[The Last Convoy]] and Tannbruck's fall | Bernard joins Oda's road school with the preparation available |
| Act II | commitment to [[Ghor at the Gate]] and the spring transition | Bernard joins the Long Watch relief mission and faces Petra |
| Act III | commitment to [[The Deep Muster Main Quest]] | Bernard opens the care site he can actually sustain |

Tracked dockets display readiness and material consequences. The Act II warning explicitly states that missing the finale permanently forfeits the Paladin unlock, romance, sworn bond, and its player rewards for that playthrough.

## Deterministic Autonomy

### Act I

With no player influence, Bernard adds an undeclared food reserve to his own pack. He recognizes Mika's behavior but delays naming his own. The warning reaches the group late:

- all seven children survive;
- several suffer avoidable minor injuries;
- the bear is killed in necessary defence once it reaches the shelter line;
- the road school continues under winter restriction;
- Bernard admits the hidden reserve after the crisis and remains `uncertain`.

Truthful influence and three or more assets can produce an autonomous morally successful rescue with lost supplies or a damaged wagon. Withholding and poor preparation can cause a serious nonfatal injury and suspend the school. No child dies off-screen.

### Act II

On the default route Bernard saves the field-infirmary patients and genuinely kindles White Flame during courageous service. The manifestation does not certify his incomplete account. He later admits that he held back one salve packet and accepts external store control.

- Petra accepts restitution but does not forgive or resume friendship;
- the mission finishes depleted or displaced;
- Bernard remains `uncertain`;
- the player does not unlock Paladin;
- romance and sworn bond close permanently.

Truthful influence and strong preparation can improve the patients, reserve record, and Petra's response without restoring the missed player unlocks. Withholding and low preparation cause serious injuries, absent kindling, and a visible departure confrontation.

### Act III

With no player involvement Bernard cannot sustain a neutral independent hospice. Brina moves the viable service into the Blackjack infirmary and controls its open inventory.

- Bernard saves people and continues useful care;
- Open Lamp remains unrealized;
- his future path is Blackjack service;
- his arc is compromised and his direction remains `uncertain`;
- he has not learned independent accountability.

Truthful influence and strong preparation may establish Open Lamp autonomously with permanent material losses. Withholding can leave the hall sponsor-controlled, lost, or followed by a warned departure. In a played finale, `bernard_arc_outcome` records moral resolution while `bernard_sacrifice_state` records physical fate; Bernard cannot sacrifice himself on an autonomous route.

## Changed Re-entry

### The Road Afterward

Missing Act I opens a winter aftermath at Bent-Oak Refuge. The player may compensate injured households, restore the road-school bell, remove the remaining snare line, and help Bernard name the hidden reserve. This can improve direction and preserve later chapters. It cannot remove injuries, restore the bear, replay the journey, or grant its progression reward.

### Embers After Snow

Missing Act II opens a spring restitution aftermath involving Bernard, Petra's recorded response, and the displaced relief mission. Bernard may confess, repair stores, and restore his own sacred coherence. The player cannot unlock Paladin, romance, sworn bond, Shared Ember, No One Alone, or the missed finale rewards.

### Act III

Missing Act III fixes Bernard's autonomous destination. [[The First Open Table]] reflects it and does not reopen the hospice judgement.

## Cross-Support

- Dismas can recover the wagon trail or mark the wounded bear's retreat.
- Ylva can mark a shelter route, organize child and patient carriers, and name the team that relieves Bernard.
- Ilyana can protect a winter relief route or stabilize the hospice perimeter.
- Zafir can authenticate custody and bound sponsor terms without owning patients or stores.

Cross-support changes evidence, routes, injuries, and material loss. No companion can confess for Bernard, declare his reserve after concealment, grant forgiveness, or make the final inventory truthful.

## Embedded Opportunities

Bernard has exactly ten reserved embedded opportunities:

1. casualty and property safeguards in [[Roads Worth Saving]];
2. a protected casualty lane in [[The City in Siege]];
3. reclaimed patient routes in [[The Land Reclaimed]];
4. service-injury responsibility in [[A Debt That Grew Wounded]];
5. heat and practical mercy in [[Mercy in Winter]];
6. mixed refuge obligations in [[The Four-Hearth Winter]];
7. the Pikehook snare-line exploration;
8. the West Refuge underways exploration;
9. a Blackjack Yard open-store drill;
10. **The Spare Blanket**, a one-shot Things Not Mine incident.

Each instance is authored and non-repeatable. Routine healing, repeated store checks, and job templates do not advance Bernard's campaign.

## Outcome Requirements

### Resolved

Bernard must:

- acknowledge the relapse and clear Hannel;
- address hunger without shaming Mika or hiding his own reserve;
- personally complete the Froststep reckoning without unresolved concealment;
- preserve a truthful admission and inventory rule during the hospice;
- have no unresolved theft from patients, refugees, children, shared stores, or the dead.

On a resolved path he names the personally owned greatsword from [[A Blade Freely Given]] **Open Hand**.

### Compromised

Bernard performs real care and restitution but remains dependent on another person or institution to control every store, retains one concealed reserve, or narrows care under sponsor pressure. His owned sword remains unnamed.

### Broken or Departed

Bernard hides essential stores while people suffer, falsifies the final count, steals from the vulnerable or dead, or invokes White Flame as immunity. Departure requires a warned confrontation and refused repair. Ownership of the gifted sword is not retroactively revoked; it remains unnamed.

## Navigation

- [[Bernard Valeon]]
- [[Bernard Field Familiarity and Relationships]]
- [[Bernard Compulsion and Accountability System]]
- [[Bernard Long Watch Greatsword Package]]
- [[Bernard Banter and Reactivity]]
- [[Companion Campaign Architecture]]
- [[Companion Autonomy and Act Convergence]]
- [[Companion Campaign Expansion Register]]
- [[Narrative State Register]]
- [[Companions MOC]]
