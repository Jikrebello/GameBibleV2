---
type: mechanic
status: archived
canon_level: obsolete
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg"]
culture: []
related_factions: []
appears_in: ["Grenzburg"]
needs:
  - allocate marquee, local, training, and job content from the Worldspace Location Register in the side-content wave
tags: [game-ready]
archive_reason: "Pre-pass control snapshot"
archived_from: "02 Playable Settings/Grenzburg/10 Production Bible/Quest and Content Architecture.md"
archived_on: 2026-07-27
superseded_by: "Active controlling note at the archived path"
---
# Quest and Content Architecture

This note controls what kinds of quests Grenzburg contains, how they enter the campaign, what metadata they carry, and how much content the game budgets. [[Grenzburg RPG Experience Constitution]] controls the relationship among the main campaign, player-authored play, autonomous companion campaigns, and the systemic world. This note replaces the old assumption that every meaningful quest requires three factions, a legal device, or a metaphysical twist.

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
| companion | An introduction, operation, act finale, friendship episode, relationship episode, or summer coda in a full companion campaign. |
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
| reward_unlocks | Named techniques, services, parts, perks, blueprints, routes, or progression assets unlocked; conditional rewards remain labelled in prose. |
| required_locations | Links to every location required by the quest. |
| blocking_status | concept, outlined, blocked, or implementation-ready |
| quest_owner | Named companion, faction line, institution, or local chain that owns the quest. |
| quest_sequence | Integer position inside a companion or faction ladder; zero when not applicable. |
| companion_id | CMP-01 through CMP-08 for companion content; empty otherwise. |
| faction_line | Controlled faction-line ID for faction content; empty otherwise. |
| faction_branch | shared, low-lanterns, black-bell, or empty as applicable. |
| chapter_id | MQ-01 through MQ-21 or SQ-01 through SQ-02 for main and aftermath content; empty otherwise. |
| main_sequence | Integer 1 through 23 for main and aftermath content; zero otherwise. |
| story_gate | open, open-world-window, operation, preparation, investigation, confrontation, friendship, relationship, season, season-transition, finale-transition, finale, aftermath, summer-aftermath, or postgame-open. |
| estimated_hours | Expected first-play critical-path hours; optional completion time is recorded in prose. |
| gameplay_pillars | Controlled list drawn from assault, boss, choice, closure, combat, command-response, consequence, conversation, defense, diplomacy, dungeon, environmental-puzzle, escort, expedition, exploration, hunt, infiltration, investigation, large-combat, mega-dungeon, memorial, moving-vehicle, protection, pursuit, reclamation, reconnaissance, reconstruction, reflection, rescue, siege, social, social-conflict, survival, travel, traversal, urban-combat, vertical-traversal, and weather. |
| required_states | States that must exist before the quest starts. |
| optional_state_inputs | Prior outputs that alter routes, costs, allies, encounters, or consequences without becoming mandatory. |
| companion_content_role | introduction, operation, act-finale, friendship, relationship, summer-coda, embedded, or empty |
| companion_campaign_stage | introduction, act-1, act-2, act-3, relationship, summer, or empty |
| relationship_variant | romance, bond, or empty; mandatory for authored relationship episodes |
| architecture_status | pending-migration, migrated, reserved, current, retired, or empty |
| preparation_inputs | Named evidence, support, practice, route, or material assets that improve a finale. |
| preparation_threshold | Bespoke participation requirement stated as a readable condition. |
| autonomous_deadline | Main-story gate at which unresolved companion content advances. |
| autonomous_resolution | Deterministic authored state or controlling resolution reference. |
| changed_reentry | Aftermath state offered when the original event resolves without the player. |
| ensemble_inputs | Companions, Blackjacks, factions, or beneficiaries who may affect an autonomous route. |
| identity_hooks | Origin, background, vocation, moral, social, or reputation uses credited through [[Player Identity Reactivity Matrix]]. |
| emotional_rewrite_status | preserve, reframe, replace, cleared, or empty. A structural block may still await emotional rewriting. |
| dialogue_status | pending-rewrite, calibrated, approved, or empty. Companion content must be approved before implementation readiness. |
| archetype_pressure | The specific point where a companion's gift risks becoming its shadow. |
| emotional_function | What the piece changes or reveals in the companion relationship beyond plot delivery. |
| pleasure_beat | Concrete appetite, humor, play, beauty, or ordinary enjoyment preserved inside the piece. |
| care_beat | A specific action through which a character gives or receives care. |
| player_archetype_hooks | Authored player-temperament reactions credited through [[Player Temperament and Chemistry]]. |
| encounter_deck | District, region, route, or seasonal systemic deck that may call the content. |
| persistence_scope | none, local-temporary, local-persistent, regional-milestone, or campaign |
| postgame_season | autumn, winter, spring, summer, multi-season, or empty |

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
| Companion | 88 authored; up to 74 playable in one run | Eleven authored pieces per companion, with separate mutually exclusive romance and bond episodes, excluding 8-12 embedded opportunities each. |
| Marquee | 24 | Distributed across city and all seven exterior subregions. |
| Local | 36 | Finite authored problems and discoveries. |
| Job templates | 12 | Most placements finite; selected hunts, escorts, and bounties repeat. |

Faction and companion quests may achieve marquee depth, but they remain counted under their owning line. The expanded companion budget is added on top of the marquee, local, faction, and job budgets rather than replacing them.

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

## Companion-Campaign Standard

[[Companion Campaign Architecture]] controls the eighty-eight-piece authored budget and maps each old four-quest line into one introduction and three act finales.

- Introductory cases and short operations require the owner but retain the ordinary field party.
- Act finales use the player-plus-owner duo.
- Friendship episodes are available to every player.
- Separate romance and sworn-bond episodes are authored for every companion; commitment exposes only the eligible one.
- Summer codas reflect settled outcomes without reopening them.
- Each act finale has three to five useful preparation opportunities and a bespoke participation threshold.
- Every unresolved act chapter advances at the act-ending main-story gate.
- Missing a finale produces deterministic autonomous resolution and changed re-entry rather than indefinite waiting.

[[Companion Campaign Expansion Register]] is the formal count authority. [[Companion Autonomy and Act Convergence]] controls tracking, deadlines, cross-support, and no-unseen-death rules.

Companion notes retain `architecture_status: pending-migration` until their individual retrofit or deep block. Structurally completed campaigns use `architecture_status: migrated`. That value does not certify emotional or dialogue readiness.

## Companion Emotional Readiness

[[Companion Emotional Rewrite Audit]] controls preserve, reframe, and replace dispositions. [[Companion Archetype Constitution]] controls the emotional engine, and [[Companion Dialogue and Scene Standard]] controls voice and scene craft.

A companion quest may retain `blocking_status: blocked` while its prose is not ready for implementation. It reaches `blocking_status: implementation-ready` only when:

1. `emotional_rewrite_status: cleared`;
2. `dialogue_status: approved`;
3. its archetype pressure is dramatized rather than stated;
4. it contains concrete pleasure and care beats appropriate to the companion;
5. required player-temperament variants and a complete grey baseline exist;
6. a blind voice review can distinguish its owner without the speaker label.

Preserve means the premise survives, not that old dialogue survives. Reframe and replace pieces remain visible in the emotional rewrite queue and are excluded from Game-Ready Content.

## Identity-Reactivity Standard

Implementation-ready main, faction, companion, marquee, local, and training content records applicable `identity_hooks`. Companion and dialogue-heavy content also records applicable `player_archetype_hooks`. A hook counts only when it changes access, risk, price, trust, information, traversal, encounter behavior, quest method, or relational texture with a real authored consequence.

[[Player Identity Reactivity Matrix]] controls the campaign-wide 10/8/8 identity targets and temperament coverage. A critical identity restriction always has a credible workaround.

## Systemic-World Boundary

Systemic encounters are authored cards rather than formal quests unless their scope develops into a named chain. [[World Simulation and Discovery Constitution]] controls selection, density, repetition, and persistence.

Named one-shot discoveries remain changed. Only credible patrols, travelers, weather incidents, hunts, camps, bounties, and other designated patterns may repeat.

## Conversion-Library Boundary

Blocked adventure conversions remain independent references and craft studies. [[Sandbox Quest Pattern]] records the approved structural lessons: central truth, useful preparation, multiple approaches, legible state, fail-forward play, and persistent endings. Grenzburg does not import conversion names, plots, locations, NPCs, or canonical outcomes unless a later explicit integration pass says so.

## Quality Tests

- The player can state what they are doing before being asked to care about hidden lore.
- A quest uses only as much politics or metaphysics as its premise needs.
- Required information has more than one source.
- A cutoff result is authored rather than merely deleting the quest marker.
- The primary gameplay mode changes often enough to avoid dialogue-combat-dialogue monotony.
- The reward supports money, gear, vocation, access, relationship, or world state rather than only experience points.
- The result is visible somewhere the player can revisit.
- A major quest records any identity hooks it claims.
- A companion act finale visibly uses its preparation assets.
- A companion scene contains concrete business, appetite or pleasure, care, subtext, and a residue that is not a neat moral summary.
- A companion quest awaiting emotional or dialogue rewriting is not presented as implementation-ready.
- Systemic content does not silently decide named deaths, companion arcs, faction endings, or major settlement survival.

## Navigation

- [[Grenzburg Game Constitution]]
- [[Grenzburg Campaign Spine]]
- [[Grenzburg Chapter and Window Matrix]]
- [[Season and World-State Constitution]]
- [[Factions Overview]]
- [[Faction Questlines MOC]]
- [[Companion Archetype Constitution]]
- [[Companion Dialogue and Scene Standard]]
- [[Companion Emotional Rewrite Audit]]
- [[Player Temperament and Chemistry]]
- [[Companion Constitution]]
- [[Companion Campaign Architecture]]
- [[Companion Autonomy and Act Convergence]]
- [[Companion Field Familiarity and Duo Quest Standard]]
- [[Companion Campaign Expansion Register]]
- [[Companions MOC]]
- [[Player Identity Reactivity Matrix]]
- [[World Simulation and Discovery Constitution]]
- [[Sandbox Quest Pattern]]
- [[Narrative State Register]]
- [[Grenzburg MOC]]
