---
type: mechanic
status: draft
canon_level: local
visibility: author-only
era: []
region: ["Grenzburg"]
culture: []
related_factions: []
appears_in: ["Grenzburg"]
needs:
  - prototype all six starting vocations before selecting final growth curves
  - assign Stagger Power and Staying Power baselines
  - set social distributions, risk thresholds, Luck behavior, mastery rates, loadout budgets, and encumbrance breakpoints
  - replace or discard the imported numerical tables after combat testing
system_family: player
player_system: provisional-balance
balance_status: provisional
tags: []
---
# Provisional Player Balance Appendix

## Status

Nothing in this note is final canon. It preserves useful numerical hypotheses from the archived [[Game Lore Bible]] and records the questions prototypes must answer. Narrative authorities may link here without inheriting these values.

The meanings of statistics are fixed in [[Player Statistics and Resolution]]. Only their curves, coefficients, caps, and budgets remain here.

## Imported Growth Hypotheses

The source supplied early and late growth for five vocations. `Defence` below maps provisionally to Physical Defence. It supplied no separate Stagger Power or Staying Power.

### Starting Values

| Vocation | Health | Stamina | Strength | Physical Defence | Magick | Magick Defence |
|---|---:|---:|---:|---:|---:|---:|
| [[Fighter]] | 570 | 430 | 90 | 75 | 60 | 75 |
| [[Slayer]] | 550 | 450 | 80 | 80 | 60 | 60 |
| [[Hunter]] | 430 | 570 | 85 | 85 | 65 | 65 |
| [[Warlock]] | 450 | 550 | 60 | 60 | 80 | 90 |
| [[Medium]] | 430 | 570 | 60 | 60 | 90 | 80 |

### Growth per Level, Levels 2-10

| Vocation | Health | Stamina | Strength | Physical Defence | Magick | Magick Defence |
|---|---:|---:|---:|---:|---:|---:|
| Fighter | +40 | +10 | +5 | +4 | +2 | +4 |
| Slayer | +25 | +25 | +4 | +4 | +4 | +3 |
| Hunter | +15 | +35 | +5 | +3 | +3 | +4 |
| Warlock | +25 | +25 | +2 | +2 | +5 | +6 |
| Medium | +15 | +35 | +2 | +3 | +6 | +4 |

### Growth per Level, Levels 11-100

| Vocation | Health | Stamina | Strength | Physical Defence | Magick | Magick Defence |
|---|---:|---:|---:|---:|---:|---:|
| Fighter | +15 | +10 | +3 | +3 | +1 | +3 |
| Slayer | +13 | +12 | +4 | +3 | +2 | +1 |
| Hunter | +10 | +15 | +4 | +2 | +2 | +2 |
| Warlock | +12 | +13 | +1 | +1 | +3 | +5 |
| Medium | +10 | +15 | +1 | +2 | +5 | +3 |

These tables are not implementation targets. They predate Stagger Power, Staying Power, Rune Fist, Paladin, Binder, the field-locked vocation ruling, and the finalized custom-growth rule.

## Qualitative Growth Intent

| Vocation | Strong growth | Supporting growth | Intended weakness |
|---|---|---|---|
| Fighter | Health, Strength, Physical Defence, Staying Power | Stagger Power, Magick Defence | limited Stamina and Magick emphasis |
| Slayer | Stamina, Strength, Stagger Power | Health, mobile survival | poor stationary defence |
| Hunter | Stamina, Strength, precision-facing Stagger Power | balanced defences | low close-pressure durability |
| Warlock | Magick, Magick Defence, Stamina | elemental control | low physical stability |
| Medium | Magick, Stamina, roster-facing resilience | Magick Defence | vulnerable when isolated from fields and shades |
| Rune Fist | Stagger Power, Staying Power, both defences | Stamina | modest raw ranged output |
| Paladin | Health, Strength, Stagger Power, Magick Defence | Staying Power | slow commitments and limited sustained mobility |
| Binder | Magick, Magick Defence, Stamina | Intelligence-facing utility | low direct physical pressure |
| Bard | Stamina, Magick, Magick Defence | Intelligence-facing support and recovery | low direct damage and severe isolation risk |

## Prototype Questions

### Character Growth

- Should character level retain a hard cap of 100?
- How much early acceleration is needed before a vocation feels complete?
- Can a player change vocation frequently without permanently weakening the character?
- How visible should future growth be at a vocation-change point?
- Does the rounded-down custom blend create a meaningful cost without becoming a trap?

### Mastery

- What share of earned experience advances vocation mastery?
- How long should one starter take to master on the critical path?
- Which rank gates require trainers rather than mastery alone?
- How much account-wide progression is appropriate before a new game loses its opening arc?

### Combat Resources

- Health versus recoverable Health proportions.
- Stamina costs for sprinting, climbing, guarding, shooting, scripts, and large-monster climbing.
- Arcane Burn gain, passive decay, active venting, and overdraw thresholds.
- Medium roster capacity by imprint scale.
- Fighter guard and Rune Fist catch windows.
- stagger and staying interactions across humans, creatures, and large monsters.

### Loadouts

The archived source proposed quick consumables, two active-skill loadouts, Hunter arrowcraft access, and equipment active skills. These remain interface hypotheses. Prototypes must determine:

- active-skill count;
- whether loadout switching is allowed during combat;
- consumable quick-slot count;
- equipment-skill presentation;
- arrow recipe and carrying limits;
- companion-command input budget;
- accessibility alternatives for chorded inputs.

### Social Resolution

- distributions behind Favored, Even, Risky, and Dire;
- primary skill and knowledge weighting;
- circumstance modifiers;
- Luck's second-stage adjustment;
- critical success and softened-failure frequency;
- how much information is shown without exposing exact rolls.

## Decision Rule

A number leaves this appendix only after it has been tested against at least:

1. one ordinary human encounter;
2. one mixed group;
3. one large creature;
4. one traversal sequence;
5. one resource-scarce expedition;
6. one vocation-switching character;
7. one accessibility review where relevant.

Final values move into an implementation specification, not into culture or story notes.

## Navigation

- [[Player Statistics and Resolution]]
- [[Health Recovery Afflictions and Encumbrance]]
- [[Equipment and Skill Loadouts]]
- [[Vocation Progression and Mastery]]
- [[Custom Vocation Workshop]]
- [[Player Systems MOC]]
