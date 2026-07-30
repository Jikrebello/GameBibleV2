---
type: reference
status: draft
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Korrheim", "Grenz Lowlands", "Frostfenn March"]
culture: ["Eclessian", "Korrheim"]
related_factions: ["Blackjack Corps", "Medori Bank", "Low Lanterns"]
appears_in: ["Grenzburg"]
needs: []
aliases: ["CMP-06 Campaign"]
tags: [production-control, narrative-rewrite]
companion_id: "CMP-06"
architecture_status: migrated
emotional_rewrite_status: cleared
dialogue_status: pending-rewrite
remote_claim_status: compliant
---
# Dismas Companion Campaign

Controlling authority for Dismas Raben's eleven authored pieces, ten-piece playthrough ceiling, preparation ladders, deadlines, deterministic autonomy, changed re-entry, progression, and outcomes.

[[Dismas Raben]] controls character. [[Dismas Field Familiarity and Relationships]] controls approval and intimacy. [[Dismas Quarry-Wise Package]] controls combat. Built per [[Dismas Rewrite Spec]]; replaces the archived four-quest outline.

## Dramatic Promise

Dismas knows which fence is decorative, which guard is bored, and which road law was written because one rich man lost a wagon twenty years ago. He will get your family out tonight and make it funny.

His danger is not that the exits are fake. They work. It is that he is gone before the second night, and the people standing in the doorway he opened inherit whatever comes down the street afterward.

The campaign lets the player enjoy the accomplice before it shows them the bill:

1. a caper that works completely, and a neighbour who watches from a window;
2. the reprisal, at somebody else's door;
3. a woman who has priced his kind of freedom and wins the argument;
4. the body remembering a sound it has not made peace with;
5. a passage that is thrilling to open and tedious to keep;
6. the truth of 1355, which nobody is looking for and only he can file;
7. a promise made twice, on purpose, to one person;
8. a network that must survive its founder being bored;
9. a road he answers three times because nobody can make him answer once.

## Campaign Shape

**The door stays open, and he keeps not leaving.**

Every act ends with a clean, visible, genuinely takeable exit that he does not take. No oath, rank, cell, or good commander ever contains him — a contained Rebel proves nothing, and the vault's own failure-mode list forbids resolving him beneath a benevolent authority. The resolved ending is **uncontained return.**

The gesture-spine is **counting**, and it fires exactly four times:

| Beat | Piece | What he counts |
|---|---|---|
| 1 | [[The Easy Ambush]] | voices, involuntarily, when stone shifts above a road |
| 2 | [[No Railing]] | chimneys in a hamlet that exists because of him |
| 3 | [[The Name on the Charge]] | the dead, out loud, to the end, once |
| 4 | [[Tuesday]] · [[Passing Through Slowly]] | the network's living |

**The missing queen** — the card kept out of every game, his route-marker and his held-back self — also holds a four-beat budget: the unsigned exit, a route-mark the player learns to read, the bond rite where he gives it away, and (resolved) the first complete hand of the campaign.

## Formal Campaign

| Seq. | ID | Piece | Format | Function |
|---:|---|---|---|---|
| 1 | CMP-06-I | [[The Decorative Fence]] | normal party | a caper that works, and the neighbour at the window |
| 2 | CMP-06-A1-O | [[The First Mile]] | normal party | the aftermath he cannot extract anyone from; the carter who is right |
| 3 | CMP-06-A1-F | [[The Easy Ambush]] | duo | reversible traps, civilian traffic, the freeze, and the dangerous cleanup |
| 4 | CMP-06-FR | [[No Railing]] | one-on-one | an impossible view, cards, breakfast, and a count that comes out right |
| 5 | CMP-06-A2-O | [[Passage]] | normal party | an underways artery, three weeks of maintenance, and Koss's leash |
| 6 | CMP-06-A2-F | [[The Name on the Charge]] | duo | he opens the case against himself, past three clean exits |
| 7 | CMP-06-RM | [[The Return Leg]] | female romance | a route chosen twice, and every exit shown |
| 7 | CMP-06-BD | [[The Missing Queen]] | male bond | a route cut for no one's enemy, and the card given away |
| 8 | CMP-06-A3-O | [[Tuesday]] | normal party | the network's first boring week; peace as a container |
| 9 | CMP-06-A3-F | [[The Road That Answers]] | duo | three legs, three renewals, three real chances to go |
| 10 | CMP-06-S | [[Passing Through Slowly]] | normal party/changed | the bedroll under the old bunk, and a complete deck |

Only the three act finales use the fixed player-plus-Dismas duo. Romance and bond are mutually exclusive. **Friendship alone reaches his strongest moral outcome** and every non-relationship reward.

Estimated first-play duration: approximately **10.5 hours.**

## Direction

`dismas_direction` changes only through named conduct:

- **returning:** he chooses commitments, renews them, and stays inside an aftermath he could leave;
- **held:** he does the work, but only under supervision, leverage, or somebody else's insistence — the compromised middle, and the one the world finds most convenient;
- **gone:** he conceals, exits before a promise can form, or accepts somebody else's offer to carry what he did.

`dismas_legal_debt_state` follows [[Companion Debt and Remote Claims Standard]]. [[Claims-Factor Marco Bellandi]] can retrieve the Korrheim registry, file an enlarged truth, and administer restitution. **He cannot compel the filing and nobody else can either** — no warrant exists for the deaths, and this is the campaign's central fact.

## The Fixed Truth

Per [[The Korrheim Rockfall]], and flagged **do not regress:**

- two named people died, one of them not at once;
- Sella Etten survived because of the soldiers he fled;
- **the counterfactual is permanently unavailable.** No playthrough discovers that nobody died, and none earns the comfort of "they were doomed anyway."

His unfairness exception is that **the truth cannot be prepared into kindness.** Preparation improves what the filing accomplishes; it never softens what it finds.

## Preparation

Two assets permit player participation in a finale. Three make every material objective achievable. Four or five add one safeguard. No asset requires a faction, relationship, temperament, or vocation.

### Act I

| State | Source | Finale use |
|---|---|---|
| `dismas_fence_route_kept` | [[The Decorative Fence]] | the roofline and the decorative gap remain usable under pressure |
| `dismas_lask_repair_begun` | [[The First Mile]] | Old Market witnesses will speak for a Blackjack |
| `dismas_ravine_civilian_timing` | Lowlands road work | reveals the wood train's schedule before the ambush is set |
| `dismas_reversible_trap_stock` | Yard or Low Lantern supply | every device can be disarmed in the dark |
| `dismas_marcher_stop_right` | [[Holdfast Without Orders]] or Liese's support | a named authority can abort the ambush without a court |

### Act II

| State | Source | Finale use |
|---|---|---|
| `dismas_passage_handoffs` | [[Passage]] | trained volunteers hold the route while he is elsewhere |
| `dismas_korrheim_registry_open` | Bellandi review | the old claim and the estate entries can be retrieved |
| `dismas_route_notation_surrendered` | personal choice | his own marks become admissible evidence against him |
| `dismas_low_lantern_terms` | [[Mara Senn]]'s handoff rules | brokers cannot bury the inquiry as a favour |
| `dismas_lask_task_kept` | ambient follow-through | one household will stand surety for his character |

### Act III

| State | Source | Finale use |
|---|---|---|
| `dismas_guide_network_charter` | [[Tuesday]] | the network runs a week without him and can be handed over |
| `dismas_fen_route_marked` | Frostfenn exploration | a third exit exists at Three Horn |
| `dismas_local_guides_trained` | spring road work | somebody else can lead a group out |
| `dismas_depot_manifest_read` | [[The Land Reclaimed]] or depot work | civilian numbers are known before the column arrives |
| `dismas_residue_pattern_sampled` | main campaign | the dead march's road-logic can be spoiled rather than fought |

`dismas_return_leg_practiced` from [[The Return Leg]] and `dismas_missing_queen_given` from [[The Missing Queen]] are mutually exclusive, equivalent safeguards outside the threshold. Either prevents one extraction or exhaustion failure at Three Horn. Neither decides whether he stays.

## Deadlines and Autonomy

| Deadline | Intended action |
|---|---|
| commitment to [[The Last Convoy]] | Dismas sets the Split Pine ambush with whatever timing he has |
| commitment to [[Ghor at the Gate]] | Dismas holds the underways passage himself rather than handing it over |
| commitment to [[The Deep Muster Main Quest]] | Dismas goes to Three Horn Depot |

Tracked dockets show readiness and closures. Untracked plans stay discoverable through the Yard route board, Old Market talk, Mara's handoff slate, and Dismas's own conversations.

### Zero-participation route

- **Act I:** he recovers the Lasks late and by extraction rather than repair; the reprisal stands; the licence is lost for a season.
- **Act I finale:** he springs the ambush, the medicine is recovered, the wood train takes two injuries, and he accepts the lieutenant's offer to leave the civilians out of the report.
- **Act II:** he runs the passage brilliantly and alone until Koss exercises the contract, then cedes the map rather than argue. **He never files.** The Korrheim registry stays closed and the count is never made — the saddest stable state in the roster, and the one the world is perfectly content with.
- **Act III:** he secures the military withdrawal, the civilians reach Fenn Road Exchange late and lighter, and he takes a sealed specialist commission.
- He becomes a **supervised marcher scout**: useful, unowned on paper, and slightly caged, which he names himself.

He cannot die autonomously. Returning direction and three assets improve autonomous conduct while preserving material losses; `gone` direction worsens trust and casualties without inventing a random death.

[[Ilyana Veshkar]] may turn a passage into a public route in Act II ⟨PAIR⟩. [[Bernard Valeon]] may hold a shelter at Three Horn. [[Ylva Winter-Track]] may mark a fen lane. **Nobody files his charge, keeps his appointments, or stays in his place.**

## Changed Re-entry

**The Neighbour's Bill** — missing Act I opens a winter Old Market aftermath: the licence review can still be contested, Girel's record cleared, and the stall reopened at greater cost. It cannot restore the season's earnings or the Act I reward.

**The Unfiled Charge** — missing Act II opens a spring registry aftermath. Bellandi can still retrieve Korrheim, and Dismas can still file, but the Act II finale's rewards, the relationship commitment, and the Quarry-Wise capstone stay closed for that playthrough. The docket states this before confirmation.

Missing Act III fixes his autonomous settlement. [[Passing Through Slowly]] reflects it rather than reopening it.

## Progression

| Stage | Reward |
|---|---|
| introduction | **Read the Hinge** — unsafe fastenings, false walls, and bored sentries surface as interactable |
| Act I finale | **Reversible Line** — traps he sets can be disarmed by anyone, including under fire |
| friendship | **Follow the Queen** — his route marks become readable by the player anywhere in the world |
| Act II finale | Quarry-Wise custom-vocation unlock; relationship commitment |
| Act III operation | **Somebody Else's Road** — trained guides act on their own initiative in escort scenes |
| Act III finale | **No One Behind** capstone and the Quarry-Wise blueprint on resolved or compromised outcomes |

Romance grants **Second Journey**, upgraded by [[The Return Leg]], and permanent non-slot perk **No Escape Route.**
Bond grants **Called Back**, upgraded by [[The Missing Queen]], and permanent non-slot perk **No Blind Turn.**

## Embedded Opportunities

1. a predatory checkpoint in [[Roads Worth Saving]];
2. captive handling and prisoner exits in [[The City in Siege]];
3. reprisal risk in [[Holdfast Without Orders]];
4. the Yard's worst exit routes, quietly repaired and loudly denied;
5. a Low Lantern client abandoned mid-route by somebody else;
6. Koss's requisition of a smuggling map in [[The Equipment Account]];
7. an Old Market stall inspection where the writ is technically valid;
8. a Frostfenn fen crossing nobody has marked;
9. the route board, and whether his name goes on it;
10. **The Second Night** — a one-shot encounter with people he moved a season ago.

## Outcomes

**Resolved:** he files the enlarged truth unprompted, keeps the Lask appointments, hands the network its charter, and stays through all three legs at Three Horn. He becomes a free road protector — unowned, uncommissioned, and answerable to a route rather than an office.

**Compromised:** real protection under supervision. He accepts a marcher commission, a Blackjack rank, or somebody else's insistence as the thing that makes him reliable, and he can name that arrangement as useful and insufficient.

**Broken/departed:** he lets the cofounder carry it, weaponizes a route against a client, abandons the depot under cover of battle, or becomes the network's toll. After a warned confrontation and one repair chance, he goes.

**Heroic but unresolved sacrifice:** available only at Three Horn, after all three exits have visibly failed or been spent, with explicit confirmation. It saves the last group and is not his strongest resolution.

No result becomes future-setting canon.

## Navigation

- [[Dismas Raben]] · [[Dismas Field Familiarity and Relationships]] · [[Dismas Quarry-Wise Package]]
- [[The Korrheim Rockfall]] · [[Sella Etten]] · [[The Stonefall Papers]]
- [[The Lask Household]] · [[Mette Harrow]]
- [[Companion Debt and Remote Claims Standard]] · [[Companion Campaign Expansion Register]] · [[Narrative State Register]]
- [[Companions MOC]]
