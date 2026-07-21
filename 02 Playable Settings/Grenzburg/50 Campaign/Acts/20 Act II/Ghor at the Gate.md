---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Grenz Lowlands"]
culture: ["Grobi", "Eclessian", "Folk"]
related_factions: ["Duchy of Grenzburg", "Blackjack Corps", "Bloody-Sun Host", "Stone-Tooth band", "Church of the Redeemer"]
appears_in: ["Grenzburg"]
needs: []
aliases: []
tags: [game-ready]
quest_class: main
act: act-2
availability_window: ["Deep Winter"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["ghor_dead", "organized_siege_broken", "grobi_aftermath_state", "city_winter_survival"]
required_locations: ["Grenzburg", "Tannward", "Lantern Ward", "Grenzburg Wall Circuit", "Old Granary Culvert", "Outer Winter Camps"]
blocking_status: blocked
quest_owner: "Grenzburg Main Campaign"
quest_sequence: 0
companion_id: ""
faction_line: ""
faction_branch: ""
chapter_id: "MQ-15"
main_sequence: 15
story_gate: season-transition
estimated_hours: 3.0
gameplay_pillars: [siege, large-combat, rescue, assault, boss]
required_states: ["southern_horn_state", "emerald_drake_dead", "western_breach_state"]
optional_state_inputs: ["ghor_host_cohesion", "counterattack_route", "uru_corridor_state", "stone_tooth_war_state", "skiv_intelligence_state", "city_siege_readiness", "emerald_law_gem_custody", "tannbruck_denial"]
---
# Ghor at the Gate

## Chapter Function

This is Act II's war climax. It pays off the physical city damage, the Grobi splinter states, the player's winter preparations, and the three main strands without making any one optional ally mandatory. Ghor dies and the organized siege breaks in every completed version; who survives and what remains functional vary sharply.

## Trigger and Commitment

The Southern Horn is destroyed. Pierre reports that Ghor has abandoned a long siege and ordered every remaining band into one final assault before fragmentation becomes irreversible. Activating the wall muster gives an explicit list of Deep Winter quests that will fail, transform, or persist, then advances the campaign into a closed siege sequence and the spring thaw.

## Beginning: The Last Assault

Ghor attacks the west and south fronts simultaneously:

- massed shield and ladder bands strike the repaired Lantern Ward breach;
- sappers and heavy beasts press Tannward's gate;
- rafts and ice runners attempt to seize the riverworks;
- any surviving Cinder Knives or Horn-Captain Ruk attack an internal objective.

The player chooses one opening emergency personally and delegates the others to available faction or companion support. Delegated fronts are not automatically won: city readiness, prior damage, and supplied allies determine casualties and structural loss.

## Middle: Restore the Line

The party moves through two urgent objectives before the counterattack:

1. **Hold the living city.** Rescue trapped defenders or civilians, restore a failing gate mechanism, and prevent a local breakthrough from becoming a second district occupation.
2. **Break the assault rhythm.** Destroy the nearest relay, defeat a breach leader, and open the chosen counterattack route.

The route depends on MQ-13:

- a turned culvert produces a concealed strike behind Ghor's assault stores;
- a flood-sealed culvert can drown one tunnel force before a wall sortie;
- a stone-sealed route gives the safest city rear but requires a direct gate sortie;
- a damaged or exposed culvert creates an extra defense phase before the baseline sortie.

## End: The Bloody Sun Falls

The Blackjacks and the surviving marcher force reach Ghor's command ground outside the walls. The final sequence changes with the host:

- a **massed** host retains coordinated bodyguards, reserve beasts, and a camp assault;
- a **strained** host loses one reserve phase;
- a **fractured** host contains fighting withdrawals, abandoned standards, and competing chiefs;
- Uru, Grakka, Skiv, and Ruk states add or remove specific forces without changing Ghor's culpability.

Ghor-Maw fights as a war-chief who made migration into conquest. He uses captured signals, heavy polearms, bodyguard rotations, and prepared retreat lanes; he has no patron, prophecy, or supernatural invulnerability. He rejects surrender after his command collapses and is killed by the player and party.

The Bloody-Sun standard is cast down, organized assault ceases, and surviving Grobi forces scatter south, surrender locally, or retreat as distinct bands.

## Encounters and Set Pieces

- simultaneous wall emergencies with one player-selected priority;
- street and gate restoration under attack;
- internal saboteur or reserve response when applicable;
- counterattack through culvert, sluice, or wall sortie;
- assault across Ghor's broken siege ground;
- multi-stage confrontation with Ghor and remaining command guard;
- immediate rescue and containment after the rout.

## Information Paths

Ghor's deployment is read through Skiv's chart, captured horn schedules, Watch Hill intelligence, ducal scouts, or direct wall observation. Missing optional intelligence replaces advance warning with a reconnaissance encounter; it never makes the assault incomprehensible.

## Choices and State Changes

- `ghor_dead` becomes true.
- `organized_siege_broken` becomes true.
- `grobi_aftermath_state` records dependents, splinter bands, prisoners, surviving chiefs, and open migration routes.
- `city_winter_survival` records district function, camps, defenders, civilians, fire damage, and stores.

The player can order mercy for surrendered fighters and protect withdrawing dependents without declaring predation harmless. Prisoners, wounded enemies, and noncombatants remain separate categories.

## Fail-Forward Results

- A lost opening front causes deaths and closes a service, but the party can still restore the central line.
- A failed delegation produces a rescue or containment objective during the aftermath.
- A compromised counterattack becomes a direct, costlier sortie.
- Defeat in Ghor's camp triggers extraction by surviving troops and a shorter emergency re-entry while the city loses another asset.
- Ghor cannot escape the completed chapter; the cost of reaching him is what changes.

## Companion Intersections

All recruited companions receive siege deployment and a post-battle scene. The three active companions affect the field operation; inactive companions defend selected city or camp fronts according to their vocation and arc state. Broken or departed companions never reappear merely to fill a slot.

## Faction Advantages

Ducal progress improves wall command, Blackjack progress improves the counterattack, Church progress preserves aid stations, Folk progress protects routes and distinguishes surrendering bands, and underworld progress counters internal movement. Each provides an advantage and visible consequence, not a required win condition.

## Cutoff and Unlocks

The chapter ends Deep Winter and begins Early Spring. The Emerald Drake and Ghor are dead, but Southwood damage, Grobi survivors, ruined defenses, refugees, and unresolved political lines remain. The thaw unlocks [[The Open Thaw]] and spring versions of all surviving regions.

## Navigation

- [[Break the Southern Horn]]
- [[Grobi Host Fragmentation Matrix]]
- [[Season and World-State Constitution]]
- [[The Open Thaw]]
- [[Main Campaign MOC]]
