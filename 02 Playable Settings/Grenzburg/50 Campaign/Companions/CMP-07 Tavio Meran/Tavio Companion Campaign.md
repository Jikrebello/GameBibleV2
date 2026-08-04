---
type: reference
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Vorthara"]
culture: ["Vortharan", "Sestaran"]
related_factions: ["Blackjack Corps", "Medori Bank", "Red Brass Bench", "The Crucible"]
appears_in: ["Grenzburg"]
needs: []
aliases: ["CMP-07 Campaign"]
tags: [production-control, narrative-rewrite]
companion_id: "CMP-07"
architecture_status: migrated
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
grounded_rewrite_status: approved
external_stakes: ["unsafe proof equipment", "mine-worker safety", "public bout integrity", "reconstruction standards", "Great Forge evacuation"]
banter_priority: contextual
player_interest_gate: player-signaled
missed_arc_treatment: changed-reentry
---
# Tavio Companion Campaign

This is the controlling authority for Tavio Meran's eleven authored pieces, ten-piece playthrough ceiling, preparation ladders, autonomous decisions, changed re-entry, progression, and outcomes.

[[Tavio Meran]] controls character canon. [[Tavio Field Familiarity and Relationships]] controls approval and intimacy. [[Tavio Lancewright Package]] controls companion combat, while [[Lancewright]] controls the player vocation.

## Grounded Campaign Identity

Tavio's campaign is worker safety, public competition, training, and forge service rather than eleven performances of champion identity. The Fifth Ring directly centres [[The False Ring]], [[The Fair Defeat]], [[Meran-Style]], and [[Horn for Leak-Day]]. The remaining pieces concern recalls, mine proof, honest games, escort, relationships, and examiner work.

Physicality is treated as craft. Tavio asks before touching, coaching, sparring, or turning labor into a contest. He is allowed to be tired, quiet, formally ashamed, and useful without an audience. Lio's appearance remains the one sanctioned remote-claim exception under the Lio Clause and does not make him Tavio's redemption prop. Romance remains inactive until a female player explicitly signals interest.

## Campaign Thesis

Tavio's story asks whether a brilliant competitor can remain joyous, daring, and technically ambitious after accepting that agreed limits are part of mastery.

His old defence is:

> If I carried the risk and still won, I earned the right to take it.

It is a story he assembled afterward. He cheated because he was losing to [[Lio Varcen]] and had begun to feel the first edge of decline, and the excuse arrived later to make the fear sound like courage.

## Campaign Shape

**The arenas get smaller and the contests get truer.**

- Championship arena — backstory, a crowd of thousands, a hidden ring.
- **Act II:** a filed public bout on his opponent's numbered terms, in a forge yard, with two seconds who can stop it.
- **Act III:** a pit-night challenge in a Hammer Ward yard, which he declines.
- **Summer:** a children's chalk ring and a road game, refereed.

The crowd's arc runs opposite and is the campaign's real antagonist: adored, then hungry for one villain to blame, then gone to somebody younger, then — if he earns it — won back honestly at small scale by a man who now measures more than he fights.

**The tremor appears exactly four times** (seeded, named, spent, passed) and never becomes a mechanic; see [[Tavio Meran#The hand]] and [[Tavio Lancewright Package]].

## Formal Campaign

| Sequence | ID | Piece | Role | Party | Estimated hours |
|---:|---|---|---|---|---:|
| 1 | CMP-07-I | [[The False Ring]] | introduction | normal party | 1.0 |
| 2 | CMP-07-A1-O | [[The Signed Measure]] | Act I operation | normal party | 0.75 |
| 3 | CMP-07-A1-F | [[Proof Under Load]] | Act I finale | player and Tavio | 1.5 |
| 4 | CMP-07-FR | [[Games Without a Crown]] | friendship | one-on-one | 0.5 |
| 5 | CMP-07-A2-O | [[The Challenger's Road]] | Act II operation | normal party | 0.75 |
| 6 | CMP-07-A2-F | [[The Fair Defeat]] | Act II finale | player and Tavio | 1.75 |
| 7 | CMP-07-RM | [[No Wager Between Us]] | romance | one-on-one | 0.5 |
| 7 | CMP-07-BD | [[After the Last Lantern]] | sworn bond | one-on-one | 0.5 |
| 8 | CMP-07-A3-O | [[Meran-Style]] | Act III operation | normal party | 0.75 |
| 9 | CMP-07-A3-F | [[Horn for Leak-Day]] | Act III finale | player and Tavio | 2.25 |
| 10 | CMP-07-S | [[The Road Examiner]] | summer coda | normal party or changed encounter | 0.5 |

One playthrough exposes nine non-exclusive pieces and one relationship variant for approximately 10.25 authored hours. Only the three act finales use the fixed duo format.

## Tracking

Tavio becomes recruitable in Early Autumn at the [[Blackjack Yard]]. His campaign becomes tracked when the player:

- accepts [[The False Ring]];
- promises to help determine where the unsafe fitting came from;
- or manually tracks the discovered campaign.

The introduction opens after one meaningful outing involving a difficult counter, equipment failure, public contest, worker-safety choice, or dangerous shared success. Idling and repeatable jobs do not count.

## Direction

`tavio_direction` is derived from named decisions:

- **measured:** Tavio files limits, accepts stop authority, protects participants, and honours outcomes he did not choose.
- **managed:** he performs useful safety work but stops only under supervision, accepts delayed truth, or takes sole blame to preserve the Bench.
- **overproof:** he conceals risk, fixes results, treats survival as proof, or exposes others for spectacle.

This is not an invisible morality score. Every change is explained through dialogue, records, injuries, or an authored aftermath.

## Readiness Standard

| Assets | Docket state | Effect |
|---:|---|---|
| 0-1 | Unprepared | Tavio acts autonomously; the duo finale cannot be staged safely |
| 2 | Viable | the player may join with meaningful tradeoffs |
| 3 | Prepared | every principal material objective can be achieved through strong play |
| 4-5 | Strongly Prepared | one additional safeguard or route is available without deciding Tavio's morality |

No threshold requires a faction, relationship, origin, starting vocation, or moral alignment.

## Act I Preparation

| Asset | Source | Use in Proof Under Load |
|---|---|---|
| `tavio_fifth_ring_evidence` | [[The False Ring]] | identifies the prohibited fourth load relation |
| `tavio_signed_batch_register` | [[The Signed Measure]] | maps recalled fittings to Red Brass endorsements |
| `tavio_cold_iron_control_sample` | Highlake or mine work | disproves the claim that local ore caused the fracture |
| `tavio_warlock_counterproof` | Warlock Hall support | permits a non-destructive load comparison |
| `tavio_workers_stop_authority` | Great Forge or labour support | lets a named worker halt the final test |

## Act II Preparation

| Asset | Source | Use in The Fair Defeat |
|---|---|---|
| `tavio_lio_brace_intact` | [[The Challenger's Road]] | preserves Lio's full choice of bout rules |
| `tavio_bout_rules_filed` | Crucible or ducal court work | prevents private rule substitution |
| `tavio_neutral_officials_secured` | Great Forge, Church, or civic route | protects a result neither Bench controls |
| `tavio_red_brass_witness` | Act I evidence or protected technician | exposes institutional pressure |
| `tavio_bookmaker_ledger` | Low Lantern, watch, or investigation | identifies sabotage and fixed odds |

## Act III Preparation

| Asset | Source | Use in Horn for Leak-Day |
|---|---|---|
| `tavio_field_inspection_ledger` | [[Meran-Style]] | reveals which fittings and pit-supplied rings must be isolated |
| `tavio_leak_horn_drill` | Great Forge practice | starts evacuation before smoke blocks the route |
| `tavio_mobile_vent_frame` | Hammer Ward craftsmen | permits one bounded containment attempt |
| `tavio_muster_cadence_reading` | [[The Land Reclaimed]] or anchor work | distinguishes repeated command from ordinary forge pressure |
| `tavio_worker_consent_roster` | foundry and relief work | names who accepted risk and who must be evacuated |

`tavio_courtship_measure_practiced` from [[No Wager Between Us]] and `tavio_seconds_halt_practiced` from [[After the Last Lantern]] are mutually exclusive bonuses outside the threshold. Either prevents one equipment or evacuation failure in [[Horn for Leak-Day]]. They do not stack or decide Tavio's moral choice.

## Deadlines

| Chapter | Deadline | Autonomous action |
|---|---|---|
| Act I | commitment to [[The Last Convoy]] | Tavio conducts the Cold-Iron proof before winter closes the route |
| Act II | commitment to [[Ghor at the Gate]] | Tavio answers Lio's challenge under available officials |
| Act III | commitment to [[The Deep Muster Main Quest|The Deep Muster]] | Tavio enters the Great Forge leak under emergency authority |

Tracked campaigns show readiness, intended action, lost rewards, and relationship consequences. Untracked plans remain discoverable through Yard schedules, forge notices, bout bills, Lio's correspondence, and Hammer Ward gossip.

## Tracked and Engaged Outcomes

These branches apply after the player tracks the campaign, changes Tavio's preparation, or breaks an explicit promise. They do not govern an ignored colleague.

### Act I

- **Measured and Prepared:** unsafe fittings are recalled without injury; one supplier or record escapes.
- **Managed default:** Tavio recalls most fittings but pushes one proof beyond the named halt, causing an avoidable worker injury.
- **Overproof:** the test fails publicly, destroys records, and leaves unsafe gear in circulation.

Ylva may establish an extraction lane and insist upon a named relief team. Ilyana may coordinate evacuation. Neither can make Tavio stop the test.

### Act II

- **Measured and Prepared:** Tavio fights honestly, accepts the result, and exposes the Bench without demanding reconciliation.
- **Managed default:** he fights fairly but accepts sole blame to preserve the Red Brass Bench.
- **Overproof:** he permits a fixed condition, throws the bout, or treats Lio's pain as another test.

Elara may recover the bookmaker ledger. Zafir may expose the liability structure. Neither can decide what Tavio does in the ring.

### Act III

- **Measured and Prepared:** Tavio sounds the horn before the forge becomes his final arena and qualifies as an independent road examiner.
- **In every route, played or autonomous:** he declines Steffen's public challenge and is read as a coward or a has-been for it. `tavio_declined_challenge` is always true; see [[Meran-Style]].
- **Managed default:** he saves the Great Forge only after Hella or ducal authority orders evacuation, becoming a supervised load tester.
- **Overproof:** he delays for spectacle, conceals a failed measure, or abandons evacuation for one impossible hold.

Bernard may protect an evacuation lane. Ilyana may carry warning signals. Neither can sound Tavio's moral halt for him.

## Stable-Colleague Route

With no personal engagement, Tavio performs ordinary proof and training under existing Great Forge stop rules. He does not push a secret test, fight Lio, confront Steffen as a claimant, or turn the forge leak into a private proving ground. Those seasonal incidents change through their public authorities.

He reaches summer as a capable Lancewright whose Fifth Ring responsibility and arena future remain unresolved. He is neither a martyr nor a supervised mascot. Changed re-entry uses current equipment, workers, and public standing rather than replaying the expired bout unchanged.

## Changed Re-entry

### The Cracked Batch

Missing Act I opens a winter aftermath around the injured worker, destroyed samples, and remaining fittings. Tavio may recall the surviving batch and compensate the worker, but cannot restore the lost records or Act I rewards.

### Bout After Snow

Missing Act II opens a spring repudiation aftermath built around the filed record, Lio's final terms, and a public proof demonstration rather than a replay of the winter bout. Tavio may withdraw his sole-blame statement, preserve one witness, and complete a rigorous changed field examination that unlocks [[Lancewright]] for the current campaign and account.

The re-entry cannot restore the winter result, relationship opportunity, Selective Yield reward, or lost public evidence. A tracked transition warning names those time-specific losses before confirmation.

### Act III

Missing the Act III finale fixes a settlement only when the player tracked Tavio into a declared forge course and then declined its conclusion. An untracked Tavio reaches summer as a working Lancewright and unresolved colleague. [[The Road Examiner]] reflects whichever state the playthrough actually established.

## Embedded Opportunities

| ID | Context | Authored effect |
|---|---|---|
| TV-E01 | [[Fort Tannbruck Main Quest|Fort Tannbruck]] | reads a loaded bridge mechanism and names a safe stop |
| TV-E02 | [[The City in Siege]] | uses Brace and Cast to reopen an evacuation lane |
| TV-E03 | [[The Land Reclaimed]] | distinguishes Muster cadence from ordinary proof feedback |
| TV-E04 | [[The Equipment Account]] | rejects Koss's request to deploy unfiled fittings |
| TV-E05 | [[Holdfast Without Orders]] | supports local stop authority under ducal pressure |
| TV-E06 | Hammer Ward local story | recognizes a false proof demonstration and changes worker access |
| TV-E07 | Highlake local story | uses a control sample to settle an ore dispute |
| TV-E08 | Cold-Iron discovery | identifies a lawful old test chamber and a hidden overproof scar |
| TV-E09 | Blackjack Yard fair | hosts declared handicaps and gives an absurd prize |
| TV-E10 | Public challenge encounter | permits, reframes, or refuses a contest according to safety and direction |

## Outcome Requirements

### Resolved

Tavio must:

- admit he knowingly used the Fifth Ring;
- recall or expose the unsafe endorsed batch;
- honour Lio's independent choice and the filed bout result;
- expose the Red Brass Bench without falsely taking sole blame;
- establish worker stop authority;
- sound the leak horn before continued proof becomes catastrophic;
- accept a permanent arena ban.

He becomes an independent road examiner and retains his delight in games, crowds, and competition.

### Compromised

Tavio performs real safety work but requires external supervision, protects part of the Bench, accepts sole blame, delays the halt, or treats restitution as another public performance.

### Broken or Departed

Tavio fixes another contest, silences Lio or a worker, deploys unsafe hardware, conceals the leak, or returns to an unregulated circuit after refusing a warned repair.

## Navigation

- [[Tavio Meran]]
- [[Tavio Field Familiarity and Relationships]]
- [[Tavio Lancewright Package]]
- [[Tavio Banter and Reactivity]]
- [[Lancewright]]
- [[Lio Varcen]]
- [[Red Brass Bench]]
- [[Companion Campaign Architecture]]
- [[Companion Autonomy and Act Convergence]]
- [[Companion Campaign Expansion Register]]
- [[Narrative State Register]]
- [[Companions MOC]]
