---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Frostfenn March", "Grenz Lowlands"]
culture: ["Eclessian", "Korrheim"]
related_factions: ["Blackjack Corps", "Ducal Marcher Service", "Unending Muster"]
appears_in: ["Grenzburg"]
needs: []
tags: [narrative-rewrite]
quest_class: companion
act: act-3
availability_window: ["Spring Reclamation", "Muster Crisis"]
repeatability: one-shot
cutoff_result: resolves-offscreen
world_state_outputs: ["dismas_act3_chapter_resolved", "dismas_act3_result", "dismas_arc_outcome", "dismas_sacrifice_state", "dismas_future_path", "three_horn_evacuated", "dismas_relationship_perk", "dismas_summer_destination"]
reward_unlocks: ["No One Behind", "Quarry-Wise blueprint", "No Escape Route", "No Blind Turn"]
required_locations: ["Three Horn Depot", "Fenn Road", "White Fen", "Fenn Road Exchange"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-finale
companion_campaign_stage: act-3
quest_owner: "Dismas Raben"
quest_sequence: 9
companion_id: "CMP-06"
main_sequence: 0
story_gate: finale
relationship_variant: ""
preparation_inputs: ["dismas_guide_network_charter", "dismas_fen_route_marked", "dismas_local_guides_trained", "dismas_depot_manifest_read", "dismas_residue_pattern_sampled"]
preparation_threshold: "2 participate; 3 all material objectives; 4 one safeguard"
grounded_rewrite_status: approved
external_stakes: ["road users", "medicine and supplies", "public passage", "civilian withdrawal"]
banter_priority: essential
player_interest_gate: none
missed_arc_treatment: changed-reentry
encounter_deck: []
postgame_season: ""
estimated_hours: 2.0
gameplay_pillars: [evacuation, traversal, defence, sabotage, closure]
required_states: ["dismas_act2_chapter_resolved", "dismas_act3_readiness_viable", "muster_known"]
optional_state_inputs: ["dismas_return_leg_practiced", "dismas_missing_queen_given", "guide_network_state", "dismas_charge_filed_state", "reprisal_family_state"]
companion_required: "Dismas Raben"
duo_quest: true
pause_points: ["First Group Away", "Depot Cleared"]
autonomous_deadline: "The Deep Muster"
autonomous_resolution: "See Companion Autonomy and Act Convergence; untracked content uses stable-colleague treatment."
changed_reentry: "Passing Through Slowly reflects a tracked settlement or Dismas's stable-colleague summer state."
ensemble_inputs: ["Ylva Winter-Track", "Bernard Valeon", "Ilyana Veshkar"]
identity_hooks: ["Military", "Wilderness", "Peasant/Labour", "Underworld"]
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
archetype_pressure: "Three legs, three sincere exits. Nothing contains him and nothing can make him stay."
emotional_function: "Resolve him through repetition — a road chosen three times, uncoerced."
pleasure_beat: "Fen craft, a road pattern spoiled rather than fought, and guides he trained leading groups he cannot see."
care_beat: "He is the last one out, three times, because he decided to be."
player_archetype_hooks: []
persistence_scope: regional-milestone
---
# The Road That Answers

## Quest Function

Dismas's Act III finale, built out from outline. A dead-march column cuts the Fenn Road and traps civilians at Three Horn Depot.

**The finale never contains him.** Three legs, three sincere and takeable exits, and a resolved outcome that is not obedience but repetition: *a road chosen twice*, scaled to thrice.

## Premise

A residue column following old replacement orders is moving up the Fenn Road toward Tannward and will pass within reach of Three Horn Depot, where a spring convoy has stopped: eleven carts, forty-one civilians, nine wounded marchers, a depot clerk, and a manifest nobody has read.

The military lane is short, hard, and defensible. The civilian route is the fen track — slower, wetter, and impossible to hold.

## Party and Preparation

Accepting forms the fixed player-plus-Dismas duo. Trained guides, evacuees, and marchers are temporary NPCs.

| Asset | Concrete advantage |
|---|---|
| `dismas_guide_network_charter` | the network functions as an institution, and guides act without waiting for him |
| `dismas_fen_route_marked` | a third exit exists, marked in his own notation |
| `dismas_local_guides_trained` | somebody else can lead a group out |
| `dismas_depot_manifest_read` | civilian numbers are known before the column arrives, not counted during it |
| `dismas_residue_pattern_sampled` | the column's road-logic can be spoiled rather than fought |

Two permit the operation. Three make all three groups, the depot stores, and the pattern-spoiling achievable. Four or five add one safeguard, as does either relationship safeguard (equal, exclusive, non-stacking).

## The Three Legs

The evacuation runs in three movements, and **each ends with an authored, sincere, genuinely takeable exit.** Not a trick, not a test, and never punished by the interface.

### Leg One — the fast walkers

Thirty-one people who can move, out along the fen track behind a guide.

**The exit:** Pierre's officer offers Dismas a *sealed specialist commission* on the spot — rank, pay, a road brief, and a lawful reason to be with the military column instead of the fen. It is a good offer, honestly meant, and it would make him a scout of the Duchy by nightfall.

### Leg Two — the wounded and the slow

Nine wounded marchers, four elderly, two children, one handcart with a broken shaft. This is the leg that costs, and it needs the line held behind it.

**The exit:** the column's flank opens during the fighting, and there is a forty-minute window in which a man who knows fen ground could simply not be there afterward, and no one would ever be able to say he ran rather than fell. Nobody would look for him. There would be no record.

### Leg Three — the last group

The clerk, the depot stores, two guides who refused to leave earlier, and whoever the first two legs could not carry.

**The exit:** [[Sergeant Liese of the Marcher Vanguard|Liese]] releases him. Out loud, in front of witnesses, sincerely: *you have done enough, this is not your column, go.* She means it and she is right, and she is the one authority in the campaign whose respect he has actually earned. **The release must be genuine** — no scene undercuts it, and refusing it is not a rebuke to her.

Resolved play is choosing to stay **three times**, uncoerced, with no one watching who could compel him.

## The Work

Between the exits, the quest is craft:

- **spoiling the pattern.** Residue follows command geometry, road grooves, and rank marks. Dismas does not fight a column; he makes a road stop looking like a road — grooves broken, marks defaced, a false lane cut into the fen that reads better to a dead formation than the real one does. His whole doctrine, finally used at scale.
- **holding the line.** Rearguard work, reversible obstacles, and disengagement windows for people who cannot run.
- **guides leading.** If trained, they take groups out on their own initiative and out of the player's sight, and the quest reports their arrivals rather than showing them.
- **the manifest.** Read or unread, it determines whether anyone knows that two names are missing before the fen swallows the evidence.

### Pause Points: First Group Away · Depot Cleared

## Outcomes

**Resolved — the free guide who stayed.** He is not commissioned, not ranked, and not anybody's scout. He is the last one out with the network's people, answerable to a route rather than an office, and the settlement records him as a road protector under no authority's charter but the one he wrote himself on a Tuesday.

**Compromised — supervised.** Real protection under somebody else's structure: the sealed commission, a Blackjack rank, or the player's insistence as the thing that makes him reliable. He can name the arrangement as useful and insufficient, and does.

**Broken or departed.** He takes the flank window, sells or abandons the fen route, or becomes the network's toll. A warned confrontation and one repair chance precede his departure.

**Heroic but unresolved sacrifice.** Available only after all three exits have visibly failed or been spent, with the alternative casualties shown, with Dismas offering it, and with explicit player confirmation. He holds the last groove-break while the final group clears White Fen. It saves them and fixes `dismas_arc_outcome: heroic-unresolved`, which is **not** his strongest resolution.

**The word "domestication" appears in no resolved-outcome sentence.** If a line reads as him settling under a good commander, cut it.

## Rewards

Resolved or compromised completion grants **No One Behind** (the rearguard capstone, named for the thing he did not do at Stonefall Cut, and no in-game text says so), the Quarry-Wise blueprint, and the eligible permanent perk: **No Escape Route** (romance) or **No Blind Turn** (bond).

Friendship reaches the resolved outcome and every non-relationship reward.

## Fail-Forward

- A lost leg means displacement and casualties, and survivors reach Fenn Road Exchange; the depot's people are never wiped out by a timer.
- Failed pattern-spoiling turns the last leg into a moving fight rather than ending the quest.
- An unread manifest means two people are missing and nobody can say who.
- Duo defeat: guides and marchers recover them, the depot is lost, and the settlement fixes the compromised result.
- No autonomous route selects the sacrifice.

## Navigation

- [[Dismas Raben]] · [[Dismas Companion Campaign]] · [[Dismas Quarry-Wise Package]]
- [[Tuesday]] · [[The Missing Queen]] · [[The Return Leg]] · [[Passing Through Slowly]]
- [[The Dead March]] · [[The Deep Muster Main Quest]] · [[Frostfenn March]]
