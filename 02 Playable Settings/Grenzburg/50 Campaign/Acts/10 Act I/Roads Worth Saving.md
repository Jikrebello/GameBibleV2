---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenz Lowlands", "Longlake Country", "Wolfsmere Woods", "Southwood Barrowlands", "Highlake Uplands", "Upper Grenz"]
culture: ["Eclessian", "Folk"]
related_factions: ["Duchy of Grenzburg", "Blackjack Corps", "Folk kindreds"]
appears_in: ["Grenzburg"]
needs: []
aliases: []
tags: [game-ready]
quest_class: main
act: act-1
availability_window: ["Open Autumn"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["autumn_operations_completed", "autumn_road_support", "southwood_early_warning", "elara_southwood_route_intelligence", "bernard_longlake_route_secured"]
required_locations: ["Three Mills Reach", "Lakewatch", "Timberfalls", "Highlake", "Grey-Withy Crossing", "Ashfield Lodge"]
blocking_status: blocked
quest_owner: "Grenzburg Main Campaign"
quest_sequence: 0
companion_id: ""
faction_line: ""
faction_branch: ""
chapter_id: "MQ-06"
main_sequence: 6
story_gate: open
estimated_hours: 3.0
gameplay_pillars: [combat, traversal, investigation, social, rescue, defense]
required_states: ["watch_hill_signals", "tannbruck_access"]
optional_state_inputs: ["three_mills_road", "folk_road_claim", "southbound_convoy", "all_companion_states", "all_faction_states"]
---
# Roads Worth Saving

## Chapter Function

This is Act I's principal open-world block. It turns six regions into useful places rather than collectible map sectors and lets the player decide which roads, settlements, and warning systems deserve immediate Blackjack attention. The chapter requires three operations; completing all six is optional and materially rewarded.

## Trigger and Commitment

After Tannbruck's systems are restored, Pierre and Hedda post six unresolved road operations. Each operation is accepted and completed independently. No global timer advances while the player explores, pursues companion quests, joins factions, or performs local work.

After any three operations, Liese offers the Late Autumn transition to [[The Last Convoy]]. The warning names unfinished operations and their transformation results. The player may decline and continue.

## Hook and Immediate Stake

Grenzburg cannot protect every autumn route with soldiers. Mills need water, Lakewatch needs passage, Timberfalls needs its river, Highlake needs carriers, Wolfsmere passage needs a bounded settlement, and Southwood hunters have vanished. The Blackjacks are assigned because each problem requires a small mobile party rather than another garrison.

## Beginning: The Operations Board

The player receives a physical map at Fort Tannbruck and a duplicate board at Blackjack Yard. [[Autumn Operations Matrix]] controls the six operations:

- Water for Three Mills;
- The Lake Road Still Runs;
- Timber on the Grenz;
- Carriers of Highlake;
- Leave to Cross;
- The Quiet Antlers.

Every operation begins with a local person in immediate difficulty, includes travel and field action, and returns the player to a changed service hub. None is a menu-only allocation.

## Middle: Six Regional Operations

### Water for Three Mills

Bandits seize the shared leat and turn three mill households against one another. The player clears the millrace, rescues a trapped keeper, and chooses whether the restored water follows old shares or a temporary winter schedule. Success increases flour capacity.

### The Lake Road Still Runs

Road-raiders damage [[Eel Bridge]] while a storm strands the ferry. The player rescues carriers, reopens one crossing, and establishes who keeps it safe. Success supplies fish, boats, and a northern withdrawal route.

### Timber on the Grenz

Deserters extort Fellwater workers while a broken boom sends logs toward Timberfalls. The player handles the river hazard and camp fight, then prioritizes fuel or structural timber. Success strengthens heat or fortification.

### Carriers of Highlake

Shattered-Tusk fighters demand evacuation of Tuskway Redoubt and threaten civilian carriers. The player may evacuate an overextended outpost, hold it under bounded terms, or defeat the raiders. Success supplies upland scouts and a safer eastern road.

### Leave to Cross

At Grey-Withy Crossing, a valid boundary claim and a campaign of civilian murder have been deliberately conflated. The player learns the permitted route, removes killers from the dispute, and secures passage through witness, force, or both. Success creates a Folk warning route without granting a universal Folk veto.

### The Quiet Antlers

Ashfield hunters disappear beyond Hunter's Last Mark. The player follows animal signs into the edge of an Emerald Drake's expanding order, rescues survivors, and withdraws before the range closes. Success creates `southwood_early_warning` and one preparation in MQ-11.

## End: What Can Still Move

After three operations, Liese summarizes available roads, supplies, and communities without ranking them as a morality score. The player may begin the final convoy or continue working.

Completing all six creates a robust autumn network. It does not save Tannbruck, cancel winter scarcity, or make every later choice painless. It ensures that later losses arise from the scale of invasion rather than the game ignoring preparation.

## Encounters and Opposition

The chapter deliberately varies play: waterworks traversal, bridge or ferry rescue, river defense, outpost combat, boundary investigation, and monster tracking. Bandits and road-raiders never share a command structure. The Drake appears only through environmental signs and one retreat encounter.

## Information Paths

Each operation provides at least two routes to its required facts through local testimony, physical evidence, cultural knowledge, tracks, records, or observation. Missing evidence changes settlement cost or trust, not whether the operation can finish.

## Choices and State Changes

- `autumn_operations_completed` records AO-1 through AO-6 individually.
- `autumn_road_support` records flour, lake food, fuel, timber, upland scouts, Folk warnings, and Southwood camp access as separate assets.
- `southwood_early_warning` becomes none, survivor-report, or mapped-range.

Local site states persist through winter, spring, and summer. Cleared named sites do not repopulate as though nothing happened.

## Fail-Forward Results

- A failed rescue reduces local personnel but leaves a repair or retaliation route.
- A hostile crossing remains physically passable under patrol at higher encounter pressure.
- An abandoned outpost strengthens carriers while surrendering military observation.
- If a regional enemy escapes, the local site is still stabilized and the fugitive enters finite side content.
- If The Quiet Antlers fails, a wounded hunter reaches Ashfield with incomplete Drake evidence.

## Companion Intersections

Every companion has at least one relevant operation, but none is mandatory. Dismas excels at Southwood ambush and quarry reading; Ylva at route signals, extraction, and relief staffing; Ilyana at timber and mill coordination; Bernard at rescue and witness; Tavio at machinery; Ashira at non-soul residue identification; Zafir at bounded terms.

If [[Elara Velescar]] accompanies **The Quiet Antlers**, she distinguishes abandoned hunter movement from old clandestine survey cuts and records a stable route between Ashfield Track and the Seven Mounds approaches. Completing the field reading produces `elara_southwood_route_intelligence` for [[A House Fed by Bones]]. The operation remains fully solvable without her.

If [[Bernard Valeon]] accompanies the Longlake operation, he establishes a casualty stop, verifies refuge bells, and leaves the route households with a witnessed property-and-injury procedure. Completing that work produces `bernard_longlake_route_secured` for [[Little Hands, Long Road]]. The operation remains fully solvable without him.

## Faction Advantages

Each faction can improve one or more operations through people, routes, supplies, or authority. Faction progress never marks an operation automatically complete. The player still travels and acts.

## Cutoff and Unlocks

Accepting [[The Last Convoy]] transforms unfinished operations:

- communities attempt their own solution;
- a named service, casualty, or hostile route results;
- no unfinished operation simply vanishes from the journal.

The chapter remains completed once three operations are done, while its optional operation entries remain active until the transition.

## Navigation

- [[Autumn Operations Matrix]]
- [[ACT I THE CLOSING ROADS]]
- [[The Last Convoy]]
- [[Main Campaign MOC]]
- [[Main Campaign State Matrix]]
