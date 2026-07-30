---
type: quest
status: draft
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Grenz Lowlands"]
culture: ["Eclessian", "Korrheim"]
related_factions: ["Blackjack Corps", "Ducal Marcher Service"]
appears_in: ["Grenzburg"]
needs: []
tags: [narrative-rewrite]
quest_class: companion
act: act-1
availability_window: ["Open Autumn", "Early Winter"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["dismas_act1_chapter_resolved", "dismas_act1_result", "dismas_direction", "winter_medicine_state", "ravine_civilian_state", "dismas_counting_heard", "lieutenant_report_state"]
reward_unlocks: ["Reversible Line", "rearguard custom parts"]
required_locations: ["Split Pine Ravine", "Lowland Reed Road", "Blackjack Yard"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-finale
companion_campaign_stage: act-1
quest_owner: "Dismas Raben"
quest_sequence: 3
companion_id: "CMP-06"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: confrontation
relationship_variant: ""
preparation_inputs: ["dismas_fence_route_kept", "dismas_lask_repair_begun", "dismas_ravine_civilian_timing", "dismas_reversible_trap_stock", "dismas_marcher_stop_right"]
preparation_threshold: "2 participate; 3 all material objectives; 4 one safeguard"
encounter_deck: []
postgame_season: ""
estimated_hours: 1.5
gameplay_pillars: [ambush, traversal, rescue, pursuit, moral-reckoning]
required_states: ["dismas_introduction_complete", "dismas_act1_readiness_viable"]
optional_state_inputs: ["reedknife_band_state", "longlake_passage_rule", "toll_precedent_state"]
companion_required: "Dismas Raben"
duo_quest: true
pause_points: ["Traps Placed", "Medicine Recovered"]
autonomous_deadline: "The Last Convoy"
autonomous_resolution: "Dismas springs the ambush on time. The medicine is recovered, the wood train takes two injuries, and he accepts the lieutenant's offer to leave the civilians out of the report."
changed_reentry: "A winter road-camp aftermath permits compensation and the disarming of the remaining line, but not the report's correction"
ensemble_inputs: ["Ylva Winter-Track", "Bernard Valeon"]
identity_hooks: ["Military", "Wilderness", "Peasant/Labour", "Underworld"]
emotional_rewrite_status: cleared
dialogue_status: pending-rewrite
remote_claim_status: compliant
archetype_pressure: "A prepared hazard, mixed traffic, and an officer offering to make the cost disappear from the paper."
emotional_function: "Put his hands on the exact machinery of 1355, and let the body remember before the man explains."
pleasure_beat: "Reversible trapcraft, a ravine read like a page, and taking a raider band apart without killing anyone."
care_beat: "Dismas stays in the dark afterward to disarm his own devices, uncredited, while the raiders regroup."
player_archetype_hooks: ["Cheerleader", "Tomboy", "Goth", "Bohemian", "Jock", "Nerd", "Rebel", "Goofball", "Grey"]
persistence_scope: regional-milestone
---
# The Easy Ambush

## Quest Function

Dismas's Act I finale, built out from outline. A marcher patrol asks him to design an ambush; a civilian wood train enters the kill zone early; and somewhere above the road, stone shifts.

**This is where the counting-freeze lands** — the body remembering before the man has explained anything. The player sees the tell hours before they can possibly understand it.

## Premise

Raiders out of the Reedknife band are moving stolen winter medicine east along the Lowland Reed Road: eleven crates of salve, bark, and spirits off a Mercy Hospital consignment, worth more than the men carrying them.

A marcher lieutenant — competent, tired, results-oriented — asks the Blackjacks for a route specialist. Split Pine Ravine is the obvious place, and Dismas can see the whole thing before he has finished walking it: two anchors, a fall line, a bottleneck, done by dusk.

Then the timing sheets come in. The ravine also carries a **civilian wood train**: four carts, a family concern, running late because the frost came early.

## Party and Preparation

Accepting at the Yard forms the fixed player-plus-Dismas duo. Prepared road workers may appear as temporary NPCs.

| Asset | Concrete advantage |
|---|---|
| `dismas_fence_route_kept` | the roofline habit transfers — he reads the upper track fast and unexposed |
| `dismas_lask_repair_begun` | Old Market witnesses will vouch for a Blackjack's account of the night |
| `dismas_ravine_civilian_timing` | the wood train's actual schedule rather than the sheet's |
| `dismas_reversible_trap_stock` | every device placed can be disarmed in the dark, under pressure |
| `dismas_marcher_stop_right` | a named authority can abort the ambush without a court or a delay |

Two permit the operation. Three make medicine, civilians, band, and record all achievable. Four or five protect one objective from a single failure.

## Beginning: Setting the Line

The player and Dismas place the ambush, and the quest should let this be beautiful: sight lines, a false path, a fall that drops timber rather than stone, the release sited where one person can reach it — and where **anybody** can reach the disarm.

He states the rule once, in a tone that closes the subject:

> **Dismas:** Everything I put down comes back up. That is not a preference.

### Pause Point: Traps Placed

The quest may pause once the line is set. Nothing advances.

## The Sound

Late in the setting, a section of the upper shelf lets go on its own — ordinary autumn, frost in a seam, perhaps forty stone of rubble down a slope two hundred yards off.

Dismas stops.

He is completely still for about four seconds, and his mouth is moving, and he is not talking to anyone. Then he says something dismissive about the frost and goes back to work, and his hands are steady, and he is fine, and he is very obviously not fine.

If the player asks, he redirects. If the player insists, he redirects better. **The explanation does not happen in this quest.**

Later, at the fire, if the player has been decent about it and has not made it a subject:

> **Dismas:** Three voices. Two at the front. One pretending the wheel wasn't frightening him.
>
> *(The player does not have to say anything.)*
>
> **Dismas:** I counted because counting was easier than going back.

He does not call it courage. He does not name the road, the year, or what happened to the three. He picks up the wire and finishes the job, and it will be Act II before anyone learns the rest — and only if he decides to find out himself.

*(Counting beat 1 of 4. Writes `dismas_counting_heard`.)*

## Middle: The Wood Train

The train arrives early, into a live kill zone, with the raiders twenty minutes behind it.

All five are viable:

- **abort and pursue** — sacrifice the position, take the band on open road: hardest fight, cleanest conscience;
- **spring partial** — trigger only sections clear of the carts, which works, and which requires him to fire a prepared hazard with civilians inside two hundred yards;
- **clear the train first** — talk, buy, or bully four carts out of a ravine in twenty minutes, and the family are not soldiers and do not move fast;
- **accept the risk** — the lieutenant's preference and the decisive capture;
- **use the stop right** — abort by named authority and lose the medicine tonight.

Preparation and strong play can preserve the medicine, the civilians, and the band's leader together. Fewer assets force a real choice among them.

**His old instinct favours the cleanest shot, and the quest lets the player feel him lean.** He does not argue for it out loud. He simply has the release in his hand and a very good reason ready.

## The Lieutenant

However it goes, a report has to be written, and the lieutenant has a suggestion.

If civilians were hurt — or nearly were, or the documented risk is awkward — he will leave them out. It costs nothing, protects the operation's success, protects the Blackjacks, protects Dismas, and is offered as a professional courtesy between people who understand paper.

**It is the Korrheim conviction in miniature: an institution offering to make the human cost vanish from the record.** Nobody in the scene knows that but Dismas and, by now, possibly the player.

Refusing means a harsher review, a documented near-miss, and an officer who remembers being embarrassed. It also means the ravine's civilian traffic gets scheduled properly next season, because somebody wrote it down.

## End: The Dark

After the fight — whatever the fight was — there are live devices in the ravine and the raiders who ran are regrouping half a mile off.

Somebody has to walk the line in the dark and take all of it up.

**This is the played climax.** No credit, no witnesses, nobody watching but the player: three hours of careful, unheroic work on his own machinery, with a clean exit visible the entire time. The horses are right there. The medicine is already recovered. The lieutenant would not even ask.

He stays. Or he does not.

## Outcomes

`dismas_act1_result`:

- **stayed:** civilians unhurt, the line taken up, the report honest;
- **costly:** medicine and civilians preserved at the cost of the band's leader, or the reverse;
- **held:** the right things happened because the player or the stop right made them happen;
- **fled:** the line left live, or the lieutenant's offer accepted, or both.

Record `winter_medicine_state`, `ravine_civilian_state`, `lieutenant_report_state`, `dismas_direction`.

Unlock **Reversible Line** and the rearguard custom parts. Opens [[No Railing]].

## Fail-Forward

- Escaped raiders reduce Lowland road safety and reappear as a bounded winter camp.
- Injured civilians survive; the family's cart trade suffers and they remember who was on the shelf.
- A live line left in the ravine injures a woodcutter in Deep Winter — recoverable through changed re-entry, not erasable.
- Duo defeat: road workers recover them, the band leaves with the medicine, and the winter is worse.
- **No civilian dies from a failed check here.** This road's dead are already accounted for, and they are not in this ravine.

## Navigation

- [[Dismas Raben]] · [[Dismas Companion Campaign]] · [[The Korrheim Rockfall]]
- [[The First Mile]] · [[No Railing]] · [[Dismas Quarry-Wise Package]]
- [[Sergeant Liese of the Marcher Vanguard]]
