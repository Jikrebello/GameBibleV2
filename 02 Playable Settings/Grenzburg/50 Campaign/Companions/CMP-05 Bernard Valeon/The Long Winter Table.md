---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Lantern Ward", "Longlake Ward", "Outer Winter Camps"]
culture: ["Eclessian", "Chapel-Folk", "Thalmyric"]
related_factions: ["Blackjack Corps", "Church of Grenzburg", "Bent Oak households"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-2
availability_window: ["Early Winter", "Deep Winter"]
repeatability: one-shot
cutoff_result: resolves-offscreen
world_state_outputs: ["bernard_long_table_network", "long_table_shelter_state", "long_table_route_state", "long_table_contribution_state", "bernard_winter_reserve_tell"]
reward_unlocks: ["Long Table Network", "shelter preparation"]
required_locations: ["Blackjack Yard", "Mercy Hospital", "West Refuge Hall", "Outer Winter Camps"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-operation
companion_campaign_stage: act-2
quest_owner: "Bernard Valeon"
quest_sequence: 5
companion_id: "CMP-05"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: preparation
estimated_hours: 1.0
gameplay_pillars: [social, traversal, protection, rescue, conversation]
required_states: ["bernard_act1_chapter_resolved", "winter_strands_open"]
optional_state_inputs: ["lantern_ward_damage", "mercy_hospital_state", "blackjack_yard_state", "longlake_passage_rule", "winter_flour_output", "winter_grain_credit"]
field_experience_gate: []
companion_required: "Bernard Valeon"
duo_quest: false
pause_points: ["First Table Cleared", "Bombardment Begins"]
relationship_gate: ""
relationship_variant: ""
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "Ghor at the Gate"
autonomous_resolution: "Three shelters form an effective network; the fourth joins after avoidable exposure because Bernard tried to carry its route alone."
changed_reentry: "The damaged supper route remains visible and provides a reduced casualty lane rather than a replay."
ensemble_inputs: ["Ilyana Veshkar", "Ylva Winter-Track", "Zafir ibn Samad"]
identity_hooks: ["Peasant/Labour", "Merchant/Craft", "Mystic/Religious", "Drifter/Vagabond"]
encounter_deck: []
persistence_scope: district-persistent
postgame_season: ""
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
archetype_pressure: "Bernard can make four isolated rooms feel like one company, then must let that company act without making himself indispensable."
emotional_function: "Turn his humor, appetite, and hospitality into a concrete siege network before testing whether he reports a reserve."
pleasure_beat: "Four very different suppers, improvised songs, terrible stew names, and travelers carrying jokes between shelters."
care_beat: "People choose what they can contribute and later rescue one another through relationships built at the tables."
player_archetype_hooks: ["Cheerleader", "Tomboy", "Goth", "Bohemian", "Jock", "Nerd", "Rebel", "Goofball", "Grey"]
---
# The Long Winter Table

## Premise

Four winter shelters are becoming four frightened islands. Bernard proposes a moving supper: one pot, one folding table, and one evening spent at each shelter so cooks, porters, carers, and residents learn one another's names and routes.

There is no hidden plot. The idea becomes important because a later bombardment and fire isolate the shelters, and the people who ate together are the people able to rescue one another.

## The Four Tables

- **Mercy Annex:** patients, laundresses, two exhausted night carers, and a stove that draws badly.
- **Debtors' Row Warming Room:** elderly debtors, Yard families, and shift workers who distrust institutional charity.
- **West Refuge Hall:** Chapel-Folk households, ferry workers, and children separated from the road school.
- **Funnel Warming Tent:** newly arrived refugees and carters still outside the walls.

Each table has a host, a need, and something it can offer. Nobody is reduced to a claimant waiting for Bernard.

## Beginning: Supper on Legs

At the Yard, Bernard unveils a folding tabletop too wide for the doorway and calls it “a modest triumph of faith over measurement.” The player chooses what begins the pot, but no ingredient solves the quest. The first work is social and physical:

1. recruit two voluntary porters;
2. let each shelter nominate its own host;
3. mark a route that does not expose food lines to Grobi scouts;
4. publish what the Yard can and cannot provide.

The normal party carries, scouts, performs, repairs, negotiates, or protects according to vocation and temperament. Bernard does not own the table because he imagined it.

### Pause Point: First Table Cleared

After the first supper, the operation may pause. The remaining hosts continue ordinary service but do not advance the crisis until resumption.

## Middle: Four Different Rooms

Each supper has distinct scene business.

### Mercy Annex

Bernard entertains a delirious mason with an increasingly inaccurate saint's life while the player helps the carers fix the flue, shift beds, or prepare a cold evacuation.

### Debtors' Row

The residents insist on contributing onions, mending, or tomorrow's carrying shift. Bernard must accept contribution without turning the meal into repayment.

### West Refuge Hall

Children rename the stew after every ingredient. A Chapel-Folk host quietly corrects Bernard when his welcoming speech begins to sound like ownership of the room.

### Funnel Camp

Carters know a service lane omitted from official maps. A stranger who has received one bowl volunteers the shortest path between all four shelters; the route belongs to the people using it, not to Bernard.

The player may rush the meals for efficiency, but doing so loses names, signals, and voluntary roles that matter during the crisis.

## Bombardment: The Table Becomes a Route

Grobi fire strikes a riverside store and burning pitch closes the public lane. Smoke separates the four shelters.

The network responds:

- Mercy laundresses carry wet blankets to Debtors' Row;
- Yard porters pull the folding table apart for two makeshift litters;
- West Refuge's bell code directs Funnel carters through the service lane;
- children repeat the ridiculous stew names as location calls through smoke.

The player moves among three rescue fronts:

1. carry or escort patients from a smoke-filled annex;
2. clear a burning cart without spreading fire to the warming room;
3. recover a missing Funnel group through the improvised signal chain.

Every vocation has a baseline route. Movement and support abilities improve speed, visibility, or casualty protection without becoming gates.

### Bernard's Reserve

Bernard has put one wrapped packet of lamp oil and dried food beneath the folding table “in case the next room has none.” It is useful now, but it was not declared.

- Naming it before discovery supports `truthful`.
- Admitting it when the table is opened supports `uncertain`.
- Hiding it after the need appears supports `withholding`.

The player may insist on a public count without humiliating him. Zafir can identify the missing weight; Ilyana can keep the crowd together; Ylva can preserve the service lane. None makes Bernard speak.

## End: Who Carries Tomorrow

After the fire, the four hosts decide whether the moving supper becomes a mutual network.

Bernard's best contribution is not a speech. He washes pots while other people assign tomorrow's route, and he tells them exactly what was under the table.

Possible results:

- **Open Network:** all four shelters share names, routes, signals, and contribution lists.
- **Useful Table:** the meals succeed, but coordination still depends on Bernard or the Yard.
- **Sponsor's Supper:** one faction claims the network and excludes an unpopular group.
- **Broken Route:** the crisis is survived, but one shelter remains isolated.

## Fail-Forward

- A missed supper removes one response team rather than failing the quest.
- Lost food changes the meal to broth and bread; relationships remain possible.
- A failed fire response causes injuries and closes one lane, opening an underways evacuation.
- A defeated party wakes in the nearest shelter while residents complete the closest rescue and another objective is lost.
- An undeclared reserve remains useful evidence of Bernard's direction; it never becomes a secret perfect solution.

## Outputs and Rewards

- `bernard_long_table_network`: open, dependent, captured, or failed;
- `long_table_shelter_state`: four-linked, three-linked, isolated, or damaged;
- `long_table_route_state`: service-lane, public-lane, underways, or closed;
- `long_table_contribution_state`: mutual, Yard-led, sponsor-owned, or unrecorded;
- `bernard_winter_reserve_tell`: named, discovered, concealed, or absent.

The open or useful network becomes an Act II preparation asset for [[Embers Without Excuse]] and changes ambient shelter movement for the rest of winter.

## Navigation

- [[Bernard Companion Campaign]]
- [[Bernard Valeon]]
- [[Bernard Compulsion and Accountability System]]
- [[Embers Without Excuse]]
- [[Blackjack Yard]]
- West Refuge Hall
- [[Companions MOC]]
