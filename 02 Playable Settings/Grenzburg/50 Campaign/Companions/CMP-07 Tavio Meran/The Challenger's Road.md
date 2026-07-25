---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Grenz Lowlands", "Highlake Uplands"]
culture: ["Vortharan", "Sestaran", "Eclessian"]
related_factions: ["Blackjack Corps", "Red Brass Bench", "The Crucible"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-2
availability_window: ["Early Winter", "Deep Winter"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["tavio_lio_brace_intact", "lio_varcen_arrival_state", "crucible_evidence_state", "red_brass_road_attack_state", "tavio_direction"]
reward_unlocks: ["Challenger's Measure", "Brace Warning"]
required_locations: ["Highlake Road", "Funnel Camp", "Hammer Ward", "Mercy Hospital"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-operation
companion_campaign_stage: act-2
quest_owner: "Tavio Meran"
quest_sequence: 5
companion_id: "CMP-07"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: preparation
estimated_hours: 0.75
gameplay_pillars: [escort, investigation, winter-traversal, defence, social]
required_states: ["tavio_act1_chapter_resolved"]
optional_state_inputs: ["red_brass_substitution_proven", "seraf_pellan_state", "highlake_route_state", "winter_siege_active"]
field_experience_gate: []
companion_required: "Tavio Meran"
duo_quest: false
pause_points: ["Lio Reaches Funnel Camp"]
relationship_gate: ""
relationship_variant: ""
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "Ghor at the Gate"
autonomous_resolution: "Lio reaches Grenzburg with damaged brace and partial evidence under independent escort"
changed_reentry: "Bout After Snow"
ensemble_inputs: ["Svala Last-Beacon", "Dismas Raben", "Elara Velescar"]
identity_hooks: ["Sestaran", "Military", "Merchant/Craft", "Wilderness", "Underworld"]
encounter_deck: []
persistence_scope: regional-milestone
postgame_season: ""
---
# The Challenger's Road

## Quest Function

This Act II operation brings [[Lio Varcen]], his fighting brace, and independent Crucible evidence safely into besieged Grenzburg without placing him under Tavio's command or making his arrival depend on reconciliation.

## Hook

A winter courier reports that Lio's protected convoy has stalled beyond the Highlake road. The western route is closing, Grobi scouts probe the approaches, and someone has circulated a false order transferring Lio into Blackjack custody.

Lio refuses the transfer. He asks for:

- neutral passage;
- custody of his own brace and records;
- a named medical stop;
- lodging outside Tavio's authority;
- a route that does not turn him into bait.

## Beginning: Terms of Escort

The party meets Lio, one Crucible clerk, and two hired guards at a snowbound wayhouse. Tavio may join only after accepting Lio's terms.

The player chooses a route:

- **public carriage road:** fastest, exposed to forged orders;
- **Highlake freight path:** physically demanding, safer from officials;
- **Lowland relief convoy:** crowded but protected by witnesses.

Tavio may advise. Lio decides whether the brace travels assembled, sealed, or worn.

## Middle: Three Pressures

### False Custody

A forged ducal document orders the evidence surrendered. Cultural, legal, craft, or Insight routes expose different faults. Refusal triggers obstruction, not automatic combat.

### Winter Attack

Ordinary hired attackers strike where the route narrows. Grobi scouts may appear as a separate regional hazard, never as Red Brass agents.

The party must protect:

- Lio;
- the brace;
- the evidence chest;
- unrelated travellers.

### Brace Failure

A sabotaged proof ring begins to heat. Tavio can identify the fault but may touch the brace only with Lio's permission or in an immediate unconscious emergency. Other vocations can stabilize, remove, cool, or protect Lio while Hella's written procedure guides repair.

## Evidence

The convoy carries:

- filed bout rules;
- Lio's original brace plate;
- a Red Brass supply correspondence;
- injury findings;
- one witness statement;
- a list of championship wagers.

Losing any one item does not end the Act II finale. Each preserved item becomes a stronger preparation input or alternate information route.

## End

At Grenzburg:

- Lio may lodge through Mercy Hospital, the Great Forge, or an independent inn;
- his brace may remain intact, repaired, or damaged;
- the evidence may be public, sealed, or partially stolen;
- attackers may be captured, killed in resistance, or escape;
- Tavio may respect Lio's independence or repeatedly treat protection as renewed authority.

## Fail-Forward

- Lio injured: he may alter, postpone, or decline the bout while still testifying.
- Brace damaged: Hella creates a limited fighting profile or non-combat proof.
- Evidence lost: bookmaker and Red Brass records provide alternate routes.
- Convoy scattered: survivors reach Grenzburg separately.
- Tavio violates a boundary: Lio narrows contact and Tavio's direction worsens.

## Rewards

- `tavio_lio_brace_intact` when preserved;
- **Challenger's Measure**, improving Tavio's mark placement against a declared opponent;
- visible brace-failure warnings;
- access to [[The Fair Defeat]] once readiness reaches two assets.

## Navigation

- [[Tavio Companion Campaign]]
- [[Lio Varcen]]
- [[The Fair Defeat]]
- [[Red Brass Bench]]
- [[Proof-Mistress Hella Dorn]]

