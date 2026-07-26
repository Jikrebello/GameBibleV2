---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Ledger Quays"]
culture: ["Sermoran"]
related_factions: ["Blackjack Corps", "Medori Bank", "The Salt-Reed Company"]
appears_in: ["Grenzburg"]
needs: []
tags: [narrative-rewrite]
quest_class: companion
act: act-1
availability_window: ["Early Autumn", "Open Autumn"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["ilyana_introduction_complete", "ilyana_cases_secured", "ilyana_forgery_admitted", "salt_reed_property_state", "customs_case_thief_state", "morante_claim_known"]
reward_unlocks: ["False Note", "Sermoran property identification"]
required_locations: ["Blackjack Yard", "Customs Hall", "North Quay Warehouses", "Quay Crane Walk", "River Stairs"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: introduction
companion_campaign_stage: introduction
quest_owner: "Ilyana Veshkar"
quest_sequence: 1
companion_id: "CMP-02"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: familiarity
estimated_hours: 1.0
gameplay_pillars: [investigation, social, pursuit, rescue, property-choice]
required_states: ["warrant_at_gate_complete"]
optional_state_inputs: ["ledger_quays_access", "blackjack_rank", "bank_rank", "underworld_rank", "sermoran_knowledge"]
field_experience_gate: ["one meaningful outing with Ilyana"]
companion_required: "Ilyana Veshkar"
duo_quest: false
pause_points: ["Customs Examination Complete"]
relationship_gate: ""
relationship_variant: ""
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "The Last Convoy"
autonomous_resolution: "Ilyana recovers four cases, conceals the forged delegation, and loses the fifth case and its ownership roll"
changed_reentry: "The missing case and forgery surface through the Act I aftermath without restoring this quest's rewards"
ensemble_inputs: ["Elara Velescar", "Zafir ibn Samad", "Dismas Raben"]
identity_hooks: ["Sermoran", "Merchant/Craft", "Underworld", "Scholarly"]
encounter_deck: []
persistence_scope: city-persistent
postgame_season: ""
emotional_rewrite_status: reframe
dialogue_status: pending-rewrite
archetype_pressure: "Freedom becomes impermanence: test whether Ilyana can sustain a shared work after novelty and sole authorship fade."
emotional_function: "Keep instruments and forged authority; let Ilyana turn a customs crisis into a dazzling introduction before the cost of speaking for others appears"
pleasure_beat: "Improvised music, novelty, public performance, and turning strangers into a temporary chorus."
care_beat: "Ilyana makes room for another person's tempo, authorship, continuity, and refusal."
player_archetype_hooks: []
---
# Five Cases at Customs

## Quest Function

This is Ilyana's normal-party introduction. It reveals her Salt-Reed history through a present property crisis rather than an exposition confession.

## Hook

Five reinforced instrument cases arrive at [[Ledger Quays#Anchor Locations|Customs Hall]] under a Sermoran seizure claim lodged by [[Patron-Captain Caterina Morante]]. Four are on the examination floor. The fifth disappeared between the river crane and bonded storage.

Ilyana recognizes the cases and initially says only that they belonged to her old company. Customs Reader **Marta Vell** will release nothing until the missing case, owner roll, and competing claims are understood.

## Principal Cast

- [[Ilyana Veshkar]]: wants the cases secured before their owners arrive and fears the documents inside.
- **Marta Vell:** customs reader protecting property without treating Morante's paper as automatically true.
- **Pell One-Thumb:** quay porter who stole the lightest case expecting jewels and becomes trapped by professional smugglers.
- [[Patron-Captain Caterina Morante]]: present through a factor or letter; her physical presence is not required.

## Beginning: The Examination Floor

The party examines the four cases:

- Mirella's score case;
- Nereo's drum shell and road accounts;
- Celia's viol tools;
- Tomas's horn plates.

Each bears an individual ownership mark beneath the Salt-Reed common seal. A false lining contains copied approvals for the Gilded Wake season. Four signatures are forgeries in Ilyana's hand.

Information has redundant sources:

- ownership marks;
- Customs Hall intake sketches;
- Ilyana's recognition;
- Sermoran insurance tags;
- a letter from Mirella denying approval.

Ilyana may admit the forgery immediately, admit it to the player and Marta privately, or try to keep the lining closed. Concealment changes direction but cannot remove the evidence.

### Pause Point

After examination, the quest may pause before pursuit. The cases remain under customs seal.

## Middle: The Missing Case

Crane grease, a cut sling, witness statements, and a dropped reed lead through:

1. the North Quay loading lanes;
2. a warehouse loft;
3. the crane walk;
4. river stairs where Pell is being forced into a skiff.

Pell stole Mirella's compact score case. Two ordinary smugglers discovered its false lining and now intend to sell the papers as leverage.

Approaches include:

- customs warrant and dock containment;
- roof and crane pursuit;
- underworld negotiation;
- concealed approach through the warehouse;
- direct rescue at the river stairs.

Every vocation can climb ordinary ladders, cross the warehouse, or reach the stairs. Specialized movement changes speed and interception points.

## End: The Crane and the River

The smugglers cut a suspended cargo net to cover their escape. The party must manage:

- Pell hanging from the net;
- the falling score case;
- civilians below;
- the escaping skiff.

Strong positioning can preserve all four. Failure costs evidence, property, injury, or an escaped thief rather than ending the campaign.

The final customs decision records each case separately. The player can support:

- individual protective custody until each owner arrives;
- temporary neutral customs custody;
- Morante's bounded claim to genuinely disputed common property;
- or Ilyana's attempt to take everything as company leader.

Marta will not assign personal instruments to Ilyana without owner consent.

## Choices and Direction

- Truthful admission plus individual custody supports `consensual`.
- Private admission with protected property supports `mixed` unless later repaired.
- Concealment, destroyed signatures, or personal seizure supports `entitled`.
- Saving Pell does not erase his theft; he may face ordinary judgement.

## Fail-Forward

- Lost case: Mirella retains copies and the physical score becomes a later recovery.
- Escaped smugglers: their buyer appears in Act I preparation.
- Injured Pell: he still identifies the route but cannot testify at the first hearing.
- Burned forged approvals: handwriting, insurance records, and owner letters preserve the truth.
- Party defeat: customs watch recovers the party after the smugglers escape with one case.

## Rewards

- **False Note:** Ilyana more quickly identifies disguised signals, copied ownership marks, and vulnerable hostile cadences.
- `ilyana_cases_secured` when at least four cases and the individual roll are protected.
- Introduction of the Salt-Reed property and Act I campaign.

## Navigation

- [[Ilyana Companion Campaign]]
- [[The Salt-Reed Company]]
- [[The Gilded Wake Season]]
- [[The Road Without a Conductor]]
- [[Ledger Quays#Anchor Locations|Customs Hall]]
