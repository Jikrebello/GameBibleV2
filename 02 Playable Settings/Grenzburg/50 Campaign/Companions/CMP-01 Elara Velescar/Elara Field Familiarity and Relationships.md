---
type: mechanic
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg"]
culture: ["Eclessian", "Virelian"]
related_factions: ["Blackjack Corps"]
appears_in: ["Grenzburg"]
needs:
  - set exact perk and duo-move tuning during combat prototyping
aliases: ["Elara Approval and Relationship Path"]
tags: [game-ready]
companion_id: "CMP-01"
relationship_theme: "adventure between equals"
relationship_perks: ["Equal Footing", "Witness at My Back"]
architecture_status: migrated
---
# Elara Field Familiarity and Relationships

This note controls Elara's approval, Field Familiarity, relationship scenes, commitment, conflict, departure, and player-facing relationship rewards. [[Elara Companion Campaign]] controls formal quest release, preparation, deadlines, autonomous results, and changed re-entry.

## Recruitment and Home Base

Elara becomes available at [[Blackjack Yard]] during Early Autumn after [[Warrant at the Gate]]. Koss presents her as a useful delver, but adding or dismissing her at a camp or hub never changes approval.

At the Yard she maintains her equipment, appraises questionable salvage, powders her face using a polished mess-tin lid, and keeps her bunk screened with a repaired Velescar travel curtain. In other hubs she favors inns, delver stations, archives, and tables from which she can watch both doors.

## Approval

Approval is displayed only as `Guarded`, `Open`, `Trusted`, or `Strained`. Exact progress remains hidden.

Elara responds positively to:

- brave action that does not spend another person's life for spectacle;
- clever entry, climbing, exploration, and discovery;
- returning named property or dividing salvage honestly;
- protecting servants, laborers, prisoners, and people overlooked by rank;
- confronting powerful people without humiliating their dependents;
- admitting culpability while attempting practical repair;
- wagers whose stakes belong to the people making them.

She responds negatively to:

- looting active graves or treating human remains as crafting material;
- stealing food, keepsakes, or tools from poor households;
- class humiliation used as entertainment;
- cowardice renamed prudence after another person is abandoned;
- blind deference to title, Church office, or wealth;
- forcing her confession into public view merely to control her;
- taking an exciting risk with an uninformed bystander as the price.

Elara can approve theft from a corrupt official, rescue through trespass, or salvage from an abandoned civic ruin. She judges ownership, consent, and harm rather than treating legality as the whole moral answer.

## Field Familiarity

Field Familiarity records distinct authored experience, never raw time.

### First Outing

Any one of these events after recruitment writes `elara_first_outing_complete`:

- discovering or meaningfully exploring a named ruin or dungeon;
- witnessing a consequential property, burial, labor, class, or salvage decision;
- completing a dangerous rescue, boss, pursuit, or traversal sequence.

At the next hub, Elara offers [[Names Beneath Lime]].

### Continuing Familiarity

Later observations may improve approval, direction, or readiness only when they are distinct:

- one of Elara's ten embedded opportunities;
- a new main, faction, companion, or local quest;
- a named region or dungeon first discovery;
- an authored camp or company scene;
- a credible report about a public choice.

Idling, crafting loops, repeated jobs, and repeating the same encounter card cannot farm familiarity.

## Campaign Tracking

Elara's campaign becomes tracked when the player:

- accepts [[Names Beneath Lime]];
- explicitly promises help with the Virelian property;
- manually tracks the discovered campaign.

Tracked campaigns appear on act-transition dockets with readiness and consequences. Untracked Elara still acts according to [[Elara Companion Campaign#Deterministic Autonomy|her autonomous route]].

## Relationship Rhythm

Relationship content never gates Elara's strongest moral result.

### The Wager

After [[Names Beneath Lime]], Elara proposes a wager about the next impossible entrance.

- A male player may express attraction, redirect toward friendship, or decline.
- A female player may express deliberate trust, redirect toward ordinary friendship, or decline the future sworn-bond path.
- A closed refusal ends only the intimate path. It does not remove friendship or campaign access.

The scene writes `elara_wager_scene`.

### A Better Wager and Without the Powder

[[A Better Wager]] becomes available after the Act I chapter resolves, including after an autonomous result. The roof race is friendship content for every player.

The post-race **Without the Powder** scene is the second possible relationship scene. Elara discusses culpability and fear of ordinariness without presenting grooming or femininity as deception.

Completing the friendship episode writes:

- `elara_friendship_episode`;
- `elara_without_powder_scene`;
- `elara_bridgehold_line_practiced`.

## Commitment

Commitment is considered only after the player personally completes [[The Patron's Cabinet]].

Requirements:

- approval is Trusted;
- The Wager and Without the Powder were completed without a closed refusal;
- no active major conflict;
- the relevant global relationship slot remains open;
- `elara_act2_finale_played` is true.

A male player may enter romance. Elara asks for an equal relationship with no patron, rescued lady, inherited claim, or expectation that either person surrender an independent future.

A female player may form a sworn bond of mutual aid, truthful spoils, and return from danger. The promise creates duty without ownership.

Declining preserves friendship and the complete companion campaign.

If [[The Patron's Cabinet]] resolves autonomously, `elara_relationship_closed` becomes true. [[Elara Companion Campaign#Cabinet After Snow|Cabinet After Snow]] may repair morality and friendship but never reopens romance or sworn bond. The tracked transition warning names this consequence before confirmation.

## Relationship Episode

Committed relationships unlock [[Raven Shelf at Dawn]] during Early Spring and Open Spring.

The climb is not a moral cure. It develops mutual reliance and supplies:

- `elara_raven_line_practiced`;
- one path-specific duo-move upgrade;
- relationship-specific Act III and summer dialogue.

Missing the climb does not end the relationship or worsen approval.

## Romance Rewards

### Crossed Measure

Commitment unlocks this Elara-only duo move. Against a properly staggered elite or large target, Elara pins, levers, or marks the vulnerable point and opens a vocation-specific player finisher. It cannot bypass required preparation or instantly kill a healthy boss.

### Crossed Measure: Second Beat

Completing Raven Shelf upgrades the move. After the finisher, Elara provides a guarded disengagement and preserves a surviving target's opened point for one immediate follow-up. It cannot chain indefinitely.

### Equal Footing

Completing [[No Lady of Velescar]] with a resolved or compromised romance grants **Equal Footing**, a permanent non-slot campaign perk.

When the player exploits a weak point or stagger opening created by any companion, or a companion exploits one created by the player, the first alternating follow-up extends the opening and restores a bounded amount of Stamina. It triggers once per opening and does not create an opening by itself.

## Sworn-Bond Rewards

### Back-to-Back

Commitment unlocks this Elara-only duo move. Elara can intercept one contextual attack while the player climbs, revives, operates a mechanism, or is surrounded, allowing an immediate defensive response.

### Back-to-Back: Held Line

Completing Raven Shelf upgrades the move. The protected interaction withstands one ordinary interruption and the attacker becomes exposed. Boss grabs and catastrophic authored hazards retain their intended answers.

### Witness at My Back

Completing [[No Lady of Velescar]] with a resolved or compromised sworn bond grants **Witness at My Back**, a permanent non-slot campaign perk.

The first flank or off-screen attack in an encounter receives an authored warning and wider defensive response window. A successful guard, dodge, or counter exposes the attacker and restores bounded Stamina. The perk never guarantees immunity.

## Friendship Equality

A friend may:

- complete all nine non-exclusive formal pieces; [[Raven Shelf at Dawn]] remains the relationship-only tenth piece;
- reach Elara's resolved outcome;
- unlock Fault Proven, A Lady's Exit, The Last Claim, custom parts, and the Delver-Duelist blueprint;
- receive the complete summer coda;
- retain all non-romantic banter, interventions, and faction reactions.

Only relationship-specific duo moves and permanent perks are exclusive.

## Conflict and Repair

A major conflict begins if the player knowingly:

- helps Vardek destroy claims;
- repeatedly desecrates graves after Elara's warning;
- uses Elara's testimony to seize claimant property for the player;
- treats workers or relief recipients as expendable leverage;
- supports restoration of House Velescar over its households.

Elara names the act at the next hub and asks for a concrete repair. Repair may require returning property, protecting a witness, repudiating Vardek's bargain, compensating injury, or accepting a material loss.

Refusal marks the relationship Strained. Reaffirming the conduct during [[No Lady of Velescar]] produces the broken or departed result.

## Persistence

Relationship perks occupy neither vocation augment nor equipment slots. The player may possess one romance perk and one sworn-bond perk in a campaign under the global relationship rules.

Once learned, Equal Footing or Witness at My Back remains if Elara later leaves or dies through an explicit chosen sacrifice. Elara-specific duo moves and interventions require her in the active party.

Relationship perks are campaign-specific rather than account-wide New Game unlocks.

## Navigation

- [[Elara Velescar]]
- [[Elara Companion Campaign]]
- [[Elara Delver-Duelist Package]]
- [[Elara Banter and Reactivity]]
- [[Names Beneath Lime]]
- [[A Better Wager]]
- [[The Patron's Cabinet]]
- [[Raven Shelf at Dawn]]
- [[No Lady of Velescar]]
- [[Companion Field Familiarity and Duo Quest Standard]]
- [[Companions MOC]]
