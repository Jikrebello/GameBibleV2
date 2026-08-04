---
type: mechanic
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg"]
culture: ["Ättar", "Grey-Wolf"]
related_factions: ["Blackjack Corps"]
appears_in: ["Grenzburg"]
needs:
  - set exact perk and duo-move tuning during combat prototyping
aliases: ["Ylva Approval and Relationship Path"]
tags: [game-ready]
companion_id: "CMP-03"
relationship_theme: "the right to be relieved"
relationship_perks: ["Hearthward", "Second Watch"]
architecture_status: migrated
grounded_rewrite_status: approved
---
# Ylva Field Familiarity and Relationships

This note controls Ylva's approval, authored familiarity, relationship commitment, departure, and permanent rewards. [[Ylva Companion Campaign]] controls formal-piece release, preparation, autonomy, and changed re-entry. Shared party and duo rules come from [[Companion Field Familiarity and Duo Quest Standard]].

## Recruitment and Home Base

Ylva joins during [[The Southbound Muster]] after [[The Fourth Marker]]. She may be added or dismissed at valid hubs without approval loss.

At the [[Blackjack Yard]] she works at the route board, fletching bench, or weather station. She refuses a private room while spare bunks remain occupied, then quietly falls asleep over route work. At exterior hubs she chooses the position with the clearest weather and escape view.

## What She Notices

Ylva responds positively to:

- publishing danger and route information;
- abandoning property to save people;
- distributing watch, credit, and liability;
- accepting another person's informed choice;
- pausing before exhaustion becomes incapacity;
- protecting the slowest traveler;
- creating redundancies rather than a single heroic solution;
- respecting local custodians and route holders.

She responds negatively to:

- concealed injury;
- needless last stands;
- unbriefed civilian risk;
- false signals or stolen refuge stores;
- treating one competent person as unlimited labour;
- keeping knowledge to preserve personal importance;
- refusing relief for pride;
- equating love with silent self-erasure.

## Campaign Release

### Act I

[[A Signal Shared]] follows recruitment. [[The Rearguard Road]] becomes personally joinable with two Act I preparation assets. Commitment to [[The Last Convoy]] resolves it autonomously if the player does not join.

[[No Quarry Today]] opens after the Act I finale or its changed winter aftermath, provided Ylva is not Strained. It is a complete friendship episode for every player.

### Act II

[[Signals Over Lantern Ward]] opens during the siege. [[What the Ice Takes]] becomes joinable with two Act II assets. Commitment to [[Ghor at the Gate]] resolves it autonomously.

The transition docket states that missing the finale closes Ylva's time-specific romance and sworn-bond opportunity. Mechanical fieldcraft rewards move to credible changed re-entry rather than disappearing solely because the player pursued other work.

### Act III and Summer

[[Routes for the Living]] opens after [[The Open Thaw]]. [[The Last Marker]] becomes joinable with two Act III assets and remains open until commitment to [[The Deep Muster Main Quest|The Deep Muster]].

A committed romance unlocks [[A Hearth Chosen]]. A committed sworn bond unlocks [[The Sister Watch]]. They are separate and mutually exclusive. [[The Road She Chooses]] reflects Ylva's settled result in summer.

Only [[The Rearguard Road]], [[What the Ice Takes]], and [[The Last Marker]] are fixed player-plus-Ylva duo quests. Operations retain the normal party. Friendship and relationship episodes are private one-on-one activities.

## Approval and Direction

Approval is shown as **Guarded**, **Open**, **Trusted**, or **Strained**.

`ylva_direction` records `shared`, `managed`, or `self-spent`. Approval and direction are related but distinct. A player may care deeply for Ylva while encouraging harmful self-sacrifice, or disagree with her while supporting an honest shared route.

Neither repeatable jobs nor idle time can farm familiarity. Authored route decisions, rescues, exploration discoveries, camp scenes, faction work, and campaign crises count.

## Conflict and Departure

A major conflict begins if the player:

- orders Ylva to conceal an injury;
- knowingly sacrifices civilians to preserve cargo;
- suppresses a relief signal for advantage;
- signs her into sole liability after she objects;
- repeatedly praises needless self-destruction as her only value;
- steals refuge stores or falsifies a route marker;
- prevents informed adults from choosing a credible rescue risk.

Ylva names the conflict at the next valid hub. Repair requires honest reporting, restored stores or signals, shared liability, or acknowledgment of the affected person's agency. Refusing repair makes her Strained. Reaffirming the wrong during [[The Last Marker]] permits the broken/departed outcome.

## Friendship

[[No Quarry Today]] is available to every player who remains on speaking terms with Ylva. It contains tracking, target shooting, carving, cooking, and friendly competition without a villain or emergency.

Friendship can reach Ylva's strongest moral resolution and unlock every recipe, the Winter-Track Fieldcraft augment, and all non-relationship progression.

## Commitment

Commitment requires:

- **Trusted** approval;
- personal completion of [[What the Ice Takes]];
- two prior familiarity conversations;
- an explicit authored player interest signal;
- no unresolved major conflict;
- the relevant global relationship slot remains available.

Ylva is heterosexual. A male player may pursue romance. A female player may pursue a sworn bond. Declining either preserves friendship and all core progression.

Before the interest signal, Ylva does not flirt, display jealousy, interpret practical care as courtship, or receive romance-coded companion banter.

## Romance

[[A Hearth Chosen]] is a male-player romantic episode. Ylva and the player prepare a private winter shelter, divide the work, exchange care without accounts, explicitly choose a shared hearth, and commit romantically before a fade to black.

### Covered Return

Commitment unlocks this Ylva-only duo move. Ylva lays smoke and suppressive fire across a retreat lane. The player clears one ordinary movement impairment while withdrawing through it and receives a short protected reposition.

It does not ignore immobilizing boss mechanics, cross impassable terrain, or make the player invulnerable.

### Hearthward

After a resolved or compromised [[The Last Marker]], the committed romance grants **Hearthward**, a permanent non-slot campaign perk.

Receiving timely allied healing, protection, or recovery while inside an ally-created safe position grants bounded recovery and brief Staying Power. The trigger rewards accepting care; it does not require Ylva to be present and cannot repeatedly refresh from the same effect.

### Homeward Route

Completing [[A Hearth Chosen]] supplies `ylva_homeward_route_practiced`. It prevents one extraction or exhaustion failure in [[The Last Marker]]. It never determines Ylva's moral decision.

## Sworn Bond

[[The Sister Watch]] is a female-player platonic episode. Ylva and the player alternate lead, rest, and watch at East Watch Cairn, create a mutual relief signal, and explicitly become sworn sisters.

The episode uses no romance, marriage imagery, physical courtship, or fade to black.

### Watch Relieved

Commitment unlocks this Ylva-only duo move. Ylva assumes overwatch and interrupts one ordinary threat while the player rescues, carries, revives, or operates a mechanism.

It does not stop prepared boss attacks or protect an action after the player leaves the marked lane.

### Second Watch

After a resolved or compromised [[The Last Marker]], the sworn bond grants **Second Watch**, a permanent non-slot campaign perk.

When a companion warns of a flank, ambush, or endangered ally, the player receives improved threat visibility and a longer response window. It does not reveal undiscovered enemies without a credible warning source.

### Sister Watch

Completing [[The Sister Watch]] supplies `ylva_sister_watch_practiced`. It prevents the same single extraction or exhaustion failure as Homeward Route. The bonuses cannot stack.

## Persistence

Relationship perks use no ordinary augment slot. Recipe access is identical on friendship, romance, and bond paths.

If Ylva dies through the player's explicit late sacrifice, a previously earned permanent perk remains as learned experience. Duo moves require Ylva in the active party. Neither relationship cures her, guarantees agreement, or prevents a warned departure.

No relationship outcome becomes future-setting canon.

## Navigation

- [[Ylva Winter-Track]]
- [[Ylva Companion Campaign]]
- [[Ylva Rescue Hunter Package]]
- [[No Quarry Today]]
- [[A Hearth Chosen]]
- [[The Sister Watch]]
- [[The Last Marker]]
- [[Companion Field Familiarity and Duo Quest Standard]]
- [[Narrative State Register]]
- [[Companions MOC]]
