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
aliases: ["Companion Affinity and Duo Quest Standard", "Companion Shared History and Party Standard"]
grounded_rewrite_status: approved
tags: [game-ready]
---
# Companion Field Familiarity and Duo Quest Standard

This note controls party management, earned familiarity, private access, and fixed-duo finales.

## Party Management

The ordinary party is the player plus three companions. Reorganization occurs at the Blackjack Yard, occupied hubs, established camps, and stabilized travel nodes. Dismissal has no approval cost. Dismissed companions return to their current assignment or seasonal home base.

## Field Familiarity

Familiarity records distinct authored experiences rather than elapsed time, gifts, repeated jobs, or dialogue farming.

Valid beats include:

- surviving a substantial operation together;
- witnessing a difficult decision relevant to the companion;
- completing a rescue, expedition, investigation, or public duty;
- returning after a failure;
- sharing an authored quiet or pleasure scene;
- keeping or breaking a specific promise.

The interface shows no number. A companion's changed manner, availability, and voluntary disclosure communicate familiarity.

## Approval and Privacy

Approval remains Guarded, Open, Trusted, or Strained. Familiarity creates opportunity; approval judges conduct.

- A companion may know the player well and disapprove of them.
- The player may refuse a private conversation without penalty.
- A declined conversation is not immediately offered again.
- Disclosure occurs because the present situation gives it a reason, not because a meter filled.
- A companion may decline to answer and never owe a complete autobiography.

## Campaign Tracking

A campaign becomes tracked only when the player explicitly accepts involvement or manually selects it after discovery. Recruitment and ordinary travel do not automatically track personal content.

Stable-colleague and changed-reentry rules come from [[Companion Autonomy and Act Convergence]].

## Party Formats

### Ordinary Content

Introductions and act operations require the owner while retaining the normal party. Other companions may speak only when selected and contextually relevant.

### Duo Finales

Only the three act finales per companion use `duo_quest: true`. Accepting one at its staging point temporarily dismisses the other active companions. The player and owner remain the only full party members until completion or an explicit pause point.

Temporary NPCs remain outside the companion limit. Every route supports every player vocation. The owner provides advantages and characterization, never the sole solution.

A duo finale reserves conversational space without requiring confession, moral summary, or intimacy. Action, failed coordination, silence, and practical recovery may carry the relationship.

### Friendship and Relationships

Friendship, romance, and bond episodes use one-on-one staging but do not use the duo-combat contract unless explicitly required by their activity.

Romantic eligibility is inert until the player selects an explicit interest signal. The signal creates permission for restrained attraction; it does not commit either character. A companion may accept, defer, or decline.

Sworn fellowship follows its own platonic undertaking and never reuses romantic framing.

## Relationship Rewards

A committed romance or sworn bond may grant one non-slot campaign perk, one active duo move, one late safeguard, and distinct summer dialogue at equivalent power. Friendship retains every vocation, moral, and general progression reward.

## Banter Setting

Ambient frequency follows [[Companion Dialogue and Scene Standard]]. Low, Normal, and High never change familiarity, approval, information, or quest availability.

## Companion-Quest Properties

| Property | Use |
|---|---|
| `companion_required` | owning companion required for formal personal content |
| `duo_quest` | true only for fixed-duo act finales |
| `field_experience_gate` | distinct authored prerequisites, never raw time |
| `player_interest_gate` | none until the player signals romance or enters a committed relationship |
| `missed_arc_treatment` | stable-colleague or changed-reentry behavior at seasonal gates |
| `banter_priority` | essential, contextual, optional, private, or silent |
| `external_stakes` | world-facing stakes beyond the companion's personal lesson |
| `grounded_rewrite_status` | progress through the grounded recalibration |

## Navigation

- [[Companion Grounded Writing Standard]]
- [[Companion Constitution]]
- [[Companion Campaign Architecture]]
- [[Companion Autonomy and Act Convergence]]
- [[Companion Dialogue and Scene Standard]]
- [[Companions MOC]]
