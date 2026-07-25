---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Old Market", "Bridgehold"]
culture: ["Vortharan", "Sestaran", "Eclessian"]
related_factions: ["Blackjack Corps"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-2
availability_window: ["Late Winter", "Early Spring"]
repeatability: one-shot
cutoff_result: expires
world_state_outputs: ["tavio_romance_episode", "tavio_romance_move_upgrade", "tavio_courtship_measure_practiced", "festival_courtship_state"]
reward_unlocks: ["Fair Challenge: Answer Freely", "No Wager Between Us"]
required_locations: ["Old Market", "Bridgehold", "Lantern Ward"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: relationship
companion_campaign_stage: relationship
quest_owner: "Tavio Meran"
quest_sequence: 7
companion_id: "CMP-07"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: relationship
estimated_hours: 0.5
gameplay_pillars: [romance, social, festival, character]
required_states: ["tavio_relationship_commitment: romance-committed", "tavio_act2_finale_played"]
optional_state_inputs: ["tavio_fair_bout_result", "yard_fair_state", "old_market_state"]
field_experience_gate: []
companion_required: "Tavio Meran"
duo_quest: false
pause_points: []
relationship_gate: "Female player; romance committed; global romance slot available"
relationship_variant: romance
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "The Unending Muster"
autonomous_resolution: "The romance remains committed if already chosen, but its episode upgrade and Act III safeguard are lost"
changed_reentry: ""
ensemble_inputs: []
identity_hooks: ["Sestaran", "Peasant/Labour", "Merchant/Craft"]
encounter_deck: []
persistence_scope: personal
postgame_season: ""
---
# No Wager Between Us

## Quest Function

This is Tavio's female-player romance episode. He attends a Grenzburg festival as a suitor rather than its champion, asks plainly for a relationship, and accepts that affection is neither prize nor proof.

There is no combat, villain, sabotage, or alternate sworn-bond branch.

## Invitation

Tavio asks the player to meet him after the public contests have ended. He has already declined the exhibition bout and arranged for another host to finish the programme.

His invitation contains no challenge:

> I would like the evening with you. Not the crowd, not the rematch, not the story of it. You may say no.

## The Evening

The pair move through three small scenes:

1. choose food from stalls without turning it into a contest;
2. exchange one modest gift under an agreed price;
3. take the quiet route across Bridgehold after the lantern procession.

Tavio repeatedly feels the urge to perform. The player may enjoy some showmanship, ask him to stop, or tease him without making the relationship conditional on winning.

## Plain Question

At the river overlook, Tavio says what he wants and what he cannot promise:

- he wants a romantic partnership;
- he will still love risk and public games;
- he will not make her body, loyalty, or fear part of a wager;
- she may call a halt without earning his contempt;
- refusal will not damage the existing friendship.

The player may commit, decline gently, end the romance, or ask to remain friends. No hidden approval check overturns the explicit answer.

## Private Close

On commitment, the couple returns to private quarters. Physical affection is consensual and the mature scene fades to black.

There is no marriage oath, proof ring, ownership token, or public victory announcement.

## Rewards

- **Fair Challenge: Answer Freely**, adding protected repositioning before the reciprocal marked-target reply;
- permanent non-slot perk **No Wager Between Us**, rewarding coordinated alternating attacks;
- `tavio_courtship_measure_practiced`, one Act III safeguard;
- romance-specific summer dialogue.

Missing the episode does not end an existing commitment, but loses these upgrades.

## Navigation

- [[Tavio Companion Campaign]]
- [[Tavio Field Familiarity and Relationships]]
- [[The Fair Defeat]]
- [[Horn for Leak-Day]]
- [[The Road Takes the Measure]]
