---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Lantern Ward", "Longlake Ward"]
culture: ["Ahl-e-Ahd", "Iqashari", "Chapel-Folk", "Eclessian"]
related_factions: ["Blackjack Corps"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-2
availability_window: ["Deep Winter", "Early Spring"]
repeatability: one-shot
cutoff_result: forfeited
world_state_outputs: ["zafir_bond_episode", "zafir_bond_move_upgrade", "zafir_night_circuit_practiced", "small_repairs_route_state"]
reward_unlocks: ["Two Keys: Night Circuit", "Night Circuit safeguard"]
required_locations: ["Blackjack Yard", "Lantern Ward", "Longlake Ward"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: relationship
companion_campaign_stage: relationship
quest_owner: "Zafir ibn Samad"
quest_sequence: 7
companion_id: "CMP-08"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: relationship
estimated_hours: 0.5
gameplay_pillars: [reconstruction, traversal, conversation, reflection]
required_states: ["zafir_relationship_commitment: bond-committed", "zafir_act2_finale_played"]
optional_state_inputs: ["longlake_passage_rule", "blackjack_yard_state", "karel_apprenticeship_state"]
field_experience_gate: []
companion_required: "Zafir ibn Samad"
duo_quest: false
pause_points: []
relationship_gate: "male player; Trusted; bond-committed"
relationship_variant: bond
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "The Open Thaw"
autonomous_resolution: "Missing the episode preserves commitment but forfeits its upgrade and safeguard."
changed_reentry: ""
ensemble_inputs: []
identity_hooks: ["Merchant/Craft", "Peasant/Labour", "Scholarly", "Drifter/Vagabond"]
encounter_deck: []
persistence_scope: district-persistent
postgame_season: ""
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
archetype_pressure: "Two men must share mastery without one becoming the conductor and the other the agreeable assistant."
emotional_function: "Build explicit platonic brotherhood through alternating work, stop authority, and ordinary trust."
pleasure_beat: "Repair a bell pull, stove catch, Yard gate, and ferry lamp while arguing about which fix is least dignified."
care_beat: "Each man takes the other's objection seriously before the mechanism becomes dangerous."
player_archetype_hooks: ["Jock", "Nerd", "Rebel", "Goofball", "Grey"]
---
# The Night of Small Repairs

## Premise

Zafir and a committed male player take the Yard's small-repairs board and complete one circuit through Lantern Ward and Longlake Ward.

The work is ordinary:

- a bell pull that sticks in sleet;
- a stove catch that closes too hard;
- a Yard gate with a proud new squeal;
- a ferry lamp whose shutter opens on the wrong side.

There is no villain, attack, hidden claimant, or romantic branch.

## Alternating Lead

The player leads the first and third repair. Zafir leads the second and fourth.

At every site:

- the non-leading man may object;
- either may call a stop;
- the owner chooses whether the repair is accepted;
- neither man's preferred method becomes compulsory through expertise or relationship.

A deliberately foolish fix may work and remain ugly. A perfect fix may be rejected because the owner cannot maintain it.

## Night Circuit

Between sites, the pair discuss:

- the difference between being trusted and being obeyed;
- humiliation when a peer sees the flaw before the crowd;
- why an objection matters before proof;
- what each man expects the other to say when he becomes dangerous.

Zafir asks for an exact oath and produces three drafts. The player may tear them up, edit one, or answer in plain language.

At the final ferry lamp they exchange two ordinary repair keys. Each key opens the other's small field case but no magical identity, body, or office.

They explicitly become sworn brothers and peers.

## Reward

Completion grants **Two Keys: Night Circuit** and `zafir_night_circuit_practiced`, preserving one volunteer or release key in [[All Cords Cut Clean]]. It never decides the override.

The repaired sites remain visible in ambient world states.

## Navigation

- [[Zafir Field Familiarity and Relationships]]
- [[Zafir Companion Campaign]]
- [[The Copyist's Answer]]
- [[All Cords Cut Clean]]
- [[Longlake Ward]]
