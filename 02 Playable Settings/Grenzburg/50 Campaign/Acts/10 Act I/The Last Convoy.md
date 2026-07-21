---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Upper Grenz", "Longlake Country", "Highlake Uplands"]
culture: ["Eclessian", "Folk", "Grobi"]
related_factions: ["Duchy of Grenzburg", "Marcher Vanguard", "Blackjack Corps", "Folk kindreds"]
appears_in: ["Grenzburg"]
needs: []
aliases: []
tags: [game-ready]
quest_class: main
act: act-1
availability_window: ["Late Autumn"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["last_convoy_people", "last_convoy_material", "last_convoy_route"]
required_locations: ["Fort Tannbruck", "Tann Crossing Farms", "Upper Grenz", "Tuskway Redoubt", "Lakewatch"]
blocking_status: blocked
quest_owner: "Grenzburg Main Campaign"
quest_sequence: 0
companion_id: ""
faction_line: ""
faction_branch: ""
chapter_id: "MQ-07"
main_sequence: 7
story_gate: season
estimated_hours: 1.5
gameplay_pillars: [traversal, defense, rescue, social]
required_states: ["autumn_operations_completed"]
optional_state_inputs: ["autumn_road_support", "three_mills_road", "southbound_convoy", "watch_hill_signals", "folk_road_claim", "all_companion_states", "all_faction_states"]
---
# The Last Convoy

## Chapter Function

This is the player-controlled Late Autumn gate. It converts autumn preparation into moving people and material rather than abstract bonuses, puts companions and factions in delegated roles, and positions Tannbruck for its unavoidable fall.

## Trigger and Commitment

After three autumn operations, Liese reports that Ghor's scouts have crossed the southern marker in force. Pierre orders the frontier stores and exposed households pulled north. Accepting displays every unfinished Open Autumn quest and its stated cutoff result. Once confirmed, the operation runs continuously until the convoy reaches Tannbruck.

## Hook and Immediate Stake

Three columns must move through narrowing weather and hostile roads:

1. **People:** farm households, wounded scouts, and prisoners who cannot march quickly.
2. **Sustenance:** flour, smoked fish, medicine, fuel, and seed grain.
3. **Defense:** bridge engineers, artillery fittings, forge stock, and signal equipment.

The baseline network can fully protect one column and partly protect another. Every relevant autumn operation adds capacity, a safer route, or a delegation option. Strong preparation can bring all three through without inventing a final arbitrary sacrifice.

## Beginning: Divide the Road

At Tann Crossing Farms, the player assigns routes and escorts:

- the central Upper Grenz road is fastest but watched by Ghor;
- the eastern Tuskway route is defensible but exposed to Shattered-Tusk raiders;
- the Longlake route is slower and requires a working bridge or ferry.

The player personally accompanies one column. Available companions and trusted faction officers lead delegated columns. Without those allies, named marcher captains take the assignments with lower but functional capacity.

## Middle: Three Pressures

The accompanied route receives its full set piece:

- **Central:** Ghor's vanguard cuts the column at Three-Log Bridge, forcing moving defense and a rapid bridge repair or ford crossing.
- **Eastern:** Harek's remaining road-raiders attack at a narrow cairn while noncombatant Folk households try to leave the same front.
- **Western:** bandit boats and worsening wind trap ferries between Lakewatch and the north road.

Delegated routes resolve visibly from their assigned leader, road states, supplies, and prior local outcomes. The player receives signals during the mission and may divert once at the cost of leaving the first column under its delegated commander.

## End: The Gates of Tannbruck

The columns converge outside Fort Tannbruck as the first hard frost closes the southern road. A final Grobi probe tries to seize the last wagons before the lower gate shuts. The player holds the farm lane and decides whether damaged wagons are dragged inside, stripped at the gate, or burned.

Ghor's distant horns answer from more than one corridor. Hedda closes the fort, Pierre rides north to prepare Grenzburg, and Gerhold remains to command the initial defense. The player is given one open fort interval to speak with survivors and prepare before starting [[Tannbruck Falls]].

## Encounters and Opposition

- route and escort assignment;
- one full route-specific traversal and defense set piece;
- reactive reports from delegated columns;
- final farm-lane rearguard at Tannbruck.

Bandits, Folk road-raiders, and Ghor's vanguard remain independent. Their simultaneous pressure comes from the same closing roads and weather, not shared command.

## Information Paths

Watch Hill signals, local road reports, scouts, and autumn operation outputs make route risks explicit before assignment. The journal names what each escort can protect. No result is hidden behind an unexplained percentage.

## Choices and State Changes

- `last_convoy_people` records named households, wounded, prisoners, and carriers.
- `last_convoy_material` records food, medicine, fuel, seed, bridge gear, forge stock, and artillery fittings.
- `last_convoy_route` records personal route, delegated leaders, and closed or damaged corridors.

These states directly alter MQ-08, winter stores, available services, and later reclamation.

## Fail-Forward Results

- A broken route diverts its column rather than erasing it; delay creates casualties and abandoned loads.
- A defeated escort leaves survivors in a defensible holdfast that can be recovered during MQ-08's withdrawal.
- Lost food or medicine enters winter scarcity; lost engineers change repair methods.
- Captured people remain recoverable during the fall instead of dying off-screen.

## Companion Intersections

Each active or trusted companion can lead a route suited to their strengths. A compromised companion requires additional support. A broken or departed companion cannot be assigned, but ordinary officers preserve the baseline route.

## Faction Advantages

- Ducal work adds disciplined escorts and bridge authority.
- Blackjacks add specialist teams and equipment capacity.
- Church work protects wounded and medicine.
- Folk work opens witnessed crossings and separates households from raiders.
- Underworld routes conceal one small high-value load through Grenzburg's northward network.

## Cutoff and Unlocks

Completion ends Open Autumn. The player receives a final warning before beginning [[Tannbruck Falls]] that the fort battle is a closed operation and advances the world to winter. Fort conversations, last equipment changes, and survivor triage remain available until that confirmation.

## Navigation

- [[Roads Worth Saving]]
- [[Tannbruck Falls]]
- [[ACT I THE CLOSING ROADS]]
- [[Main Campaign MOC]]
- [[Main Campaign State Matrix]]
