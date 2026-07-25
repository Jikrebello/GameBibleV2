---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Highlake Uplands"]
culture: ["Ättar", "Grey-Wolf"]
related_factions: ["Blackjack Corps"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-2
availability_window: ["Late Winter", "Early Spring"]
repeatability: one-shot
cutoff_result: expires
world_state_outputs: ["ylva_bond_episode", "ylva_bond_move_unlocked", "ylva_sister_watch_practiced", "east_watch_cairn_state"]
reward_unlocks: ["Watch Relieved", "Sister Watch"]
required_locations: ["East Watch Cairn", "High Tuskway"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: relationship
companion_campaign_stage: relationship
quest_owner: "Ylva Winter-Track"
quest_sequence: 7
companion_id: "CMP-03"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: "Bond commitment after What the Ice Takes"
estimated_hours: 0.5
gameplay_pillars: [route-practice, shared-watch, private-conversation, sworn-bond]
required_states: ["ylva_relationship_commitment: bond-committed", "player_sex: woman"]
optional_state_inputs: ["ylva_direction", "ylva_shared_signal_code", "longlake_evacuees_state"]
field_experience_gate: ["Trusted", "What the Ice Takes personally completed"]
companion_required: "Ylva Winter-Track"
duo_quest: false
pause_points: ["Cairn Reached"]
relationship_gate: "bond-committed"
relationship_variant: bond
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "The Last Marker"
autonomous_resolution: "The private episode does not occur; commitment remains but its upgrade and safeguard are lost"
changed_reentry: ""
ensemble_inputs: []
identity_hooks: ["Ättar", "Wilderness", "Military"]
encounter_deck: []
persistence_scope: permanent
postgame_season: ""
---
# The Sister Watch

## Quest Function

This is Ylva's female-player sworn-bond episode. It is a completely platonic night at East Watch Cairn built around alternating lead, rest, and responsibility.

There is no romance, courtship, marriage symbolism, physical intimacy scene, fade to black, villain, or contrived attack.

## Trigger

After bond commitment and personal completion of [[What the Ice Takes]], Ylva asks the player to inspect East Watch Cairn with her.

She says the old relief practice required two route women to demonstrate that either could take lead and either could call the other off the road. The custom was never a formal war-scout office and grants no clan rank.

Ylva has never performed it with someone she chose.

## Outward Route

The pair alternate lead across three legs:

1. reed path with obscured footing;
2. exposed ridge with changing wind;
3. dark ascent marked by low cairns.

At each change, the lead gives:

- observed danger;
- intended pace;
- current limit;
- and the condition for asking relief.

The player may be more or less skilled than Ylva. The exercise is not about matching her tracking ability. It is about reporting honestly enough for two people to work.

## Establishing the Watch

At the cairn they:

- clear snow from the vent;
- inspect the lamp cap;
- divide food and fuel;
- set two overlapping sight lines;
- write a public relief time;
- create a signal both can issue and neither can overrule.

Ylva initially offers to take first and last watch. The player may remind her that this leaves only the middle as real relief.

They settle on equal turns.

## Night Conversation

During the first change Ylva discusses:

- women trusted with survival work but denied formal scout office;
- why professional recognition mattered to her;
- the difference between being underestimated and making oneself indispensable;
- fear that rest will reveal she was useful only while spending herself;
- what she needs a sister to say when she refuses relief.

The player names what she needs in return. Valid answers include:

- warning without command;
- truth before reassurance;
- physical help without humiliation;
- challenge when pride disguises danger;
- silence and presence;
- permission to make her own informed risk.

The bond is mutual. The player does not become Ylva's keeper.

## The Sister Signal

At dawn each ties a short grey-white service cord to the cairn's relief bar. The cords are not rings, prayer beads, marriage tokens, clan adoption, or military insignia.

They agree upon a simple signal meaning:

> I see what you carry. I am ready to take my watch. Answer me.

Each must answer before the other assumes control.

They explicitly call one another sworn sister.

## Return

The player leads the first return leg. Ylva takes the second. They walk the final stretch abreast.

No emergency interrupts the proof. The cairn remains an ordinary staffed route point.

## Rewards

- `ylva_bond_episode`
- **Watch Relieved**, Ylva's sworn-bond duo move.
- `ylva_sister_watch_practiced`, one Act III safeguard.
- relationship-specific summer dialogue.

The permanent perk **Second Watch** is earned only after a resolved or compromised [[The Last Marker]].

## Missed Episode

Skipping or allowing this episode to expire does not end the committed bond. It permanently forfeits Watch Relieved, Sister Watch, and the episode's authored scenes for that playthrough.

## Navigation

- [[Ylva Field Familiarity and Relationships]]
- [[Ylva Companion Campaign]]
- [[Ylva Winter-Track]]
- [[What the Ice Takes]]
- [[The Last Marker]]
- [[The Road She Chooses]]
