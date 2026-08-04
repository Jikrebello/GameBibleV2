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
act: act-1
availability_window: ["Open Autumn"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["ashira_yard_testimony_protected", "debtor_room_state", "house_echo_state", "ashira_debtors_row_extortion_state"]
reward_unlocks: ["Hush Field preparation"]
required_locations: ["Debtors' Row", "Lantern Ward", "Grenzburg Underways"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-operation
companion_campaign_stage: act-1
quest_owner: "Ashira bath Melan"
quest_sequence: 2
companion_id: "CMP-04"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: preparation
relationship_variant: ""
preparation_inputs: []
preparation_threshold: ""
grounded_rewrite_status: approved
external_stakes: ["Heda Morn's housing and safety", "residents trapped above the extortion room", "evidence against a Debtors' Row protection crew"]
banter_priority: contextual
player_interest_gate: none
missed_arc_treatment: changed-reentry
encounter_deck: []
postgame_season: ""
estimated_hours: 0.75
gameplay_pillars: [investigation, infiltration, protection, combat, environmental-puzzle]
required_states: ["ashira_introduction_complete"]
optional_state_inputs: ["customs_runner_state", "neda_available", "underways_route_access"]
companion_required: "Ashira bath Melan"
duo_quest: false
pause_points: ["Witness Protected", "Echo Source Found"]
autonomous_deadline: "The Last Convoy"
autonomous_resolution: "See Companion Autonomy and Act Convergence; untracked content uses stable-colleague treatment."
changed_reentry: "The Drowned Answer begins with reduced privacy support."
ensemble_inputs: ["Elara Velescar", "Bernard Valeon", "Dismas Raben", "Ilyana Veshkar", "Tavio Meran", "Zafir ibn Samad", "Ylva Winter-Track"]
identity_hooks: ["Underworld", "Peasant/Labour", "Scholarly", "Mystic/Religious"]
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
archetype_pressure: "Ashira can prove the uncanny event only by exposing a dismissed debtor's private grief."
emotional_function: "Show her as the person who believes an unwanted witness, then test whether belief becomes ownership."
pleasure_beat: "A room answering knocks, covert observation, and exposing a clever mundane racket around a real Echo."
care_beat: "Protect the witness's chosen account even when a more dramatic disclosure would solve the case faster."
player_archetype_hooks: []
persistence_scope: local-persistent
---
# The Room That Answered

## Premise

Dismissed Blackjack **Heda Morn** says her dead sister answers a three-knock pattern from an empty room in Debtors' Row. A protection crew uses the answers to identify when Heda is alone and extort former debtors.

The room contains a genuine non-conscious [[Anchored Hauntings|House Echo]] formed from repeated household movement. The criminals neither created it nor understand it; they learned how to trigger selected sounds.

## Structure

The normal party can:

1. interview Heda privately;
2. observe the room without triggering it;
3. map hidden speaking tubes and floor pressure;
4. follow collectors into an underways counting niche;
5. confront the extortion crew and decide what becomes public.

Every essential conclusion has two sources: physical tubes and witness timing; echo cadence and collector schedule; marked payments and a captured lookout.

Ashira knows immediately that the answer is not Heda's sister. She does not say so until Heda asks. If the player pushes for instant correction, Heda may close the room.

Ashira initially classifies the three-knock response as a fixed domestic loop that the criminals can only observe. Heda insists the third knock moved after the collectors replaced one floorboard. Ashira dismisses that as grief joining unrelated details. A physical inspection proves Heda right: a new pressure strip lets the crew select which part of the Echo repeats. Ashira's error costs the party its first chance to catch the upstairs lookout if they accepted her certainty without checking.

## Action

The crew responds to discovery by trapping residents on the upper floor, releasing smoke, and escaping through the speaking tubes. The party protects residents, crosses a collapsing gallery, and captures or pursues the collectors.

The House Echo repeats evacuation gestures from an older fire. Following them reveals a safe stair. It is useful without being conscious.

## Choice

The easiest public case uses Heda's grief, room, and sister's name. The protected case requires more field evidence and may let one collector escape.

Heda's instruction is: “Prove what they did. Leave my sister out of your mouth.”

Ashira can honor it, argue that the name is evidentiary, or follow the player's public strategy. She does not summarize what she learned afterward. If she was wrong about the floorboard, she adds Heda's observation to the case record under Heda's name.

## Failure and Outcomes

- Lost collectors leave payment marks for later arrest.
- A public room draws gawkers and closes Heda's housing.
- A protected room preserves trust but yields weaker publicity.
- Destroying the Echo ends exploitation but also erases a useful fire route.

Record `ashira_yard_testimony_protected`, `debtor_room_state`, `house_echo_state`, and `ashira_debtors_row_extortion_state`. Completion supports **Hush Field** and Act I readiness.

## Navigation

- [[Ashira Companion Campaign]]
- [[The Faces She Kept]]
- [[A Useful Terror]]
- [[Anchored Hauntings]]
