---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Grenz Lowlands"]
culture: ["Eclessian", "Folk"]
related_factions: ["Blackjack Corps", "Medori Bank", "Duchy of Grenzburg", "Marcher Vanguard"]
appears_in: ["Grenzburg"]
needs: []
aliases: []
tags: [game-ready]
quest_class: main
act: prologue
availability_window: ["Black Road"]
repeatability: one-shot
cutoff_result: persists
world_state_outputs: ["ducal_warrant", "city_access", "funnel_camp_state", "blackjack_party_formed"]
required_locations: ["Funnel Camp", "North Gate", "Blackjack Yard"]
blocking_status: blocked
quest_owner: "Grenzburg Main Campaign"
quest_sequence: 0
companion_id: ""
faction_line: ""
faction_branch: ""
chapter_id: "MQ-02"
main_sequence: 2
story_gate: season
estimated_hours: 0.75
gameplay_pillars: [investigation, social, pursuit, rescue]
required_states: ["black_road_survivors"]
optional_state_inputs: ["black_road_cargo", "toll_band_state", "grobi_scout_warning"]
---
# Warrant at the Gate

## Chapter Function

This chapter converts the convoy crisis into the player's durable game premise. It introduces Grenzburg through one crowded outer camp, one practical emergency, and three authorities with different scopes. It opens the city without presenting every faction leader at once.

## Trigger and Commitment

The convoy leaves its road-shrine camp at dawn and reaches [[Funnel Camp]]. Starting the final walk is automatic after MQ-01. The player may speak to survivors and divide recovered supplies before departure; those decisions become fixed when the column enters the camp.

## Hook and Immediate Stake

Thousands of seasonal arrivals are waiting outside the [[Grenzburg Wall Circuit|North Gate]]. The debtor convoy has admission papers, but its rear medicine wagon never arrived. Three people wearing stolen Blackjack coats lead that wagon toward the camp's salvage lane while shouting that it is contaminated.

At the same time, a false cry that Grobi have reached the northern ridge starts a crowd surge against the gate barriers. The alarm is human opportunism, not another Grobi attack. If the barriers fail, people will be crushed and the thieves will escape inside the confusion.

## Beginning: Funnel Camp

[[Sergeant Liese of the Marcher Vanguard]] orders the convoy to hold the eastern barrier while gate soldiers reverse the crowd flow. The player can:

- reinforce and reopen the marked family lanes;
- reach a signal platform and expose the false alarm;
- enter the salvage lane after the medicine wagon.

Ilyana can coordinate barrier crews, Bernard can stabilize people pulled from the crush, and Dismas can identify the false Blackjacks by their clean boot soles and wrong road spacing. The player may complete all three tasks; chosen order determines injuries and whether the thieves reach the camp's quarry pits.

## Middle: What the Bank Owns

The pursuit ends among abandoned quarry sheds beneath the camp. The thieves are surviving Tollers or camp scavengers hired by them according to `toll_band_state`. They have divided medicine from the locked service chest and intend to sell both before the gate reopens.

[[Captain Valdemar Koss]] arrives with a fresh Blackjack detail and orders the service chest recovered first because it proves ownership and equipment liability. Liese orders the medicine recovered first because the camp infirmary is already receiving crush victims. Neither order magically removes the other objective.

The player can recover both through stealth, negotiation backed by evidence, or combat. If forced to choose, the lost item produces a later cost rather than mission failure. Koss records disobedience or competence, but this main chapter does not create a hidden Bank rider system.

## End: The Seconded Hand

Inside North Gate, [[Castellan Pierre Hohenwall]] interviews the player, Liese, and the surviving convoy officer. Recovered Grobi route evidence improves the report; without it, Liese supplies independent patrol sightings.

Pierre invokes the winter crisis charter to second the protagonist and a small Blackjack specialist unit to ducal field service. Koss retains contractual command over company discipline and debt. Pierre controls public assignments. Neither authority can silently order the player through the other's institution.

The player receives:

- a ducal field warrant;
- a bunk and equipment access at [[Blackjack Yard]];
- permission to move through all eight surface districts;
- formal party access to Ilyana, Bernard, and Dismas;
- a first assignment to reopen the Lowlands road.

The chapter ends with the player walking through Lantern Ward rather than a long council scene. District services, rumors, faction contacts, and optional recruitment hooks appear naturally along the route to the Yard.

## Encounters and Opposition

- crowd-flow rescue at Funnel Camp;
- signal-platform traversal under panic;
- pursuit through salvage lanes and quarry sheds;
- confrontation with wagon thieves;
- social confrontation between Koss's property priority and Liese's public-safety priority.

## Information Paths

The false alarm is exposed through the empty ridge signal, testimony from a runner who heard the first shout, or Dismas's track reading. The stolen uniforms are identified through missing badges, incorrect equipment knots, or surviving convoy witnesses. The warrant does not depend on perfect evidence because Pierre already needs proven specialists; evidence changes its terms and initial trust.

## Choices and State Changes

- `funnel_camp_state` records orderly, injured, or breached barriers and named casualties.
- `ducal_warrant` records standard, trusted, or restricted initial terms.
- `city_access` opens all surface districts and public transit.
- `blackjack_party_formed` makes the three prologue companions available and unlocks party management.

Recovered medicine improves Mercy Hospital's opening stock. Recovered service records reduce Koss's first equipment claim. Recovering both creates no implausible bonus beyond avoiding those costs.

## Fail-Forward Results

- If the crowd breaks a barrier, Liese still contains the surge but Funnel Camp begins autumn with injuries and lower trust.
- If the thieves escape with medicine, their fence exposes the first underworld contact and the Church supplies a smaller replacement cache.
- If the service chest is lost, Medori reconstructs the contracts from city copies; Koss uses the loss as leverage but cannot erase character creation.
- If the player openly defies Koss, Pierre still issues the warrant because the public rescue is proven. Koss's stance hardens.

## Companion Intersections

- Ilyana's willingness to command ends when lawful responsibility returns; this establishes her strength and discomfort.
- Bernard reacts to whether property or wounded people received priority, without treating one rushed choice as final judgement.
- Dismas recognizes Koss's instinct to abandon recoverable people and quietly marks the Yard's exits.

## Faction Advantages

No faction commitment exists. The scene introduces the Duke and Blackjacks as separate institutions while reserving Church, Folk, and underworld introductions for optional content after the gate opens.

## Cutoff and Unlocks

Accepting the warrant advances the world to **Early Autumn**. The game displays a concise notice that prologue-only road conversations close, while convoy survivors and material states persist. It unlocks [[The Closing Roads]], early companion recruitment, faction admission quests, trainers, city services, and open district exploration.

## Navigation

- [[The Black Road Main Quest|The Black Road]]
- [[PROLOGUE THE BLACK ROAD]]
- [[The Closing Roads]]
- [[Main Campaign MOC]]
- [[Main Campaign State Matrix]]
