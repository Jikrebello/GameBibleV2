---
type: quest
status: archived
canon_level: obsolete
visibility: author-only
archive_reason: "Control snapshot before the Grenzburg RPG Experience Constitution pass"
archived_from: "02 Playable Settings/Grenzburg/50 Campaign/Acts/Accounts of the Living.md"
archived_on: 2026-07-24
superseded_by: "[[Accounts of the Living]]"
era: ["Present Day"]
region: ["Grenzburg"]
culture: ["Eclessian", "Folk", "Grobi"]
related_factions: ["Duchy of Grenzburg", "Blackjack Corps", "Medori Bank", "Church of the Redeemer", "Folk kindreds", "Grenzburg underworld"]
appears_in: ["Grenzburg"]
needs: []
aliases: []
tags: [game-ready]
quest_class: aftermath
act: summer
availability_window: ["Summer Aftermath"]
repeatability: one-shot
cutoff_result: persists
world_state_outputs: ["player_service_claim", "campaign_casualty_record", "companion_destinations_locked", "political_settlement_composed"]
required_locations: ["Grenzburg", "Cathedral Close", "Crown Heights", "Lantern Ward", "Ledger Quays"]
blocking_status: blocked
quest_owner: "Grenzburg Main Campaign"
quest_sequence: 0
companion_id: ""
faction_line: ""
faction_branch: ""
chapter_id: "SQ-01"
main_sequence: 22
story_gate: aftermath
estimated_hours: 2.0
gameplay_pillars: [consequence, exploration, social, memorial]
required_states: ["campaign_victory"]
optional_state_inputs: ["all_main_campaign_states", "all_faction_states", "all_companion_states", "all_settlement_states"]
---
# Accounts of the Living

## Quest Function

This is the first required summer quest. It resolves the campaign through people, places, funerals, public claims, and one service decision rather than a single council screen. It composes a political settlement from five independent lines; it does not choose a canonical winner for the setting.

## Trigger and Commitment

The party emerges from the Deep Muster and reaches Last Hearth's evacuation road. The quest begins automatically but allows free movement between its city stages. No remaining postgame content is permanently cut off.

## Beginning: Bring Back the Living

The return journey contains three state-driven scenes:

- a casualty station reflects `final_assault_strength` and the method of closure;
- a returning column includes, omits, or mourns people from the three Dead March fronts;
- the first messenger from Grenzburg reports city services, settlements, and political claims.

The player identifies remains, gives immediate orders about dangerous salvage, and chooses which urgent message reaches the city first: survival, warning, or names of the dead. This changes the arrival scene, not the settlement's substance.

## Middle: A City Counts Itself

Grenzburg is freely traversable. Four physical account stations replace one abstract hearing:

### Cathedral Close: Names and Remains

Hospitals, burial workers, families, and military clerks reconcile the dead. The player can correct missing names, disclose difficult causes, and establish Gerhold's recorded fate. The scene locks `campaign_casualty_record`; it never converts residue into souls or hides culpable deaths for convenience.

### Lantern Ward: Debtors and the Yard

Surviving Blackjacks gather at the Yard. Brina Kest presents the unit's losses and collective claim; Koss's state and Lucia Medori's reform position alter who contests it. The protagonist may ask for personal release, spend the claim on collective debtor relief, or accept a broader faction settlement that has already superseded both.

### Ledger Quays and Old Market: Work and Restitution

Guilds, households, traders, Folk delegates, Grobi prisoners or intermediaries, and underworld actors present immediate material claims. The player sees food, homes, tools, routes, and jurisdiction rather than choosing from unexplained policy names.

### Crown Heights: The Provisional Settlement

Alaric's court records five independent terms:

1. military authority and expiration of emergency powers;
2. debt, Blackjack service, and ownership of collective equipment;
3. Church spiritual jurisdiction and secular criminal law;
4. Folk seasonal rights, sanctuary boundaries, and road obligations;
5. underground power, tolerated services, and the treatment of vigilantism.

Faction-line results supply available terms. The player selects among earned terms, accepts a deadlock, or leaves one axis provisionally unresolved. No faction can erase the other four axes by winning its own line.

## End: Eight Doors

Every recruited companion receives an in-person scene in their current location. Resolved, compromised, broken, departed, romance, sworn-bond, and sacrifice states are respected. The player confirms immediate destinations without forcing permanent companionship.

The quest ends at a public memorial assembled from the campaign's actual losses. The protagonist's service claim and the provisional settlement are read aloud only to the degree that their actions made them public.

## Information Paths

The quest draws directly from named campaign states. Missing witnesses, records, or faction resolutions produce honest uncertainty or provisional terms; they never invent a default victory behind the player's back.

## Encounters and Active Problems

Summer consequence play still requires action: dangerous Muster salvage must be quarantined, a disputed casualty train must be identified, one crowd or household crisis must be de-escalated, and the player must physically reach companions or account stations altered by city damage. These scenes use exploration, social play, recovery, and limited combat only where surviving threats make sense.

## Choices and State Changes

- `player_service_claim` resolves to personal-release, collective-relief, or superseded-by-faction-settlement.
- `campaign_casualty_record` becomes the authoritative record of named and grouped losses.
- `companion_destinations_locked` records all eight companion post-campaign states.
- `political_settlement_composed` stores the five independent settlement axes.

Personal release ends the protagonist's own Medori service. Collective relief converts the protagonist's claim into reduced terms and common assets for surviving Blackjacks; the player remains under a shorter fixed service unless another earned settlement frees the company.

## Fail-Forward and Incomplete States

- Missing records create a summer recovery objective and an explicitly incomplete memorial roll.
- A faction deadlock leaves that settlement axis provisional rather than assigning a winner.
- A companion who departed receives a letter, witness report, or absence marker only if the campaign established one; they do not return for convenience.
- Refusing to endorse a settlement preserves public conflict and changes patrols or services, but does not prevent summer play.
- The player can leave and return between account stations without a false urgency timer.

## Companion Intersections

Every resolved arc supplies authored variants. Relationships affect intimacy and support, not whether a companion's civic or moral position exists.

## Faction Intersections

Every completed faction line supplies earned settlement terms, witnesses, services, and public claims. Factions may claim credit, but the casualty record identifies who actually acted and no line can seize another settlement axis.

## Cutoff and Unlocks

Completing the memorial unlocks [[The First Summer Road]]. City postgame routines, companion schedules, faction headquarters, and provisional political terms activate immediately.

## Navigation

- [[SUMMER AFTERMATH]]
- [[Main Campaign State Matrix]]
- [[Narrative State Register]]
- [[The First Summer Road]]
- [[Main Campaign MOC]]
