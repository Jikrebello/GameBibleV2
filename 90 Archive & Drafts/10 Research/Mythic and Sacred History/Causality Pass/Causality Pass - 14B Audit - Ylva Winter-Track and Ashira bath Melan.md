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
# Causality Pass — 14B Audit: Ylva Winter-Track and Ashira bath Melan

> [!note] Status — 15 November 2026
> Detail for [[Causality Pass - 14 Grenzburg and Companions Audit]]. **Report only: nothing in the game folders or in canon was changed.** This is the auditor's report as written. Paths beginning `CMP-`, `C10`, `PH` and the like are short forms for folders under `02 Playable Settings/Grenzburg/`; each report explains its own.

Audit date: 15 November 2026. Read-only. Canon is whatever `01 Canon Reference/` says now; Locked Rulings are in `00 Start Here/Current Focus Board.md` (lines 57–97).

Paths are relative to the vault root. Game files are under `02 Playable Settings/Grenzburg/`; "CMP-03/" and "CMP-04/" mean the two companion folders under `50 Campaign/Companions/`. "l." is a line number.

**Headline.** Neither companion's files contain a single renamed name or a moved date: the only years in the slice are 1359 AR and 1360 AR, and a search for all sixty-seven old names found nothing. The disagreements are of other kinds: one story-logic problem in Ashira's Act I, places where the game describes a canon people, place or creature differently from its canon page, and internal slips.

Severity counts — Ylva: A 0, B 2, C 10. Ashira: A 1, B 5, C 5.

---

## Ylva Winter-Track

### What this story leans on

- **The Grey-Wolf Ättar** (her origin, women's work, the male war-scout office, beacons, earned names): `01 Canon Reference/Peoples and Cultures/Ättar/10 Foundations/Ättar Canon Register.md`; `.../Ättar/60 Realms and Peoples/Grey-Wolf Range.md`; `.../Ättar/50 Economy and Warfare/Winter War and the Grobi Frontier.md`; `.../Ättar/30 Society and Daily Life/Ättar Kinship, Descent, and Weregild.md`; `.../Ättar/Ättar Overview.md`; Locked Ruling at Current Focus Board l.82.
- **The Medori Bank and debt service in the Blackjacks** (the White-Sled surety, the sale of her labour, Bellandi as debt manager): `.../Sestaran Concord/60 Realms and Peoples/Grand Duchy of Fiorenzia/Medori Bank.md`; `.../Debtors’ Corps.md`; `01 Canon Reference/History/70 Later History and Present Day/Present-Day Courts and Crowns (1360 AR).md` l.96.
- **The Unending Muster and corpse residue** (Act III): `01 Canon Reference/History/20 Prehistory/The Unending Muster.md`; `01 Canon Reference/Creatures/10 Material and Residue/20 Residue Dead/Corpse Residue.md` and `Residue Dead Overview.md`.
- **The Grobi** (winter siege, archers, river probe): `01 Canon Reference/Creatures/30 Shadowlands and Idols/20 Wrath/10 Grobi/Grobi History and Pack Life.md`.
- **The Folk as an umbrella people with particular custodians** (route holders, Chapel-Folk): Locked Ruling l.81.
- **Grenzburg Locked Rulings**: vocations (l.85, l.88), fixed outcomes (l.90), companion structure (l.91), geography (l.96).
- **The calendar** (whether "winter of 1359" is one winter before the game): `.../Eclessia/30 Society and Daily Life/Eclessian Daily Life and the Year of the Flame.md` l.20–33.

### Findings

| ID | Where | What the game says | What canon says | Type | Sev. | Suggested change |
|---|---|---|---|---|---|---|
| Y-01 | `30 Characters/10 Companions/Ylva Winter-Track.md` l.32 (`debt_manager`); also Ashira's file l.32 | The Medori officer for both debts is "Claims-Factor Marco Bellandi", under Ledger-Master Lucia Medori | `Present-Day Courts and Crowns (1360 AR).md` l.96: "Factors Gianni and Livia active in Grenzburg". No Gianni or Livia exists anywhere in the game; Bellandi is not in canon. (`Medori Bank.md` l.47 does link Lucia, so canon is split against itself too.) | Contradiction | B | Creator to choose: rename canon's two factors, or add them to the game's Bank cast. Probably belongs to the Bank slice; logged here because both debts hang on it. |
| Y-02 | CMP-03/`The Fourth Marker.md` l.18, l.189; `50 Campaign/00 Main Campaign Controls/Main Campaign State Matrix.md` l.26; against CMP-03/`Ylva Companion Campaign.md` l.71–75, l.149, l.165, l.170–174, l.192 | The Fourth Marker awards `ylva_campaign_tracked` flatly and the State Matrix lists it as a required output of MQ-04. The Campaign file makes tracking conditional and builds an "untracked" stable-colleague route; its tracked default has "one avoidable injury" and Ylva recovered "under imposed shift limits" | Locked Ruling l.91: "Ignored companions continue stable assignments without unseen moral resolution, injury, departure, or death." | Internal (touches a Locked Ruling) | B | State whether MQ-04 always tracks her. If it does, a player who then ignores her gets the managed autonomous results, which the ruling forbids; if not, make the reward conditional in both files. |
| Y-03 | CMP-03/`The Sister Watch.md` l.79, l.138 | The custom "grants no clan rank"; the cords are not "clan adoption" | `Ättar Canon Register.md` l.23: "The four totems are great regional kindreds containing many rival halls." Canon never uses "clan" for the Ättar; it is the Folk word (`Present-Day Political Board.md` l.62 "Green March clans") | Contradiction (term) | C | "hall rank"; "hall adoption". |
| Y-04 | CMP-03/`A Hearth Chosen.md` l.114 | "Grey-Wolf language distinguishes a shelter one happens to share from a hearth deliberately chosen" | `Ättar Overview.md` l.17: the Ättar "share a language, forms of law, four totem-kindreds" | Contradiction (wording) | C | "Grey-Wolf speech" or "the Ättar tongue as Grey-Wolf halls use it". |
| Y-05 | CMP-03/`Routes for the Living.md` l.134 | Muster patterns "must be dispersed, burned, broken, or redirected" | `Corpse Residue.md` l.47: "Burning remains without containing residue can seed soot-hauntings." | Contradiction | C | Drop "burned" or add "contained and burned". |
| Y-06 | CMP-03/`Signals Over Lantern Ward.md` l.108 | "Bard and advanced vocations offer support" | Locked Ruling l.85: "Paladin, Binder, Bard, and Lancewright are companion-earned advanced paths" | Contradiction (Locked Ruling) | C | "Bard and the other advanced vocations". |
| Y-07 | CMP-03/`The Fourth Marker.md` l.30 | `chapter_id: "MC-04"` | Every other chapter ID in the game is "MQ-nn"; the State Matrix row is MQ-04 (l.26) | Internal | C | "MQ-04". |
| Y-08 | CMP-03/`The Fourth Marker.md` l.104–110 | "The party follows three redundant signs:" followed by five | — | Internal | C | "five". |
| Y-09 | CMP-03/`The Fourth Marker.md` l.162 | "She joins the Blackjacks as a selectable companion" | Her own file l.72: already "Medori surety debtor and Blackjack rescue scout"; `The White-Sled Rescue.md` l.44 sold her labour "into the Blackjack Corps" before the game | Internal | C | "joins the player's company". |
| Y-10 | CMP-03/`Ylva Rescue Hunter Package.md` l.145 against CMP-03/`Ylva Companion Campaign.md` l.211–219 | Package lists "Rescue Scout doctrine" from What the Ice Takes as an account unlock; the Campaign's progression table has five rows and omits it | — | Internal | C | Add the row to the Campaign table or mark the doctrine as Ylva-only. |
| Y-11 | CMP-03/`A Hearth Chosen.md` l.14–15; CMP-03/`The Sister Watch.md` l.14–15; CMP-03/`Signals Over Lantern Ward.md` l.15; CMP-03/`What the Ice Takes.md` l.15 | Relationship episodes are `act: act-2` with windows "Late Winter", "Early Spring"; winter pieces use "Winter Siege" | `10 Production Bible/Season and World-State Constitution.md` l.48–57 has no "Late Winter" or "Winter Siege" (windows are Early Winter, Deep Winter, Early Spring, Open Spring, Muster Crisis). CMP-03/`Ylva Field Familiarity and Relationships.md` l.69–73 files the same episodes under "Act III and Summer". Ashira's files label the same slot `act-3` and call the winter window "Siege Winter" | Internal (also between the two companions) | C | One window vocabulary and one act label for sequence 7 across both campaigns. |
| Y-12 | CMP-03/`Routes for the Living.md` l.32, l.36, l.75, l.89 | Opens "After The Open Thaw" (MQ-16) and asks the party to "Reopen the Tannbruck scout post"; `tannbruck_reclaimed` is only an optional input | State Matrix l.39: `tannbruck_reclaimed` is set by MQ-17, after the Open Thaw; Locked Ruling l.90: "Fort Tannbruck always falls" | Internal | C | Gate the Upper Grenz corridor on `tannbruck_reclaimed`, or say it stays closed until then. |

### Checked and holds

- **Stale names and dates: none.** The slice holds only "winter of 1359 AR" (`The White-Sled Rescue.md` l.21) and "thirty-one in 1360 AR" (her file l.69). The Anchor Date record says no line in the Grenzburg material changed (`Causality Pass - 13 Anchor Date Proposals.md` l.59).
- **"One winter before the game"** (her file l.99) agrees with "winter of 1359 AR". The Eclessian year begins at Bindingtide and ends with Kindlenight (midwinter) and Thawwait (Year of the Flame l.22, l.32–33), so an autumn 1360 start puts the previous winter in 1359, and the thaw still falls in 1360 as `The Unending Muster.md` l.52 requires.
- **Grey-Wolf as a kindred on the Grobi frontier**: `Grey-Wolf Range.md` l.16 "principal Ättar pressure frontier against Grobi migration"; halls "dependent on beacon chains".
- **Women barred from the war-scout office** (her file l.91): `Ättar Canon Register.md` l.26 "Male institutions control chiefship, raiding, sworn war service"; Kinship l.26 "Men hold chiefly, raiding, and formal warrior offices."
- **Earned hyphenated name** "Winter-Track": canon Ättar carry the same form ("Hedra Store-Keeper", "Eldran of Grey Pass").
- **An Ättar working alone in Eclessia**: `Ättar and the Wider World.md` l.44 "Distance limits settlement but not raids, mercenary movement, or captives."
- **Debt turned into Blackjack service**: `Medori Bank.md` l.26 "distressed-debt purchase and negotiated collection"; `Debtors’ Corps.md` l.20 names the Blackjack Corps in Grenzburg; l.28 "commanders add disputed costs" matches Koss's use of the surety.
- **Muster dead are residue, not souls** (`Routes for the Living.md` l.132–134; `The Last Marker.md` l.98, l.179): `The Unending Muster.md` l.60 "Human souls are not trapped in Muster soldiers."
- **Muster waymarks appear after the Open Thaw** (`Routes for the Living.md` l.75): canon l.56 "first becomes undeniable in The Open Thaw". The "old command crypt" and "Banner Vault" match the Watch-Hill Command Crypt and Tuskway Banner Vault (`Muster Anchor Matrix.md` l.22, l.24; canon l.56).
- **Grobi archers** (`What the Ice Takes.md` l.116): `Grobi History and Pack Life.md` l.87 "stolen bows and hit-and-run attacks".
- **"No universal Folk authority"** (`Routes for the Living.md` l.112): Locked Ruling l.81 "a living umbrella civilization rather than a state".
- **Geography**: Frostfenn is the cold south and Muster routes run "toward the south", as Locked Ruling l.96 requires. The principal sites are in `Grenzburg Worldspace Location Register.md` (Snowblind Rise at l.187, l.198); for the ones that are not, see Open question 7.
- **Structure**: eleven pieces, ten per run, ten embedded opportunities, three duo finales, one heterosexual romance and one same-sex sworn bond (Locked Ruling l.91). Hours add up to 10.75 and 10.25 as stated.
- **Hunter and field arrows**: Hunter is a starter (l.85); the five recipes match `Hunter.md` l.98–108; blast powder exists in canon (`Jirahar Defence and Caravan Law.md` l.32 "purchased powder weapons").
- **Vocation notes** on Warlock "bounded scripts" and Medium "non-conscious imprints" match Locked Ruling l.88.
- **Links**: every wiki-link in her files resolves to one live note.

### Open questions for the creator

1. **Old-rite or baptised hall?** Canon splits the Ättar of 1360 into old-rite halls (skinwalker chief, child exchange, Moon-Seer) and baptised halls (`Ättar Overview.md` l.57–61). Ylva's files never say which she left.
2. **Who keeps the beacons?** The game gives beacon-tending to Grey-Wolf women (her file l.91); canon says "Grey-Wolf scouts maintain beacons and migration intelligence" (`Winter War and the Grobi Frontier.md` l.18). Readable as "women tend, scouts hold the office", but canon does not say so.
3. **The White-Sled Rescue happened inside the game map.** Snowblind Rise is in Frostfenn March (Location Register l.187), the region where the "ordinary ducal survey" ends (l.185). Where was a mixed freight and passenger convoy bound, and why is no driver, guard or passenger in Grenzburg a year later (l.198)? The Remote Claims Standard speaks of wrongs that remain "abroad" (l.21).
4. **The name Ylva** is a real Scandinavian name meaning she-wolf, given to a Grey-Wolf woman. Does Concordance Rule 5 ("one step sideways on all names") bind the game's cast?
5. **Braids and torcs.** Canon makes "braids and long hair" and torcs carry family and campaign meaning (`Ättar Overview.md` l.43). Ylva wears "no ornament that can catch a line" (her file l.87). Deliberate?
6. `Ylva Banter and Reactivity.md` l.96–102: "Seven minutes", "Eleven", "the four minutes she stole". The sum is not explained on the page.
7. **Sites named in her quests but absent from the location notes**: Southbound Muster Camp, Upper Grenz Relief Cut, Dyers' Roof, Longlake Ward Shore, Longlake Ice, Tannbruck Scout Post (which also carries the asset `ylva_tannbruck_scout_post_restored`), and Longlake Road (the notes have "Lake Road" and "Lakewatch Road"). Quest-level invention, or names to register?

### What the new history offers

- The War of the Empty Halls began with an unrelieved watch: "The first beacon line failed after a hall chief withheld replacement watchers during a feud" (`The Ättar before the Great Keel-Taking.md` l.76). The Wolf founder Eldran led "the survivors of the failed beacon line" (l.93).
- Hedra Store-Keeper's public tally-sticks kept chiefs from eating "the shares needed by dependants, scouts and boat crews" (`War of the Empty Halls.md` l.55): an ancestral public roster.
- In 1360 the Grey-Wolf Range has "chiefs showing early moon-loss after remaining transformed through entire patrol seasons" (`Grey-Wolf Range.md` l.22): leaders who would not stand down.
- "Grey-Wolf halls demand a stronger Grobi muster" (`Present-Day Political Board.md` l.68); the Grobi corridors "aim toward Grenzburg's latitude" (Gazetteer l.65). Her people and Grenzburg face the same movement.
- The rewritten Muster "treated discharge, burial, surrender, and death as administrative errors" and each repair "demanded more bodies, armour and grain" (`The Unending Muster.md` l.22, l.28): service that never releases.

---

## Ashira bath Melan

### What this story leans on

- **The Jirahar and Migdal Qesheth** (her origin, the judgement, Keepers, caravan law, naming): `01 Canon Reference/Peoples and Cultures/Jirahar/10 Foundations/Jirahar Canon Register.md`; `.../Jirahar/60 Realms and Peoples/Migdal Qesheth.md`; `.../Jirahar/40 Government and Institutions/Keepers, Courts, and Communal Government.md`; `.../Jirahar/50 Economy and Defence/Jirahar Defence and Caravan Law.md`; `.../Jirahar/20 Faith and Worldview/Jirahar Law, Descent, and Conversion.md`; `.../Theological and Mystical Traditions.md`; Locked Ruling l.64. The naming register itself is spelt out in `01 Canon Reference/History/10 Chronology and Control/World Historical Atlas - Integration and Coverage Ledger.md` l.885.
- **Where Qesheth is**: `01 Canon Reference/Geography/Gazetteer of the Known World.md` l.41, l.49, l.78; `.../Jirahar/60 Realms and Peoples/Migdal Talga.md`.
- **Residue and hauntings** (House Echo, corpse residue, "ghost"): `01 Canon Reference/Creatures/10 Material and Residue/20 Residue Dead/Anchored Hauntings.md`, `Corpse Residue.md`, `Residue Dead Overview.md`; `01 Canon Reference/Magic & Systems/50 Thresholds and Soul-Routing/Soul Routing and the Vestibule.md`.
- **What a Medium shade is**: Locked Rulings l.71 and l.88. No page in `01 Canon Reference/` defines Medium; the game's `10 Production Bible/20 Player Systems/30 Starting Vocations/Medium.md` does.
- **The Unending Muster and Qianglong** (Act III): `01 Canon Reference/History/20 Prehistory/The Unending Muster.md`.
- **The Medori Bank** (purchase of the liability, Bellandi): `Medori Bank.md`; `Debtors’ Corps.md`; `Present-Day Courts and Crowns (1360 AR).md` l.96.
- **Atherian remains** (Sunken Causeway, Rain Vault): taken from the game's own location notes; not checked against the reach of the Atherian Empire.

### Findings

| ID | Where | What the game says | What canon says | Type | Sev. | Suggested change |
|---|---|---|---|---|---|---|
| A-01 | CMP-04/`A Useful Terror.md` l.69, l.71; against CMP-04/`Ashira Companion Campaign.md` l.87, `30 Characters/10 Companions/Ashira bath Melan.md` l.101, l.105–109, and `50 Campaign/Companions/Companion Debt and Remote Claims Standard.md` l.23 | The Longlake smugglers' sentries "are former associates of the raider band"; of the captives' families, "Some knew the dead raider." Elsewhere: "No Qesheth Keeper, affected family, raider relation, or former rival appears in Grenzburg", and the judgement was made "to prevent collective sanction against the tower" | `Migdal Qesheth.md` l.16: the tower "stands on the dry margin near Zanthir"; Gazetteer l.41 puts Zanthir in the desert crescent and l.49 puts Grenzburg "on the far southern frontier" of Eclessia. The Standard: "No person from a companion's former life physically enters the base-game worldspace" | Internal, sharpened by canon geography | A | The three statements cannot all stand. Either place the massacre on a road near Grenzburg (then the raiders' camp and the "affected family collectives" are local, against the remote-only rule), or cut the sentries' and families' personal tie to the raiders and let the face frighten for another reason. The quest is marked `remote_claim_status: compliant` (l.57). |
| A-02 | CMP-04/`The Room That Answered.md` l.71, l.87, l.93, l.108 | "a genuine non-conscious House Echo"; a "fixed domestic loop"; "useful without being conscious"; destroying it only "erases a useful fire route" | `Anchored Hauntings.md` l.27: anchored hauntings, House Echoes among them, are "persona-grade residue"; "They can speak, recognize people, and solve problems inside the copied pattern." l.29: an echo "can suffer within its pattern, provide truthful testimony". `Residue Dead Overview.md` l.24: persona echo, moral agency "Limited" | Contradiction | B | Either call the room's phenomenon routine-grade house residue and not a House Echo, or keep the name and give it canon's properties: a voice bound to the house's remembered life, a release condition, and weight to destroying it. |
| A-03 | `30 Characters/10 Companions/Ashira bath Melan.md` l.70 | "Qesheth Tower, one of the Jirahar scholarly communities" | `Migdal Qesheth.md` l.16: "**Migdal Qesheth**, the Tower of the Bow ... first in sacred dignity and the seat of High Keeper Zerahiah"; l.36 "the principal routing court". "Qesheth Tower" occurs nowhere else in the vault | Contradiction (understated) and non-canon name form | B | "Migdal Qesheth, the Tower of the Bow, first in sacred dignity among the five living towers". |
| A-04 | `30 Characters/10 Companions/Ashira bath Melan.md` l.90 | "Qesheth scholarship treats memory, image, repetition, and shadow as distinct things" | Canon gives Qesheth "legal education, manuscript authentication" (l.28). The Jirahar mystical discipline is the Millin Setharin, "an interpretive discipline, not a separate source of magic" (`Theological and Mystical Traditions.md` l.16). The Mesakha tests name "Shade" among the ways a sign can be staged (`Mesakha Traditions.md` l.20). Worship is "without images" (`The Path of the Chosen Jiraharin Religion.md` l.32). No canon page gives any tower a school of shadow or imprint study | Unsupported | B | Name the study in the Jirahar register and say whether the tower sanctions it or merely tolerates it; or make it Ashira's own restricted work. |
| A-05 | `30 Characters/10 Companions/Ashira bath Melan.md` l.324 | In autumn she "confronts the first living owner of a face she retained" | Her Act I pieces show only "a dead raider's face" (CMP-04/`The Faces She Kept.md` l.70) and "the dead raider" (`A Useful Terror.md` l.71); the Campaign bars any affected family from Grenzburg (l.87) | Internal | B | Reword the seasonal line to what Act I contains, or say who the living owner is. |
| A-06 | `30 Characters/10 Companions/Ashira bath Melan.md` l.32, l.109; CMP-04/`Ashira Companion Campaign.md` l.85; CMP-04/`No Human Shadow.md` l.133 | Claims-Factor Marco Bellandi administers the Qesheth liability | As Y-01: canon names "Factors Gianni and Livia active in Grenzburg" | Contradiction | B | As Y-01. |
| A-07 | CMP-04/`Ashira Shadow Roster Package.md` l.19 | "a companion package, not a ninth vocation" | Locked Ruling l.85: five starters and four advanced paths, nine authored vocations already. (`Custom Vocation Workshop.md` l.74 has the same phrase.) | Contradiction (Locked Ruling) | C | "not a tenth vocation" or "not a new vocation". |
| A-08 | CMP-04/`The Puppet Dies Twice.md` l.15; `What the Ruins Repeated.md` l.15; `When the Screen Comes Down.md` l.15; `The Garden Under Rain.md` l.14–15; `What We Keep Closed.md` l.14–15 | Winter window is "Siege Winter"; the relationship episodes are `act: act-3`, "Early Spring" | Season Constitution l.48–57 has no "Siege Winter". Ylva's files call the same window "Winter Siege" and label the same sequence-7 slot `act-2` | Internal (between the two companions) | C | As Y-11. |
| A-09 | CMP-04/`Borrowed Faces.md` l.45–46, l.69 | Premise: "A relief convoy from reclaimed Tannbruck is overdue"; `tannbruck_reclaimed` is only an optional input | State Matrix l.39: set by MQ-17 | Internal | C | Make `tannbruck_reclaimed` a required state. |
| A-10 | CMP-04/`Ashira Companion Campaign.md` l.176 against `20 Region and Locations/20 Exterior Regions/50 Highlake Uplands/Rain Vault.md` l.28 | Embedded opportunity 7, open to every player: "Rain Vault exploration: recognize blue-glass repeats". The place note calls the Vault "a romance-only exploration site" | — | Internal | C | Say the quest is romance-only and the site is not. |
| A-11 | CMP-04/`The Faces She Kept.md` l.125–130, l.136 | `customs_runner_state` may be "dead", but no branch of the quest kills Pavel | — | Internal | C | Drop "dead" or add the branch. |

### Checked and holds

- **Stale names and dates: none.** The only year is "twenty-nine in 1360 AR" (her file l.69).
- **Her name fits the locked register as written**: Coverage Ledger l.885, "d'- genitives, -a / -atha / -in endings, bar / bath patronymics". Canon also has "Amaryah bath Yoreth" (`Amaryah the Fire-Bearer.md` l.20). See Open question 2.
- **Keepers, no single Jirahar sovereign, remote judgement**: `Keepers, Courts, and Communal Government.md` l.24–40. "No ... Keeper ... arrives" breaks nothing.
- **A court laying personal liability**: `Jirahar Law, Descent, and Conversion.md` l.38 "Courts may impose restitution, loss of communal office, exclusion from rites".
- **Her act was a Jirahar crime**, which supports the judgement: `Jirahar Defence and Caravan Law.md` l.40 "Collective punishment, hostage-taking ... and pre-emptive killing remain crimes even when justified as survival."
- **"Collective sanction against the tower"** is plausible: Qesheth sits "under an old emirial charter" (l.16) and charters "can be honored, renegotiated, or betrayed" (Keepers l.36).
- **Medori buying the liability and authenticating rulings**: `Medori Bank.md` l.25–26 "custody, authentication, and account clearing; distressed-debt purchase".
- **Shades are not souls; soulbinding is evil; constructs have no moral agency** (`Ashira Shadow Roster Package.md` l.23, l.86–94; her file l.268): Locked Rulings l.71, l.88.
- **Residue is not the dead person** (`What the Ruins Repeated.md` l.75, l.95): `Corpse Residue.md` l.28 "None of the four common forms contains the deceased person"; corpse-walkers repeat "the movement their final moments impressed upon them" (l.42), which fits the six hammer blows.
- **The Church agrees with her on residue**: `Residue Dead Overview.md` l.57 "Eclessian and Thalmyric churches agree that ordinary residue is not the soul." Sister Marcellina's limited cooperation is in keeping.
- **"Ghost" as a loose everyday word** (her file l.99): `Anchored Hauntings.md` l.67 "'Ghost' remains an everyday word covering residue, bound souls, counterfeits".
- **Testimony from residue is not reliable alone** (Package l.90, l.93): canon lets an echo "provide truthful testimony, misremember, manipulate" (l.29). Compatible.
- **The Muster**: Qianglong work, non-conscious, no trapped souls (`No Human Shadow.md` l.69, l.95, l.103): `The Unending Muster.md` l.16, l.60–61. Bone-Reed Pool as a buried Qianglong signal platform agrees with the game's place note.
- **"The underways"** in `The Faces She Kept.md` are Grenzburg's own; the place note says they are not "a Jirahar Underway" (`Grenzburg Underways.md` l.26), so there is no clash with canon's Jirahar Underways (Locked Ruling l.76).
- **Appearance**: `Ethnic Groups Overview.md` l.50 "Jirahar identity follows communal descent and conversion law rather than appearance."
- **"Place-law"** (her file l.214) is a canon term.
- **Structure**: eleven pieces, ten embedded opportunities, three duo finales, about ten hours (Locked Ruling l.91). Links all resolve.

### Open questions for the creator

1. **Where was the massacre, and who were the raiders?** Her files never say. The answer decides A-01.
2. **"bath" or "bat"?** The register lock says "bar / bath" (Coverage Ledger l.885). The rewritten Jirahar history writes "bat" and "ben" throughout: "Rava bat Horel", "Avileth bat Oram", "Seram ben Teth" (`Jirahar Canon Register.md` l.29–30), and the second-bend record says "*bar/bat/ben* patronymics unchanged" (`Causality Pass - 11B2 ...md` l.242). Canon now disagrees with itself. If "bat" is the rule, Ashira's name, her folder, her file names and every link to them are stale; so are the Jirahar names in the Quest Library ("Tavira bath Selan").
3. **Migdal Talga.** Canon places a fifth great tower "in the cold Eclessian marches nearest Grenzburg" and tags it `appears_in: ["Grenzburg"]` (`Migdal Talga.md` l.10, l.16). The word Talga appears nowhere in the Grenzburg game. Does a Jirahar tower with its own Keepers and court stand within reach of Ashira, and if so why do her rulings come only through a Medori factor?
4. **Is she observant?** Canon gives the Jirahar a resting day when work stops (`Cultural and Ritual Practices.md` l.24), food law (l.28), image-free worship, and "exclusion from rites" as a court penalty (Law l.38). "Marriage to an outsider requires the outsider's conversion" (Law l.30) bears on her romance. Her files are silent on all of it.
5. **Was the liability only civil?** "Jirahar internal law does not erase host criminal jurisdiction" (Keepers l.36). Did the emir's courts have a claim? And why Medori and not Jirahar credit, when "Dahava competes with Medori finance" (`Jirahar and the Wider World.md` l.32)?
6. **The Weaponize ending** (`No Human Shadow.md` l.125–127: "Overwrite the station and command its human likeness"). The ancient closure rests on "no accepted living commander" (`The Unending Muster.md` l.44), and Gerhold's acceptance "accelerates the General Below's materialisation" (l.54). Does Ashira commanding a Muster station count as living command? The quest gives it no such cost.
7. **How does her campaign become tracked?** Ylva's Campaign has a Tracking section (l.69–77); Ashira's speaks of tracked and untracked states (l.133, l.143) without saying what tracks it.
8. **Imprints from the living.** `Medium.md` records an imprint "from a defeated form" (l.43) and "suitable fresh residue" (l.96). Ashira took hers "from the killers' traces" (her file l.105), and Blackjack plates copy living runners (`Borrowed Faces.md` l.75–77). One craft or two?
9. **Merrik Voss** (`When the Screen Comes Down.md` l.99) shares a surname with Lord High Bailiff Enzo Voss. Related, or a collision?
10. `What the Ruins Repeated.md`: the "lower stair" voice comes from "a damaged signal mechanism" (l.75, l.89), yet Ashira tells the family "the wall remembers badly" (l.103). Mechanism or residue?
11. "Custody already in force at recruitment" (Campaign l.137): her file says she "secretly retained" the roster (l.111). Whose custody is meant?
12. **Sites named in her quests but absent from the location notes**: Frostfenn Muster Station (`No Human Shadow.md` l.20; the register calls Bone-Reed Pool itself the "Muster command station", l.186) and Tannbruck Road (`Borrowed Faces.md` l.20; the notes have the "Upper Grenz Military Road" and the "Tannbruck spur").

### What the new history offers

- The bank that owns her debt was made by faces of the dead. In 1345–46 "the wax faces Fiorenzians keep of their dead began to speak", the senate "burned them in the Pyre of Masks", and the ducal line descends from "a mask-maker's son" (`Present-Day Courts and Crowns (1360 AR).md` l.100). Fiorenzian citizenship is the Roll of Faces.
- The Medori vault is "the Bank of the Dead", holding the registers of unsung Sendings (`Medori Bank.md` l.34): a creditor that already keeps the dead on paper.
- Rab Yequtiel of Zanthir wrote that "a register holds the name and lets the person go"; the Keepers denounced it "as a licence for bondage" (`Jirahar Canon Register.md` l.45). A Jirahar quarrel, near Qesheth, about keeping a record of a person.
- The Hidden Words include "Name restraint: studies the moral danger of naming" (`Theological and Mystical Traditions.md` l.22); Migdal Yamma's mourning court "preserves the names of those lost without burial" (`Migdal Yamma.md` l.32).
- At the Muster's first closure "the sovereign builders' names were deliberately removed from the surviving archive" (`The Unending Muster.md` l.40): a precedent for destroying a record so that no one can claim through it.

---

## Coverage

**Slice files read in full (33).**
- CMP-03 (15): Ylva Companion Campaign; Ylva Rescue Hunter Package; Ylva Field Familiarity and Relationships; Ylva Banter and Reactivity; The Fourth Marker; A Signal Shared; The Rearguard Road; No Quarry Today; Signals Over Lantern Ward; What the Ice Takes; A Hearth Chosen; The Sister Watch; Routes for the Living; The Last Marker; The Road She Chooses.
- `30 Characters/10 Companions/Ylva Winter-Track.md`; `30 Characters/60 Personal Histories/The White-Sled Rescue.md`.
- CMP-04 (15): Ashira Companion Campaign; Ashira Shadow Roster Package; Ashira Field Familiarity and Relationships; Ashira Banter and Reactivity; The Faces She Kept; The Room That Answered; A Useful Terror; The Puppet Dies Twice; What the Ruins Repeated; When the Screen Comes Down; The Garden Under Rain; What We Keep Closed; Borrowed Faces; No Human Shadow; A Shadow with No Face.
- `30 Characters/10 Companions/Ashira bath Melan.md`.

**Canon read in full.** Locked Rulings (Current Focus Board l.57–97); the renames list (`Real-History Concordance.md` l.260–275). Ättar: Canon Register, Grey-Wolf Range, Overview, Winter War and the Grobi Frontier, Kinship (body), Ättar and the Wider World (body). Jirahar: Canon Register, Migdal Qesheth, Migdal Talga, Defence and Caravan Law, Keepers and Courts, Prophet's Roads and the Underways, Theological and Mystical Traditions, Cultural and Ritual Practices, Law Descent and Conversion, Social and Political Structure, Four Ways, Jirahar and the Wider World. Creatures: Anchored Hauntings, Corpse Residue, Residue Dead Overview. The Unending Muster. Medori Bank; Debtors' Corps. Soul Routing and the Vestibule (body).

**Canon searched or skimmed, not read whole.** Gazetteer; Present-Day Courts and Crowns; Present-Day Political Board; the Grobi pages; The Image, Soul, and Creaturely Continuity; Emirate of Zanthir Overview; The Ättar before the Great Keel-Taking; War of the Empty Halls; Halls, Jarls, and Chief-Kings; the Year of the Flame; the Coverage Ledger (l.885 only); Causality Pass 00 Proposal Index (l.189–260) and 13 Anchor Date Proposals (searched); Causality Pass 11B2 (l.242 only). All of `01 Canon Reference/` was searched for Ylva, Winter-Track, White-Sled, Snowblind, Ashira, bath Melan and Qesheth: neither companion is named in canon outside the Locked Rulings.

**Game control notes consulted** (outside the slice, to test it): Medium.md (full); Companion Debt and Remote Claims Standard and its Compliance Register (full); Grenzburg Worldspace Location Register, Season and World-State Constitution, Main Campaign State Matrix, Muster Anchor Matrix, Companion Constitution, Grenzburg Underways, Sunken Causeway, Rain Vault, Bone-Reed Pool (parts); Hunter.md and Custom Vocation Workshop (searched).

**Not checked.**
- Whether Atherian works could stand at Long Lake and Highlake (the Sunken Causeway and Rain Vault premises). That belongs to the locations slice.
- Eclessian Church doctrine on Medium practice beyond the residue pages; Shadowlands canon; Magic Systems Overview; the Folk Canon Register and Folk custom in detail.
- The Chronology and Named Figures beyond searches; the per-stretch date tables 13A–13E (the slice has no historical dates to test against them).
- The other six companions' files. Cross-checks were made only between Ylva and Ashira.
- Y-01/A-06 was not traced into the Bank and faction notes; it is reported from the canon side only.
