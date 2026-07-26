---
type: reference
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Virelia"]
culture: ["Eclessian", "Virelian"]
related_factions: ["Blackjack Corps", "Medori Bank", "House Velescar", "Vardek household"]
appears_in: ["Grenzburg"]
needs: []
aliases: ["CMP-01 Campaign"]
tags: [production-control, narrative-rewrite]
companion_id: "CMP-01"
architecture_status: migrated
emotional_rewrite_status: pending-paired-pass
dialogue_status: pending-rewrite
---
# Elara Companion Campaign

This note remains the structural authority for Elara's sequence, deadlines, preparation, autonomy, and rewards. [[Companion Emotional Rewrite Audit]] now supersedes its scene-level emotional assumptions. It is not implementation-ready until the Elara-Ashira paired pass clears its emotional and dialogue status.

This is the controlling authority for Elara Velescar's eleven authored campaign pieces, ten-piece playthrough ceiling, three act deadlines, preparation assets, autonomous decisions, changed re-entry, embedded opportunities, and progression rewards. [[Elara Velescar]] remains the character authority. [[Elara Field Familiarity and Relationships]] controls approval and intimacy, while [[Elara Delver-Duelist Package]] controls combat.

## Campaign Thesis

Elara's campaign asks whether exploration can remain joyful after she admits what she once made other people pay for it.

She begins as a clever woman who can name every technical failure in an excavation except the decision that put vulnerable workers there. Her old refrain is, **"I did what the house required."** Across the campaign she must learn:

1. a name and a claim are not obstacles to discovery;
2. preserving useful relief does not require protecting the person who supplied it;
3. living custodians and laborers are participants, not scenery;
4. relinquishing rank does not require relinquishing curiosity, beauty, daring, or pleasure.

The strongest outcome leaves Elara an adventurer. It does not turn her into a clerk, penitent recluse, or person ashamed of elegance.

## Formal Campaign

The eleven authored pieces contain mutually exclusive romance and sworn-bond episodes. A playthrough exposes nine non-exclusive pieces and no more than one sequence-7 relationship episode, preserving approximately **10.75 first-play hours** within the campaign's 9-12 hour budget. Exploration, repeated attempts, optional conversations, and embedded opportunities can extend that time without padding the formal sequence.

| Sequence | ID | Piece | Role | Party | Principal function |
|---:|---|---|---|---|---|
| 1 | CMP-01-I | [[Names Beneath Lime]] | introduction | normal party | identify Elara's crime and recover named grave property |
| 2 | CMP-01-A1-O | [[The Sixth Field Book]] | Act I operation | normal party | recover the worker roll and Seven Mounds survey |
| 3 | CMP-01-A1-F | [[A House Fed by Bones]] | Act I finale | player and Elara | choose workers, proof, and treasure under collapse |
| 4 | CMP-01-FR | [[A Better Wager]] | friendship | one-on-one | let adventure be pleasure rather than entitlement |
| 5 | CMP-01-A2-O | [[Eight Honest Warrants]] | Act II operation | normal party | separate evidence from genuine winter relief |
| 6 | CMP-01-A2-F | [[The Patron's Cabinet]] | Act II finale | player and Elara | confront Vardek without sacrificing the people he feeds |
| 7 | CMP-01-RM | [[Raven Shelf at Dawn]] | romance | one-on-one | deepen a male-player romance through danger, rescue, and private intimacy |
| 7 | CMP-01-BD | [[Two Names on the Rope]] | sworn bond | one-on-one | establish female-player sworn friendship through equal survey, reciprocal rescue, and guaranteed return |
| 8 | CMP-01-A3-O | [[Sixty-Three Claims]] | Act III operation | normal party | protect household petitions before the estate settlement |
| 9 | CMP-01-A3-F | [[No Lady of Velescar]] | Act III finale | player and Elara | decide what leaves the vault and what House Velescar becomes |
| 10 | CMP-01-S | [[The First Honest Find]] | summer coda | normal party or changed encounter | demonstrate the settled expedition ethic |

The introduction and operations retain ordinary party management. Only the three act finales dismiss other full companions under the duo-quest rule. Friendship, romance, and sworn-bond episodes are private one-on-one activities. Romance and bond are mutually exclusive, authored separately, and never presented as alternate dialogue inside the same scene. Temporary workers, witnesses, and guides never consume companion slots.

## Tracking and Release

Elara becomes available at [[Blackjack Yard]] during Early Autumn. Her campaign becomes tracked when the player accepts [[Names Beneath Lime]], promises to help with the Virelian property, or manually tracks her discovered campaign.

The introduction unlocks after one distinct meaningful outing with Elara. Any one of the following is sufficient:

- a named ruin or dungeon discovery;
- a consequential decision about property, burial, labor, class, or salvage;
- a dangerous rescue, pursuit, boss, or traversal success.

Idle time, repeatable jobs, and revisiting the same discovery do not count.

## Direction State

`elara_direction` is qualitative and derived from named conduct:

- **accountable:** Elara has admitted agency, accepted a material cost, and repaired any major conflict;
- **mixed:** she has performed real restitution while preserving an unexamined title, reserve, excuse, or hierarchy;
- **entitled:** she continues to place proof, wealth, title, or her own preferred story ahead of named people.

The state is not a hidden morality score. Each change is attached to an authored decision or aftermath. Public confession is never mandatory: truthful admission to affected people and material restitution can establish accountability without spectacle.

## Readiness Standard

Each act has five named assets.

| Assets held | Docket state | Effect |
|---:|---|---|
| 0-1 | Unprepared | Elara will act autonomously at the deadline; the player cannot safely stage the duo finale |
| 2 | Viable | the duo finale is available with meaningful tradeoffs |
| 3 | Prepared | every principal material objective is achievable through strong play |
| 4-5 | Strongly Prepared | one additional safeguard or route is available; success is still played rather than guaranteed |

No act requires a particular vocation, faction, relationship, or moral alignment.

### Act I Assets

| Asset | Principal source | Finale use |
|---|---|---|
| `elara_sixth_fieldbook_secured` | [[The Sixth Field Book]] | supplies the worker roll, survey corrections, and collapse sequence |
| `elara_southwood_route_intelligence` | Elara's contribution to [[Roads Worth Saving]] | reveals the hunter approach and Vardek cart route |
| `elara_burial_name_support` | Elara's scene in [[Bread and Burial]] | provides lawful name tablets, wrapping, and a burial witness |
| `elara_shoring_knowledge` | exploration of Ropehouse Ruin | improves support work and the emergency exit |
| `elara_living_custodian_support` | the Finder's Share local-story hook | provides local witnesses and a post-collapse holding crew |

### Act II Assets

| Asset | Principal source | Finale use |
|---|---|---|
| `elara_warrant_casket_key` | [[Eight Honest Warrants]] | identifies the authentic cabinet and preserves relief instruments |
| `elara_winter_roofline_proven` | Elara's contribution to [[The City in Siege]] | opens the safest reception and frozen-quay escape line |
| `elara_lucia_logistics_copy` | Elara's scene in [[Lucia's Long Book]] | separates grain movement from ownership and debtor pages |
| `elara_danara_authentication` | Danara's post-operation record scene | identifies the cabinet's genuine construction and missing names |
| `elara_bridgehold_line_practiced` | [[A Better Wager]] | supplies a rehearsed cross-bank route and movement cues |

### Act III Assets

| Asset | Principal source | Finale use |
|---|---|---|
| `elara_household_claims_protected` | [[Sixty-Three Claims]] | preserves claimant instructions and the three delegated priorities |
| `elara_living_claims_indexed` | Elara's contribution to [[The Land Reclaimed]] | distinguishes living property claims from military salvage |
| `elara_kata_delegation_ready` | Kata's survival and claimant-preparation scene | supplies worker testimony and an evacuation team |
| `elara_burial_provenance_matched` | [[The Names They Buried]] or Danara's archive work | identifies the burial tubes and valid restitution chain |
| `elara_old_tithe_route_known` | underways access or the public riverworks survey | opens one of the Old Tithe Vault approaches |

`elara_raven_line_practiced` from [[Raven Shelf at Dawn]] and `elara_two_names_line_practiced` from [[Two Names on the Rope]] are mutually exclusive relationship bonuses outside the five-asset threshold. Either can preserve one person or material recovery during the clearing-chamber collapse. They never stack and cannot change Elara's direction or settlement choice.

## Act Deadlines

| Chapter | Deadline | Autonomous action |
|---|---|---|
| Act I | commitment to [[The Last Convoy]] and Tannbruck's fall | Elara follows the copied field book to Seven Mounds |
| Act II | commitment to [[Ghor at the Gate]] and the spring transition | Elara enters Vardek's cabinet operation through her best available route |
| Act III | commitment to [[The Deep Muster Main Quest]] | Elara races surviving Velescar interests to Old Tithe Vault |

Tracked campaigns show intended action, readiness, relationship consequences, and changed-reentry warning. Untracked campaigns advance without a consolidated docket entry, but Elara's schedule, letters, and Blackjack assignments still reveal what she intends.

## Deterministic Autonomy

Autonomous outcomes resolve from direction, readiness, prior antagonist states, world state, and available support. They are never random.

### Act I

- **Accountable with Prepared or Strongly Prepared:** Elara saves the crew and puts them first. The field antagonist escapes with part of the correspondence, the mound remains scarred, and the custom-part rewards are lost.
- **Mixed default:** Elara pursues proof before turning back for the crew. Kata and the diggers survive, but several suffer avoidable injuries; portable goods disappear and Vasko or Daria escapes.
- **Entitled or Strained:** Elara secures the field book and title evidence while workers are scattered or seriously harmed. Her next chapter begins under an active repair conflict.

Bernard may prevent a worker injury if his Act I chapter is already resolved and he is available. Dismas may close one retreat route. Neither decides Elara's priority.

### Act II

- **Accountable with Prepared or Strongly Prepared:** relief reaches its recipients and Elara refuses restoration. Only partial evidence survives and Vardek or his executor escapes.
- **Mixed default:** the grain arrives and part of Vardek's network is exposed, but Elara secretly retains the title seal and restoration option.
- **Entitled or Strained:** Elara accepts patronage, loses the clean evidence channel, or treats relief recipients as leverage. Repudiation remains possible through changed re-entry.

Zafir may authenticate ownership substitutions. Ilyana may preserve the relief convoy or secure the withdrawal. Neither can refuse Vardek for Elara.

### Act III

- **Accountable with Prepared or Strongly Prepared:** Elara relinquishes the title and protects household land, but one material claim group or fund is permanently lost. No capstone, blueprint, or relationship perk is granted for the unplayed finale.
- **Mixed default:** household obligations are cancelled and meaningful working rights transfer, while Elara retains a reduced title and private reserve.
- **Entitled or Strained:** Elara restores the house through concealed wealth or destroyed claims. She may remain through the immediate crisis only if the warned departure conflict is repaired.

Ashira may preserve burial provenance. Zafir may expose substituted title liabilities. Neither chooses whether Elara remains a lady.

## Zero-Participation Route

With no player involvement, Elara remains a **compromised survivor**:

1. Seven Mounds is scarred, its workers live with avoidable injuries, and the field antagonist escapes.
2. Virelian relief reaches Grenzburg while only part of Vardek's network is exposed.
3. Elara grants households durable working rights and cancels inherited obligations but retains a reduced title and private reserve.
4. She remains an adventurer and Blackjack colleague rather than freezing in place or dying unseen.

This default playthrough state is not future-setting canon.

## Changed Re-entry

### The Scarred Mounds

Missing the Act I finale closes its original version. During winter the player may visit the scarred site, recover remaining names, compensate injured diggers, and resume the antagonist trail. This can move `entitled` to `mixed` or `mixed` to `accountable` when Elara accepts the material remedy. It cannot restore destroyed chambers, erase injuries, recapture an escaped antagonist, or grant Fault Proven and the custom-part unlocks.

### Cabinet After Snow

Missing the Act II finale opens an Early Spring aftermath. The player may protect a surviving witness, help Elara repudiate Vardek's restoration terms, and recover partial cabinet copies. This can restore the accountable Act III path. It cannot recreate the original heist, recover lost relief or evidence, or reopen romance and sworn bond.

Missing the Act II finale permanently closes Elara's relationship commitment for that playthrough. A tracked docket must state this consequence before the player confirms the transition.

### Act III

Missing the Act III finale fixes the autonomous settlement. [[The First Honest Find]] reflects that result and cannot reopen the Hall of Petitions.

## Embedded Opportunities

Elara has exactly ten reserved embedded opportunities:

| ID | Context | Authored effect |
|---|---|---|
| EL-E01 | [[Roads Worth Saving]] | distinguishes bandit handling, Folk boundary marks, and Vardek spoil without merging the threats |
| EL-E02 | [[The City in Siege]] | guides a roof-and-crane rescue or pursuit through damaged Ledger Quays |
| EL-E03 | [[The Land Reclaimed]] | identifies which recovered records and grave goods establish living claims |
| EL-E04 | [[Bread and Burial]] | restores names without using burial duty as self-absolution |
| EL-E05 | [[Lucia's Long Book]] | separates useful logistics from ownership and debtor valuation |
| EL-E06 | [[The Names They Buried]] | matches protected-crime records to burial provenance |
| EL-E07 | Finder's Share local-story hook | argues a salvage dispute from custodian, labor, and discovery claims |
| EL-E08 | Ropehouse Ruin exploration | reads load marks and practices safe shoring |
| EL-E09 | Named Property Board | establishes a Blackjack Yard process for seized items with identifiable owners |
| EL-E10 | Abandoned Pack encounter | reacts to found property according to her current direction |

These are authored variants, not ten extra quest notes.

## Outcome Requirements

### Resolved

Elara must:

- truthfully acknowledge her role through the introduction or changed aftermath;
- place workers before proof at Seven Mounds or complete its material repair;
- refuse or repudiate Vardek's restoration;
- prioritize land or burial claims before title wealth in the Act III finale;
- have no unresolved major conflict involving destroyed claims, grave desecration, or personal seizure of claimant property.

### Compromised

Elara performs real restitution but retains a reduced title, private reserve, controlling privilege, or uncorrected hierarchy. This is stable and playable rather than disguised failure.

### Broken or Departed

Elara restores House Velescar through concealed wealth, destroys claims, accepts Vardek's patronage without repudiation, or treats the settlement as proof of her immunity. Departure requires a warned confrontation and refused repair unless it occurs through the deterministic autonomous route.

## Navigation

- [[Elara Velescar]]
- [[Elara Field Familiarity and Relationships]]
- [[Elara Delver-Duelist Package]]
- [[Elara Banter and Reactivity]]
- [[Companion Campaign Architecture]]
- [[Companion Autonomy and Act Convergence]]
- [[Companion Campaign Expansion Register]]
- [[Narrative State Register]]
- [[Companions MOC]]
