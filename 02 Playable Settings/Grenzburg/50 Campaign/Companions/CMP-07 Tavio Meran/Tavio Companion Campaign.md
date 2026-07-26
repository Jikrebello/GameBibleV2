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
emotional_rewrite_status: pending-paired-pass
dialogue_status: pending-rewrite
---
# Tavio Companion Campaign

This note remains the structural authority for Tavio's sequence, deadlines, preparation, autonomy, and rewards. [[Companion Emotional Rewrite Audit]] now supersedes its scene-level emotional assumptions. It is not implementation-ready until the Ylva-Tavio paired pass clears its emotional and dialogue status.

This is the controlling authority for Tavio Meran's eleven authored pieces, ten-piece playthrough ceiling, preparation ladders, autonomous decisions, changed re-entry, progression, and outcomes.

[[Tavio Meran]] controls character canon. [[Tavio Field Familiarity and Relationships]] controls approval and intimacy. [[Tavio Lancewright Package]] controls companion combat, while [[Lancewright]] controls the player vocation.

## Campaign Thesis

Tavio's story asks whether a brilliant competitor can remain joyous, daring, and technically ambitious after accepting that agreed limits are part of mastery.

His old defence is:

> If I carried the risk and still won, I earned the right to take it.

The campaign tests four truths:

1. An opponent's body is not part of Tavio's wager.
2. A stop authority must be able to stop the proof.
3. Accepting sole blame may still protect a corrupt institution.
4. A fair defeat is not a performance of remorse.

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
| 8 | CMP-07-A3-O | [[Measure on the March]] | Act III operation | normal party | 0.75 |
| 9 | CMP-07-A3-F | [[Horn for Leak-Day]] | Act III finale | player and Tavio | 2.25 |
| 10 | CMP-07-S | [[The Road Takes the Measure]] | summer coda | normal party or changed encounter | 0.5 |

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
| `tavio_field_inspection_ledger` | [[Measure on the March]] | reveals which fittings must be isolated |
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

## Deterministic Autonomy

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
- **Managed default:** he saves the Great Forge only after Hella or ducal authority orders evacuation, becoming a supervised load tester.
- **Overproof:** he delays for spectacle, conceals a failed measure, or abandons evacuation for one impossible hold.

Bernard may protect an evacuation lane. Ilyana may carry warning signals. Neither can sound Tavio's moral halt for him.

## Zero-Participation Route

With no player involvement:

1. Tavio recalls most unsafe gear but causes one avoidable testing injury.
2. He fights Lio fairly while accepting sole blame to preserve the Red Brass Bench.
3. He saves the Great Forge only after an external evacuation order.
4. He becomes a supervised load tester rather than an independent road examiner.

This is a stable compromised outcome, not future-setting canon. Tavio cannot die unseen.

## Changed Re-entry

### The Cracked Batch

Missing Act I opens a winter aftermath around the injured worker, destroyed samples, and remaining fittings. Tavio may recall the surviving batch and compensate the worker, but cannot restore the lost records or Act I rewards.

### Bout After Snow

Missing Act II opens a spring repudiation aftermath. Tavio may withdraw his sole-blame statement and preserve one witness.

It cannot unlock [[Lancewright]], restore Act II progression rewards, or reopen romance and sworn bond. A tracked transition warning states this before confirmation.

### Act III

Missing the Act III finale fixes Tavio's autonomous settlement. [[The Road Takes the Measure]] reflects it without reopening the judgement.

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
