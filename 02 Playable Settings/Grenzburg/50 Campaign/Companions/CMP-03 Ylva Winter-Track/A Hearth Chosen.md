---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Longlake Country"]
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
world_state_outputs: ["ylva_romance_episode", "ylva_romance_move_unlocked", "ylva_homeward_route_practiced", "chosen_hearth_state"]
reward_unlocks: ["Covered Return", "Homeward Route"]
required_locations: ["West Reed Shelter", "Longlake Shore"]
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
story_gate: "Romance commitment after What the Ice Takes"
estimated_hours: 0.5
gameplay_pillars: [shelter-craft, private-conversation, romance]
required_states: ["ylva_relationship_commitment: romance-committed", "player_sex: man"]
optional_state_inputs: ["ylva_direction", "ylva_shared_signal_code", "longlake_evacuees_state"]
field_experience_gate: ["Trusted", "What the Ice Takes personally completed"]
companion_required: "Ylva Winter-Track"
duo_quest: false
pause_points: ["Shelter Prepared"]
relationship_gate: "romance-committed"
relationship_variant: romance
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "The Last Marker"
autonomous_resolution: "The private episode does not occur; commitment remains but its upgrade and safeguard are lost"
changed_reentry: ""
ensemble_inputs: []
identity_hooks: ["Ättar", "Wilderness", "Peasant/Labour"]
encounter_deck: []
persistence_scope: permanent
postgame_season: ""
---
# A Hearth Chosen

## Quest Function

This is Ylva's male-player romance episode. It is a private winter shelter journey about receiving care, choosing shared domestic intimacy, and distinguishing a freely chosen hearth from another duty station.

There is no villain, attack, stranded traveler, emergency signal, or secret test. The episode uses romantic presentation and ends with a fade to black.

## Trigger

After romance commitment and personal completion of [[What the Ice Takes]], Ylva asks the player to walk with her to West Reed Shelter.

She says the shelter needs preparing for the next cold front. Brina has already assigned another crew. Ylva eventually admits she chose the work because she does not know how to ask for private time without making it useful.

## Preparing the Shelter

The pair complete ordinary work:

- clear the stove;
- hang wet blankets;
- set a wind cloth;
- split kindling;
- seal a roof gap;
- prepare enough food for two;
- place one public emergency reserve and one meal intended to be eaten now.

Tasks may be divided freely. If the player repeatedly takes all work, Ylva points out the resemblance. If Ylva attempts the same, the player may ask her to name what she wants rather than simply continuing.

No result is graded for efficiency.

## Care Without Account

Ylva's hands are raw from winter bow work. The player may offer salve, warm water, food, or rest. She asks whether accepting it creates an expectation.

The player can state:

- it is a gift;
- care may be returned later but is not owed;
- partners may ask directly rather than keep accounts;
- the player is also willing to receive care.

Ylva then offers something in return only after asking whether it is wanted: a repaired glove, a prepared meal, a shoulder rub, or simply company.

The scene is reciprocal without turning affection into barter.

## The Shared Hearth

At night Ylva explains that Grey-Wolf language distinguishes a shelter one happens to share from a hearth deliberately chosen with another person.

She asks plainly whether the player wants the latter.

The player may:

- choose the shared hearth;
- affirm romance but ask for more time;
- step back into friendship;
- end the relationship without hostility.

Choosing it leads to physical affection and a mature fade to black. No marriage, property, debt transfer, or permanent destination is decided here.

## Morning

Ylva wakes second and allows the player to take first watch. The pair strike only their private bedding, leaving the public shelter supplied and recorded.

They mark the homeward route together.

## Rewards

- `ylva_romance_episode`
- **Covered Return**, Ylva's romance duo move.
- `ylva_homeward_route_practiced`, one Act III safeguard.
- relationship-specific summer dialogue.

The permanent perk **Hearthward** is earned only after a resolved or compromised [[The Last Marker]].

## Missed Episode

Skipping or allowing this episode to expire does not end the committed romance. It permanently forfeits Covered Return, Homeward Route, and the episode's authored scenes for that playthrough.

## Navigation

- [[Ylva Field Familiarity and Relationships]]
- [[Ylva Companion Campaign]]
- [[Ylva Winter-Track]]
- [[What the Ice Takes]]
- [[The Last Marker]]
- [[The Road She Chooses]]
