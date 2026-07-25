---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenz Lowlands", "Upper Grenz"]
culture: ["Eclessian", "Folk", "Grobi", "Ättar"]
related_factions: ["Duchy of Grenzburg", "Marcher Vanguard", "Blackjack Corps", "Folk kindreds"]
appears_in: ["Grenzburg"]
needs: []
aliases: []
tags: [game-ready]
quest_class: main
act: act-1
availability_window: ["Early Autumn"]
repeatability: one-shot
cutoff_result: persists
world_state_outputs: ["southbound_convoy", "ylva_recruited", "ylva_campaign_tracked", "ylva_fourth_marker_restored", "folk_road_claim", "tannbruck_access"]
required_locations: ["Tann Field", "Timberfalls", "Black Fir Watch", "Fort Tannbruck"]
blocking_status: blocked
quest_owner: "Grenzburg Main Campaign"
quest_sequence: 0
companion_id: ""
faction_line: ""
faction_branch: ""
chapter_id: "MQ-04"
main_sequence: 4
story_gate: operation
estimated_hours: 1.25
gameplay_pillars: [traversal, social, defense, combat]
required_states: ["three_mills_road"]
optional_state_inputs: ["broken_tollworks_state", "road_prisoners_state", "ducal_rank_admitted", "compact_initial_trust", "ylva_fourth_marker_restored"]
---
# The Southbound Muster

## Chapter Function

This chapter carries the player from the safer north into the military frontier, recruits [[Ylva Winter-Track]], and makes the Folk conflict concrete without treating every local claim as righteous or every marcher road as illegitimate. It ends by establishing [[Fort Tannbruck]] as a temporary home base.

## Trigger and Commitment

Liese assembles a reinforcement convoy at Tann Field after MQ-03. The convoy includes forty soldiers, twelve replacement Blackjacks, bridge timber, lamp oil, medicine, and civilian carriers. Accepting departure creates a closed road operation of one game day; open-world play resumes at Timberfalls and again at Tannbruck.

## Hook and Immediate Stake

Fort Tannbruck's autumn garrison is under strength. Its bridge winch and Watch Hill signal need parts before snow. The convoy must pass [[Timberfalls]] and Black Fir Watch before dark or camp in a road section repeatedly struck by raiders.

Koss assigns Ylva to the route detail because her severe-weather fieldcraft is useful and her White-Sled surety lets him treat unclaimed watches as part of her debt service. She is a Grey-Wolf Hunter and rescue pathfinder, not a heavy front-line fighter. Her warmth appears through repaired harness, hot food, and noticing who is already exhausted.

The route board assigns her to four simultaneous watches after Koss removes a paid scout from the roster. The omitted position stops answering, and two supply carts follow its false all-clear. This opens [[The Fourth Marker]] as Ylva's normal-party introductory case.

The player may join the case before departure or leave Ylva to resolve it autonomously while the main convoy completes its preparation. Either route introduces and recruits her, but only personal participation can secure every victim, supply, truth, and preparation reward.

## Beginning: Timberfalls

At Timberfalls, loose timber has jammed a river bend and delayed the army's bridge components. The player helps free a pinned rafter, defend workers from bandits who use the jam as cover, and choose whether the convoy carries bridge timber or additional fuel when not all loads can leave before dusk.

This is a concise service problem rather than a hidden plot. The bandits are local opportunists, not agents of Ghor or Jorund.

If [[The Fourth Marker]] was completed personally, its restored warning point identifies the bandits' approach and a staffed relief crew receives the pinned worker. If Ylva handled it alone, she arrives with the same route intelligence but an undisclosed injury and reduced supplies.

## Middle: The Moved Stone

At Black Fir Watch, a Shattered-Tusk war-band blocks the road behind an uprooted boundary stone. Its leader, Harek Split-Antler, claims the widened military road crosses a burial copse. A ducal road crew did move the stone during summer work. Harek has also killed two unarmed charcoal carriers on an older public track and demands the entire road close.

The player can establish a bounded settlement by:

- restoring the copse boundary and narrowing the military road;
- securing witnessed seasonal passage and compensating damaged graves;
- exposing that the murdered carriers never crossed the disputed ground.

Harek refuses any settlement that permits ducal passage. Nearby households will accept a marked boundary and safe road. The player may separate them from Harek through evidence and social play, challenge his fighters away from the convoy, or break the blockade directly.

No outcome grants Harek permission to murder civilians. No outcome gives the Duke ownership beyond the road and repaired boundary.

## End: First Grobi Probe

Near the Upper Grenz, a disciplined Grobi probe attacks the rear wagons while smaller goblins rush the food carts. Their purpose is to measure response time and identify valuable loads. Captured markings connect them to Ghor's emerging Bloody-Sun Host, but the force withdraws before a decisive fight.

The player holds the road, rescues separated carriers, and protects or abandons one delayed wagon. A fast response can capture a horn-token showing three southern routes.

The convoy enters Fort Tannbruck at dusk. Captain Hedda Rann receives the column, assigns the Blackjacks quarters in Service Row, and immediately identifies the broken Watch Hill signals as the next priority.

## Encounters and Opposition

- timber-jam rescue and bandit defense;
- boundary investigation and tense road confrontation;
- optional duel, flanking route, or direct fight against Harek's war-band;
- moving-convoy defense against the first organized Grobi probe.

## Information Paths

Survey stakes, the stone's root scar, and a road worker establish that the boundary moved. Burial cloth, household testimony, and old wheel ruts establish the narrower legitimate claim. The Grobi purpose is read through withdrawal discipline, copied wagon marks, or the horn-token.

## Choices and State Changes

- `southbound_convoy` records soldiers, bridge timber, fuel, medicine, and carriers delivered.
- `ylva_recruited` becomes true and opens Ylva as a full companion.
- `ylva_campaign_tracked` records whether the player joined her introductory case.
- `ylva_fourth_marker_restored` records whether the missing watch received a real relief roster rather than another promise that Ylva would cover it.
- `folk_road_claim` becomes bounded-passage, occupied-road, abandoned-road, or blood-feud.
- `tannbruck_access` opens the fort and Upper Grenz public route.

## Fail-Forward Results

- A failed timber rescue costs one carrier and forces a lighter convoy; Timberfalls remains accessible.
- If Harek escapes, his road-raiders appear in MQ-06 and MQ-07.
- If the convoy camps, the Grobi attack occurs at night with more stealth and fewer civilians exposed.
- If the horn-token is lost, Tannbruck scouts later recover partial route evidence at greater cost.

## Companion Intersections

- Ylva reads danger and extraction before damage, covers separated carriers, and reveals her habit of hiding injury rather than asking another scout to take the watch.
- Ilyana can organize the timber release and moving defense.
- Dismas detects the Grobi observation team.
- Bernard can witness the boundary settlement without declaring the Church owner of the graves.

## Faction Advantages

Ducal service supplies engineers; Folk trust supplies a neutral household witness; Blackjack gear state preserves an extra wagon. These improve outcomes but do not replace investigation or defense.

## Cutoff and Unlocks

Arrival opens Fort Tannbruck, Timberfalls travel, Upper Grenz jobs, Ylva as a full companion, [[A Signal Shared]], and [[Fort Tannbruck Main Quest|Fort Tannbruck]]. It does not advance the season.

## Navigation

- [[ACT I THE CLOSING ROADS]]
- [[Fort Tannbruck Main Quest|Fort Tannbruck]]
- [[Ylva Winter-Track]]
- [[The Fourth Marker]]
- [[Ylva Companion Campaign]]
- [[Main Campaign MOC]]
- [[Main Campaign State Matrix]]
