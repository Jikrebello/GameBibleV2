---
type: mechanic
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg"]
culture: ["Thalmyric", "Kedravan"]
related_factions: ["Blackjack Corps", "Order of the Long Watch"]
appears_in: ["Grenzburg"]
needs:
  - set exact perk and duo-move tuning during combat prototyping
aliases: ["Bernard Approval and Relationship Path"]
tags: [game-ready]
companion_id: "CMP-05"
relationship_theme: "receiving without taking"
relationship_perks: ["Kept in the Light", "Last Watch"]
architecture_status: migrated
---
# Bernard Field Familiarity and Relationships

This note controls Bernard's approval, authored familiarity, relationship commitment, departure, and permanent rewards. [[Bernard Companion Campaign]] controls formal-piece release, preparation, autonomous progression, and changed re-entry. Shared party and duo rules come from [[Companion Field Familiarity and Duo Quest Standard]].

## Recruitment and Home Base

Bernard becomes available during [[The Black Road Main Quest|The Black Road]] and is formally added to party management after [[Warrant at the Gate]]. He may be recruited or dismissed at valid hubs without approval loss.

At the [[Blackjack Yard]] he works near the kitchen, casualty bench, or communal equipment racks. He inventories issued kit in the open, keeps no private chest, and sleeps with his prayer rope around his left hand. Settlement hubs place him near hospitals, kitchens, shelters, road shrines, and children who have decided his height makes him public furniture.

## What He Notices

Bernard responds positively to:

- feeding, clothing, or sheltering people without turning need into humiliation;
- returning property and admitting responsibility before proof makes denial impossible;
- maintaining declared emergency reserves with visible counts and named custodians;
- protecting children, patients, prisoners, and frightened combatants;
- accepting surrender while preserving public safety;
- respecting sincere religious practice and equally sincere refusal;
- asking for help before exhaustion becomes martyrdom;
- bearing a real cost to repair an avoidable harm.

He responds negatively to:

- theft from poor households, hospitals, graves, or shared stores;
- secret caches during shortage;
- coerced prayer, false absolution, or visible Flame used as jurisdiction;
- leaving vulnerable people behind to preserve prestige, treasure, or appearances;
- treating compulsion as comedy, possession, or proof that no choice remains;
- expecting a victim to forgive because the offender now feels sincere;
- rules that preserve an institution by quietly spending a person.

## Campaign Release and Readiness

### Introduction

[[Little Things Missing]] unlocks after one distinct meaningful outing involving authored care, a consequential property decision, or dangerous field success with Bernard active. Idling, repeated jobs, and recycled encounters do not count. Approval need not already be Open; the case is how the player first learns what Bernard has done.

### Act I

[[The Wagon in the Reeds]] follows the introduction as a normal-party operation. [[Little Hands, Long Road]] becomes joinable when two of its five Act I assets are held. Commitment to [[The Last Convoy]] resolves the finale autonomously if the player does not join it. [[A Blade Freely Given]] remains a complete friendship episode for every player who continues on speaking terms with Bernard.

### Act II

[[The Long Winter Table]] opens during the winter siege. [[Embers Without Excuse]] becomes joinable when two of its five Act II assets are held. The quest itself is not relationship-gated, but commitment requires **Trusted** approval and personal completion.

Commitment to [[Ghor at the Gate]] resolves the chapter autonomously. The transition docket states plainly that missing the finale permanently forfeits the player [[Paladin]] unlock, romance, sworn bond, and the finale's player rewards for that playthrough. **Embers After Snow** permits changed restitution but cannot recreate those rewards.

### Act III and Summer

[[Beds Before Banners]] prepares West Refuge Hall. [[The Open Hospice]] becomes joinable when two of its five Act III assets are held and remains open until commitment to [[The Deep Muster Main Quest|The Deep Muster]]. No relationship is required: a trusted friend may reach Bernard's strongest moral resolution and every non-romantic destination.

A committed romance unlocks [[Enough for Two]]. A committed sworn bond unlocks [[Watch Until Morning]]. The two episodes are separate authored experiences and mutually exclusive. [[The First Open Table]] reflects the settled or autonomous result in summer and never reopens the hospice judgement.

Only [[Little Hands, Long Road]], [[Embers Without Excuse]], and [[The Open Hospice]] are fixed player-plus-Bernard duo quests. Operations retain the normal field party; friendship and relationship episodes are private one-on-one activities.

## Compulsion Interaction

[[Bernard Compulsion and Accountability System]] supplies finite field incidents. Approval does not rise merely because the player interrupts every attempt. Bernard values help that preserves agency:

- naming the tell without public humiliation;
- giving him the first opportunity to self-report;
- returning an object to its actual owner rather than paying an abstract fine and keeping it;
- distinguishing transparent reserve practice from indiscriminate suspicion;
- refusing to conceal a completed theft after Bernard asks for concealment.

The player may choose stricter supervision, but permanent surveillance cannot produce Bernard's resolved state. He must eventually name and act upon the urge himself.

## Direction and Approval

`bernard_direction` is `truthful`, `uncertain`, or `withholding` and records named conduct across the campaign. It is not a hidden approval score:

- **truthful:** he reports urges, declares reserves, accepts gifts openly, and repairs harm;
- **uncertain:** he provides real service but relies on external control or admits concealment only after pressure;
- **withholding:** he hides stores, shifts blame, or uses institutional or sacred authority as protection from consequence.

Affection cannot buy a truthful outcome. Equally, a stern but proportionate demand for restitution does not by itself make Bernard Strained.

## Conflict and Departure

A major conflict begins if the player:

- knowingly hides Bernard's theft from a patient, refugee, child, or bereaved household after warning;
- orders him to steal from the dead or from shared medical stores;
- uses White-Flame kindling as proof that his prior conduct no longer matters;
- turns his condition into a recurring joke after he asks them to stop;
- pressures [[Petra Ilev]] to forgive him;
- encourages a secret cache during [[The Open Hospice]].

Bernard names the conflict at the next valid hub. Repair requires return, compensation, protected testimony, reopening the inventory, or repudiating the sacred claim. Refusing repair marks him **Strained**. Reaffirming the wrong during [[The Open Hospice]] creates the broken/departed outcome.

## Relationship Rhythm

Bernard is heterosexual. A female player may pursue romance; a male player may pursue a sworn bond. Friendship remains a complete path for either.

Two pre-commitment scenes are required:

1. **Enough for Tonight:** after [[Little Things Missing]], Bernard admits that a full pantry can still feel one meal from empty. The player may listen, establish a boundary, or close romantic or bond interest without closing friendship.
2. **The Child's Portion:** at the end of [[A Blade Freely Given]], Bernard discusses Mika's hidden food, accepting the player's unconditional gift, and the difference between protecting someone from shame and hiding what happened. Romance interest emphasizes being cared for without becoming dependent; bond interest emphasizes truthful witness.

## Commitment After Embers Without Excuse

Commitment requires:

- approval **Trusted**;
- both earlier scenes completed without a closed refusal;
- no active major conflict;
- the relevant global relationship slot remains available.
- the player personally completed [[Embers Without Excuse]] before its Act II deadline.

### Romance

A female player may enter romance. Bernard asks whether care can be received without becoming debt and whether the relationship can proceed without making either person the other's custodian. The commitment opens [[Enough for Two]], where the freely given prayer-rope bead and romantic intimacy receive their own authored scene.

The commitment promises companionship without ownership, honest naming of urges without policing, and a shared road that either person may still choose.

### Sworn Bond

A male player may enter a sworn bond. Bernard asks whether the two men should become more than ordinary friends through mutual truth, return, and service without either claiming authority over the other. The commitment opens [[Watch Until Morning]], where they repair Cairnside Shelter and explicitly become sworn brothers through a Long Watch lay custom. The bond does not imitate romance, marriage, or ordination.

Declining either path preserves friendship, quest access, Paladin progression, and the strongest non-relationship endings.

## Romance Reward

### Kept in the Light

After [[The Open Hospice]], a resolved or compromised committed romance grants **Kept in the Light**, a permanent non-slot campaign perk.

Once per major encounter, receiving an ally-granted heal, cleanse, revive, or protective effect while frightened or critically wounded clears one fear effect and grants brief Staying Power. If no fear effect is present, the aid still grants the Staying Power interval. Self-used consumables do not trigger it.

The effect represents learned courage in receiving help. It is not an automatic White-Flame miracle and functions without Bernard present.

### Shared Ember

Commitment after [[Embers Without Excuse]] unlocks this Bernard-only duo move. Bernard braces his greatsword, names the player, and steadies both characters through the prayer rope. It clears ordinary fear, creates a brief anti-stagger interval, and lets the player choose retreat, rescue, or renewed attack.

It cannot erase boss mechanics, restore broken moral coherence, or substitute for medicine.

### Shared Ember: Warmth Returned

[[Enough for Two]] upgrades the move. When either partner receives timely allied healing or protection, the move shares bounded recovery and Stamina between them while preserving its fear-clear and anti-stagger interval. It remains a mutual survival tool rather than a cure or automatic miracle.

## Sworn-Bond Reward

### Last Watch

After [[The Open Hospice]], a resolved or compromised sworn bond grants **Last Watch**, a permanent non-slot campaign perk.

Once per major encounter, the first ordinary hit received while the player performs a revive, rescue, carry, or protected interaction does not interrupt the action. Fear resistance persists until the interaction ends. The perk does not prevent damage or defeat.

### No One Alone

Commitment after [[Embers Without Excuse]] unlocks this Bernard-only duo move. Bernard crosses to a downed, grappled, or endangered target, interposes with the greatsword, and opens a short safe rescue window. Enemy area attacks, prepared counters, and boss phases may still require movement or interruption.

### No One Alone: Two Bearers

[[Watch Until Morning]] upgrades the move. A rescue, carry, or revival survives one ordinary interruption and grants both characters brief Staying Power when the protected action completes. Damage, boss mechanics, and total defeat remain possible.

## Future Paths

Moral outcome is determined before destination.

### Long Watch Restored

On any resolved or compromised relationship path, Bernard may accept reinstatement under the order's ordinary poverty, obedience, and inventory safeguards. A resolved version enters freely and keeps responsibility personal; a compromised version relies on command to make every difficult choice for him. Romance or bond changes the summer scene, not the order's authority to hear his petition.

### Open Lamp Hospice

On any resolved or compromised relationship path, Bernard may remain in Grenzburg and establish the [[Open Lamp Hospice]]. A resolved hospice maintains transparent stores and mixed service; a compromised hospice survives under narrow institutional custody or incomplete disclosure.

### The Road Beside You

A committed romance may select a travelling hospitaller future. Bernard remains with the player through summer play and later takes road service rather than accepting a distant fixed post. If the Open Lamp exists, he entrusts daily work to its named staff instead of abandoning patients without succession.

## Persistence

Relationship perks occupy neither vocation augment nor equipment slots. Moral outcome and physical fate are recorded separately: a resolved or compromised path still grants its learned permanent perk if Bernard dies through the player's chosen sacrifice. Duo moves, field interventions, and Last Ember conversations require him to be present.

Neither relationship cures his compulsion, guarantees agreement, prevents a warned departure, or becomes future-setting canon.

## Navigation

- [[Bernard Valeon]]
- [[Bernard Companion Campaign]]
- [[Bernard Compulsion and Accountability System]]
- [[Bernard Long Watch Greatsword Package]]
- [[Bernard Banter and Reactivity]]
- [[A Blade Freely Given]]
- [[Enough for Two]]
- [[Watch Until Morning]]
- [[Companion Field Familiarity and Duo Quest Standard]]
- [[Narrative State Register]]
- [[Companions MOC]]
