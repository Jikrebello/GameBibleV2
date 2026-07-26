---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Longlake Country"]
culture: ["Chapel-Folk", "Eclessian", "Thalmyric"]
related_factions: ["Blackjack Corps", "Bent Oak households"]
appears_in: ["Grenzburg"]
needs: []
tags: [narrative-rewrite]
quest_class: companion
act: act-1
availability_window: ["Open Autumn", "Late Autumn"]
repeatability: one-shot
cutoff_result: resolves-offscreen
world_state_outputs: ["bernard_road_school_wagon_recovered", "road_school_wagon_state", "refuge_bell_state", "road_school_pack_state", "wagon_driver_state", "reed_road_bandits_state"]
reward_unlocks: ["Road-School Wagon", "Longlake refuge service"]
required_locations: ["Bent Oak Chapel", "Lake Gate", "Pikehook Marsh", "Bent-Oak Refuge"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: operation
companion_campaign_stage: act-1
quest_owner: "Bernard Valeon"
quest_sequence: 2
companion_id: "CMP-05"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: preparation
estimated_hours: 0.75
gameplay_pillars: [exploration, rescue, pursuit, protection]
required_states: ["bernard_introduction_complete"]
optional_state_inputs: ["bernard_accountability_plan", "lakewatch_trust", "longlake_route_state", "road_bandit_pressure"]
field_experience_gate: []
companion_required: "Bernard Valeon"
duo_quest: false
pause_points: ["Wagon Located"]
relationship_gate: ""
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "The Last Convoy"
autonomous_resolution: "Oda recovers a damaged wagon with reduced packs; the Act I operation asset is lost"
changed_reentry: "The road school proceeds with fewer supplies; the original recovery cannot be replayed"
ensemble_inputs: ["Dismas Raben", "Ylva Winter-Track", "Ilyana Veshkar"]
identity_hooks: []
encounter_deck: []
persistence_scope: local-persistent
postgame_season: ""
emotional_rewrite_status: reframe
dialogue_status: pending-rewrite
archetype_pressure: "Warmth becomes evasion: test whether Bernard can remain funny and loving while accepting specific judgement."
emotional_function: "Keep the school wagon and practical rescue; foreground Bernard's play, rapport with children, and fear when humor cannot solve the marsh"
pleasure_beat: "Food, absurdity, road stories, children laughing, and companionship without ceremony."
care_beat: "Bernard feeds, shelters, steadies, and tells the truth about what he takes or withholds."
player_archetype_hooks: []
---
# The Wagon in the Reeds

## Quest Function

This is Bernard's short Act I operation. It prepares [[Little Hands, Long Road]] through practical recovery rather than another confession. The problem begins with ordinary bandit violence, a damaged road, and a driver who chose to protect people before cargo.

The operation uses the normal field party. Bernard remains required, but other companions may help with tracking, defence, repair, and evacuation.

## Hook and Immediate Stake

[[Oda Reed-Way]] expected a Bent Oak road-school wagon through Lake Gate before noon. It carries:

- seven child-sized packs;
- route boards and chalk;
- blankets, food, bandages, and a field kettle;
- the bronze refuge bell used to teach emergency signals;
- repair timber for [[Bent-Oak Refuge]].

The wagon never arrived. A soaked mule returns with a cut trace and reeds tangled around its harness.

## What Happened

Five ordinary road bandits attacked the wagon near Pikehook Marsh. Driver **Elsa Marten** turned from the raised road into a reed-haul track to keep two refugee passengers out of the firing line. The wagon broke an axle in soft ground.

Elsa and the passengers reached an abandoned eel shed. The bandits began stripping food, the bell, and saleable fittings from the immobilized wagon. They know nothing about Bernard, Oda, the wounded bear, or later campaign events.

## Operation States

### Water Rise: 0-3

Delay, failed extraction, or cutting the wrong bank raises water around the wagon.

- **0-1:** the axle and all packs remain recoverable.
- **2:** one pack bundle drifts into the reed channels.
- **3:** the wagon body rolls and only separately secured cargo survives.

### Bandit Alarm: 0-3

Visible road entry, escaped lookouts, and prolonged fighting improve the bandits' positions. Alarm changes sentries, hostages, and escape routes rather than closing the operation.

## Beginning: The Cut Trace

At Lake Gate the party may:

- inspect the returned mule and follow mud, blood, and cut leather;
- interview a ferry hand who heard crossbows in the reeds;
- take the raised causeway and search from above;
- use a boat, marsh path, or ordinary wading line.

Every route reveals the broken wagon, the eel shed, and at least one bandit lookout. No tracking roll can permanently lose the operation.

## Middle: People Before Packs

Elsa has a deep leg cut. One passenger has exposure, and the other is keeping the shed door barred with a fishing pole. Two bandits are trying to smoke them out while the remaining three unload the wagon.

The party may:

- rescue the shed first and allow some cargo to move;
- ambush the stripping crew before freeing the passengers;
- divide through two accessible routes;
- negotiate an exchange while preparing a rescue;
- frighten, capture, or kill bandits who continue armed resistance.

Bernard prioritizes Elsa and the passengers. He does not demand that the player abandon recoverable supplies after the people are secure.

## End: Hauling from the Reeds

The wagon can be:

- repaired with its spare timber;
- dragged to firm ground with the mule and reed-haul capstan;
- unloaded into a ferry skiff;
- abandoned after the packs and bell are carried out.

The refuge bell is in a bandit sack moving toward the north path. A short pursuit may recover it through the causeway, reed channels, or ferry landing. Losing sight of the runner leads to a known fence rather than deleting the bell.

## Vocation Access

Every player vocation can complete every objective:

- ordinary ropes, poles, tools, and the capstan recover the wagon;
- Fighter and ordinary carrying proficiency accelerate bracing and hauling;
- Slayer opens exposed reed and roof shortcuts;
- Hunter reads the cleanest trail and animal-safe path;
- Warlock may dry fittings or shift water in bounded ways;
- Medium and Binder forms may scout or carry without replacing human rescue.

No route requires magic, stealth, cultural knowledge, or a particular companion.

## Information Redundancy

- Elsa is located through blood, shed smoke, passenger calls, or the ferry witness.
- The bell is identified by drag marks, its wrapping, bandit speech, or the runner's route.
- Every pack bundle has a manifest mark, child-name board, or matching cart slot.
- The bandits' independence is clear through their camp, testimony, stolen miscellany, and lack of faction equipment.

## Fail-Forward Results

- A lost wagon does not lose every pack.
- A drifting bundle can be recovered downstream with damaged contents.
- Escaped bandits reduce local road safety and may reappear as a finite bounty.
- If the party is defeated, Elsa gets the passengers onto a ferry skiff while the bandits take the bell and food.
- A dead mule forces hand carriage or ferry transport without ending the operation.

## Outputs

- `bernard_road_school_wagon_recovered`: true or false;
- `road_school_wagon_state`: sound, repaired, salvaged, or lost;
- `refuge_bell_state`: recovered, damaged, fenced, or lost;
- `road_school_pack_state`: complete, reduced, soaked, or stolen;
- `wagon_driver_state`: safe, injured, abandoned, or dead-through-explicit-combat;
- `reed_road_bandits_state`: captured, dispersed, killed, escaped, or active.

## Autonomous Resolution

If the player does not participate, Oda, Elsa, and local fishers recover the passengers and a reduced pack set. The bell is damaged or lost, the wagon remains unusable, and `bernard_road_school_wagon_recovered` is false. Bernard still joins the later school trip with lower readiness.

## Rewards

- the Act I preparation asset;
- full road-school packs and refuge service according to outcome;
- Longlake trust for protecting both people and accountable communal property.

## Navigation

- [[Bernard Companion Campaign]]
- [[Bernard Valeon]]
- [[Oda Reed-Way]]
- [[Little Hands, Long Road]]
- [[Grenzburg Worldspace Location Register#Longlake Country|Pikehook Marsh]]
- [[Bent-Oak Refuge]]
- [[Companions MOC]]
