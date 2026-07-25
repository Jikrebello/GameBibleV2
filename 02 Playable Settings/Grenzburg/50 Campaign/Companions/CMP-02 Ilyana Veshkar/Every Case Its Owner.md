---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Ledger Quays", "Cathedral Close"]
culture: ["Sermoran", "Eclessian"]
related_factions: ["Blackjack Corps", "The Salt-Reed Company", "Medori Bank"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-3
availability_window: ["Open Spring", "Muster Crisis"]
repeatability: one-shot
cutoff_result: resolves-offscreen
world_state_outputs: ["ilyana_releases_protected", "salt_reed_authorship_state", "salt_reed_instrument_state", "mirella_release_state", "nereo_release_state", "celia_release_state", "tomas_release_state", "morante_claim_state"]
reward_unlocks: ["Partitioned Score", "release authentication"]
required_locations: ["Customs Hall", "North Quay Warehouses", "Chancery House", "Bridge Vaults"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: operation
companion_campaign_stage: act-3
quest_owner: "Ilyana Veshkar"
quest_sequence: 8
companion_id: "CMP-02"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: preparation
estimated_hours: 0.75
gameplay_pillars: [escort, investigation, defence, archive-recovery, property-choice]
required_states: ["ilyana_act2_chapter_resolved", "open_spring"]
optional_state_inputs: ["ilyana_instruments_returned", "morante_state", "salt_reed_winter_consent", "ledger_quays_condition", "church_rank", "bank_rank", "underworld_rank"]
field_experience_gate: []
companion_required: "Ilyana Veshkar"
duo_quest: false
pause_points: ["Release Packet Assembled"]
relationship_gate: ""
relationship_variant: ""
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "The Deep Muster"
autonomous_resolution: "Personal service releases survive, but disputed common repertoire remains under supervised Grenzburg custody"
changed_reentry: "Lost scores or instruments remain lost; the Act III finale adapts to the surviving release packet"
ensemble_inputs: ["Zafir ibn Samad", "Elara Velescar", "Ashira bath Melan"]
identity_hooks: ["Sermoran", "Scholarly", "Merchant/Craft", "Underworld", "Nobility"]
encounter_deck: ["Grenzburg Spring Dead-March Signs"]
persistence_scope: city-persistent
postgame_season: ""
---
# Every Case Its Owner

## Quest Function

This Act III operation protects the Salt-Reeds' individual release, authorship, and property records before the final emergency can be used to erase them.

## Hook

Customs Reader Marta Vell assembles five release packets:

- Ilyana's personal liability and Medori surety;
- Mirella's authorship and scores;
- Nereo's road accounts and drum;
- Celia's viol, tools, and unpaid share;
- Tomas's horn, cadence plates, and credit.

A separate packet contains genuinely disputed common property.

The first Muster disturbances reach Ledger Quays as the packets are due to move from Customs Hall to Chancery House. Morante's surviving interests attempt substitution and seizure while non-conscious residue follows old cargo-command markings through the Bridge Vaults.

The human seizure and undead movement are independent threats.

## Beginning: Five Owners, Five Instructions

Each person gives a separate instruction:

- Mirella prioritizes authorship records.
- Nereo prioritizes release and wages over the drum.
- Celia prioritizes the tools that let her work.
- Tomas prioritizes personal cadence plates and correct credit.
- Ilyana must decide whether her own release matters more than keeping the company archive together.

The player may ask for clarification but cannot consolidate the instructions into one company order.

## Middle: The Transfer

Routes:

- public escorted street transfer;
- bonded warehouse passage;
- Bridge Vault service route;
- Low Lantern substitution counter-operation.

The normal party protects three moving groups:

1. people and witnesses;
2. sealed release packets;
3. instruments and common cases.

Morante's factor uses convincing duplicate seals. Muster residue follows painted portage symbols and attacks whatever bears the old command mark. Destroying every marked case protects movement but destroys evidence and property.

Zafir can expose false delegation. Elara can identify substituted containers. Ashira can distinguish residue behavior from human intent. None decides ownership.

### Pause Point: Release Packet Assembled

After authenticating the five packets, the quest may pause before the route begins.

## End: Chancery Steps

At Chancery House, the player must keep witnesses alive long enough for individual releases to be entered while:

- human agents attempt to remove the common packet;
- residue breaks through an old service stair;
- a damaged instrument case threatens to burn;
- Ilyana sees a chance to preserve the entire company archive by delaying separate registration.

Three strong route or preparation successes preserve every person, packet, and case. Otherwise priorities follow the owners' recorded instructions.

## Choices

- Register releases individually.
- Preserve disputed common property for a later hearing.
- Assign genuinely joint work by documented contribution.
- Let Ilyana claim the company name or archive.
- Destroy the disputed packet to end all claims at the cost of authorship evidence.
- Use emergency ducal custody without converting it into permanent ownership.

## Fail-Forward

- Lost packet: surviving owners testify, but the corresponding Act III asset is weakened.
- Burned score: credit survives if copied; the music itself is lost.
- Captured factor: Morante's legal position changes, not the truth of consent.
- Escaped factor: final opposition gains a human retrieval team.
- Party defeat: Chancery guards save witnesses after cases and papers are divided.

## Rewards

- `ilyana_releases_protected` when all five personal releases enter the register.
- **Partitioned Score:** identifies which lines of the Last Common Measure belong to whom and permits voluntary assignment.
- Act III preparation for [[The Last Common Measure]].

## Navigation

- [[Ilyana Companion Campaign]]
- [[The Salt-Reed Company]]
- [[Patron-Captain Caterina Morante]]
- [[The Last Common Measure]]
- [[Ledger Quays]]

