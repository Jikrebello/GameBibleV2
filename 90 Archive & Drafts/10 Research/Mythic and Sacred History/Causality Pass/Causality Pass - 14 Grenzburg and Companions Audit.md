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
# Causality Pass — 14 Grenzburg and Companions Audit

> [!note] Status — 15 November 2026, evening
> **Acted on.** This page was written as a report only. The creator then asked for the canon-side items, the breaks, the rewords and the cosmetics to be fixed, and they were, the same day. "What was fixed" below says what was done, which calls were judgement, and what was left. The rest of the page and the seven detail records keep the audit as it was written; their line numbers refer to the files before the fixes (commit `c5add80`).

The history was rewritten between 13 and 15 November while the game material was deliberately left alone. This page lists where the two now disagree, and where the game disagrees with itself. Seven auditors each read one slice in full and compared every statement that depends on the wider world with the canon page for it. Their reports are the detail records:

| Slice | Detail |
|---|---|
| Elara Velescar and Ilyana Veshkar | [[Causality Pass - 14A Audit - Elara Velescar and Ilyana Veshkar\|14A]] |
| Ylva Winter-Track and Ashira bath Melan | [[Causality Pass - 14B Audit - Ylva Winter-Track and Ashira bath Melan\|14B]] |
| Bernard Valeon and Dismas Raben | [[Causality Pass - 14C Audit - Bernard Valeon and Dismas Raben\|14C]] |
| Tavio Meran and Zafir ibn Samad | [[Causality Pass - 14D Audit - Tavio Meran and Zafir ibn Samad\|14D]] |
| The production bible, the region and its locations, the factions | [[Causality Pass - 14E Audit - Grenzburg World Bible\|14E]] |
| The cast, the acts and the faction questlines | [[Causality Pass - 14F Audit - Grenzburg Cast and Campaign\|14F]] |
| The quest library's adventures that lean on history | [[Causality Pass - 14G Audit - Quest Library\|14G]] |

Each companion's slice is the campaign folder, the profile, the personal histories tied to that companion and, where one exists, the in-world text in `03 Stories & In-World Texts` (*The Velescar Correspondence*, *The Froststep Packet*, *The Stonefall Papers*, *The Red Brass Papers*).

## What was fixed on 15 November 2026

All 169 findings were answered: fixed in the game files, fixed in canon where canon was the stale side, or (one) withdrawn as a false finding. Eleven commits, `979eda3` to `8ae4645`, change 232 notes, and a twelfth records this. Nothing was pushed.

**How it was done.** One writer per slice drafted exact old-to-new replacements without touching the vault. Each replacement had to match the file exactly once, each was read before it was applied, and each slice is its own commit, so any one can be reverted alone. Links were checked after every commit (no missing targets), the Chronology is still in date order, and no canon note links ambiguously in the reader.

**The false finding.** RL-03 said Birchcross cannot be "outside the atlas" because it lies on a mapped road. The Locked Ruling (*Current Focus Board*: "Birchcross and Alderway Vale remain outside the base-game atlas") and the Gazetteer both put it outside. The finding was wrong and nothing was changed for it.

### The ten decisions, as taken

1. **Dismas.** The rockfall is autumn 1349. He was twenty-three, reached the march about 1351, and every "eleven years" tied to the coach is now true.
2. **The Grobi follow canon.** Ghor has every tactical choice and no moral conscience; captives are provisions, not slaves; restraint toward separate bands rests on what humans owe. Bands signal by drum, and the Southern Horn is kept as Ghor's break with drum law. Urra stays a Grobi child: her danger is hunger and cold, with no lasting frostbite.
3. **The Medori's officers.** Canon follows the game: Lucia Medori and Marco Bellandi in *Present-Day Courts and Crowns*.
4. **Zafir's canon pages.** Malphas is generalised and the Way-Weaver sentence dropped. The two live links that used the alias "Zafir the Bound Chainmaster" now point at his name; the alias itself stays as a redirect because four frozen snapshots link it.
5. **Jirahar patronymics.** 68 "bat" became "bath" and 9 "ben" became "bar" in canon, stories and research, and three more names were corrected in the quest library.
6. **The Night of Broken Bells** is named in *Freeflame Reformation* and *The Korrheim Accord* and has a Chronology entry for 1338.
7. **The Church questline: a light touch.** The second rite is named where the quests already stand: the winter camps and the trench (*Bread and Burial*), the Chapel-Folk households (*Ash at the Door*) and one clause in *Mercy in Winter*. No quest was added or restructured.
8. **Ashira's past stays remote,** as the companion standard requires. What frightens Grenzburg is the copied face already loose in its criminal trade.
9. **Bellless Hold** is the older imperial fort, regranted to a Markish lord in the 980s, abandoned after the Standing of the Water (994), its bell taken down under the Peace of the Bent Oak (999).
10. **The duke** is `Duke Alaric von Grenzmark`. The old title stays as an alias so frozen snapshots still resolve.

### Judgement calls worth a second look

Each is small to reverse; the writers' notes give the alternative.

- **Sandro Tessari keeps his scene (EL-01, EL-06).** "He was fourteen" and "the diggers' children" stand, so he is now "not yet twenty" and no longer in his thirties, and his mother still dies in Grenzburg. The companion standard now defines `downstream-local`, the value his note and Lenka Vrana's already carry: a resident who was already in the city, not an arrival. The alternative (keep him in his thirties and cut "fourteen") loses the scene's last line.
- **The Last Convoy (A-07).** The columns withdraw north from Tann Crossing Farms; the party returns to the fort for the last wagons. The other reading, a supply run south into the fort, contradicts "pulled north" and both matrices.
- **Act II order (A-09).** The window matrix was followed against the Season Constitution: *The Emerald Trail* and *Knives Behind the Walls* both open after *The City in Siege*.
- **Falkendorf (D-02).** Korrheim has cantons and no provinces, so the coach, court and registry needed a canton. Falkendorf is the only one canon names; it is also the canton of the 1340 rising. Heldenheim is the alternative, in eight places.
- **The Black Road and Haymaker's Copse (D-07, D-12).** The Lowlands "Ash Road" collided with canon's name for the Castaran Long Road and is now the Black Road. Dismas's Act I ambush moved from Split Pine Ravine, which the register puts in the Southwood, to the ravine under Haymaker's Copse.
- **The queens (D-09).** The queens Dismas leaves on roads are lifted from other people's decks; his own stays in his coat.
- **The Black Bell (F-05).** *The First Toll* is the Bell's first planned killing "as a standing tribunal", so Vey and the siege prisoners can come first.
- **New minor names (EL-11, EL-12, IL-07).** Duplicate names needed a replacement: Tilde, Dorota Oster, Tam Two-Reeds, Jutta Helt, Arko Lund. None is used elsewhere.
- **Window names.** The Companions register and 15 quest files used window names the Season Constitution does not have. "Siege Winter" became Early and Deep Winter, "Late Winter" Deep Winter, "Open Thaw" Early Spring, "Spring Reclamation" Early and Open Spring, "Before Deep Muster" Muster Crisis, "Playable Summer" Summer Aftermath, "Postgame Summer" Postwar Cycle. The register now follows each quest file for act and window.
- **Paladin.** One line said the spring re-entry cannot earn the unlock; four other notes say it can. The one line was changed.
- **Old Tithe Vault.** Two notes disagreed about who brought the Velescar cache to Grenzburg. It now reads: Medori shipped the pledged paper; Vardek's cutouts rented a section beside it before the siege closed the roads.
- **Bent Oak Refuge (RL-10)** takes canon's spelling; the family surname Bent-Oak keeps its hyphen.

### Seen while fixing, not in the audit, left alone

- **State register rows nothing writes:** `salt_reed_roster_in_grenzburg`, `salt_reed_winter_consent`, `ilyana_celia_safe`, `ilyana_instruments_returned`, `ilyana_performer_pledges_recorded` and `hospice_cold_injury_child` (the last still says "unrepairable", against the rule that consequences are shown before the choice). Dropping identifiers is the creator's call.
- ***The City in Siege*** records `elara_winter_roofline_proven`; Elara's files and the register call it `elara_roofline_route`.
- ***Old Tithe Vault*** names "Vasko or the replacement senior retainer" where the quest has Advocate Sera Vann.
- ***The Last Convoy***: "Completion ends Open Autumn" (the controls end it at the commitment), and a defeated escort's holdfast is recovered on a withdrawal that follows only the central road.
- **Faction quest 8** of all four lines is windowed "Early Spring, Muster Crisis" and skips Open Spring.
- ***Hollow Keep*** no longer says why Hannes's death was recorded elsewhere, now that the massacre is public (HK-2). One sentence would settle it; none was invented.
- ***The Broken Tower*** conversion note still carries an older torque (the lapsed charter, "the surveyor's ransom") that is not in the full adventure.
- **Near-duplicate minor names** not in the findings: Hanne Wirth and Sister Hanne Wolkert; Mara Venn and Mara Senn; Harl Venn and Hadrik Venn.
- **`past_contact_mode: current-world`** on Karel Reed-Hand's note is not defined in the companion standard.
- **The production map** (SVG and PNG) was not touched; any label on it spelled the old way still is.

## The short version

- **The rewrite did very little damage.** No date that moved is cited anywhere in the game material. Of about seventy renames, one old name survives: "Saint Ioan Outer Fort" in Caleran, twice. The game's own years (1338, 1343, 1355 to 1360) were never touched.
- **Most findings are the game disagreeing with itself.** 93 of 169 are internal: an age that does not add up, a person in two places, a quest that opens in two different windows.
- **Where the game and canon disagree, the canon is usually older than November.** The largest cluster is the Grobi, whose canon dates from September, and the next is the Locked Rulings.
- **The rewrite does show in five places:** Wolfsmere and the Folk Wars, what the Accord says, the end of the assurance trade, the Grey Sweat's dead, and two order names.
- **In five places canon is out of date about the game,** not the other way round. Those are listed separately because they are fixed in canon.
- **The game hardly uses the Reformation.** The Church questline has no Freeflame, no Accord and no second rite in it. That is a gap to fill, not an error to correct.

## Counts

| Slice | Breaks something | Needs rewording | Cosmetic | Total |
|---|---:|---:|---:|---:|
| Elara and Ilyana (14A) | 2 | 11 | 12 | 25 |
| Ylva and Ashira (14B) | 1 | 7 | 15 | 23 |
| Bernard and Dismas (14C) | 2 | 9 | 15 | 26 |
| Tavio and Zafir (14D) | 2 | 5 | 14 | 21 |
| World bible, region, factions (14E) | 1 | 7 | 15 | 23 |
| Cast, acts, faction questlines (14F) | 2 | 15 | 10 | 27 |
| Quest library (14G) | 1 | 8 | 15 | 24 |
| **Total** | **11** | **62** | **96** | **169** |

By kind: 93 internal, 38 contradictions of canon, 21 unsupported claims about the wider world, 10 superseded by the rewrite, 7 stale names or dates.

## The eleven that break something

Finding numbers are the auditors'; the detail record gives file, line and quotation for each.

| Finding | What is wrong |
|---|---|
| D-01 (14C) | Dismas's rockfall is dated 1355 in six files, but Sella's claim, *The Stonefall Papers* and *The Name on the Charge* say "eleven years" throughout. 1355 to 1360 is five |
| EL-01 (14A) | Sandro Tessari is "in his thirties" and also "was fourteen" during Elara's digs of about 1355–57, which makes him seventeen to nineteen |
| TAV-01 (14D) | Seraf Pellan is chased through Hammer Ward in *The Signed Measure* and may be the mine agent in *Proof Under Load*. Four other files say he never enters Grenzburg |
| A-01 (14B) | Ashira's Act I finale gives the Longlake smugglers "former associates of the raider band" and families who "knew the dead raider". Her campaign file bars anyone from that past from appearing, and canon puts Migdal Qesheth far away, near Zanthir |
| IL-01 (14A) | *The Salt-Reed Company* says Ilyana's four former companions "reach Grenzburg by winter". Every Ilyana file says they stay remote |
| ZAF-01 (14D) | Two canon bestiary pages describe a Zafir storyline the game no longer has: an adversary called Malphas, and a bound Way-Weaver held by a church court. This is a fault in canon |
| B-01 (14C) | Bernard's Act III triage turns on Urra, a Grobi child who may lose fingers to frostbite. Canon makes the Grobi a regenerating lineage and says the Church disputes what they are |
| C-01 (14F) | *Ghor-Maw* says "Ghor has full moral agency". Canon gives the Grobi none, and Skrit's note already follows canon |
| A-01 (14F) | The campaign spine and the Act II notes speak of Grobi "responsibility" and Ghor's "culpability", on the same assumption |
| RL-01 (14E) | Bellless Hold is "an Eclessian occupation fort built … after the Folk Wars" whose garrison found the bell problem. Canon has the lake take the Markish shore-fort in 994, no Markish grant beyond the lake since, and the bell ban as charter law from 999 |
| ES-1 (14G) | In *The Echo Seam*, Hushfield's last toll-keeper watched Atherians close the mine (905 at the latest) and lost his post when the caravan line moved (1334 at the earliest) |

## What the rewrite changed under the game

- **Wolfsmere and the Folk Wars.** Canon now ends the fighting in 994 with the Standing of the Water and gives the bell, boat and iron ban to the Peace of the Bent Oak (999).
  - Bellless Hold has two different histories, in its location note and in its quest (RL-01 in 14E, F-04 in 14F), and neither is canon's.
  - *The First Writ* founds its fraternity in 1012, "four years after the Folk Wars formally ended" (FW-1 in 14G). Thirteen years after the Peace is right.
- **What the Accord says.** It is now a schedule of churchyards: every yard to the rite that has kept its dead sent, and a yard unsent for a year and a day forfeit.
  - The Accord Wardens of *Hollow Keep* guard roads on a "peace schedule". Canon founds them on the common-ground yards of the Night Count of 1342 (HK-3 in 14G).
  - *Hollow Keep* treats the massacre and its forged order as buried. Canon states both openly (HK-2).
  - *The God of the Open Hand* has the churches unable to act "without violating the Accord". Under the new Accord a faith with no yard has no protection at all (GO-1).
- **The assurance trade is over.** The Council abolished the sale of assurances. *The Second Brannoc* has "assurance-collectors" on the Weiss roads in 1360 (SB-1 in 14G); the collectors of 1360 work for dead-paper brokers and the Arrears-levy.
- **The Grey Sweat's dead.** Canon now has most of them burned unblessed, and Virelian bondage beginning as "the bond of the clean village", a bargain for a priest and burial in rite. Elara's "six expeditions into Grey Sweat burial sites" and her house's "sixty-three bound households" never say what the sites were or how the bond arose (EL-02, EL-03 in 14A).
- **Two names.** The Paladin file speaks of "Western orders", a usage canon dropped (PB-01 in 14E). The "Ashen Commandery" belongs to no chartered order, and canon now gives "ash" names to the Freeflame's Ashenmen, the Sweat's Ash-Walkers and the Folk's Ashen Guest Court (RL-04 in 14E, C-04 in 14F).
- **Saint Ioan.** The saint is Dovrin of Velia since the renames. *Caleran Anchor Location Register* line 127 and *Outer Crown* line 36 still say "Saint Ioan Outer Fort".

## Where the game breaks older canon or a Locked Ruling

- **The duke's name.** The Locked Ruling says the family is von Grenzmark and only the seat is Grenzburg. His note is titled "Duke Alaric von Grenzburg" and seven files use that form (PB-02 in 14E, C-02 in 14F).
- **The Grobi.** Canon (September) gives them no moral agency, no writing, drums for signals, and bodies that regenerate.
  - Ghor-Maw's "full moral agency" and "culpability" (C-01, A-01 in 14F).
  - Urra's lasting frostbite (B-01 in 14C).
  - "Horn teams", "Horn-Captain Ruk" and the Southern Horn (IL-04 in 14A, A-02 in 14F).
  - Grobi ledgers (A-03 in 14F).
- **Companions' pasts stay remote.** The companion standard says nobody from a companion's old life comes to Grenzburg. Five findings break it: IL-01 and IL-02 (Ilyana), A-01 (Ashira), EL-06 (Elara's diggers), TAV-01 (Seraf).
- **An ignored companion.** *The Fourth Marker* always sets Ylva's campaign as tracked, so a player who then ignores her gets outcomes the Locked Ruling on ignored companions forbids (Y-02 in 14B).
- **The Medori and Sestaran law.**
  - The bank holds "court-appointed custody" of a true-name cord over its own debtor. Canon makes name-binding in Corps instruments a Fiorenzian crime (ZAF-02 in 14D).
  - Maro and Seraf may be "arrested abroad", but canon gives Vorthara no law to arrest under (TAV-05 in 14D).
  - Crucible "member cities" sits badly with a Concord that has no common court (F-02 in 14E).
- **Korrheim** is a confederation of cantons seated at Heldenheim. Dismas's files treat it as one realm with "Korrheim town", one registry and "one province" (D-02 in 14C).
- **Residue.** *The Room That Answered* calls its House Echo "non-conscious". Canon grades House Echoes as able to speak, recognise and suffer (A-02 in 14B).
- **Migdal Qesheth** is "first in sacred dignity" among the towers and a routing court, not "one of the Jirahar scholarly communities" (A-03, A-04 in 14B).
- **The Old River Arsenal** is one of the five Muster anchors in canon and in the game's own location register. Its location note says it is "not a branch of the Deep Muster" (RL-02 in 14E).
- **Directions and distances.** Eclessia lies east of Thalmyria by Locked Ruling.
  - Lenka "came west" from Kedrava (B-03 in 14C).
  - Kedrava is "nine days" by drover's road (D-03).
  - The escarpment "opens south over the Lowlands", which lie north (D-04).
  - Birchcross is "outside the atlas" but on a road the atlas shows (RL-03 in 14E). *This finding was wrong: the Locked Ruling and the Gazetteer both put Birchcross outside the base-game atlas. Nothing was changed.*
  - *The Last Convoy* and *The First Summer Road* give routes that do not fit the map (A-06, A-07 in 14F).
- **An Earth month.** "Districts that went hungry in February" (EL-04 in 14A).

## Where the game disagrees with itself

- **Dates and ages.** Dismas's eleven years (D-01, D-05); Sandro's age (EL-01).
- **The campaign's sequence.**
  - Open Autumn begins at MQ-04 in one note and MQ-05 in another (A-08 in 14F). Ylva's recruitment and five faction windows hang on it.
  - The window matrix and the chapter notes disagree on what MQ-11 and MQ-13 require (A-09).
  - The Black Bell's "first planned killing" comes after earlier Bell executions (F-05).
  - Two Underworld quests exist only in a window the Dead March closes (F-06).
- **Objects and accounts.** Mirella's score case is both on the customs floor and the stolen fifth (IL-03 in 14A). *The Broken Tower* gives three accounts of one hour and two different grievances (BT-1, BT-2 in 14G). Sella's file says two things about what her record shows (D-06 in 14C).
- **Winter paper.** Vardek's offer and the Salt-Reed instruction arrive in a winter when "nothing new arrives while the city is shut" (EL-07, IL-05 in 14A).

The cosmetic findings are in the detail records.

## Where canon is out of date about the game

These are fixed in canon, not in the game files.

1. **Zafir's old storyline.** `Whisper-Mantles and Ash Advocates` line 52 and `Way-Weavers` line 60 name "Zafir the Bound Chainmaster", his adversary Malphas and a bound Way-Weaver. None is in the game.
2. **The Medori's people in Grenzburg.** `Present-Day Courts and Crowns (1360 AR)` line 96 names "Factors Gianni and Livia". The game has Ledger-Master Lucia Medori and Claims-Factor Marco Bellandi, and every companion's debt runs through them.
3. **The massacre of 1338 has no name in canon.** *Freeflame Reformation* and *The Korrheim Accord* describe it in the game's own words (a forged no-quarter order, a prisoner exchange) but never call it the Night of Broken Bells, and the Chronology has no entry for 1338.
4. **Jirahar patronymics.** The locked register says "bar / bath". Ashira bath Melan follows it, and so do two canon names. Canon otherwise writes "bat" 45 times and "ben" 6 times (Yaelith bat Coren, Seram ben Teth). Those forms date from September, and this month's renames kept them.
5. **Smaller ones.** Canon's line on the Church of Grenzburg's leaders looks older than the game's cast (F-05 in 14E). Bernard's Long Watch custom of cut cords is not on the Long Watch's canon page (B-13 in 14C).

## Decisions for the creator

1. **Dismas.** Move the rockfall to about 1349, or change every "eleven years" to five. *The auditor leans to 1349: he is then twenty-three at the rockfall and has been in Grenzburg about nine years, which also settles "he comes every year".*
2. **The Grobi.** Either the game follows canon (Ghor has every tactical choice and no conscience; Urra's danger is hunger and cold, not a lasting injury), or the September ruling is reopened. *Recommended: the game follows canon. Skrit's note already does.*
3. **The Medori's officers.** *Recommended: canon follows the game. Correct the one line in Courts and Crowns.*
4. **Zafir's canon pages.** Drop Malphas and the Way-Weaver from the two bestiary pages, or bring them back into his campaign. *Recommended: drop or generalise them.*
5. **Jirahar patronymics.** *Recommended: bring canon to the locked register, "bat" to "bath" and "ben" to "bar", 51 names.*
6. **The Night of Broken Bells.** *Recommended: give canon the name and a Chronology entry.*
7. **The Church questline and the Reformation.** Canon puts Freeflame preachers in Grenzburg's winter camps and makes every unsung grave a deadline under the Accord. The nine Church quests have neither. Whether to bring them in is a design decision.
8. **Ashira's massacre.** If it happened near Grenzburg, local people can know the raider; if at Qesheth, nobody in Grenzburg can.
9. **Bellless Hold.** Canon offers it a history: the Lake Watch, whose garrison was found on the ice in 994, or an older imperial fort regranted in the 980s.
10. **The duke's file name.** Renaming it to von Grenzmark is a file rename inside the game folder.

The detail records carry further open questions for each companion.

## What the new history offers the game

Collected from the seven reports. None of this is a correction.

- **The year and a day.** A yard unsent for a year and a day is forfeit to the other rite, so after a siege every unsung grave is a deadline. *Bread and Burial*, *The Unquiet Name* and the Paupers' Cloister already tell that story without the law.
- **The camps.** Virelian runaways walk south to Grenzburg, Freeflame elders in the winter camps "will bury anyone", and Bent Oak's elders have begun quietly attending Freeflame meetings.
- **The Peace of the Bent Oak** was won by a baptised Folk lord against the king in the bishops' own court. It is ducal charter law, and a precedent for every Compact term.
- **The Bank of the Dead.** The Medori hold the Chancery's registers of the unsung. A factor "in a debtor's coat" sold extracts in 1345 and was drowned for it. That is a precedent for Lucia's Long Book and for what a debtor can leak.
- **Faces of the dead.** The bank that owns Ashira's debt belongs to a city whose wax death-masks began to speak in 1345 and were burned in the Pyre of Masks.
- **A register holds the name and lets the person go.** Rab Yequtiel's book, denounced by the Keepers "as a licence for bondage", is a Jirahar quarrel about keeping a record of a person. It serves Ashira and Zafir both.
- **Korrheim's founding** by convict slaves, with a liberation feast at which the victims' names are read and a liberator who confessed before the assembly. Dismas's count of the dead has a native form.
- **Kedrava's refuge rule.** The monasteries that "did not drink" at Qarath's Well and refused the forfeited farms give Bernard native words for what one may accept.
- **The Blackwater pit of 1290,** where a tally-keeper read a dead chaplain's count to the widows, and the miners' twenty-three-year war, for the Highlake workers in Tavio's story.
- **The Unending Muster's hunger.** Each repair "demanded more bodies, armour and grain". Several companion stories already circle that demand.
- **The Night Count of 1342 and its common ground** give Hollow Keep and its Wardens a canon origin: a walking undercroft is exactly what the Accord could not assign.

## Method and limits

- **What was read.** The Grenzburg folder is 424 notes and about 356,000 words; the eight companions account for about 180,000 of it. The auditors read their slices in full, apart from two psychology reference files in the production bible, the map images, and production metadata such as state keys.
- **What was only scanned.** Caleran and the lighter quest-library adventures had a mechanical scan for old names and years, and no reading.
- **What I checked by hand.** Fourteen findings were confirmed against the files before this page was written: D-01, TAV-01, ZAF-01, C-01, the duke's name, the Medori factors, the Freeflame in the camps, RL-02, the Grobi drums, B-03, EL-04, FW-1, the missing name for 1338 and the patronymics. The rest are the auditors' work, unverified by me.
- **Each auditor read canon selectively.** They opened the canon pages their slice pointed to. A dependency nobody thought to look up will have been missed.
- **Some findings rest on prose, not the map.** The travel and direction findings were not measured against the map images.
- **"Unsupported" is a judgement.** Local invention is expected in a game bible. The auditors flagged it only where it reached past Grenzburg.
