---
type: reference
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Longlake Country", "Frostfenn March"]
culture: ["Thalmyric", "Kedravan", "Eclessian"]
related_factions: ["Blackjack Corps", "Medori Bank", "Order of the Long Watch", "Church of Grenzburg"]
appears_in: ["Grenzburg"]
needs: []
aliases: ["CMP-05 Campaign"]
tags: [production-control, game-ready]
companion_id: "CMP-05"
architecture_status: migrated
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
---
# Bernard Companion Campaign

This note controls Bernard's eleven authored pieces, ten-piece playthrough ceiling, approximately twelve playable hours, three preparation ladders, deterministic autonomy, changed re-entry, progression, and outcomes. [[Bernard Valeon]] controls character. [[Bernard Field Familiarity and Relationships]] controls approval and intimacy. [[Bernard Compulsion and Accountability System]] and [[Bernard Long Watch Greatsword Package]] control systemic play.

## Dramatic Promise

Bernard makes bad places feel inhabited by people rather than suffering. He can turn a ration line into supper, a frightened child into a rule-maker, and the last watch into a story everybody knows is too long.

His warmth is real. Its danger is that he sometimes offers so much comfort that asking him to answer for harm begins to feel ungrateful.

The campaign lets the player enjoy him before asking him to remain present when the joke no longer helps:

1. the Yard loves him before it trusts him;
2. a real relapse harms somebody with less standing;
3. children receive courage without becoming proof that Bernard is good;
4. he accepts the first object that is unambiguously his;
5. public hospitality becomes practical rescue;
6. courageous service and exact accountability occur in the same room;
7. romance or brotherhood lets him receive care without purchase;
8. a hospice tests whether love, inventory, faith, and limits can coexist.

Direct discussion of Froststep occupies less than one-third of ambient Bernard material. The rest is food, work, jokes, prayer, children, company life, danger, affection, and Grenzburg.

## Campaign Shape

**The war gets bigger and the object gets smaller.**

Act I's decisive object is a food portion among seven children on a road. Act II's is a salve packet under a folding table in a siege. Act III's is one dose with a name on it, in a coat, in a hospice he built. The institutions expand — wagon, network, hall — while the thing that actually decides who he is keeps shrinking toward a single hidden item in a single pocket.

His silhouette is a **spiral, not an escalation:** relapse, repair, relapse smaller. He does not graduate from concealment; he gets better at catching himself, later than he should, in front of people who are harder to face each time.

### Two intentional exceptions — do not regress

1. **The shortage in [[The Open Hospice]] is real at every preparation level.** Preparation changes who bears it and how badly, never whether somebody does. A hospice that can always be supplied teaches nothing about a man who hoards.
2. **The cold injury to the child who went without is permanent, unwarned, and unrepairable.** It is written at the allocation, displayed nowhere, and surfaces once in [[Grace]] after judgement has closed. Do not add a warning, a save, or a repair path.

`lenka_state` is likewise fixed and sits outside the ordinary conflict-and-repair loop; see [[Lenka Vrana]].

## Formal Campaign

| Seq. | ID | Piece | Format | Function |
|---:|---|---|---|---|
| 1 | CMP-05-I | [[Little Things Missing]] | normal party | a genuine relapse, wrongful suspicion, pursuit, and specific restitution |
| 2 | CMP-05-A1-O | [[The Wagon in the Reeds]] | normal party | recover a road-school wagon and learn when humor must stop |
| 3 | CMP-05-A1-F | [[Little Hands, Long Road]] | duo | protect seven children, confront Mika's hunger, and survive the snared bear |
| 4 | CMP-05-FR | [[A Blade Freely Given]] | one-on-one | return borrowed arms and receive a greatsword without earning it |
| 5 | CMP-05-A2-O | [[The Long Winter Table]] | normal party | turn four shelter suppers into a voluntary rescue network |
| 6 | CMP-05-A2-F | [[Embers Without Excuse]] | duo | declare a reserve, save an infirmary, and kindle White Flame without acquittal |
| 7 | CMP-05-RM | [[Enough for Two]] | female romance | receive a private feast, a freely given bead, desire, and intimacy |
| 7 | CMP-05-BD | [[Watch Until Morning]] | male bond | repair a shelter and become sworn brothers through shared service |
| 8 | CMP-05-A3-O | [[Beds Before Banners]] | normal party | protect familiar patients and establish neutral admission at West Refuge Hall |
| 9 | CMP-05-A3-F | [[The Open Hospice]] | duo | move patients, keep witnessed stores, survive residue, and choose a destination |
| 10 | CMP-05-S | [[Grace]] | normal party/changed | demonstrate Bernard's settled conduct through an ordinary meal; the scar surfaces |

Only the three act finales use the fixed player-plus-Bernard party. Romance and bond are mutually exclusive. Friendship alone can reach Bernard's strongest moral resolution and every non-relationship progression reward.

## Direction, Restitution, and Debt

`bernard_direction` changes only through named conduct:

- **truthful:** he reports urges, declares reserves, accepts gifts openly, and repairs harm without requiring affection;
- **uncertain:** he performs real service but relies on supervision or admits concealment only after pressure;
- **withholding:** he hides stores, shifts blame, or uses usefulness, humor, or sacred authority to escape consequence.

`bernard_legal_debt_state` follows [[Companion Debt and Remote Claims Standard]]. [[Claims-Factor Marco Bellandi]] verifies the Froststep schedule, receives authenticated responses, and closes or restructures the account. Legal satisfaction does not select Bernard's direction.

Legal debt, personal direction, relationship, destination, and physical fate remain separate playthrough states. No one of them automatically selects another.

[[Petra Ilev]] controls her own response through the authenticated restitution record:

| State | Condition |
|---|---|
| `accepted-no-reconciliation` | complete and timely restitution without pressure; she accepts the record and closes personal contact |
| `redirected-to-road-care` | she directs her share toward practical winter-road care instead of receiving it personally |
| `contact-closed` | concealment, pressure, or use of her name as moral proof ends further contact |

No state means forgiveness. The player cannot contact or persuade Petra directly. [[Matej Solin]], [[Hospice-Mother Radena Vosk]], and Petra remain remote.

## Preparation

Two assets permit player participation in a finale. Three make every material objective achievable. Four or five add one safeguard. No asset requires a faction, relationship, temperament, moral alignment, or vocation.

### Act I

| State | Source | Finale use |
|---|---|---|
| `bernard_road_school_wagon_recovered` | [[The Wagon in the Reeds]] | supplies sound transport and the refuge bell |
| `bernard_longlake_route_secured` | [[Roads Worth Saving]] | opens the safest approach and return |
| `bernard_service_injury_claim_supported` | [[A Debt That Grew Wounded]] | gives Oda authority to requisition care |
| `bernard_pikehook_snare_line_mapped` | Pikehook exploration | identifies the bear's route before contact |
| `bernard_hunger_named_early` | Yard or road-school scene | lets Mika ask before the food crisis becomes concealment |

### Act II

| State | Source | Finale use |
|---|---|---|
| `bernard_long_table_network` | [[The Long Winter Table]] | supplies cooks, porters, signals, and receiving shelters |
| `bernard_breach_casualty_lane_secured` | [[The City in Siege]] | opens the infirmary evacuation lane |
| `bernard_mercy_heat_plan` | [[Mercy in Winter]] | preserves deep-cold patients |
| `bernard_long_watch_kit_provenance` | Bellandi and Long Watch records | distinguishes issued, donated, and restitution stores |
| `bernard_open_store_procedure_practiced` | Blackjack Yard drill | makes the reserve declaration immediate and legible |

### Act III

| State | Source | Finale use |
|---|---|---|
| `bernard_west_refuge_neutral_claim` | [[Beds Before Banners]] | prevents sponsors reserving beds by rank |
| `bernard_reclaimed_patient_routes` | [[The Land Reclaimed]] | opens two evacuation paths |
| `bernard_mixed_carer_pledge` | Church, Folk, and Blackjack work | supplies trusted carers without one faction owning admission |
| `bernard_underways_evacuation_route` | West Refuge exploration | provides a low-casualty retreat |
| `bernard_named_store_custodians` | Yard and hospice practice | keeps the final stores witnessed under panic |

`bernard_table_received` and `bernard_second_bearer_practiced` are mutually exclusive, equivalent safeguards outside the five-asset threshold. Either prevents one exhaustion-driven physical failure in [[The Open Hospice]]. Neither changes Bernard's moral choice.

## Deadlines and Autonomy

| Deadline | Bernard's intended action |
|---|---|
| commitment to [[The Last Convoy]] | escort Oda and seven children along the Longlake road |
| commitment to [[Ghor at the Gate]] | serve the isolated field infirmary with an undeclared or declared reserve |
| commitment to [[The Deep Muster Main Quest]] | establish the final patient route and defend the hospice |

Tracked dockets show readiness, closure, and the exact relationship consequence. Untracked plans remain discoverable through the kitchen rota, Oda's route board, Mercy Hospital notices, and Bernard's own conversations.

### Zero-participation route

Bernard becomes a compromised caregiver:

- all seven children survive, but a late warning causes avoidable minor injuries and the bear is killed in defence;
- the winter patients survive and White Flame genuinely kindles during courageous service, but Bernard's accountability remains incomplete;
- Petra records restitution without reconciliation according to the actual account;
- Bernard serves the Blackjack infirmary under [[Quartermaster Brina Kest|Brina Kest]]'s inventory authority;
- Open Lamp remains unrealized.

He cannot die autonomously.

Truthful direction and three assets can improve autonomous moral conduct while preserving permanent material losses. Withholding direction or weak preparation worsens trust, injury, and destination without inventing random death.

[[Ylva Winter-Track]] or [[Dismas Raben]] may protect a road or child in Act I. [[Ilyana Veshkar]] or [[Zafir ibn Samad]] may preserve a shelter signal or catch an undeclared reserve in Act II. [[Ylva Winter-Track]], Ilyana, or Zafir may preserve a patient route or witnessed release in Act III. Nobody confesses, declares a reserve, or receives a gift for Bernard.

## Changed Re-entry

**The Bent Bell:** missing Act I opens a winter road-school aftermath. The player can repair the bell, fund injuries, and clear the snare line. It cannot restore the missed rescue reward or reverse the bear's death.

**Ashes in the Storebook:** missing Act II opens a spring restitution aftermath. Bernard may complete personal severance and repair a concealed record, but the Paladin unlock, romance, bond, and finale rewards remain closed for that playthrough. The transition docket states this explicitly.

Missing Act III fixes Bernard's autonomous destination. [[Grace]] reflects it rather than reopening the hospice decision.

## Progression

| Stage | Reward |
|---|---|
| introduction | **Hands Declared**, Things Not Mine, and improved self-report cues |
| Act I operation/finale | **Shelter at My Back** rescue interposition and Long Watch field parts |
| friendship | Bernard's freely owned greatsword |
| Act II finale | [[Paladin]] current-playthrough and account unlock; relationship commitment |
| Act III finale | **Last Ember** capstone and Long Watch custom-vocation blueprint on resolved or compromised outcomes |

Romance grants **Shared Ember**, upgraded through [[Enough for Two]], and permanent non-slot perk **Kept in the Light** after a resolved or compromised finale.

Bond grants **No One Alone**, upgraded through [[Watch Until Morning]], and permanent non-slot perk **Last Watch** after a resolved or compromised finale.

## Embedded Opportunities

1. casualty and property safeguards in [[Roads Worth Saving]];
2. a breach casualty lane in [[The City in Siege]];
3. reclaimed patient routes in [[The Land Reclaimed]];
4. service-injury responsibility in [[A Debt That Grew Wounded]];
5. practical hospital heat in [[Mercy in Winter]];
6. mixed refuge obligations in [[The Four-Hearth Winter]];
7. Pikehook's snare-line exploration;
8. West Refuge's underways route;
9. a Blackjack Yard open-store drill;
10. **The Spare Blanket**, a one-shot Things Not Mine incident.

## Outcomes

**Resolved:** Bernard keeps truthful stores without needing supervision, completes specific restitution, and establishes Open Lamp, rejoins the Long Watch under honest limits, or travels as a hospitaller according to the player's destination choice.

**Compromised:** he provides real care under Brina, Church, ducal, or Long Watch supervision because he still cannot sustain independent accountability.

**Broken/departed:** he hides from an active store loss, steals from patients or the dead, or claims sacred usefulness as immunity after a warned repair opportunity.

**Heroic but unresolved sacrifice:** the player may accept Bernard's final stand only after all evacuation alternatives visibly fail. It saves lives but is not his strongest resolution.

No result becomes future-setting canon.

## Navigation

- [[Bernard Valeon]]
- [[Bernard Field Familiarity and Relationships]]
- [[Bernard Compulsion and Accountability System]]
- [[Bernard Long Watch Greatsword Package]]
- [[Companion Debt and Remote Claims Standard]]
- [[Zafir Companion Campaign]]
- [[Companion Campaign Expansion Register]]
- [[Narrative State Register]]
- [[Companions MOC]]
