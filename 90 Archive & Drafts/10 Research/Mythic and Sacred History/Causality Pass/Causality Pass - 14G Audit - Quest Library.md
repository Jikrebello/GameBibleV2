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
# Causality Pass — 14G Audit: The Quest Library

> [!note] Status — 15 November 2026
> Detail for [[Causality Pass - 14 Grenzburg and Companions Audit]]. This is the auditor's report as written, before any fix. **The fixes were applied later the same day;** record 14 says what was done under "What was fixed". Line numbers and quotations are from the files as they stood at commit `c5add80`. Paths beginning `CMP-`, `C10`, `PH` and the like are short forms for folders under `02 Playable Settings/Grenzburg/`; each report explains its own.

Audit of `02 Playable Settings/Quest Library/` against `01 Canon Reference/` as it stands on 15 November 2026. Read-only; nothing in the vault was changed.

Paths are shortened: **BA/** = `02 Playable Settings/Quest Library/Blocked Adventures/`, **MC/** = `…/Quest Library/Module Conversions/`, **CR/** = `01 Canon Reference/`. "Full" = the adventure's `— Full Adventure.md` file. L = line number.

Totals: **24 findings — 1 A, 8 B, 15 C.** No renamed name from the 15 November list appears anywhere in the Quest Library (the only hit is the game character Livia Serrat, excluded by the brief). Only one count of years is stale (*The First Writ*). Most disagreements come from what the rewrite did to the Accord, the assurance trade and the Folk Wars, and from the adventures disagreeing with themselves.

---

## The First Writ

### Findings

| ID | Where | What the adventure says | What canon says | Type | Sev. | Suggested change |
|---|---|---|---|---|---|---|
| FW-1 | BA/The First Writ/Full L74 | "In 1012 AR, four years after the Folk Wars formally ended" | CR/Peoples and Cultures/Folk/10 Foundations/Folk Canon Register L46 "Folk Wars of 985-994 AR", L54 "Peace of the Bent Oak (999) … The Folk Wars ended at the lake in 994". Same in Historical Spine of the Folk L37–40 and the Chronology L247 | Stale date (count of years) | B | Keep 1012 and say "thirteen years after the Peace of the Bent Oak" (or "eighteen years after the fighting stopped at the lake"); or move the founding to 1003 if "four years" matters |

Confirmation of the mechanical scan: the year 1012 itself is used on five more lines (First Shelter Watch-Barrow L6, L27; Fraternity of the First Shelter L6, L16; The First-Shelter Writ L6) and all of those say only "after the Folk Wars", which still holds. Only Full L74 carries the wrong count. The "four years" implies an end in 1008; canon still has one leftover of that older date in a heading, "The marches, 1008–1232 AR" (Historical Spine of the Folk L50).

### Open questions for the creator

- **Marcher soldiers near Birchcross in 1012.** The fraternity is founded by "Chapel-Folk survivors and Eclessian marcher soldiers" (Full L74). Canon says the frontier "stopped beside" the lake in 994 and that marcher rule went south "around the lake country" only with the First Southern Crusade of 1060–1067 (Historical Spine of the Folk L46, L52). I could not find a founding date for Grenzburg or its march in canon, so I cannot say whether marcher soldiers were this far south in 1012.
- **Where Birchcross is.** Birchcross.md L17 and MC/The First Writ L64 put it "one day's travel west of Grenzburg on the road toward Lakewatch". The Locked Ruling keeps Birchcross "outside the base-game atlas", and the Gazetteer (L59) says "beyond the western edge of the base-game atlas". But the game's own Lakewatch Road runs Grenzburg to Lakewatch in two days, both inside the atlas, so a hamlet one day along it would be inside too. Is Birchcross on a different, "wider" Lakewatch road?
- Canon's "Lake Watch" is Adalmar's shore-fort, destroyed in 994 (Historical Spine of the Folk L46). Is the game's town of Lakewatch meant to be its successor?

---

## The Accord's Hollow Keep

### Findings

| ID | Where | What the adventure says | What canon says | Type | Sev. | Suggested change |
|---|---|---|---|---|---|---|
| HK-1 | Full L48, L116, L310, L422, L454; Hollow Keep.md L59; The Hollow Muster.md L17; Othmar Vale.md L17 | The massacre of 1338 is "the Night of Broken Bells" | Canon describes the event but never names it: CR/History/70 Later History and Present Day/The Korrheim Accord L24 and Freeflame Reformation L108, "In 1338 a forged no-quarter order turned a prisoner exchange … into a massacre". No file under CR uses the name, including CR/Creatures/…/Hollow Sentries. Record 11F (playable-settings table) says the name is "now named in the reader articles"; it is not | Unsupported (name) | C | Either add the name to the two canon sentences, or present it in the adventure as the garrison's own name for the night |
| HK-2 | Full L66 "Publicly acknowledging the massacre would have required accusing one of the first signatory houses"; L413 (a fact that "must be proven"); L422 "enters the public record"; Hollow Keep.md L61 "without publicly assigning blame" | The massacre and the forged order are buried; proving the forgery is the adventure's prize | Both public reader articles (visibility: public) state the forgery as plain history: "a forged no-quarter order turned a prisoner exchange … into a massacre" (Korrheim Accord L24; Freeflame Reformation L108) | Contradiction (what is publicly known) | B | Decide which is hidden. Simplest: the massacre and the fact of a forged order are known; who forged it, and that the dead still walk under the keep, are what the Accord buried. Reword Full L66, L413, L422 to match |
| HK-3 | Accord Wardens.md L18–24, L36 | Wardens are assigned "to roads and watchhouses whose exclusive occupation would threaten" the Accord; they "swear to the peace schedule and assigned road" | Korrheim Accord L34: places that "would not lie still for anyone … were written down as common ground, and the mixed watches posted on them were the first Accord Wardens"; L70: Wardens tell "a walking churchyard from a man in a sheet" and escort "carrying parties … with their dead on handcarts". The Accord is now a count of graveyards (the Schedule of Yards) | Superseded in part | B | Keep the roads and watchhouses, but give the Wardens their canon origin (common-ground yards from the Night Count of 1342) and their yard and carrying-party duties; "peace schedule" should read "Schedule of Yards" |

Dates confirmed against the fixed anchors: 1338, "signed five years later" (1343), "seventeen years" of joint garrison, "buried … twenty-two years earlier" and Othmar's posting of 1352 all agree with each other and with canon.

### Open questions for the creator

- Is Hollow Keep one of the Schedule's "few dozen" common grounds? Canon would then explain why it has a mixed garrison without any change to the adventure.
- The adventure has the delegates seal the undercroft "when the Accord was signed". Canon's commissioners sat up at night in disputed yards in 1342. Did they sit at Hollow Keep, and what did they see?
- "Canon-Militant" (Full L35) is not a title found in canon. Local invention, or should it be an existing old-Church rank?

---

## The Dead Press Upward

### Findings

| ID | Where | What the adventure says | What canon says | Type | Sev. | Suggested change |
|---|---|---|---|---|---|---|
| DP-1 | Full L56 "Early Brauvalian brothers"; Abbey of the Last Lamp.md L21 "early Brauvalian clergy"; MC/The Dead Press Upward L73 | The abbey is founded in 1028 by Brauvalians | CR/Peoples and Cultures/Eclessia/70 History and Conflicts/The Rise of the Eclessian Duchies and Kingdoms L37–41: the Blank Lot is 1027 and Gervin holds "the lands that became Brauvalis"; L75 Brauvalis "grew around monastic towns" | Unsupported (wording only) | C | The date now works. Say "brothers of the middle march" or "of what became Brauvalis" |

Confirmation of the mechanical scan: this is no longer a disagreement of date. With Drossfeld moved from 1041 to 1027 the abbey is founded a year after the lot, not thirteen years before it; record 13 notes this as "a gain for Grenzburg". Only the adjective is early.

### Open questions for the creator

- None on history. Wanenbruck.md L23 says the funeral road has been used "for nine generations" while the abbey is 332 years old; this is compatible (the modern cemetery is younger than the abbey) but worth a glance.

---

## Chapel-Ford

### Findings

| ID | Where | What the adventure says | What canon says | Type | Sev. | Suggested change |
|---|---|---|---|---|---|---|
| CF-1 | Full L164 | Father Tomas spots the fraud because the apparition's phrases imitate "Chapel-Folk idiom rather than the saint's surviving sermons" | CR/History/50 Redeemer and Conversion/The Twelve Companions of the Redeemer L98–100: "Saint Elsin of the Wordless Flame … The mute shepherd … moved crowds without a word", who died "in silence" | Contradiction | B | Elsin left no sermons. Make the tell that the apparition speaks at all (it "names private griefs", Full L130–132), or compare its words with the preaching of the later Elsin-tradition missioners |

### Open questions for the creator

- The apparition claims Elsin among the Folk whose oath-secret is his unfound grave ("you will not have our shepherd", Twelve Companions L100). Should unconverted kin such as Sivra Ash-Reed react to that claim?
- The conversion note files the adventure under "Grenzburg / Folk frontier" (MC/Chapel-Ford L8–10) and the full adventure under "Southern Eclessian Frontier". Same place?

---

## The Echo Seam

### Findings

| ID | Where | What the adventure says | What canon says | Type | Sev. | Suggested change |
|---|---|---|---|---|---|---|
| ES-1 | Hushfield.md L17 "abandoned early road hamlet … the movement of the declared caravan line emptied it"; L21 "generations of repeated route declarations"; L37 "Hushfield's last keeper recorded Atherian workers passing east after closing a western mine"; Full L269, L277 | A road hamlet with generations of toll-keepers, the last of whom saw Atherians close the mine, and which was emptied when the declared caravan line moved | CR/Geography/Castaran Long Road L21: "In 1333 AR Castaran surveyors staked wells across Ash pasture … first Ash Road Peace in 1334". Declared caravans exist only from 1334; Castara was "a minor port" until 1328 (Castara Overview). The Atherian empire fell in 905 | Contradiction and Internal | A | The last keeper cannot both have watched Atherian workers (905 at the latest) and have lost his post to the declared line (1334 at the earliest). Make Hushfield a toll hamlet on the older northern caravan routes (canon has these before 1265) whose keepers handed down an Atherian entry and cadence; or drop "last keeper" for "the oldest entry in the register" |
| ES-2 | Cavora.md L19 "an old assay house"; Full L96 "former mineral office" | Cavora has an old assay house | Cavora stands on ground "granted by the Grey-Rein Banner" under the Ash Road Peace (Castaran Long Road L40), so it is at most 26 years old | Internal (cosmetic) | C | "the first assay house" or "a disused assay house" |

### Open questions for the creator

- Canon does not say that Atheria ever built roads, forts or mines in what is now Ash pasture north of Eclessia. The adventure needs an Atherian road fort, survey shaft and mine there. The Gazetteer (L71) accepts Cavora's "restricted discovery" without saying so. Confirm.

---

## Risen from the Glass

### Findings

| ID | Where | What the adventure says | What canon says | Type | Sev. | Suggested change |
|---|---|---|---|---|---|---|
| RG-1 | Full L445 "the first fully documented example of funerary ownership magic"; L449 "Estate Dead and Gilded Wardens enter the known bestiary" | The estate's behaviour is new to the world | CR/History/20 Prehistory/The Serpent Kingdom of Ishkatar L69: in "the Reclaiming" (c. 1450–1325 BR) "linked Wardens woke and walked the old ceremonial roads recovering marked metal", which "helped break the Bronze Roads" | Unsupported (wording) | C | "the first documented in the present age"; let Samir or Miriam cite the Reclaiming as precedent |

### Open questions for the creator

- None. "Buried before the Exodus" (The Glass-Risen Estate.md L18) fits the Chronology (Closing Courts c. 2400–2300 BR; the Unbinding c. 2300–2260 BR).

---

## The Court That Drank Itself

### Findings

| ID | Where | What the adventure says | What canon says | Type | Sev. | Suggested change |
|---|---|---|---|---|---|---|
| CD-1 | Azravan the Last Cup.md L17 | Azravan is "a towering court-bred descendant of the Sovereign" | CR/History/20 Prehistory/The Fall of Anshara L21: "court claims of immediate and exclusive birth from the Idol of Pride called the Sovereign remain unverified political theology" | Unsupported | C | "who claims descent from the Sovereign" |
| CD-2 | Full L76 against Six-Lantern Expedition.md L30, L38 | Full: "After Qasim died at the Gate of Conquest, Bashir offered his blood … to … prevent another death". Roster: Bashir "offered blood to save an injured porter"; Qasim is the porter and is already dead | — | Internal | C | Pick one: the offering was for Qasim while he still lived, or for the others after he died |
| CD-3 | Full L248 against Six-Lantern Expedition.md L31 | Full: Lethara's mirror is cut "without heat deformation". Roster: "the cut line and scorched threshold" | — | Internal | C | Remove "scorched" |

### Open questions for the creator

- The route log ends "on day sixteen at the Bitter Wells" (Full L155), but the Wells lie on the eight-day outward road and the expedition was expected back on day twenty-four. Was it sixteen days out, or eight?

---

## The Drake's Demand

### Findings

| ID | Where | What the adventure says | What canon says | Type | Sev. | Suggested change |
|---|---|---|---|---|---|---|
| DD-1 | Full L66 | In 1117 the drake hunted "along the upper Weiss" | Hellerbruck is on "the central River Weiss" (Hellerbruck.md L17; Gazetteer L53 "In central Brauvalis"). Canon now uses "upper Weiss" for the Brenholt iron country in Ironvale (Freeflame Reformation L44 "the iron country of the upper Weiss") | Contradiction (place name) | C | "along the middle Weiss" |

### Open questions for the creator

- None. The founding of 1117 sits comfortably after the Two Winters (1101–1103), when canon has Brauvalian abbeys taking land.

---

## The Drakesfall

### Findings

| ID | Where | What the adventure says | What canon says | Type | Sev. | Suggested change |
|---|---|---|---|---|---|---|
| DF-1 | Full L93 | Kalzaret is "where the reconquest stages" | The Reconquest ended in 1052 (a kept anchor). CR/…/Kalzaret, Bastion of the Returning Road L18: a "Reconquest fortress, and modern truce market"; Vlastrava Overview: "pressure for a new crusade" | Stale wording | C | "where the next war would stage" or "where the Reconquest once staged" |

### Open questions for the creator

- The skete is named for "the ascetic Cyrion" (The Drakesfall Vale.md L28) and is called the Cyrian Skete throughout. Canon has a city of Cyrian (CR/History/50 Redeemer and Conversion/The Temple That Would Not Burn L27, c. 246 AR). Intended echo, or a collision?

---

## The Broken Tower

### Findings

| ID | Where | What the adventure says | What canon says | Type | Sev. | Suggested change |
|---|---|---|---|---|---|---|
| BT-1 | Full L59; Torvald Ghost-Foot.md L31–33; MC/The Broken Tower L79–81 | Full: "Torvald helped them reach the top floor"; the guides are "free, injured". Torvald's page: he "recognized the seal and took him" and "does not know that Kesler entered with two local guides". Conversion: Torvald "follows them in", "holding frightened guides at spearpoint" | — | Internal | B | Three accounts of the same hour. Choose one and bring the other two files into line |
| BT-2 | Full L57 and Torvald Ghost-Foot.md L21 against MC/The Broken Tower L81 | Full: a Bank survey "condemned his family's holding on a technicality". Conversion: the Bank "used an old marcher survey to close a Ghost-Foot winter road" and never compensated "displaced households" | — | Internal | B | Choose one grievance |
| BT-3 | Full L57 against L99–101 | Torvald "cleared the top three floors himself", but Floor Three is still held by barrow-shades | — | Internal | C | "the top two floors" |

### Open questions for the creator

- The tower "changed hands three times across two centuries of frontier war" (Full L53). Canon's wars on this frontier are short and far apart: the Folk Wars (985–994), the First Southern Crusade (1060–1067), the Great Southern Purge (1158–1163) and the March of the Redeemer's Sword (1258–1261). Which three garrisons are meant?

---

## Murder at Lantern Fair

### Open questions for the creator

- "Sister Alena Naris" is a "harbor priest" (Full L103). Canon says "Thalmyric parish priests are married men" (CR/History/70 Later History and Present Day/The Grey Sweat L39). Is she a priest, or a lay chapel sister?
- Halmenth's people here are Gerhard Lenz, Bailiff Klara Wess, Hester and Gero Vallin and Niko Pell; in *The Celion Light* the same city's people are Ivana, Milena, Petar and Luka with Saltborn bynames. The first set reads as Markish. Also "Folk caravan marks" (Full L290) and Folk performers on Thalmyria's far western coast. Intended, or left over from an earlier placement?

---

## The Feast at Wanemoor

### Open questions for the creator

- "32 likely victims since 1329" (Full L117). One feast a year from 1329 to 1359 gives 31. More than one victim in some years, or a slip?

---

## Conversion notes without a full adventure

### Findings

| ID | Where | What the note says | What canon says | Type | Sev. | Suggested change |
|---|---|---|---|---|---|---|
| GO-1 | MC/The God of the Open Hand L25 | "The town's official churches can't act without violating the Accord; the party can" | Korrheim Accord L60–62: congregations "without a yard or a lord" are counted with the Unsworn; "the Accord protects none of them" and "Princes of both confessions hunt their preachers". L47: a yard "unsent for a year and a day is open to whichever rite will send them" | Superseded | B | Under the new Accord a yardless new faith has no protection at all. Re-derive the churches' paralysis from the yards: for example the Open Hand has begun sending the dead of a yard both exhausted confessions let lapse, so it now holds that yard lawfully |
| SB-1 | MC/The Second Brannoc L25, L64 | In 1360 someone is "robbing assurance-collectors and tithe-farmers along the Weiss roads" | CR/Peoples and Cultures/Eclessia/20 Faith and Worldview/Eclessian Church Overview L41: the Council of Veridance (1319–1324) "abolished assurance sales". What remains is a "gray assurance market" in Aurelia (Lives of Aurelia L36), the Great Arrears, and "dead paper" on which "brokers still press claims" (Freeflame Reformation L130–131) | Superseded | B | The targets in 1360 are dead-paper brokers' collectors, Arrears-levy collectors and tithe-farmers. Brannoc's own legend ("assurance-sellers" in the Sweat years) is unaffected |
| RA-1 | MC/The Reborn Arsenal L23 | "a Caldrian crown arsenal" | Caldria is a duchy: "Grand Duke Alric IV and War Council" (Eclessian Canon Register L36) | Contradiction (wording) | C | "ducal arsenal" or "War Council arsenal" |
| RA-2 | MC/The Reborn Arsenal L65 against L23, L62 | The arsenal and its foundry town are in Caldria, but the consequences are for "Ironvale's roads and food" | — | Internal | C | "the foundry town's roads and food" |
| SC-1 | MC/The Stone Before the Covenant L25, L64 against L56 | "beneath an Ishkatar ruin", "Ishkatar contract monument"; but the ruling says to use "mixed Ansharan ritual" | Ishkatar and Anshara are different Giant empires | Internal | C | One empire throughout |
| MG-1 | MC/The Midnight Glass L19 against L9, L54, L58 | Header: "a Brauvalis manor-town or Vortharan client estate"; frontmatter and ruling: Caldria | — | Internal | C | Correct the header |
| ID-1 | MC/The Iron Diadem L19 against L9, L54, L58 | Header: "a remote Thalmyric border range"; frontmatter and ruling: Veridun | — | Internal | C | Correct the header |

### Open questions for the creator

- **The Last Baron of Brauvalis** (L53): a "hardline confessional league" takes a river-fort and "the transfer violates the Korrheim settlement". Canon has no such league, and the Accord's rule is now about yards: "armed conversion across a signatory border is a breach" (Korrheim Accord L45). The note already lists "specify the confessional league and its legal claim" as unfinished. The league's claim will need to be written in the new terms (whose lamp the land's yards stand under).
- **The Founder's Lamp** (L55, L63): a Caldrian hill town's "Freeflame founder" lies in a crypt with an old coming-of-age rite. The reform is seventy years old (1290) and its order forty-seven (c. 1313); Caldria is an "old-Church bastion" that campaigned against reformed towns in 1310–1324 (Eclessian Canon Register L36; Freeflame Reformation L108). Is the founder a recent reformer, or an older figure whom the reformers claim, as Markish reformers claim Hedwen?
- **The Fane of the Braided Flame** (L55, L57, L61): the Fane "stands on the Velian border" yet its circles attack "Chapel-Folk settlements" and the hook is "raids around Chapel-Ford and the Commandery". The Velian States lie "between Zanthir and Thalmyria" (Gazetteer L41); Chapel-Ford is on the Folk frontier by Grenzburg. The note's own to-do (L89) admits the gap.
- **The Serpent Under Qafra** (L60) places Qafra in Al-Qahur. Canon has "the travelling court at Qafra" whose ruling of 603 began the dispute of the Fourth Seal (CR/History/70…/The Disputed Fourth Seal L35) and, separately, "the fair at Velian Qafra" (CR/History/Folk Heroes and Legendary Adventurers L36). One town or two, and does the adventure's Qafra carry the memory of 603?
- **Names across the library:** Captain Othmar Vale (*Hollow Keep*), Baron Othric Vale (*Last Baron*), Gernot Vale and Magister Othmar Veyl (*Drake's Demand*), Arcanist Odran Vale (*Breach-Week*), Othmar Harrowfen (*Into the Old Wood*). Three of these are Brauvalian. One family, or a collision?

---

## Checked and holds

- **The Accord's Hollow Keep** — 1338, 1343 and every span counted from them; "Wars of Reform" (CR/…/Military and Warfare Overview L24); a dismissed Order of the Lantern investigator; mixed-confession companies with service articles; Korrheim next to Brauvalis; the Hollow Sentries creature page. All agree.
- **The First Writ** — Chapel-Folk road chapels served by household readers, Bent Oak daughter households, the fourteen-anchor ruling, Corpse Residue, the Atherian Road Warden form: agree. Only the count of years is wrong.
- **The Dead Press Upward** — founding year (now after Drossfeld), Grey Sweat pauper galleries (Wanemoor District L47), Souls-month after first frost, the Fever Deeps, the Maw-Road and the Wane-Warren (Warrens of Woe L46–50), the Boatman's commission, the Locked Ruling on ghoul cities: agree.
- **The Feast at Wanemoor** — leans only on its own dates (1326–1328, 1329) and on Gluttony canon (Gut-Maw, Feastlings, the Long Table, "the Devourer"): agrees.
- **Chapel-Ford** — Weylan Oath-Bent's line, Chapel-Folk custom, the Weeping Courts' Weepers and Postulants, the Rival, Borrowed Saints: agree, apart from CF-1.
- **The Echo Seam** — the Ash Road Peace, the Grey-Rein grant, twelve road-days, about 650 residents, Merchant Princes, the University of Castara, the Locked Ruling that the Long Road is not Concord territory, and that the mine is not a fifteenth anchor: agree, apart from Hushfield.
- **The Celion Light** — Halmenth, the Celion mouth, Saint Naris's Tooth six miles west, Saltborn bynames, Kedrava as a principality, Qazmarid as the Sealed-Blood power on the western strait under a Caliph-Wasi, Qazmari mourning cloth and ship-kin: agree. The adventure never gives Saint Naris a gender, so the correction that he is a man does not touch it.
- **The Duke's Road** — Alderway Vale's position, its place outside the atlas, Duke Alaric and Castellan Hohenwall, the Alder-Crossing Clan, ruby drakes: agree. It cites no dated history.
- **Risen from the Glass** — Ishkatar tomb-estates and their dead owners, Avarix, the Serpent's Spine, Qasr Ilyun's breach court, burial before the Exodus: agree with the rewritten deep past.
- **The Court That Drank Itself** — Azravan, the Five Memory Cups and the Palace are named in canon (The Fall of Anshara L35–41); the Drinking Wars; the Court of Courts left unresolved; the Locked Ruling on surviving Giants: agree.
- **The Drake's Demand** — Hellerbruck as a charter town of central Brauvalis, Father Sun, gold drakes and the elder threshold: agree.
- **Murder at Lantern Fair** — Emberrise is the third month of the calendar Thalmyria shares with Eclessia; Vardessan paper and fairs: agree. No history beyond that.
- **The Drakesfall** — Vlastrava's military law and return grants, the Concord of Weights, the Gemfallen: agree.
- **The Broken Tower** — the Ghost-Foot proverb ("counts what you had yesterday"), Ledger-Master Lucia Medori, Dornwatch: agree. Its problems are internal.
- **The Tower That Kept Its Year** — canon's Weird register says Atherian astronomers "built an entire intercalary theology" around the Year of Standing Stars, and the note "explains nothing": agrees.
- **The Warren Under the Mission, The Severin Panels, The Saint of the Morning Quarter** — the Elsin tradition and Averil's fence-law; "fourteen years after the Pyre of Masks" (1346); "the relic courts smell Bruckmoor" (1243): agree.
- **00 Conversion Index** — a list of titles; nothing to check against history.
- **Other full adventures** (Breach-Week, Entombed with the Court, Into the Old Wood, No Word from Claim Seventeen, The Bailiff's Ram, The Bragging Vault, The Bright-Fire Carnival) — skimmed; none leans on dated history and nothing was seen to disagree.

## What the new history offers

- *Hollow Keep*: the Schedule's unassignable "common ground" and the Night Count of 1342 give the keep and its Wardens a canon origin; a walking undercroft is exactly what the Accord could not assign.
- *The First Writ*: Weylan Oath-Bent dies in 1012, the fraternity's founding year; the brothers' last years ("late twelfth century") follow the Great Southern Purge and the Hunt of 1163.
- *The Dead Press Upward*: Aubert, the "Ferryman Primarch" of the Ferry Rule, "died in a Brauvalis abbey in 1251", and the Ossuary Crown surfaced at a Brauvalis abbey fair that year; the ruling "the dead do not testify through things" answers Edrik and Mournfang directly.
- *Chapel-Ford*: Vessing (1352), which the Weeping Courts claim, is two years before the first apparition here; Bruckmoor "burned and salted" is the adventure's Ash and Salt ending.
- *The God of the Open Hand* and *The Last Baron*: the year-and-a-day rule on unsent yards is a ready lawful weapon for a new faith or a league.
- *The Second Brannoc*: dead paper, the second fee and the Arrears-levy give the claimant better targets than the abolished trade.
- *Risen from the Glass*: the Reclaiming is a precedent for Wardens walking out to recover marked metal.
- *The Feast at Wanemoor*: the Three Wet Years (1326–1328) coincide with the Arrears-levy (1326) and the Ironvale Merchants' War on the Weiss (1326–1334), which would explain why district relief came once.

## Coverage

- **Read in full:** every file in the fourteen named adventure folders under Blocked Adventures (114 files), their fourteen conversion notes, the ten further conversion notes named in the brief, and the Conversion Index. In the longer files I viewed lines cut at about 300 to 900 characters for the scene-by-scene halves; the cut tails were covered by whole-library searches for every AR and BR year, bare years from 900 to 1399, relative spans ("years ago", "centuries", "generations"), the old names from the rename list, and about fifty history terms. In conversion notes I read the World Egg sections completely and passed quickly over the summaries of the source modules.
- **Skimmed:** the Full Adventure file of the seven other blocked adventures (premise and central-truth sections, plus the searches above); the conversion and torque paragraphs of thirteen other conversion notes (Severin Panels, Gallows Court, Saint of the Morning Quarter, Ossuary Heresy, Tithe-House, Thirtieth Sister, Drowned Bell of Soligrad, Talga Folios, Garden of Stolen Names, Serpent Under Qafra, Gilded City of Avarix, Fane of the Braided Flame, Commandery at World's Hem); Quest Tier Doctrine and The Conversion Library (searched only).
- **Canon opened:** Current Focus Board (Locked Rulings); Concordance renames; record 13 in full; record 00; the playable-settings tables of 10F and 11F; The Korrheim Accord, Freeflame Reformation and The Grey Sweat in full; Eclessian Canon Register, The Rise of the Eclessian Duchies and Kingdoms, the Brauvalis, Wanemoor and Korrheim pages; Folk Canon Register, Chapel-Folk, Historical Spine of the Folk, Green March Kindreds; Castaran Long Road, Ash Horde, Castara; Saltborn Coast, Kedrava, Kalzaret, Vlastrava; Qasr Ilyun, Ishkatar, The Fall of Anshara; The Twelve Companions (Elsin, Naris); the creature pages the adventures cite; Gazetteer and Chronology by search.
- **Not checked:** records 09 and 11F beyond their tables; Present-Day Courts and Crowns beyond searches; whether Grenzburg's own files (first autumn muster of 1360, Lakewatch, Duke Alaric) agree with canon, which belongs to another slice; the founding date of Grenzburg, which I could not find in canon; the twenty-four conversion notes not listed above (seven belong to the skimmed adventures, seventeen are canon-locked seeds) beyond the whole-library searches.
