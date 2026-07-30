---
type: reference
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg"]
culture: ["Vortharan", "Sestaran"]
related_factions: ["Blackjack Corps", "Red Brass Bench"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
companion_id: "CMP-07"
architecture_status: migrated
---
# Tavio Field Familiarity and Relationships

## Purpose

This reference controls Tavio's authored familiarity, approval, conflict, friendship, heterosexual romance, same-sex sworn bond, and permanent rewards.

## Field Familiarity

Tavio advances through distinct experiences, not time spent in the active party. A qualifying beat includes:

- a public or private contest with disclosed rules;
- a worker-safety or equipment decision;
- an accepted defeat or voluntary halt;
- a difficult movement or large-monster success;
- a craft investigation;
- a rescue in which performance is abandoned for safety;
- a faction choice involving emergency authority;
- a named main-story contribution.

Idling, repeated jobs, repeated arena games, camp cycling, and reloading the same encounter do not count.

## Approval States

| State | Presentation |
|---|---|
| Guarded | charming, performative, and careful not to admit the whole measure |
| Open | shares technical fear, asks the player to act as second, and accepts small corrections |
| Trusted | permits a real halt, speaks without a crowd, and receives an outcome he did not stage |
| Strained | turns concern into insult, hides a load, or treats the player as an audience rather than a second |

Approval never replaces `tavio_direction`. A likeable Tavio may remain managed or overproof.

## Warned Conflicts

Major conflicts arise from:

- knowingly deploying unsafe equipment;
- forcing a bout after Lio withdraws;
- fixing a result;
- killing a yielded opponent;
- overriding worker stop authority;
- destroying evidence to preserve the Red Brass Bench.

The first major breach creates a direct confrontation and a specific repair. Refusing that repair may lock Trusted approval or cause departure.

## Universal Friendship

[[Games Without a Crown]] is available after the Act I finale at Open approval or better. It contains no villain, sabotage, or moral trap.

Tavio and the player run a fair for debtors, forge families, and refugees. The player may compete, officiate, cook, or invent prizes. The point is to experience Tavio's appetite for games without a crown, a rigged measure, or a body at stake.

Friendship remains available regardless of player sex or later relationship choice.

## Commitment

Commitment requires:

- Trusted approval;
- personal completion of [[The Fair Defeat]];
- no unresolved major violation;
- an available global relationship slot.

A female player may choose romance. A male player may choose sworn bond. The paths are mutually exclusive for Tavio and do not share a quest.

`tavio_relationship_commitment` uses `none`, `friendship`, `romance-committed`, or `bond-committed`. The Act II choice writes the state explicitly; approval never assigns it automatically.

### Romance

[[No Wager Between Us]] presents Tavio as a suitor rather than a performer. He asks plainly and accepts refusal without turning it into a challenge.

- **Duo move:** **Fair Challenge**, allowing one partner's perfect answer to open an empowered reply.
- **Upgrade:** **Fair Challenge: Answer Freely**, adding protected repositioning before the reciprocal marked-target strike.
- **Permanent non-slot perk:** **No Wager Between Us**, rewarding coordinated alternating attacks without increasing overproof capacity.
- **Act III bonus:** `tavio_courtship_measure_practiced`, preventing one equipment or evacuation failure in [[Horn for Leak-Day]].

### Sworn Bond

[[After the Last Lantern]] is a completely platonic brotherhood between trusted seconds. It contains no romantic framing, courtship, rings, or fade to black.

- **Duo move:** **Fair Return**, sharing a bounded captured-force opportunity with the second who did not make the counter.
- **Upgrade:** **Fair Return: Second's Halt**, allowing either sworn brother to cancel one overcommitted action into a guarded Yield.
- **Permanent non-slot perk:** **Second's Word**, rewarding a timely cancel, guard, or retreat after a companion warning.
- **Act III bonus:** `tavio_seconds_halt_practiced`, preventing the same single failure in [[Horn for Leak-Day]].

The Act III bonuses cannot stack. Missing an exclusive episode does not end a commitment, but forfeits its upgrade and safeguard.

## Relationship Limits

- One committed romance and one committed sworn bond may exist per playthrough.
- Romance and bond rewards are mechanically equivalent, not identical.
- Neither path is required for Tavio's resolved moral outcome.
- Permanent perks remain learned after departure or chosen sacrifice.
- Duo moves require Tavio in the active party.
- Exact numerical values remain provisional.

## Seasonal Conversations

- **Autumn:** boasts, workshop games, first admission about Lio.
- **Winter:** fear of a public defeat, concern for unsafe siege fittings.
- **Spring:** whether sounding the horn is mastery or surrender.
- **Summer:** games without title, road inspection, or a return to spectacle depending on outcome.

## Spec-Pass Hooks

**Approval movement added by the [[Tavio Rewrite Spec]] pass:**

- filing the hand at the bout filing in [[The Fair Defeat]] rather than concealing it;
- leaving an honest bout record alone afterward — declining the sympathetic reframe, the corrected bill, the interview;
- refusing the sole-blame settlement after reading Maro's letter, and refusing it without contempt for the man who wrote it;
- offering [[Steffen Krall]] the fair ladder plainly rather than as a lecture;
- naming the hand at the proof gauntlet in [[Horn for Leak-Day]].

**A player-second who learns about the tremor and stays silent** receives one line of reckoning from Hella after the bout. It is not an approval penalty; it is a note in the file.

`tavio_declined_challenge` is true in every playthrough and is not an approval event. Being read as a coward by a crowd is the cost of the act, not a judgement on the player.

## Navigation

- [[Tavio Companion Campaign]]
- [[Tavio Meran]]
- [[Games Without a Crown]]
- [[No Wager Between Us]]
- [[After the Last Lantern]]
- [[The Fair Defeat]]
- [[Horn for Leak-Day]]
- [[Companion Constitution]]
- [[Companion Field Familiarity and Duo Quest Standard]]
