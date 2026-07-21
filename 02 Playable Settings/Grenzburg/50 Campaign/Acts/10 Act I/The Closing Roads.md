---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenz Lowlands"]
culture: ["Eclessian", "Folk"]
related_factions: ["Duchy of Grenzburg", "Blackjack Corps", "Folk kindreds"]
appears_in: ["Grenzburg"]
needs: []
aliases: []
tags: [game-ready]
quest_class: main
act: act-1
availability_window: ["Early Autumn"]
repeatability: one-shot
cutoff_result: persists
world_state_outputs: ["three_mills_road", "broken_tollworks_state", "road_prisoners_state"]
required_locations: ["Three Mills Reach", "Broken Tollworks", "South Ferry"]
blocking_status: blocked
quest_owner: "Grenzburg Main Campaign"
quest_sequence: 0
companion_id: ""
faction_line: ""
faction_branch: ""
chapter_id: "MQ-03"
main_sequence: 3
story_gate: open
estimated_hours: 1.25
gameplay_pillars: [combat, traversal, investigation, social]
required_states: ["ducal_warrant", "city_access"]
optional_state_inputs: ["toll_band_state", "black_road_survivors", "black_road_cargo"]
---
# The Closing Roads

## Chapter Function

This is the first ordinary ducal assignment and the model for Grenzburg's grounded open-world work. It opens the Lowlands, introduces a persistent settlement, gives the player a compact civil dungeon, and establishes that bandits and hostile Folk road-raiders have separate motives.

## Trigger and Commitment

[[Sergeant Liese of the Marcher Vanguard]] posts the assignment at [[Blackjack Yard]] after the warrant is issued. The player can explore Grenzburg and begin parallel content before accepting. Departure by the South Ferry closes no quests and starts no timer.

## Hook and Immediate Stake

No flour convoy has arrived from [[Three Mills Reach]] for six days. The last returning carter reports that armed people have occupied the [[Broken Tollworks]], while a different group has marked the west bank with Shattered-Tusk warnings. If the road stays closed, the mills cannot send flour north and Grenzburg must begin drawing reserve grain before winter.

## Beginning: The Empty Flour Road

The player travels with Liese and two carters to the South Ferry. Evidence along the route establishes two conflicts:

- Broken Axle Tollers and deserters have rebuilt barriers, robbed wagons, and taken travelers into the toll cellar.
- A Shattered-Tusk road-raiding party has killed one surveyor and marked a side road that crosses an old Folk burial strip.

Neither group trusts the other. The Tollers have removed Folk warning marks to lure carts into their barricade; the road-raiders have attacked two Tollers as unlawful occupiers.

At a wrecked flour cart, the player rescues a hiding apprentice and follows either wheel ruts toward Three Mills or blood and boot tracks toward the Tollworks.

## Middle: Three Mills Reach

Three mill households are arguing over whether to surrender flour, arm their workers, or cut the shared leat and retreat. The player learns that five travelers and the Reach's wheelwright are held beneath the Tollworks.

The settlement offers three practical preparations:

- a millrace culvert leading beneath the Tollworks;
- a repaired flour cart that can conceal the party;
- workers willing to create a loud diversion if the player first secures their families.

The player may also inspect the Folk burial strip. A moved boundary stone proves the surveyor violated a marked place, but the dead carter and kidnapped mill workers never entered it. This evidence can limit further road conflict without validating murder outside the boundary.

## End: Broken Tollworks

The civil ruin contains a barricaded road court, holding cellar, collapsed inspection tunnel, and roof signal position. Its encounter state depends on `toll_band_state`:

- Harl Venn commands the site if he escaped the Black Road.
- His lieutenant Marta Krail commands a smaller but more nervous force if Harl died or was captured.
- Captured Tollers have been replaced partly by local deserters if the original band was broken.

The player rescues prisoners, breaks the roof signal, and confronts the commander. The band may be killed, captured, or scattered. Surrender becomes available only after hostages are safe and escape routes are controlled.

Afterward, the player decides whether the Tollworks becomes a ducal road post, a Three Mills watchhouse, or a dismantled ruin whose stone repairs the road. This is a local operational choice, not a final political settlement.

The Folk side-road conflict resolves through one of three actions: restore the boundary and designate a bypass, force the road open under patrol, or ignore the claim. Restoring the marked strip prevents further attacks from nearby households, but Jorund's total-war followers still condemn all ducal passage.

## Encounters and Opposition

- road investigation and survivor rescue;
- optional confrontation with Shattered-Tusk raiders outside the burial boundary;
- social and material preparation at Three Mills;
- three-entry Tollworks delve;
- hostage protection and commander confrontation.

## Information Paths

Wheel ruts, survivor testimony, and recovered toll chits locate the prisoners. The boundary dispute is established by the displaced stone, an elder miller's memory, and marks recognized through Folk cultural knowledge. Missing any one route increases uncertainty but never blocks the bypass or assault.

## Choices and State Changes

- `three_mills_road` becomes secured-bypass, secured-patrolled, or damaged-open.
- `broken_tollworks_state` becomes ducal-post, mill-watchhouse, dismantled, or hostile-remnant.
- `road_prisoners_state` records survivors, wounds, and the wheelwright's availability.

Treatment of captured attackers affects later faction dialogue and local trust. No execution or release silently represents all future criminal justice.

## Fail-Forward Results

- If the apprentice is not found, they reach Three Mills alone but the bandits prepare for pursuit.
- If prisoners are exposed during the assault, some are moved to the roof rather than killed off-screen.
- If the commander escapes, the Tollworks is still cleared and a later bandit job inherits the fugitive.
- If the boundary evidence is lost, the player can still enforce passage, but road-raider attacks persist into MQ-06.

## Companion Intersections

- Dismas identifies ambush discipline and offers a route that avoids repeating his old crime.
- Bernard objects to looting the captured road court before ownership is recorded.
- Ilyana can turn the mill diversion into a controlled breach rather than an indiscriminate fire.

## Faction Advantages

Ducal admission supplies a road squad. Early Folk contact supplies a boundary witness. Blackjack equipment work supplies a second breaching tool. None is required.

## Cutoff and Unlocks

Completion opens routine travel through the Grenz Lowlands, Three Mills services, the Broken Tollworks changed state, and [[The Southbound Muster]]. It also opens the first broad interval for faction admission, companion recruitment, local work, and Lowlands exploration.

## Navigation

- [[ACT I THE CLOSING ROADS]]
- [[Autumn Operations Matrix]]
- [[The Southbound Muster]]
- [[Main Campaign MOC]]
- [[Main Campaign State Matrix]]
