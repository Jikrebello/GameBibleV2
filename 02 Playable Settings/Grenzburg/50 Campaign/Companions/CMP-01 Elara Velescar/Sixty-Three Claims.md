---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Crown Heights", "Cathedral Close", "Ledger Quays"]
culture: ["Eclessian", "Virelian"]
related_factions: ["Blackjack Corps", "Duchy of Grenzburg", "Church of the Redeemer", "Vardek household", "Grenzburg underworld"]
appears_in: ["Grenzburg"]
needs: []
tags: [narrative-rewrite]
quest_class: companion
act: act-3
availability_window: ["Early Spring", "Open Spring"]
repeatability: one-shot
cutoff_result: resolves-offscreen
world_state_outputs: ["elara_household_claims_protected", "velescar_delegate_states", "velescar_claimant_priorities", "claim_substitution_state", "daria_keln_state"]
reward_unlocks: ["claimant-priority register", "Old Tithe Vault route"]
required_locations: ["Blackjack Yard", "Paupers' Cloister", "Chancery House", "Hall of Petitions", "Petition Stair", "Bridgehold"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: operation
companion_campaign_stage: act-3
quest_owner: "Elara Velescar"
quest_sequence: 8
companion_id: "CMP-01"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: preparation
estimated_hours: 0.75
gameplay_pillars: [investigation, escort, infiltration, defense, choice]
required_states: ["elara_act2_chapter_resolved", "muster_known"]
optional_state_inputs: ["kata_belyn_state", "danara_veln_state", "daria_keln_state", "vardek_escape_route", "protected_crimes_archive", "civil_review_access", "underways_route_access"]
field_experience_gate: []
companion_required: "Elara Velescar"
duo_quest: false
pause_points: ["Custody Plan Chosen"]
relationship_gate: ""
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "The Deep Muster"
autonomous_resolution: "Elara preserves a partial petition bundle; Vardek interests learn which vault records remain decisive"
changed_reentry: "The Old Tithe Vault contains substitute proof, but lost delegates and claimant instructions remain lost"
ensemble_inputs: ["Ashira bath Melan", "Zafir ibn Samad", "Bernard Valeon"]
identity_hooks: []
encounter_deck: []
persistence_scope: campaign
postgame_season: ""
emotional_rewrite_status: replace
dialogue_status: pending-rewrite
archetype_pressure: "Belonging becomes curation: test whether Elara shares social power or decides who deserves the room."
emotional_function: "Replace petition protection with an active coalition operation in which former dependants speak and organize without Elara owning their voice"
pleasure_beat: "Social sparkle, discovery, elegant risk, and making a temporary company feel chosen."
care_beat: "Elara shares credit, access, attention, and protection without making gratitude the price of belonging."
player_archetype_hooks: []
---
# Sixty-Three Claims

## Quest Function

This is Elara's short Act III operation. Instead of stealing property for House Velescar, she organizes a reverse-heist to keep other people's claims from being stolen, substituted, or converted into liabilities before [[No Lady of Velescar]].

The operation establishes what the sixty-three bound households actually want. Elara cannot perform restitution by choosing one picturesque future for all of them.

## Hook and Immediate Stake

Three Virelian delegates reach Grenzburg with certified petitions from House Velescar's sixty-three households:

- **Kata Belyn**, if available, represents former expedition laborers and households seeking complete release from inherited fines;
- **Mila Rovan**, a miller from the upper village, carries land and water-use petitions;
- **Stefan Vorel**, a river-landing cooper, carries claims concerning wages, landing shares, and the right to leave.

If Kata is dead, missing, or unwilling, burial clerk Danara Veln carries certified worker testimony without pretending to speak for the workers personally.

The petitions must be entered at the Hall of Petitions the next morning. Daria Keln, if free, has ordered Vardek retainers to:

1. replace the authentic rolls with debt acknowledgments;
2. abduct one delegate and discredit another;
3. learn which missing records inside Old Tithe Vault can defeat the remaining claims.

## Party and Staging

Elara is required and the normal party remains available. The operation stages at the Blackjack Yard after the three delegates arrive separately.

Other companions may contribute:

- Ashira distinguishes copied handwriting patterns without turning an imprint into testimony;
- Zafir exposes clauses that convert release into renewed obligation;
- Bernard may protect a delegate or public shelter without asking them to forgive Elara.

## Vocation Access

Every player vocation can protect the claims through public escort, split custody, decoy movement, witness reconstruction, or direct defense. Social statistics, knowledge, stealth, and combat change cost and exposure; none is a single required solution.

## Operation States

### Claim Bundles

Track three authentic bundles independently:

- `land_and_water`;
- `labor_and_release`;
- `burial_and_property`.

Each may be original, certified-copy, substituted, destroyed, or safely entered.

### Delegate States

Track Kata or her substitute, Mila, and Stefan as safe, watched, missing, injured, or protected. No delegate dies off-screen. An abduction opens an immediate rescue route.

### Hearing Docket 4-0

- **4:** arrival and custody planning;
- **3:** Vardek observers identify one delegate;
- **2:** a substitution team enters Chancery House;
- **1:** an abduction begins on Petition Stair or Bridgehold;
- **0:** the hearing opens with whatever claims and witnesses remain.

Delay, exposed decoys, retreat, or an escaped hostile courier advances the docket.

## Beginning: Three Arrivals

The delegates do not trust the same institutions.

- Mila wants the land petitions entered openly under ducal seal.
- Stefan distrusts title courts and prefers split copies among the guilds and Low Lantern archive.
- Kata wants worker releases separated from every offer of land so no household is forced to remain grateful.
- Danara insists burial property cannot be converted into a general compensation fund without named claim review.

The player and Elara choose a custody plan rather than selecting one delegate's politics as universally correct.

## Custody Approaches

### Public Escort

Move originals under Blackjack and ducal guard from Paupers' Cloister to Chancery House. This provides the clearest legitimacy and the most visible attack surface.

### Split Custody

Place one certified set with Chancery House, one with Paupers' Cloister, and one with a lawful guild or protected archive. Substitution becomes harder, but coordinating the hearing costs time.

### Decoy Procession

Carry sealed blank rolls openly while moving originals through service stairs, rooftops, or underways. Discovery turns the operation into a pursuit rather than invalidating the documents.

### Living Memory

Have each delegate learn the decisive claim and mark before the rolls move. Destroyed paper then increases risk and hearing difficulty without erasing every case.

## Middle: The Substitution House

Evidence leads to a rented copying room near Chancery House. Vardek's clerks are preparing:

- release documents that preserve old food and travel debts;
- land grants that return control to a reduced Velescar title;
- burial settlements that remove names in exchange for one general fund;
- testimony describing the delegates as paid Elara agents.

The party may seize the room, copy the enemy instructions, replace substituted rolls with decoys, or let one forgery move in order to identify the handler.

If Daria is alive and free, she directs the operation from a nearby service court. She can be captured, killed during resistance, or allowed to escape. If Daria is unavailable, a Vardek household captain follows her written plan with less adaptive opposition.

## End: Petition Stair

The hostile plan converges between Bridgehold and the Hall of Petitions:

- one team attempts to pull a delegate into a sealed carriage;
- one courier carries substitute rolls up Petition Stair;
- one observer marks which claim the player protects first.

Preparation, split custody, and companion skills can secure all three delegates and all claim bundles. Without them, the party must choose where to intervene personally.

Elara's defining action is whether she protects a delegate and their stated priority even when pursuing the courier would produce stronger evidence against Vardek.

## Claimant Priorities

The final entered record must preserve that households disagree:

- some want viable land in their own names;
- some want cash and freedom to leave;
- some want burial property and names restored;
- some want debts and inherited duties cancelled before any new arrangement;
- none appoints Elara to choose for all sixty-three.

The quest never asks the player to select one universal remedy. It records enough legitimate instruction for the Hall of Petitions to implement multiple remedies after the vault evidence is recovered.

## Information Redundancy

- Authenticity comes from seals, delegate memory, Danara's copies, or the copying-room instructions.
- Old Tithe Vault appears in Daria's orders, the substitute land rolls, or Vardek's prior cabinet route.
- Claimant priorities survive through the original petitions, delegate testimony, or separated household summaries.

## Fail-Forward Results

- A substituted bundle can be challenged at the hearing if the copying room or a living delegate survives.
- An abducted delegate is taken to a moving carriage or Bridge Vault room and remains rescuable.
- Destroyed originals leave certified copies with narrower legal force.
- If the party loses every paper set, the vault becomes the sole remaining proof and Act III readiness loses this asset.

## Autonomous Resolution

If unfinished at [[The Deep Muster Main Quest|The Deep Muster]], Elara preserves one complete bundle and partial copies of the others. Vardek's interests learn which vault records remain decisive. Her direction determines whether she protects delegates or title evidence first.

## Outputs

- `elara_household_claims_protected`: complete, split, partial, substituted, or lost;
- `velescar_delegate_states`: named state for each delegate;
- `velescar_claimant_priorities`: complete, partial, generalized, or erased;
- `claim_substitution_state`: exposed, seized, entered, or successful;
- `daria_keln_state`: unidentified, active, captured, dead, escaped, or previously-resolved.

## Rewards

- `elara_household_claims_protected`, an Act III preparation asset;
- the claimant-priority register used in the Hall of Petitions settlement;
- an Old Tithe Vault mark and one possible access route;
- claimant, civil, Church, and underworld reactions based on actual custody choices.

## Navigation

- [[Elara Companion Campaign]]
- [[Elara Velescar]]
- [[Kata Belyn]]
- [[Danara Veln]]
- [[Daria Keln]]
- [[House Velescar]]
- [[No Lady of Velescar]]
- [[Grenzburg City Anchor Register#District Anchors|Hall of Petitions and Chancery House]]
- [[Companions MOC]]
