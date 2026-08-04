---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Old Market", "Bridgehold"]
culture: ["Eclessian", "Virelian"]
related_factions: ["Blackjack Corps"]
appears_in: ["Grenzburg"]
needs: []
tags: [narrative-rewrite]
quest_class: companion
act: act-1
availability_window: ["Late Autumn", "Early Winter", "Deep Winter"]
repeatability: one-shot
cutoff_result: persists
world_state_outputs: ["elara_friendship_episode", "elara_bridgehold_practice", "elara_rooftop_wager_result", "elara_without_powder_scene"]
reward_unlocks: ["Follow My Line", "Bridgehold route practice"]
required_locations: ["Blackjack Yard", "Market Roofline", "Bridge Market", "Great Bridge Keep"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: friendship
companion_campaign_stage: act-1
relationship_variant: ""
quest_owner: "Elara Velescar"
quest_sequence: 4
companion_id: "CMP-01"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: friendship
estimated_hours: 0.5
gameplay_pillars: [traversal, exploration, conversation]
required_states: ["elara_act1_chapter_resolved"]
optional_state_inputs: ["elara_act1_result", "rooftop_network_state", "elara_wager_scene"]
field_experience_gate: []
companion_required: "Elara Velescar"
duo_quest: false
pause_points: []
relationship_gate: "Available to every player; no attraction or commitment required"
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: ""
autonomous_resolution: "See Companion Autonomy and Act Convergence; untracked content uses stable-colleague treatment."
changed_reentry: "A winter version uses cleared icy roofs after an autonomous Act I finale"
ensemble_inputs: []
identity_hooks: []
grounded_rewrite_status: approved
external_stakes: ["Bridgehold rooftop race", "Old Market route safety"]
banter_priority: optional
player_interest_gate: none
missed_arc_treatment: stable-colleague
encounter_deck: []
persistence_scope: local-persistent
postgame_season: ""
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
archetype_pressure: "Belonging becomes curation: test whether Elara shares social power or decides who deserves the room."
emotional_function: "Protect the uninterrupted race, delight, vanity, and mutual play"
pleasure_beat: "Social sparkle, discovery, elegant risk, and making a temporary company feel chosen."
care_beat: "Elara shares credit, access, attention, and protection without making gratitude the price of belonging."
player_archetype_hooks: []
---
# A Better Wager

## Quest Function

This is Elara's friendship episode. It is deliberately free of villains, interrupted rescues, hidden crimes, and compulsory moral tests.

The player and Elara race because racing across Grenzburg's roofs is enjoyable.

## Hook

After her Act I chapter resolves, Elara produces the wager first proposed after [[Names Beneath Lime]]:

> "Blackjack Yard to the Bridgehold vane. No horses. No hired hands. No pretending the stairs are beneath us."

She has walked the route, obtained roof access from the relevant stallholders, and marked unsafe construction. The race is daring but not an act of trespass that leaves workers carrying the risk.

**The stake is specified and slightly public:** the loser carries the winner's field kit across the Old Market at midday. Not a punishment — a spectacle, of the small ridiculous kind, in front of people who buy vegetables.

## Party and Staging

The activity is one-on-one. Other companions remain at the Yard and may comment on the wager before departure or its result afterward.

The player keeps their current vocation and equipment. No vocation owns the best route.

## Vocation Access

Every player vocation runs the complete course through ordinary ladders, vaults, stairs, awnings, and ledge grabs. Free Running and vocation movement alter flourishes or offer equivalent shortcuts; they do not decide the winner or gate the conversation.

## Course

### Start: Blackjack Yard

The player chooses one of three declared lines:

- **Market Highline:** shortest, exposed, and rich in ordinary climbing;
- **Arcade Line:** interior balconies, guild stairs, and vaults through moving crowds;
- **Lower Bridge Line:** cranes, pier stairs, and the underside approach to Bridgehold.

Elara chooses a different line after hearing the player's selection. She does not teleport or gain an impossible head start.

### Old Market

The route uses awnings, chimneys, rain channels, service bridges, and the Market Roofline. Free Running, Slayer tools, Warlock movement, and other vocation advantages create shortcuts. Every line retains stairs, ladders, ledges, and ordinary vaults.

Missing a jump costs position rather than causing serious injury. The player may recover through a lower route without reloading.

### Bridgehold

The final section crosses the Bridge Market galleries and climbs the Great Bridge Keep to a weather vane visible from both banks.

Elara may win, lose, or reach the vane with the player. The game records the result only for dialogue:

- if she wins, she is delighted and insufferably precise about the margin;
- if the player wins, she pays the wager immediately and demands a rematch someday;
- a tie becomes an argument over whose hand touched the iron first.

No result changes approval, readiness, romance eligibility, or Elara's moral outcome.

**Paying it.** If Elara lost, she carries the kit across the Old Market at midday in full style, waving, having clearly decided that the only way through this is to be magnificent about it — and she hates every step. Somewhere near the fish stalls one laugh lands wrong: not cruel, just a stranger enjoying the grave lady with a pack on. She styles over it almost successfully, and *almost* is the word. Two lines, no comment, no state. It is a forecast of the spring, and the player will not recognize it as one until [[Uninvited]].

## Without the Powder

After the race, the pair sit above Bridgehold until the market closes. Back at a sheltered maintenance landing, Elara repairs a torn cuff and cleans rain, soot, and powder from her face.

This is not a revelation that her appearance was false. She speaks about fearing that, without House Velescar, guilt and charm may be the only remarkable things left about her.

One optional thread, if the player has noticed Perle: Elara mentions the ribbon on the apron — how Perle wears it, how she tells the Ropehouse story wrong, how she tells it constantly — and for one beat she lets the player see that being adored by somebody she has never once thought about makes her feel like a fraud. She does not resolve it, and she changes the subject herself. See [[Perle Winkel]].

The player may:

- affirm adventure without flattering her innocence;
- say friendship does not require performance;
- keep the conversation light without closing future intimacy;
- explicitly decline romantic or sworn-bond interest while preserving friendship.

The scene records `elara_without_powder_scene`.

## Winter Transformation

If Act I resolved autonomously, Elara remains willing to race after [[Elara Companion Campaign#The Scarred Mounds|The Scarred Mounds]] or once winter city access stabilizes. The course uses swept snow, frozen gutters, and interior galleries. The conversation acknowledges what happened without turning the race into punishment.

## Rewards

- `elara_bridgehold_practice`, an Act II preparation asset;
- **Follow My Line**, an Elara field behavior that marks a nearby safe traversal continuation after the player misses a jump or loses sight of a climb route;
- Bridgehold and Market Roofline shortcuts remain visible on the player map;
- friendship progression and the second pre-commitment relationship scene.

Follow My Line does not solve puzzles, reveal secret rooms, or create routes unavailable to other parties.

## Navigation

- [[Elara Companion Campaign]]
- [[Elara Field Familiarity and Relationships]]
- [[Elara Delver-Duelist Package]]
- [[Bridgehold]]
- [[Old Market]]
- [[Grenzburg City Anchor Register#Cross-City Anchors|Market Roofline]]
- [[The Patron's Cabinet]]
- [[Companions MOC]]
