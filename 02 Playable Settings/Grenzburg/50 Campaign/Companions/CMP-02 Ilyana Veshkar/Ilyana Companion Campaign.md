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
emotional_rewrite_status: pending-paired-pass
dialogue_status: pending-rewrite
---
# Ilyana Companion Campaign

This note remains the structural authority for Ilyana's sequence, deadlines, preparation, autonomy, and rewards. [[Companion Emotional Rewrite Audit]] now supersedes its scene-level emotional assumptions. It is not implementation-ready until the Ilyana-Dismas paired pass clears its emotional and dialogue status.

This is the controlling authority for Ilyana Veshkar's eleven authored pieces, ten-piece playthrough ceiling, act preparation, autonomous decisions, changed re-entry, progression, and formal outcomes.

[[Ilyana Veshkar]] controls character canon. [[Ilyana Field Familiarity and Relationships]] controls approval and intimacy. [[Ilyana Harmonic Support Package]] controls companion combat, while [[Bard]] controls the player vocation.

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
| `ilyana_cases_secured` | [[Five Cases at Customs]] | identifies Nereo's property and the hidden duplicate signal |
| `ilyana_celia_safe` | [[The Road Without a Conductor]] | provides instrument-repair gear and a truthful account |
| `ilyana_eel_bridge_route_known` | Longlake exploration or road service | opens the spring-culvert and reed-bank approaches |
| `ilyana_individual_ownership_recorded` | Customs, Lucia, or Low Lantern work | prevents bandits or Ilyana from treating the cases as common leverage |
| `ilyana_voluntary_signal_support` | local musicians or Chapel-Folk ferrymen | supplies a signal plan that does not require Nereo |

## Act II Preparation

| Asset | Source | Use in The Free Refrain |
|---|---|---|
| `ilyana_instruments_returned` | [[Reeds Under Ice]] | lets each former member choose with their own conductor |
| `ilyana_breach_casualty_lane_mapped` | [[The City in Siege]] | opens the safest casualty corridor |
| `ilyana_counter_tuning_prepared` | Warlock Hall or Hammer Ward support | counters Grobi horns without overstraining the ensemble |
| `ilyana_performer_pledges_recorded` | individual conversations | establishes who volunteered for which task and when consent ends |
| `ilyana_refuge_acoustics_known` | West Refuge or River Boom exploration | supplies a second performance position and retreat cadence |

## Act III Preparation

| Asset | Source | Use in The Last Common Measure |
|---|---|---|
| `ilyana_releases_protected` | [[Every Case Its Owner]] | prevents the final emergency from reviving old service claims |
| `ilyana_muster_cadence_sampled` | [[The Land Reclaimed]] or anchor work | identifies the command engine's repetition |
| `ilyana_boom_tower_route_known` | River Boom exploration | opens the maintenance approach and evacuation line |
| `ilyana_common_score_partitioned` | Mirella, records, or lawful mediation | assigns each musical line without assuming company ownership |
| `ilyana_ensemble_destinations_secured` | individual performer scenes | prevents evacuation pressure from becoming coerced participation |

`ilyana_private_cadence_practiced` from [[One Private Song]] and `ilyana_equal_cadence_practiced` from [[Duet Without a Conductor]] are mutually exclusive bonuses outside the threshold. Either preserves one person or material objective during the River Boom split. They do not stack or decide Ilyana's moral choice.

## Deadlines

| Chapter | Deadline | Autonomous action |
|---|---|---|
| Act I | commitment to [[The Last Convoy]] | Ilyana goes to Eel Bridge to recover Nereo and the drum |
| Act II | commitment to [[Ghor at the Gate]] | Ilyana stages a casualty refrain using whatever authority she still possesses |
| Act III | commitment to [[The Deep Muster Main Quest|The Deep Muster]] | Ilyana confronts the cadence engine and settles the Salt-Reed property |

Tracked campaigns show readiness, intended action, lost rewards, and relationship consequences. Untracked plans remain discoverable through Yard schedules, performer conversations, letters, and customs notices.

## Deterministic Autonomy

### Act I

- **Consensual and Prepared:** Ilyana rescues Nereo without requiring his performance. Bandit leaders escape with some common property.
- **Mixed default:** she saves Nereo and the ferrymen but pressures him to maintain fog before a safe alternative is ready. He is injured and refuses further private contact.
- **Entitled:** she treats the emergency as permission, worsening Nereo's injuries and losing his drum or the ferry records.

Dismas may close a bandit withdrawal. Bernard may protect a ferryman. Neither can make Ilyana respect Nereo's refusal.

### Act II

- **Consensual and Prepared:** the casualty corridor survives through individually accepted roles; Morante or her factor escapes with part of the claim.
- **Mixed default:** Ilyana saves the patients by accepting temporary control of the old ensemble and only releases it afterward.
- **Entitled:** she invokes the company name or compulsion against a non-hostile person, creating a major departure conflict.

Zafir may expose the invalid service claim. Bernard may stabilize casualties. Neither grants consent for the performers.

### Act III

- **Consensual and Prepared:** Ilyana releases every claim and defeats the cadence engine, but one archive, instrument, or route is permanently lost.
- **Mixed default:** she releases personal service while retaining disputed common repertoire and accepts a supervised civic signal post.
- **Entitled:** she preserves the Salt-Reed name or scores as her property, uses the final emergency as ownership proof, or rejoins Morante's enterprise.

Ashira may preserve a score archive. Tavio may vent the engine. Neither chooses whether Ilyana releases ownership.

## Zero-Participation Route

With no player involvement:

1. Nereo and the Eel Bridge households survive with avoidable injuries after Ilyana pressures him to perform.
2. The winter casualty corridor holds, but Ilyana uses externally enforced Salt-Reed authority.
3. She releases personal service while retaining disputed repertoire and public credit.
4. She becomes a Grenzburg civic signal-Bard under a supervised charter.

This is a stable compromised outcome, not future-setting canon.

## Changed Re-entry

### Echoes at Eel Bridge

Missing Act I opens a winter aftermath. Ilyana may return Nereo's drum, compensate injured households, and identify escaped bandits. It cannot erase injury, restore lost property, or grant Act I finale rewards.

### Refrain After Snow

Missing Act II opens a spring restitution aftermath. Ilyana can release disputed emergency authority, protect one witness, and repair direction before Act III.

It cannot unlock [[Bard]], restore the Act II rewards, or reopen romance and sworn bond. A tracked transition warning states this before the player confirms the deadline.

### Act III

Missing the Act III finale fixes Ilyana's autonomous settlement. [[The Road Takes the Song]] reflects it without reopening the judgement.

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
