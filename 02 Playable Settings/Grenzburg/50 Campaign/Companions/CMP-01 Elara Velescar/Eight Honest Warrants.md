---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Ledger Quays", "Bridgehold", "Crown Heights"]
culture: ["Eclessian", "Virelian", "Sestaran"]
related_factions: ["Blackjack Corps", "Medori Bank", "Vardek household", "Church of the Redeemer"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-2
availability_window: ["Early Winter", "Deep Winter"]
repeatability: one-shot
cutoff_result: resolves-offscreen
world_state_outputs: ["elara_warrant_casket_key", "eight_warrants_state", "vardek_relief_route_state", "hidden_payment_strip_state", "warrant_courier_state"]
reward_unlocks: ["Warrant Casket Key", "sealed-container callouts"]
required_locations: ["Blackjack Yard", "Grain Stairs", "North Quay Warehouses", "Bridgehold", "Crown Granary"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: operation
companion_campaign_stage: act-2
quest_owner: "Elara Velescar"
quest_sequence: 5
companion_id: "CMP-01"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: preparation
estimated_hours: 0.75
gameplay_pillars: [social, infiltration, moving-vehicle, pursuit, protection]
required_states: ["elara_act1_chapter_resolved", "winter_strands_open"]
optional_state_inputs: ["elara_public_culpability", "elara_sixth_fieldbook_secured", "lucia_long_book_state", "winter_grain_credit", "rooftop_network_state"]
field_experience_gate: []
companion_required: "Elara Velescar"
duo_quest: false
pause_points: ["Convoy Approach Chosen"]
relationship_gate: ""
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "Ghor at the Gate"
autonomous_resolution: "The relief arrives, but Vardek moves the cabinet without exposing its key"
changed_reentry: "Danara can reconstruct part of the route during Cabinet After Snow; the preparation asset remains lost"
ensemble_inputs: ["Zafir ibn Samad", "Ilyana Veshkar", "Bernard Valeon"]
identity_hooks: []
encounter_deck: []
persistence_scope: regional-milestone
postgame_season: ""
---
# Eight Honest Warrants

## Quest Function

This is Elara's short Act II operation. It prepares [[The Patron's Cabinet]] by teaching the party how Vardek hides culpable records inside useful relief without making the relief itself fraudulent.

All eight warrants are genuine. Every one can feed people. The operation succeeds by separating evidence from food, not by proving that Vardek has never done good.

## Hook and Immediate Stake

Danara sends a copied packing notation to Elara. Vardek's winter delegation will unload eight sealed grain-warrant caskets at the Grain Stairs, carry them across the city, and present them at Crown Granary before distribution to hospitals, refugee kitchens, and outer camps.

One casket has a false floor containing:

- the measuring key for Vardek's travelling cabinet;
- payment strips linking the Black Lime buyers to his household;
- the winter transfer route from Grenzmark Keep to Ledger Quays.

Vardek assumes no opponent will risk delaying eight genuine deliveries to seize one hidden record.

## Party and Staging

Elara is required and the normal party remains available. The operation stages at [[Blackjack Yard]], where the player chooses an approach and assigns ordinary winter equipment.

Companion contributions are optional:

- Zafir can identify which seals prove custody without treating possession as moral ownership;
- Ilyana can plan a moving inspection that does not stop the convoy;
- Bernard can keep a broken sled's grain moving while the party follows the evidence.

## Vocation Access

Every player vocation can complete the operation through observation, timed movement, controlled inspection, a physical casket switch, or interception at a scheduled stop. Elara can create a cleaner opening, but she is not the only means of copying the evidence or preserving the convoy.

## Principal Cast

- **Elara Velescar:** knows Vardek's habit of concealing private movement inside public ceremony.
- **Danara Veln:** supplies the notation but cannot appear openly without being removed from the delegation.
- **Courier-Master Soren Valek:** Vardek's disciplined convoy officer, aware that one casket is special but not told what it contains.
- **Mira Solt:** Crown Granary receiver who needs all eight warrants registered before evening distribution.
- **Lucia Medori:** may provide a neutral logistics copy if her faction line permits, without endorsing seizure of the food.

## Operation State

### Delivery Integrity 8-0

Each warrant begins intact. Reckless seizure, abandoned sleds, fire, or lost seals can reduce the total. An intact casket arriving late still feeds people after delay; a destroyed seal requires costly revalidation.

### Courier Suspicion 0-3

- **0:** ordinary relief movement;
- **1:** guards compare faces and seals;
- **2:** the special casket changes sleds;
- **3:** Valek removes the false-floor packet and attempts a separate courier escape.

### Distribution Clock 4-0

The clock advances through delay, failed inspections, retreat, or obvious pursuit. At 0 the grain enters public distribution and the evidence packet leaves by the safest surviving route.

## Beginning: Grain Stairs

The eight caskets are visually identical, but the hidden one can be identified through three independent signs:

1. a slightly shortened lower iron band;
2. a Virelian cabinet-maker's seventh-pin sequence;
3. a weight discrepancy recorded in Danara's copy.

The player may:

- join the receiving crew under Blackjack warrant;
- observe from warehouse roofs and mark the correct sled;
- enter the convoy as temporary security;
- inspect seals through Medori or Crown Granary authority;
- follow the caskets without revealing interest.

A failed social check raises Courier Suspicion. It never ejects the party from the quest.

## Middle: The Moving Relief

The convoy divides after the Grain Stairs:

- three caskets move along Ledger Quays;
- three cross [[Bridgehold]] toward Cathedral Close;
- two take the Crown Road to the granary.

Valek transfers the hidden casket between routes when suspicion rises. The party must keep visual or material contact while winter crowds, narrow bridge traffic, a broken axle, and an overloaded handcart interrupt the line.

The broken axle is ordinary neglect, not Vardek sabotage. Leaving it unresolved loses one delivery. Repairing it personally, assigning a companion, or calling prepared granary workers preserves the grain while the player continues.

## Extraction Methods

### Copy in Motion

Board the correct sled, open the false floor beneath its tarpaulin, make a wax or charcoal copy of the measuring key, and return the payment strips. This preserves concealment and all deliveries but gives Vardek more time before he realizes the route is known.

### Controlled Inspection

Divert one casket into a public weighing bay while the other seven continue. The party needs physical signs or a recognized authority to avoid a general stop. This produces the strongest evidence chain but raises suspicion.

### Casket Switch

Prepare an empty granary casket with matching weight, switch it during the Bridgehold bottleneck, and return the genuine warrant before registration. Failure creates a pursuit, not a lost quest.

### Courier Intercept

Allow Valek to extract the packet at Suspicion 3, then pursue him through bridge galleries, lower stairs, and a waiting river sled. This is the most combat-capable route but risks the evidence leaving the food convoy entirely.

## End: The Honest Eighth

At Crown Granary, Mira Solt reads each warrant aloud and registers the receiving kitchens. Elara must decide how to handle the hidden evidence:

- copy it and let all eight caskets complete public registration;
- seize the packet under named evidence custody while preserving the warrant;
- take the whole casket as leverage, delaying one-eighth of the relief;
- quietly return the packet to Vardek in exchange for his promise of access.

The first two secure the preparation asset. Deliberate relief leverage moves `elara_direction` toward entitled even when it produces useful evidence. Returning the packet strengthens Vardek's Act II position.

## Information Redundancy

- The cabinet key can be copied from the false floor, reconstructed from its pin scars, or supplied later by Danara at greater risk.
- The transfer route appears on the payment strips, Valek's sled orders, or Lucia's logistics copy.
- All warrants' legitimacy is established by granary registration, independent mill seals, and the named receiving kitchens.

## Fail-Forward Results

- If the wrong casket is opened, the party discovers a genuine recipient list and gains another chance at higher suspicion.
- If Valek escapes, his sled marks still reveal the general cabinet route while the exact key is lost.
- If a warrant seal breaks, the grain is quarantined for revalidation rather than vanishing.
- If the party is defeated, dockworkers recover the food; Vardek keeps the evidence and receives warning.

## Autonomous Resolution

At [[Ghor at the Gate]], all eight warrants reach their recipients if the operation was never attempted. Vardek removes the hidden packet and changes the cabinet sequence. Elara gains no readiness asset, but the public relief remains real.

## Outputs

- `elara_warrant_casket_key`: copied, seized, reconstructed, returned, or lost;
- `eight_warrants_state`: eight-delivered, delayed, partially-delivered, or damaged;
- `vardek_relief_route_state`: known, partial, changed, or unknown;
- `hidden_payment_strip_state`: copied, civil-evidence, Vardek-held, or destroyed;
- `warrant_courier_state`: cooperative, captured, injured, escaped, or dead.

## Rewards

- `elara_warrant_casket_key`, an Act II preparation asset;
- a material winter-supply improvement for every warrant delivered;
- Elara gains a contextual callout for false floors and substituted sealed containers;
- faction reactions based on evidence custody rather than blanket approval.

## Navigation

- [[Elara Companion Campaign]]
- [[Elara Velescar]]
- [[Danara Veln]]
- [[Lord Marek Vardek]]
- [[A Better Wager]]
- [[The Patron's Cabinet]]
- [[Ledger Quays]]
- [[Bridgehold]]
- [[Grenzburg City Anchor Register#District Anchors|Grain Stairs and Crown Granary]]
- [[Companions MOC]]
