---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Lantern Ward"]
culture: ["Eclessian"]
related_factions: ["Blackjack Corps"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-2
availability_window: ["Siege Winter"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["ashira_breach_casualty_map", "ashira_missing_blackjacks_identified", "repeated_signal_state", "yard_missing_roster"]
reward_unlocks: ["Witness Circle preparation"]
required_locations: ["Lantern Ward", "Blackjack Yard", "Quarry Galleries"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-operation
companion_campaign_stage: act-2
quest_owner: "Ashira bath Melan"
quest_sequence: 5
companion_id: "CMP-04"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: preparation
relationship_variant: ""
preparation_inputs: []
preparation_threshold: ""
encounter_deck: []
postgame_season: ""
estimated_hours: 1
gameplay_pillars: [investigation, rescue, traversal, combat]
required_states: ["ashira_act1_resolution"]
optional_state_inputs: ["western_breach_state", "neda_available", "winter_company_roster_state"]
companion_required: "Ashira bath Melan"
duo_quest: false
pause_points: ["Search Grid Established", "Quarry Signal Located"]
autonomous_deadline: "Ghor at the Gate"
autonomous_resolution: "Ashira finds the living but publicly names one repeated death as proof."
changed_reentry: "After the Screen"
ensemble_inputs: ["Elara Velescar", "Bernard Valeon", "Ilyana Veshkar", "Ylva Winter-Track"]
identity_hooks: ["Military", "Peasant/Labour", "Scholarly", "Mystic/Religious"]
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
archetype_pressure: "Accuracy must serve the search without turning the dead into publicly useful evidence."
emotional_function: "Let Ashira do indispensable winter work where hope and truth pull in different directions."
pleasure_beat: "Reading a damaged city as a layered signal puzzle and finding a living person everyone else missed."
care_beat: "Tell families exactly what is known without manufacturing hope or exposing private death details."
player_archetype_hooks: ["Cheerleader", "Tomboy", "Goth", "Bohemian", "Jock", "Nerd", "Rebel", "Goofball", "Grey"]
persistence_scope: district-persistent
---
# What the Ruins Repeated

## Premise

After the western breach, nine Blackjacks remain missing. Three calls repeat from ruined buildings:

- a bell struck every forty breaths;
- a woman calling “lower stair”;
- hammering beneath a collapsed lodging.

One comes from survivors, one from a damaged signal mechanism, and one from a residue loop left by a person already dead. Treating all three as either hope or death will kill somebody.

## Search

The normal party establishes a grid with [[Neda Volk]]. Evidence includes snow disturbance, air movement, current smoke, repeated timing, and company equipment.

Players can pursue calls in any order. Delay changes injuries and access, not arbitrary off-screen deaths.

### Bell

Two living debtors use a displaced stair bell. Grobi stragglers and fire block extraction.

### Lower stair

The phrase repeats from a damaged acoustic plate. It points toward a service route but has no current speaker.

### Hammering

One living worker and one corpse-residue pattern overlap beneath the Quarry Galleries. The living rhythm becomes irregular under stress; the residue does not.

## Emotional Beat

A family asks whether the repeated woman's voice means she remained. Ashira answers:

> “No. It means the wall remembers badly.”

She can then stay, provide the known time and place, and let them decide whether the detail remains private. The player may support that boundary or turn the explanation into public proof of Ashira's expertise.

## Failure

- Wrong classification costs time and causes injury.
- Destroying a repeated signal can remove a route clue.
- Public death details damage trust but strengthen a formal casualty record.
- A living survivor missed on first pass remains recoverable in the finale.

## Outputs

Set `ashira_breach_casualty_map`, `ashira_missing_blackjacks_identified`, individual roster states, and `repeated_signal_state`. Provide Witness Circle preparation.

## Navigation

- [[Ashira Companion Campaign]]
- [[When the Screen Comes Down]]
- [[Neda Volk]]
- [[Corpse Residue]]
