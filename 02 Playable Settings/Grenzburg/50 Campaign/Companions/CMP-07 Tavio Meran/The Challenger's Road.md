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
tags: [narrative-rewrite]
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
autonomous_resolution: "See Companion Autonomy and Act Convergence; untracked content uses stable-colleague treatment."
changed_reentry: "Bout After Snow"
ensemble_inputs: ["Ylva Winter-Track", "Dismas Raben", "Elara Velescar"]
identity_hooks: ["Sestaran", "Military", "Merchant/Craft", "Wilderness", "Underworld"]
grounded_rewrite_status: approved
external_stakes: ["equipment safety", "worker stop authority", "public bout integrity", "forge evacuation"]
banter_priority: contextual
player_interest_gate: none
missed_arc_treatment: changed-reentry
encounter_deck: []
persistence_scope: regional-milestone
postgame_season: ""
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant-via-lio-clause
archetype_pressure: "Competition becomes worth: test whether Tavio can stop, lose, or need help without surrendering athletic joy."
emotional_function: "Keep Lio's remote claim and refusal; use a present-day challenger to center bodily vulnerability, public expectation, and the right to withdraw"
pleasure_beat: "Competition, crowds, food, physical effort, ridiculous prizes, and celebrating improvement."
care_beat: "Tavio trains beside people, celebrates their effort, and calls a halt before glory spends their bodies."
player_archetype_hooks: []
---
# The Challenger's Road

## Quest Function

This Act II operation brings [[Lio Varcen]], his fighting brace, and independent Crucible evidence safely into besieged Grenzburg without placing him under Tavio's command or making his arrival depend on reconciliation.

## Hook

A winter courier reports that Lio's protected convoy has stalled beyond the Highlake road. The western route is closing, Grobi scouts probe the approaches, and someone has circulated a false order transferring Lio into Blackjack custody.

Lio refuses the transfer, and his arrival is sanctioned under [[Companion Constitution#Past Claims and the Lio Exception|the Lio Clause]]: he travels under his own power, for his own aims, with his own second, clerk, and exit route, and never in Tavio's custody.

He asks for five things, numbered, because he numbers things:

> **Lio:** One, neutral passage. Two, my brace and my records stay with me. Three, a named medical stop, and I will tell you where. Four, lodging that is not his.
>
> *(He looks at the road, not at Tavio.)*
>
> **Lio:** Five. If this route is chosen because I am useful bait, say so now and I will take the ferry and be slower.

## Beginning: Terms of Escort

The party meets Lio, one Crucible clerk, and two hired guards at a snowbound wayhouse. Tavio may join only after accepting Lio's terms.

The player chooses a route:

- **public carriage road:** fastest, exposed to forged orders;
- **Highlake freight path:** physically demanding, safer from officials;
- **Lowland relief convoy:** crowded but protected by witnesses.

Tavio may advise. Lio decides whether the brace travels assembled, sealed, or worn — and he is at every departure before it is called, every morning, without ever explaining why a man who manages pain before dawn is early to things.

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
