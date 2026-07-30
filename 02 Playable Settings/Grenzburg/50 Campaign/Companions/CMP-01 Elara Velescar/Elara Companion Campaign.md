---
type: reference
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Southwood Barrowlands", "Highlake Uplands"]
culture: ["Eclessian", "Virelian"]
related_factions: ["Blackjack Corps", "Medori Bank", "House Velescar"]
appears_in: ["Grenzburg"]
needs: []
aliases: ["CMP-01 Campaign"]
tags: [production-control, game-ready]
companion_id: "CMP-01"
architecture_status: migrated
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
---
# Elara Companion Campaign

This is the controlling authority for Elara's eleven authored pieces, ten-piece playthrough ceiling, three deadlines, preparation ladders, autonomous progression, changed re-entry, and reward sequence. [[Elara Velescar]] controls character; [[Elara Field Familiarity and Relationships]] controls approval and intimacy; [[Elara Delver-Duelist Package]] controls combat.

## Dramatic Promise

Elara makes adventure feel splendid. She remembers the porter, names the rescue party, finds a better view, and can persuade frightened strangers that they already belong to a company worth saving.

Her danger is not false warmth. It is using real warmth to decide who counts.

Across the campaign, the player repeatedly enjoys Elara's gift before seeing its edge:

1. she turns strangers into a heroic company;
2. somebody necessary is left outside the story;
3. the excluded person refuses the role she offers;
4. Elara spends status without owning the result, under siege, and it works;
5. the room continues without her;
6. she discovers that relinquishing a house does not require relinquishing delight.

Direct discussion of the Velescar grave expeditions occupies less than one-third of ambient companion material. The rest is current work, appetite, jokes, arguments, competence, affection, and Grenzburg life.

## Campaign Shape

Elara's silhouette is **rise, fall, rise.**

- **Act I** — her form works, and the player enjoys it. She assembles crews, clears a porter's name, wins rooms, and the campaign lets her be magnificent before it charges her for it.
- **Act II** — her form becomes materially necessary. Siege makes her social gift into survival infrastructure, and she practises distributed authority in the one season where distributing it visibly saves lives. Meanwhile her name becomes a liability: Vardek's agents turn her existing notoriety into a rumour of ongoing service.
- **Act III** — the form is taken from her. Partly by the scandal, and partly **because the healthy thing she built in winter now runs without her.** She is politely managed out of the first celebration of the peace, commits the campaign's one witnessed cruelty inside four minutes of being irrelevant, and cannot style her way back.

The cruellest engine of the dethronement is her own reform working. That is the design, and no scene should soften it.

## Formal Campaign

| Seq. | ID | Piece | Format | Emotional and playable function |
|---:|---|---|---|---|
| 1 | CMP-01-I | [[Names Beneath Lime]] | normal party | local smuggling pursuit; Elara chooses who enters the public account |
| 2 | CMP-01-A1-O | [[A Splendid Little Expedition]] | normal party | assemble a mixed Ropehouse crew and discover whom glamour excludes |
| 3 | CMP-01-A1-F | [[A House Fed by Bones]] | duo | rescue, refusal, credit, and evidence compete during a barrow collapse |
| 4 | CMP-01-FR | [[A Better Wager]] | one-on-one | uninterrupted Bridgehold race and mutual delight |
| 5 | CMP-01-A2-O | [[The Winter Company]] | normal party | build siege rescue teams whose social inclusion changes survival |
| 6 | CMP-01-A2-F | [[The Patron's Cabinet]] | duo | social heist, relief dilemma, and remote restoration offer |
| 7 | CMP-01-RM | [[Raven Shelf at Dawn]] | male romance | danger, rescue, chosen privacy, and romantic commitment |
| 7 | CMP-01-BD | [[Two Names on the Rope]] | female bond | equal survey, reciprocal rescue, and platonic sworn friendship |
| 8 | CMP-01-A3-O | [[Uninvited]] | normal party | the public loss she cannot style; the coalition established and protected |
| 9 | CMP-01-A3-F | [[No Lady of Velescar]] | duo | recover claims and choose relinquishment, compromise, or restoration |
| 10 | CMP-01-S | [[The First Honest Find]] | normal party/changed | demonstrate her settled expedition ethic |

Only the three act finales use the fixed player-plus-Elara party. Temporary workers, custodians, witnesses, and rescued people remain outside companion capacity. Romance and bond are mutually exclusive; all other pieces remain available to ordinary friendship.

Estimated first-play duration is approximately **11 hours**.

## Direction and Legal State

`elara_direction` records named conduct:

- **accountable:** Elara shares authority, names her own choices, accepts refusal, and bears a real cost;
- **mixed:** she performs material repair while preserving a private privilege or curated version of events;
- **entitled:** she protects title, status, or her preferred story at another person's expense.

`elara_legal_debt_state` independently uses the states in [[Companion Debt and Remote Claims Standard]]. [[Claims-Factor Marco Bellandi]] may authenticate Velescar instructions, place assets in escrow, and close the account. He cannot decide Elara's direction or produce forgiveness.

**The packet.** Household correspondence is finite and already in the city. One authenticated packet crossed before the siege closed the roads and has been sitting in Bellandi's backlog; nothing new arrives while Grenzburg is shut. Everything the campaign can enforce comes out of that packet or out of copies the Bank already held — which is also the deadline underneath Act III, because the packet is the only version of the households' words that exists here. Its four principal instructions are quoted in [[The Velescar Correspondence]].

[[Lord Marek Vardek|Marek Vardek]] remains remote. He acts through a restoration offer, local agents, bought claims, and authenticated correspondence. His physical absence keeps the decisive scene on Elara.

## Readiness

Every act offers five assets. Two permit player participation, three make every material objective achievable, and four or five add one safeguard. No asset requires a faction, relationship, moral profile, or vocation.

**Intentional exception — do not regress.** [[The Patron's Cabinet]] breaks the three-assets-all-objectives guarantee on purpose. If Elara refuses or escrows the restoration offer, the heist secures the complete evidence set **or** the complete relief delivery, never both, at any preparation level. Assets change which half survives and how badly the lost half degrades; they never dissolve the fork. A campaign about a woman who always finds the elegant both-and requires exactly one authored moment where there is none.

### Act I

| State | Source | Finale use |
|---|---|---|
| `elara_mixed_expedition_crew` | [[A Splendid Little Expedition]] | supplies people Elara initially overlooked |
| `elara_southwood_intelligence` | [[Roads Worth Saving]] | exposes a safe approach and retreat |
| `elara_burial_support` | [[Bread and Burial]] | provides named handling and lawful care |
| `elara_shoring_knowledge` | Ropehouse fieldwork | opens the safest collapse response |
| `elara_living_custodians` | local finder dispute | provides refusal authority and a holding crew |

### Act II

| State | Source | Finale use |
|---|---|---|
| `elara_winter_company_ready` | [[The Winter Company]] | preserves both rescue and evidence teams |
| `elara_roofline_route` | [[The City in Siege]] | provides the cleanest cabinet escape |
| `elara_bellandi_escrow_access` | account review | separates relief from Vardek ownership |
| `elara_public_witnesses` | faction/local work | prevents quiet substitution after the heist |
| `elara_bridgehold_practice` | [[A Better Wager]] | opens a fast non-combat crossing |

### Act III

| State | Source | Finale use |
|---|---|---|
| `elara_coalition_ready` | [[Uninvited]] | keeps decision-making with current claimants |
| `elara_living_claims_index` | [[The Land Reclaimed]] | distinguishes household use from salvage |
| `elara_remote_instructions_authenticated` | Bellandi review | makes absent households' exact terms enforceable |
| `elara_burial_provenance` | [[The Names They Buried]] | identifies restitution property |
| `elara_old_tithe_access` | riverworks or underways work | opens a second vault route |

`elara_raven_line_practiced` and `elara_two_names_line_practiced` are mutually exclusive, equal safeguards outside the five-asset threshold. Either preserves one person or material objective during the Act III collapse. Neither alters Elara's moral choice.

## Deadlines and Autonomy

| Deadline | Intended action |
|---|---|
| commitment to [[The Last Convoy]] | Elara leads the best available crew to Seven Mounds |
| commitment to [[Ghor at the Gate]] | Elara enters the cabinet through her strongest current route |
| commitment to [[The Deep Muster Main Quest]] | Elara races local Vardek agents to the Old Tithe Vault |

Tracked campaigns show readiness and the exact content that will close. Untracked plans remain discoverable through Elara's schedule, crew board, and conversations, but receive no consolidated warning.

### Zero-participation route

Elara becomes a compromised survivor:

- she saves the Seven Mounds workers after chasing proof first, causing avoidable injuries and a scarred chamber;
- she preserves the winter relief and exposes part of Vardek's local network, but keeps the restoration option;
- **she attends the Reclamation Feast, is needled, and makes the joke anyway.** The cruelty in [[Uninvited]] is hers in every route, played or unplayed; the substitution partly succeeds and the coalition is functional rather than ready;
- she cancels inherited obligations and grants durable household rights while retaining a reduced title and private reserve.

She cannot die unseen.

Two states in this campaign are unrepairable by design, and both are flagged in their own files: `perle_state` never returns to `adoring` (see [[Perle Winkel]]), and `sandro_state` never moves at all (see [[Sandro Tessari]]). Neither sits inside the ordinary conflict-and-repair loop. Do not add repair scenes for either.

### Influenced autonomous results

Accountable direction and at least three assets can produce moral success with permanent material loss. Entitled direction or zero assets can worsen casualties, evidence, or Elara's settlement, but never invent a random outcome.

[[Bernard Valeon]] or [[Dismas Raben]] may protect workers in Act I. [[Zafir ibn Samad]] or [[Ilyana Veshkar]] may preserve relief authentication in Act II. [[Ashira bath Melan]] may preserve provenance in Act III. No companion chooses Elara's priority or settlement.

## Changed Re-entry

**The Scarred Mounds:** a winter aftermath can compensate injured workers, recover names, and move direction one step through material repair. It cannot undo injuries, restore the chamber, or grant the missed finale reward.

**Cabinet After Snow:** a spring aftermath permits repudiation of the restoration offer and recovery of partial evidence. It cannot restore lost relief or reopen romance and bond. The Act II transition warning states this closure exactly.

Missing Act III fixes Elara's autonomous settlement. [[The First Honest Find]] reflects it and does not reopen judgement.

## Ten Embedded Opportunities

| Context | Function |
|---|---|
| [[Roads Worth Saving]] | makes an overlooked road crew visible without taking command |
| [[The City in Siege]] | forms a crane-and-roof rescue team |
| [[The Land Reclaimed]] | distinguishes living use from impressive salvage |
| [[Bread and Burial]] | credits burial work without using it as absolution |
| [[Lucia's Long Book]] | separates useful logistics from ownership |
| [[The Names They Buried]] | matches provenance while respecting restricted testimony |
| Finder's-right dispute | spends social standing on a custodian's refusal |
| Ropehouse exploration | lets a worker correct her structural read |
| Named Property Board | turns a Yard ceremony into an accountable process |
| Abandoned Pack encounter | tests whether she names the finder and owner before the story |

## Outcome Standard

**Resolved:** Elara relinquishes the title, transfers viable land and authority according to authenticated household instructions, funds burial repair, and remains an ethical adventurer.

**Compromised:** she performs meaningful restitution but retains a reduced title, private reserve, or formal patron role.

**Broken/departed:** she restores the house through concealed wealth, suppresses claims, or accepts Vardek's terms after a warned repair opportunity.

None becomes future-setting canon.

## Navigation

- [[Elara Velescar]]
- [[Elara Field Familiarity and Relationships]]
- [[Elara Delver-Duelist Package]]
- [[Elara Banter and Reactivity]]
- [[Claims-Factor Marco Bellandi]]
- [[Companion Debt and Remote Claims Standard]]
- [[Companion Campaign Expansion Register]]
- [[Narrative State Register]]
- [[Companions MOC]]
