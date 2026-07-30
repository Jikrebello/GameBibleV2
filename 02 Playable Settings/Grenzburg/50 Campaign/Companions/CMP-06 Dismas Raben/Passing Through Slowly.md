---
type: quest
status: draft
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Grenz Lowlands"]
culture: ["Eclessian", "Korrheim"]
related_factions: ["Blackjack Corps"]
appears_in: ["Grenzburg"]
needs: []
tags: [narrative-rewrite]
quest_class: companion
act: summer
availability_window: ["Summer Aftermath", "Postgame Summer"]
repeatability: one-shot
cutoff_result: persists
world_state_outputs: ["dismas_summer_coda", "dismas_deck_state", "guide_network_summer_state"]
reward_unlocks: ["Dismas summer routine"]
required_locations: ["Blackjack Yard", "Old Market", "Cold Spring Cut"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: summer
companion_campaign_stage: summer
quest_owner: "Dismas Raben"
quest_sequence: 10
companion_id: "CMP-06"
main_sequence: 0
story_gate: summer-aftermath
relationship_variant: ""
estimated_hours: 0.5
gameplay_pillars: [conversation, travel, reflection]
required_states: ["companion_summer_codas_unlocked"]
optional_state_inputs: ["dismas_arc_outcome", "dismas_future_path", "guide_network_state", "reprisal_family_state", "dismas_missing_queen_given", "dismas_return_leg_practiced", "sella_etten_response", "dismas_sacrifice_state"]
companion_required: ""
duo_quest: false
pause_points: []
autonomous_deadline: ""
autonomous_resolution: "The coda reflects the fixed Act III settlement and never changes it"
changed_reentry: "A departed or sacrificed Dismas appears through the network, the Lasks, and one piece of correspondence"
persistence_scope: campaign
postgame_season: summer
emotional_rewrite_status: cleared
dialogue_status: pending-rewrite
remote_claim_status: compliant
archetype_pressure: "Uncontained return, demonstrated by a man who has stayed and refuses to make a ceremony of it."
emotional_function: "Show the settled outcome through a bedroll, an appointment, and a card."
pleasure_beat: "A bad cellar door, a nine-year-old's terrible card trick, and a road that is half a day shorter than it was."
care_beat: "He is where he said he would be, on the day, without being asked."
player_archetype_hooks: ["Cheerleader", "Tomboy", "Goth", "Bohemian", "Jock", "Nerd", "Rebel", "Goofball", "Grey"]
---
# Passing Through Slowly

## Quest Function

Dismas's summer coda. Its title is his own joke from the banter file, and it reflects the fixed Act III outcome without reopening it.

## Resolved — the free road protector

He is at the Yard when the player arrives, which is the first surprising thing.

- **The bedroll is under the old bunk** by the gate. Nobody comments. He has stopped moving it.
- **The network runs without being his.** The charter is on the board in a hand that is not his; two disputes were settled last month by people who are not him; his name appears on the marked-route list once, next to eleven others, in the same size lettering.
- **The appointment.** He leaves mid-conversation because it is the day of the Lask surety visit, and he is not making a point about it — he simply looks at the light and goes. The player may come. Bekka performs the card trick badly at both of them and demands a verdict.
- **The Cut.** If [[The Missing Queen]] was played, the Cold Spring Cut is in ordinary carter use, half a day shorter, nobody's, with the keeping-rules still legible on the post.

### The Deck

If the player holds the queen, they may give it back.

He looks at it for a moment, puts it in the deck, and deals — **the first complete hand of the campaign.**

> **Dismas:** Do not make this a habit.

He means the ceremony, not the return. Writes `dismas_deck_state: complete`.

If the player keeps it, he says nothing about it ever, and the deck stays short, and that is also an ending.

## Compromised — supervised scout

He is on a ducal or Blackjack list, doing real work under somebody's charter, and he names the arrangement himself without being asked: useful, honest, and one signature short of the thing he wanted.

He is dry about it rather than bitter, and he still fixes the Yard's worst exit routes and still denies it.

## Broken or departed

Word comes from far roads. A ferryman mentions a guide answering his description on the Kedravan track; the network runs anyway, chartered and fine, which he would hate to know is the kindest thing about his absence.

**The Lasks send thanks he will never collect.** Anke has written it out and does not know where to send it, and gives it to the player, who cannot deliver it either.

## Sacrificed

The White Fen groove-break is marked with a queen, because one of the guides he trained put it there and did not know why he would have liked that.

The Lasks' licence is renewed. The charter holds. Bekka can do the card trick properly now, and asks the player whether it was the way he did it, and the player may say yes.

Memorial dialogue records the road and the coach in the same breath, without absolution.

## Outputs

- `dismas_summer_coda`: complete, changed-encounter, memorial, or missed;
- `dismas_deck_state`: complete, short, or unresolved;
- `guide_network_summer_state`: chartered, personal, fractured, or dissolved.

## Navigation

- [[Dismas Raben]] · [[Dismas Companion Campaign]]
- [[The Road That Answers]] · [[Tuesday]] · [[The Missing Queen]] · [[The Return Leg]]
- [[The Lask Household]] · [[Accounts of the Living]]
