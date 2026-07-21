---
type: mechanic
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg"]
culture: []
related_factions: ["Blackjack Corps"]
appears_in: ["Grenzburg"]
needs: []
aliases: ["Companion Affinity and Duo Quest Standard"]
tags: [game-ready]
---
# Companion Field Familiarity and Duo Quest Standard

This note controls how companions join and leave the field party, how personal quests unlock, and how the thirty-two companion adventures are staged. [[Companion Constitution]] controls the roster and moral contract; individual companion references define their authored observations and rewards.

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

Only companions in the active party witness ordinary field beats. Public campaign transformations may inform later dialogue, but they do not pretend the companion personally saw a choice they missed.

Idle time, repeated resting, repeated crafting, and repeated job-template outcomes do not advance familiarity. A repeatable activity may provide one authored first-time observation, never an unlimited source.

## Approval and Disclosure

Approval remains qualitative:

- **Guarded:** the companion works with the player but withholds important personal material.
- **Open:** enough conduct has been witnessed for the first personal disclosures.
- **Trusted:** the companion will risk reputation, safety, or future plans on the player's judgement.
- **Strained:** a named disagreement blocks deeper trust until confronted or repaired.

The interface never displays a number. When a threshold is reached, the companion comments in context and later asks to speak at a camp or hub. Personal history is disclosed in stages; recruitment never delivers the whole biography.

## Personal Quest Release

Every personal quest requires:

- completion of the preceding companion stage;
- its named seasonal or campaign window;
- a short list of companion-specific Field Familiarity beats;
- no unresolved conflict explicitly marked as blocking that disclosure.

Meeting a gate places a **wants to speak** notice at the next valid hub. It does not interrupt another closed quest. A strained companion receives a repair conversation before the quest can begin; the player is never required to guess which action caused the block.

## Duo Quest Rule

All thirty-two personal quests are designed as intimate duo adventures.

1. The quest begins at a named staging point after a warning that the current party will change.
2. Accepting forms a fixed party of the player and the quest-owning companion.
3. Other companions return to their assigned hub and cannot enter the personal quest's central scenes.
4. The duo remains fixed until completion or an authored pause point.
5. Pausing returns the owner to the staging point and restores ordinary party management.
6. Resuming reforms the duo and restores the recorded quest phase.

Temporary guides, witnesses, prisoners, soldiers, animals, and rescued people exist outside the companion limit. They may follow, fight, flee, or require protection, but they do not use companion progression, relationship perks, inventory authority, or party dialogue rules.

## Encounter Contract

Every companion quest must be completable by the player and one companion across all player vocations.

- Enemy density, flanking pressure, revive expectations, and boss phases assume two full combatants.
- A companion may provide a distinctive shortcut, callout, or coordinated action, but not the only route through a required obstacle.
- Temporary NPC aid is additive and state-dependent, never required to make the base encounter mathematically possible.
- Required information has at least two sources and cannot depend on another companion's knowledge tag.
- Closed sections provide safe save behavior and at least one pause point during adventures expected to exceed ninety minutes.
- A downed companion creates a rescue pressure rather than immediate quest failure unless the scene explicitly establishes lethal stakes.

## Intimacy and Reactivity

The duo format reserves conversational space for the quest owner. Travel dialogue, investigation, failure, recovery, and the final decision should reveal the relationship through action rather than inserting unrelated party commentary.

Other companions react through:

- pre-departure remarks at the staging hub;
- post-return conversations;
- later banter about a public consequence;
- faction or campaign scenes outside the personal adventure.

No companion interrupts another companion's confession, relationship commitment, or chosen-future scene.

## Relationship Rewards

A committed romance or sworn bond may grant:

- one campaign-specific, non-slot relationship perk usable without the companion present;
- one duo move usable only while that companion is active;
- one late intervention and one summer scene.

The player may hold one romance perk and one sworn-bond perk. Learned permanent perks remain if the companion later dies through a chosen sacrifice or departs; the duo move becomes unavailable without them.

## Companion-Quest Properties

Deep-blocked companion quests record:

| Property | Use |
|---|---|
| `field_experience_gate` | Named authored observations required before the quest can be offered. |
| `companion_required` | The quest-owning companion; no other full companion is permitted. |
| `duo_quest` | `true` for every personal quest. |
| `pause_points` | Named safe phases where ordinary party management can resume. |
| `relationship_gate` | Any approval, conflict, sex, or commitment requirement; empty when none. |

## Navigation

- [[Companion Constitution]]
- [[Companions MOC]]
- [[Companion Reactive Scene Register]]
- [[Narrative State Register]]
- [[Quest and Content Architecture]]
- [[Grenzburg MOC]]
