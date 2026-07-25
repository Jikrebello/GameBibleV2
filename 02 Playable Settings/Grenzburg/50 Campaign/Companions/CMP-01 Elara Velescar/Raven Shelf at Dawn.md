---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Highlake Uplands"]
culture: ["Eclessian", "Virelian"]
related_factions: ["Blackjack Corps", "Highlake signal service"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-3
availability_window: ["Early Spring", "Open Spring"]
repeatability: one-shot
cutoff_result: resolves-offscreen
world_state_outputs: ["elara_romance_episode", "elara_romance_move_upgrade", "elara_raven_line_practiced", "raven_signal_runner_state"]
reward_unlocks: ["Crossed Measure: Second Beat", "Raven Line Practiced"]
required_locations: ["Highlake", "Raven Shelf", "Blue Ice Cave"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: relationship
relationship_variant: romance
companion_campaign_stage: act-3
quest_owner: "Elara Velescar"
quest_sequence: 7
companion_id: "CMP-01"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: relationship
estimated_hours: 0.5
gameplay_pillars: [traversal, weather, rescue, conversation]
required_states: ["elara_relationship_commitment: romance-committed", "elara_act2_finale_played"]
optional_state_inputs: ["highlake_carrier_terms", "spring_settlement_access", "elara_bridgehold_line_practiced"]
field_experience_gate: []
companion_required: "Elara Velescar"
duo_quest: false
pause_points: ["Signal Runner Safe"]
relationship_gate: "Male player; elara_relationship_commitment: romance-committed"
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "The Deep Muster"
autonomous_resolution: "The romance episode closes without relationship penalty; its upgrade and Raven Line asset are not earned"
changed_reentry: "Summer dialogue acknowledges the missed climb but does not replay it"
ensemble_inputs: []
identity_hooks: []
encounter_deck: []
persistence_scope: local-persistent
postgame_season: ""
---
# Raven Shelf at Dawn

## Quest Function

This is Elara's romance episode for a male player. It deepens physical and emotional intimacy through a private expedition, a weather-driven rescue, and explicit reliance without making romance responsible for her moral reform.

The episode grants the romance move upgrade and a material Act III advantage. It cannot determine the resolved, compromised, or broken outcome.

## Hook

Elara has wanted to climb Raven Shelf since seeing it from the Southwood road. There is no tomb, relic, or disputed treasure at the top. The shelf is simply difficult, beautiful, and high enough to see the spring frontier open beneath it.

She asks the player to leave Highlake before dawn, climb by the old signal line, and camp above the clouds for one night.

## Party and Preparation

The activity is one-on-one. Elara brings rope, anchors, weather cloth, food, and signal chalk. The player may add cold protection, tracking supplies, or a Highlake forecast.

Every vocation can complete the route:

- ordinary climbing and ladders form the main ascent;
- Slayer and Free Running open exposed shortcuts;
- Hunter tracking reads old signal marks;
- Warlock and an unlocked Lancewright can clear ice or stabilize a damaged fitting without creating new routes;
- Fighter, Paladin, Binder, and Medium tools solve load, protection, or hazard problems.

Elara's equipment provides safer options, not mandatory access.

## Beginning: The Signal Line

The ascent crosses three sections:

1. a scree path with old rope posts;
2. a narrow chimney protected from the wind;
3. an exposed traverse beneath Raven Shelf.

The player and Elara alternate anchors. The episode records whether the player leads, follows, or trades responsibility without grading one as the correct relationship posture.

Along the route they find a fresh signal token belonging to **Nika Rimek**, a young Highlake warning runner who was expected back the previous evening.

## Middle: Weather Turn

A spring mountain front closes faster than the valley forecast predicted. Wind removes the upper trail, sleet freezes the traverse, and one old signal cable tears loose.

Nika is alive on a lower ledge after descending to repair an aerial-warning marker. Her ankle is injured and her return line has fallen.

The rescue has three simultaneous needs:

- reach or throw a line to Nika;
- establish a protected anchor before the next wind wall;
- preserve enough shelter material for the descent or emergency camp.

The player may descend, direct Elara, build an improvised hauling line, or approach through Blue Ice Cave. Failed actions cost equipment, worsen Nika's injury, or force the party into the cave. Nika never dies off-screen or from one failed check.

## Rescue State

- **Clean extraction:** Nika is mobile with support and the upper route remains available.
- **Hard extraction:** Nika survives with a serious injury and the party loses gear or the direct descent.
- **Cave refuge:** all three wait out the worst weather in Blue Ice Cave and return by a longer route.

Highlake responds to the material result. Relationship quality does not depend on performing a perfect rescue.

## End: Camp Above Highlake

Once Nika is secured with a returning signal crew or sheltered below the shelf, the player and Elara make the private camp originally intended.

Elara speaks about the difference between being accompanied and being possessed. She does not offer the player a place in a restored house. She asks whether they can choose expeditions, returns, danger, and ordinary life as equals whose futures remain their own.

The player may reciprocate, ask for more time, or reaffirm the commitment without sex. If welcomed, the scene becomes physically intimate and fades to black. None of these responses grants forgiveness for Elara's past or asks the player to supervise her conscience.

## Move Upgrades

### Crossed Measure: Second Beat

The romance upgrade preserves the existing setup and vocation-specific finisher. After the finisher, Elara provides a guarded disengagement and leaves a surviving target's opened point marked for one immediate follow-up. It cannot chain indefinitely or bypass boss phases.

The upgrade requires Elara in the active party.

## Raven Line Practiced

The climb records `elara_raven_line_practiced`. During the clearing-chamber collapse in [[No Lady of Velescar]], the pair can trust a split route and preserve one additional person or material recovery.

This advantage never changes which recovery Elara values first and cannot create a resolved outcome from entitled conduct.

## Cutoff

Beginning [[The Deep Muster Main Quest|The Deep Muster]] closes the episode. Highlake's signal service recovers Nika through its own spring operations. Elara does not punish the player or end the relationship, but the private climb, move upgrade, and Raven Line asset are lost.

## Outputs and Rewards

- `elara_romance_episode`: complete, declined, or missed;
- `elara_romance_move_upgrade`: second-beat or none;
- `elara_raven_line_practiced`: true or false;
- `raven_signal_runner_state`: safe, injured, cave-recovered, or independently-recovered.

## Navigation

- [[Elara Companion Campaign]]
- [[Elara Field Familiarity and Relationships]]
- [[Elara Delver-Duelist Package]]
- [[Highlake Uplands]]
- [[Grenzburg Worldspace Location Register#Highlake Uplands|Raven Shelf and Blue Ice Cave]]
- [[No Lady of Velescar]]
- [[Companions MOC]]
