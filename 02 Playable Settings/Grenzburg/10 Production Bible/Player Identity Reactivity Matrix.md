---
type: mechanic
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg"]
culture: ["Eclessian", "Thalmyric", "Sestaran", "Jirahar", "Ahl-e-Ahd", "Folk", "Ättar", "Tarkhan", "Nsizwa"]
related_factions: []
appears_in: ["Grenzburg"]
needs:
  - allocate individual identity hooks while main, faction, companion, and side content enters implementation
system_family: player
player_system: identity-reactivity
tags: [game-ready]
---
# Player Identity Reactivity Matrix

This note controls how Grenzburg recognizes the character the player created. [[Character Creation and Identity]] controls available choices; this matrix controls their minimum campaign presence.

## Meaningful Recognition

An identity hook counts only when it changes at least one of these:

- access or route;
- risk or opposition;
- price, reward, or resource cost;
- trust, suspicion, or legal treatment;
- information or interpretation;
- traversal or encounter behavior;
- quest method or fail-forward result.

A greeting, cosmetic line, or interchangeable success response does not satisfy the target by itself.

## What Other People Know

The protagonist is human. Culture is learned identity and social formation rather than biological instinct.

- Bank, Blackjack, and ducal intake authorities may know the declared origin recorded on debtor papers.
- Strangers learn origin through disclosure, records, reputation, clothing or practice where credible, or an inference that may be wrong.
- Additional cultural familiarity becomes visible when the player uses it. It is not a second public identity that every NPC automatically knows.
- Background is inferred from demonstrated knowledge or disclosed history.
- Vocation is normally visible through equipment and practice.
- Moral tendency becomes socially legible only through repeated public conduct, testimony, or established reputation.
- No NPC receives private character-sheet knowledge without an authored information path.

## Campaign Coverage Targets

| Identity family | Choices | Required meaningful uses per choice | Total reserved uses |
|---|---:|---:|---:|
| Origin culture | 9 | 10 | 90 |
| Background knowledge | 9 | 8 | 72 |
| Starting vocation | 6 | 8 | 48 |
| Advanced vocation | 2 | 4 after unlock | 8 |

Hooks may share a scene when each option produces a genuinely different interpretation, cost, route, or consequence. A single generic tagged line cannot be counted nine times.

## Origin Allocation

Every origin receives:

1. two favorable opportunities;
2. two material frictions;
3. one main-campaign recognition;
4. one faction recognition;
5. one companion recognition;
6. one systemic-world encounter variant;
7. two additional uses suited to that culture.

| Origin | Target | Opportunity | Friction | Main | Faction | Companion | World | Additional | Allocation status |
|---|---:|---:|---:|---:|---:|---:|---:|---:|---|
| Eclessian | 10 | 2 | 2 | 1 | 1 | 1 | 1 | 2 | reserved |
| Thalmyric | 10 | 2 | 2 | 1 | 1 | 1 | 1 | 2 | reserved |
| Sestaran | 10 | 2 | 2 | 1 | 1 | 1 | 1 | 2 | reserved |
| Jirahar | 10 | 2 | 2 | 1 | 1 | 1 | 1 | 2 | reserved |
| Ahl-e-Ahd | 10 | 2 | 2 | 1 | 1 | 1 | 1 | 2 | reserved |
| Folk | 10 | 2 | 2 | 1 | 1 | 1 | 1 | 2 | reserved |
| Ättar | 10 | 2 | 2 | 1 | 1 | 1 | 1 | 2 | reserved |
| Tarkhan | 10 | 2 | 2 | 1 | 1 | 1 | 1 | 2 | reserved |
| Nsizwa | 10 | 2 | 2 | 1 | 1 | 1 | 1 | 2 | reserved |

Friction may include suspicion, an unfavorable first price, temporary exclusion, an extra proof burden, hostile attention, or a different approach. It must have a credible workaround and may also open content unavailable to a socially favored origin.

## Background Allocation

Each background receives eight uses spread across at least four content families. The full set should include practical knowledge, social recognition, one field method, one information route, and one complication or false assumption the player can correct.

| Background | Target | Allocation status |
|---|---:|---|
| Wilderness | 8 | reserved |
| Underworld | 8 | reserved |
| Military | 8 | reserved |
| Nobility | 8 | reserved |
| Scholarly | 8 | reserved |
| Merchant/Craft | 8 | reserved |
| Peasant/Labour | 8 | reserved |
| Mystic/Religious | 8 | reserved |
| Drifter/Vagabond | 8 | reserved |

## Vocation Allocation

Each starting vocation receives eight uses outside ordinary combat effectiveness. At least three must involve traversal, investigation, social reputation, preparation, creature reading, law, or environmental interaction.

| Vocation | Target | Non-combat minimum | Allocation status |
|---|---:|---:|---|
| Fighter | 8 | 3 | reserved |
| Slayer | 8 | 3 | reserved |
| Hunter | 8 | 3 | reserved |
| Warlock | 8 | 3 | reserved |
| Medium | 8 | 3 | reserved |
| Rune Fist | 8 | 3 | reserved |
| Paladin | 4 after unlock | 2 | reserved |
| Binder | 4 after unlock | 2 | reserved |

## Moral and Social Reactivity

Social skills continue to use visible governing labels and qualitative risk. Virtue and sin tendencies describe repeated conduct rather than deleting ordinary dialogue at random.

Each sustained moral tendency should eventually receive:

- one companion recognition;
- one faction or public-authority recognition;
- one systemic-world or local-story consequence.

These are audit targets rather than a requirement to force every moral pair into every quest.

## Critical-Path Safeguard

Identity may make a critical route harder, dearer, more dangerous, or socially different. It may not make the critical path impossible. Every hard restriction requires at least one workaround through action, evidence, disguise, alternate authority, payment, traversal, or confrontation.

## Production Use

Every implementation-ready major quest records `identity_hooks`. The entry names the identity, what changes, whether the result is an advantage or friction, and which coverage slot it satisfies.

The matrix is complete only when allocated hooks link to real content. Reserved targets do not count as implemented uses.

## Navigation

- [[Grenzburg RPG Experience Constitution]]
- [[Player Character Constitution]]
- [[Character Creation and Identity]]
- [[Social Skills and Knowledge]]
- [[Virtue and Sin Tendencies]]
- [[Quest and Content Architecture]]
- [[Player Systems MOC]]
