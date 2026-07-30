---
type: quest
status: draft
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Hammer Ward", "Old Market"]
culture: ["Vortharan", "Sestaran", "Eclessian"]
related_factions: ["Blackjack Corps", "Great Forge", "Red Brass Bench"]
appears_in: ["Grenzburg"]
needs:
  - final wording of the needling exchange, the controlling lines, and the declined challenge at scene pass
tags: [narrative-rewrite]
quest_class: companion
act: act-3
availability_window: ["Open Thaw", "Spring Reclamation"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["tavio_field_inspection_ledger", "steffen_state", "pit_gear_state", "tavio_declined_challenge", "tavio_direction"]
reward_unlocks: ["Road Proof", "Field Yield"]
required_locations: ["Hammer Ward", "Great Forge", "Old Market"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-operation
companion_campaign_stage: act-3
quest_owner: "Tavio Meran"
quest_sequence: 8
companion_id: "CMP-07"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: preparation
relationship_variant: ""
preparation_inputs: []
preparation_threshold: ""
encounter_deck: []
postgame_season: ""
estimated_hours: 0.75
gameplay_pillars: [investigation, social, pursuit, technical-proof]
required_states: ["tavio_act2_chapter_resolved", "open_thaw_active"]
optional_state_inputs: ["tavio_fair_bout_result", "lio_varcen_state", "red_brass_exposure", "hella_dorn_trust", "yard_fair_state", "unsafe_lancewright_fittings_state"]
companion_required: "Tavio Meran"
duo_quest: false
pause_points: ["Chain Traced"]
autonomous_deadline: "The Deep Muster"
autonomous_resolution: "Tavio confronts Steffen alone, is baited, and half-accepts the challenge before Hella intervenes. The gear is partly recalled, Steffen is estranged, and the inspection ledger is incomplete."
changed_reentry: "Horn for Leak-Day opens with unrecalled Meran-style fittings in the forge crews' hands"
ensemble_inputs: ["Ylva Winter-Track", "Ilyana Veshkar", "Bernard Valeon", "Zafir ibn Samad"]
identity_hooks: ["Military", "Merchant/Craft", "Peasant/Labour", "Underworld", "Lancewright"]
emotional_rewrite_status: cleared
dialogue_status: pending-rewrite
remote_claim_status: compliant
archetype_pressure: "Replacement and decline: test whether Tavio can refuse a contest in front of a crowd that reads refusal as cowardice."
emotional_function: "Stage the public stop that feels like defeat, and put his name on a hazard he cannot fight."
pleasure_beat: "Pit-night noise, an outrageously good nineteen-year-old, and the specific joy of watching someone do your own trick better than you did at that age."
care_beat: "Tavio offers a fair ladder instead of a lesson, and lets the crowd think what it likes."
player_archetype_hooks: ["Cheerleader", "Tomboy", "Goth", "Bohemian", "Jock", "Nerd", "Rebel", "Goofball", "Grey"]
persistence_scope: regional-persistent
---
# Meran-Style

## Quest Function

This is Tavio's Act III operation and the campaign's promised **public stop that feels like defeat.** It produces `tavio_field_inspection_ledger` for [[Horn for Leak-Day]] through the pit-gear supply chain, and it stages the two things his campaign never had: someone younger wearing his style, and a refusal that costs him a crowd.

It replaces the archived *Measure on the March*. The Muster-plate beat from that quest migrates into Horn for Leak-Day's opening.

## Premise

The first spring since the siege lifted brings the reclamation games — licensed, ducal, respectable — and, underneath them, pit nights in the Hammer Ward yards, which are none of those things and much better attended.

**Steffen Krall** is winning them in Meran-style: spear, proof gauntlet, arena flourishes off eight years of bout bills. He is nineteen and he is *good.*

His gauntlet is the private demonstration piece that left the Old Market auction in [[The Signed Measure]]. His rings are knockoff Red Brass from the recalled batches, bought cheap from a Hammer Ward fence — cheap because they carry a Meran endorsement the sellers still believe means quality.

Hella traces a cracked ring from a pit injury back to the endorsement chain and asks Tavio to find the supply and stop it. He has no authority to stop anything, and everybody in the yards knows it.

## Beat One: The Crowd, Lost

The party attends a pit night.

**Steffen must be sold as gifted, not reckless.** He wins cleanly; the crowd is right to love him; Tavio watches somebody perform his own trick better than he could at that age and is visibly, complicatedly delighted for about ninety seconds.

Then Steffen recognizes him, and plays to the room, and the needling is affectionate and lethal:

> **Steffen:** You said a halt is part of the bout.
>
> *(beat, to the crowd)*
>
> **Steffen:** You never called one.

He is correct, and the crowd knows it, and they laugh.

**The Lovable Captain register fires.** Tavio jokes; the jokes thin; the jokes stop; and then three sentences come out of his mouth that are drill-sergeant, rank-pulling, and ugly — an old champion telling a crane-hand what he has earned the right to say. The room sides with the kid. Nobody swings at anybody, and it is much worse than a fight.

The player may interrupt, let it run, or pull him out. None of it un-says the sentences.

## Beat Two: The Chain

Investigation through Hammer Ward pit culture, no combat required and none forbidden:

- the fence who sold the rings, and the batch stamps he cannot read but kept;
- the auction paper trail from Old Market to the pits;
- three other fighters carrying batch gear, one of whom has a hand that will not close properly;
- the bout brokers taking bets on gear they cannot certify.

Every route reaches the same legible picture, and it yields `tavio_field_inspection_ledger`.

### Pause Point: Chain Traced

The quest may pause once the supply is mapped. The pits continue running.

## Beat Three: The Refusal

Steffen will not surrender the rings.

His reasons are self-interested, reasonable-shaped, and not a seminar: the gauntlet is the only ladder out of a crane yard he has ever found, purses are the only money, and an old champion preaching limits sounds precisely like a man closing a door behind himself. He says that last part out loud, in public, and it lands.

No social check converts him. No dialogue option makes him grateful.

## Beat Four: The Challenge, and the Stop

Steffen makes it a spectacle, because he is nineteen and it is a good idea:

> Beat me and the rings are yours.

The trap is total, and every wall of it is something Tavio wants or fears:

- fighting is the thing he loves most in the world;
- the arena ban he must accept — if his Act II reckoning went honestly — forbids exactly this;
- winning proves nothing except that a thirty-year-old can beat a nineteen-year-old, and it might cripple the boy through the very gear at issue;
- **the tremor makes it genuinely dangerous for Tavio**, and he cannot say so without producing an excuse-shaped truth in front of a crowd that has already decided he is making excuses.

**Authored beat, all routes: Tavio declines.** In front of everyone. He does not explain the ban well, he does not mention his hand, and he does not get a speech.

> **Tavio:** No.
>
> *(The crowd waits for the rest of it. There is no rest of it.)*
>
> **Tavio:** A halt is part of the bout. Anyone can continue.

He performs his own maxim at maximum personal cost, and the room reads it exactly as cowardice or as decline — the two readings the Jock archetype fears most, arriving together, from people he wanted to inspire.

The player's role is response, not prevention. The act is his.

## Beat Five: The Teach

The path that exists **because** he declined:

- **Prove the gear honestly.** Hella tests a knockoff ring on the frame, publicly, with Steffen watching. It fails. The wall of liars gains a piece, and the thing Tavio could not win by fighting is settled by a measurement nobody can boo.
- **Offer the fair ladder.** Filed bouts, an examiner's word, apprentice training, a sponsor who is not a fence. Tavio can offer it plainly, offer it as a favour, or offer it as a lecture — and the difference decides whether Steffen takes it, spurns it, or takes it *resentfully*, which is its own outcome and not a failure.

`tavio_direction` moves on whether he taught or performed teaching.

## End: Residue

The crowd does not come back to Tavio's side. That is not a fail state; it is the piece.

What exists at the end is a fair route for a gifted kid, a supply chain broken, a ledger Hella can use, and a man who gave up the last thing he was still good at in public and got booed for it.

Nobody thanks him. Steffen, if he takes the ladder, is graceless about it for at least a season.

## Outputs

- `tavio_field_inspection_ledger`: complete, partial, or lost;
- `steffen_state`: examiner-apprentice, licensed fighter, injured, or estranged;
- `pit_gear_state`: recalled, partly-recalled, or circulating;
- `tavio_declined_challenge`: true in every route (autonomous included);
- `tavio_direction` movement.

## Rewards

- **Road Proof** and **Field Yield**, as previously sourced from the archived operation;
- Act III finale preparation.

## Fail-Forward

- A lost fence trail leaves the batch stamps on recovered rings.
- Circulating gear strengthens the Horn for Leak-Day opening and injures a named forge crewman in spring.
- An estranged Steffen keeps fighting; the bounded follow-up is a summer encounter, not a respawn.
- If the party never attends the pit night, Hella files what she has and the ledger enters the finale partial.
- **No route lets Tavio win the crowd back by fighting.** There is no hidden option, exhibition, or demonstration bout that reverses Beat Four.

## Archetype Chemistry

- Jock/Cheerleader players feel the managed-out humiliation immediately and may push him toward the fight — the entitled reading is theirs to make attractive.
- Tomboy/Rebel players may want the pits left alone entirely, which is a defensible position with a named cost.
- Goth/Nerd players will spot the injured fighter's hand before anyone mentions it.
- Bohemian/Goofball players can make the honest proof into a piece of theatre good enough to beat a fight.
- Grey receives the complete practical exchange about stamps, fences, and who signs a licence.

## Navigation

- [[Tavio Companion Campaign]] · [[Tavio Meran]]
- [[Steffen Krall]] · [[Proof-Mistress Hella Dorn]] · [[The Signed Measure]]
- [[Horn for Leak-Day]] · [[The Examiner]]
- [[Hammer Ward]] · [[Red Brass Bench]]
