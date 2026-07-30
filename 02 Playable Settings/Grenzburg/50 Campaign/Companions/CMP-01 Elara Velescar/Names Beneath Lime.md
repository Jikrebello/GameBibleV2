---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Ledger Quays"]
culture: ["Eclessian", "Virelian"]
related_factions: ["Blackjack Corps", "Grenzburg Customs"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-1
availability_window: ["Early Autumn", "Open Autumn"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["elara_introduction_complete", "elara_first_admission", "lime_names_state", "jonas_feld_state", "silkhook_broker_state", "elara_heroic_account_state"]
reward_unlocks: ["Appraiser's Cut", "Elara appraisal service"]
required_locations: ["Blackjack Yard", "Customs Hall", "Quarry Steps", "North Quay Warehouses", "Grain Stairs"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: introduction
companion_campaign_stage: introduction
quest_owner: "Elara Velescar"
quest_sequence: 1
companion_id: "CMP-01"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: open-world-window
relationship_variant: ""
preparation_inputs: []
preparation_threshold: ""
encounter_deck: []
postgame_season: ""
estimated_hours: 1.25
gameplay_pillars: [investigation, infiltration, rescue, pursuit, urban-combat]
required_states: ["elara_recruited"]
optional_state_inputs: ["underways_route_access", "church_record_trust", "blackjack_rank_admitted", "rooftop_network_state"]
field_experience_gate: ["elara_first_outing_complete"]
companion_required: "Elara Velescar"
duo_quest: false
pause_points: ["Customs Inquiry Complete", "Warehouse Located"]
autonomous_deadline: "The Last Convoy"
autonomous_resolution: "Elara recovers part of the property with a glamorous Yard team, but Jonas remains blamed and unnamed workers disappear from the report."
changed_reentry: "The Scarred Mounds exposes the omitted people and missing property during winter."
ensemble_inputs: ["Ashira bath Melan", "Bernard Valeon", "Dismas Raben", "Ilyana Veshkar", "Tavio Meran", "Zafir ibn Samad", "Ylva Winter-Track"]
identity_hooks: ["Merchant/Craft", "Underworld", "Peasant/Labour", "Nobility", "Scholarly"]
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
archetype_pressure: "Elara can make the pursuit heroic; the test is whether the porter, forced crew, and record workers become subjects rather than supporting color."
emotional_function: "Introduce her brightness, competence, culpability, and instinct to curate one exciting public account."
pleasure_beat: "Dockside deduction, disguises, crane traversal, and a moving-barge finish."
care_beat: "Elara uses her visibility to clear Jonas and lets quieter witnesses own their part of the story."
player_archetype_hooks: ["Cheerleader", "Tomboy", "Goth", "Bohemian", "Jock", "Nerd", "Rebel", "Goofball", "Grey"]
persistence_scope: local-persistent
---
# Names Beneath Lime

## Premise

Dock porter **Jonas Feld** opens a crate after caustic lime burns through its boards. Inside are funerary cups, identity tablets, cloth, and grave fittings listed as lamp parts. Elara recognizes shallow survey cuts she made during one of her six Virelian expeditions.

Customs arrests Jonas. A local receiving crew called the **Silkhooks** begins removing the rest of the shipment before sunset. They are liquidating property purchased remotely through [[Lord Marek Vardek|Vardek]] intermediaries; nobody from Elara's former life is present.

## What Is Already Known

Elara arrives in Grenzburg convicted, and the city knows it. Koss introduced her to the Yard as the famous grave lady — useful, watched, cheaper than she looks — because visible leverage is the only kind he trusts. Some debtors find it glamorous. [[Perle Winkel]] finds it tragic and romantic and says so, at length, to anyone near the linen.

So this quest is not about whether the past comes out. It is about whether **these** cups, **this** manifest, and **this** warehouse are hers, said out loud, in a building where Customs is taking notes.

`elara_first_admission` records that specific claim, not the general one:

- **full:** she names the cut, the expedition, and the chain in the Customs Hall, on the record;
- **private:** she tells the player and Marta's clerk and no one else;
- **evasive:** she confirms the survey style is Virelian and lets the inference sit;
- **refused:** she says nothing, and the lime, the cut geometry, and the remote purchase copies establish it anyway, later, worse.

The distinction runs the whole campaign. Her shame is not news. Her specifics are evidence.

## Party and Pressure

The normal party remains available. Elara is required but never the only route or clue solution.

`Manifest Clock 4-0` advances through delay, loud retreat, or escaped couriers. At 0 the warehouse burns and its barge departs. The quest becomes a rescue and pursuit instead of failing.

`Fire State` is contained, spreading, or quay-threatening.

## Beginning: Customs Hall

Three independent clues clear Jonas:

- lime under the later dock packing came from burial stabilization;
- his burns prove he opened the crate after leakage;
- a handcart left with the document case before his arrest.

Elara sees her cut and says, too lightly:

> “That triangle is mine. I was very proud of its consistency.”

The player can ask what that means, pursue the cart first, or protect Jonas's household. Elara admits command responsibility without being forced into a public spectacle. Concealment remains possible and carries later cost.

Jonas has burns up one forearm and has been answering questions for six hours. He gives the wheel mark, in order, twice, because the first clerk did not write it down. When Elara begins to say what she intends to do for him he asks whether she will be clearing his name before or after she makes a lovely speech over the cups, and then he asks for water, and then he stops talking to her for the rest of the scene.

Across the water, a crane-hand on the North Quay platform stops working to watch the Customs crowd. He is looking at Elara. She does not see him, and nothing marks him. (See [[Sandro Tessari]].)

## Middle: Quarry Steps

Any two clues find the Silkhook warehouse:

- blue cord caught on a rail;
- a square-repaired wheel;
- a customs tally in a drain;
- a lamp child who saw the roof courier;
- an Underworld contact who recognizes the receiving knot.

The chase crosses stairs, laundry bridges, and quay roofs. Catching the courier preserves the office key and buyer list. Losing them advances the clock and reveals the destination.

### Approaches

- **lawful seizure:** establish contraband in place;
- **false buyer:** use culture, status, disguise, or trade knowledge;
- **roof route:** rent gear or use public maintenance access;
- **loading drain:** clear unstable masonry beneath the office;
- **direct breach:** fight through the loading floor while workers flee.

All vocations can complete every route. Elara shortens appraisal and traversal interactions.

## Warehouse Fire

The Silkhooks are led locally by broker **Jorek Sile**, an elegant receiver who has never met Vardek. He knows the shipment is illicit and intends to burn the names because unnamed goods sell better.

The office fire creates three physical priorities:

1. release two locked sorters;
2. preserve the name tablets and buyer roll;
3. stop fire crossing into occupied storage.

Pump access, a lawfully assembled crew, or opening the river shutters can make all three possible. Otherwise the player chooses where to spend bodies and time.

Elara runs the fire the way she runs a dinner. She learns the pump crew's names off their jackets in the first thirty seconds and uses them; she puts the slowest man where the work is survivable without telling him that is why; she catches a child out of a window and hands her along without breaking sentence. It is the best she looks all quest, and the player should want to be on her crew.

At the end of it she thanks the sorters — “our little company,” warmly, with the buyer roll still smoking in her other hand.

One of them, two scenes later, mentions in passing which of the men now standing in her crew had turned the key on their door. Nobody comments. Nobody in the scene connects it to the thanks. The player may.

## End: The Grain-Stairs Barge

Jorek takes the master list and two portable cases onto a light barge crewed by coerced laborers. Routes to it include a crane swing, quay pursuit, customs skiff, or stern ladder from the drain.

The fight uses shifting cargo, cut lines, smoke, and narrow footing. Jorek fights badly and expensively — he is a receiver, not a knifeman — and ends the night arrested, in the river, or three miles downstream with the master list wet in his coat. The evidence and the people decide what happens next; he does not.

Elara must decide how the return is recorded:

- **shared account:** Jonas, sorters, barge crew, Customs, and Elara each own their testimony;
- **accurate led account:** Elara speaks publicly but names agency and credit;
- **curated account:** she clears Jonas while making everybody else part of her redemption story;
- **concealed account:** the goods return without her role entering a usable record.

## Information and Failure

No conclusion depends on one check:

- Elara's role comes from survey cuts, her admission, or remote purchase copies;
- Vardek's interest comes from payment marks, Bellandi's portfolio, or buyer routes;
- Seven Mounds comes from a survey scrap, Jorek's order, or the removed cart case.

Failures transform:

- Jonas may remain on appeal;
- wet or burned fragments preserve partial names;
- an escaped barge sheds cargo downstream;
- killed workers become a named company conflict;
- a defeated party is recovered by dockworkers after the evidence worsens.

## Archetype Chemistry

- Cheerleader/Jock can make the rescue cohere but risk claiming it.
- Tomboy/Rebel can reject ceremony but must still clear Jonas publicly.
- Goth/Nerd can protect names and evidence without treating people as exhibits.
- Bohemian/Goofball can improvise the pursuit while respecting frightened workers' limits.
- Grey receives complete practical choices around custody, fire crews, and testimony.

## Rewards and Outputs

Unlock **Appraiser's Cut** and Elara's hub appraisal.

Record:

- `elara_first_admission`: full, private, evasive, or refused;
- `lime_names_state`: complete, partial, dispersed, or lost;
- `jonas_feld_state`: cleared, appeal, imprisoned, injured, or dead;
- `silkhook_broker_state`: captured, dead, escaped, or unidentified;
- `elara_heroic_account_state`: shared, accurate-led, curated, or concealed;
- `elara_direction` movement;
- `elara_introduction_complete`.

## Navigation

- [[Elara Companion Campaign]]
- [[A Splendid Little Expedition]]
- [[Elara Velescar]]
- [[Claims-Factor Marco Bellandi]]
- [[Neda Volk]]
