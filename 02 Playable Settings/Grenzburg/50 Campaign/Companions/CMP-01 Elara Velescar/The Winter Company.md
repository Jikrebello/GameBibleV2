---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Lantern Ward", "Ledger Quays"]
culture: ["Eclessian", "Folk"]
related_factions: ["Blackjack Corps"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-2
availability_window: ["Siege Winter"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["elara_winter_company_ready", "winter_company_roster_state", "lantern_rescue_state", "elara_public_credit_state"]
reward_unlocks: ["A Lady's Exit"]
required_locations: ["Blackjack Yard", "Lantern Ward", "Ledger Quays", "Bridgehold"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-operation
companion_campaign_stage: act-2
quest_owner: "Elara Velescar"
quest_sequence: 5
companion_id: "CMP-01"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: preparation
relationship_variant: ""
preparation_inputs: []
preparation_threshold: ""
grounded_rewrite_status: approved
external_stakes: ["salvage custody", "crew safety", "winter rescue capacity", "living claims"]
banter_priority: contextual
player_interest_gate: none
missed_arc_treatment: changed-reentry
encounter_deck: []
postgame_season: ""
estimated_hours: 1
gameplay_pillars: [command-response, rescue, traversal, defense, siege]
required_states: ["elara_act1_resolution"]
optional_state_inputs: ["western_breach_state", "ropehouse_outer_state", "neda_elara_trust", "underways_route_access"]
companion_required: "Elara Velescar"
duo_quest: false
pause_points: ["Company Posted", "First Rescue Complete"]
autonomous_deadline: "Ghor at the Gate"
autonomous_resolution: "See Companion Autonomy and Act Convergence; untracked content uses stable-colleague treatment."
changed_reentry: "The Patron's Cabinet proceeds with reduced public witnesses and a weaker escape network."
ensemble_inputs: ["Ashira bath Melan", "Bernard Valeon", "Dismas Raben", "Ilyana Veshkar", "Tavio Meran", "Zafir ibn Samad", "Ylva Winter-Track"]
identity_hooks: ["Military", "Peasant/Labour", "Underworld", "Nobility", "Merchant/Craft"]
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
archetype_pressure: "Elara must build a company whose unglamorous stations matter as much as its visible rescues."
emotional_function: "Turn her social gift into material siege survival while testing whether everyone receives belonging and authority."
pleasure_beat: "Uniform scraps, call signs, gallows humor, and a rescue team discovering its rhythm."
care_beat: "Elara gives private or peripheral workers real authority rather than ceremonial praise."
player_archetype_hooks: []
persistence_scope: district-persistent
---
# The Winter Company

## Premise

After the western breach, Grenzburg has volunteers but no shared rescue language. Elara proposes a temporary company linking roof runners, stretcher crews, pump hands, cooks, lamp keepers, and message children old enough for safe station work.

The obvious version is magnificent and wrong: one famous flying squad around Elara. The useful version distributes prestige, supplies, and the right to call a withdrawal.

## Beginning: Names and Stations

At the Yard, players build four teams:

- **High Line:** roofs, ropes, and trapped upper floors;
- **Low Line:** cellars, smoke, and street extraction;
- **Warm Line:** receiving rooms, food, blankets, and identification;
- **Quiet Line:** signals, missing-person reports, and private effects.

Elara gives them stylish names. Neda asks whether Quiet Line can stop High Line from entering a room whose survivors asked for privacy.

The player chooses captains, replacement order, and who controls scarce climbing equipment. Background hooks alter methods, but every path can create a viable roster.

## Middle: Three Simultaneous Calls

The company receives three calls during one Grobi bombardment:

1. a lodging loft catches fire with residents on the roof;
2. a collapsed debtor cellar contains people nobody has counted;
3. a famous guild household sends a public plea from a visible balcony.

The normal party responds to one while assigned teams handle the others. Prior staffing and authority determine outcomes. The player can change course after new information, but abandoning a team without warning damages it.

Each rescue has action:

- High Line crosses awnings and a broken crane;
- Low Line moves through smoke, water, and unstable joists;
- Warm/Quiet Lines hold a receiving hall against panic, thieves, and a second collapse.

Human looters and Grobi skirmishers exploit the confusion independently. They are not secretly connected to Elara's past.

**The whisper starts here**, in the receiving halls, in the mouths of frightened people who are not lying on purpose: that the grave lady is still working for her patron, that the relief coming into the city has his name under it, that she was placed here. It is half-adjacent to a truth the player already knows — the offer exists, or is coming — and it cannot be refuted without conceding the rest. Elara hears it at least once and cannot correct it. By spring the sponsors of the Reclamation Feast will act on it, politely, without ever repeating it aloud.

## Elara's Test

A talented roof runner refuses Elara's public commendation because it would expose their Low Lantern work. A quiet kitchen captain needs coal, not applause. A Chapel-Folk stretcher crew refuses a route that leaves its own lodging unprotected.

Elara can:

- accept private competence and distribute authority;
- negotiate a real exchange;
- turn refusal into a charming scene and keep the original plan;
- punish the refusal by moving supplies toward the photogenic rescue.

Her decisive line is delivered while hauling a wet blanket, not during a tribunal:

> “I can make them cheer for you.”
>
> “I asked for coal.”
>
> Elara looks at the empty brazier. “Yes. You did.”

## End: The Company Without Her

The final incident traps Elara and the active party behind a fallen firebreak. The four teams must continue without her voice.

If authority was real, they:

- reroute a pump cart;
- open a casualty lane;
- send the Quiet Line to locate the party;
- complete two rescues before Elara returns.

If the company was curated around her, stations wait, improvise inconsistently, or compete to be the team she notices.

The success case is the campaign's quiet hinge. Elara comes out from behind the firebreak to find the work finished well by people who did not need her voice, and she is *proud* — genuinely, uncomplicatedly, this is the thing she wanted. Nobody notes that she has just built the machine that will make her unnecessary by spring. The scene must not hint at it. [[Uninvited]] collects.

The player and Elara escape through roofline, street, underways, or a physically cleared firebreak. Every vocation can complete the route.

## Fail-Forward

- A failed rescue changes named household and district survival but does not end the company.
- Lost climbing gear narrows the cabinet's later roof escape.
- A privacy breach creates a repair scene and removes one witness.
- If Elara is incapacitated, the roster's actual distribution decides survival.
- If the player abandons the operation, Elara completes the central rescue and leaves peripheral stations weak.

## Archetype Chemistry

- Cheerleader/Jock can strengthen team identity but may overvalue visible courage.
- Tomboy/Rebel can protect local autonomy but may leave coordination underbuilt.
- Goth/Nerd recognize invisible work and risk making people into a lesson.
- Bohemian/Goofball create flexible signals and must still make them legible.
- Grey receives a grounded exchange about staffing the least admired station.

## Outputs and Rewards

- `elara_winter_company_ready`: distributed, functional, centralised, or broken;
- `winter_company_roster_state`: named, partial, exposed, or dispersed;
- `lantern_rescue_state`: strong, mixed, costly, or failed;
- `elara_public_credit_state`: shared, private-respected, curated, or seized;
- unlock **A Lady's Exit**;
- supply Act II asset `elara_winter_company_ready`.

## Navigation

- [[Elara Companion Campaign]]
- [[The City in Siege]]
- [[The Patron's Cabinet]]
- [[Neda Volk]]
- [[Blackjack Yard]]
