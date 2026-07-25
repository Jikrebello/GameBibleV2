---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Old Market", "Longlake Ward", "Bridgehold"]
culture: ["Sermoran", "Eclessian", "Chapel-Folk"]
related_factions: ["Blackjack Corps"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-1
availability_window: ["Open Autumn", "Late Autumn", "Early Winter"]
repeatability: one-shot
cutoff_result: persists
world_state_outputs: ["ilyana_friendship_episode", "ilyana_common_tune_state", "ilyana_bridgehold_refrain_known", "ilyana_relationship_interest"]
reward_unlocks: ["Common Tune", "Your Part If You Want It"]
required_locations: ["Red Stag Inn", "Fish Market", "Great Forge", "Bridgehold"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: friendship
companion_campaign_stage: friendship
quest_owner: "Ilyana Veshkar"
quest_sequence: 4
companion_id: "CMP-02"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: optional
estimated_hours: 0.5
gameplay_pillars: [exploration, social, performance, companionship]
required_states: ["ilyana_introduction_complete"]
optional_state_inputs: ["ilyana_act1_result", "old_market_state", "longlake_ward_state", "bridgehold_state"]
field_experience_gate: []
companion_required: "Ilyana Veshkar"
duo_quest: false
pause_points: []
relationship_gate: "Available to every player on speaking terms with Ilyana"
relationship_variant: ""
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: ""
autonomous_resolution: "The episode remains optional and does not resolve autonomously"
changed_reentry: ""
ensemble_inputs: []
identity_hooks: ["Sermoran", "Folk", "Peasant/Labour", "Merchant/Craft"]
encounter_deck: []
persistence_scope: character-persistent
postgame_season: ""
---
# A Tune with No Owner

## Quest Function

This is Ilyana's universal friendship episode: a pleasurable walk through Grenzburg to build and perform one local tune. There is no villain, attack, theft, surprise emergency, or disguised moral trial.

## Beginning: A Bad Chorus

At the [[Old Market#Anchor Locations|Red Stag Inn]], Ilyana hears three patrons singing incompatible versions of the same bridge song. She proposes spending the afternoon finding out how many versions exist.

The player may accept, tease her about professional curiosity, or ask whether she plans to claim it. Ilyana answers:

> Nobody owns a road tune. People do own the verse they wrote yesterday.

## The Four Stops

The pair visits in any order:

1. **Fish Market:** carriers sing a short hauling version with a missing final beat.
2. **Great Forge:** hammer workers preserve an older rhythm but changed the words.
3. **Bridgehold:** sentries use a warning couplet timed to bridge traffic.
4. **Red Stag:** performers know the newest comic verse and who wrote it.

At each stop the player can:

- ask the source;
- offer payment, a drink, labor, or reciprocal information;
- contribute cultural knowledge;
- attempt a simple rhythm response;
- decline to perform and listen.

No skill failure blocks the collection. Failure changes humor, confidence, and which local performer joins the final song.

## End: Common Tune

The pair performs at the Red Stag with the source names announced:

- carriers;
- forge workers;
- bridge sentries;
- the writer of the comic verse;
- Ilyana and the player for the new connecting line.

The player may sing, tap a cup, provide a silent timing cue, or remain the named witness.

Winning applause, earning laughter, or producing an awkward sincere performance changes dialogue only.

## Relationship Scene

Afterward, **Your Part, If You Want It** opens. Ilyana offers the player a two-note answer for future camps and makes refusal easy. This can establish romance interest, bond interest, friendship, or a closed relationship path without affecting ordinary companionship.

## Rewards

- `ilyana_bridgehold_refrain_known`, one Act II route cue.
- **Common Tune:** limited voluntary local assistance during one later Grenzburg performance or signal scene.
- A complete friendship memory available regardless of romance or bond.

## Navigation

- [[Ilyana Companion Campaign]]
- [[Ilyana Field Familiarity and Relationships]]
- [[Old Market]]
- [[Bridgehold]]

