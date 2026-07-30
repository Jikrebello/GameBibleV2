---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Cathedral Close", "Lantern Ward", "Outer Winter Camps"]
culture: ["Thalmyric", "Kedravan", "Eclessian", "Folk"]
related_factions: ["Order of the Long Watch", "Church of Grenzburg", "Blackjack Corps", "Folk Kindreds"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-3
availability_window: ["Early Spring", "Open Spring", "Muster Crisis"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["bernard_act3_chapter_resolved", "bernard_act3_result", "bernard_act3_finale_played", "bernard_direction", "bernard_arc_outcome", "bernard_sacrifice_state", "bernard_future_path", "open_lamp_hospice_state", "paladin_capstone_unlocked", "long_watch_field_form_blueprint", "bernard_relationship_perk", "bernard_duo_move_upgrade", "bernard_owned_greatsword_name", "bernard_summer_destination"]
reward_unlocks: ["Last Ember", "Long Watch Field Form", "Kept in the Light", "Last Watch", "Open Hand"]
required_locations: ["Mercy Hospital", "Paupers' Cloister", "West Refuge Hall", "Outer Winter Camps", "Open Lamp Hospice"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-finale
companion_campaign_stage: act-3
quest_owner: "Bernard Valeon"
quest_sequence: 9
companion_id: "CMP-05"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: finale
estimated_hours: 2.5
gameplay_pillars: [rescue, travel, protection, defense, choice, closure]
required_states: ["bernard_act2_chapter_resolved", "bernard_act3_readiness_viable", "muster_known"]
optional_state_inputs: ["bernard_west_refuge_neutral_claim", "bernard_reclaimed_patient_routes", "bernard_mixed_carer_pledge", "bernard_underways_evacuation_route", "bernard_named_store_custodians", "bernard_table_received", "bernard_second_bearer_practiced", "bernard_romance_move_upgrade", "bernard_bond_move_upgrade", "petra_ilev_response", "long_watch_return_open", "bernard_accountability_plan", "church_line_outcome", "blackjack_line_outcome", "four_hearth_compact_form", "lantern_ward_damage"]
field_experience_gate: []
companion_required: "Bernard Valeon"
duo_quest: true
pause_points: ["Hospice Site Declared", "Patients Sheltered"]
relationship_gate: "No relationship required; relationship state changes scenes and rewards, not moral resolution"
relationship_variant: ""
preparation_inputs: ["bernard_west_refuge_neutral_claim", "bernard_reclaimed_patient_routes", "bernard_mixed_carer_pledge", "bernard_underways_evacuation_route", "bernard_named_store_custodians"]
preparation_threshold: "2 of 5"
autonomous_deadline: "The Deep Muster"
autonomous_resolution: "Brina moves Bernard's viable care service into the Blackjack infirmary under open inventory control; Open Lamp remains unrealized and Bernard remains uncertain"
changed_reentry: "Grace"
ensemble_inputs: ["Ylva Winter-Track", "Ilyana Veshkar", "Zafir ibn Samad"]
identity_hooks: []
encounter_deck: []
persistence_scope: regional-milestone
postgame_season: ""
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
archetype_pressure: "Warmth becomes evasion: test whether Bernard can remain funny and loving while accepting specific judgement."
emotional_function: "Keep witnessed stores, mixed patients, triage, destination, and warned sacrifice"
pleasure_beat: "Food, absurdity, road stories, children laughing, and companionship without ceremony."
care_beat: "Bernard feeds, shelters, steadies, and tells the truth about what he takes or withholds."
player_archetype_hooks: ["Cheerleader", "Tomboy", "Goth", "Bohemian", "Jock", "Nerd", "Rebel", "Goofball", "Grey"]
---
# The Open Hospice

## Quest Function

Bernard's Act III finale asks whether his new accountability survives a crisis large enough to make concealment feel prudent again. The player and Bernard establish a mixed hospice during the Unending Muster, secure its supply routes, maintain a witnessed inventory, move patients, and hold it against residue soldiers.

The moral outcome is separate from Bernard's destination. A resolved Bernard may return to the [[Thalmyric Military Orders#Order of the Long Watch|Order of the Long Watch]], remain to establish [[Open Lamp Hospice]], or travel as a hospitaller beside a committed female romantic partner. None of those destinations alone proves his reform.

The closed quest uses the player and Bernard only. Grenzburg carers, patients, porters, guards, and faction-provided helpers are temporary NPCs outside the companion limit. Petra, Matej, and Radena remain remote.

## Unlock and Staging

Once any two Act III assets in [[Bernard Companion Campaign]] are secured, Mercy Hospital receives notice that the dead march has cut two casualty routes and will pass within reach of the outer camps. Its beds cannot absorb soldiers, debtors, displaced Folk, captured Grobi dependents, and civilians at once.

Bernard proposes converting the abandoned West Refuge Hall into a neutral lay hospice. The hall's old lamp sign gives the future institution its name. The site is defensible and near the patients, but its roof, water line, and eastern lane require immediate work.

The tracked docket displays Viable, Prepared, or Strongly Prepared readiness. Accepting the departure warning dismisses the other active companions. It states that the Deep Muster commitment will resolve Bernard's campaign autonomously, transform unresolved patients, and close the ordinary construction window.

## Preparation in Play

| Asset | Concrete advantage |
|---|---|
| `bernard_west_refuge_neutral_claim` | secures lawful mixed-patient use before sponsors arrive |
| `bernard_reclaimed_patient_routes` | preserves one spring casualty or return corridor |
| `bernard_mixed_carer_pledge` | provides carers already committed to neutral admission |
| `bernard_underways_evacuation_route` | opens a nonpublic withdrawal route without requiring underworld allegiance |
| `bernard_named_store_custodians` | supplies independent witnesses for every category of stock |

Two assets permit the hospice attempt. Three make every principal patient, route, and store objective achievable through strong play. Four or five protect one material objective from a single failure. Either `bernard_table_received` from [[Enough for Two]] or `bernard_second_bearer_practiced` from [[Watch Until Morning]] additionally prevents one exhaustion-driven physical failure. The states are mutually exclusive and never stack. Neither can declare a reserve, choose a patient, confess, or determine Bernard's outcome.

## Admission Rule

Bernard drafts a one-page field rule before accepting supplies:

> The wounded enter by need. Their uniform, debt, kindred, confession, and captivity determine security arrangements, not whether care is owed.

The rule does not require the hospice to release dangerous captives or ignore military security. It forbids using treatment as leverage for conversion, enlistment, debt acknowledgement, intelligence, or political allegiance.

The player may preserve the rule, narrow it under faction pressure, or let one sponsor claim priority. This shapes the institution but does not erase the need to defend its patients.

## Principal Cast

- [[Bernard Valeon]]: can now identify the urge to hide supplies but still fears that public stores will be wasted or taken.
- [[Claims-Factor Marco Bellandi]]: authenticates Petra's existing restitution instruction and the Long Watch's remote service record before the duo departs; he does not enter the hospice assault.
- **Neda Volk:** veteran Blackjack recovery hand who knows Bernard's jokes, his store tells, and the patients by name.
- **Sister Hanne Wolkert:** organizes triage and insists that a neutral hospice requires practical security.
- **Brina Kest:** can assign debtor porters and an open tally board.
- **Olof Reed-Kin:** Chapel-Folk route reader who speaks for patients arriving from Longlake, not for all Folk.

Only characters supported by prior faction states appear. Missing helpers are replaced by ordinary unnamed carers so no faction or companion becomes mandatory.

## Pressure States

### Patient Safety: 3 to 0

- **3:** wards are separated, exits marked, and immobile patients have assigned carriers.
- **2:** one ward is crowded or an arrival route is exposed.
- **1:** treatment continues under attack and evacuation choices become immediate.
- **0:** the hall is lost; surviving patients must be moved to the cloister or a field line.

### Witnessed Stores: 0 to 4

This measures useful supply categories counted before at least two independent witnesses:

1. food and clean water;
2. bandages and medicines;
3. fuel, blankets, and lamps;
4. tools, stretchers, and defensive stores.

Witnessing does not make supplies infinite. It prevents hidden caches and identifies honest shortage.

### Muster Pressure: 0 to 4

Pressure rises through delay, unsealed approaches, uncontrolled corpse residue, and the campaign's active anchors. It controls the final assault's strength and which routes remain open.

## Beginning: A Door for Whom

At West Refuge Hall the duo finds three groups already waiting:

- wounded marcher soldiers with a ducal sergeant;
- debtor families carrying two injured Blackjack porters;
- Chapel-Folk and Grobi dependents escorted under guard after separate fighting.

Among the Lantern Ward arrivals is a Kedravan laundress who takes a bed, a blanket, and a carer, and who will not take a bowl from Bernard's hand. She is not a scene. See [[Lenka Vrana]].

Church staff offer medicine if a priest controls admission. Ducal officers offer shields if soldiers receive first priority. Medori agents offer carts if debtor treatment is recorded against company liabilities. Folk helpers offer route knowledge if their sanctuary practices are respected.

The player can accept bounded help from any or all parties. The strongest arrangement preserves the admission rule while giving each helper a defined practical role. Rejecting every institution remains possible but lowers initial resources.

## Middle: Preparing the Hall

Three tasks may be completed in any order:

### Water and Heat

Clear the blocked river cistern, repair a stove flue, or establish a carried-water line. Warlock and an unlocked Lancewright offer technical shortcuts; every vocation can use tools, labour, and local plans.

### Wards and Exits

Open the rear cart door, mark two patient routes, and separate contagious, immobile, and guarded patients. Slayer and Fighter gain speed or defence options, but ordinary work completes the task.

### The Open Count

Bring supplies from Mercy Hospital, the Blackjack Yard, and one optional faction source. Every load is counted before witnesses and placed on a public tally board. Bernard is entrusted with no unrecorded personal store.

**And there is already something in his coat.**

Before the count began — before the player arrived, before anyone asked him for anything — Bernard set aside the last full portion of warming salve. Not for himself. For **Mika Reed-Kin's** feverish younger cousin, who came in with the Longlake arrivals in [[Beds Before Banners]] and who is eight years old and whom Bernard has been feeding since winter.

**Mika did not ask him to.** Nobody asked him to. He simply did it, the way he did the bakehouse floor at Froststep, out of love and arithmetic, and the salve is not on the board.

The taking is done. The live choice is the concealment — the same architecture as [[Little Things Missing]], at the end of the campaign instead of the start, with a name on it.

- **Named now:** he puts it on the tally before the shortage is known, as a declared reserve with a stated release condition. Supports `truthful`.
- **Named at the call:** he speaks when the allocation comes up (see the Triage Wave). Supports `truthful` at higher cost.
- **Discovered:** the witnessed count, Hanne's tally, Zafir's weight-check assist, or the allocation itself exposes it. Supports `uncertain`.
- **Maintained:** he keeps it, or shifts the account. Supports `withholding`.

### Pause Point: Hospice Site Declared

After the admission rule and site plan are fixed, the quest may pause. World pressure does not advance until resumption.

## Securing the Three Routes

The hospice depends on three short local corridors:

1. **Mercy Walk:** medicines and skilled carers from Cathedral Close;
2. **Lantern Lane:** food, porters, and refugee movement through Lantern Ward;
3. **Outer Camp Track:** incoming casualties and the emergency withdrawal route.

Each route has one grounded obstacle and one Muster obstacle. Examples include a collapsed cart, frightened crowd, wounded hostile, commanded corpse file, or rank-tablet signal. The duo can secure, reroute, or abandon each corridor. Any two routes are sufficient for the final defence; all three protect the broadest patient population.

Faction work changes available assistance, not route access:

- ducal engineers brace a lane;
- Church carers increase treatment capacity;
- Brina's debtors move supplies under an open tally;
- Folk readers mark a safer camp track;
- Low Lantern guides open a cellar evacuation path.

## The Triage Wave

A spring convoy arrives during a brief dead-march lull. The player assigns finite beds and movement support among:

- immobile wounded;
- fever and exposure patients;
- walking wounded who can defend or carry;
- guarded captives needing treatment;
- children and dependent adults.

No group is disposable. Triage determines location and urgency, not moral worth. Insight, Medicine-related background knowledge, and faction relationships provide clearer projections; the player always receives enough information to choose.

### The Shortage — intentional, undissolvable

**The wave exceeds the medicine at every preparation level.** Three assets, five assets, perfect play: the salve does not stretch to cover the cold injuries in this convoy. Preparation changes *who* bears the shortage and *how badly* — never whether somebody does.

Do not rebalance this toward sufficiency; see [[Bernard Companion Campaign]]. A hospice that can always be supplied teaches nothing about the man who hoards.

### The Allocation

Sister Hanne calls the salve for a guarded captive's child — a Grobi dependent, eight years old, brought in under escort after separate fighting, exactly the case Bernard's own one-page admission rule was written to protect:

> The wounded enter by need. Their uniform, debt, kindred, confession, and captivity determine security arrangements, not whether care is owed.

There is no salve on the board, because it is in Bernard's coat, and it is for a child he loves.

**His love breaks his law.** That is the campaign's thesis in one object, and the quest must let the player feel the pull of it: Mika's cousin is a face, the captive's child is a case, and everyone in the room including Bernard knows which one he would choose if nobody were watching.

His choice, and the outcome mapping:

- **Resolved** — he names it at the call, before discovery, and the salve goes where the rule sends it. The strongest line in his campaign is not eloquent; it is the same register as *“Open it. Write that I was afraid. Open it anyway.”*
- **Compromised** — discovered, then owned. Real service, real care, and one more thing he only said out loud after somebody found it.
- **Broken** — maintained, or blamed on the manifest, or justified by the fever chart he did not write.

### “The child required nothing”

Elara's excuse was *I did what the house required*, and the house required nothing.

Bernard's is *I did what love required* — and **the child required nothing.** Mika never asked. Nobody asked. He made a person into the reason for a lie, on his own, out of love, and the naming scene must say so plainly if it is played:

> “She never asked me. I want that written too.”

**Mika's reaction is written, not skipped.** Being made the justification for something is its own injury: an eleven-year-old who once hid two food portions for a sibling and was handled gently about it now finds out she was the reason a stranger's child went without. She is not grateful. She does not forgive him in the scene. `mika_food_state` gains a downstream note either way.

### The Silence After the Joke

Somewhere in the wave, Bernard tries the thing that has never once failed him.

The captive's child is terrified and alone in a corner of a ward full of soldiers. So he does the bit: the invented kitchen office, the grave commission, the absurd title solemnly conferred — the routine that made Hannel judge a porridge contest and a frightened passenger hold a refuge bell in the reeds.

The child does not share his language.

Nothing lands. Nobody laughs. There is no translation and no time to find one, and the guard is watching, and Bernard is standing in a room holding the only tool he has ever trusted, and it does not work here.

**He stays.** He sits down on the floor at a distance the child chooses, and he is quiet, and he is still there when the carer comes. That is the entire beat: two minutes, no dialogue lesson, nobody comments afterward.

His frontmatter names his humiliation as *the silence after the joke, when others may judge or discard him.* This is the scene where he finds out that the silence is survivable and the room does not discard him — and that he has nothing to offer except presence, which turns out to be the thing he has been claiming to offer all along.

### Pause Point: Patients Sheltered

Once assignments and stores are fixed, the quest may pause before the Muster assault. Resuming reforms the duo at the hospice with every patient and route state preserved.

## The Muster Assault

The Unending Muster does not target the hospice for theological reasons. A residue column follows old replacement orders toward Tannward and encounters the occupied hall across its route.

The assault has four production beats:

1. **Rank Call:** command residue attempts to impose formation on wounded soldiers and recent corpses outside the hall. Bernard's courage effect, physical disruption, or counter-script support breaks it.
2. **Lane Pressure:** residue files attack the weakest secured route. Patient carriers move according to the player's preparation.
3. **The Open Ward:** a wall breach forces the duo to fight among beds while preventing fire, panic, and trampling.
4. **Last Ember:** Bernard holds the central doorway while the player destroys the local rank tablet, closes the breach, or completes evacuation.

No enemy contains a trapped soul. The soldiers are corpse residue and command patterns. Funeral action may quiet residue after control is broken, but dialogue cannot persuade the formation.

## Explicit Sacrifice Rule

Bernard can die only if all of the following are true:

- Patient Safety has reached 0;
- no secured evacuation route remains;
- the player has seen the exact alternative casualties;
- Bernard offers to hold the doorway;
- the player explicitly confirms the sacrifice.

No timer, failed check, hidden approval value, or ordinary combat defeat selects this outcome. A non-sacrifice fail-forward always exists: abandon the building, lose supplies, and accept greater injuries.

## End: The Final Inventory

After the assault, Bernard performs the count before treating his own wounds. The result establishes the moral outcome.

**And the count balances.** Whatever he named or concealed, whoever got the salve, the hospice's paper is straight and its people are alive, and the night reads as a success to everyone in it.

The cost is not in the inventory. One of the two children went without warming salve on a cold night with a fever, and cold injuries in children are slow and quiet and do not present for weeks. Nobody in this quest knows. **No warning fires, no state flags it, and no dialogue foreshadows it** — it surfaces once, months later, in [[Grace]], after judgement has closed and nothing can be done.

This is intentional and flagged in [[Bernard Companion Campaign]]: **do not add a warning, a save, or a repair path.** Froststep's five became five because a number was wrong in the dark; this is one, discovered the way every harm Bernard has ever done was discovered — later, by someone else, when it was already permanent.

`hospice_cold_injury_child` records which child bore the shortage. It is written at the allocation and never displayed.

### Resolved

Bernard declared every reserve, spent stores according to witnessed need, confessed any lapse, and refused sacred or institutional immunity. The hospice remains open or relocates honestly if the hall is lost.

### Compromised

Bernard provides real service but retains a hidden reserve, relies on the player or an institution to control every possession, or accepts a preferred class of patients. He can continue doing good, but has not learned to receive or provide without concealment.

### Broken or Departed

Bernard steals from patients or the dead, hides essential stores while people suffer, falsifies the count, or uses the White Flame and Long Watch name to place himself above judgement. After a warned confrontation and repair opportunity, he leaves or is dismissed from the party.

## Destination Choice

Destination is selected only after the moral outcome is recorded.

### Return to the Long Watch

Available when `long_watch_return_open` is open and Bernard is not broken. Bellandi transmits Bernard's petition to Matej; resolved Bernard may return after the game as a lay field knight under witnessed-store conditions. Compromised Bernard enters supervised probation. No Long Watch figure arrives in Grenzburg for the decision.

### Open Lamp Hospice

Bernard remains in Grenzburg to establish [[Open Lamp Hospice]] as a lay institution with mixed carers, public stores, and bounded sponsor rights. This path is available on resolved or compromised outcomes.

### Road Beside You

Available only to a committed female romantic partner on a resolved outcome. Bernard becomes a travelling hospitaller alongside the player. He carries issued or gifted equipment and keeps no secret store. The path does not require marriage during the game.

### Continued Blackjack Service

If no destination is chosen or conditions fail, Bernard completes his existing service and remains available through summer. This is not automatically a broken ending.

## Information Redundancy

- Route danger appears through scouts, wall maps, patient arrivals, and direct observation.
- Patient needs appear through ward rolls, carers, visible conditions, and Bernard's assessment.
- Supply truth appears through seals, tallies, witnesses, and physical stock.
- Residue behavior appears through rank calls, formation marks, campaign records, and the local tablet.

## Fail-Forward Results

- Lost medicine narrows treatment and changes injuries; the hospice still operates.
- A failed route defence closes that route and shifts patients elsewhere.
- If the hall falls, a smaller field hospice survives at the Paupers' Cloister.
- If the rank tablet is not destroyed, the duo can evacuate under repeated assaults.
- If sponsors withdraw, ordinary carers preserve a reduced service.
- If the quest reaches the Deep Muster cutoff before commitment, Bernard follows the autonomous route recorded below.

## Outputs

- `bernard_act3_chapter_resolved`: played or autonomous;
- `bernard_act3_result`: resolved, compromised, broken, or departed;
- `bernard_act3_finale_played`: true or false;
- `bernard_direction`: truthful, uncertain, or withholding;
- `bernard_arc_outcome`: resolved, compromised, broken, or departed;
- `bernard_sacrifice_state`: none or chosen;
- `bernard_future_path`: long-watch, open-lamp, travelling-hospitaller, blackjack-service, or none;
- `open_lamp_hospice_state`: established, field-only, sponsor-controlled, lost, or unrealized;
- `paladin_capstone_unlocked`: full, constrained, or unavailable;
- `long_watch_field_form_blueprint`: unlocked or unavailable;
- `bernard_relationship_perk`: kept-in-the-light, last-watch, or none;
- `bernard_duo_move_upgrade`: warmth-returned, two-bearers, or none;
- `bernard_owned_greatsword_name`: open-hand or unnamed;
- `bernard_summer_destination`: order, Grenzburg, road, Blackjack Yard, memorial, or absent.

## Relationship Payoff

- A romantic partner helps Bernard pack only what has been issued or freely given. The prayer-rope bead remains his chosen symbol of receiving.
- A sworn brother performs the final inventory beside him and establishes a standing rescue rule: neither leaves a living person alone to protect property.
- Friendship receives the same destination choices except the travelling romantic path.
- A resolved or compromised romantic path grants the permanent non-slot perk **Kept in the Light**. A resolved or compromised sworn bond grants **Last Watch**.
- `bernard_romance_move_upgrade` from [[Enough for Two]] derives `bernard_duo_move_upgrade: warmth-returned`; `bernard_bond_move_upgrade` from [[Watch Until Morning]] derives `bernard_duo_move_upgrade: two-bearers`. Missing the eligible episode preserves the base move. The final inventory records the result without making it a moral requirement.
- A chosen sacrifice records Bernard's physical fate separately from his moral outcome. If that outcome is resolved or compromised, the appropriate permanent relationship perk is still learned; duo moves require Bernard in the active party.

## Autonomous Resolution

If the player commits to [[The Deep Muster Main Quest|The Deep Muster]] without joining this finale, Brina moves the viable care service into the Blackjack infirmary and controls its open inventory:

- patients receive useful care under ordinary company limits;
- [[Open Lamp Hospice]] remains unrealized;
- Bernard's future path is continued Blackjack service;
- his arc is compromised and his direction remains `uncertain`;
- he has not developed independent accountability;
- no capstone, blueprint, relationship perk, or sword-name reward is granted.

Truthful influence and strong preparation can establish Open Lamp autonomously with permanent material losses. Withholding can leave the hall sponsor-controlled, lost, or followed by a warned departure. No autonomous route selects Bernard's sacrifice, and [[Grace]] reflects rather than reopens the result.

## The Sword Named

On a player-completed resolved outcome in which Bernard survives, he names the greatsword freely given in [[A Blade Freely Given]] **Open Hand**. Compromised, broken, departed, autonomous, and chosen-sacrifice outcomes leave it unnamed without revoking his ownership.

## Rewards and Unlocks

- unlocks the Paladin capstone **Last Ember** on resolved or constrained terms according to outcome;
- unlocks the saved **Long Watch Field Form** custom-vocation blueprint on resolved or compromised outcomes;
- completes Bernard's companion technique progression;
- establishes Open Lamp as a summer service and dialogue hub when founded;
- resolves Bernard's relationship, institution, and seasonal future without fixing a setting-canon result.

These progression rewards require personal completion. A missed Act III finale fixes the autonomous settlement and grants none of them.

## Summer Reactivity

The summer game reflects patients saved, sponsor terms, the selected destination, Petra's response, and whether the prayer rope bears the freely given bead. Bernard never describes the White Flame as proof that Froststep no longer matters.

## Navigation

- [[Bernard Valeon]]
- [[Bernard Companion Campaign]]
- [[Open Lamp Hospice]]
- [[Beds Before Banners]]
- [[Enough for Two]]
- [[Watch Until Morning]]
- [[Embers Without Excuse]]
- [[The Froststep Evacuation]]
- [[Bernard Field Familiarity and Relationships]]
- [[Bernard Long Watch Greatsword Package]]
- [[Bernard Compulsion and Accountability System]]
- [[Corpse Residue]]
- [[The Unending Muster]]
- [[Grace]]
- [[Companion Field Familiarity and Duo Quest Standard]]
- [[Narrative State Register]]
- [[Companions MOC]]
