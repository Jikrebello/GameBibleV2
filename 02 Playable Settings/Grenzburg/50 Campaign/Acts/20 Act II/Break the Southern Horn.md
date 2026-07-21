---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Highlake Uplands", "Frostfenn March"]
culture: ["Grobi", "Eclessian", "Folk"]
related_factions: ["Duchy of Grenzburg", "Blackjack Corps", "Bloody-Sun Host", "Stone-Tooth band"]
appears_in: ["Grenzburg"]
needs: []
aliases: []
tags: [game-ready]
quest_class: main
act: act-2
availability_window: ["Deep Winter"]
repeatability: one-shot
cutoff_result: persists
world_state_outputs: ["southern_horn_state", "uru_corridor_state", "stone_tooth_war_state", "skiv_intelligence_state", "ghor_host_cohesion"]
required_locations: ["Highlake Uplands", "Tuskway Redoubt", "Frostfenn March", "Herd Rest"]
blocking_status: blocked
quest_owner: "Grenzburg Main Campaign"
quest_sequence: 0
companion_id: ""
faction_line: ""
faction_branch: ""
chapter_id: "MQ-14"
main_sequence: 14
story_gate: operation
estimated_hours: 2.0
gameplay_pillars: [assault, reconnaissance, diplomacy, large-combat]
required_states: ["emerald_drake_dead", "winter_knives_state"]
optional_state_inputs: ["autumn_road_support", "tannbruck_material", "folk_compact_progress", "blackjack_progress", "skiv_contact"]
---
# Break the Southern Horn

## Chapter Function

This chapter converts knowledge and regional relationships into a military offensive. The player must destroy Ghor's command-horn position, but may first separate three groups whose interests are not identical to his. The operation makes the final siege shorter or harsher without turning Grobi into one moral or political bloc.

## Trigger and Commitment

The Drake is dead, the human strike cell has been stopped, and Pierre has located the horn relay above Tuskway Redoubt. The player chooses when to begin a two-night field operation. Starting it warns that unresolved optional contacts will be decided by their default winter states.

## Hook and Immediate Stake

Ghor-Maw has assembled a frame of hide, horn, and captured signal metal above the upland road. Its calls coordinate bands that otherwise move at different speeds and obey different chiefs. If it survives, the next assault reaches Grenzburg as one army.

The Blackjacks are sent as a specialist shock unit, not as army commanders. Liese holds the withdrawal road; ducal soldiers can exploit an opening but cannot climb the horn position unseen.

## Beginning: Three Fractures

The player reconnoitres from Tuskway Redoubt. Three optional operations become available and may be completed in any order before the horn assault:

### Uru's Corridor

Herd-Matron Uru's dependent train is held near Herd Rest as labor, food pressure, and political hostages. The player can mark a withdrawal corridor, remove human ambushers who intend to massacre the moving camp, and guarantee that ducal scouts will not close the route. Uru withdraws dependents and refuses Ghor one reinforcement wave. She does not become an ally or renounce Grobi predation.

### Stone-Tooth Price

Grakka's Stone-Tooth fighters occupy the lower redoubt. They can be separated by defeating their champion force, proving that Ghor reserves captured food for his own Bloody-Sun bands, or offering bounded withdrawal without rights to raid civilians. Failure leaves them in the horn defense. Skrit may interpret, but cannot make the agreement morally broader than its terms.

### Skiv's Last Chart

Skiv's trader-captains move stores over a frozen branch channel. The player can seize the flotilla, buy one truthful chart while exposing Skiv's double sales, or raid his ledgers. The evidence confirms Ghor's resupply line and the approach used by the Cinder Knives. Skiv remains a profiteer whether he cooperates, flees, or dies.

## Middle: The Relay Climb

The assault has three critical tasks:

1. cross the exposed lower road or a route supplied by autumn support;
2. disable two relay crews before they can concentrate the host;
3. breach the timber-and-ice horn frame while Horn-Captain Ruk directs the defense.

Each unresolved fracture adds a distinct complication: desperate camp followers obstruct the lower field, Stone-Tooth tunnel fighters hold the redoubt, and Skiv's boats resupply the ridge. These are additive pressures, not mandatory failure walls.

## End: The Broken Call

The player destroys the Southern Horn by toppling its frame, burning its hide chambers, shattering the captured signal metal, or overloading it with controlled warlock force. Every vocation can reach and destroy the structure; movement skills alter routes rather than access.

Ruk attempts a final rally. Killing or capturing him prevents one emergency signal. If he escapes, the horn still falls but he leads a reserve in MQ-15.

Ghor's host begins to move before the party returns. The army is now massed, strained, or fractured according to the completed operations, but Ghor remains committed to his final assault.

## Encounters and Opposition

- upland reconnaissance and frozen-route hazards;
- one to three optional fracture operations;
- relay-post infiltration or direct shock assault;
- lower-redoubt battle shaped by Stone-Tooth status;
- multi-level horn-frame destruction under reinforcement pressure;
- fighting withdrawal to Liese's line.

## Information Paths

Captured horn schedules, Skiv's charts, Watch Hill observations, and Folk upland scouts independently reveal relay timing. Uru and Grakka's positions can be learned through direct reconnaissance even if the player has no prior Grobi contacts.

## Choices and State Changes

- `southern_horn_state` becomes destroyed; damage alone is not chapter completion.
- `uru_corridor_state` records withdrawn, trapped, dispersed, or casualties.
- `stone_tooth_war_state` records separated, hostile, destroyed, or three-sided-conflict.
- `skiv_intelligence_state` records secured, partial, false, or unavailable.
- `ghor_host_cohesion` resolves through [[Grobi Host Fragmentation Matrix]].

## Fail-Forward Results

- A failed optional operation returns the group to its hostile or unstable default rather than blocking the horn.
- Alarm concentrates defenders and closes the quiet climb, leaving the fortified road assault.
- Lost demolitions require environmental collapse or manual destruction under pressure.
- A failed withdrawal costs allied troops and begins MQ-15 with the player wounded but does not reverse the horn's destruction.
- If Ruk escapes, he commands one reserve phase at the Gate.

## Companion Intersections

Svala and Dismas read winter movement; Ilyana and Tavio offer distinct destruction methods; Zafir can formalize a bounded withdrawal but cannot bind persons; Ashira can scout with nonhuman imprints; Bernard and Elara protect or infiltrate the dependent route. No companion is required.

## Faction Advantages

Folk compact progress supplies pathfinders, ducal service supplies a diversion, Blackjacks supply demolition equipment, Church work supplies protected casualty stations, and underworld progress can expose Skiv's buyers. None replaces the player's assault.

## Cutoff and Unlocks

Destroying the horn starts Ghor's final mobilization and unlocks [[Ghor at the Gate]]. The player receives a clear warning that beginning MQ-15 ends Deep Winter and resolves unfinished winter-window quests by their cutoff rules.

## Navigation

- [[Grobi Host Fragmentation Matrix]]
- [[The Grobi]]
- [[Frostfenn March]]
- [[Ghor at the Gate]]
- [[Main Campaign MOC]]
