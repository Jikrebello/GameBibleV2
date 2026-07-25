---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenz Lowlands", "Grenzburg northern road"]
culture: ["Eclessian", "Grobi"]
related_factions: ["Blackjack Corps", "Medori Bank"]
appears_in: ["Grenzburg"]
needs: []
aliases: ["The Black Road Quest"]
tags: [game-ready]
quest_class: main
act: prologue
availability_window: ["Black Road"]
repeatability: one-shot
cutoff_result: persists
world_state_outputs: ["black_road_survivors", "black_road_cargo", "toll_band_state", "grobi_scout_warning"]
required_locations: ["The Black Road", "Old Coach Burn", "Black Road Quarry"]
blocking_status: blocked
quest_owner: "Grenzburg Main Campaign"
quest_sequence: 0
companion_id: ""
faction_line: ""
faction_branch: ""
chapter_id: "MQ-01"
main_sequence: 1
story_gate: open
estimated_hours: 1.25
gameplay_pillars: [combat, traversal, rescue, pursuit]
required_states: []
optional_state_inputs: []
---
# The Black Road

## Chapter Function

The opening teaches character creation, shared movement, combat, rescue, interaction, party roles, and fail-forward play through one grounded emergency. It introduces debt as the reason the protagonist is present, not as a lecture about the Bank. The first human attackers and the first Grobi are visibly independent threats.

## Trigger and Commitment

The game begins inside a northbound debtor convoy on [[The Black Road]]. Character creation occurs through the player's intake card, issued equipment, conversations during a walking halt, and a short supervised combat drill. The convoy then descends toward the old quarry crossing at [[Old Coach Burn]]. No content exists before the crisis and no warning is required.

## Hook and Immediate Stake

Former toll-contractor Harl Venn and twenty-one **Broken Axle Tollers** have cut the crossing's lower trestles. When the first heavy wagon enters, they release a stone cart from [[Black Road Quarry]]. The bridge folds, three wagons overturn, and the rear column stops beneath prepared bow positions.

The Tollers want food, powder, saleable equipment, and debtor hostages. Their wages and road lease were genuinely terminated without compensation after repeated extortion complaints. That grievance explains their local knowledge; it does not excuse deliberate mass killing and kidnapping.

Smoke and noise draw a six-member Grobi scouting knot. The Grobi attack the exposed southern flank, take food from bodies, and try to carry one wounded carter away. Harl's people are surprised by them and fire on them when paths cross.

## Beginning: The Crossing Breaks

The player recovers from the wreck beside [[Ilyana Veshkar]], whose handler is stunned. Ilyana takes practical command of the immediate rescue without claiming permanent authority.

Three priorities become visible at once:

1. **People:** a passenger wagon hangs over the ravine; two debtors are pinned beneath a wheel; a carter is bleeding beside the Grobi approach.
2. **Material:** medicine burns beside a lamp-oil spill; the powder wagon is rolling toward the broken span; the convoy's sealed service chest lies within bandit bowshot.
3. **Warning:** a Toller runner is climbing toward the quarry signal basket and can alert the reserve camp.

The player can address all three with fast execution, but no order is declared morally mandatory. The situation teaches that delay changes cost rather than waiting politely.

[[Bernard Valeon]] establishes a casualty point behind an overturned wagon. He asks the player to bring people rather than pretending his treatment can reach everyone. [[Dismas Raben]] marks a climbable drainage cut, identifies the runner's path, and admits that the Tollers have prepared a second firing line.

## Middle: Break the Ambush

Once one rescue priority is secured, Ilyana leads surviving Blackjacks against the bow line. The player chooses one of three approaches:

- climb the quarry drainage with Dismas and strike the Tollers' flank;
- cross beneath the broken bridge and emerge behind their stone barricade;
- hold the road, use recovered powder or warlock fire to break cover, and advance directly.

Every starting vocation can use every route. Slayer movement, Hunter tracking, Warlock counter-scripts, Medium imprints, and Fighter protection alter speed and encounter shape rather than access. Advanced vocations add later-playthrough options without being assumed by the prologue.

The Grobi scouts strike during the advance. The player can drive them away, kill them, or prevent their leader from escaping with a ducal route marker. There is no dialogue branch that turns the scouting knot into allies.

## End: The Quarry Signal

Harl withdraws toward the quarry hoist with any surviving Tollers and captured cargo. The player confronts him while the damaged hoist threatens to drop a stone skip onto the road.

Harl may be killed, captured, or driven into the quarry back-country. Capture requires stopping the skip and breaking his fighters; a social check can then secure surrender but cannot erase their crimes. If he escapes, he becomes the organizing human enemy in [[The Closing Roads]]. If he dies or is captured, his lieutenant takes that role with fewer resources.

The survivors pull away before the crossing collapses completely. Night camp is made at a road shrine north of Funnel Camp. Ilyana returns formal command to the convoy officer, Bernard records every handled possession, and Dismas reports that at least one Grobi scout carried a sketch of the southern roads.

## Encounters and Opposition

- collapsing bridge traversal and timed rescues;
- Toller archers, shielded road-cutters, and the signal runner;
- opportunistic Grobi scouts attacking both convoy and Tollers;
- quarry drainage climb or under-bridge crossing;
- Harl's hoist position and falling stone skip.

The Tollers use human tactics: overwatch, hostages, smoke, and retreat. The Grobi use hunger-driven rushes, food theft, and rapid withdrawal. Their silhouettes, sounds, goals, and loot remain distinct.

## Information Paths

Harl's old toll badge, cut trestle wedges, and a surviving road worker independently establish human sabotage. Grobi tracks arrive from the south after the collapse; a captured Toller curses them as unexpected scavengers; Dismas can reconstruct the timing. No required understanding depends on one check.

## Choices and State Changes

- `black_road_survivors` records named survivors and a broad strong, wounded, or shattered convoy state.
- `black_road_cargo` records medicine, powder, service chest, and ordinary stores separately.
- `toll_band_state` becomes broken, leaderless, captured, or escaped-organized.
- `grobi_scout_warning` becomes none, partial, or recovered-map depending on the route marker and escaping scouts.

The choices alter later help, evidence, and material. They do not decide whether the player reaches Grenzburg.

## Fail-Forward Results

- A missed hanging-wagon rescue produces wounded and one named death; surviving passengers still identify a Toller.
- Burning medicine reduces early healing stock but opens an emergency Church supply scene.
- A lost service chest strengthens Koss's leverage but does not erase the player's identity or contract.
- An escaped runner reinforces the quarry camp encountered in MQ-03.
- If Harl escapes, his later force is stronger; if he is captured, the Tollers splinter and a lieutenant continues the road threat.

## Companion Intersections

- Ilyana demonstrates command under fire and reacts to whether the player protects people or follows the cleanest tactical line.
- Bernard teaches recovery and witnessed property without opening his personal quest.
- Dismas teaches tracking, route reading, and the difference between retreat and abandonment.

These companions are temporarily available during the prologue. Formal party access is established in [[Warrant at the Gate]].

## Faction Advantages

No prior faction state exists. Character background and cultural knowledge alter dialogue, identification, and rescue efficiency, never the existence of a solution.

## Cutoff and Unlocks

Completion advances to the road-shrine camp and immediately starts [[Warrant at the Gate]]. It unlocks the companion party tutorial, camp conversation, inventory division, and the first visible convoy-state summary.

## Navigation

- [[PROLOGUE THE BLACK ROAD]]
- [[Warrant at the Gate]]
- [[Main Campaign MOC]]
- [[Main Campaign State Matrix]]
