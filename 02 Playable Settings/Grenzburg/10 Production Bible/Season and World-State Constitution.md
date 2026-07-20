---
type: mechanic
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg"]
culture: []
related_factions: []
appears_in: ["Grenzburg"]
needs:
  - define the exact world-state ledger and save-data implementation during integration
aliases: ["Campaign Structure Notes (Open-World Pacing)"]
tags: [game-ready]
---
# Season and World-State Constitution

This note controls campaign time, quest windows, regional persistence, and summer aftermath. It is not an in-world calendar simulation. Time advances when the player knowingly completes a campaign milestone.

## Time Model

Grenzburg uses four playable seasonal states:

1. **Autumn:** roads close, refugees move, stores are gathered, and the frontier contracts.
2. **Winter:** the city and fortified routes are under siege; snow, ice, scarcity, and urban pressure reshape play.
3. **Spring:** thaw exposes bodies, abandoned holdings, damaged roads, land disputes, and the Deep Muster.
4. **Summer:** the crisis has ended, but the surviving region reveals who gained power and what can be rebuilt.

The calendar does not advance continuously while the player explores. Rest, travel, crafting, and side content consume implied local time without silently ending quests. Seasonal transition occurs only at named critical-path gates.

## Player-Controlled Transition Rule

Before crossing an autumn, winter, spring, or finale threshold, the game must:

- name the action that will advance the campaign;
- state that some quests or conditions will change;
- identify all currently tracked quests that will conclude, fail, or transform;
- allow the player to cancel and return to the open world;
- never hide a point of no return inside ordinary travel or dialogue.

Warnings describe consequences without spoiling unknown story outcomes.

## Campaign Windows

| Window | Opens | Closes | Open-world purpose |
|---|---|---|---|
| Black Road | New game | arrival at Grenzburg | Tutorial rescue, convoy choices, first companions, first debt pressure. |
| Early Autumn | Grenzburg admission | Southbound Muster | Learn the city, take first faction contacts, acquire services, explore northern and western roads. |
| Open Autumn | Southbound Muster | Last Convoy commitment | Stabilize roads and settlements, pursue faction work, recruit companions, clear grounded dungeons. |
| Late Autumn | Last Convoy | fall of Fort Tannbruck | Resolve exposed frontier work and determine the fort's survivors, intelligence, and supplies. |
| Early Winter | city lockdown | Emerald hunt commitment | Urban quests, first siege operations, faction escalation, winter services. |
| Deep Winter | drake hunt opens | final assault on Ghor | Balance urban politics, the Emerald Drake hunt, and shock operations. |
| Early Spring | first thaw | Gerhold's irreversible choice | Reclaim holdings, reopen routes, investigate residue musters, resolve delayed autumn wounds. |
| Muster Crisis | Gerhold accepts the dead command | descent into the Deep Muster | Defend the region, settle final faction preparations, resolve companion arcs, enter finale. |
| Summer Aftermath | Deep Dragon stopped | open-ended | See consequences, resolve debt and political settlement, rebuild, explore, and complete surviving content. |

## Quest Window States

Every quest at a transition resolves into one of four controlled states:

- **persists:** unchanged and still available;
- **transforms:** returns in a season-appropriate form with prior choices retained;
- **resolves-offscreen:** the world reaches a stated outcome because the player did not intervene;
- **fails:** its core objective becomes impossible, with a visible consequence and any appropriate continuation.

Seasonal cutoff never means that an NPC simply vanishes without a recorded result. A quest that transforms should feel authored for the new season, not merely receive snow on its terrain.

## World-State Families

The campaign records outcomes in seven families. Later waves may implement these as variables, sets, or authored state bundles.

### Settlement State

Population, leadership, stores, services, damage, displacement, and local allegiance for each hub and vulnerable community.

### Regional Access and Safety

Road control, bridges, patrols, camps, fast-travel availability, creature pressure, Grobi routes, and cleared or occupied dungeons.

### Faction State

Rank, institutional stance, completed sequence, internal alignment, leader states, services, and settlement terms. All five lines remain open through quest six; later lock-ins are explicit. No single global reputation number replaces faction-specific consequences. [[Narrative State Register]] controls the values.

### Companion State

Recruitment, active personal stage, Guarded/Open/Trusted/Strained approval, named conflicts, personal outcome, relationship commitment, departure, injury, and ending destination. One romance and one sworn bond use separate commitment slots. [[Narrative State Register]] controls the values.

### Material Survival

Food, fuel, shelter, garrison capacity, civilian casualties, refugee burden, disease, and reconstruction resources. [[Grenzburg Numbers and Constraints]] supplies current anchors.

### Debt and Player Standing

Outstanding obligation, Blackjack status, Bank leverage, ducal warrant, criminal exposure, public recognition, and freedom state.

### Deep Muster State

Known signs, awakened sites, residue pressure, Gerhold's preparations, seals secured, and finale assets. This state remains independent of Grobi, Drake, and faction causation.

## Seasonal Transformation Standard

Every exterior subregion must change in at least five visible ways per season:

- traversal and weather;
- inhabitants and camp patterns;
- creatures or hostile control;
- available services and resources;
- quests, conversations, or discoveries;
- visible damage, recovery, burial, or construction where applicable.

The city must also change through gates, crowds, prices, patrols, interiors, public notices, ambient scenes, faction presence, and available routes. Seasonal change cannot be only a sky and texture swap.

## Fixed Campaign Transformations

- Fort Tannbruck falls at the end of Act I. Prior play determines evacuation, supplies recovered, defenders saved, intelligence gained, and the strength of the winter line.
- Ghor's organized siege is defeated at the end of Act II. Grobi survival, splintering, captives, migration routes, and later relations remain variable.
- Gerhold's acceptance of the Unending Muster occurs in Act III. He cannot return to ordinary command afterward.
- The General Below is stopped in every completed campaign. How much survives the stopping remains variable.

## Summer Contract

Summer is a playable state, not a slideshow attached to the final boss. It begins with two critical aftermath quests:

1. **Accounts of the Living:** count survivors, settle immediate authority, confront debt status, and establish companion destinations.
2. **The First Summer Road:** travel through the reopened region, witness settlement and faction consequences, and choose the first reconstruction priority.

After those quests, surviving faction, companion, local, dungeon, hunt, and repeatable content remains available where logically possible. Rebuilt services, memorials, displaced populations, hostile remnants, and new patrols must reflect the recorded campaign state.

## No Canonical Political Ending

Wave 1 does not select a ducal, Church, Bank, Folk, underworld, coalition, or independence ending as setting canon. Every political ending must first be fully designed, costed, and checked against companion and settlement outcomes. A future continuity ruling requires its own explicit pass.

## Navigation

- [[Grenzburg Game Constitution]]
- [[Grenzburg Campaign Spine]]
- [[Grenzburg Chapter and Window Matrix]]
- [[Quest and Content Architecture]]
- [[Grenzburg Regional Geography]]
- [[Grenzburg MOC]]
