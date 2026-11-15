---
type: reference
status: draft
canon_level: core
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg"]
culture: []
related_factions: []
appears_in: ["Grenzburg"]
needs: [creator-decision]
tags: [causality-pass, audit, grenzburg]
---
# Causality Pass — 14F Audit: The Grenzburg Cast, Acts and Faction Questlines

> [!note] Status — 15 November 2026
> Detail for [[Causality Pass - 14 Grenzburg and Companions Audit]]. This is the auditor's report as written, before any fix. **The fixes were applied later the same day;** record 14 says what was done under "What was fixed". Line numbers and quotations are from the files as they stood at commit `c5add80`. Paths beginning `CMP-`, `C10`, `PH` and the like are short forms for folders under `02 Playable Settings/Grenzburg/`; each report explains its own.

Read-only audit, 15 November 2026. Nothing in the vault was changed.

Paths are shortened as follows. **G/** is `02 Playable Settings/Grenzburg/`. **C/** is `01 Canon Reference/`. **LR** is `00 Start Here/Current Focus Board.md`, section "Locked Rulings". Line numbers are file line numbers.

Overall result: the slice contains **no stale names and no stale dates** from the rename and anchor-date lists. The only year it cites is 1349. The disagreements are of other kinds: one rule about the Grobi that canon changed in September, a church line written as if the Accord had never happened, a handful of names and compass points, and several places where the acts and questlines disagree with each other.

---

## Characters

### What this material leans on

- The ducal house and its seat — LR l.60.
- The mirrored map (Eclessia east of Thalmyria; south is cold) — LR l.59; `C/Geography/Gazetteer of the Known World.md`.
- The Medori, the Debtors' Corps and the Blackjacks — `C/Peoples and Cultures/Sestaran Concord/60 Realms and Peoples/Grand Duchy of Fiorenzia/` (Medori Bank, Medori family Overview, Debtors' Corps); `C/History/70 Later History and Present Day/Present-Day Courts and Crowns (1360 AR).md`.
- The old Church after 1343: bishops, relic courts, chartered orders, the Order of the Lantern — `C/Peoples and Cultures/Eclessia/20 Faith and Worldview/Eclessian Church Overview.md`; `C/Peoples and Cultures/Eclessia/50 Economy and Warfare/Eclessian Military Orders.md`; `C/History/70 Later History and Present Day/The Korrheim Accord.md`.
- Folk clans, the Bent Oak house, the Lakekeepers and Wolfsmere — `C/Peoples and Cultures/Folk/30 Society and Daily Life/The Folk of the Frontier and the Wolfsmere Lineage.md`; `…/Chapel-Folk.md`; `C/Peoples and Cultures/Folk/10 Foundations/Folk Canon Register.md`.
- The nature of the Grobi — `C/Creatures/30 Shadowlands and Idols/20 Wrath/10 Grobi/Grobi Overview.md`, `Grobi History and Pack Life.md`, `Hobgoblins.md`; `C/Cosmology/20 Realms and Soul-Routes/The Image, Soul, and Creaturely Continuity.md`.
- Gerhold, the Muster and the General Below — `C/History/20 Prehistory/The Unending Muster.md`; `C/Creatures/70 Hell and Abyss/50 Abyssal Wounds and Dragons/The General Below.md`.
- The Sestaran cities — LR l.68; `…/The Grand Duchy of Fiorenzia Overview.md`.

### Findings

| ID | Where | What the game says | What canon says | Type | Sev. | Suggested change |
|---|---|---|---|---|---|---|
| C-01 | G/30 Characters/60 Personal Histories/Ghor-Maw.md l.44 (also l.25) | "Ghor has full moral agency"; conquest, "hostage-taking… or slavery" are not "necessary" | Grobi Overview l.17 `moral_agency: none`; l.30 "possess neither the Image nor a human moral conscience"; l.78 "Grobi do not maintain humans as permanent household slaves". Image, Soul l.49 "no human moral conscience". Canon changed on 15 September 2026; the Ghor file is from July. Skrit's file (l.25–27) already follows the new rule, so the two Grobi files disagree with each other | Contradiction | A | Recast Ghor as a chief with full tactical choice and no moral conscience; drop "slavery" (captives are provisions) |
| C-02 | G/30 Characters/20 Ducal and Civil/Duke Alaric von Grenzburg.md l.23 (title and file name); Characters MOC l.39 | "Duke Alaric von Grenzburg" | LR l.60 "The ducal family is **von Grenzmark**; the seat and duchy are **Grenzburg**" | Stale name (Locked Ruling) | B | Retitle to "Duke Alaric von Grenzmark"; keep the old form as an alias (the alias list at l.12 already has the right name) |
| C-03 | G/30 Characters/50 Bank and Underworld/Ledger-Master Lucia Medori.md l.27; Claims-Factor Marco Bellandi.md l.30 | Lucia is "the Medori ledger-master responsible for Grenzburg"; Bellandi a "Fiorenzian claims-factor assigned beneath" her | Courts and Crowns l.96 "Factors Gianni and Livia active in Grenzburg". Medori family Overview l.27–31 lists Gaius, Valeria, Matteo, Fabrizio, Isabella and no Lucia. (Medori Bank l.47 does link to Lucia.) | Contradiction | B | Choose one cast. Either correct the Courts and Crowns line to Lucia and Bellandi, or seat Gianni and Livia in the game |
| C-04 | G/30 Characters/30 Church/Deacon Ignatius.md l.9, l.27 | "Ashen Commandery"; "militant protection and investigation" | Eclessian Military Orders l.20–42 names six chartered orders; none is this. l.26: the Council "placed their supernatural investigations under Lantern review in 1324" (the Malveris inquisitors). l.30: the Avelines "defend the southern marches". Freeflame Reformation l.70: "Their enemies called them the Ashenmen" | Unsupported | B | Place Ignatius in a chartered order (an Aveline chapter fits his arc) or say the Commandery is a diocesan body; reconsider "Ashen", which canon gives to the Freeflame miners |
| C-05 | G/30 Characters/60 Personal Histories/Magister Leviticus of Sestaren.md l.23, l.25 | "of Sestaren"; "Sermoran-trained" | No "Sestaren" exists in canon. LR l.68: seven named cities; "'Sestaran' is secondary to city identity" | Unsupported | B | "Magister Leviticus of Sermora" |
| C-06 | G/30 Characters/40 Folk/Lenka Vrana.md l.31 | "Lenka and her sister came west for wages" (Kedrava to Grenzburg) | LR l.59 "Eclessia sits east of Thalmyria"; Gazetteer l.37 Kedrava is the empire's "western and southwestern outer coast" | Contradiction (Locked Ruling) | C | "came east" |
| C-07 | G/30 Characters/50 Bank and Underworld/Perle Winkel.md l.29 | "her nephew's letters from the Fiorenzian coast" | Fiorenzia Overview l.17 "Fiorenzia is an inland highland duchy" | Contradiction | C | "from the Fiorenzian hills", or a Sermoran port |
| C-08 | G/30 Characters/40 Folk/Thorn-Seer Mael.md l.35 | "He controls no compact seat by himself" | Folk of the Frontier l.36 "the Thorn-Seer's unifying authority across clans and the 'prophetic opportunism' the faction notes describe" | Contradiction (canon describes an older Mael) | C | Bring the two into line; the canon sentence is probably the stale one |
| C-09 | G/30 Characters/30 Church/Bishop-Prelate Caestus.md l.23, l.27 | "Bishop-Prelate… the diocese's pastoral prelate… under Konrad" | Church Overview l.25 "Bishops supervise dioceses"; canon has no "Bishop-Prelate" and no second bishop inside a see | Unsupported | C | Say what the rank is (auxiliary, provost, hospital prelate) or retitle |
| C-10 | G/30 Characters/30 Church/ (all four notes) | Bishop, Bishop-Prelate, Deacon, Sister | `C/History/10 Chronology and Control/Real-History Concordance.md` l.223 "Grenzburg's Bishop/Inquisitor/Reliquarian triangle" | Stale (one side) | C | Update whichever is out of date; the game has neither an Inquisitor nor a Reliquarian |

### Checked and holds

- Mael as "a Lakekeeper-line seer" who "neither worships the lake" (Mael l.27, l.31) — LR l.61; Folk of the Frontier l.34 "The Lakekeepers do not worship what is in the lake".
- Elof as a Chapel-Folk "reader" (Elof l.27) — Chapel-Folk l.36 "household readers"; l.49 "Elof's Grenzburg communities".
- Moss-Crown, River-Clans, Ghost-Foot, Shattered-Tusk and Chapel-Folk as frontier groups — Folk of the Frontier l.20.
- Koss as a "Bank-appointed commander" (Koss l.27) — Debtors' Corps l.22 "named provosts and company captains"; l.20 "the Blackjack Corps employed in Grenzburg".
- Bellandi's insistence on finite, evidenced claims (Bellandi l.46–53) — Debtors' Corps l.26 "states the principal, permitted charges… term ceiling… discharge conditions".
- Koss has "no… secret Left Hand function" (Koss l.31); Debtors' Corps l.22 "rather than a hidden supreme Collector".
- Gerhold "neither causes the awakening" and gets no redemption (Gerhold l.27, l.31) — Unending Muster l.52–54, l.64; LR l.90.
- Leviticus is "not the winter betrayer" (Leviticus l.29) — LR l.89.
- Skrit "understands restraint, exchange, fear, appetite, and reputation" (Skrit l.27) — Grobi Overview l.44.
- "Order of the Long Watch" (Companion Constitution l.9) — `C/Peoples and Cultures/Thalmyric Empire/20 Faith and Worldview/Church-Military Unity.md` l.41.
- Ivo Renn, the game character, is a different man from the renamed Father Ivo; not flagged.
- No renamed historical name and no moved date appears in any character note in this slice.

### Open questions for the creator

1. **Perle's dates** (Perle Winkel l.29, l.72). "The soup bone of 1349" now shares its year with the Medori being made hereditary dukes and Severin's death. "Before the fever year" has no canon referent in her lifetime; the Grey Sweat ended in 1247. Is a local fever meant?
2. **Perle and Vey** (Perle Winkel l.33). She quotes "Oskar" deciding what went into the Yard's common box. Oskar Vey is the Watch-Captain. Was he once a Blackjack officer, or is this another Vey?
3. **Karel's refuge bells** (Karel Reed-Hand l.30, l.41, l.55). The march charters "forbade any bell within hearing of Wolfsmere" (Chapel-Folk l.20). Longlake borders Wolfsmere. Where does the Chapel-Folk bell line stop?
4. **Marcellina** (l.27) runs church intelligence from the Chancery. Canon gives that work to the Order of the Lantern (Church Overview l.29). Is she a Lantern, a rival to it, or under its review?
5. **"Low Lanterns" and "Lantern Ward".** In canon "the Lantern" is now the chartered order of night-singers. Is the echo wanted?
6. **Alaric and Alric.** The 1360 board has "Grand Duke Alric IV von Caldria" (Courts and Crowns l.43). Is the near-match with Duke Alaric acceptable?

---

## Acts and campaign controls

Covers the Main Campaign MOC, the eight control notes, the five act overviews, the twenty-three chapter notes, and the standards at the root of `50 Campaign/Companions/`.

### What this material leans on

- The fixed spine and its fixed results — LR l.84, l.89–91, l.94, l.96.
- The Grobi as a people, their stages, signals and captives — Grobi Overview; Grobi History and Pack Life; Hobgoblins; `C/Peoples and Cultures/Folk/50 Economy and Warfare/Frost-Road and the Winter War.md`.
- The Emerald Drake as a non-sapient court animal with a law-gem — `C/Creatures/20 Faewild and Menhir/10 Drakes/Emerald Drakes.md`; `Drakes Overview.md`.
- Qianglong, the Unending Muster, its five anchors and first closure — Unending Muster; `C/History/20 Prehistory/The Empire of Qianglong.md`; `C/Creatures/80 Ancient and Crafted Legacies/20 Giant Legacies/10 Qianglong/Qianglong Caste Recurrences.md`.
- The General Below as a true dragon — General Below; `True Dragons.md`.
- Residue against souls; Medium imprints — `C/Creatures/10 Material and Residue/The Mundane Layer — Residue, Vermin, and the Delver Trade.md`; LR l.88.
- White Flame and warlock script — `C/Magic & Systems/20 Sacred and Restorative Magic/White Flame Doctrine.md`; `C/Peoples and Cultures/Eclessia/50 Economy and Warfare/Military and Warfare Overview.md`.
- The Eclessian year — `C/Peoples and Cultures/Eclessia/30 Society and Daily Life/Eclessian Daily Life and the Year of the Flame.md`.
- The game's own geography and season windows (used only to test the acts against themselves) — `G/20 Region and Locations/Grenzburg Regional Geography.md`; `…/10 Grenz Lowlands/Grenz Lowlands.md`; `Season and World-State Constitution.md`.

### Findings

| ID | Where | What the game says | What canon says | Type | Sev. | Suggested change |
|---|---|---|---|---|---|---|
| A-01 | G/50 Campaign/00 Main Campaign Controls/Grenzburg Campaign Spine.md l.121; Grobi Host Fragmentation Matrix.md l.17; Acts/ACT II WINTER'S TEETH.md l.43; Acts/20 Act II/Ghor at the Gate.md l.77; The City in Siege.md l.95 | "Specific Folk and Grobi groups retain distinct responsibility"; "His culpability"; "Ghor knowingly chooses conquest"; "does not absolve the chosen assault" | Grobi Overview l.17, l.30, l.44: tactical choices "do not include a moral apprehension of mercy, justice or another creature's dignity". Frost-Road l.34 puts the duty on the humans: cruelty and broken truce "degrade the people committing those acts" | Contradiction | A | Keep "bands differ; no collective punishment", but ground it in what humans owe, and in bands' differing interests, not in Grobi guilt |
| A-02 | Acts/20 Act II/Break the Southern Horn.md l.47; The City in Siege.md l.56; Acts/10 Act I/Fort Tannbruck Main Quest.md l.69; The Southbound Muster.md l.81; Tannbruck Falls.md l.65 | "a frame of hide, horn, and captured signal metal"; "hobgoblin horn-team"; "horn-token"; "Horn-Captain Ruk" | Grobi History l.77 "Drums carried signals farther and more reliably… drum law developed around authorised patterns"; Hobgoblins l.37 "They use drums, ash marks, trophy records" | Contradiction | B | Make the everyday signals drums. If the Southern Horn stays, say it is Ghor's break with drum law, which would explain why rival chiefs resent it |
| A-03 | Break the Southern Horn.md l.65, l.96; Ghor at the Gate.md l.95 | "raid his ledgers"; "Captured horn schedules" | Grobi History l.23 "the absence of writing did not make its commanders stupid"; Hobgoblins l.59 "ration tallies" | Contradiction | C | "tallies", "knot-cords" or "ash marks" for Grobi records; charts as drawings are fine |
| A-04 | Acts/00 Prologue/The Black Road Main Quest.md l.43 | "a northbound debtor convoy" | Same note l.85: camp "north of Funnel Camp". Grenz Lowlands l.26: the Lowlands lie "north of Grenzburg". Regional Geography l.123: "Prologue: northern road to Grenzburg" | Internal | C | "southbound" |
| A-05 | Acts/10 Act I/The Closing Roads.md l.47 | "the mills cannot send flour north and Grenzburg must begin drawing reserve grain" | Grenz Lowlands l.32: "Grenzburg's walls on the southern horizon". Three Mills is in the Lowlands | Internal | C | "south" |
| A-06 | Acts/The First Summer Road.md l.51 | "Every version leaves Grenzburg through the Grenz Lowlands", past Funnel Camp and the Black Road; the four corridors then run south, west and east | Regional Geography l.36: the "settled northern fan narrows into three southern military approaches" | Internal | B | Have the convoy muster at the Funnel and return through the city, or drop the Lowlands leg for the southern corridors |
| A-07 | Acts/10 Act I/The Last Convoy.md l.43, l.57, l.71, l.77; Tannbruck Falls.md l.81 | Households are "pulled north"; routes are assigned "At Tann Crossing Farms"; columns "converge outside Fort Tannbruck"; one route runs "between Lakewatch and the north road". The withdrawal north from the fort then passes "Tann Crossing Farms" again | Regional Geography l.89: Longlake lies "west of the city and Lowlands"; l.107: Fort Tannbruck is on the Upper Grenz supply corridor, south of the city | Internal | B | Fix where the farms stand and which way the columns move. If the farms are north of the fort, the columns travel south, not north; if south, the withdrawal cannot pass them. A Lakewatch route cannot join either |
| A-08 | Acts/10 Act I/Fort Tannbruck Main Quest.md l.114 against Acts/ACT I THE CLOSING ROADS.md l.45 and The Southbound Muster.md l.125 | "Completion opens **Open Autumn**" (MQ-05); "Open Autumn begins with the Southbound Muster" (overview); MQ-04 "does not advance the season" | Season Constitution l.49: Open Autumn runs from The Southbound Muster | Internal | B | Pick MQ-04 or MQ-05 as the start. Ylva's recruitment and five faction windows hang on it |
| A-09 | 00 Main Campaign Controls/Grenzburg Chapter and Window Matrix.md l.43, l.45 against Acts/20 Act II/The Emerald Trail.md l.43, Winter's Teeth.md l.81, The City in Siege.md l.138 | Matrix: MQ-11 requires MQ-10; MQ-13 requires MQ-10. Notes: the Trail "can be pursued before or after MQ-10"; the two "open in parallel"; Knives opens "after MQ-11 is completed" | — | Internal | B | Make the matrix and the three chapter notes state one rule each for MQ-11 and MQ-13 |
| A-10 | Acts/30 Act III/The Open Thaw.md l.43 | "soldiers dead for centuries" | Empire of Qianglong l.6 `era: c. 3400–2260 BR`; Chronology l.31 puts the Muster in "c. 2400–2300 BR" | Stale date (understated span) | C | "dead for thousands of years" |
| A-11 | G/50 Campaign/Companions/Companions MOC.md l.59–139 | Windows named "Siege Winter", "Winter Siege", "Late Winter", "Spring Reclamation", "Open Thaw", "Before Deep Muster", "Playable Summer" | Season Constitution l.47–55 has Early, Open and Late Autumn; Early and Deep Winter; Early and Open Spring; Muster Crisis | Internal | C | Use the nine window names the campaign controls use |

### Checked and holds

- The chapter list, order and fixed results in the MOC, Spine, Matrix and overviews match LR l.89–90 exactly, and match Unending Muster l.52–56 and General Below l.69–87.
- The five anchors and "three must be destroyed" — General Below l.69; Unending Muster l.56. Names are identical in all files.
- The first closure in the Campaign Archive (The Deep Muster l.67: "coerced auxiliaries and laborers broke relay links while defecting keepers buried the deepest command hall") — Unending Muster l.40, nearly word for word.
- "Muster soldiers are corpse residue… not routed human souls" — Unending Muster l.60–61; Mundane Layer l.44.
- The General Below as "a sovereign Abyssal true dragon", "neither a drake nor a biological species"; its avatar of eel coil, lamprey mouth and crab armour — General Below l.31, l.75; Drakes Overview l.18.
- The Emerald Drake: animal mind, cannot speak or bargain, law-gem persists after death, countered by clean wind, controlled fire, sealed breathing gear and cross-cut paths — Emerald Drakes l.17–18, l.51–53; Drakes Overview l.35. Canon l.57 also agrees that no drake material is "a required key to the Deep Muster".
- Church custody of the gem as "explicitly not a saint's relic" — Emerald Drakes l.61 "Clergy debate consecration and safe custody".
- Grobi stages ("goblins loot and infiltrate, hobgoblins coordinate, orcs lead shock groups, and larger forms attack structures") — Grobi Overview l.52–58.
- Grobi carrying off a wounded carter; captives recoverable, not enslaved, in the acts themselves — Grobi Overview l.78.
- Ghor's host failing when its coordination breaks, and a chief whose crown rivals will not die for — Grobi Overview l.66, l.86 (Gharuk Eight-Bowls).
- Surrendering Grobi, exchange and bounded withdrawal — Frost-Road l.34.
- The "Atherian road gallery" and reused Atherian stone — Folk Canon Register l.52 "the imperial frontier forts".
- Ducal "Warlock Hall" and licensed assessors — Military and Warfare Overview l.49 "Old-Church authorities demand licensed warlocks".
- White-Flame release as one way to destroy the altar — General Below l.81.
- The outsider debtor under ducal warrant; Bank pressure selective (Spine l.21–23; Warrant at the Gate l.67, l.73) — LR l.84.
- Party of the player plus three; three-companion prologue; recruitment windows; eleven pieces, ten playable, seventy-four across a run (Companion Constitution l.33, l.58; Companions MOC l.17, l.34–43) — LR l.91.
- Medium imprints, Binder limits, bounded Shellcraft (Companion Constitution l.108–111) — LR l.88.
- The thaw of 1360 (Unending Muster l.52). The Eclessian year ends in Thawwait, "the mud month" (Year of the Flame l.33), so a campaign that opens in autumn 1360 reaches the thaw inside 1360.
- Companion standards at the root of `Companions/`: no other statement about the wider world was found.

### Open questions for the creator

1. **Which year is Act III?** The year turns at Bindingtide, straight after Thawwait. Spring reclamation and the summer aftermath therefore fall in 1361, while canon calls 1360 "Grenzburg's crisis year" (Chronology l.344). Is that intended?
2. **The Southern Horn.** Would you rather replace it with a drum, or keep it as Ghor's deliberate break with drum law (A-02)?
3. **Grobi boats and trade.** Skiv's "flotilla", "trader-captains" and "boats" (Break the Southern Horn l.65) go beyond canon's barter truces (Grobi Overview l.80). Acceptable local invention?
4. **Zafir's "controlled bound labor without living coercion"** (The City in Siege l.118). LR l.88 forbids binding "coerced persons". Is this bound constructs only? The wording invites the wrong reading.
5. **Tuskway Redoubt in winter.** Break the Southern Horn l.61 has Stone-Tooth fighters holding the lower redoubt in Deep Winter; Tusk Broken Twice (Deep Winter, Early Spring) sends the player into the same redoubt against Jorund's charges. Which comes first?
6. **A faction quest inside a closed operation.** Holdfast Without Orders is set "During Tannbruck's withdrawal" at Tann Crossing Farms, but Tannbruck Falls is a closed operation with a locked party (l.45).

---

## Faction questlines

### What this material leans on

- The confessional settlement: whose yard, who sends the dead, the year and a day — Korrheim Accord l.20, l.43–47, l.70, l.74; Church Overview l.45; Freeflame Reformation l.129; Courts and Crowns l.43.
- Sending Houses, assurance letters, relic courts and the Lantern — Church Overview l.26, l.29, l.39–41; Military Orders l.26, l.42.
- The Grey Sweat, its registers and its walking dead — `C/History/70 Later History and Present Day/The Grey Sweat.md` l.18, l.30, l.54, l.60; `The Grey Sweat - Authorial Truth.md` l.22, l.38.
- Signs and their limits — White Flame Doctrine l.54; `C/History/70 Later History and Present Day/The Age of Held Proofs.md` l.16.
- The Folk Wars, the Drowning (993), the Standing of the Water (994), the Peace of the Bent Oak (999), the lake-law — Folk Canon Register l.52–54; Folk of the Frontier l.24–34; Chapel-Folk l.20.
- Folk political rule (no common sovereign) and Menhir law — LR l.81; Folk Canon Register l.34, l.38.
- The Debtors' Corps — Debtors' Corps l.16–28.
- Faction counts and settlement axes — LR l.95.

### Findings

| ID | Where | What the game says | What canon says | Type | Sev. | Suggested change |
|---|---|---|---|---|---|---|
| F-01 | G/50 Campaign/Factions/30 Church/ (all nine quests); Faction Progression and Settlement Matrix.md l.35 | The diocese is the only rite in the duchy. Its one quarrel is with the civil courts. No quest mentions the Freeflame, the Accord or a second rite | Accord l.74: "Freeflame influences make actual practice less tidy than the ducal register suggests". Courts and Crowns l.43: "Freeflame preachers among the winter labor camps". Church Overview l.45: the Accord gave "every ruler the public rite of his land's yards" | Superseded (the church as described has no post-1343 setting) | B | Add the missing party where the quests already stand: the Outer Winter Camps, the burial trench, the Chapel-Folk refuges |
| F-02 | Factions/30 Church/Bread and Burial.md l.41, l.59 | "escort a burial reader"; "families and burial readers control the resulting record" | Grey Sweat l.60: Gelasin "confirmed the Ferry Rule for the plague years, forbade it afterwards". Accord l.47: "A yard whose dead go unsent for a year and a day is open to whichever rite will send them" | Unsupported | B | Say who the reader is: a priest, a Lantern singer, or a lay reader acting outside the old rite. The last choice makes the trench a matter under the Accord |
| F-03 | Factions/30 Church/A Relic Proven False.md l.41, l.49 | The player and "Warlock Hall measurements" prove the relic false and "present findings before Church and civic audiences" | Church Overview l.26: "Relic courts test claims of sainthood, apparitions, and sanctified objects". Military Orders l.26: Malveris inquisitors handle "fraudulent relics" under Lantern review | Unsupported | B | Name the relic court or Lantern examiner that receives the finding; the player gathers the evidence for it |
| F-04 | Factions/40 Four-Hearth Compact/The Bellless Hold.md l.35, l.45, l.49 | "Occupation-era mechanisms"; "Atherian mechanisms"; "Hold inscriptions… establish the occupation history". The location note (G/20 Region and Locations/20 Exterior Regions/30 Wolfsmere Woods/Bellless Hold.md l.26) calls it an "Eclessian occupation fort built… after the Folk Wars", its bell removed when "sound carried wrongly" | Folk Canon Register l.52: Adalmar "granted his Markish lords the imperial frontier forts". l.54: "the march charters forbid any bell within hearing of Wolfsmere". l.53: after 994 "no Markish army crossed the lake country again" | Internal, and superseded cause for the missing bell | B | One history for both notes: an imperial fort granted to a Markish lord in the 980s, its bell taken down under the charters of 999 |
| F-05 | Factions/50 Underworld/The First Toll.md l.35, l.77 against The Watchman Who Walked.md l.55; G/30 Characters/50 Bank and Underworld/Watch-Captain Oskar Vey.md l.35; Acts/20 Act II/Knives Behind the Walls.md l.100 | Quest 7 is "the Black Bell's first planned killing" and "fixes whether its founding act is killing or coerced trial". Quest 6 already offers "a planned Black Bell execution" of Vey, and MQ-13 lets the Bell "execute prisoners" in Deep Winter | — | Internal | B | Either quest 7 is the first killing of someone who poses no immediate danger, or the earlier executions are not the Bell's |
| F-06 | Factions/50 Underworld/The Store Beneath the Siege.md l.15; A Bell Behind the Walls.md l.15; every line's quests 8 and 9 | Window "Muster Crisis" (the only window for the two Underworld quest 8s) | Acts/30 Act III/The Dead March.md l.50: "Confirming begins the Muster Crisis and a closed three-front sequence", which runs on into the finale | Internal | B | Open a city interval inside the Muster Crisis, or move these quests to Open Spring |

### Checked and holds

- Counts and structure: four lines of nine, six shared underworld quests, two branches of three; five independent settlement axes; no outcome is setting canon (Faction MOC l.17; Matrix l.61–65) — LR l.95, l.90.
- Blackjacks and Medori line. Inflated equipment charges, injury extending service, altered pages, a contract's stated terms, and advocates able to challenge the arithmetic — Debtors' Corps l.26–28: "commanders add disputed costs… injury has generated new obligations". Reform advocates and collectors as rival camps — l.32–34.
- "Lucia will correct fraud but initially defends equipment liability"; credit that keeps clients working — Medori family Overview l.37.
- The Unquiet Name: a wrong name from the Sweat years, settled by a "proper renaming rite" (l.35, l.41) — Grey Sweat l.54 "The plague-gap registers never closed"; l.60 a walker "went" when named and sung. The mechanism agrees; see open question 1.
- Mercy in Winter: the White Flame "answers genuine self-giving but does not replace labor"; "no institution gains automatic jurisdiction" (l.55, l.61) — White Flame Doctrine l.33–35, l.54 "it cannot settle every claim made by a relic's custodians".
- Jurisdiction of Fire: a real miracle does not hand Konrad the civil courts — same passage.
- Bent Oak, Living: the title and its sanctuary argument — Chapel-Folk l.20 "Chapel-Folk answer that a bent oak remains alive". The pass's own check agrees (Causality Pass 11E l.189).
- Root-Witness: "without treating Menhir law as proof of justice" (l.37) — Folk Canon Register l.38.
- Four Empty Seats and The Four-Hearth Winter: no delegate binds absent households; no "permanent Folk state" — LR l.81; Folk Canon Register l.34.
- Names Under Water: Mael withholds the Wolfsmere truth — Folk of the Frontier l.34 "they have never told anyone… exactly what that costs".
- Ash at the Door: Chapel-Folk may keep a boundary without worship — Chapel-Folk l.24 "prudence is not worship".
- Ignatius risking "secular judgement" — Military Orders l.30: chapters that ignore the distinction "risk both secular prosecution and spiritual corruption".
- No quest cites a Sending House, an assurance letter, the Schedule of Yards, the Night of Broken Bells or any dated event; nothing here is stale by name or date.

### Open questions for the creator

1. **Residue or an unsent soul?** The Unquiet Name (l.37, l.77) teaches that the walker is "residue" and never "a trapped soul". Canon now says the Sweat's walkers were "residue and unsent souls at thin places" (Authorial Truth l.22). The quest can stand as residue, but its lesson is flatter than canon. Which is it at Willow Graveyard?
2. **Who rules on the miracle?** Mercy in Winter (l.37) is "unambiguously genuine". In the Age of Held Proofs the great powers avoid tests (l.16), and Vessing, "a hill parish of the southern marches", has waited eight years (l.68). Does a relic court come to Grenzburg, and does Konrad want it to?
3. **The drowned rolls.** Names Under Water (l.35, l.41) recovers written "roll cases". Canon's Roll of the Drowned is recited from memory (Folk of the Frontier l.32). Are these a different record, for instance the clerks' copy of the 993 recital?
4. **Ash on the door.** In canon ash belongs to the Ash-Walkers, who carried the unblessed dead to a priest, and to the Ashenmen. Does Ignatius's ash mark (Ash at the Door l.35) borrow that meaning on purpose?
5. **Lakewatch.** Canon's "Lake Watch" is Adalmar's shore-fort on Wolfsmere, lost in 994 (Folk of the Frontier l.34). The game's Lakewatch is a living fishing town on Longlake. Same name by design?
6. **The Duke's part in the Church.** Under the Accord the lord "sets its public rite and confirms its clergy" (l.44). Should the Church settlement axis (Accounts of the Living l.81) start from that?
7. **Ash-Spear.** Canon lists the Ash-Spear (Warlord Cenn) among the frontier clans and names Speaker Bran for the River-Clans (Folk of the Frontier l.20). The Four-Hearth line uses neither. Deliberate?

---

## What the new history offers

- **The year and a day.** An unsung yard is forfeit to the other rite, so "a village haunting is a legal event with a deadline" (Accord l.70). Bread and Burial and The Unquiet Name are already that story.
- **The camps.** Virelian runaways and Freeflame elders who "will bury anyone" are in Grenzburg's seasonal camps (Grey Sweat l.52). Bent Oak elders "have begun, very quietly, attending Freeflame meetings" (Folk Daily Life l.66).
- **The Peace of the Bent Oak was won in a bishops' court against the king.** Elof and Konrad share that precedent; it suits Bent Oak, Living and Jurisdiction of Fire.
- **The Standing of the Water, 994.** A garrison found on the ice is ready-made testimony for the Bellless Hold and Names Under Water.
- **The Bank of the Dead.** The Medori hold the Chancery registers and sell sheets to the Lantern (Medori Bank l.34). Lucia's Long Book could sit beside a second, older book.
- **Vessing and the Closed House.** A held apparition and an inquisitors' prison under hearing since 1357 (Age of Held Proofs l.68–70) are live models for Ignatius and for the miracle.
- **The winter truce and Folk law on Grobi captives** (Frost-Road l.32–34) give Act II's mercy choices a native law to cite.
- **Grenzburg's own calendar.** Wanefall "decides who winters inside the walls"; Souls-month grave-watch is "a militia duty"; the Castellan counts Kindlenight hearths (Year of the Flame l.75).

## Coverage

**Read in full** (body text of every note; YAML front matter was skimmed, not read line by line)

- `G/30 Characters/`: Characters MOC; all six notes in `20 Ducal and Civil`; all four in `30 Church`; all ten in `40 Folk`; all ten in `50 Bank and Underworld`; and Ghor-Maw, Magister Leviticus of Sestaren and Skrit Stone-Tooth in `60 Personal Histories`.
- `G/50 Campaign/Main Campaign MOC.md` and all eight notes in `00 Main Campaign Controls/`.
- `G/50 Campaign/Acts/`: five act overviews, twenty-one chapter notes, Accounts of the Living, The First Summer Road.
- `G/50 Campaign/Factions/`: Faction Questlines MOC, Faction Progression and Settlement Matrix, and all forty-eight quest notes. The quest notes share a template; the shared lines were read once and the distinct lines of each note in full.
- `G/50 Campaign/Companions/` (root): Companions MOC, Companion Constitution, Companion Debt and Remote Claims Standard, Companion Remote Claims Compliance Register.

**Skimmed** (keyword search for world terms, plus a partial read)

- The other fifteen standards at the root of `Companions/`: the archetype, dialogue, scene, grounded-writing, field-familiarity, campaign-architecture, autonomy, expansion, reactive-scene and emotional-audit notes, the pair briefs and the four blind dialogue tests. They are craft documents and yielded only finding A-11.

**Canon opened and quoted from**

- Locked Rulings; the renames list; Causality Pass 13 (applied section and tables 13C to 13E); the Grenzburg checks inside Causality Pass 11E and 11F.
- The Korrheim Accord; Eclessian Church Overview; Eclessian Military Orders; Eclessian Canon Register; The Grey Sweat and its Authorial Truth; White Flame Doctrine; Year of the Flame.
- The Folk of the Frontier and the Wolfsmere Lineage; Chapel-Folk; Folk Canon Register; Grobi Overview; The Unending Muster; The General Below; Emerald Drakes; Debtors' Corps; Medori Bank; Medori family Overview; Medori Family - Authorial Truth.
- Read in part: Freeflame Reformation; Present-Day Courts and Crowns; Present-Day Political Board; The Age of Held Proofs; Real-History Concordance; Gazetteer; Grobi History and Pack Life; Hobgoblins; Frost-Road and the Winter War; Folk Daily Life; Drakes Overview; The Empire of Qianglong; Qianglong Caste Recurrences.

**Not checked**

- Causality Pass 09 and 11F were not read end to end; only their Grenzburg sections and the Proposal Index search.
- Where Tann Crossing Farms stands. No location note gives its position, so A-07 rests on the acts and the regional geography alone.
- `C/History/10 Chronology and Control/Reader-Facing Campaign Material - Authorial Control.md` mentions Grenzburg fourteen times and was not compared.
- The Grenzburg faction dossiers in `G/40 Factions/` and the location notes belong to other auditors. They were opened only where a quest in this slice depends on them (Bellless Hold, The Grobi, the Lowlands notes, the Season Constitution).
- Anything inside the eight `CMP-…` folders, `10 Companions/`, and the other personal histories.
