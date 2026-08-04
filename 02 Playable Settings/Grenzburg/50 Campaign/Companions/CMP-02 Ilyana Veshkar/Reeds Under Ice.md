---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Ledger Quays", "Longlake Ward"]
culture: ["Sermoran", "Eclessian", "Folk"]
related_factions: ["Blackjack Corps", "Church of Grenzburg"]
appears_in: ["Grenzburg"]
needs: []
tags: [companion-campaign]
quest_class: companion
act: act-2
availability_window: ["Early Winter", "Deep Winter"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["ilyana_winter_signal_code", "winter_signal_crews_state", "frozen_freight_channel_state", "quay_lifeboat_state", "ilyana_direction"]
reward_unlocks: ["Second Bore", "winter signal rehearsal"]
required_locations: ["Customs Hall", "North Quay Warehouses", "Frozen Freight Channel", "River Boom Towers", "Ferry Yard"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-operation
companion_campaign_stage: act-2
quest_owner: "Ilyana Veshkar"
quest_sequence: 5
companion_id: "CMP-02"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: preparation
estimated_hours: 0.75
gameplay_pillars: [urban-traversal, rescue, repair, rehearsal, defence]
required_states: ["ilyana_act1_chapter_resolved", "winter_siege_active"]
optional_state_inputs: ["ilyana_road_circuit_state", "tessa_rill_state", "city_in_siege_result", "ledger_quays_condition", "longlake_ward_condition"]
field_experience_gate: []
companion_required: "Ilyana Veshkar"
duo_quest: false
pause_points: ["Stranded Crews Reached"]
relationship_gate: ""
relationship_variant: ""
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "Ghor at the Gate"
autonomous_resolution: "See Companion Autonomy and Act Convergence; untracked content uses stable-colleague treatment."
changed_reentry: "A spring repair shift can restore the apparatus, but the missed winter rehearsal no longer prepares The Free Refrain."
ensemble_inputs: ["Bernard Valeon", "Tavio Meran", "Elara Velescar"]
identity_hooks: ["Sermoran", "Folk", "Merchant/Craft", "Military", "Peasant/Labour"]
grounded_rewrite_status: approved
external_stakes: ["a functioning frozen-river traffic code", "two stranded work crews", "food and casualty sled access", "the River Boom apparatus"]
banter_priority: contextual
player_interest_gate: none
missed_arc_treatment: changed-reentry
encounter_deck: ["Grenzburg Winter Quays"]
persistence_scope: city-persistent
postgame_season: ""
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
archetype_pressure: "Ilyana's elegant variations fail workers who need the same clear instruction on the hundredth repetition."
emotional_function: "Give Ilyana a winter work story about maintenance, fatigue, and civic repetition rather than another property hearing."
pleasure_beat: "She discovers that four quay crews have added rude mnemonic lyrics to her signal scale and reluctantly admits they work."
care_beat: "Ilyana gives up the warm tower shift and spends the repair interval thawing reeds beside the ice crews."
player_archetype_hooks: []
---
# Reeds Under Ice

## Quest Function

This normal-party winter operation is about keeping public work reliable after novelty has worn off. Grenzburg uses four musical signal posts to move food sleds, casualty litters, work crews, and limited freight across the frozen river channel.

Ilyana designed the code. Each shift learned a slightly different version because she kept improving it in performance.

## Hook

During a routine change of watch, the east tower sounds **lane clear** while the Ferry Yard crew hears **boom closing**. A food sledge and a casualty team enter opposing lanes. The ice buckles around the central reed markers as Grobi skirmishers probe from the west bank.

No saboteur caused the contradiction. Condensation split one keyed reed, a copied score omitted a rest, and Ilyana taught an ornamental variation to one shift without updating the others.

## Current Crews

- **Oren Fask:** now serving the east horn post.
- **Sella Morn:** Mercy Hospital litter caller, exact and impatient.
- **Pell Two-Reeds:** Ferry Yard drummer and rope lead.
- **Arko Venn:** River Boom mechanic, deaf in one ear and dependent on flag confirmation.

Tessa Rill may be present if fit, but no former Salt-Reed member enters the quest.

## Beginning: Contradictory Calls

From Customs Hall the party can identify:

- six patients stranded on a casualty sledge;
- a food team pinned beside a widening crack;
- the central reed markers disappearing under shifting ice;
- a boom counterweight pulling against a frozen chain;
- Grobi skirmishers using the confusion to test the quay.

Routes include crane ladders, marked ice, the warehouse loading tunnel, and the River Boom wall walk. Every vocation has a complete route.

## Middle: Rescue Before Revision

The party handles four simultaneous objectives:

1. secure the casualty sledge;
2. move the food team off the cracked lane;
3. stop the boom counterweight before it tears down a quay crane;
4. drive off the Grobi probe without masking the evacuation signals.

Ilyana initially tries to conduct all four posts herself. Wind delay makes that impossible. The player can place crew members according to the code they actually know, use flags and ropes, simplify to two emergency calls, or let each crew improvise its own withdrawal.

Other companions grant practical advantages. Bernard stabilizes cold casualties, Tavio braces the mechanism, Elara finds the quickest warehouse path, and Ylva reads the ice. None can repair the code for Ilyana.

### Pause Point: Stranded Crews Reached

The quest may pause after all living workers reach stable ice or quay. The repair and rehearsal remain unresolved.

## The Boring Work

The second half is intentionally not another attack. The party must visit all four posts and make one code survive different voices, hearing limitations, wind directions, and shift habits.

Play consists of:

- recovering or replacing frozen reed keys;
- testing calls from positions with obstructed sight;
- choosing which flourishes become music and which remain safety signals;
- letting each crew write its own mnemonic without changing the command;
- running a timed sledge drill while the boom opens and closes.

Ilyana can publish a plain common code with local annotations, reserve all changes for herself, or create an ornamental performance layer that never alters the safety phrase.

The crews do not applaud the administrative work. Sella signs the sheet, asks for twelve dry copies, and returns to Mercy Hospital.

## End: The Night Shift

The final test happens after dark as a real casualty convoy reaches the channel. There is no staged crisis. Success is the ordinary sight of different crews doing the same job without Ilyana at every post.

If the code remains dependent on her, she must overextend to keep the crossing open and the Act II finale loses an independent signal team. If it is shared, Ilyana can leave her tower to support the most endangered lane.

## Fail-Forward

- Patients survive a failed rescue but gain complications and Mercy Hospital loses capacity.
- Lost food worsens winter prices without closing the campaign.
- Boom damage closes one river route and lengthens the later casualty corridor.
- A confused code can be simplified under ducal order, producing a procedural rather than consensual direction result.
- Party defeat ends with quay workers recovering the stranded crews after the cargo is lost.

## Rewards

- `ilyana_winter_signal_code`: shared, imposed, dependent, or damaged.
- `winter_signal_crews_state`: records which posts can operate independently.
- **Second Bore:** Ilyana can sustain a field refrain while a trained local crew carries a separate fixed signal line.
- Act II preparation for [[The Free Refrain]].

## Navigation

- [[Ilyana Companion Campaign]]
- [[The Road Without a Conductor]]
- [[The Free Refrain]]
- [[Ledger Quays]]
- [[Grenzburg City Anchor Register#Cross-City Anchors|River Boom Towers]]
