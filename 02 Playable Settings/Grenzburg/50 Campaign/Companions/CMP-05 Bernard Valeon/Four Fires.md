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
world_state_outputs: ["bernard_four_fires_plan", "four_shelters_state", "winter_fuel_state", "warming_routes_state", "four_fires_distribution_state"]
reward_unlocks: ["Four Fires Plan", "shelter preparation"]
required_locations: ["Blackjack Yard", "Mercy Hospital", "West Refuge Hall", "Outer Winter Camps"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: operation
companion_campaign_stage: act-2
quest_owner: "Bernard Valeon"
quest_sequence: 5
companion_id: "CMP-05"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: preparation
estimated_hours: 0.75
gameplay_pillars: [relief-logistics, exploration, protection, rescue]
required_states: ["bernard_act1_chapter_resolved", "winter_siege_active"]
optional_state_inputs: ["lantern_ward_condition", "mercy_hospital_state", "blackjack_yard_state", "longlake_travel_state", "winter_fuel_supply"]
field_experience_gate: []
companion_required: "Bernard Valeon"
duo_quest: false
pause_points: ["Shelter Plan Declared"]
relationship_gate: ""
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "Ghor at the Gate"
autonomous_resolution: "Three shelters remain open and the fourth consolidates late with avoidable exposure; the preparation asset is lost"
changed_reentry: "Shelter damage and exposure remain visible; the original distribution cannot be replayed"
ensemble_inputs: ["Ilyana Veshkar", "Ylva Winter-Track", "Zafir ibn Samad"]
identity_hooks: []
encounter_deck: []
persistence_scope: district-persistent
postgame_season: ""
---
# Four Fires

## Quest Function

This is Bernard's short Act II operation. Four winter shelters have honest and immediate claims on a fuel delivery that plainly heats only three if nothing else changes. The player is not choosing which group deserves cold; the operation asks how much practical work can expand a finite supply.

There is no theft, false claimant, hidden cult, or official who caused the shortage. Siege damage, river ice, poor fuel quality, and simultaneous need are sufficient.

## The Four Shelters

1. **Mercy Annex:** fever and exposure patients whose stove cannot safely go dark.
2. **Debtors' Row Warming Room:** Blackjack households, elderly debtors, and night workers.
3. **West Refuge Hall:** Chapel-Folk and displaced Longlake households.
4. **Funnel Warming Tent:** recent refugees outside the walls awaiting placement.

Each shelter has a named steward, a visible population, and one practical weakness. No shelter is secretly empty or stocked well enough to make the decision trivial.

## Hook

Brina receives three usable fuel sleds and four sealed requests. Bernard asks that the company count them in public before movement.

Inspection reveals:

- one sled carries wet timber beneath dry surface pieces;
- one Mercy flue loses most of its heat;
- West Refuge Hall can safely consolidate part of its population;
- an abandoned charcoal cart remains beyond a damaged Lantern Ward lane.

These are opportunities, not a hidden perfect answer. Keeping all four fires requires work and risk.

## Operation States

### Shelter Heat

Track each shelter as `steady`, `failing`, `consolidated`, or `cold`. A cold shelter evacuates with injuries rather than producing off-screen deaths.

### Fuel Loads: 3 plus 1 recoverable

The three delivered loads may be split, dried, redirected, or consumed. The charcoal cart supplies a fourth load if recovered before ice and bombardment ruin it.

### Route Pressure: 0-3

Delay, visible convoys, Grobi probing fire, and failed lane clearance raise pressure. It changes escorts and damage without revealing a coordinated plot against the shelters.

## Beginning: The Count in the Yard

The normal field party inspects the loads and hears all four stewards. Bernard insists upon:

- quantity and condition spoken aloud;
- a named destination for every load;
- a witnessed reserve only when its release condition is stated;
- no promise that cannot physically be fulfilled.

The player may plan direct distribution, consolidation, technical repair, or recovery of the charcoal cart.

### Pause Point: Shelter Plan Declared

After the destinations are recorded, the operation may pause. Resuming reforms the normal party at the Yard with loads and heat states preserved.

## Middle: Expanding the Supply

The operation offers four tasks in player-selected order:

### Dry the Wet Load

Use the Great Forge waste-heat lane, a protected Warlock drying script, or ordinary racks and labor. Every route costs time or escort capacity.

### Repair Mercy's Flue

Clear collapsed brick and rebuild the draw. No vocation is required; technical skills make the work faster.

### Consolidate West Refuge

Move willing households into two heated rooms without erasing kin groups, accessibility, or privacy. Coercive crowding preserves fuel but damages trust.

### Recover the Charcoal Cart

Cross a damaged Lantern lane, free two trapped carters, and bring the load through Grobi probing fire. The Grobi seek fuel and captives for their own war camp; they are not agents in Bernard's story.

## End: Four Visible Fires

The final distribution occurs before all four stewards. Possible material results include:

- four steady fires;
- three fires and one orderly consolidation;
- one cold shelter evacuated with injuries;
- multiple failing shelters after lost fuel or delay.

Bernard may propose retaining one unmarked sack of charcoal beneath the Yard infirmary stairs. Naming the thought before acting supports `truthful`; requiring the player to discover it supports `uncertain`; concealing it supports `withholding`.

## Vocation Access

Every player vocation can complete every task through ordinary carrying, tools, ladders, carts, escorts, and negotiation.

- Fighter and Paladin protect convoys and move collapsed material.
- Slayer opens roof and lane shortcuts.
- Hunter reads safe cart and weather routes.
- Warlock accelerates drying or flue work; ordinary tools preserve the baseline route.
- Medium and Binder forms assist scouting and hauling within their existing moral limits.

No shelter survival depends on one vocation or companion.

## Fail-Forward Results

- A lost fuel load forces consolidation or evacuation.
- A failed flue repair moves Mercy patients rather than killing them invisibly.
- If the charcoal cart is captured, it may be recovered at a defended lane or abandoned to preserve the carters.
- If the party is defeated, city crews save the nearest shelter while another goes cold.
- Public overpromising damages trust and does not create extra fuel.

## Outputs

- `bernard_four_fires_plan`: true or false;
- `four_shelters_state`: all-warm, three-warm, consolidated, or evacuations;
- `winter_fuel_state`: sufficient, stretched, lost, or captured;
- `warming_routes_state`: open, damaged, escorted, or closed;
- `four_fires_distribution_state`: witnessed, improvised, sponsor-controlled, or concealed.

## Autonomous Resolution

Without the player, Bernard, Brina, and shelter stewards keep three fires steady. The fourth shelter consolidates only after avoidable exposure injuries. Bernard performs useful work under Brina's count, but no tested Four Fires plan is created.

## Rewards

- the Act II preparation asset;
- persistent shelter heat and service changes;
- a companion intervention improving Bernard's winter evacuation behavior.

## Navigation

- [[Bernard Companion Campaign]]
- [[Bernard Valeon]]
- [[Bernard Compulsion and Accountability System]]
- [[Embers Without Excuse]]
- [[Blackjack Yard]]
- [[Cathedral Close#Anchor Locations|Mercy Hospital]]
- [[Longlake Ward#Anchor Locations|West Refuge Hall]]
- [[Companions MOC]]
