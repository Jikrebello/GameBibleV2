---
type: mechanic
status: archived
canon_level: obsolete
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg"]
culture: []
related_factions: ["Blackjack Corps"]
appears_in: ["Grenzburg"]
needs: []
aliases: ["Companion Affinity and Duo Quest Standard", "Companion Shared History and Party Standard"]
tags: [game-ready]
archived_from: "02 Playable Settings/Grenzburg/50 Campaign/Companions"
archived_on: 2026-08-04
archive_reason: "pre-grounded-companion-recalibration snapshot"
superseded_by: "[[Companion Field Familiarity and Duo Quest Standard]]"
---
# Companion Field Familiarity and Duo Quest Standard

This note controls how companions join and leave the field party, how shared history develops, and when content uses the ordinary party or an intimate duo. [[Companion Campaign Architecture]] controls the eighty-eight authored pieces and seventy-four-piece playthrough ceiling. [[Companion Autonomy and Act Convergence]] controls deadlines and unassisted progression.

## Party Management

The normal field party is the player plus three companions. Companions may be added, dismissed, or reordered only at:

- the [[Blackjack Yard]];
- occupied settlement hubs;
- established camps and expedition staging points;
- stabilized travel nodes that explicitly offer party organization.

Dismissal never reduces approval. A dismissed companion returns to their assigned home base or current seasonal destination. Closed combat, pursuit, siege sequences, and personal quests do not permit party reorganization.

## Field Familiarity

Companion relationships grow through authored experience rather than elapsed time or a repeatable affection economy.

A **Field Familiarity beat** is a distinct witnessed event belonging to one of these families:

1. a meaningful quest completion;
2. discovery of a named ruin, settlement, route, or threat;
3. a moral or political choice relevant to the companion;
4. a rescue, retreat, defeat, or dangerous shared success;
5. a companion-specific intervention or observation;
6. a camp conversation unlocked by prior field experience.

Only companions in the active party witness private field beats. Public campaign transformations, company reports, witnesses, records, and visible consequences may inform later dialogue without pretending the companion personally saw a choice they missed.

Idle time, repeated resting, repeated crafting, and repeated job-template outcomes do not advance familiarity. A repeatable activity may provide one authored first-time observation, never an unlimited source.

## Approval and Disclosure

Approval remains qualitative:

- **Guarded:** the companion works with the player but withholds important personal material.
- **Open:** enough conduct has been witnessed for the first personal disclosures.
- **Trusted:** the companion will risk reputation, safety, or future plans on the player's judgement.
- **Strained:** a named disagreement blocks deeper trust until confronted or repaired.

The interface never displays a number. When a threshold is reached, the companion comments in context and later asks to speak at a camp or hub. Personal history is disclosed in stages; recruitment never delivers the whole biography.

## Campaign Tracking and Participation

A personal campaign becomes tracked when the player accepts its introductory case, explicitly promises help, or manually tracks a discovered personal matter.

Shared-history gates control:

- whether the player is invited into a companion's act finale;
- which preparation opportunities and disclosures are available;
- approval, repair, friendship, romance, and sworn-bond access;
- which player-led resolutions remain credible.

They do not control whether the companion acts. Every unresolved chapter advances at its act-ending main-story gate.

Meeting a conversational gate places a **wants to speak** notice at the next valid hub. It does not interrupt another closed quest. A strained companion receives a named repair conversation rather than a hidden numerical block.

## Party Formats

### Ordinary-Party Companion Content

Introductory cases and short act operations require the owning companion but retain the player plus up to three companions. The owner controls defining conversations and decisions; other companions may contribute without replacing them.

### Duo Act Finales

Each of the twenty-four act finales uses an intimate duo:

1. the finale begins at a named staging point after a party-change warning;
2. accepting forms a fixed party of the player and quest owner;
3. other companions return to their assigned destinations;
4. the duo remains fixed until completion or an authored pause;
5. pausing restores ordinary party management;
6. resuming reforms the duo and restores the recorded phase.

### Friendship, Romance, and Bond Episodes

These are one-on-one authored scenes or activities. Romance and sworn bond are separate quest notes with separate activities, states, and presentation. They need not dismiss the party until their private staging moment and need not include combat.

Temporary guides, witnesses, prisoners, soldiers, animals, and rescued people exist outside the companion limit. They may follow, fight, flee, or require protection, but they do not use companion progression, relationship perks, inventory authority, or party dialogue rules.

## Encounter Contract

Every duo act finale must be completable by the player and one companion across all player vocations. Ordinary-party content uses the standard field-party encounter budget.

- Enemy density, flanking pressure, revive expectations, and boss phases assume two full combatants.
- A companion may provide a distinctive shortcut, callout, or coordinated action, but not the only route through a required obstacle.
- Temporary NPC aid is additive and state-dependent, never required to make the base encounter mathematically possible.
- Required information has at least two sources and cannot depend on another companion's knowledge tag.
- Closed sections provide safe save behavior and at least one pause point during adventures expected to exceed ninety minutes.
- A downed companion creates a rescue pressure rather than immediate quest failure unless the scene explicitly establishes lethal stakes.

## Intimacy and Reactivity

The duo finale reserves conversational space for the quest owner. Travel dialogue, investigation, failure, recovery, and the final decision should reveal the relationship through action rather than inserting unrelated party commentary.

Other companions react through:

- pre-departure remarks at the staging hub;
- post-return conversations;
- later banter about a public consequence;
- faction or campaign scenes outside the personal adventure.

No companion interrupts another companion's confession, relationship commitment, or chosen-future scene.

Other companions may materially affect an autonomous route through authored cross-support outside the player-led finale.

## Relationship Rewards

A committed romance or sworn bond may grant:

- one campaign-specific, non-slot relationship perk usable without the companion present;
- one duo move usable only while that companion is active;
- one late intervention and one summer scene.

The player may hold one romance perk and one sworn-bond perk. Learned permanent perks remain if the companion later dies through a chosen sacrifice or departs; the duo move becomes unavailable without them.

## Companion-Quest Properties

Companion content records:

| Property | Use |
|---|---|
| `field_experience_gate` | Named shared-history observations relevant to disclosure or participation. |
| `companion_required` | The owning companion required in the field or private scene. |
| `duo_quest` | `true` for the formal fixed-duo act finales; `false` for introductions, operations, and private friendship or relationship activities that use one-on-one staging without the finale encounter contract. |
| `pause_points` | Named safe phases where ordinary party management can resume. |
| `relationship_gate` | Any approval, conflict, sex, or commitment requirement; empty when none. |
| `companion_content_role` | introduction, operation, act-finale, friendship, relationship, summer-coda, or embedded |
| `relationship_variant` | `romance`, `bond`, or empty. Required on authored relationship episodes. |
| `preparation_inputs` | Named assets that improve an act finale. |
| `preparation_threshold` | Bespoke qualitative condition for player participation. |
| `autonomous_deadline` | Act-ending main-story gate. |
| `changed_reentry` | Authored aftermath if the original event resolves without the player. |

## Navigation

- [[Companion Constitution]]
- [[Companion Campaign Architecture]]
- [[Companion Autonomy and Act Convergence]]
- [[Companions MOC]]
- [[Companion Reactive Scene Register]]
- [[Narrative State Register]]
- [[Quest and Content Architecture]]
- [[Grenzburg MOC]]
