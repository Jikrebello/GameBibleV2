---
type: quest
status: draft
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Old Market", "Crown Heights"]
culture: ["Eclessian", "Virelian"]
related_factions: ["Blackjack Corps", "Medori Bank", "House Velescar"]
appears_in: ["Grenzburg"]
needs:
  - final wording of the joke, the rebuke, and the toast at scene pass
tags: [narrative-rewrite]
quest_class: companion
act: act-3
availability_window: ["Spring Reclamation"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["elara_coalition_ready", "perle_state", "player_laughed_at_perle", "elara_dethronement_complete", "reclamation_feast_state", "coalition_delegate_state", "elara_direction"]
reward_unlocks: ["Held From the Edge"]
required_locations: ["Old Market", "Blackjack Yard", "Hall of Petitions"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-operation
companion_campaign_stage: act-3
quest_owner: "Elara Velescar"
quest_sequence: 8
companion_id: "CMP-01"
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
estimated_hours: 1
gameplay_pillars: [social, investigation, protection, pursuit]
required_states: ["elara_act2_resolution"]
optional_state_inputs: ["elara_winter_company_ready", "winter_company_roster_state", "elara_public_credit_state", "vardek_second_letter_read", "four_hearth_compact_form", "underworld_branch_low_lantern"]
companion_required: "Elara Velescar"
duo_quest: false
pause_points: ["Programme Fixed"]
autonomous_deadline: "The Deep Muster Main Quest"
autonomous_resolution: "The feast proceeds without the player. Elara is needled, makes the joke anyway, and the substitution partly succeeds: the coalition is functional rather than ready."
changed_reentry: "No Lady of Velescar begins with fewer enforceable household terms and a coalition that does not fully trust her."
ensemble_inputs: ["Ashira bath Melan", "Bernard Valeon", "Dismas Raben", "Ilyana Veshkar", "Tavio Meran", "Zafir ibn Samad", "Ylva Winter-Track"]
identity_hooks: ["Nobility", "Merchant/Craft", "Peasant/Labour", "Underworld", "Scholarly"]
emotional_rewrite_status: cleared
dialogue_status: pending-rewrite
remote_claim_status: compliant
archetype_pressure: "The room continues without her: test whether she can hand power to people who no longer need her holding it, on the day she discovers they do not."
emotional_function: "Stage the public loss she cannot style, and the one cruelty the player watches her commit."
pleasure_beat: "A city's first party since the siege — ribbons on scaffolding, terrible spring wine, a delegate's daughter dancing badly and being adored for it."
care_beat: "Elara spends her knowledge, contacts, and standing from the margin of a room she is not running."
player_archetype_hooks: ["Cheerleader", "Tomboy", "Goth", "Bohemian", "Jock", "Nerd", "Rebel", "Goofball", "Grey"]
persistence_scope: regional-persistent
---
# Uninvited

## Quest Function

This is Elara's Act III operation and the campaign's promised public loss. It establishes the Velescar coalition in Grenzburg's civic view, produces `elara_coalition_ready` for [[No Lady of Velescar]], and contains the one act of present-tense cruelty the player witnesses her commit.

Nobody in this quest wrongs Elara. That is its subject.

## Premise

Spring. The Old Market and the Yard stage the Reclamation Feast — the city's first occasion since the siege lifted, half thanksgiving and half advertisement that Grenzburg is open for trade. Its civic function is the public presentation of the Velescar household delegates: **Mira Spoke** the carter, **Olek Sar** the burial conservator, and **Hanne Wirth** the cooperative organizer, who need to exist in front of witnesses before the Old Tithe Vault is opened.

Elara assumes she is hosting. Occasions are her form; she has hosted every gathering the Yard has managed since autumn.

Two things have happened while she was being useful.

The first is the whisper. Vardek's agents have spent the winter suggesting that the grave lady still works for her patron, and the guild sponsors funding the feast have decided — politely, without malice, in a conversation she was not in — that the delegates' first appearance should not be attached to her name.

The second is worse. The [[The Winter Company|Winter Company]] worked. The rescue captains she named, trained, and gave real authority to can run an occasion without her, and are visibly delighted to be doing it.

**She has been managed out by prudence and by her own reform.** Both are correct.

## Party and Staging

Normal party; Elara required, never the only route. No new locations: the programme is fixed at the Yard, the feast occupies the Old Market, and the substitution attempt reaches the Hall of Petitions.

No preparation assets are required. `elara_winter_company_ready` and `winter_company_roster_state` from Act II determine how competent the network is when the crisis lands, and `elara_public_credit_state` determines how gracefully the sponsors decline her.

## Beginning: Managed Out

Three planning scenes, in any order, each of which Elara is thanked in and given nothing:

- **The programme.** A guild wife and a relief captain — one of Elara's own winter captains — set the running order. They ask her advice about the toast and then assign it elsewhere, warmly, for reasons they do not state and the player can work out.
- **The delegates.** Hanne refuses a sponsor's suggestion that Elara present them; she has refused Elara's public escort once before and her reasoning has not changed. Mira does not care either way and says so while loading crates. Olek wants to know who is guarding the record tubes during the dancing, which nobody has thought about.
- **The seating.** Perle Winkel is helping with the linen and has opinions about the linen, at length, and is the only person in Grenzburg entirely delighted that Elara is there.

Elara's stress tell runs on script through all three: ceremonial politeness escalating, speaking for other people, improving arrangements nobody asked her to touch. The player can interrupt, let it run, or hand her something useful to do. None of it changes the programme.

### Pause Point: Programme Fixed

The quest may pause once the running order is set. The feast does not begin until the player returns.

## The Feast

Ribbons on scaffolding. Spring wine that everyone agrees is terrible. A delegate's daughter dancing badly and being adored for it. Elara is a guest, and she is very good at being a guest for about forty minutes.

Then the needling starts, and it is ordinary: a guild wife mentions the scandal at conversational volume within earshot; someone asks Olek whether the grave lady picked him personally; the toast she was not given is given, well, by someone she trained.

Perle is attached to her arm, describing the linen.

## The Joke

**Authored, fixed, all routes, including the autonomous one.**

Elara makes one perfectly shaped joke at Perle's expense. Loud enough to carry, affectionate in form, and precisely engineered — Perle's endless talk, her hopeless devotion, the ribbon on the apron — so that the room can laugh at somebody who is not Elara.

The joke must be genuinely funny on the page. If it is not funny, the scene does not work.

The room laughs. **The player is offered the chance to laugh, and it is written as the warm, natural, socially correct response** — the option a person takes at a party without thinking. There is no prompt indicating a test, no approval icon, no pause. `player_laughed_at_perle` records it and is never mentioned again until the coda.

Perle understands in stages. That is the cruelty — not the sentence, but the four seconds while her face works out what has happened to her. She does not answer. She puts the linen down.

## The Turn

The laugh curdles within the minute, and not on Perle's behalf: the room has just watched the grave lady be cruel to a harmless woman, which confirms the story the sponsors were too polite to say out loud.

Elara attempts to style it. This is the campaign's first **failed performance**, and it is authored to fail:

- a toast — she is not given the floor;
- a public generosity — it reads as payment;
- a rearrangement — the captains have the programme and do not need her.

The room continues. Nobody hands her a recovery. Nobody is cruel to her either, which is worse; they simply carry on with an occasion that is going well.

## The Rebuke

Private, brief, unornamented. [[Ashira bath Melan]] holds the campaign's only licence for the surgical register, and this is what it is for.

> **Ashira:** You made the room lighter.
>
> *(Elara waits for the rest of it.)*
>
> **Ashira:** It was the room you wanted lighter. Not her.

If Ashira is unavailable in this playthrough state, [[Quartermaster Brina Kest|Brina]] delivers a shorter, blunter variant with no rhetorical shape at all. Neither of them stays to discuss it.

## The Operative Spine

Mid-feast, Vardek's local agents move, and the quest becomes work:

1. **The staged seizure.** A purchased writ boxes Mira's wagon in at the Old Market gate with the transport and remittance terms inside it. The writ is technically defective and the defect is findable.
2. **The substitution.** A courier attempt on the instruction packet at the Hall of Petitions, timed to the dancing, using a clean "household consent" copy.
3. **The delegates.** Olek's record tubes and Hanne's route are both exposed while the guards are watching the wine.

**The network answers.** Winter Company captains, Yard porters, and the delegates' own prepared people act on their own authority, in parallel, without waiting for instruction. The player fights, runs, argues, and unpicks the writ alongside them.

Elara's playable choice sits underneath all of it, and the quest never names it:

- **Feed it from the margin.** She spends what she has — the defect in the writ, the name of the solicitor's clerk, which gate captain owes her, where a courier would hide a packet in that building — into other people's hands, and lets them run it. Slower. Untidy. Nobody thanks her. Supports `accountable`.
- **Take the centre.** She stands up, names the crisis, and runs the response herself, brilliantly, in front of everyone. **It works.** The wagon is freed, the packet is saved, the room remembers who she is, and the sponsors are relieved. This is the trap: the grab succeeds as spectacle and *costs coalition readiness*, because delegates who were about to become independent have just been rescued by a patron. Supports `entitled`.

Preparation and play determine the material result. The direction is determined by which hands the work went through.

## End: Residue

The feast succeeds. It is remembered as the night the city reopened.

The toast was given by someone else. The delegates were presented and are now real in the civic record. Somebody else's name is on the evening.

Perle is not at the linen table. Her apron is on the chair with the ribbon off it.

Elara says nothing styled about any of it. If the player laughed, Perle is different with them too from this point, and neither the game nor Perle explains why.

## Outputs

- `elara_coalition_ready`: ready, functional, curated, or broken;
- `perle_state`: **wounded** — fixed, all routes; see [[Perle Winkel]];
- `player_laughed_at_perle`: true or false;
- `elara_dethronement_complete`: true;
- `reclamation_feast_state`: celebrated, marred, or disrupted;
- `coalition_delegate_state`: individual states for Mira, Olek, and Hanne;
- `elara_direction` movement.

## Rewards

- **Held From the Edge** — an Elara field behaviour: when the player is directing another ally or NPC action, Elara supplies one piece of concrete local knowledge instead of taking the action herself. It does nothing she could not have done in person; that is the joke and the point.
- Act III preparation asset `elara_coalition_ready`.
- Preparation toward **The Last Claim** through [[No Lady of Velescar]].

## Fail-Forward

- A lost wagon delays Mira's terms; they arrive by proxy at greater cost.
- A successful substitution puts a false consent copy in the vault as leverage.
- An exposed route wounds or delays a delegate; none is erased.
- If the party withdraws entirely, the network saves most of it and the coalition is `functional`.
- Public violence at the feast reduces hearing legitimacy and creates witnesses.
- **No outcome undoes the joke, and no outcome permits its repair.** This is intentional; see [[Elara Companion Campaign]].

## Archetype Chemistry

- Cheerleader/Jock players recognize the managing-out immediately and may push her to fight for the room — the entitled route is theirs to make attractive.
- Tomboy/Rebel players may find the whole occasion contemptible and miss that it is a working institution.
- Goth/Nerd players see Perle's usefulness before anyone else and can say so before the joke, which changes nothing.
- Bohemian/Goofball players can improvise the crisis response brilliantly from the edge.
- Grey receives the complete practical exchange about writs, couriers, and who holds the packet.

## Navigation

- [[Elara Companion Campaign]] · [[Elara Velescar]]
- [[Perle Winkel]] · [[Ashira bath Melan]] · [[The Winter Company]]
- [[No Lady of Velescar]] · [[The Velescar Correspondence]]
- [[Old Market]] · [[Crown Heights#Anchor Locations|Hall of Petitions]]
