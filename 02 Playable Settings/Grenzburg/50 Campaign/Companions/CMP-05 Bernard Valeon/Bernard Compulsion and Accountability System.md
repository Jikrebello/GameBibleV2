---
type: mechanic
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg"]
culture: ["Thalmyric", "Kedravan"]
related_factions: ["Blackjack Corps", "Medori Bank"]
appears_in: ["Grenzburg"]
needs:
  - tune incident spacing, witness sensitivity, and local reputation values during implementation
aliases: ["Bernard Theft System", "Things Not Mine"]
tags: [game-ready]
companion_id: "CMP-05"
system_family: companion
balance_status: qualitative
---
# Bernard Compulsion and Accountability System

This system makes Bernard's kleptomania present in ordinary play without turning him into an uncontrolled inventory penalty, a comic thief, or a supernatural danger. It models urges, completed acts, self-reporting, return, and local consequence through a finite authored pool.

## Design Principles

1. Deprivation explains the condition's shape; it does not transfer ownership.
2. An urge is not identical to a completed theft.
3. Concealment after the act is a separate choice with separate consequences.
4. The player may assist accountability but cannot become Bernard's permanent jailer or cure.
5. Romance changes intimacy, not incidence rules or moral responsibility.
6. No random incident may break a critical quest, remove player property, or create irreversible faction hostility without warning.

## The Finite Incident Pool

Up to eight context incidents may become available across a campaign. They are selected from unique, non-repeatable triggers in:

- Old Market shops and public stalls;
- Mercy Hospital or Paupers' Cloister;
- the Red Stag and other hospitality spaces;
- Longlake Ward refuge kitchens;
- Ledger Quays storehouses;
- the Blackjack Yard supply area;
- outer refugee camps;
- one religious or faction interior where small personal objects remain visible.

Only one incident may be unresolved at a time. Repeated resting, zone transitions, crafting, and job templates cannot farm incidents. An incident already resolved never respawns with a replacement object.

## Eligible Objects

Bernard may attempt to take a small, portable NPC object such as:

- a spoon, cup, button, flint, key, ribbon, knife, food portion, cloth, devotional token, or medicine tool;
- an object with a named owner or accountable communal use;
- an item whose absence can create dialogue, inconvenience, or a recoverable local cost.

He may never systemically take:

- player inventory or currency;
- unique, legendary, or account-unlocked equipment;
- quest-critical evidence, keys, or objectives;
- supplies required to keep a critical-path target alive;
- a companion's relationship object;
- human remains or a soul-route object;
- an item whose loss silently closes content.

## Visible Tell

Every attempt has a readable sequence:

1. Bernard checks the room or shared store without an assigned reason.
2. His left thumb moves across the prayer-rope beads.
3. He adjusts an empty pouch or sleeve.
4. A short companion bark or player-awareness cue opens intervention.

Higher Field Familiarity makes the cue earlier and clearer. Quest one unlocks Bernard's ability to name the urge himself. A failed Insight or observation check shortens the response window but never removes every sensory cue.

## Player Responses

### Give Bernard the first word

The player waits through the cue. Bernard may self-report and step away. This best supports agency after quest one, but before that quest he is more likely to complete the act.

### Interrupt privately

The player names the hand, object, or urge without public accusation. Bernard returns his hand and may ask to leave the space briefly. Repeated interruption without later conversation prevents immediate harm but cannot alone create a resolved arc.

### Call a witness

A shopkeeper, steward, or companion observes the return. This protects both Bernard and the owner where trust is already low, but public use in every minor case can become humiliating and reduce openness.

### Permit the act

The item enters **Things Not Mine**. Approval and later consequence depend on whether the player then encourages return, concealment, sale, or use.

## Things Not Mine

Completed incident objects enter a dedicated companion quest pouch.

- Objects cannot be sold, consumed, equipped, dismantled, gifted, dropped, or moved into the player stash.
- Each records owner, place, season, witness state, and whether Bernard self-reported.
- The next valid hub offers return, confession, compensation, or concealment.
- Throwing the object into inaccessible terrain cannot clear the state.

The pouch is an accountability interface, not a magical container. In fiction Bernard physically carries the object until it is returned or secured by a witness.

## Consequence States

### Returned

The object reaches its owner. Trust depends on timing, damage, and whether Bernard admits taking it. A return does not erase a witnessed theft but usually prevents wider harm.

### Compensated

The owner accepts material replacement while retaining, forgiving, or refusing the personal grievance. Compensation cannot buy forced forgiveness.

### Confessed under loss

If the object is destroyed or inaccessible, Bernard may still name it and accept the local fine, service, or reputation cost.

### Concealed

The object remains hidden or is falsely attributed. Concealment increases Strained risk and can change quest-three or quest-four dialogue. No relationship path makes concealment harmless.

## Progression

### Before Little Things Missing

One tutorial incident can occur. Bernard notices his own tell late, minimizes what happened, and lacks the Things Not Mine routine.

### After Little Things Missing

The pouch, owner records, private interruption, and self-report states unlock. Public or witnessed resolution makes tells clearer; concealment keeps later incidents less legible.

### After Little Hands, Long Road

Bernard can identify hunger-driven behavior without humiliating another person. He becomes more likely to name food or shelter urges before acting.

### After Embers Without Excuse

A resolved or honest compromised path lets him halt one incident per season without player input and report it at the next hub. White Flame does not suppress the condition.

### After The Open Hospice

Resolved Bernard maintains his own witnessed inventory and automatically returns any remaining Things Not Mine before summer. Compromised Bernard still needs external prompting. Broken Bernard may conceal the final incident and trigger departure.

## Law and Reputation

Systemic incidents produce bounded local consequences:

- a modest fine or replacement obligation;
- temporary merchant distrust or service delay;
- named faction or companion dialogue;
- a return task;
- a Strained conflict after serious concealment.

They do not create random imprisonment, permanent faction lockout, or a citywide combat state. A deliberate player choice to weaponize or repeatedly conceal theft may escalate through authored scenes.

## Metaphysical Boundary

Bernard's condition is neither possession, an Idol feed automatically overriding choice, a curse, nor proof of Greed allegiance. White Flame may support courage and truth but does not clinically remove compulsion. Exorcism, relic contact, romance, and punishment cannot produce a cure-state.

## State Outputs

- `bernard_compulsion_disclosed`: denied, partial, full, or public;
- `bernard_accountability_plan`: none, private, witnessed, or coercive;
- `things_not_mine_count`: unresolved finite set;
- `bernard_self_report_state`: unavailable, prompted, active, or reliable;
- `bernard_incident_consequence`: returned, compensated, confessed-under-loss, concealed, or exploited.

## Navigation

- [[Bernard Valeon]]
- [[Bernard Field Familiarity and Relationships]]
- [[Little Things Missing]]
- [[The Froststep Evacuation]]
- [[Virtue and Sin Tendencies]]
- [[Narrative State Register]]
- [[Companions MOC]]
