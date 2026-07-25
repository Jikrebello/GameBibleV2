---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Lantern Ward", "Hammer Ward"]
culture: ["Eclessian", "Grobi"]
related_factions: ["Duchy of Grenzburg", "Blackjack Corps", "Bloody-Sun Host"]
appears_in: ["Grenzburg"]
needs: []
aliases: []
tags: [game-ready]
quest_class: main
act: act-2
availability_window: ["Early Winter"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["lantern_ward_damage", "western_breach_state", "blackjack_yard_state", "millwheel_pumps_state", "elara_winter_roofline_proven", "bernard_breach_casualty_lane_secured"]
required_locations: ["Lantern Ward", "Quarry Steps", "Debtors' Row", "Blackjack Yard", "Millwheel Works", "Wallwright Yard"]
blocking_status: blocked
quest_owner: "Grenzburg Main Campaign"
quest_sequence: 0
companion_id: ""
faction_line: ""
faction_branch: ""
chapter_id: "MQ-10"
main_sequence: 10
story_gate: operation
estimated_hours: 2.0
gameplay_pillars: [combat, rescue, defense, traversal]
required_states: ["winter_strands_open"]
optional_state_inputs: ["city_siege_readiness", "winter_intake_state", "tannbruck_material", "rooftop_network_state", "underways_route_access", "blackjack_gear_supply", "mercy_hospital_state"]
---
# The City in Siege

## Chapter Function

This is Act II's urban set piece and Ghor's first undeniable penetration of Grenzburg. It combines street combat, rescue, fire control, traversal, and physical repair. The player does not expose a secret mastermind; they survive a well-prepared military breach and restore the defenses.

## Trigger and Commitment

After one open Early Winter interval, wall horns sound while the player is inside Grenzburg. Starting the response at Blackjack Yard begins a closed operation. The attack does not interrupt a player already inside another closed quest; it waits as an explicit main-story start.

## Hook and Immediate Stake

Ghor's sappers cross a frozen side-channel under smoke and bombardment. Charges placed against old quarry masonry collapse the western revetment above Quarry Steps. Grobi fighters enter Lantern Ward while fire pots ignite debtor roofs and warehouse awnings.

Their immediate goals are the Blackjack Yard, the Lake Gate interior, and a route to the bridge. If they hold those positions, the west bank becomes an occupied foothold.

## Beginning: The Breach

The player reaches Quarry Steps as the wall gives way. The opening battle has three objectives:

- hold the stair long enough for civilians below it to escape;
- stop a hobgoblin horn-team from directing later waves;
- reach the wall cap and lower an emergency barrier.

Success contains the first wave. Failure moves the defense line to Debtors' Row and increases fire spread rather than ending the game.

## Middle: Fire and People

Lantern Ward divides into connected emergencies:

- **Debtors' Row:** residents are trapped between fire and Grobi looters.
- **Blackjack Yard:** wounded Blackjacks defend the equipment store and party quarters.
- **Lantern Market:** a burning arcade threatens to carry fire toward Lake Gate.
- **Quarry Galleries:** goblins use old workings to bypass street barricades.

The Millwheel Works can feed pressure to west-bank pumps if its frozen intake is cleared and Bridgehold valves are opened. The player may personally restore the pumps, ask available engineers to do so under escort, or fight with bucket lines and accept greater demolition.

The firebreak choice is physical and local. Wallwrights identify three connected structures. Demolishing one tenement row is fast but displaces debtors; dropping the market arcade preserves homes but destroys winter trade; fully restoring pumps can save both if the player has sufficient engineers, time, and route control.

## End: Push Them Out

Once civilians and fire are stabilized enough to move, Liese forms a counterattack from the Yard. The player chooses one approach:

- street advance behind shields and water carts;
- Quarry Gallery infiltration beneath the occupied wall;
- rooftop attack using the Market Roofline and emergency ladders.

The party destroys the breach horn, defeats the Grobi breach-captain, and drives the surviving force back through the wall gap or onto the ice. The player then holds the exterior while engineers raise a timber-and-earth closure.

Restoration is part of the quest, not an off-screen promise. The player carries braces, defends workers, and chooses whether scarce forge stock creates a stronger gate or preserves material for later siege engines. The final city walk shows fire crews, cleared streets, and a visibly repaired but scarred wall.

## Encounters and Opposition

- wall-collapse escape and first-wave battle;
- street rescue amid spreading fire;
- pump restoration and Bridgehold traversal;
- Quarry Gallery or rooftop flanking route;
- breach-captain boss and exterior hold;
- repair defense under bombardment.

Grobi stages remain legible: goblins loot and infiltrate, hobgoblins coordinate, orcs lead shock groups, and larger forms attack structures. Their food pressure does not absolve the chosen assault.

## Information Paths

Wall damage, sapper tools, and observed river tracks prove the breach method. Horn relays, marked objectives, and captured sketches establish the assault plan. No human traitor is required. Later evidence in MQ-13 concerns exploitation of the damaged city, not the cause of this breach.

## Choices and State Changes

- `lantern_ward_damage` records saved and destroyed blocks, displaced residents, fires, and services.
- `western_breach_state` becomes strong-repair, field-repair, or unstable-closed.
- `blackjack_yard_state` records personnel, equipment, quarters, and Green Ward eligibility.
- `millwheel_pumps_state` becomes restored, damaged-operational, or failed-replaced.

## Fail-Forward Results

- If Quarry Steps falls, combat moves to Debtors' Row and the counterattack route becomes longer.
- If pumps fail, demolition and bucket lines contain the fire with greater property loss.
- If the Yard is overrun, Blackjacks retake it from the underways and lose equipment or people.
- If the breach-captain escapes, they reinforce Ghor in MQ-15; the wall is still closed.
- A failed repair hold produces a weaker closure that MQ-13's strike cell targets.

## Companion Intersections

Ilyana can establish obscuring fog, shared weapon cadence, and audible casualty calls without taking permanent command of the ward. Tavio stabilizes pumps or wall braces. Zafir organizes controlled bound labor without living coercion. Bernard protects casualty movement; Ylva's resident-held signal chain warns Debtors' Row and opens a marked extraction lane. Every route has ordinary alternatives.

[[Elara Velescar]] can lead the Market Roofline counterattack while reading fire damage, guard lines, and improvised winter footing. Completing that route with her records `elara_winter_roofline_proven`, one preparation asset for [[The Patron's Cabinet]]. The rooftop route and the campaign chapter remain viable without Elara.

[[Bernard Valeon]] can organize the marked casualty lane between Debtors' Row, the Blackjack Yard, and the nearest functioning treatment point. Holding it through the breach and leaving carriers with a tested fallback records `bernard_breach_casualty_lane_secured` for [[Embers Without Excuse]]. Civilian rescue remains viable without him.

[[Ilyana Veshkar]] can test the route with fog boundaries, stretcher calls, and a refrain whose participating carriers may leave at named relief points. Preserving the lane without compelling a civilian or performer records `ilyana_breach_casualty_lane_mapped` for [[The Free Refrain]]. The breach and casualty route remain viable without her.

## Faction Advantages

- Ducal work supplies disciplined wall crews.
- Blackjacks preserve equipment and specialist teams.
- Church work improves triage and fire shelter.
- Folk contacts provide west-bank carriers and lake-water knowledge.
- Underworld work opens roofs or galleries without granting criminals control of the defense.

## Cutoff and Unlocks

Completion restores open city play in its damaged winter state, opens related repair jobs, and makes [[Knives Behind the Walls]] available after MQ-11 is completed. It advances no season and leaves the Drake and military strands open.

## Navigation

- [[Winter's Teeth]]
- [[Knives Behind the Walls]]
- [[ACT II WINTER'S TEETH]]
- [[Main Campaign MOC]]
- [[Main Campaign State Matrix]]
