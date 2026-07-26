---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Frostfenn March", "Upper Grenz"]
culture: ["Ättar", "Grey-Wolf", "Eclessian", "Folk"]
related_factions: ["Blackjack Corps", "Duchy of Grenzburg"]
appears_in: ["Grenzburg"]
needs: []
tags: [narrative-rewrite]
quest_class: companion
act: act-3
availability_window: ["Dead March", "Before Deep Muster"]
repeatability: one-shot
cutoff_result: autonomous
world_state_outputs: ["ylva_act3_finale_played", "ylva_direction", "ylva_final_outcome", "fenn_lantern_state", "white_mud_causeway_state", "last_hearth_evacuated", "last_marker_relief_state", "ylva_fate", "ylva_relationship_perk"]
reward_unlocks: ["Winter-Track Fieldcraft", "Hearthward or Second Watch", "Ylva Final Companion Resolution"]
required_locations: ["Fenn Lantern", "White Mud Causeway", "Last Hearth"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-finale
companion_campaign_stage: act-3
quest_owner: "Ylva Winter-Track"
quest_sequence: 9
companion_id: "CMP-03"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: "Two Act III preparation assets"
estimated_hours: 2.25
gameplay_pillars: [duo-command, mass-evacuation, residue-combat, severe-traversal, moral-climax]
required_states: ["ylva_recruited", "dead_march_active"]
optional_state_inputs: ["ylva_living_route_atlas", "ylva_tannbruck_scout_post_restored", "ylva_fenn_lantern_fuel", "ylva_last_hearth_relief_roster", "ylva_white_mud_extraction_line", "ylva_homeward_route_practiced", "ylva_sister_watch_practiced"]
field_experience_gate: ["two Act III preparation assets"]
companion_required: "Ylva Winter-Track"
duo_quest: true
pause_points: ["Fenn Lantern Relit", "Last Hearth Reached"]
relationship_gate: ""
relationship_variant: ""
preparation_inputs: ["ylva_living_route_atlas", "ylva_tannbruck_scout_post_restored", "ylva_fenn_lantern_fuel", "ylva_last_hearth_relief_roster", "ylva_white_mud_extraction_line"]
preparation_threshold: "2 join; 3 all material objectives; 4-5 one safeguard"
autonomous_deadline: "The Deep Muster Main Quest"
autonomous_resolution: "Other Blackjacks recover Ylva after she tries to hold the final route alone; she becomes a supervised pathfinder"
changed_reentry: "The Road She Chooses reflects the fixed autonomous settlement"
ensemble_inputs: ["Elara Velescar", "Zafir ibn Samad", "Ilyana Veshkar", "Tavio Meran"]
identity_hooks: ["Ättar", "Folk", "Military", "Wilderness", "Peasant/Labour", "Mystic/Religious", "Hunter", "Fighter", "Slayer", "Warlock", "Medium", "Bard", "Lancewright", "Paladin", "Binder"]
encounter_deck: ["Muster residue formation", "black-mud surge", "dead-march siege engine"]
persistence_scope: permanent
postgame_season: ""
emotional_rewrite_status: preserve
dialogue_status: pending-rewrite
archetype_pressure: "Competence becomes self-erasure: test whether Ylva accepts shared agency without reading care as confinement."
emotional_function: "Keep relief, final-route pressure, and the fully warned sacrifice distinction"
pleasure_beat: "Field competence, open weather, friendly contest, practical food, and quiet work done well."
care_beat: "Ylva notices strain and shares practical work while leaving the other person real authority over risk."
player_archetype_hooks: []
---
# The Last Marker

## Quest Function

Ylva's Act III finale is a player-and-Ylva command-and-rescue operation across Fenn Lantern, White Mud Causeway, and Last Hearth during the dead march.

It resolves whether Ylva can build a route that includes her own relief. Her optional sacrifice is heroic but unresolved and appears only after safer alternatives are visibly exhausted or refused.

Other active companions leave at the staging point. Trained route teams, evacuees, guards, carers, and rescued people remain temporary NPCs outside the companion limit.

## Trigger

The Muster counteroffensive cuts the southern relay into three isolated signals:

- Fenn Lantern burns low and reports a residue column;
- White Mud Causeway has lost its north anchor;
- Last Hearth shelters civilians, wounded scouts, and two route teams awaiting an evacuation order.

Ylva proposes moving south, relighting the chain, and remaining at the final marker until every group passes.

With two preparation assets, the player can join through a credible duo plan. The transition docket names every missing asset and warns that declining fixes Ylva's autonomous settlement.

## Stage One: Fenn Lantern

The duo reaches Fenn Lantern by:

- the public Fenn Road;
- a secured spring shelf;
- a line crossing over shallow black mud;
- the restored Tannbruck relay approach.

The lantern is surrounded by residue infantry repeating a deployment turn. Their bodies are empty shells animated by command residue. They cannot be reasoned back into personhood.

The duo must:

- clear or bypass the formation;
- recover the lamp cap;
- choose whether to spend reserve fuel now;
- restore the signal;
- send a truthful report north.

If fuel was prepared, the lantern remains active through the finale. Without it, the player chooses between immediate guidance and retaining fuel for Last Hearth.

## Stage Two: White Mud Causeway

The causeway's northern anchor has torn free. Three groups are separated:

- a six-person route crew;
- four wounded soldiers with one litter;
- a household group carrying two children and an elderly miller.

Black mud rises through the old road joints while a residue siege frame advances from the south.

Solutions include:

- use the prepared extraction line;
- place a Line Arrow pilot and haul a full rope;
- repair the anchor under covering fire;
- break the frame's command axle;
- lead groups over exposed stones;
- create smoke and withdraw before the formation locks.

All vocations remain viable. Ylva opens rescue opportunities but is never the only character capable of interacting with the line, carrying a person, breaking an obstruction, or disabling the frame.

## Relief Choice

The route crew offers to remain at the causeway while Ylva moves south. She attempts to refuse because they are tired.

The player may ask the crew for:

- its actual condition;
- its chosen risk;
- its required relief time;
- and its withdrawal signal.

If informed and supported, the crew can choose to hold. Protecting people does not mean denying competent adults their agency.

Ylva's response materially affects `ylva_direction`.

## Stage Three: Last Hearth

Last Hearth contains:

- eleven civilians;
- seven wounded or exhausted defenders;
- three carers;
- a route archive;
- food and lamp stores;
- one damaged handcart;
- a relief roster, if prepared.

The dead march approaches in three ranks. The duo has a limited period to:

- prepare evacuation groups;
- choose what records and stores travel;
- mark the northern lane;
- place smoke and controlled blast points;
- assign receiving responsibility;
- decide who operates the final signal.

Three preparation assets make every material objective achievable through strong play. With fewer, living people remain the priority.

## The Counteroffensive

The evacuation unfolds in overlapping waves:

1. fast walkers and messengers;
2. carried or wounded people;
3. carers and remaining defenders;
4. route records and essential stores;
5. the final marker team.

Residue forces do not hunt personalities. They follow command geometry, lights, rank marks, and road grooves. The player can manipulate that logic without treating the dead as conscious soldiers.

The encounter combines:

- ranged interruption;
- route defense;
- carrying and revival;
- line operation;
- obstruction clearing;
- signal choices;
- staged withdrawal.

Failure in one wave adds pressure to the next rather than ending the quest.

## The Last Marker

At the final signal, Ylva insists that she can keep the dead fixed on the light while everyone else withdraws.

The full resolution tree is shown, not hidden behind one check:

### Relief Available

If a roster, living-route atlas, or surviving causeway crew exists, relief arrives. Ylva may:

- hand over the watch and leave;
- remain beside the relief team for one bounded interval;
- refuse relief.

Resolved Ylva leaves when the agreed change occurs.

### Extraction Available

If the White Mud line, relationship safeguard, or strong preparation remains, the marker can be operated remotely or abandoned after a timed withdrawal.

The player and Ylva leave together.

### No Prepared Relief

The duo can still:

- collapse the lamp platform after drawing the residue;
- carry the signal north in stages;
- destroy the command groove;
- abandon records and stores to preserve movement;
- fight a harder retreat.

These options cost material and may injure temporary NPCs, but preserve a living route.

### Sacrifice

Ylva's sacrifice appears only if:

- safer alternatives have visibly failed, been spent, or been knowingly rejected;
- Last Hearth's final group still requires time;
- Ylva is physically capable of holding the marker;
- the player receives an explicit confirmation stating that she will die;
- the player accepts rather than merely fails a check.

She remains, lights the last flare, and is killed after the final group clears the causeway. The act saves lives but fixes `ylva_final_outcome: heroic-unresolved`.

The player may always refuse and attempt the harder shared retreat.

## Final Decision

If Ylva survives, the northern route board records:

- who held each station;
- who called relief;
- who accepted it;
- what was abandoned;
- and whether liability was shared.

Resolved Ylva signs as one member of the route, not its sole bearer.

The player then chooses or influences her destination:

- independent pathfinder with open shared contracts;
- ducal route scout;
- Blackjack pathfinder;
- solitary departure;
- destination deferred until summer.

Destination does not replace moral outcome.

## Fail-Forward

- **Fenn Lantern remains dark:** northern teams receive warning by runner and suffer greater casualties.
- **Causeway anchor fails:** every person remains rescuable through stones and line work; stores are harder to save.
- **A group is delayed:** the next combat wave strengthens.
- **Route archive is lost:** living teams still know their route, but summer reconstruction loses records.
- **Ylva is incapacitated:** the player and temporary team finish the signal; she survives if recovered.
- **Duo defeat before the final choice:** prepared teams recover survivors and fix a compromised autonomous result.
- **No single failed check kills Ylva:** only the explicit sacrifice choice can do so.

## Rewards

- **Winter-Track Fieldcraft**, account-wide.
- final companion resolution.
- resolved or compromised romance grants **Hearthward**.
- resolved or compromised sworn bond grants **Second Watch**.
- friendship retains full progression and can produce the resolved outcome.
- regional casualty, route, and reconstruction states.

## Navigation

- [[Ylva Companion Campaign]]
- [[Ylva Winter-Track]]
- [[Ylva Field Familiarity and Relationships]]
- [[Ylva Rescue Hunter Package]]
- [[Routes for the Living]]
- [[The Dead March]]
- [[The Deep Muster Main Quest]]
- [[Frostfenn March]]
- [[The Road She Chooses]]
