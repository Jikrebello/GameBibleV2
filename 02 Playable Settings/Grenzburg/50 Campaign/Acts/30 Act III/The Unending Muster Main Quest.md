---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Frostfenn March"]
culture: ["Qianglong", "Folk", "Eclessian"]
related_factions: ["Duchy of Grenzburg", "Blackjack Corps", "Folk kindreds", "Church of the Redeemer"]
appears_in: ["Grenzburg"]
needs: []
aliases: ["The Unending Muster - Main Quest"]
tags: [game-ready]
quest_class: main
act: act-3
availability_window: ["Open Spring"]
repeatability: one-shot
cutoff_result: persists
world_state_outputs: ["deep_muster_approach_open", "last_hearth_forward_base", "remaining_anchor_access"]
required_locations: ["Frostfenn March", "Last Hearth", "Deep Muster Approaches", "Three Horn Depot"]
blocking_status: blocked
quest_owner: "Grenzburg Main Campaign"
quest_sequence: 0
companion_id: ""
faction_line: ""
faction_branch: ""
chapter_id: "MQ-18"
main_sequence: 18
story_gate: operation
estimated_hours: 2.5
gameplay_pillars: [expedition, survival, assault, dungeon, defense]
required_states: ["tannbruck_reclaimed", "muster_anchor_threshold_met"]
optional_state_inputs: ["emerald_law_gem_custody", "spring_settlement_access", "fenn_ossuary_state", "tuskway_banner_state", "river_arsenal_anchor", "watch_hill_anchor"]
---
# The Unending Muster

## Chapter Function

This chapter reveals the outer Qianglong campaign complex and establishes the final southern roadhead. It is the point where separate anchor sites become visibly one Unending Muster, while preserving the distinction between residue machinery, Gerhold's later choice, and the General Below.

## Trigger and Commitment

Three destroyed anchors cause the remaining system to emit one synchronized recall. Last Hearth's keepers report roads aligning through the thaw and emptied armor marching south. Beginning the expedition commits the party to a multi-day push, but does not close the remaining anchors afterward.

## Hook and Immediate Stake

If Last Hearth falls, Grenzburg loses its only dependable refuge and every later assault begins across an exposed fen. Pierre sends a limited column to hold the roadhead; the Blackjacks must find and sever the outer mobilization works before the column is classified as incoming material.

## Beginning: Roads That Remember War

The party advances along one of three ancient branches:

- the Fenn Road through White Mud Causeway;
- the Upper Grenz heavy road through Tannbruck's restored line;
- the Tuskway officer road across the uplands.

Destroyed anchors remove their route distortions. Active anchors add armor, bombardment, imposed rank, reinforcement, or black-mud movement according to [[Muster Anchor Matrix]]. All routes converge at Last Hearth, but preparation changes casualties and discoveries.

## Middle: Hold Last Hearth

The roadhead is attacked not by a random undead horde but by a classification process. The outer works mark:

- living soldiers as replacements;
- healers and refugees as body stores;
- wagons as campaign inventory;
- Last Hearth's signal mast as an officer standard.

The player defends the refuge while locating three command cuts around it. Each cut can be broken, redirected into an empty road, or temporarily accepted to lure a formation. Accepting a rank is a tactical deception with a time limit; it never grants legitimate command over people or makes the Muster morally usable.

## End: The Outer Works

The party assaults the outer mobilization yard beyond the last maintained marker. The site contains intake ramps, empty barracks, body scales, campaign stones, and the sealed main descent. The player must:

1. destroy the recall engine threatening Last Hearth;
2. secure one surface route to the Intake Gate;
3. open the damaged maintenance route from Last Hearth;
4. identify the Fen Wound as a dangerous third approach;
5. recover evidence that a living Grenzburger officer has copied rank tablets and visited Three Horn Depot.

The officer is not named here unless prior investigation has already exposed Gerhold's movement. The evidence begins a fair trail rather than a surprise betrayal.

## Encounters and Set Pieces

- route-specific dead-road traversal;
- mobile camp defense at Last Hearth;
- command-cut objectives under formation pressure;
- outer mobilization-yard assault;
- first view of the sealed Deep Muster Intake Gate;
- escape or holdout as the surviving outer works realign.

## Information Paths

Last Hearth testimony, route geometry, recovered command tablets, and anchor records independently identify the outer works. The copied living hand can be matched through ducal records, Gerhold's orders, or surviving soldiers in MQ-19.

## Choices and State Changes

- `deep_muster_approach_open` becomes true.
- `last_hearth_forward_base` records held, damaged, reduced, or evacuated-and-restored.
- `remaining_anchor_access` remains open and receives a direct warning that it will close when MQ-20 begins.

The player chooses which finale approach receives the first engineering preparation. The other approaches remain available if later conditions support them.

## Fail-Forward Results

- A failed southern march costs escort strength and changes the Last Hearth defense.
- If the refuge falls during the first defense, survivors withdraw to a field camp; clearing the recall engine permits a reduced forward base.
- A lost command tablet has duplicates in the outer yard and Three Horn Depot.
- A failed yard assault exposes the maintenance route through collapse but costs defenders and stores.
- Active anchors increase pressure without making the operation impossible.

## Companion Intersections

Dismas, Svala, and Ilyana have strong road-and-command responses; Ashira distinguishes residue from persons; Bernard rejects false honorable service; Elara, Tavio, and Zafir support infiltration, mechanisms, and command-cord analysis. No companion is mandatory.

## Faction Advantages

Faction resolutions provide road repair, burial stations, guides, engineers, or covert supply. The Last Hearth base remains a coalition under immediate ducal defense, not a faction reward or new government.

## Cutoff and Unlocks

The chapter unlocks [[Gerhold's Choice]] and keeps every remaining anchor available. It also exposes the Deep Muster Approaches on the creator and discovered player maps without opening the final descent.

## Navigation

- [[The Unending Muster]]
- [[Deep Muster Approaches]]
- [[Muster Anchor Matrix]]
- [[Gerhold's Choice]]
- [[Main Campaign MOC]]
