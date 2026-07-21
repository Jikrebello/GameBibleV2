---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg"]
culture: ["Eclessian", "Folk", "Grobi"]
related_factions: ["Duchy of Grenzburg", "Blackjack Corps", "Church of the Redeemer", "Folk kindreds", "Bloody-Sun Host"]
appears_in: ["Grenzburg"]
needs: []
aliases: []
tags: [game-ready]
quest_class: main
act: act-2
availability_window: ["Early Winter"]
repeatability: one-shot
cutoff_result: persists
world_state_outputs: ["winter_intake_state", "city_siege_readiness", "winter_strands_open"]
required_locations: ["Tann Field", "Funnel Camp", "Tann Gate", "Grenzburg"]
blocking_status: blocked
quest_owner: "Grenzburg Main Campaign"
quest_sequence: 0
companion_id: ""
faction_line: ""
faction_branch: ""
chapter_id: "MQ-09"
main_sequence: 9
story_gate: season
estimated_hours: 0.75
gameplay_pillars: [rescue, defense, social, combat]
required_states: ["tannbruck_fallen"]
optional_state_inputs: ["tannbruck_survivors", "tannbruck_material", "last_convoy_people", "last_convoy_material", "autumn_road_support"]
---
# Winter's Teeth

## Chapter Function

This chapter makes winter visible in population, services, damage, and enemy control. It processes the Tannbruck withdrawal through play, establishes Ghor's siege without pretending it begins in ten minutes, and opens the urban, Drake, and military strands that may be pursued alongside faction and companion content.

## Trigger and Commitment

MQ-08 flows directly into Tann Field outside Grenzburg. The chapter begins during the survivors' arrival and returns open-world control after intake. It is the Early Winter season transition.

## Hook and Immediate Stake

The gates cannot admit the whole column at once. Wounded people need triage, military stores must be separated from personal carts, and Ghor's advance scouts are close enough to strike the exposed field. A second refugee flow at Funnel Camp is moving south through rumor and risks meeting the army road.

## Beginning: Count the Living

The player chooses an initial task while ordinary officers handle the others:

- establish a protected casualty lane from Tann Field to Mercy Hospital;
- organize the surviving fort stores at Tann Gate;
- ride north to turn the Funnel Camp flow away from the military road.

Prior survival and material states change scale. Strong preparation allows the player to move rapidly between tasks; weak preparation produces hard but named shortages.

The scene introduces winter variants of familiar spaces: frozen ruts, wall braziers, crowded refuge halls, shuttered markets, and soldiers billeted in workshops.

## Middle: The First Investment

Ghor's outriders and goblin food-rushes test Tann Field before the gates close. The attack is not the full siege. Its objectives are to seize abandoned wagons, capture wounded soldiers, and determine which wall towers respond.

The player defends two of three fronts directly while Liese or an assigned companion handles the third:

- the casualty lane;
- the store park;
- the gate winch and outer barrier.

Tannbruck route intelligence reveals the signal pattern early. Without it, the player reads the attack from horns and scout movement after the first rush.

## End: Three Winter Fronts

After the field is cleared, Pierre conducts a short map briefing at the Marcher Barracks. It identifies three separate problems:

- Ghor is constructing siege positions and testing the western river approaches;
- the displaced Emerald Drake has closed a needed Southwood winter corridor;
- scarcity and damage inside Grenzburg are creating opportunities for criminals and abusive authority.

The player is not asked to solve all three immediately. [[The City in Siege]] and [[The Emerald Trail]] open in parallel, while faction, companion, local, and training content receives its Early Winter states. Military patrol jobs and Grobi-band leads also open.

## Encounters and Opposition

- large-scale but readable intake management;
- optional ride between Tann Field and Funnel Camp;
- three-front outer-camp defense;
- aftermath walk through changed Tannward and Lantern Ward.

## Information Paths

Survivor rolls, material wagons, and visible field conditions establish intake needs. Scout reports, captured food sacks, and horn patterns establish that Ghor is investing rather than launching the final siege. The three campaign strands are introduced through concrete requests rather than lore exposition.

## Choices and State Changes

- `winter_intake_state` records admitted people, outer-camp population, wounded throughput, and separated families.
- `city_siege_readiness` records stores, responsive towers, outer barriers, and surviving specialists.
- `winter_strands_open` unlocks urban, Drake, and military content.

## Fail-Forward Results

- An overrun store park loses material but retreating Grobi leave a track to one siege cache.
- A broken casualty lane sends wounded to Church and Folk shelters with different service pressure.
- Funnel Camp confusion increases outer-camp population but does not erase refugees.
- If the player loses a field front, city soldiers retake it after the gate closes at a casualty cost.

## Companion Intersections

All recruited companions receive a winter-arrival scene. Bernard and Caestus work the casualty lane; Ilyana reads the siege test; Svala handles panic without treating it as weakness; Dismas identifies the withdrawal routes Ghor wants to close.

## Faction Advantages

Autumn faction work changes intake staff, shelters, stores, passage, and covert routes. Every task retains an ordinary ducal or civic baseline.

## Cutoff and Unlocks

Completion opens **Early Winter**, the winter city and regional states, [[The City in Siege]], [[The Emerald Trail]], winter faction quests through their valid stages, and post-Tannbruck companion reactions. No real-time siege clock runs during the open interval.

## Navigation

- [[Tannbruck Falls]]
- [[ACT II WINTER'S TEETH]]
- [[The City in Siege]]
- [[The Emerald Trail]]
- [[Main Campaign MOC]]
