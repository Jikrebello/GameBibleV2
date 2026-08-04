---
type: reference
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Sermora"]
culture: ["Sermoran"]
related_factions: ["Blackjack Corps", "Medori Bank", "The Salt-Reed Company"]
appears_in: ["Grenzburg"]
needs: []
aliases: ["CMP-02 Campaign"]
tags: [production-control, narrative-rewrite]
companion_id: "CMP-02"
architecture_status: migrated
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
grounded_rewrite_status: approved
external_stakes: ["customs theft", "road and ferry safety", "winter casualty signals", "public performance work", "Muster cadence suppression"]
banter_priority: contextual
player_interest_gate: player-signaled
missed_arc_treatment: changed-reentry
---
# Ilyana Companion Campaign

This is the controlling authority for Ilyana Veshkar's eleven authored pieces, ten-piece playthrough ceiling, act preparation, autonomous decisions, changed re-entry, progression, and formal outcomes.

[[Ilyana Veshkar]] controls character canon. [[Ilyana Field Familiarity and Relationships]] controls approval and intimacy. [[Ilyana Harmonic Support Package]] controls companion combat, while [[Bard]] controls the player vocation.

## Grounded Campaign Identity

Ilyana's campaign is about earning a living in public art while Grenzburg needs repetition, maintenance, signals, morale, and disciplined service. Her former troupe remains remote. Their claims arrive through authenticated records and Bellandi; current performers, ferrymen, patients, workers, and audiences carry the playable action.

Only [[Five Cases at Customs]], [[No Song by Command]], [[The Free Refrain]], and the settlement aspect of [[The Last Common Measure]] directly centre her old abuse. The other pieces concern road work, sustained public performance, friendship, civic rehearsal, a creative project surviving its founder, and private relationship choices.

Her charm is not constant. A paid room may be indifferent, a rehearsal may be tedious, a signal may need to be played identically for hours, and somebody may prefer silence. The player must explicitly signal romantic interest before Ilyana treats attention as attraction.

## Campaign Thesis

Ilyana's story asks whether a gifted leader can remain decisive, joyful, and ambitious after accepting that other people are not instruments in her composition.

Her old defence is:

> They needed someone willing to choose the next measure.

The campaign tests four truths:

1. A good plan must survive another person's refusal.
2. Shared success does not create continuing consent.
3. Credit, instruments, wages, and repertoire have owners.
4. Restitution may end the relationship it repairs.

## Formal Campaign

| Sequence | ID | Piece | Role | Party | Estimated hours |
|---:|---|---|---|---|---:|
| 1 | CMP-02-I | [[Five Cases at Customs]] | introduction | normal party | 1.0 |
| 2 | CMP-02-A1-O | [[The Road Without a Conductor]] | Act I operation | normal party | 0.75 |
| 3 | CMP-02-A1-F | [[No Song by Command]] | Act I finale | player and Ilyana | 1.5 |
| 4 | CMP-02-FR | [[A Tune with No Owner]] | friendship | one-on-one | 0.5 |
| 5 | CMP-02-A2-O | [[Reeds Under Ice]] | Act II operation | normal party | 0.75 |
| 6 | CMP-02-A2-F | [[The Free Refrain]] | Act II finale | player and Ilyana | 1.75 |
| 7 | CMP-02-RM | [[One Private Song]] | romance | one-on-one | 0.5 |
| 7 | CMP-02-BD | [[Duet Without a Conductor]] | sworn bond | one-on-one | 0.5 |
| 8 | CMP-02-A3-O | [[Every Case Its Owner]] | Act III operation | normal party | 0.75 |
| 9 | CMP-02-A3-F | [[The Last Common Measure]] | Act III finale | player and Ilyana | 2.0 |
| 10 | CMP-02-S | [[The Road Takes the Song]] | summer coda | normal party or changed encounter | 0.5 |

One playthrough exposes nine non-exclusive pieces and one relationship variant for approximately ten authored hours. Only the three act finales use the fixed duo format.

## Tracking

Ilyana is recruited during [[The Black Road Main Quest|The Black Road]]. Her campaign becomes tracked when the player:

- accepts [[Five Cases at Customs]];
- promises to help identify the Salt-Reed property;
- or manually tracks the discovered campaign.

The introduction opens after one meaningful outing involving a coordinated rescue, a performance or property dispute, a dangerous group success, or a battlefield support decision. Idling and repeated jobs do not count.

## Direction

`ilyana_direction` is derived from named decisions:

- **consensual:** Ilyana makes plans that survive refusal, returns control, and asks before assigning.
- **mixed:** she performs real repair but relies on external supervision, delayed admission, or retained common property.
- **entitled:** she treats urgency, friendship, talent, or success as authority over another person's participation.

This is not an invisible approval score. A changed value is always explained through authored dialogue or aftermath.

## Readiness Standard

| Assets | Docket state | Effect |
|---:|---|---|
| 0-1 | Unprepared | Ilyana acts autonomously; the player cannot safely stage the duo finale |
| 2 | Viable | the duo finale becomes joinable with meaningful tradeoffs |
| 3 | Prepared | every principal material objective can be achieved through strong play |
| 4-5 | Strongly Prepared | one additional safeguard or route is available without deciding Ilyana's morality |

No threshold requires one vocation, faction, relationship, origin, or moral alignment.

## Act I Preparation

| Asset | Source | Use in No Song by Command |
|---|---|---|
| `ilyana_cases_secured` | [[Five Cases at Customs]] | identifies the prepared fog reed and its safe release phrase |
| `ilyana_road_circuit_state` | [[The Road Without a Conductor]] | provides a tested public code and current signal crew |
| `ilyana_eel_bridge_route_known` | Longlake exploration or road service | opens the spring-culvert and reed-bank approaches |
| `ilyana_individual_ownership_recorded` | Customs, Lucia, or Low Lantern work | establishes Tessa's equipment and the limits of seizure |
| `ilyana_voluntary_signal_support` | local musicians or Chapel-Folk ferrymen | supplies a signal plan that does not require Tessa to keep playing |

## Act II Preparation

| Asset | Source | Use in The Free Refrain |
|---|---|---|
| `ilyana_winter_signal_code` | [[Reeds Under Ice]] | keeps the corridor legible after its performance positions split |
| `ilyana_breach_casualty_lane_mapped` | [[The City in Siege]] | opens the safest casualty corridor |
| `ilyana_counter_tuning_prepared` | Warlock Hall or Hammer Ward support | counters Grobi horns without overstraining local callers |
| `ilyana_local_roles_recorded` | Yard, Mercy, and Longlake rehearsals | establishes each task, stop signal, and replacement |
| `ilyana_refuge_acoustics_known` | West Refuge or River Boom exploration | supplies a second performance position and retreat cadence |

## Act III Preparation

| Asset | Source | Use in The Last Common Measure |
|---|---|---|
| `ilyana_field_cases_state` | [[Every Case Its Owner]] | supplies independent district signals when the tower isolates Ilyana |
| `ilyana_muster_cadence_sampled` | [[The Land Reclaimed]] or anchor work | identifies the command engine's repetition |
| `ilyana_boom_tower_route_known` | River Boom exploration | opens the maintenance approach and evacuation line |
| `ilyana_common_score_partitioned` | district field-case work | separates the shared technical core from local authorship |
| `ilyana_ensemble_destinations_secured` | route and refuge work | gives every crew a retreat point and relief shift |

`ilyana_private_cadence_practiced` from [[One Private Song]] and `ilyana_equal_cadence_practiced` from [[Duet Without a Conductor]] are mutually exclusive bonuses outside the threshold. Either preserves one person or material objective during the River Boom split. They do not stack or decide Ilyana's moral choice.

## Deadlines

| Chapter | Deadline | Autonomous action |
|---|---|---|
| Act I | commitment to [[The Last Convoy]] | Ilyana joins the Eel Bridge response as a working Blackjack Bard |
| Act II | commitment to [[Ghor at the Gate]] | Ilyana takes her assigned post in the main-campaign casualty response |
| Act III | commitment to [[The Deep Muster Main Quest|The Deep Muster]] | Ilyana supports the River Boom defence without resolving her private account unseen |

Tracked campaigns show readiness, intended action, lost rewards, and relationship consequences. Untracked plans remain discoverable through Yard schedules, performer conversations, letters, and customs notices.

## Tracked and Engaged Outcomes

These branches apply after the player tracks the campaign, influences Ilyana's conduct, or breaks an explicit promise. They do not govern an ignored colleague.

### Act I

- **Consensual and Prepared:** Ilyana rescues Tessa without requiring another fog line. Heda may escape with one wagon.
- **Mixed default:** she obeys Tessa's stop only after the player or route code makes the limit unavoidable.
- **Entitled:** she orders the injured Bard to continue, worsening Tessa's breathing injury and creating a warned conflict.

Dismas may close a bandit withdrawal. Bernard may protect a ferryman. Neither can make Ilyana respect Tessa's stop.

### Act II

- **Consensual and Prepared:** the casualty corridor survives through local roles that retain stop and revision authority.
- **Mixed default:** Ilyana saves the patients under externally enforced role limits while still treating the refrain as solely hers.
- **Entitled:** she invokes the company name or compulsion against a non-hostile person, creating a major departure conflict.

Zafir may formalize stop authority. Bernard may stabilize casualties. Neither can make Ilyana release control.

### Act III

- **Consensual and Prepared:** Ilyana trusts the district crews, defeats the cadence engine, and separately releases every invalid personal claim; one route or case may still be lost.
- **Mixed default:** she releases personal service while retaining disputed repertoire and accepts a bounded civic signal post.
- **Entitled:** she preserves the Salt-Reed name or scores as her property, uses the final emergency as ownership proof, or rejoins Morante's enterprise.

Ashira may preserve a score archive. Tavio may vent the engine. Neither chooses whether Ilyana releases ownership.

## Stable-Colleague Route

With no personal engagement, Ilyana performs normal convoy signals, paid rooms, Mercy drills, and instrument maintenance. Local road musicians and ferrymen handle the Eel Bridge incident; the winter casualty corridor follows its main-campaign state; the Salt-Reed property and authorship claims remain in Bellandi's escrow.

Ilyana neither pressures a former performer nor resolves the old company off-screen. She reaches summer as a working Blackjack Bard whose skill, ego, and unresolved obligations remain intact. Changed re-entry uses current civic performers and the present season rather than recreating an expired troupe emergency.

## Changed Re-entry

### Echoes at Eel Bridge

Missing Act I opens a winter aftermath. Ilyana may repair Tessa's signal reed, compensate injured households, and identify escaped bandits. It cannot erase injury, restore lost cargo, or grant the original finale rewards.

### Refrain After Snow

Missing Act II opens a spring restitution aftermath. Ilyana can release disputed emergency authority, protect one witness, and repair direction before Act III.

It can unlock [[Bard]] through a new civic field test, but does not restore the siege rewards or relationship opportunity. A tracked transition warning states the specific losses before the player confirms the deadline.

### Act III

Missing the Act III finale leaves Ilyana's legal and moral settlement unresolved unless the campaign was already tracked into a deterministic branch. [[The Road Takes the Song]] reflects the surviving civic work without inventing a grand transformation.

## Embedded Opportunities

| ID | Context | Authored effect |
|---|---|---|
| IL-E01 | [[Roads Worth Saving]] | uses signals to coordinate a rescue while asking local road-speakers who directs movement |
| IL-E02 | [[The City in Siege]] | establishes fog, weapon cadence, and casualty calls during the western breach |
| IL-E03 | [[The Land Reclaimed]] | samples a Muster cadence while distinguishing non-conscious command from consent |
| IL-E04 | [[Terms of Service]] | supports Brina's voluntary drill and rejects Koss's morale compulsion |
| IL-E05 | [[Mercy in Winter]] | supports hospital breathing and respects the boundary between mending and White Flame |
| IL-E06 | Local performance dispute | names a borrowed song's source and changes payment or access |
| IL-E07 | River rescue story | coordinates ferrymen without replacing their local judgement |
| IL-E08 | River Boom exploration | identifies acoustic routes and dangerous returning echoes |
| IL-E09 | Open rehearsal at the Yard | lets every participant opt into a signal role and stop without punishment |
| IL-E10 | Stranded performer encounter | changes help, price, and trust according to Ilyana's direction |

## Outcome Requirements

### Resolved

Ilyana must:

- admit the forged authority;
- complete or materially repair the Act I refusal crisis;
- release emergency control after the winter defence;
- protect individual release and authorship records;
- relinquish the company name and shared repertoire unless every owner freely agrees otherwise;
- avoid unresolved compulsion against a civilian, captive, companion, or former performer.

She becomes an open-road Bard and does not found another company during the game.

### Compromised

Ilyana performs real rescue and restitution but retains disputed repertoire, relies on external supervision, delays release until after success, or preserves public credit that others contest.

### Broken or Departed

Ilyana conceals releases, claims performers or repertoire through emergency authority, uses compulsion to manufacture participation, or accepts Morante's replacement patronage. Departure follows a warned confrontation and refused repair.

## Navigation

- [[Ilyana Veshkar]]
- [[Ilyana Field Familiarity and Relationships]]
- [[Ilyana Harmonic Support Package]]
- [[Ilyana Banter and Reactivity]]
- [[The Salt-Reed Company]]
- [[Bard]]
- [[Companion Campaign Architecture]]
- [[Companion Autonomy and Act Convergence]]
- [[Companion Campaign Expansion Register]]
- [[Narrative State Register]]
- [[Companions MOC]]
