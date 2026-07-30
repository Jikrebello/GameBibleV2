---
type: quest
status: draft
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Ledger Quays", "Korrheim"]
culture: ["Eclessian", "Korrheim", "Fiorenzian"]
related_factions: ["Blackjack Corps", "Medori Bank", "Low Lanterns"]
appears_in: ["Grenzburg"]
needs: []
tags: [narrative-rewrite]
quest_class: companion
act: act-2
availability_window: ["Deep Winter", "Early Spring"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["dismas_act2_chapter_resolved", "dismas_act2_result", "dismas_act2_finale_played", "dismas_direction", "dismas_charge_filed_state", "sella_etten_response", "dismas_legal_debt_state", "dismas_relationship_commitment", "cofounder_offer_state"]
reward_unlocks: ["Quarry-Wise", "relationship commitment"]
required_locations: ["Iron Ledger Counting-House", "Ledger Quays", "Blackjack Yard", "Hall of Petitions"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-finale
companion_campaign_stage: act-2
quest_owner: "Dismas Raben"
quest_sequence: 6
companion_id: "CMP-06"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: confrontation
relationship_variant: ""
preparation_inputs: ["dismas_passage_handoffs", "dismas_korrheim_registry_open", "dismas_route_notation_surrendered", "dismas_low_lantern_terms", "dismas_lask_task_kept"]
preparation_threshold: "2 participate; 3 all material objectives; 4 one safeguard"
encounter_deck: []
postgame_season: ""
estimated_hours: 1.75
gameplay_pillars: [investigation, social, protection, legal-process, moral-reckoning]
required_states: ["dismas_act1_chapter_resolved", "dismas_act2_readiness_viable"]
optional_state_inputs: ["koss_leash_result", "passage_state", "dismas_counting_heard", "brina_trust", "bank_rank"]
companion_required: "Dismas Raben"
duo_quest: true
pause_points: ["Registry Retrieved", "Names Established"]
autonomous_deadline: "Ghor at the Gate"
autonomous_resolution: "He never files. The registry stays closed, the count is never made, and the world remains perfectly content with a conviction smaller than the truth. The vocation unlock and relationship commitment close for the playthrough."
changed_reentry: "The Unfiled Charge"
ensemble_inputs: ["Ilyana Veshkar", "Zafir ibn Samad"]
identity_hooks: ["Underworld", "Scholarly", "Nobility", "Peasant/Labour", "Merchant/Craft"]
emotional_rewrite_status: cleared
dialogue_status: pending-rewrite
remote_claim_status: compliant
archetype_pressure: "Nobody is coming for him. Three clean exits are authored and open. The only thing that closes the gap is his own hand."
emotional_function: "Invert the courtroom — he opens the case against himself — and finish a count eleven years old."
pleasure_beat: "Bellandi's exact competence, a clerk enjoying a genuine puzzle, and the strange comedy of a highwayman commissioning his own prosecution."
care_beat: "He pays for the truth out of his own service credit and asks nobody to carry it with him."
player_archetype_hooks: ["Cheerleader", "Tomboy", "Goth", "Bohemian", "Jock", "Nerd", "Rebel", "Goofball", "Grey"]
persistence_scope: regional-milestone
---
# The Name on the Charge

## Quest Function

Dismas's Act II finale. The title's meaning is inverted from the archived outline: **the name on the charge is his own, and he is the one who puts it there.**

No survivor arrives. No warrant exists. No court is looking. This is the roster's only act of accountability that the world will never compel — and that is the design, because a man whose flaw is flight cannot be redeemed by being cornered.

## Premise

The Lask task is running. The passage is held or lost. Winter is breaking.

And the thing the ravine started has not stopped. He has been counting in his sleep since Split Pine; the number is three; and he has never known which three.

He goes to [[Claims-Factor Marco Bellandi]] and commissions an inquiry into the Korrheim rockfall of 1355 — passengers, survivors, estates, and the human cost the conviction never established. **Out of his own service credit,** the only currency he owns, at a price that measurably extends his contract.

> **Dismas:** I want to know how many. Then I want it written where the first number was.
>
> **Bellandi:** You understand this can only increase what you owe.
>
> **Dismas:** Yes.

## Party and Preparation

Accepting at the Counting-House forms the fixed player-plus-Dismas duo. Bellandi, clerks, and Korrheim correspondents are temporary actors.

| Asset | Concrete advantage |
|---|---|
| `dismas_passage_handoffs` | the passage runs without him for the weeks this takes |
| `dismas_korrheim_registry_open` | the old claim and estate entries are retrievable rather than reconstructed |
| `dismas_route_notation_surrendered` | his own marks corroborate the sequence — self-incrimination as evidence |
| `dismas_low_lantern_terms` | brokers cannot bury the inquiry as a favour to a friend |
| `dismas_lask_task_kept` | one household will stand surety for his character in a filing |

Two permit the inquiry. Three establish names, sequence, and filing intact. Four or five preserve one document through interference.

## The Tracing Is Played

Weeks of work, and the player does it:

- **the registry** — Bellandi's Korrheim correspondence, honest about time: three weeks each way, a clerk who wants a fee, a war on the roads. The quest spans a season edge and says so.
- **the notation** — his own route book from 1355, out of a Lowlands cache. Surrendering it is voluntary and irreversible, and it is the most self-destructive act available to him anywhere in the campaign.
- **the estates** — Hedric Vane's family and the Bekks, as ledger entries with addresses and an unpaid burial subscription.
- **the claim** — [[Sella Etten]]'s eleven-year-old civil filing against *persons unknown*, quoted whole in [[The Stonefall Papers]] and read on screen. Written in the register of expenses, because that is the register the form asked for. The last line is hers.
- **the interference** — Low Lantern brokers offer to disappear *the inquiry*: cheaper than disappearing a person, nobody hurt, everybody content. Koss separately wants it closed, because an enlarged claim complicates his asset.

### Pause Point: Registry Retrieved

## The Three Exits

**Authored, visible, genuinely available.** Each is clean and free in the short term, and nobody but Dismas stops him:

1. **Before the packet is opened** — Bellandi will return the fee and close the file at a word. The envelope goes in a drawer.
2. **After the names are read, before anything is filed** — knowing is not filing. He would be the only living person who knew, which is the position he has held for eleven years and knows exactly how to hold.
3. **After the cofounder's letter** — there is a boat at Reed Landing on the fourteenth, and there is always a boat.

The quest tracks whether the player pushes him toward any of them. None is a fail state and all three are in character.

## The Cofounder's Letter

Three weeks in, word travels, and the band's other planner writes — quoted whole in [[The Stonefall Papers]].

He offers to take it. All of it, in writing, to anyone Dismas likes: *I set the anchors, I gave the release, you were on the upper track with the glass and never touched it.* No warrant exists on either of them. A paper from him closes the business, and Dismas keeps his service, his road, and whatever he has built in Grenzburg.

**The offer is real, it costs nothing, and it is made out of loyalty.** It is also the fled ending in a gift's wrapping — the sole-blame temptation inverted, with somebody else volunteering to be the villain.

Accepting writes `cofounder_offer_state: accepted` and maps to `gone`, regardless of how the rest of the quest plays.

## The Names

The correspondence comes back, and the record is what it is:

- **Hedric Vane**, driver, fifty-one, killed by the fall;
- **Anke Bekk**, passenger, nineteen, who did not die at once;
- **Sella Etten**, survivor, dug out by the soldiers;
- one passenger thrown clear, unnamed, untraceable, and not a mystery this quest solves.

**The counterfactual does not arrive.** No examiner, engineer, witness, or expert establishes whether staying would have saved Anke Bekk. The stone shifted twice, the soldiers came within the hour, and the record supports both readings and settles neither — permanently, in every playthrough. **Do not write the resolution.**

### The Count

The spine completes here, and this rather than the filing is the quest's climax.

He asks for the room. Bellandi steps out. The player may stay or go, and the scene is written for either.

He counts them. Out loud. To the end. With names attached, for the first time in eleven years, without stopping at two.

*(Counting beat 3 of 4.)*

### Pause Point: Names Established

## The Filing

Then the choice — and the player names what they will and will not carry for him, which is the one line worth keeping verbatim from the archived outline.

- **Public filing.** The enlarged truth entered against his own conviction record at the Hall of Petitions, deaths named. Service extended; the record corrected; a man who has never signed anything signing something.
- **Sealed admission.** The same content under marcher oversight — real, binding, invisible. Liese holds it. It protects the network he is building, and the public record still lies.
- **Restitution only.** The estates paid from his credit, the deaths unfiled. Money without a name on it.
- **Suppression.** The inquiry ends and the envelope goes in a drawer. Available at every stage, and the interface never punishes it.

`sella_etten_response` is then fixed by what he actually filed: `record-accepted-no-contact`, `redirected-to-road-works`, or `no-response`. **She is never contacted, persuaded, or met.**

And the hardest thing in the quest sits underneath all four options: **she may not have known that a person caused it.** Eleven years of her life are built on a road that fell down, and his honesty hands her a man. He has to choose before he can learn whether that was repair or injury — and the campaign never tells him.

## Outcomes and Rewards

`dismas_act2_result`: **filed**, **sealed**, **paid**, or **buried**.

Record `dismas_charge_filed_state`, `sella_etten_response`, `cofounder_offer_state`, `dismas_legal_debt_state`, `dismas_direction`.

Personal completion — **the filing, not the outcome** — unlocks the Quarry-Wise custom vocation and opens relationship commitment: [[The Return Leg]] or [[The Missing Queen]].

## Fail-Forward

- A lost registry packet can be re-requested at cost and a season's delay.
- Brokers who bury the inquiry can be undone through Mara's terms, at the price of a favour.
- Koss's interference is procedural, not violent, and Bellandi outranks him on the file.
- If the player is absent, Bellandi proceeds correctly and Dismas stops at exit two.
- **Nothing here produces forgiveness,** and no branch makes the record smaller than it is.

## Navigation

- [[Dismas Raben]] · [[Dismas Companion Campaign]] · [[The Korrheim Rockfall]]
- [[Sella Etten]] · [[The Stonefall Papers]] · [[Claims-Factor Marco Bellandi]]
- [[The Return Leg]] · [[The Missing Queen]] · [[Tuesday]]
