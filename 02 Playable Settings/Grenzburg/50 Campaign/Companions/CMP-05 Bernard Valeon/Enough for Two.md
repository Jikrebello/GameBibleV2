---
type: quest
status: canon
canon_level: local
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
cutoff_result: forfeited
world_state_outputs: ["bernard_romance_episode", "bernard_romance_move_upgrade", "bernard_table_received", "private_feast_state"]
reward_unlocks: ["Shared Ember: Warmth Returned", "Table Received"]
required_locations: ["Blackjack Yard"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: relationship
relationship_variant: romance
companion_campaign_stage: relationship
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
required_states: ["bernard_relationship_commitment: romance-committed", "bernard_act2_finale_played"]
optional_state_inputs: ["petra_ilev_response", "bernard_direction", "bernard_owned_sword_state", "long_table_shelter_state"]
field_experience_gate: []
companion_required: "Bernard Valeon"
duo_quest: false
pause_points: []
relationship_gate: "Female player; bernard_relationship_commitment: romance-committed"
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "The Deep Muster"
autonomous_resolution: "The romance episode closes without relationship penalty; its move upgrade and Table Received bonus are not earned"
changed_reentry: "The private evening does not reopen after the Deep Muster commitment"
ensemble_inputs: []
identity_hooks: []
encounter_deck: []
persistence_scope: personal
postgame_season: ""
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
archetype_pressure: "Warmth becomes evasion: test whether Bernard can remain funny and loving while accepting specific judgement."
emotional_function: "Let Bernard receive a female partner's desire and care without turning either into payment, rescue, or proof of innocence."
pleasure_beat: "A private feast, ridiculous portions, freely chosen affection, and nowhere else either person is required to be."
care_beat: "Bernard accepts the meal and one gifted prayer-rope bead without bargaining to repay them."
player_archetype_hooks: ["Cheerleader", "Tomboy", "Goth", "Bohemian", "Grey"]
---
# Enough for Two

## Quest Function

This is Bernard's romance episode for a female player. It contains no attack, emergency patient, missing supply, confession trap, or institution requiring judgement. Its purpose is to let Bernard accept food, rest, pleasure, and romantic intimacy without earning every bite through service.

The episode improves the romance move and grants one physical Act III safeguard. It cannot determine Bernard's moral outcome.

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

Petra's accepted-without-reconciliation, redirected, or contact-closed response remains hers. The player may comfort Bernard without rewriting her choice.

### Enough

Bernard admits that contentment feels more dangerous than hunger because it asks him to trust that the present good can end without having been stolen.

The player may answer with tenderness, humor, silence, a boundary, or a mutual promise. No response requires a social check.

## Shared Ember: Warmth Returned

Bernard asks whether he may add something freely given to the prayer rope that is his only inherited possession. The player offers a plain wooden bead chosen for him, and he confirms aloud that it is a gift rather than payment, pledge, or debt. If welcomed, the private scene becomes physically affectionate and fades to black before explicit sexual detail. The player may instead keep the evening tender without sex or ask for more time without ending the commitment.

The upgraded duo move retains the fear cleanse and anti-stagger interval from **Shared Ember**. During that interval, the first timely ally-granted heal, cleanse, revive, or protection received by either partner shares bounded recovery and Stamina with the other. It cannot chain, duplicate unique consumables, or bypass defeat states.

The upgrade requires Bernard in the active party.

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

- `bernard_romance_episode`: complete, declined, or missed;
- `bernard_romance_move_upgrade`: warmth-returned or none;
- `bernard_table_received`: true or false;
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
