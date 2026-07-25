---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Lantern Ward"]
culture: ["Ättar", "Grey-Wolf", "Eclessian"]
related_factions: ["Blackjack Corps", "Duchy of Grenzburg"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-2
availability_window: ["Early Winter", "Winter Siege"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["ylva_lantern_ward_signal_chain", "ylva_direction", "lantern_rooftop_stations_state", "debtors_row_warning_state", "west_alley_receivers_state"]
reward_unlocks: ["Smoke Arrow", "Lantern Signal Chain"]
required_locations: ["Lantern Ward", "Blackjack Yard", "Debtors' Row", "West Wall"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-operation
companion_campaign_stage: act-2
quest_owner: "Ylva Winter-Track"
quest_sequence: 5
companion_id: "CMP-03"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: "Winter's Teeth"
estimated_hours: 0.75
gameplay_pillars: [urban-traversal, civilian-coordination, signal-drill, defensive-skirmish]
required_states: ["ylva_recruited", "winter_siege_active"]
optional_state_inputs: ["ylva_shared_signal_code", "city_in_siege_preparations", "blackjack_yard_state"]
field_experience_gate: []
companion_required: "Ylva Winter-Track"
duo_quest: false
pause_points: ["Three Stations Staffed", "Full Chain Tested"]
relationship_gate: ""
relationship_variant: ""
preparation_inputs: ["ylva_shared_signal_code", "ylva_western_breach_route_known"]
preparation_threshold: ""
autonomous_deadline: "Ghor at the Gate"
autonomous_resolution: "Ylva builds a useful chain but assigns herself as the only moving verifier"
changed_reentry: "Ice After Thaw"
ensemble_inputs: ["Ilyana Veshkar", "Tavio Meran", "Bernard Valeon"]
identity_hooks: ["Ättar", "Military", "Underworld", "Peasant/Labour", "Wilderness", "Hunter", "Slayer"]
encounter_deck: ["Lantern Ward rooftop hazard", "Grobi river probe", "winter fire"]
persistence_scope: seasonal-milestone
postgame_season: ""
---
# Signals Over Lantern Ward

## Quest Function

This normal-party winter operation creates a resident-held warning chain across Lantern Ward before the western breach. It transforms Ylva's rural signal craft into an urban network and prepares both [[The City in Siege]] and [[What the Ice Takes]].

The quest succeeds only when residents can operate the system without Ylva running every message herself.

## Trigger

Outer fires and false alarms have made the ward ignore ordinary bells. The wall watch can see the frozen river but cannot reliably warn Debtors' Row, the Blackjack Yard, west-alley shelters, and the Millwheel pumps at the same time.

Koss proposes one roaming Blackjack signaler: Ylva.

Ylva accepts before Brina finishes reading the assignment. The player may intervene immediately or let the first test expose the flaw.

## Beginning: Name the Stations

The party surveys four linked positions:

1. **West Wall cap:** sees the river approach.
2. **Dyers' Roof:** carries colour and smoke above crowded alleys.
3. **Debtors' Row pump loft:** reaches the housing courts.
4. **Blackjack Yard tower:** coordinates response and receives casualties.

Each station requires:

- a visible day signal;
- a low-light signal;
- a confirmation method;
- a named primary and relief crew;
- a safe descent when the roof becomes untenable.

The player recruits crews through neighbourhood trust, faction contacts, payment, civic authority, or practical demonstration. No one faction is required.

## Middle: Build and Test

### Roof Routes

The party secures ladders, hatchways, and two ordinary rooftop gaps. Shared traversal works for every vocation. Slayer and Hunter gain faster routes; Fighter can stabilize ladders; Warlock can clear ice with bounded heat; Medium can distract residue around an old fire site; Bard and advanced vocations offer support without becoming keys.

### Signal Materials

The network needs:

- wet-weather flare caps;
- coloured shutters;
- cool smoke pots;
- bell dampers;
- marked evacuation cloth;
- written station cards.

The player chooses whether the cards are public, restricted to residents, or held by officers. A public emergency code with guarded military details gives the strongest civic result.

### Independent Drill

Ylva must remain at one station while the other three run a drill. The player selects where she stands.

The drill includes:

- a simulated wall sighting;
- a false fire report;
- one blocked alley;
- a casualty message;
- a deliberate station silence testing the relief crew.

If Ylva abandons her station to correct each mistake, the chain technically passes but remains dependent on her.

## Real Pressure

During the final drill, a small Grobi river probe uses the noise to approach a wall drain while an accidental brazier fire starts in a roof store.

These events are concurrent but unrelated. The Grobi did not arrange the fire.

The party chooses its immediate focus while the resident stations handle the other:

- intercept the river probe;
- contain the roof fire;
- protect a descending signal crew;
- keep the warning moving despite one lost station.

The test is whether the network distributes response. Strong preparation allows every station and resident to survive. Failure costs a roof, supplies, or route speed rather than invalidating the chain.

## End: Who Holds the Code

The completed network may be placed under:

- resident station crews coordinated from the Yard;
- ducal wall command with guaranteed local access;
- Blackjack control with Brina's public roster;
- Ylva as sole verifier.

The first three can produce `ylva_lantern_ward_signal_chain` if relief crews are named. Sole control moves Ylva toward managed or self-spent.

## Fail-Forward

- **Crew refuses:** the station is moved to a nearby public building with slower coverage.
- **Roof route fails:** a street relay replaces it.
- **Fire destroys a station:** its relief crew activates from a lower window.
- **Grobi reach the drain:** the party fights them in the service passage and gains precise breach intelligence.
- **Ylva runs every message:** the ward is warned, but the Act II finale loses one autonomous safeguard.
- **Party defeat:** the wall watch drives off the probe after losses; the resident chain survives in reduced form.

## Rewards

- **Smoke Arrow**, account-wide.
- `ylva_lantern_ward_signal_chain`
- persistent warning and evacuation advantages in [[The City in Siege]].
- Act II preparation for [[What the Ice Takes]].

## Navigation

- [[Ylva Companion Campaign]]
- [[Ylva Winter-Track]]
- [[Ylva Rescue Hunter Package]]
- [[The City in Siege]]
- [[What the Ice Takes]]
- [[Blackjack Yard]]
