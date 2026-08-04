---
type: mechanic
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg"]
culture: ["Eclessian", "Korrheim"]
related_factions: ["Blackjack Corps", "Low Lanterns"]
appears_in: ["Grenzburg"]
needs:
  - set exact perk and duo-move tuning during combat prototyping
aliases: ["Dismas Approval and Relationship Path"]
tags: [game-ready]
companion_id: "CMP-06"
relationship_theme: "a road chosen twice"
relationship_perks: ["No Escape Route", "No Blind Turn"]
architecture_status: migrated
grounded_rewrite_status: approved
dialogue_status: approved
player_interest_gate: player-signaled
---
# Dismas Field Familiarity and Relationships

Controls Dismas's approval, Field Familiarity, relationship scenes, commitment, conflict, departure, and rewards. [[Dismas Companion Campaign]] controls quest release, preparation, deadlines, autonomy, and re-entry.

## Recruitment and Home Base

Dismas is recruited during [[The Black Road Main Quest|The Black Road]]. Koss presents him as a route specialist and mentions the purchased service in front of him, which Dismas answers with a joke and remembers for a season.

At the Yard he takes the bunk nearest the gate, improves the worst exit routes and denies it, and keeps a deck with one queen missing. He reacts badly to being ordered into the party "for his own good" and warmly to being asked because his particular judgement is wanted.

## Approval

Displayed as `Guarded`, `Open`, `Trusted`, or `Strained`.

He responds positively to:

- refusing a predatory authority in a way that leaves the beneficiaries safe afterward;
- naming who carries the cost of a plan before it starts;
- keeping an appointment nobody could enforce;
- lawful process used against power rather than against the poor;
- letting a client, family, or guide make their own informed choice;
- humour at the expense of rank, ceremony, or a uniform worn as personality.

He responds negatively to:

- reprisal risk waved away as somebody else's problem;
- theft or extortion from people with nothing;
- collective punishment, and any officer who treats it as arithmetic;
- being thanked publicly, or recorded doing something decent;
- romantic martyrdom ordered by people with horses;
- an escape sold to someone with no plan for the second night.

**Approval is not a proxy for his direction.** A player may be Trusted and still be encouraging flight.

## Field Familiarity

Familiarity records authored shared experience only. Idling, jobs, and repeated encounters cannot farm it.

### First Outing

Any of these after recruitment writes `dismas_first_outing_complete`:

- a checkpoint, seizure, or passage decision with a named beneficiary;
- an escape, extraction, or pursuit at any scale;
- a scene where an institution's rule visibly costs somebody who could not argue.

At the next hub, he proposes [[The Decorative Fence]].

### Continuing Familiarity

Distinct events only: one of his ten embedded opportunities, a new main or faction quest, a first discovery, an authored camp scene, or a credible report of a public choice.

## Relationship Rhythm

Romantic interest appears only after the player selects an explicit authored signal. Before that choice, Dismas does not flirt, sexualize danger, imply jealousy, or treat private routes as courtship. Trust and attraction remain separate states.

- **After [[The Decorative Fence]]:** the roof-and-breakfast beat. A male player may express deliberate trust. A female player may select the explicit attraction signal or keep it ordinary. Writes `dismas_roof_scene`; attraction additionally writes `dismas_romance_interest_signaled`.
- **After [[No Railing]]:** the second pre-commitment scene, on the platform, over cards. He tells a story with himself removed from the brave part, and the player may notice out loud.

**Commitment is considered only after personal completion of [[The Name on the Charge]]** — the filing, not the outcome. Requirements: Trusted approval; both interest scenes without a closed refusal; no active major conflict; the relevant global slot open.

- A female player with `dismas_romance_interest_signaled` may enter romance: [[The Return Leg]], a route chosen twice.
- A male player may form the sworn bond: [[The Missing Queen]], a route cut for no one's enemy.

Declining preserves friendship and the complete campaign. If the Act II finale resolves autonomously, `dismas_relationship_closed` becomes true and **The Unfiled Charge** cannot reopen it.

## Rewards

### Romance — Second Journey → No Escape Route

Commitment unlocks **Second Journey**, a duo move: after either partner disengages, the other's next reposition is protected. [[The Return Leg]] upgrades it and supplies `dismas_return_leg_practiced`.

A resolved or compromised finale grants **No Escape Route**, a permanent non-slot perk: when the player is the last to withdraw from an encounter, the withdrawal cannot be interrupted. The name is a joke he makes once and never explains.

### Bond — Called Back → No Blind Turn

Commitment unlocks **Called Back**, a duo move: either sworn brother may signal the other out of an overcommitted position once per encounter. [[The Missing Queen]] upgrades it and supplies `dismas_missing_queen_given`.

A resolved or compromised finale grants **No Blind Turn**, a permanent non-slot perk: the first unseen approach in an encounter is flagged before contact.

Both safeguards are equal, exclusive, and never stack. Friendship reaches the resolved outcome and every non-relationship reward.

## Conflict and Repair

A major conflict begins if the player knowingly:

- sells, weaponizes, or trades a route against the people using it;
- leaves a client or family to a reprisal after being shown the risk;
- lets Girel Lask or a comparable dependent take a charge that belongs to somebody else;
- forces Dismas's confession into public view for leverage;
- accepts the cofounder's offer to carry the rockfall.

He names it at the next hub — sideways, then plainly — and asks for a concrete repair: a return, a surety, a testimony, an appointment kept. Refusal marks the line Strained. Reaffirming it during [[The Road That Answers]] produces the broken or departed result.

## Outside the Loop

Nothing in this system reaches [[Sella Etten]]. Her response is fixed by the filing and by nothing else; she is approval-neutral, unpersuadable, and unreachable. Do not add a contact path.

## Persistence

Relationship perks occupy no vocation or equipment slot and survive his departure or an explicit late sacrifice. Duo moves require him in the active party. Perks are campaign-specific rather than account-wide.

## Chatter Discipline

At Normal frequency, Dismas contributes no more than two ambient exchanges during roughly twenty minutes of uninterrupted travel. He does not nickname every official, answer every danger with a joke, or turn every silence into charm. High frequency draws from additional route, weather, work, and company material. Deaths, funerals, confessions, stealth, major failures, and solemn discoveries impose the global silence lock.

## Navigation

- [[Dismas Raben]] · [[Dismas Companion Campaign]] · [[Dismas Quarry-Wise Package]]
- [[The Decorative Fence]] · [[No Railing]] · [[The Name on the Charge]]
- [[The Return Leg]] · [[The Missing Queen]] · [[The Road That Answers]]
- [[Companion Field Familiarity and Duo Quest Standard]] · [[Companions MOC]]
