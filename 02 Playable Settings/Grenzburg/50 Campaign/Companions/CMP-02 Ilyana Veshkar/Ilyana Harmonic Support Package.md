---
type: mechanic
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Sermora"]
culture: ["Sermoran"]
related_factions: ["Blackjack Corps", "The Salt-Reed Company"]
appears_in: ["Grenzburg"]
needs:
  - tune companion AI priorities, refrain radius, Resonance costs, and final skill names
aliases: ["Ilyana Combat Package"]
tags: [game-ready]
companion_id: "CMP-02"
architecture_status: migrated
---
# Ilyana Harmonic Support Package

This note controls Ilyana's companion combat behavior. [[Bard]] controls the player vocation. Ilyana uses a Sermoran Field Bard loadout and does not create a separate vocation.

## Combat Identity

Ilyana is a back-line support specialist who:

1. reads the party's immediate weakness;
2. establishes a mobile refrain;
3. designates a Lead;
4. builds Resonance through coordinated play;
5. spends it on the right enchantment, counter, or rescue window;
6. relocates before enemies can isolate her.

She does not carry a dagger, sword, wand, or hidden melee fallback.

## Native Equipment

- keyed double flute of brass and darkwood;
- replaceable reeds and tuning keys;
- breath salts and instrument wraps;
- light field coat and layered cloth armour;
- no shield and no native melee weapon.

## Signature Families

### Harbor Fog

Creates a moving water-air field around Ilyana. Variants provide concealment, projectile disruption, cooling, elemental resistance, or brief route shelter. Allies must remain near her or carry a Lead line.

### Common Breath

Improves Stamina efficiency, action recovery, and coordinated movement. It does not make exhaustion impossible.

### Mending Mist

Restores recoverable Health only. It cannot touch lasting Health loss, revive, cure disease, or imitate White Flame.

### Four-Cadence Gift

Spends Resonance to enchant the active party's weapons with one bounded relation:

- fire;
- ice;
- lightning;
- corrosive mineral suspension.

The cadence follows material resistances and cannot turn every weapon into an unrestricted spell.

### Countervoice

Interrupts a valid hostile spell, roar, signal, or conducted working. It is strongest after Ilyana has heard or observed the cadence and cannot silence every boss action.

### Unwelcome Measure

Applies fascination, fear, sleep, emotional pressure, or one brief simple command to a hearing living target. Use follows [[Harmonic Shellcraft]] and is never valid consent.

### Reed-Split Step

A short pressure burst and fog step that breaks aim, creates distance, or evades a closing enemy.

### Closing Crescendo

Consumes accumulated Resonance to intensify active support for a short decisive interval. A bad close damages breath and instrument rather than granting free power.

## Lead Logic

At recruitment, Ilyana designates one Lead. Progression through [[The Free Refrain]] permits two.

Companion AI prioritizes:

1. the ally currently carrying the decisive objective;
2. a player climbing or controlling a large creature;
3. a rescuer, reviver, or exposed front-liner;
4. an ally exploiting the chosen elemental weakness.

The player may override the Lead through companion commands. Ilyana never removes control of player movement.

## Progression

| Stage | Unlock |
|---|---|
| [[Five Cases at Customs]] | improved weakness reading and property-sensitive field observations |
| [[No Song by Command]] | stronger countervoice and a voluntary-support AI rule |
| [[The Free Refrain]] | second Lead, two compatible refrains, and relationship duo move |
| [[The Last Common Measure]] | master counter-cadence and Sermoran Field Bard custom blueprint |

## Companion AI Guardrails

- Ilyana does not use lethal compulsion against surrendering or non-hostile targets without explicit player command.
- She never compels another companion.
- Mending Mist does not fire when no recoverable Health is missing.
- She changes elemental cadence when repeated attacks prove ineffective.
- She seeks cover and uses Reed-Split Step rather than drawing a nonexistent melee weapon.
- She can support every vocation but is not required for any critical route.

## Custom Vocation Parts

Personal completion of [[The Free Refrain]] unlocks the Bard vocation. [[The Last Common Measure]] grants:

- keyed double flute;
- Lead line;
- one selected refrain family;
- pressure-note movement;
- Resonance augments;
- the Sermoran Field Bard blueprint.

## Navigation

- [[Ilyana Veshkar]]
- [[Ilyana Companion Campaign]]
- [[Bard]]
- [[Harmonic Shellcraft]]
- [[Vocation Originalization Register]]

