---
type: quest
status: draft
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Quarry Steps", "Grenz Lowlands"]
culture: ["Eclessian", "Korrheim"]
related_factions: ["Blackjack Corps"]
appears_in: ["Grenzburg"]
needs: []
tags: [narrative-rewrite]
quest_class: companion
act: act-1
availability_window: ["Late Autumn", "Early Winter", "Deep Winter"]
repeatability: one-shot
cutoff_result: persists
world_state_outputs: ["dismas_friendship_episode", "dismas_chimney_count", "dismas_relationship_interest"]
reward_unlocks: ["Follow the Queen"]
required_locations: ["Quarry Steps", "Old Smuggler's Traverse", "Hollow Ash"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: friendship
companion_campaign_stage: friendship
quest_owner: "Dismas Raben"
quest_sequence: 4
companion_id: "CMP-06"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: friendship
relationship_variant: ""
estimated_hours: 0.5
gameplay_pillars: [traversal, exploration, conversation]
required_states: ["dismas_act1_chapter_resolved"]
optional_state_inputs: ["dismas_act1_result", "rooftop_network_state", "dismas_roof_scene"]
companion_required: "Dismas Raben"
duo_quest: false
pause_points: []
relationship_gate: "Available to every player; no attraction or commitment required"
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: ""
autonomous_resolution: "He goes alone, as he has every year. The episode remains available later."
changed_reentry: "A winter version uses the frozen traverse and a shorter sit"
ensemble_inputs: []
identity_hooks: []
encounter_deck: []
persistence_scope: character-persistent
postgame_season: ""
emotional_rewrite_status: cleared
dialogue_status: pending-rewrite
remote_claim_status: compliant
archetype_pressure: "Illicit pleasure with nothing prosecuted: the one piece where refusal costs nobody anything."
emotional_function: "Give the player the man rather than the case, and hide the campaign's heart in a count that comes out right."
pleasure_beat: "A route that does not exist, cards on a parapet, breakfast carried all night, and a view officials call impossible."
care_beat: "He shows the player something he has never shown anyone, and lies about why."
player_archetype_hooks: ["Cheerleader", "Tomboy", "Goth", "Bohemian", "Jock", "Nerd", "Rebel", "Goofball", "Grey"]
---
# No Railing

## Quest Function

Dismas's friendship episode. **No villain, no test, no confession, and nothing at stake.**

It is also the secret heart of his campaign, and the player is not told that.

## Hook

He asks the player to come and see something. He will not say what. He implies, wrongly, that it is illegal.

## The Route

Quarry Steps laundry loft, two roofs, a ladder that is not supposed to be there, the unused watch platform from [[The Decorative Fence]] — and then past it, onto an **old smuggler's traverse** along the escarpment that has not carried freight in thirty years and is not on any map the Duchy owns.

Every vocation completes it through ordinary climbing, ledges, and one controlled descent. Free Running and Slayer movement add flourishes. Missing a step costs position and dignity, never health.

He has brought breakfast. He has been carrying it the whole way.

## The Sit

At the end of the traverse the escarpment opens south over the Lowlands, and the view is genuinely worth the climb: three river bends, the Ash Road, and a scatter of small holdings in the flats.

They eat. They play cards on the parapet with a deck one queen short. He tells three stories, all accurate, all of which omit the moment he mattered. He is funnier here than anywhere else in the campaign and completely unguarded, and the player should simply enjoy an afternoon with him.

Conversation may include: the first road he ever read; why he despises checkpoints designed as humiliation more than checkpoints that merely work; revolutionaries who cannot cook; whether the player wants to be needed; what he thinks Grenzburg will be in ten years. **Nothing locks, nothing grades, and any topic can be declined.**

## Hollow Ash

Down in the flats, one of the holdings has eleven chimneys and a chapel roof going green.

It is called Hollow Ash and it was not there twelve years ago. It exists because a Korrheim guide moved four families off a toll road in a bad winter and pointed them at empty ground, and it has been growing ever since, and nobody there knows his name.

**He comes every year.** Alone, anonymously, from this platform, to see whether the escape turned into a life.

The player catches him **counting chimneys** — lips moving, finger on the parapet, the exact tell from the ravine. He finishes it. He gets to eleven, and there are eleven, and he does it twice to be sure.

*(Counting beat 2 of 4. Writes `dismas_chimney_count`.)*

If asked, he lies, badly:

> **Dismas:** Waste of a good view otherwise.

Then he deals the next hand. **No line in this scene explains the ravine, the coach, or the count.** The player may connect them or not; the quest never does.

## End

They go back the way they came, in the dark, slower.

He mentions — as though it were a joke about laundry — that the traverse is marked at three bad turns with a card. Not a card: a queen. Somebody's queen, from somebody's deck, wedged in the rock at the places where a person moving fast would guess wrong.

Unlocks **Follow the Queen**: his old route marks become readable to the player throughout the worldspace. There are seven of them and he never signed any of them.

Writes the second pre-commitment relationship beat. Interest of any kind may be expressed here, or nothing at all, without cost.

## Rewards

- `dismas_friendship_episode`;
- **Follow the Queen**;
- the Old Smuggler's Traverse and the platform remain on the player's map;
- one absurd keepsake: the pack of cards, still one short, if the player asks for it.

## Navigation

- [[Dismas Raben]] · [[Dismas Companion Campaign]] · [[Dismas Field Familiarity and Relationships]]
- [[The Decorative Fence]] · [[Passage]] · [[The Missing Queen]]
