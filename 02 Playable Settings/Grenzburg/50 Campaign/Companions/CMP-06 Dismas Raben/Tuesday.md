---
type: quest
status: draft
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Grenz Lowlands", "Old Market"]
culture: ["Eclessian", "Korrheim"]
related_factions: ["Blackjack Corps", "Low Lanterns", "Ducal Marcher Service"]
appears_in: ["Grenzburg"]
needs: []
tags: [narrative-rewrite]
quest_class: companion
act: act-3
availability_window: ["Open Thaw", "Spring Reclamation"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["dismas_guide_network_charter", "guide_network_state", "dismas_local_guides_trained", "dismas_direction"]
reward_unlocks: ["Somebody Else's Road", "network charter"]
required_locations: ["Blackjack Yard", "Old Market", "Lowland Reed Road"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-operation
companion_campaign_stage: act-3
quest_owner: "Dismas Raben"
quest_sequence: 8
companion_id: "CMP-06"
main_sequence: 0
story_gate: preparation
relationship_variant: ""
estimated_hours: 0.75
gameplay_pillars: [social, arbitration, travel, maintenance]
required_states: ["dismas_act2_chapter_resolved", "open_thaw_active"]
optional_state_inputs: ["passage_state", "dismas_passage_handoffs", "toll_precedent_state", "dismas_lask_task_kept", "underworld_branch_low_lantern"]
companion_required: "Dismas Raben"
duo_quest: false
pause_points: ["Week Begun"]
autonomous_deadline: "The Deep Muster"
autonomous_resolution: "He settles the quarrel by fiat, keeps the fee book himself, and the network becomes a thing that works because he is in it. The charter is lost."
changed_reentry: "The network enters the finale as his personal following rather than an institution"
ensemble_inputs: ["Ilyana Veshkar", "Ylva Winter-Track", "Zafir ibn Samad", "Bernard Valeon"]
identity_hooks: ["Peasant/Labour", "Merchant/Craft", "Underworld", "Drifter/Vagabond"]
emotional_rewrite_status: cleared
dialogue_status: pending-rewrite
remote_claim_status: compliant
archetype_pressure: "Nothing is wrong. That is the antagonist."
emotional_function: "Make peace the container he cannot pick, and let the network survive its founder being bored."
pleasure_beat: "A fee dispute conducted with total seriousness, two guides who hate each other, and a route marked properly in good weather."
care_beat: "He arbitrates by the rules on the post, re-marks a route, and shows up on the day."
player_archetype_hooks: ["Cheerleader", "Tomboy", "Goth", "Bohemian", "Jock", "Nerd", "Rebel", "Goofball", "Grey"]
persistence_scope: regional-persistent
---
# Tuesday

## Quest Function

Dismas's Act III operation, and the campaign's structural joke: **the free guide network's first entirely normal week.**

No villain. No pursuit. No crisis. Nothing is wrong, and that is the antagonist.

## Premise

The siege has lifted. The roads are open, the checkpoints are half-staffed and mostly polite, and the thing Dismas built out of a dead tunnel and a set of keeping-rules is now, unmistakably, an organization.

It has fourteen people, a fee book, a marked-route list, and problems:

- **a fee dispute.** Two guides charged different rates on the same run and a carter is furious about it, correctly.
- **a territory quarrel.** Ordde and Sen both claim the Reed Road stretch. Neither is wrong. Neither will move. They have not spoken in nine days and are conducting the whole thing through a third guide who is sick of it.
- **a route that needs re-marking.** The spring thaw moved a ford. Somebody has to walk eleven miles and cut new marks, and it is nobody's turn, and everybody says so.
- **a complaint.** A client is angry about a *perfectly safe detour* that added ninety minutes, and wants the fee back, and is going to be unpleasant about it in the Old Market where people can hear.

None of this is dangerous. All of it is Tuesday.

## The Temptations

Three, all authored, all open, all in character:

### Leave

The exits have never closed. Nobody is watching the fee book. The network would run for weeks before anyone noticed he was gone, which is a fact he can work out in about four seconds and does.

### Manufacture

**The retired outlaw's itch,** and the quest's most interesting failure: he can make Tuesday interesting.

Spice a route report with a hazard that is not quite there. Refuse an escort to prove the network's independence from a sponsor who has not actually threatened it. Take a client the long way to demonstrate a checkpoint's malice. Every one of these is a small lie that makes the work exciting again, and every one of them is Stonefall's grammar at harmless scale — a prepared hazard fired on an unconfirmed target.

The player may encourage, permit, or name it. Naming it is awkward and he will be charming about it.

### Rule

Settle the quarrel by fiat. Keep the fee book himself. Decide the rates, hold the marked-route list, be the person everybody asks. It works instantly and makes the network **his**, which the campaign's outcome standard forbids and which he would enjoy enormously.

## The Actual Work

The resolved play is the dullest and hardest thing in his campaign:

- **arbitrate by the post.** The keeping-rules from [[The Missing Queen]], or their equivalent from [[Passage]]'s handoff terms, are already written. He can apply them rather than his judgement, which means Ordde and Sen both get half of what they want and neither thanks him.
- **fix the rate.** Publicly, in the fee book, in a hand other people can read.
- **walk the eleven miles.** With whoever is willing, in good weather, to cut marks nobody will credit.
- **hear the complaint.** In the Old Market, out loud, from a man who is being unpleasant, and refund half of it because half is right.
- **show up on the appointed day** for the Lask surety visit, which is the same week, which nobody has reminded him about.

⟨PAIR⟩ The Ilyana spring foil beat — *she leaves room in the song; he arrives when promised* — lands here.

### Pause Point: Week Begun

## The Charter

At the end of the week the network either has a charter or has Dismas.

The charter is one page and it is boring: who marks what, who holds the fees, who may refuse a client, who settles a dispute, and — the clause he writes last and hates most — **what happens if the founder leaves.**

Writing that clause is the piece's moral climax, and it is a man specifying his own dispensability in his own hand on a Tuesday afternoon.

Before he signs it he counts the network — fourteen guides, by name, off the fee book, out loud, because he wants to know the number he is handing over. He gets it right the first time and does not check it twice.

*(Counting beat 4 of 4. The spine closes: the first count he ever finished without needing to, of people who are all still alive.)*

## Convergence Note

This is the roster's fourth institution-must-survive-its-founder piece, and its axis is distinct: Bernard's is indispensability, Ilyana's is authorship, Elara's is dethronement. **Dismas's is boredom.** Nothing is threatening the network. He simply cannot bear a week in which refusal is not required of him, and the quest says so without offering a lesson about it.

## Outputs

- `dismas_guide_network_charter`: written, partial, or none — Act III preparation;
- `guide_network_state`: chartered, founder-held, fractured, or dissolved;
- `dismas_local_guides_trained`: how many can lead a group out without him — Act III preparation;
- `dismas_direction`: **returning** if he applies the rules and keeps the appointment; **held** if the player has to hold him to it; **gone** if he manufactures a hazard, rules by fiat, or simply stops attending.

## Fail-Forward

- An unwritten charter means the network enters the finale as his following, which is materially useful and thematically fatal.
- A manufactured hazard is discovered by a guide within the season and costs trust, not lives.
- An unresolved quarrel splits the Reed Road stretch and loses one route into the finale.
- A missed Lask visit is noticed and mentioned by a nine-year-old.

## Navigation

- [[Dismas Raben]] · [[Dismas Companion Campaign]]
- [[Passage]] · [[The Missing Queen]] · [[The Lask Household]] · [[Mette Harrow]]
- [[The Road That Answers]]
