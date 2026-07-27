---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Longlake Country"]
culture: ["Sermoran", "Chapel-Folk"]
related_factions: ["Blackjack Corps", "The Salt-Reed Company"]
appears_in: ["Grenzburg"]
needs: []
tags: [narrative-rewrite]
quest_class: companion
act: act-1
availability_window: ["Open Autumn", "Late Autumn"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["ilyana_act1_chapter_resolved", "ilyana_act1_result", "ilyana_act1_finale_played", "ilyana_direction", "nereo_valdo_state", "nereo_drum_state", "eel_bridge_households_state", "reedknife_band_state"]
reward_unlocks: ["Countervoice", "Voluntary Lead"]
required_locations: ["Eel Bridge", "Eel Weirs", "Ferry House", "Spring Culvert", "Reed Bank"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-finale
companion_campaign_stage: act-1
quest_owner: "Ilyana Veshkar"
quest_sequence: 3
companion_id: "CMP-02"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: reckoning
estimated_hours: 1.5
gameplay_pillars: [infiltration, rescue, combat, traversal, consent-choice]
required_states: ["ilyana_act1_readiness_viable"]
optional_state_inputs: ["ilyana_cases_secured", "ilyana_celia_safe", "ilyana_eel_bridge_route_known", "ilyana_individual_ownership_recorded", "ilyana_voluntary_signal_support", "celia_orsani_state", "lowlands_bandit_state"]
field_experience_gate: []
companion_required: "Ilyana Veshkar"
duo_quest: true
pause_points: ["Eel Bridge Reconnaissance Complete", "Nereo Freed"]
relationship_gate: "No relationship required"
relationship_variant: ""
preparation_inputs: ["ilyana_cases_secured", "ilyana_celia_safe", "ilyana_eel_bridge_route_known", "ilyana_individual_ownership_recorded", "ilyana_voluntary_signal_support"]
preparation_threshold: "2 of 5"
autonomous_deadline: "The Last Convoy"
autonomous_resolution: "Ilyana saves Nereo and the bridge households but pressures him to sustain the fog before a safe alternative exists; he is injured and the drum is lost"
changed_reentry: "Echoes at Eel Bridge"
ensemble_inputs: ["Dismas Raben", "Bernard Valeon"]
identity_hooks: ["Sermoran", "Folk", "Wilderness", "Military", "Drifter/Vagabond"]
encounter_deck: []
persistence_scope: regional-milestone
postgame_season: ""
emotional_rewrite_status: reframe
dialogue_status: pending-rewrite
remote_claim_status: pending-migration
archetype_pressure: "Freedom becomes impermanence: test whether Ilyana can sustain a shared work after novelty and sole authorship fade."
emotional_function: "Keep forced performance and rescue; use a current local musician so refusal is immediate rather than another imported reckoning"
pleasure_beat: "Improvised music, novelty, public performance, and turning strangers into a temporary chorus."
care_beat: "Ilyana makes room for another person's tempo, authorship, continuity, and refusal."
player_archetype_hooks: []
---
# No Song by Command

## Quest Function

Ilyana's Act I duo finale turns refusal into a gameplay constraint. The player and Ilyana must rescue [[Nereo Valdo]] and the Eel Bridge households without requiring Nereo to perform for her.

## Hook

The **Reedknife Band**, ordinary human road raiders, has occupied [[Eel Bridge]]. They force Nereo to maintain concealment fog while they move stolen cargo through the ferry slip.

Band leader **Heda Rusk** threatens ferrymen held beneath the bridge whenever Nereo stops. She plans to collapse one span after the final wagons cross.

The tracked docket displays readiness and the approaching Last Convoy cutoff. Accepting dismisses other companions until either pause point.

## Preparation

| Asset | Advantage |
|---|---|
| Cases secured | identifies Nereo's real drum and the duplicate bandit signal |
| Celia safe | supplies tuning wedges and a repair kit |
| Eel Bridge route known | opens the culvert and reed-bank approaches |
| Ownership recorded | lets local watch seize stolen wagons without claiming Nereo's property |
| Voluntary signal support | supplies ferrymen able to carry the evacuation signal without Nereo |

Two assets permit the rescue. Three make Nereo, households, drum, bridge, and bandit capture achievable. Four or five protect one objective from a single logistical failure.

## Beginning: The False Quiet

From the approach, the duo can hear:

- a drum cadence under unnatural fog;
- hammers weakening the downstream brace;
- wagon wheels crossing at fixed intervals;
- a deliberately missed beat marking where Nereo is held.

Approaches:

- main road bluff as expected buyers;
- reed-bank crawl to the weirs;
- spring culvert beneath the ferry house;
- ordinary climb along bridge inspection posts.

All vocations can use each critical route. Special movement changes speed and surprise.

### Pause Point: Reconnaissance Complete

The duo may pause after marking Nereo, the ferrymen, wagons, and bridge charges.

## Middle: Break the Leverage

The duo must separate three controls:

1. the guard holding the ferrymen;
2. the brace charges;
3. Heda's drummer-signal used by outside patrols.

Possible methods include stealth, simultaneous environmental releases, direct assault, false signals, freeing captives first, or turning the stolen wagons into cover.

Failed actions increase `Barrow Alarm` nowhere; this quest uses a local **Bridge Alarm 0-3**:

- 0: routine occupation;
- 1: patrol recalled;
- 2: Heda begins the wagon withdrawal;
- 3: charges are lit and captives moved onto the span.

Every increase advances the encounter rather than closing it.

## Nereo's Refusal

When freed, Nereo drops the sticks and says:

> I will not play because you have decided I must.

Ilyana sees that his fog could make the remaining rescue easier. The player can:

- affirm the refusal and execute another plan;
- ask what Nereo freely offers;
- pressure him through danger;
- order him as a Blackjack asset;
- or let Ilyana answer without intervention.

The quest remains completable without his performance.

If Ilyana accepts refusal and the duo creates a viable route, Nereo may independently choose one short evacuation cadence. This improves a material objective but does not equal forgiveness or reunion.

### Pause Point: Nereo Freed

After the refusal and a withdrawal route selection, the quest may pause. Resuming reforms the duo at the ferry house.

## End: Eel Bridge Break

Heda retreats across the loaded span while the downstream brace fails. The duo must manage:

- ferrymen leaving the undercroft;
- stolen wagons on the bridge;
- the lit charge;
- Nereo and his drum;
- Heda's escape route.

The player can hold the bridge, cut one span cleanly after evacuation, redirect wagons into the weir yard, or abandon property to save people.

## Outcomes

- **Accountable:** Ilyana respects refusal, saves people, and returns the drum.
- **Costly:** refusal is respected but bridge or property is lost.
- **Compromised:** Nereo is pressured into performing and people survive.
- **Broken:** Ilyana compels or threatens a non-hostile Nereo, creating a major conflict.

Nereo may remain distant, communicate through Celia, or permit practical contact. None is automatic forgiveness.

## Fail-Forward

- Bridge collapse: households survive through the ferry route, but Longlake transit worsens.
- Heda escapes: later road camps gain her leadership.
- Drum lost: Nereo reaches Grenzburg without it and refuses all ensemble work.
- Nereo injured: he survives and his winter capacity changes.
- Duo defeat: local ferrymen rescue them after the bandits leave with wagons and drum.

## Rewards

- **Countervoice:** Ilyana gains a stronger interrupt after hearing a hostile cadence.
- **Voluntary Lead:** companion AI will not assign a non-hostile temporary NPC as a Lead without authored consent.
- Act I direction, autonomy, and changed re-entry states.

## Navigation

- [[Ilyana Companion Campaign]]
- [[Nereo Valdo]]
- [[Eel Bridge]]
- [[A Tune with No Owner]]
- [[Reeds Under Ice]]
