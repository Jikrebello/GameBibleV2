---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day", "Giant Age"]
region: ["The Deep Muster", "Frostfenn March"]
culture: ["Qianglong", "Eclessian", "Folk"]
related_factions: ["Duchy of Grenzburg", "Blackjack Corps", "Church of the Redeemer", "Folk kindreds"]
appears_in: ["Grenzburg"]
needs: []
aliases: ["The Deep Muster - Main Quest"]
tags: [game-ready]
quest_class: main
act: act-3
availability_window: ["Muster Crisis"]
repeatability: one-shot
cutoff_result: persists
world_state_outputs: ["general_below_stopped", "deep_muster_altar_destroyed", "deep_muster_site_state", "campaign_victory"]
required_locations: ["Deep Muster Approaches", "The Deep Muster", "Last Hearth"]
blocking_status: blocked
quest_owner: "Grenzburg Main Campaign"
quest_sequence: 0
companion_id: ""
faction_line: ""
faction_branch: ""
chapter_id: "MQ-21"
main_sequence: 21
story_gate: finale
estimated_hours: 4.0
gameplay_pillars: [mega-dungeon, exploration, large-combat, boss, closure]
required_states: ["gerhold_command_severed", "muster_anchor_threshold_met", "final_assault_strength"]
optional_state_inputs: ["muster_anchor_count", "all_anchor_states", "emerald_law_gem_custody", "all_companion_states", "all_faction_progress", "deep_muster_approach_preparation"]
---
# The Deep Muster

## Chapter Function

This is the five-layer final mega-dungeon and the culmination of Act III. It pays off anchor destruction, Gerhold's severed command, companion and faction support, and the campaign's moral distinction between duty and ownership. The General Below is stopped and the deepest altar destroyed in every completed campaign; the cost and surviving site vary.

## Trigger and Commitment

The dead formations withdraw into the southern basin. At Last Hearth the player receives a final review of active anchors, allied strength, approach preparations, party composition, and quests transformed by entry. Crossing the selected approach begins the finale and prevents ordinary return until victory or a fail-forward extraction.

## Approach Choices

- **Intake Gate:** direct military assault; best with strong allied support and destroyed siege anchors.
- **Last Hearth Shaft:** damaged maintenance route; tighter, quieter, and dependent on roadhead survival.
- **Fen Wound:** unstable breach through black mud; dangerous but bypasses part of Outer Mobilization.

Every starting vocation can complete every approach. Slayer movement, Hunter tracking, Warlock counter-scripts, Medium pattern reading, and Fighter control create advantages rather than exclusive locks. An unlocked Lancewright may interact with physical command carriers but is never required.

## Beginning: Layer I, Outer Mobilization

The party crosses intake yards, barracks, route scales, and newly recalled formations. The principal objective is to open a return-and-supply line before the works seal behind them. `final_assault_strength` determines allied reach, casualty pressure, and whether the party receives one forward recovery point.

An active Watch-Hill anchor adds recent-dead reinforcement waves. Destroying or bypassing local intake relays limits those forces inside the dungeon but does not retroactively count as regional anchor destruction.

## Middle: Layer II, Body and Equipment Works

Sorting halls reduce remains, armor, and battlefield material into replacement parts. The party must stop one live processing line while choosing whether to preserve names and remains, salvage useful machinery, or collapse the works quickly.

An active Cold-Iron anchor would supply crab-like replacement armor, but MQ-16 always destroyed it. Its absence teaches the anchor system by visibly leaving malformed gaps in the production line.

## Layer III: Campaign Archive

The archive contains maps of extinct fronts, incompatible orders, casualty rolls, and the truth of the ancient closure. It proves that coerced auxiliaries and laborers broke relay links while defecting keepers buried the deepest command hall. The player may preserve selected evidence, burn the archive, or use false campaign orders to redirect formations.

An active Tuskway Banner Vault adds imposed rank and formation-control effects. Rejecting false rank, destroying archive standards, or applying a captured counter-order weakens those effects locally.

## Layer IV: Command Depths

The party crosses recursive officer halls and replacement artillery galleries. Gerhold's severed command leaves a vacant structure trying to classify the player as successor. Accepting is never required. Tactical impersonation can open one door but raises command pressure until the assumed rank is explicitly rejected.

An active River Arsenal anchor adds siege volleys and pressure-breath channels. The party can disable individual galleries, but the final avatar retains the regional power if the anchor survived.

## End: Layer V, The Wound Below

The deepest space is an Abyssal altar built from Qianglong refusal: no discharge, no completed war, and no person beyond service. Black mud rises through ranked stone as the General Below attempts to materialize.

Its first complete battlefield body is a **corpse-built dragon-avatar**, assembled from residue formations rather than souls:

- a long eel-like coil carries marching bodies through black mire;
- a lamprey mouth turns command into hunger and pressure;
- crab-armored limbs replace themselves from active works;
- banners, roads, and siege frames produce the silhouette of wings;
- no stable natural anatomy suggests a drake or biological species.

## Final Confrontation

The battle has three required objectives:

1. **Break the avatar:** defeat its current body while anchor powers alter phases.
2. **Prevent reformation:** sever three altar feeds, redirect or destroy the campaign archive's last command, and refuse the offered supreme rank.
3. **Destroy the altar:** use physical collapse, White-Flame release, warlock counter-script, law-gem stabilization, or a combined method to end the Material foothold.

Anchor effects are exact:

- Watch Hill active: recent-dead reinforcement waves;
- River Arsenal active: siege volleys and pressure breath;
- Tuskway active: imposed rank and formation control;
- Fen Ossuary active: black-mud regeneration and eel-burrow movement;
- Cold-Iron destroyed: armor replacement remains permanently impaired.

All five destroyed creates the cleanest assault. Three destroyed is always sufficient, but remaining powers raise losses and contamination.

## Encounters and Set Pieces

- approach-specific breach and return-line objective;
- Outer Mobilization battle with anchor-dependent reinforcements;
- live processing-line shutdown while remains and records are at risk;
- archive navigation through contradictory campaigns and false orders;
- command-depth artillery, recursive officers, and rejected succession;
- corpse-built dragon-avatar confrontation;
- altar-feed interruption, reformation crisis, and permanent closure escape.

## Information Paths

Regional anchor records, the campaign archive, physical production lines, Gerhold's copied tablets, and the ancient closure evidence independently explain the system. A missed archive chamber removes historical detail or a tactical shortcut, never the identity of an altar feed or the means to stop reformation.

## Intelligence and Temptation

The [[The General Below|General Below]] speaks coherently through rank, praise, and accusation. It offers perfect defense, restored purpose, and an army that will never abandon Grenzburg. It is a sovereignly evil true dragon, not Gerhold's ghost, the soldiers' collective soul, or a creature that can be responsibly harnessed.

The final refusal is expressed through action as well as dialogue: releasing bodies, breaking rank, choosing living vulnerability, and ending a useful machine rather than owning it.

## Fail-Forward Results

- A failed layer objective costs evidence, remains, allied support, or a recovery point while opening a harsher route onward.
- Party defeat before the Wound produces extraction to the last secured layer and advances dungeon pressure.
- Defeat at the avatar destroys one prepared support and returns the party to a failing command-depth refuge; the altar cannot simply win off-screen.
- Losing preserved evidence changes summer knowledge, not the ability to close the wound.
- No failed roll permanently hides a required altar feed or makes one vocation mandatory.

## Choices and State Changes

- `general_below_stopped` becomes true.
- `deep_muster_altar_destroyed` becomes true.
- `deep_muster_site_state` records purified-and-buried, flooded, collapsed, burned, or partially-preserved after closure.
- `campaign_victory` becomes true.

The player also records preserved remains, archives, routes, machinery, and allied casualties. None permits recurring control of the Muster.

## Companion Intersections

The three active companions receive final-dungeon solutions tied to their arcs. Other resolved companions affect approach support and evacuation. No companion, romance, bond, custody result, or advanced vocation is required. Broken or absent companions remain absent.

## Faction Advantages

Resolved factions supply physically bounded support: an approach force, casualty refuge, route knowledge, engineering, supplies, or evacuation. Their assistance changes losses and optional objectives without granting ownership of the Muster or replacing the party's closure work.

## End and Unlocks

The altar fails, organized formations collapse, and the living evacuate through the secured route. There is no formal credits endpoint. The campaign moves directly into [[Accounts of the Living]], where casualties, claims, companions, and politics are resolved in the changed city.

## Navigation

- [[The Deep Muster]]
- [[The General Below]]
- [[Muster Anchor Matrix]]
- [[Accounts of the Living]]
- [[Main Campaign MOC]]
