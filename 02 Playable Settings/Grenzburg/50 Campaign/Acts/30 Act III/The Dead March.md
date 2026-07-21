---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Upper Grenz", "Highlake Uplands", "Frostfenn March"]
culture: ["Eclessian", "Folk", "Qianglong"]
related_factions: ["Duchy of Grenzburg", "Blackjack Corps", "Folk kindreds", "Church of the Redeemer"]
appears_in: ["Grenzburg"]
needs: []
aliases: []
tags: [game-ready]
quest_class: main
act: act-3
availability_window: ["Muster Crisis"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["upper_grenz_front", "tuskway_front", "fenn_road_front", "final_assault_strength"]
required_locations: ["Upper Grenz", "Tuskway", "Fenn Road", "Fort Tannbruck", "Last Hearth"]
blocking_status: blocked
quest_owner: "Grenzburg Main Campaign"
quest_sequence: 0
companion_id: ""
faction_line: ""
faction_branch: ""
chapter_id: "MQ-20"
main_sequence: 20
story_gate: finale-transition
estimated_hours: 3.0
gameplay_pillars: [large-combat, command-response, traversal, rescue, defense]
required_states: ["gerhold_command_severed", "muster_anchor_threshold_met"]
optional_state_inputs: ["muster_anchor_count", "muster_acceleration", "emerald_law_gem_custody", "spring_settlement_access", "all_faction_progress", "all_companion_states"]
---
# The Dead March

## Chapter Function

This is Act III's regional war set piece and the final preparation for the Deep Muster. The player cannot personally command three armies or save every road. They act as the specialist unit that resolves the decisive problem on each front while prior settlement, faction, companion, and anchor work determines what can hold without them.

## Trigger and Commitment

Gerhold's severed command causes the Muster to classify every northern road as a hostile front. Before the player begins, the campaign displays:

- every remaining active anchor and the boss power it will preserve;
- quests that close or transform when the march starts;
- each front's current people, services, and defensive support;
- the warning that remaining anchor operations will become inaccessible until after the altar is destroyed.

Confirming begins the Muster Crisis and a closed three-front sequence.

## Beginning: Three Fronts Move

The counteroffensive advances simultaneously:

- **Upper Grenz:** recent-dead reinforcements and siege engines drive toward Tannbruck and Timberfalls.
- **Tuskway:** banner commands impose false rank and coordinated movement on defenders.
- **Fenn Road:** black mud, eel-burrow movement, and old formations attempt to isolate Last Hearth.

The player chooses which front to reach first. Inactive companions and faction forces can be assigned to support fronts if available, but all three retain a baseline defense.

## Middle: Specialist Interventions

Each front has one decisive operation:

### Upper Grenz Front

Destroy a mobile command battery before it crosses Tann Bridge. If the River Arsenal anchor remains active, siege volleys and rebuilt artillery add a boss phase. Saved Tannbruck assets, ducal progress, and winter survivors improve the line.

### Tuskway Front

Reach the living standard-bearers and break a rank loop causing friendly formations to obey false withdrawals. If the Banner Vault remains active, imposed movement and formation-control effects persist. Folk pathfinders and upland settlement access supply better approaches.

### Fenn Road Front

Keep the retreat and supply causeway open while cutting black-mud channels around Last Hearth. If the Fen Ossuary remains active, formations regenerate and travel beneath the mire. Uru's corridor state and local route survival alter who is caught between armies.

The player's order changes exhaustion, losses, and which emergency grows while they are elsewhere. No front disappears merely because it was not selected first.

## End: The Road South

After the third intervention, the remaining formations receive one recall and withdraw toward the Deep Muster. The player may pursue immediately to preserve surprise or pause for one bounded recovery scene. `final_assault_strength` is calculated from:

- three front states;
- number of destroyed anchors;
- Last Hearth condition;
- Gerhold's acceleration;
- faction and companion support actually preserved;
- Emerald law-gem custody aid.

Even the weakest state can enter and complete the finale. Strength changes allied casualties, available approaches, recovery nodes, and support objectives.

## Encounters and Set Pieces

- strategic front selection with visible consequences;
- Tannbruck bridge battery assault;
- Tuskway false-command rescue and standard fight;
- Fenn Road moving defense across unstable mire;
- traveling field camp that reflects companion and faction states;
- final pursuit to the Deep Muster Approaches.

## Information Paths

Anchor records explain each front's mechanism. Scouts, refugees, signals, and physical signs identify current pressure. Missing intelligence shortens preparation time or obscures one optional objective; it never removes the front.

## Choices and State Changes

- `upper_grenz_front` records holds, damaged, evacuated, or overrun-and-recovered.
- `tuskway_front` records holds, fractured, isolated, or recovered.
- `fenn_road_front` records holds, contaminated, evacuated, or recovered.
- `final_assault_strength` resolves as strong, viable, strained, or desperate.

The player assigns available companions and faction support with clear risk warnings. Nobody dies from an untelegraphed menu choice; sacrifice requires an explicit later scene.

## Fail-Forward Results

- Failing a front objective worsens its world state and adds a finale pressure.
- A front may evacuate rather than be annihilated, preserving people while losing land and service.
- Party defeat advances the other two fronts and resumes at a fallback position.
- Weak support removes conveniences, never critical-vocation access.
- Active anchors express their stated powers without adding unrelated new lore.

## Companion Intersections

Every recruited companion receives a possible front assignment tied to vocation and resolved arc. Active companions accompany the player; inactive companions act only when available and willing. Compromised arcs give narrower support, while broken or departed companions remain absent.

## Faction Advantages

Each principal faction can hold one kind of pressure: marcher line defense, Blackjack shock work, Church casualty and sanctuary support, Folk route protection, or underworld supply and evacuation. No faction is required and no political settlement is selected here.

## Cutoff and Unlocks

Completion closes remaining anchor operations and begins [[The Deep Muster Main Quest|The Deep Muster]]. The player receives one final equipment, party, and route-selection opportunity at Last Hearth before descent.

## Navigation

- [[Muster Anchor Matrix]]
- [[Deep Muster Approaches]]
- [[The Deep Muster Main Quest|The Deep Muster]]
- [[Season and World-State Constitution]]
- [[Main Campaign MOC]]
