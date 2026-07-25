---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Upper Grenz"]
culture: ["Ättar", "Grey-Wolf", "Eclessian", "Folk"]
related_factions: ["Blackjack Corps", "Duchy of Grenzburg"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-1
availability_window: ["Open Autumn", "Late Autumn"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["ylva_shared_signal_code", "ylva_direction", "fellwater_signal_state", "black_fir_watch_state", "tann_crossing_relay_state", "road_spoofers_state"]
reward_unlocks: ["All-Weather Flare Arrow", "Reinforced Blunt-Head"]
required_locations: ["Fellwater Camps", "Black Fir Watch", "Tann Crossing"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-operation
companion_campaign_stage: act-1
quest_owner: "Ylva Winter-Track"
quest_sequence: 2
companion_id: "CMP-03"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: "The Fourth Marker completed"
estimated_hours: 0.75
gameplay_pillars: [route-building, social-coordination, signal-puzzle, skirmish]
required_states: ["ylva_recruited"]
optional_state_inputs: ["ylva_fourth_marker_restored", "folk_standing", "ducal_route_support"]
field_experience_gate: []
companion_required: "Ylva Winter-Track"
duo_quest: false
pause_points: ["Two Stations Agreed", "Relay Tested"]
relationship_gate: ""
relationship_variant: ""
preparation_inputs: ["ylva_fourth_marker_restored"]
preparation_threshold: ""
autonomous_deadline: "The Last Convoy"
autonomous_resolution: "Ylva establishes a working code but keeps its interpretation dependent on herself"
changed_reentry: "Relay After Frost"
ensemble_inputs: ["Ilyana Veshkar", "Dismas Raben", "Bernard Valeon"]
identity_hooks: ["Ättar", "Folk", "Military", "Wilderness", "Peasant/Labour", "Hunter"]
encounter_deck: ["false road signal", "Upper Grenz bandits", "autumn storm"]
persistence_scope: regional-milestone
postgame_season: ""
---
# A Signal Shared

## Quest Function

This normal-party operation turns Ylva's private route notation into a public warning relay held by three independent teams. It prepares [[The Rearguard Road]] and establishes that a robust signal system must remain useful when its creator is absent.

## Trigger

After [[The Fourth Marker]], three south-road stations use incompatible warning practices:

- Fellwater Camps use cloth direction and mill bells;
- Black Fir Watch uses cut marks and shuttered lamps;
- Tann Crossing uses ducal horn calls.

Ylva has translated all three into her private book. A false all-clear appears between stations, proving that a stolen symbol can redirect traffic while no one else knows how to verify it.

## Beginning: Three Ways to Say Run

The party visits the stations in any order. Each team has a valid objection:

- Fellwater will not abandon a signal readable by children and mill workers.
- Black Fir refuses bright permanent marks that expose shelters.
- Tann Crossing requires a code an officer can audit during mobilization.

The player is not choosing a winning culture. The shared code must preserve local signals while adding a common emergency layer:

1. direction;
2. hazard;
3. time seen;
4. confirmation from a second station.

Ylva initially offers to remain the translator between all three.

## Middle: Build the Relay

Each station supplies a compact authored task:

### Fellwater Camps

Recover a bell clapper and weather cloth from a flooded mill race. The player may use the wheel controls, cross the service beams, or wade a secured shallow line. The task teaches visible public signals.

### Black Fir Watch

Map a concealed line through dense timber and identify two old marks now pointing toward a collapsed shelf. The party must decide which paths remain secret and which emergency approach can be published.

### Tann Crossing

Test horn intervals amid cart noise and wind. The player places three listeners, alters timing, and prevents a draft team from panicking when an unannounced test begins.

Every task produces information even when performed poorly. The consequence is slower confirmation, damaged supplies, or reduced trust rather than a blocked relay.

## Signal Spoofers

Three ordinary road thieves have copied Ylva's private mark from the Fourth Marker and are using it to redirect pack animals toward a hidden unloading point.

The party can:

- trace the repeated mark;
- plant a false confirmation;
- follow a diverted empty cart;
- wait at the unloading point;
- persuade one frightened porter to identify the buyers.

The thieves may flee, surrender, be captured, or die in justified combat. They are not a recurring faction and have no connection to Ylva's past.

## Final Test

A cold rain closes visibility during the relay's first full test. Each station receives incomplete information about:

- a slipped timber cart;
- two children on the wrong side of a ford;
- and a harmless charcoal plume mistaken for a road fire.

The player assigns confirmation responsibility. Ylva must remain at one station instead of running between all three.

Strong results require trusting local teams:

- Fellwater secures the children;
- Black Fir identifies the false fire;
- Tann Crossing stops the cart flow.

If Ylva overrides every station, people survive but the code remains dependent on her and `ylva_direction` moves toward managed or self-spent.

## Decision

The finished code may be:

- publicly posted at staffed road points;
- held by named local custodians with public emergency signs;
- filed under ducal authority with local amendments protected;
- kept as Ylva's proprietary system.

Only the first three supply `ylva_shared_signal_code`. No faction route is inherently required.

## Fail-Forward

- **Station refuses:** a practical demonstration earns limited participation.
- **Spoofers escape:** the shared confirmation step defeats their copied mark.
- **Test misread:** one rescue is slower and stores are damaged, but the error identifies the weak interval.
- **Ylva centralizes control:** the relay works for autumn but enters winter with an autonomous vulnerability.
- **Party defeat at unloading point:** road staff recover the party after the thieves abandon heavy goods; the thieves remain an encounter-deck threat.

## Rewards

- `ylva_shared_signal_code`
- **All-Weather Flare Arrow**, account-wide.
- **Reinforced Blunt-Head**, account-wide.
- Ylva automatically gains both preparations.
- access to [[The Rearguard Road]] readiness.

## Navigation

- [[Ylva Companion Campaign]]
- [[Ylva Winter-Track]]
- [[Ylva Rescue Hunter Package]]
- [[The Fourth Marker]]
- [[The Rearguard Road]]
- [[Upper Grenz]]
