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
  - allocate marquee, local, training, and job content from the Worldspace Location Register in the side-content wave
tags: [game-ready]
---
# Quest and Content Architecture

This note controls what kinds of quests Grenzburg contains, how they enter the campaign, what metadata they carry, and how much content the game budgets. It replaces the old assumption that every meaningful quest requires three factions, a legal device, or a metaphysical twist.

[[Grenzburg Worldspace Location Register]] controls physical placement. A later quest may claim a reserved site and define its cast, encounters, and persistent result; it may not silently move that site or create a disposable duplicate of an existing anchor.

## The Three Core Quest Experiences

### Authored Marquee Quests

These are the Witcher-style local stories: a strong human hook, investigation or discovery, a particular place, a conflict with more than one plausible action, and consequences that remain visible. Complexity must arise from people and circumstances rather than from piling on secret patrons, contracts, or cosmology.

### Faction Lines

These are long Skyrim-style institutional arcs. Each line introduces a social world, teaches its work, reveals an internal fault line, grants concrete services or abilities, and culminates in a leadership or doctrine decision. Faction quests remain available in parallel with the main story and react to seasonal milestones.

### Gameplay-Forward Local Work

These are clear journeys, rescues, hunts, delves, defenses, recoveries, deliveries, and confrontations whose combat, traversal, location, or creature design carries the experience. They still need a local reason and a visible result. They do not need a hidden moral inversion to justify their existence.

## Controlled Quest Classes

Every Grenzburg quest uses one quest class:

| Value | Use |
|---|---|
| main | One of the twenty-one critical-path chapters. |
| aftermath | One of the two required summer consequence quests. |
| faction | A stage in one of the five deep faction lines. |
| companion | One of four personal quests belonging to a full companion. |
| marquee | A large authored local story outside the main, faction, or companion lines. |
| local | A smaller finite authored quest with a specific local problem. |
| job | A finite placement or repeatable gameplay contract built from a controlled template. |
| training | A vocation, proficiency, craft, or specialist progression quest. |

Quest class describes production purpose, not quality. A short local rescue may be more memorable than a faction climax if its place and people are stronger.

## Required Quest Properties

Every active Grenzburg quest note must carry these properties in addition to ordinary vault frontmatter:

| Property | Controlled use |
|---|---|
| quest_class | main, aftermath, faction, companion, marquee, local, job, or training |
| act | prologue, act-1, act-2, act-3, summer, or multi-act |
| availability_window | One or more named windows from [[Season and World-State Constitution]]. |
| repeatability | one-shot, finite-repeat, or repeatable |
| cutoff_result | persists, transforms, resolves-offscreen, or fails |
| world_state_outputs | Named settlement, faction, companion, material, debt, access, or Muster states changed. |
| required_locations | Links to every location required by the quest. |
| blocking_status | concept, outlined, blocked, or implementation-ready |
| quest_owner | Named companion, faction line, institution, or local chain that owns the quest. |
| quest_sequence | Integer position inside a companion or faction ladder; zero when not applicable. |
| companion_id | CMP-01 through CMP-08 for companion content; empty otherwise. |
| faction_line | Controlled faction-line ID for faction content; empty otherwise. |
| faction_branch | shared, low-lanterns, black-bell, or empty as applicable. |
| chapter_id | MQ-01 through MQ-21 or SQ-01 through SQ-02 for main and aftermath content; empty otherwise. |
| main_sequence | Integer 1 through 23 for main and aftermath content; zero otherwise. |
| story_gate | open, open-world-window, operation, investigation, confrontation, season, season-transition, finale-transition, finale, aftermath, or postgame-open. |
| estimated_hours | Expected first-play critical-path hours; optional completion time is recorded in prose. |
| gameplay_pillars | Controlled list drawn from assault, boss, choice, closure, combat, command-response, consequence, defense, diplomacy, dungeon, expedition, exploration, hunt, infiltration, investigation, large-combat, mega-dungeon, memorial, pursuit, reclamation, reconnaissance, reconstruction, rescue, siege, social, social-conflict, survival, travel, traversal, urban-combat, and vertical-traversal. |
| required_states | States that must exist before the quest starts. |
| optional_state_inputs | Prior outputs that alter routes, costs, allies, encounters, or consequences without becoming mandatory. |

The fields record current design truth. They do not replace readable prose.

## Quest Anatomy

Every fully blocked quest must answer:

1. **Hook:** what the player sees or is asked to do.
2. **Immediate stake:** who needs help and what changes if the player delays.
3. **Player actions:** the travel, investigation, social play, traversal, combat, or craft that constitutes the quest.
4. **Opposition:** who or what resists and why.
5. **Information path:** how required facts can be learned through more than one source.
6. **Decision or mastery point:** the meaningful choice, preparation payoff, or gameplay test.
7. **Fail-forward result:** how failure changes rather than erases the problem.
8. **World outputs:** what visibly changes after completion or cutoff.
9. **Return value:** what character, location, system, or future conflict the quest prepares.

A simple job may answer these in a page. A marquee or main quest may require a controlling file and support dossiers.

## Main-Skeleton Rhythm

The critical path advances in blocks. A main chapter should normally do at least two of the following:

- open a district, road, subregion, dungeon, service, trainer, or companion;
- alter the campaign season or pressure;
- introduce or pay off a principal character;
- unlock a faction or companion stage;
- transform existing side content;
- teach a player system through meaningful use;
- resolve a question required by the next campaign block.

After most major chapters, the player receives an open window to pursue parallel content. The main path may signal urgency, but it must not pretend that a siege begins in ten minutes while encouraging twenty hours of exploration. Real deadlines appear only when the player explicitly commits to a closed operation.

## Content Budget

| Family | Target | Notes |
|---|---:|---|
| Main | 21 | Two prologue, six Act I, seven Act II, six Act III. |
| Aftermath | 2 | Required summer consequence and reopening quests. |
| Faction | 40-50 | Five lines of eight to ten quests. |
| Companion | 32 | Four per companion, excluding reactive scenes. |
| Marquee | 24 | Distributed across city and all seven exterior subregions. |
| Local | 36 | Finite authored problems and discoveries. |
| Job templates | 12 | Most placements finite; selected hunts, escorts, and bounties repeat. |

Faction and companion quests may achieve marquee depth, but they remain counted under their owning line. The budget avoids double-counting the same quest as three kinds of content.

## Job Templates

The twelve controlled job shapes are:

1. monster hunt;
2. fugitive or bandit bounty;
3. road escort;
4. endangered-person rescue;
5. site clearing;
6. patrol and reconnaissance;
7. salvage or recovery;
8. supply delivery;
9. settlement defense;
10. resource gathering with field complications;
11. duel or combat trial;
12. short investigation.

Most job placements are finite and handcrafted around a named place. Repeatable variants are restricted to activities whose repetition makes world sense, chiefly hunts, escorts, and bounties. Repeatable jobs rotate routes, conditions, targets, and rewards but never pretend to have permanent story consequences they cannot retain.

## Faction-Line Standard

The active faction library contains forty-eight authored notes: nine each for Ducal/Marcher, Blackjacks/Medori, Church, and Four-Hearth, plus six shared underworld quests and two exclusive three-quest branches. Each line crosses four movements:

1. **Admission:** learn the work and earn access.
2. **Service:** perform representative missions and meet internal factions.
3. **Fracture:** confront the institution's central corruption or disagreement.
4. **Settlement:** decide leadership, doctrine, method, or continued relationship.

At least one quest per line must be primarily social or investigative, one must use a distinctive dungeon or urban space, one must intersect a main crisis without becoming required for main completion, and one must visibly alter summer.

[[Faction Questlines MOC]] is the count and order authority. All five lines remain open through quest six; later internal lock-ins must display exact consequences.

## Companion-Line Standard

Each companion owns four major personal quests. Ordinary approval scenes and romance or bond conversations do not consume those four slots. [[Companion Constitution]] controls structure and eligibility.

Every personal quest uses the duo format from [[Companion Field Familiarity and Duo Quest Standard]]: the player and quest owner are the only full party members from staging-point acceptance until completion or an authored pause. Temporary NPC allies operate outside the companion limit. Encounter density, traversal, information, revive pressure, and boss phases must work for every player vocation with one companion.

Deep-blocked companion notes additionally record `field_experience_gate`, `companion_required`, `duo_quest`, `pause_points`, and `relationship_gate`. These fields do not apply to other quest classes.

[[Companions MOC]] is the count, order, and blocking-status authority for the thirty-two registered personal quests.

## Conversion-Library Boundary

Blocked adventure conversions remain independent references and craft studies. Grenzburg's game quests may learn from their clarity, encounter construction, fail-forward logic, or research discipline. They do not import conversion names, plots, locations, NPCs, or canonical outcomes into the main game unless a later explicit integration pass says so.

## Quality Tests

- The player can state what they are doing before being asked to care about hidden lore.
- A quest uses only as much politics or metaphysics as its premise needs.
- Required information has more than one source.
- A cutoff result is authored rather than merely deleting the quest marker.
- The primary gameplay mode changes often enough to avoid dialogue-combat-dialogue monotony.
- The reward supports money, gear, vocation, access, relationship, or world state rather than only experience points.
- The result is visible somewhere the player can revisit.

## Navigation

- [[Grenzburg Game Constitution]]
- [[Grenzburg Campaign Spine]]
- [[Grenzburg Chapter and Window Matrix]]
- [[Season and World-State Constitution]]
- [[Factions Overview]]
- [[Faction Questlines MOC]]
- [[Companion Constitution]]
- [[Companion Field Familiarity and Duo Quest Standard]]
- [[Companions MOC]]
- [[Narrative State Register]]
- [[Grenzburg MOC]]
