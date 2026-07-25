---
type: quest
status: archived
canon_level: obsolete
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Ledger Quays"]
culture: ["Eclessian", "Virelian", "Sestaran"]
related_factions: ["Blackjack Corps", "Medori Bank", "Low Lanterns", "Duchy of Grenzburg", "Vardek household"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-3
availability_window: ["Early Spring", "Open Spring", "Muster Crisis"]
repeatability: one-shot
cutoff_result: resolves-offscreen
world_state_outputs: ["elara_act3_finale_played", "elara_act3_result", "elara_arc_outcome", "elara_direction", "velescar_land_state", "velescar_burial_state", "velescar_title_state", "burial_repair_fund", "old_tithe_vault_state", "elara_summer_destination", "elara_relationship_perk", "elara_duo_move", "elara_duo_move_upgrade", "delver_duelist_blueprint"]
reward_unlocks: ["The Last Claim", "Delver-Duelist blueprint", "Equal Footing or Witness at My Back"]
required_locations: ["Blackjack Yard", "Ledger Quays", "Old Tithe Vault", "Hall of Petitions"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-finale
companion_campaign_stage: act-3
quest_owner: "Elara Velescar"
quest_sequence: 9
companion_id: "CMP-01"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: operation
estimated_hours: 2
gameplay_pillars: [infiltration, traversal, combat, rescue, choice]
required_states: ["elara_act2_chapter_resolved", "elara_act3_readiness_viable", "muster_known"]
optional_state_inputs: ["elara_household_claims_protected", "elara_living_claims_indexed", "elara_kata_delegation_ready", "elara_burial_provenance_matched", "elara_old_tithe_route_known", "elara_raven_line_practiced", "cabinet_integrity", "elara_vardek_verdict", "elara_patron_refused", "vasko_dren_state", "daria_keln_state", "vardek_escape_route", "danara_veln_state", "kata_belyn_state", "grave_goods_state", "coerced_diggers_state", "elara_relationship_commitment"]
field_experience_gate: []
companion_required: "Elara Velescar"
duo_quest: true
pause_points: ["Vault Route Secured", "Clearing Chamber Secured"]
relationship_gate: "Quest is ungated; final perk requires a committed romance or sworn bond"
preparation_inputs: ["elara_household_claims_protected", "elara_living_claims_indexed", "elara_kata_delegation_ready", "elara_burial_provenance_matched", "elara_old_tithe_route_known"]
preparation_threshold: "2 of 5"
autonomous_deadline: "The Deep Muster"
autonomous_resolution: "Elara races the estate interests alone; direction and readiness determine claims, title, and departure"
changed_reentry: "The First Honest Find reflects the fixed settlement and cannot reopen it"
ensemble_inputs: ["Ashira bath Melan", "Zafir ibn Samad"]
identity_hooks: []
encounter_deck: []
persistence_scope: campaign
postgame_season: ""
archive_reason: "Snapshot before romance and same-sex sworn-bond episodes were separated into distinct authored quests"
archived_from: "02 Playable Settings/Grenzburg/50 Campaign/Companions/CMP-01 Elara Velescar/No Lady of Velescar.md"
archived_on: 2026-07-25
superseded_by: "[[No Lady of Velescar]]"
---
# No Lady of Velescar

## Quest Function

This is Elara's Act III finale, an estate-cache heist followed by a short public settlement. The player and Elara race Vardek's remaining interests beneath [[Ledger Quays]], recover the records needed to separate households from title, and decide whether Elara will finally relinquish the social fiction that enabled her crimes.

The active party is only the player and Elara. Any clerk, porter, guard, claimant, or faction specialist who assists is a temporary NPC outside the squad limit.

The quest tests action before rhetoric. Elara cannot prove that people matter more than House Velescar merely by saying so in the [[Grenzburg City Anchor Register#District Anchors|Hall of Petitions]]. She must first decide what to carry out while water rises, records burn, enemies close, and the title wealth lies within reach.

## Unlock and Staging

The quest opens once any two Act III readiness assets from [[Elara Companion Campaign]] are secured. A spring flood dislodges a blocked quay culvert and exposes the old Velescar clearing mark beneath a Medori warehouse.

Three people independently confirm that the cache is being emptied:

- Danara identifies a Virelian destruction order among seized correspondence;
- Kata hears that surviving expedition hands have been offered passage for one last recovery;
- a quay porter reports armed night workers carrying archive tubes into the bonded sublevels.

Whichever witness remains available supplies the lead. If all three are lost, a customs seizure from [[The Patron's Cabinet]] names the vault and its opening tide.

Elara stages the operation from the Blackjack Yard. Accepting the quest dismisses other companions and locks the player-Elara duo until completion or an explicit pause. The tracked warning names readiness, flood risk, the three recoverable claim groups, and that crossing the Deep Muster gate fixes the autonomous settlement.

## Immediate Stakes

The [[Old Tithe Vault]] contains three independent classes of recovery:

1. **Household land records:** original rolls, boundary descriptions, service conversions, and receipts proving which Velescar households paid for their holdings.
2. **Burial claims:** provenance books, family marks, unsold grave goods, and buyer chains needed to return property and fund repair.
3. **Title and wealth instruments:** the seal of House Velescar, transferable river rights, portable coin, jewels, and claims that could restore a reduced estate.

Vardek's surviving interests intend to remove the wealth, burn the first two groups, and leave Elara holding an empty title. Early Muster residue entering through an older imperial drain is an independent danger. Neither the dead nor the vault machinery serves Vardek.

## Principal Cast

- [[Elara Velescar]]: knows the estate notation and must choose what her future is worth.
- [[Lord Marek Vardek]]: appears only if his prior state permits; otherwise his written instructions and beneficiaries drive the clearance.
- [[Vasko Dren]]: may command the loyalists if free; his prior capture or death is never undone.
- [[Daria Keln]]: may direct record destruction and substitutions if she escaped earlier operations.
- [[Kata Belyn]]: may identify worker claims and assist at the later petition hearing.
- [[Danara Veln]]: can authenticate provenance and title instruments.
- [[Ledger-Master Lucia Medori]]: may grant bounded access to the bonded stair but will protect legitimate third-party deposits.
- [[Mara Senn]]: may provide the Low Lantern route without claiming the contents.

## Operation States

### Clearance Clock: 4 to 0

- **4:** loyalists are still sorting the outer archive.
- **3:** destruction bundles are prepared and wealth cases are moved inward.
- **2:** one claim wing is threatened by fire or flooding.
- **1:** the loyalists begin their withdrawal with the title case.
- **0:** they escape with what they can carry and destroy what they cannot; the duo pursues through the flood channel.

Delay, retreat, loud entry, and failed interception advance the clock. Strong preparation, captured couriers, and disabling the vault hoist hold it.

### Flood Level: low, rising, high, or breaking

Water changes routes and hazards rather than serving as a simple timer. At high water, the flood-channel entrance closes, lower shelves become rescue spaces, and floating archive cases create alternate traversal. At breaking water, the clearing chamber begins to fail and evacuation becomes the climax.

### Recoveries

Track `land_records`, `burial_claims`, and `title_wealth` as **secured**, **contested**, **damaged**, or **lost**. A recovery becomes secured only when it reaches a protected cache, named temporary ally, or the surface.

## Preparation and Entry

The duo may secure one or more routes before committing. Each route changes the starting room and preserves a different resource.

### Medori Bonded Stair

Lucia grants supervised access if Bank standing, cabinet evidence, or a civil order is sufficient. The route begins near the clearing chamber and protects the title case from ordinary looting, but loyalists see the party coming and begin burning burial records.

The player may also force or counterfeit access. This keeps the route but creates a later Bank claim and starts with increased Exposure.

### Low Lantern Bridge-Vault Route

Mara's people reveal a forgotten maintenance walk from the bridge cellars. It reaches the land-roll gallery before the loyalists and provides a safe record cache. In return, the player must keep uninvolved night workers out of ducal prosecution; this does not excuse any killer or Vardek loyalist found inside.

### Exterior Flood Channel

The duo enters from the riverworks at low tide, using pilings, culvert chains, and a broken imperial drain. It is available without faction support and offers the best surprise, but begins among Muster residue and closes as water rises.

Every route is viable for every player vocation. Locksmithing, Free Running, Tracking, cultural knowledge, and Elara's delving skill reveal shortcuts or safer recoveries rather than mandatory access.

### Pause Point: Vault Route Secured

The quest may pause after a route is prepared but before entry. Resuming reforms the duo at that route's staging point.

## The Old Tithe Vault

### 1. Receiving Cellars

Old cargo cages and tally bays establish that the vault stored movable estate wealth during earlier wars. Loyalist porters may surrender if shown Vardek's abandonment orders or offered safe testimony. Attacking surrendered workers damages Elara's approval and the petition evidence.

### 2. Land-Roll Gallery

Boundary rolls hang in sealed copper tubes above a flooded floor. Loyalists have mixed genuine records with household debt copies and prepared the originals for burning. The duo can:

- identify the genuine series through Elara's childhood lessons;
- use tax endorsements or Danara's copy sequence;
- lower the entire rack onto a cargo float;
- sacrifice speed and carry families' rolls individually.

The threat is human opposition, smoke, unstable shelving, and rising water. No supernatural test decides land ownership.

### 3. Burial Provenance Room

The room contains unsold objects and the master provenance ledger from the six expeditions. Early Muster residue pushes through the imperial drain as coordinated but non-conscious command patterns. It attacks living movement and attempts to reform around old labor tools.

Elara's darts do not affect residue. Faultfinder can break anchor fittings, while any player vocation can disable the patterns through physical destruction, White Flame support items, prepared warlock counters, fire, or controlled flooding.

If the duo previously restored names and protected workers, the correct shelves and safe handling order are already known. Otherwise the player must choose between a slower complete recovery and keeping pace with the title case.

### 4. Title Cistern

The seal, portable wealth, and river claims are suspended in a dry cage over an old cistern. Vasko or the replacement loyalist commander makes the principal stand here.

- If Vasko escaped twice, he has studied Elara's habits and uses false ledges, powder, and a prepared exit.
- If he escaped once, he commands the defence but lacks a second retreat.
- If captured or dead, a Vardek household captain holds the room with more soldiers and less delving knowledge.
- If Vardek remains free, he may speak from the escape gallery or join the final withdrawal.
- If Vardek is arrested or dead, competing beneficiaries argue over the case and can be divided.

No branch resurrects or preserves either antagonist. Both may be captured, killed in justified resistance, or escape only through the current state and player action.

### 5. Clearing Chamber

The three archive paths meet at the old hoist. Fire from the land gallery, water from the drain, and combat damage can begin a structural failure. The player and Elara must secure recoveries, rescue temporary allies, and choose an evacuation route.

Three readiness assets, a controlled Clearance Clock, or equivalent strong play makes all three recoveries achievable. Four or five assets add a protected cache or evacuation route. Otherwise Elara asks what goes first. Choosing land or burial records ahead of the title is the clearest evidence that she has rejected her central lie, but the final outcome also accounts for her conduct across the complete campaign.

If `elara_raven_line_practiced` is true, Elara and the player can split across a rehearsed anchored route during the collapse and preserve one additional person or recovery. This never changes what Elara chooses to prioritize.

### Pause Point: Clearing Chamber Secured

Once enemies are defeated and at least one recovery is protected, the quest may pause before the public settlement. Resuming begins at the Hall of Petitions with the exact recovered evidence and witnesses preserved.

## Final Opposition

The principal opponent is determined by prior outcomes:

- **Vardek free:** Vardek attempts to leave with the title case and offers Elara one final partnership.
- **Vardek arrested:** his steward carries instructions to destroy household and burial claims.
- **Vardek dead:** his heirs' factor tries to secure portable value and blame all destruction on Elara.
- **Vasko free:** Vasko controls the physical withdrawal and may abandon Vardek's interests to save himself.
- **Daria free:** Daria controls substituted records and may burn title evidence to preserve her account chain.
- **All principals removed:** frightened retainers and commercial beneficiaries become divisible opposition rather than a substitute mastermind.

Accepting Vardek's restoration offer in [[The Patron's Cabinet]] does not lock the player into failure. Elara receives one explicit repudiation: surrender the title seal, save the claims, and testify that the agreement was corrupt. Repudiation costs the easiest wealth recovery and may expose her to additional judgement, but restores the resolved path if her wider conduct supports it.

## Fail-Forward Results

- If the bonded stair is denied, the flood channel remains physically available.
- If the Low Lantern route is lost, quay construction marks identify the bridge-vault door.
- If fire destroys one land-roll rack, household receipts and boundary copies preserve partial claims.
- If the provenance book is damaged, recovered objects, Danara's copies, and named testimony preserve restitution at greater cost.
- If the title case escapes, the household and burial settlement can still proceed; pursuit determines only title wealth and antagonist state.
- If the duo is defeated, loyalists leave them in the breaking vault. Escape becomes a rescue sequence and at least one hidden document case survives.
- If Elara is Strained, she still completes the operation. A warned post-vault confrontation determines repair, compromised resolution, or departure.

## Hall of Petitions Settlement

The coda is concise and public. The surviving records, witnesses, earlier confessions, and Elara's vault priorities determine which dispositions are actually possible. No single speech erases missing proof or prior harm.

### Resolved: No Lady of Velescar

Elara relinquishes the title and seal, transfers viable holdings to their resident households under locally workable tenure, establishes a burial-repair fund from recovered wealth, and submits remaining personal liability for judgement. She keeps only freely awarded delving equipment and remains an ethical adventurer.

This result requires a consistent preference for living workers and named claims, plus land or burial evidence sufficient to act. It does not require every treasure or antagonist outcome to be perfect.

### Compromised: The Lesser House

Elara compensates households and funds partial burial repair but preserves a reduced title, river income, or private reserve. She accepts responsibility without surrendering the hierarchy that helped her rationalize abuse.

This remains a playable, stable outcome. Her summer behavior is more formal and controlling, and some former diggers refuse reconciliation.

### Broken or Departed: House Restored

Elara conceals wealth, destroys or abandons claims, renews Vardek's patronage, or uses the Muster crisis to restore House Velescar above its households. After one explicit confrontation and repair opportunity, she leaves the Blackjacks if the player refuses to support the restoration.

If the player actively supports it, she may remain through the immediate crisis as a compromised ally but is recorded as broken for her personal arc. No romance or sworn-bond reward unlocks from this state.

## Outputs

- `elara_arc_outcome`: resolved, compromised, broken, or departed;
- `velescar_land_state`: household-transfer, mixed-tenure, court-sale, restored-house, or records-lost;
- `velescar_burial_state`: full-restitution, funded-repair, partial-claims, private-retention, or records-lost;
- `velescar_title_state`: relinquished, reduced, restored, destroyed, or absconded;
- `burial_repair_fund`: endowed, limited, unfunded, or diverted;
- `old_tithe_vault_state`: preserved, flooded, burned, collapsed, or stripped;
- `elara_summer_destination`: field-delver, claims-steward, lesser-lady, restored-lady, or departed;
- `elara_relationship_perk`: equal-footing, witness-at-my-back, or none;
- `elara_duo_move`: crossed-measure, back-to-back, or none;
- `elara_duo_move_upgrade`: second-beat, held-line, or none;
- `delver_duelist_blueprint`: unlocked or unavailable;
- `elara_act3_finale_played`: true;
- `elara_act3_result`: played-resolved, played-compromised, played-broken, autonomous-resolved-costly, autonomous-compromised, or autonomous-broken;
- `elara_direction`: accountable, mixed, or entitled.

## Relationship Resolution

A committed relationship is tested by the vault, not replaced by it.

- A resolved romance grants **Equal Footing** as a permanent non-slot perk and retains **Crossed Measure**, upgraded to **Second Beat** if [[Raven Shelf at Dawn]] was completed.
- A resolved sworn bond grants **Witness at My Back** as a permanent non-slot perk and retains **Back-to-Back**, upgraded to **Held Line** if Raven Shelf was completed.
- A compromised outcome still grants the learned perk and duo move, but the summer scene acknowledges the unresolved hierarchy.
- A broken outcome grants no relationship reward because the Act III finale is the perk unlock. If Elara departs or dies after a resolved or compromised completion, the learned perk remains while the duo move becomes unavailable without her.

The final private scene takes place on the repaired Blackjack Yard roof or beside the summer road. Elara does not ask to be forgiven on behalf of the people she harmed. She asks whether the relationship can continue with the truth kept visible.

## Combat and Progression Rewards

- **The Last Claim:** Elara prioritizes a marked weak point after the player breaks armour or guard and extends the opening with a precise thrust.
- **Delver-Duelist blueprint:** unlocked on resolved or compromised outcomes for the metagame custom-vocation workshop.
- final relationship perk and duo move, where committed;
- recovered estate wealth or claimant support according to the settlement;
- outcome-dependent Act III evacuation, archive, and summer reconstruction support.

The blueprint contains Elara's coherent rapier, pick, dart, mobility, and appraisal package. It does not add a ninth authored vocation or alter the player's native Slayer.

## Autonomous Resolution and Cutoff

The final commitment warning before [[The Deep Muster Main Quest|The Deep Muster]] names this quest. If left incomplete, the clearance happens during the crisis:

- accountable and Prepared Elara relinquishes the title and protects household land, but one material claim group or fund is permanently lost;
- mixed Elara cancels household obligations and grants meaningful working rights while retaining a reduced title and private reserve;
- entitled or Strained Elara restores the house through concealed wealth or destroyed claims and may depart;
- available Ashira preserves one burial-provenance set;
- available Zafir exposes one substituted title liability;
- no permanent relationship perk, capstone, or blueprint unlocks from an unplayed finale.

This deterministic result closes the adventure without pretending the vault waited indefinitely. [[The First Honest Find]] reflects it and cannot reopen the Hall of Petitions.

## Navigation

- [[Elara Velescar]]
- [[Elara Companion Campaign]]
- [[House Velescar]]
- [[Lord Marek Vardek]]
- [[Vasko Dren]]
- [[Daria Keln]]
- [[Kata Belyn]]
- [[Danara Veln]]
- [[Sixty-Three Claims]]
- [[Raven Shelf at Dawn]]
- [[The First Honest Find]]
- [[Old Tithe Vault]]
- [[Ledger Quays]]
- [[Grenzburg City Anchor Register#District Anchors|Hall of Petitions]]
- [[Elara Delver-Duelist Package]]
- [[Elara Field Familiarity and Relationships]]
- [[Companion Field Familiarity and Duo Quest Standard]]
- [[Companions MOC]]
