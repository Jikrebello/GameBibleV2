---
type: quest
status: archived
canon_level: obsolete
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Lantern Ward"]
culture: ["Thalmyric", "Kedravan", "Eclessian"]
related_factions: ["Blackjack Corps"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-3
availability_window: ["Early Spring", "Open Spring"]
repeatability: one-shot
cutoff_result: resolves-offscreen
world_state_outputs: ["bernard_relationship_episode", "bernard_table_received", "bernard_duo_move_upgrade", "private_feast_state"]
reward_unlocks: ["Shared Ember: Warmth Returned or No One Alone: Two Bearers", "Table Received"]
required_locations: ["Blackjack Yard"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: relationship
companion_campaign_stage: act-3
quest_owner: "Bernard Valeon"
quest_sequence: 7
companion_id: "CMP-05"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: relationship
estimated_hours: 0.5
gameplay_pillars: [conversation, reflection]
required_states: ["bernard_relationship_commitment", "bernard_act2_finale_played"]
optional_state_inputs: ["petra_ilev_response", "bernard_direction", "bernard_owned_sword_state", "four_shelters_state"]
field_experience_gate: []
companion_required: "Bernard Valeon"
duo_quest: false
pause_points: []
relationship_gate: "Committed romance or sworn bond"
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "The Deep Muster"
autonomous_resolution: "The feast closes without relationship penalty; its move upgrade and Table Received bonus are not earned"
changed_reentry: "The private evening does not reopen after the Deep Muster commitment"
ensemble_inputs: []
identity_hooks: []
encounter_deck: []
persistence_scope: companion-persistent
postgame_season: ""
archive_reason: "Snapshot before romance and same-sex sworn-bond episodes were separated into distinct authored quests"
archived_from: "02 Playable Settings/Grenzburg/50 Campaign/Companions/CMP-05 Bernard Valeon/Enough for Two.md"
archived_on: 2026-07-25
superseded_by: "[[Enough for Two]]"
---
# Enough for Two

## Quest Function

This is Bernard's committed relationship episode. It contains no attack, emergency patient, missing supply, confession trap, or institution requiring judgement. Its purpose is to let Bernard accept food, rest, pleasure, and intimacy without earning every bite through service.

The episode deepens either romance or sworn bond. It improves a relationship move and grants one physical Act III safeguard. It cannot determine Bernard's moral outcome.

## Hook

Brina, Hannel, and several Yard cooks prepare the kitchen after the evening meal, leave a covered table for two, and lock the duty slate in the pantry.

The gift is explicit:

- the food is ordinary company surplus and personal contributions, not diverted relief;
- Bernard is not expected to cook, wash, inventory, or repay it;
- the room belongs to the pair until the watch bell;
- accepting it creates no account.

Bernard's first response is to check the stove, portions, and door latch. He catches himself and asks the player to sit before he invents work.

## The Table

The meal includes:

- dark bread and onion broth from the Yard kitchen;
- a Kedravan pepper-and-root dish Bernard has mentioned but did not prepare;
- one small sweet divided openly;
- a player-origin course or drink when the relevant ingredient is credibly available.

Origin culture changes stories and taste, not relationship access. No dish functions as a test with one correct response.

## Conversation Movements

### What Was Given

Bernard speaks about the personally owned sword from [[A Blade Freely Given]], or the inherited blade if that episode was missed. He distinguishes accepting a gift from keeping something before it can be taken away.

### What Petra Did Not Owe

Petra's forgiveness, refusal, or restitution-only response remains hers. The player may comfort Bernard without rewriting her choice.

### Enough

Bernard admits that contentment feels more dangerous than hunger because it asks him to trust that the present good can end without having been stolen.

The player may answer with tenderness, humor, silence, a boundary, or a mutual promise. No response requires a social check.

## Romance: Shared Ember — Warmth Returned

For a committed female player, the private scene may become physically affectionate and fades to black before explicit sexual detail.

The upgraded duo move retains the fear cleanse and anti-stagger interval from **Shared Ember**. During that interval, the first timely ally-granted heal, cleanse, revive, or protection received by either partner shares bounded recovery and Stamina with the other. It cannot chain, duplicate unique consumables, or bypass defeat states.

## Sworn Bond: No One Alone — Two Bearers

For a committed male player, the pair renew the last-watch promise over the same table without imitating romance.

The upgraded duo move retains Bernard's interposition and safe rescue window. One revive, carry, extraction, or protected interaction may withstand a single ordinary interruption. On completion, the player and rescued target gain brief Staying Power. Boss grabs and catastrophic hazards retain their authored answers.

## Table Received

`bernard_table_received` records that Bernard accepted care without converting it into debt or work.

During [[The Open Hospice]], the bonus prevents one exhaustion-driven physical failure: a dropped load, missed carrier call, failed brace, or momentary collapse. It cannot:

- expose a hidden reserve;
- make a patient choice;
- restore moral coherence;
- preserve a store category by itself;
- prevent Bernard's explicit sacrifice if the player later accepts it.

## Ending

The pair leave the kitchen together, or remain until the watch bell. Bernard washes nothing. The morning crew finds exactly the ordinary dishes it expected to find.

Outputs:

- `bernard_relationship_episode`: romance-complete, bond-complete, declined, or missed;
- `bernard_table_received`: true or false;
- `bernard_duo_move_upgrade`: warmth-returned, two-bearers, or none;
- `private_feast_state`: accepted, shortened, or missed.

## Vocation and Access

No player vocation, faction rank, origin, or combat proficiency gates the episode. Origin culture may change one course and its associated story without changing intimacy or reward access.

## Cutoff

Beginning [[The Deep Muster Main Quest|The Deep Muster]] closes the episode. Bernard does not punish the player or end the relationship, but the private scene, move upgrade, and Table Received bonus are lost.

## Navigation

- [[Bernard Companion Campaign]]
- [[Bernard Valeon]]
- [[Bernard Field Familiarity and Relationships]]
- [[Embers Without Excuse]]
- [[The Open Hospice]]
- [[Blackjack Yard]]
- [[Companions MOC]]
