---
type: reference
status: draft
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg"]
culture: ["Eclessian", "Virelian"]
related_factions: ["Blackjack Corps", "Medori Bank", "House Velescar"]
appears_in: ["Grenzburg"]
needs:
  - execute phases 1-6 in order
tags: [narrative-design, production-control, rewrite-spec]
aliases: ["CMP-01 Rewrite Spec"]
---
# Elara Rewrite Spec

Execution spec for actioning [[Companion Critical Review - Elara and Bernard]], Elara scope. This document is the working authority for the rewrite: it locks decisions, defines every new canon element, lists every file change, and sets the verification gates. Bernard gets his own spec.

## Locked Decisions

1. **Secondary archetype: Tomboy** — Elara becomes Cheerleader-primary / Tomboy-secondary ("Athletic Social Captain" per the blended reference). Her creed: *"If I earned my place under these rules, the rules must be fair."*
2. **Notoriety: everyone knows.** From recruitment, Grenzburg knows Elara as "the grave lady" — convicted grave-robber, Medori debtor. What remains secret: this specific cargo is hers, and the patron is still operating.
3. **Structure: merge + new piece.** [[The Hands That Hold It]] is archived; its unique material folds into [[No Lady of Velescar]]'s opening movement; a new Act III operation (working title **Uninvited**) carries the cruelty and dethronement. The 11-piece lattice stays intact.
4. **Both unfairness exceptions adopted.** The Patron's Cabinet fork cannot be dissolved by preparation, and Perle's wound is permanently unrepairable. Both get explicit in-doc "intentional exception" flags so later passes don't regress them.

## The Re-Architecture in One View

The campaign's six promised beats, mapped to where they will actually live after the rewrite:

| Beat (from [[Elara Velescar]]) | Where it lands | Status |
|---|---|---|
| 1. The appeal of being chosen by Elara | Names Beneath Lime, A Splendid Little Expedition | exists — light retrofit |
| 2. Her chosen circle has a backstage | A Splendid Little Expedition (Perle omitted), A House Fed by Bones | exists — Perle seeding added |
| 3. A public loss she cannot style into victory | **Uninvited** (new) | **new — currently unstaged anywhere** |
| 4. Spending status without owning the result | The Winter Company (rehearsal), Uninvited back half (exam) | exists — reframed as rehearsal/exam pair |
| 5. Relinquishment, compromise, or restoration | No Lady of Velescar (now with hearing movement absorbed) | exists — rewritten front |
| 6. Adventure remains joyful after separation | The First Honest Find | exists — Perle/Sandro epilogue beats added |

Note the deliberate beat order 1-2-4-3-5-6: she *practices* shared power in winter, then Act III *tests* whether the practice survives losing the room. The bio's beat list gets re-ordered to match (or annotated), so the docs stop promising a sequence the campaign doesn't play.

**Campaign shape statement** (goes into the campaign doc's Dramatic Promise): Elara's silhouette is **rise–fall–rise**. Act I: her form works and the player enjoys it. Act II: her form becomes materially necessary (siege) while her name becomes a liability. Act III: the form is taken from her — partly by scandal, partly *by her own reforms working* — and she chooses who she is without the room. The cruelest engine of the dethronement is that the healthy thing she built is what makes her unnecessary.

---

# Part 1 — New Canon Elements

## 1.1 Perle Winkel (the Miss Bates)

**File:** new character note. **Role:** the person Elara's charm can actually wound.

- Yard mender and salvage-hand, mid-fifties, debtor. Talks in unstoppable, kindly, boring detail (her pigeons, a nephew's letters, the famous soup bone of 1349). Adores Elara without irony — keeps a ribbon from the Ropehouse expedition pinned to her apron, retells Elara's exploits wrongly and worshipfully.
- **Her hidden use:** she remembers everything that passes through the Yard — every object, every owner, every season. She is the Yard's unrecorded institutional memory. Nobody notices this because nobody can bear listening long enough.
- **Voice key:** run-on, associative, self-interrupting, never bitter. Comic but never witless — she always eventually arrives at a true observation, one clause too late for anyone to still be listening. After the wound: complete sentences. Short ones. That's how the player hears the damage.
- **Seeding (Act I–II):** in [[A Splendid Little Expedition]] she volunteers for the crew and Elara curates her out *with a compliment* — the shadow in miniature, inside a quest already about whom glamour excludes. She is retroactively the obvious candidate for the "record" function nobody filled. One Yard ambient scene in winter (she brings Elara mended gloves, wrong size, right love). Optional line in Without the Powder: Elara mentions Perle's adoration and, for one beat, lets the player see it makes her feel fraudulent.
- **The wound (Act III, Uninvited):** authored-fixed, all routes — see 2.2.
- **Permanence rule (locked decision 4):** `perle_state` has no restored value: `adoring → wounded → distant-kind`. No repair scene exists in any outcome. She remains decent — in Act III she still supplies her memory when the coalition needs it, which is worse for Elara than spite would be. In [[The First Honest Find]] she attends the occasion, kind and remote, ribbon gone. The Field Familiarity doc gets one line stating Perle sits outside the conflict-and-repair loop by design.
- **Player complicity:** during the joke, the room laughs and the player gets a reaction option set where laughing is the *charmingly written, socially natural* choice. `player_laughed_at_perle` changes Perle's later manner toward the player and one line of the coda. It is never announced as a test.

## 1.2 Sandro Tessari (the unresolvable local victim)

**File:** new character note. **Role:** the one person in Grenzburg Elara personally harmed, who will not perform anything.

- Crane-hand at Ledger Quays, Virelian emigrant, thirties. His mother, **Aldi Tessari**, was one of Elara's Grey Sweat diggers — recruited into an arrangement she could not safely refuse, hands and lungs scarred by burial lime (ties his body to Elara's established method: lime stabilization). She emigrated with him; she is dead or diminished (execution choice: dead — cleaner, and keeps the Remote Claims Standard's letter: he is downstream of the harm, not a returning figure from Elara's circle).
- **The inversion that defines him:** Elara — who remembers every name after one introduction — does not know his face. The diggers' children were never people she performed for. He knows hers on sight.
- **Behavior rules (fixed, all playthroughs):** refuses her coin, refuses her introductions, refuses to testify against Vardek ("not for her"), refuses to perform anger or forgiveness. Never becomes a quest. Never blocks a quest. `sandro_state` does not move.
- **Voice key:** halting, flat, unshaped. He is the anti-aphorist — the review's voice-redistribution rule made person. His one fixed exchange (mid-game, Quays, a few lines): *"I know you. — No. You don't have to do anything. I wanted you to know that I know."* Nothing sharper. He is not eloquent about power; he just doesn't move.
- **Placements (all already Quays-set, zero new locations):** silent background presence in [[Names Beneath Lime]] (watches the customs crowd from a crane platform; one flagged look); the fixed exchange between Acts II and III (or during The Winter Company's quay traffic); visible at the Frozen Quays during [[The Patron's Cabinet]]; present near the vault approach in [[No Lady of Velescar]].
- **The rolls payload (the Baru fix):** in No Lady's burial gallery, one recovered tube carries **Aldi Tessari's** name and mark among the labor/burial rolls. If the player has met Sandro, the ledger line has a face. In the resolved ending, restitution reaches him through the settlement like any claimant — and he nods and walks off. The campaign's fixed point: the best ending does not move him either.

## 1.3 Vardek: scheme, letters, and menace

**Scheme paragraph** (added to [[Lord Marek Vardek]] and echoed in [[House Velescar]]): The restoration offer is witness management. Restored under his patronage, Elara's testimony dies twice — socially (a restored lady cannot accuse her patron without destroying herself) and legally (an interested beneficiary is no witness). Her authority to "settle" household claims, exercised under debts he holds, converts his criminal exposure into a patronage asset. He is not sentimental about her; he is buying the silence of the only witness who can assemble the whole chain, at the price of a reduced house he expects to control anyway. One sentence of this must be *sayable by a player who has read the letter twice* — that is the test of legibility.

**Letter I — the restoration offer** (full prose, in-world text, ~300 words). Voice: warm, cultured, paternal, flawless manners. Never names the crime — "the unpleasantness engineered by men we both trusted." Praises her as brave, overburdened, uniquely able to make restitution "with dignity." Contains the settlement-authority clause. Written on her favorite paper (established beat — keep "He has remembered my favorite paper"). The letter must be genuinely persuasive on first read; a reader who skims should think it kind. Placement: read in the records room during [[The Patron's Cabinet]], player-readable in full.

**Letter II — the surveillance letter** (full prose, ~150 words, new). Arrives early Act III through Bellandi's ordinary mail. Congratulates her on her new life. Names things he cannot innocently know: the blue cups, Jonas Feld's clearing, the outing board, the Bridgehold wager. No threat anywhere in it. Closes: the offer remains open "until the vault opens." Menace entirely by demonstrated knowledge. This is the cheapest scene-equivalent of presence the Remote Claims Standard permits, and it makes his agents in Act III feel directed rather than ambient. Output: `vardek_second_letter_read`.

**File placement:** both letters as one in-world text note (03 Stories & In-World Texts/In-World Texts) linked from the quests, or embedded verbatim in quest bodies — executor's call, but the prose must exist in full, not as summary.

## 1.4 Household voices (de-enum the sixty-three)

New in-world text: **three or four short authenticated instruction excerpts** in distinct voices, quoted verbatim inside the No Lady hearing movement:

1. A household demanding individual title, in blunt farmer's terms with a wrong legal word used confidently.
2. A household refusing her money in plain, ugly anger — the one register the current chorus forbids its victims.
3. A household asking for specific objects back — her mother's cups, listed, with one detail misremembered. Object-grief, not principle-grief.
4. **A household that wants the house back** — misses the lady, distrusts the new arrangement, asks Elara to come home. The uncomfortable one. Relinquishing must disappoint someone real, or the resolved ending stays painless.

Voice 4 is load-bearing for the finale: the settlement scene gains a claimant whose authentic instruction *opposes* the morally resolved outcome, so "follow the households' instructions" stops being a single arrow.

## 1.5 Renames and small fixes

- **Nika Rimek → Vesna Rimek** (kills the Mika/Nika near-collision with Bernard's child). Propagate through [[Raven Shelf at Dawn]], [[The First Honest Find]], and any register that names her.
- **"Silkooks" → "Silkhooks"** in Names Beneath Lime.
- Elara bio frontmatter: add `archetype_secondary: "Tomboy"` and the creed line; check [[Companion Archetype Constitution]] and [[Companion Archetype Chemistry Matrix]] for where secondary archetypes need registering.

---

# Part 2 — Structural Surgery

## 2.1 The Hands That Hold It: merge and archive

- Move the file to 90 Archive & Drafts (do not delete; vault convention).
- **Into [[No Lady of Velescar]]'s new opening movement ("The Hearing Before the Doors"):** Bellandi's three bundles; the unedited-instructions-vs-polished-consolidation confrontation (Hanne Wirth's "read theirs with the same patience" beat survives); the substitution attempt (compressed: one attempt at the Hall of Petitions on the eve of the vault delve, not a three-delegate escort operation); delegate states simplified to Mira/Olek/Hanne present-protected-or-compromised per the Uninvited outcome.
- **Into Uninvited:** the delegates' public establishment (their presentation to Grenzburg society is the feast's civic function) and the protection-under-fire beat (agents move during the feast).
- `elara_coalition_ready` survives as the Act III prep asset; its source becomes Uninvited.
- Update every backlink (grep `[[The Hands That Hold It]]` across the vault: campaign doc, No Lady, Emotional Rewrite Audit, Expansion Register, MOCs, quest cross-navs).
- Recompute campaign duration: −1.0h (Hands) +1.0h (Uninvited) +0.25h (No Lady hearing movement) ≈ **11 hours**; update the campaign doc.

## 2.2 New piece: Uninvited (CMP-01-A3-O, Act III operation)

Working title **Uninvited** (single word, deliberately off the noun-preposition-noun cadence; alternates: *Badly Done*, *The Room Continues* — decide at execution, do not use both).

**Function:** stage beat 3 (public loss she cannot style) and the campaign's one authored act of present-tense cruelty; publicly establish and protect the coalition (prep asset); give Elara her first practice of feeding power into other hands *from the margins*.

**Premise:** Spring Reclamation. The Old Market and Yard stage the first post-siege occasion — a Reclamation Feast that doubles as the public presentation of the Velescar coalition delegates to Grenzburg civic society. Elara assumes she is hosting; occasions are her form. Two pressures converge: the winter scandal has made her a liability the guild sponsors politely route around, and the Winter Company distributed authority so well that the people she trained can run an occasion without her. **She is excluded by prudence and by her own reforms working.** Nobody wrongs her. That is the point.

**Beat structure:**

1. **Managed out.** Planning scenes: Elara is thanked, consulted, and given nothing. Her stress tell deploys on-script — ceremonial politeness escalating, speaking for other people, "improving" arrangements nobody asked her to touch. The player watches the mechanism the bio promised.
2. **The joke (authored-fixed, all routes).** At the feast, needled — a guild wife mentions the scandal within earshot; a delegate is asked whether the "grave lady" chose him — and with Perle attached to her side, loudly, lovingly, at the worst moment, Elara makes one perfectly shaped joke at Perle's expense. The joke must be genuinely funny on the page — the player should want to laugh, and gets the option to (see 1.1). The room laughs. Perle understands in stages: the worst way.
3. **The turn.** The laugh curdles. Her one cruelty confirms the liability story the sponsors were too polite to say aloud. She attempts to style it — a toast, a public generosity, a re-arrangement — and the styling *fails*, authored, the first failed performance of the campaign. The room continues without her. No one hands her a recovery.
4. **The rebuke.** Ashira, private, brief, unornamented — the Knightley beat (Ashira holds the campaign's only scalpel license; this is what it's for). If Ashira is unavailable in this playthrough state, Brina delivers a shorter, blunter variant. Draft register (final wording at scene pass): *"You made the room lighter. It was the room you wanted lighter. Not her."*
5. **The operative spine.** Mid-feast, Vardek's agents move — a staged debt seizure against Mira's wagon and a courier substitution aimed at the instruction packet (material inherited from Hands). The crisis is answered *by the network*: Winter Company teams and the delegates act on their own authority. The player fights/works the response; Elara's playable choice is whether to feed her knowledge, contacts, and status into other people's hands from the margin (accountable) or seize the visible center to win the room back (entitled — and it works socially, which is the trap; the quest must let the grab *succeed as spectacle* while quietly costing coalition readiness).
6. **Residue.** The feast succeeds. The toast is given by someone else. Perle's ribbon is off her apron. Elara says nothing styled about any of it. If the player laughed, Perle is different with them too.

**Outputs:** `elara_coalition_ready` (ready / functional / curated / broken — same values, new vehicle); `perle_state: wounded`; `player_laughed_at_perle`; `elara_dethronement_complete`; `elara_direction` movement; feast/delegate states as needed by No Lady.

**Autonomous resolution (no player):** the feast proceeds; Elara attends, is needled, commits the cruelty anyway — **the joke is hers, not the player's, in every route**; the substitution partially succeeds (coalition functional, not ready); Perle is wounded regardless. Deadline: The Deep Muster, as before.

**Pillars/format:** normal party, ~1h, social / investigation / protection / pursuit. Prep inputs: none required (operation). No new locations (Old Market, Yard, Hall of Petitions all exist).

## 2.3 The Patron's Cabinet: the undissolvable fork (locked decision 4)

Rewrite the crisis so refusing Vardek has a price preparation cannot erase:

- The offer packet now includes **signed release of the relief warrants** — restoration announced as "a gift to the city in the house's name." Accept, and both evidence and relief are secured tonight, legally, warmly, in front of everyone. The tempting option is materially superior and publicly virtuous. It must *feel* like the adult choice.
- Refuse or escrow, and Venn moves the cabinets under fire: the heist can now secure **the complete evidence set or the complete relief delivery — never both — at any preparation level.** Assets change *which* partial survives and how badly the lost half degrades (reissue paths, partial copies, fewer hungry shelters), not whether the fork exists.
- The lost half propagates visibly: relief loss = named hunger states at Winter Company stations through the rest of winter; evidence loss = specific worker liabilities unprovable in the No Lady hearing (named claims fail on screen in Act III).
- **In-doc exception flag:** "This finale intentionally breaks the three-assets-all-objectives guarantee. Do not regress." Update the campaign doc's Readiness section with the same clause.
- Everything else survives: three cabinets, approaches, Letter I read in the records room, the Neda "who saved the relief cabinet" ending beat (now conditional on the fork taken).

## 2.4 Raven Shelf at Dawn: the witness-deprivation rebuild

Keep: Highlake, the signal-line climb, the injured runner (now **Vesna** Rimek), rescue-with-real-stakes, fade-to-black, Crossed Measure upgrade, Raven Line safeguard, cutoff rules.

Change the back half: the weather front closes *behind* the rescue and forces the pair into **Blue Ice Cave overnight in all routes** (cave stops being the failure outcome; rescue quality now determines gear, injuries, and comfort inside the cave, not whether they end up there).

The cave scene is the point: no exits to arrange, no one to introduce, nothing to host. Script her archetype under deprivation — she tries to *host the cave* (arranging stones into seating, narrating tomorrow's route as an itinerary, proposing names for the expedition — the bio's "objects to sleeping before everyone has agreed what the next morning is called," played straight into a void). The performance runs out of room; the turn is the dark, and the plain voice the bio promises ("when she finally speaks plainly, the loss of polish should be noticeable"). Content: being accompanied versus being possessed (keep), plus the new center — the cave is the indifferent room she fears, survived because one witness who requires nothing turns out to be enough. Intimacy follows. Morning button: she does not name the expedition. First unnamed summit.

Swap-test target: this scene must be impossible to run for Ylva or Ashira without rewriting every beat.

[[Two Names on the Rope]] stays materially intact (strongest relationship piece she has); add the explicit contrast line to [[Elara Field Familiarity and Relationships]]: **bond = maximally witnessed intimacy (claim boards, clerks, two names in public record); romance = maximally unwitnessed (a cave, no record, no room).**

## 2.5 Names Beneath Lime: notoriety retrofit (locked decision 2)

- Koss introduces her *with* the notoriety — the famous grave lady, useful and watched; he keeps the leverage visible. Yard ambience: some debtors find her glamorous (grim comedy), Perle finds her tragic-romantic.
- `elara_first_admission` reworked: no longer "does she reveal grave-robbing" (known) but **"does she claim this cargo publicly"** — command responsibility for these objects, here, with Customs listening, versus letting the past stay generic. Values can keep their shape (full / private / evasive / refused) with redefined meanings.
- Jonas retains his anger and his "lovely speech over the cups" line (in-register); the surrounding narration stops diagnosing him ("uninterested in becoming her evidence of compassion" moves out of scene prose — his refusal is *behavior*).
- Sandro's first silent appearance (1.2). Fix Silkhooks typo.
- Winter scandal (bio, Seasonal Movement) re-specified: not exposure of the crime but **weaponization** — siege-paranoia whispers that "the grave lady still works for her patron," seeded by Vardek's agents, and half-adjacent to a truth the player knows (the offer exists). This is what makes her a liability by spring, powering Uninvited.

## 2.6 A Better Wager: give play a cost

Keep the villain-free rule. Add a specified, slightly public stake: loser carries the winner's field kit across the Old Market at midday. If Elara loses, she visibly hates it and does it in full style anyway — and one passerby's laugh lands wrong, a two-line micro-forecast of Act III she styles over *almost* successfully. Keep the pebble. Without the Powder gains the optional Perle line (1.1).

---

# Part 3 — Voice and Prose Rules

## 3.1 Voice redistribution (her quest cast)

One scalpel-speaker per campaign: **Ashira only.** Everyone else loses the therapeutic-refusal register. Per-NPC keys for the rewrite pass:

| Speaker | New voice key |
|---|---|
| Jonas Feld | Angry-flat, workman's economy; refuses by leaving, not by aphorism |
| Emri | Imperatives, counts, breaths — keeps "You may say you listened. Do not say we followed." as the campaign's one earned chorus-line (a foreman whose job is stop-authority talks like this) |
| Juta | Tally-keeper: numbers, refuses adjectives |
| Seven Mounds workers | Break the victim chorus: one defends Branka out of loyalty/fear; one wants more money, not dignity; none speaks in seminar |
| Hanne Wirth | Organizer-stubborn: repeats herself under pressure instead of sharpening |
| Mira Spoke | Fast, transactional, mid-sentence subject changes |
| Neda Volk | Established deadpan ("They hold soup") — protect it |
| Perle Winkel | See 1.1 — run-on adoration; short sentences after the wound |
| Sandro Tessari | See 1.2 — halting, unshaped, immovable |
| Sera Vann | Professional pride in clean exits; keeps a token from every completed contract (mirror-image provenance board); her vault bargain re-written to be seductive *in Elara's own register* — company language, the expedition a restored title could fund. One line: Elara's title is "bad inventory" she'd rather not carry |
| Hadrik Venn | Fussy archivist-solicitor; hates fire near paper more than he hates the party; loves documents (petty humanizing appetite) |
| Bellandi | Keeps exactly one deadpan boundary line ("not in my portfolio"); otherwise procedural-warm, never wise |

## 3.2 Prose pass checklist (apply to every Elara file touched)

- "X is not Y. It is Z." — budget **one per file**; recast the rest as direct assertion or cut.
- Delete self-grading stage directions ("The strongest scene is not a speech"; "Elara is brilliant here") — replace each with one concrete behavior that shows it.
- Kill "captured, killed in justified resistance, or escape" boilerplate; write per-quest natural consequences.
- Hide the virtue slider: option sets phrased as concrete actions, non-parallel in length and shape; sometimes three options, sometimes five; occasionally no clean "good" option. Internal states can keep their enums — the *player-facing surface* must not sort by grade.
- Emotional abstractions ("mutual delight," "magnetic under pressure") → one specific image each.
- Announce-what-it's-not disclaimers: keep at most one per file where genuinely load-bearing (metaphysics guardrails); cut the reflexive ones.
- Where the doc states the thesis and the scene then illustrates it verbatim, cut the thesis sentence and let the scene carry it (Names Beneath Lime's sorter-irony gets un-narrated: the praise happens; the locked-door fact surfaces one scene later, uncommented).

---

# Part 4 — File Manifest

Read before editing (not yet read this session): [[Lord Marek Vardek]], [[Claims-Factor Marco Bellandi]], [[Companion Campaign Expansion Register]], [[Companion Reactive Scene Register]], [[Companion Archetype Constitution]], [[Companion Archetype Chemistry Matrix]], [[Companions MOC]], Quest Library index.

**Confirmed backlink set for archiving The Hands That Hold It** (grep, this session): Narrative State Register, Grenzburg City Anchor Register, House Velescar, Lord Marek Vardek, Elara Companion Campaign, Elara Delver-Duelist Package, No Lady of Velescar, The Patron's Cabinet, Companion Campaign Expansion Register, Companion Emotional Rewrite Audit, Companions MOC — all need link updates at Phase 2. Re-grep at execution in case of drift.

**Vesna rename scope:** grep bare `Nika` (not just "Nika Rimek") — [[The First Honest Find]] references "Nika's rescue" possessively.

| # | File | Action | Core changes |
|---|---|---|---|
| 1 | Elara Velescar.md | edit | secondary archetype + creed; notoriety baseline; beat-list reorder; Perle/Sandro references; seasonal-movement scandal respec; prose pass |
| 2 | Elara Companion Campaign.md | edit | table row swap (Hands → Uninvited); duration ≈11h; readiness exception clause; coalition-asset source; autonomous-route updates; shape statement; postal fix (one packet, arrived pre-siege, Bellandi backlog = deadline) |
| 3 | Names Beneath Lime.md | edit | per 2.5; Sandro cameo; typo |
| 4 | A Splendid Little Expedition.md | edit | Perle seeded as omitted record-candidate; prose pass |
| 5 | A House Fed by Bones.md | edit | worker voice redistribution per 3.1; prose pass |
| 6 | A Better Wager.md | edit | per 2.6; prose pass |
| 7 | The Winter Company.md | light edit | scandal-liability whisper seeded; lean on existing "company without her voice" beat as dethronement foreshadow; prose pass |
| 8 | The Patron's Cabinet.md | rewrite | per 2.3; Letter I embedded; Venn texture; prose pass |
| 9 | Raven Shelf at Dawn.md | rewrite | per 2.4; Vesna rename |
| 10 | Two Names on the Rope.md | light edit | contrast line; prose pass only |
| 11 | The Hands That Hold It.md | archive | move to 90 Archive & Drafts; update all backlinks |
| 12 | No Lady of Velescar.md | rewrite | "Hearing Before the Doors" opening movement (2.1); household voices quoted (1.4); Aldi Tessari roll in burial gallery; fork-loss propagation from Cabinet; Sera texture; prose pass |
| 13 | The First Honest Find.md | edit | Perle distant-kind at the occasion; Sandro non-beat in resolved path; prose pass; (coda title unchanged — Bernard's coda gets renamed instead, in his spec) |
| 14 | Elara Banter and Reactivity.md | edit | add Perle calibration scene (pre-wound) + post-wound variant; add failure-mode: "reject any line that repairs Perle"; light touch otherwise — this file is the quality bar |
| 15 | Elara Field Familiarity and Relationships.md | edit | romance-episode description; bond/romance contrast line; Perle outside repair loop; Sandro approval-neutrality note |
| 16 | **Uninvited.md** | create | per 2.2, full quest-doc format matching vault frontmatter conventions |
| 17 | **Perle Winkel.md** | create | per 1.1 (placement: 30 Characters — folder judgment at execution, likely alongside Yard/Bank figures) |
| 18 | **Sandro Tessari.md** | create | per 1.2 |
| 19 | **Vardek letters + household instructions** | create | per 1.3/1.4, In-World Texts |
| 20 | Lord Marek Vardek.md | edit | scheme paragraph |
| 21 | House Velescar.md | edit | records chain-of-custody sentence (why the vault under Ledger Quays holds Velescar instruments: Medori removed the pledged instruments to its Grenzburg vault when it bought the surety — one sentence); pro-Elara household exists among the 63; postal timing |
| 22 | Companion Emotional Rewrite Audit.md | edit | CMP-01 rows: touched pieces flip from `cleared` to the appropriate pending state; add Uninvited row; note Hands archived |
| 23 | Registries/MOCs (Expansion Register, Reactive Scene Register, Companions MOC, Archetype Constitution/Chemistry Matrix, Quest Library) | check/edit | link hygiene; secondary-archetype registration; new-piece registration |

**Not changing (protected):** Elara Delver-Duelist Package (combat untouched); approval system mechanics; recruitment window; foil-arc autumn/winter incidents; "The house required nothing"; the blue cups, coal, and "Begin the sentence again" scenes; Without the Powder's core; The Winter Company's structure; Two Names' structure; all reward/perk mechanics and thresholds outside the flagged Cabinet exception.

---

# Part 5 — Execution Order

1. **Phase 1 — canon substrate.** Read the unread files (Part 4 header). Write: Vardek scheme, House Velescar edits, both letters, household instructions, Perle file, Sandro file, notoriety baseline in bio. *Everything else depends on these.*
2. **Phase 2 — structure.** Archive Hands (backlinks first), update campaign doc, create Uninvited skeleton, rewrite No Lady's opening movement.
3. **Phase 3 — quest passes in play order.** Names Beneath Lime → Splendid → House Fed → Better Wager → Winter Company → Patron's Cabinet → Raven Shelf / Two Names → Uninvited (full) → No Lady (full) → First Honest Find.
4. **Phase 4 — character-layer sync.** Bio beat-list, Banter file additions, Field Familiarity.
5. **Phase 5 — registry hygiene.** Audit table, registers, MOCs, link check.
6. **Phase 6 — verification** (Part 6). Fix, then flip statuses.

Phases 1–2 in one session if possible; Phase 3 can split across sessions cleanly (each quest self-contained once Phase 1–2 exist).

# Part 6 — Acceptance Criteria

- **Last-thing-on-screen test:** each rewritten piece climaxes on a person acting on a person; counts and records happen before or after, never as the peak.
- **Swap test:** Uninvited and rebuilt Raven Shelf fail for every other companion.
- **Chorus test:** read every Elara-quest NPC's lines in sequence; exactly one scalpel-speaker (Ashira), plus Emri's single retained line.
- **Slider test:** an uninvolved reader shown any option set cannot rank it by virtue from shape alone.
- **Beat map:** the six-beat table in this spec maps 1:1 to authored scenes; beat 3 exists.
- **Unfairness flags:** both exceptions carry in-doc do-not-regress notes; Perle has no repair path in any file; Cabinet fork survives at five assets.
- **Blind voice test** (per [[Companion Dialogue and Scene Standard]]) on all new/rewritten dialogue, including Perle pre/post-wound as *two* identifiable registers.
- **Tell budget:** ≤1 "X is not Y. It is Z." per file; zero self-grading; zero "justified resistance"; Silkhooks and Vesna propagated; `[[ ]]` link integrity across the vault.
- **Constitution compliance:** 11 pieces, formats intact, friendship still reaches the strongest outcome, Remote Claims Standard unbroken (Sandro is downstream kin, Letter II arrives by mail).

## Navigation

- [[Companion Critical Review - Elara and Bernard]]
- [[Elara Velescar]] · [[Elara Companion Campaign]]
- [[Companion Dialogue and Scene Standard]] · [[Companion Emotional Rewrite Audit]]
- [[Companions MOC]]
