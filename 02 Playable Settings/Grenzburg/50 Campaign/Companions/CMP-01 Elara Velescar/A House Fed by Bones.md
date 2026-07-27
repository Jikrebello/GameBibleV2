---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Southwood Barrowlands"]
culture: ["Eclessian", "Folk"]
related_factions: ["Blackjack Corps"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-1
availability_window: ["Open Autumn", "Late Autumn"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["seven_mounds_state", "seven_mounds_worker_roster", "southwood_burial_state", "elara_act1_resolution", "elara_direction"]
reward_unlocks: ["Fault Proven", "Delver-Duelist rapier parts", "Delver-Duelist pick parts", "Prepared dart parts"]
required_locations: ["Ashfield Lodge", "Seven Mounds"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-finale
companion_campaign_stage: act-1
quest_owner: "Elara Velescar"
quest_sequence: 3
companion_id: "CMP-01"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: confrontation
relationship_variant: ""
encounter_deck: []
postgame_season: ""
estimated_hours: 1.5
gameplay_pillars: [expedition, infiltration, rescue, survival, boss]
required_states: ["elara_introduction_complete"]
optional_state_inputs: ["elara_mixed_expedition_crew", "elara_southwood_intelligence", "elara_burial_support", "elara_shoring_knowledge", "elara_living_custodians"]
companion_required: "Elara Velescar"
duo_quest: true
pause_points: ["Seven Mounds Camp Reached", "Upper Chamber Secured"]
preparation_inputs: ["elara_mixed_expedition_crew", "elara_southwood_intelligence", "elara_burial_support", "elara_shoring_knowledge", "elara_living_custodians"]
preparation_threshold: "2 participate; 3 all material objectives; 4 one safeguard"
autonomous_deadline: "The Last Convoy"
autonomous_resolution: "Elara saves the workers after chasing proof first; avoidable injuries and a scarred mound remain."
changed_reentry: "The Scarred Mounds"
ensemble_inputs: ["Bernard Valeon", "Dismas Raben"]
identity_hooks: ["Wilderness", "Peasant/Labour", "Folk", "Scholarly", "Merchant/Craft"]
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
archetype_pressure: "Current workers may refuse Elara's plan, title, praise, and preferred account while still needing rescue."
emotional_function: "Make people-before-proof an action decision made among capable adults."
pleasure_beat: "A dangerous Southwood approach, clever entry, discovery, and Elara in her element."
care_beat: "Elara follows a worker's stop call and spends the best route on people rather than evidence."
player_archetype_hooks: ["Cheerleader", "Tomboy", "Goth", "Bohemian", "Jock", "Nerd", "Rebel", "Goofball", "Grey"]
persistence_scope: regional-persistent
---
# A House Fed by Bones

## Premise

A local illegal crew is opening **Seven Mounds** using copied Velescar surveys sold through remote Vardek channels. The workers are current Southwood people: some were coerced by food debt, some took dangerous pay knowingly, and some now want to leave with evidence that they were promised a lawful excavation.

The player and Elara enter as a duo. Current workers, custodians, and temporary rescuers do not consume companion slots.

## Cast and States

**Foreman Branka Sohl** is a Grenzburg delver who knowingly crossed the custody line. She is practical, armed, and willing to abandon her crew to keep portable proof.

Six workers are tracked individually:

- Emri, shoring lead;
- Fenn and Bela, siblings on spoil haul;
- Rosk, powder hand;
- Juta, cook and tally keeper;
- Vale, injured survey assistant.

They possess different information and do not vote as one moral chorus.

Track:

- `Mound Integrity: 3-0`;
- `Crew Alarm: 0-3`;
- each worker as safe, active, injured, trapped, fled, or dead;
- evidence and burial goods separately.

## Beginning: Ashfield to Seven Mounds

Three approaches remain viable:

- **hunter trail:** safest observation, longest route;
- **spoil trench:** fastest worker contact, high collapse risk;
- **crown descent:** vertical surprise entry through an old vent.

Every vocation can use every approach with gear and effort. Specialized movement provides shortcuts.

Along the path Elara tells a magnificent story about “the first clean look” at a sealed chamber. Emri, contacted through a work whistle, replies:

> “We have looked. It is falling.”

That interruption establishes the quest's tone. Workers possess knowledge Elara wants, and they are not waiting to become her crew.

## Middle: The Active Dig

The duo can:

- infiltrate through shifts;
- openly demand a stop;
- free food and tool stores to remove immediate coercion;
- contact workers and let them decide whether to flee, testify, or hold the shoring.

Branka's guards, unstable spoil, natural vermin, damaged burial mechanisms, and non-conscious [[Corpse Residue]] create distinct threats. No supernatural force caused the human exploitation.

The upper chamber reveals:

- name recesses already stripped;
- evidence that the copied plan omitted a refuge passage;
- a portable Vardek purchase instruction;
- living workers trapped beyond a failed partition;
- a protected inner panel the custodians expressly forbid opening.

## Collapse and Priority

Branka starts a partial powder line to open her escape. The lower chamber separates into four objectives:

1. workers behind the partition;
2. the purchase instruction;
3. portable memorial property;
4. the inner panel and its intact burial context.

With three assets and strong play, all material objectives are achievable. With fewer, the party must commit physically to routes. Elara can chase Branka or stabilize the worker passage, but cannot do both alone.

Workers act:

- Emri calls a stop and can direct shoring;
- Rosk can disarm one charge if trusted;
- Juta carries the work roll only if not treated as a passive witness;
- Vale knows the refuge passage but cannot walk unaided.

If Elara overrides them, she may still save lives through competence while repeating the ownership pattern.

## Boss and Escape

Branka fights with powder, hooks, crossbow pressure, and collapsing lines. She may be captured, killed in justified resistance, or escape. Later stages use the surviving evidence and local-agent network; they do not require her.

Escape uses the reinforced descent, refuge passage, or blast fracture. Carrying injured people changes traversal and enemy pressure. Elara's pick is useful, not mandatory.

## End: Refusal and Credit

At the surface, the workers decide:

- whether to give testimony;
- whether Elara may use their names publicly;
- who controls recovered tools and wages;
- whether the mound remains closed.

Elara can offer an inspiring public account. Emri may answer, “You may say you listened. Do not say we followed.”

The resolved Act I beat occurs when she accepts that sentence without improving it.

## Fail-Forward

- Missing workers leave marks and later rescue routes.
- Lost evidence survives through the work roll or purchase instruction.
- A scarred mound remains visitable in winter.
- Broken custodian trust closes the inner route but not the rescue.
- Defeat results in an exterior recovery with Branka gone and the worker state worsened.

## Outcomes and Rewards

`elara_act1_resolution`:

- **workers-first:** Elara spends the strongest route on living people;
- **prepared-both:** people, evidence, and context survive through preparation;
- **proof-first-repaired:** she turns back after a material cost;
- **curated-victory:** she saves people but claims their decision;
- **house-fed:** proof or goods are preserved over workers.

Record `seven_mounds_state`, each worker, `southwood_burial_state`, and `elara_direction`.

Unlock **Fault Proven**, Delver-Duelist rapier/pick/dart custom parts, and [[A Better Wager]]. Missing the finale forfeits these rewards.

## Navigation

- [[Elara Companion Campaign]]
- [[A Splendid Little Expedition]]
- [[A Better Wager]]
- [[Corpse Residue]]
- [[Ashfield Lodge]]
