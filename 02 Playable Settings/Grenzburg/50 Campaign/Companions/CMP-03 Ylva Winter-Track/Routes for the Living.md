---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Upper Grenz", "Highlake Uplands", "Frostfenn March"]
culture: ["Ättar", "Grey-Wolf", "Eclessian", "Folk"]
related_factions: ["Blackjack Corps", "Duchy of Grenzburg"]
appears_in: ["Grenzburg"]
needs: []
tags: [narrative-rewrite]
quest_class: companion
act: act-3
availability_window: ["Spring Reclamation"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["ylva_living_route_atlas", "ylva_direction", "upper_grenz_route_team_state", "tuskway_route_team_state", "frostfenn_route_team_state", "duplicated_stores_state"]
reward_unlocks: ["Controlled Blast Arrow", "Living Route Atlas"]
required_locations: ["Upper Grenz", "Tuskway", "Frostfenn March", "Tannbruck Scout Post"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-operation
companion_campaign_stage: act-3
quest_owner: "Ylva Winter-Track"
quest_sequence: 8
companion_id: "CMP-03"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: "The Open Thaw"
estimated_hours: 0.75
gameplay_pillars: [route-survey, team-training, residue-clearance, logistics]
required_states: ["ylva_recruited", "spring_reclamation_active"]
optional_state_inputs: ["tannbruck_reclaimed", "folk_compact_state", "ducal_route_support", "blackjack_reform_state"]
field_experience_gate: []
companion_required: "Ylva Winter-Track"
duo_quest: false
pause_points: ["Two Route Teams Certified", "Atlas Duplicated"]
relationship_gate: ""
relationship_variant: ""
preparation_inputs: ["ylva_tannbruck_scout_post_restored", "ylva_fenn_lantern_fuel", "ylva_last_hearth_relief_roster", "ylva_white_mud_extraction_line"]
preparation_threshold: ""
autonomous_deadline: "The Deep Muster Main Quest"
autonomous_resolution: "Ylva maps the routes but keeps the master copy and final authority herself"
changed_reentry: "The Road She Chooses reflects the incomplete shared atlas"
ensemble_inputs: ["Elara Velescar", "Zafir ibn Samad", "Dismas Raben"]
identity_hooks: ["Ättar", "Folk", "Military", "Wilderness", "Scholarly", "Peasant/Labour", "Hunter"]
encounter_deck: ["Muster route interference", "spring flood", "abandoned military stores"]
persistence_scope: regional-milestone
postgame_season: ""
emotional_rewrite_status: reframe
dialogue_status: pending-rewrite
archetype_pressure: "Competence becomes self-erasure: test whether Ylva accepts shared agency without reading care as confinement."
emotional_function: "Make this a delegation and training operation rather than a third mapping exercise"
pleasure_beat: "Field competence, open weather, friendly contest, practical food, and quiet work done well."
care_beat: "Ylva notices strain and shares practical work while leaving the other person real authority over risk."
player_archetype_hooks: []
---
# Routes for the Living

## Quest Function

This normal-party operation creates three independently held evacuation corridors before the dead march. It prepares [[The Last Marker]], unlocks Ylva's final practical arrow recipe, and tests whether her route knowledge can remain useful without a single master carrier.

## Trigger

After [[The Open Thaw]], scouts discover that old Muster waymarks are reappearing along living roads. Corpse residue follows rank signs and command grooves, turning familiar retreat lines into channels toward the south.

Ylva proposes one corrected atlas carried by herself.

Brina points out the obvious danger: if Ylva is captured, injured, or wrong, all three fronts inherit the same failure.

## The Three Corridors

The party may address the corridors in any order.

### Upper Grenz

Reopen the Tannbruck scout post and establish a northbound casualty route that does not cross the old command crypt.

Tasks include:

- clearing a collapsed signal room;
- identifying a repeated Muster rank mark;
- moving stores from a single exposed depot into two smaller caches;
- training a ducal and civilian pair to verify one another's route report.

### Tuskway

Mark a high route around the Banner Vault's influence without publishing Ghost-Foot paths or sacred approaches.

Tasks include:

- negotiate local passage;
- distinguish current trail signs from ancient imposed rank;
- secure a spring slide;
- place a pilot line and a visible retreat mark;
- assign one local and one outside copy of the route.

No universal Folk authority is implied. The route exists only through the consent of its particular holders.

### Frostfenn

Connect Fenn Lantern, White Mud Causeway, and Last Hearth through duplicated fuel and line stores.

Tasks include:

- sound black-mud depth;
- clear a residue patrol from an old road notch;
- recover lamp caps without following the dead road south;
- establish a relief roster with explicit change times;
- mark an extraction point north of the causeway.

## Muster Interference

The supernatural threat consists of non-conscious corpse residue and command patterns. The dead repeat old formations, follow rank geometry, and respond to working route marks as if they were mobilization signs.

They are not trapped souls, soldiers awaiting persuasion, or a moral community. Burial knowledge may identify remains and support later rites, but the immediate patterns must be dispersed, burned, broken, or redirected.

Every vocation can contribute:

- shared stealth and traversal avoid patrol lines;
- Fighter breaks formation and protects workers;
- Slayer reaches command marks and flank points;
- Hunter reads route overlap;
- Warlock disrupts engraved command relations;
- Medium uses non-conscious imprints against non-conscious formations without claiming souls;
- advanced vocations provide bounded alternatives.

## The Atlas

The completed work has four layers:

1. public settlement routes;
2. restricted emergency paths;
3. temporary spring closures;
4. secret local paths retained by their custodians.

The player decides how copies are distributed. A valid living-route atlas requires:

- one Upper Grenz holder;
- one Tuskway holder;
- one Frostfenn holder;
- one Blackjack or civic duplicate;
- no theft of protected local knowledge.

Ylva must permit teams to annotate their own copy and act when contact with her is lost.

## Final Drill

The three teams receive different simulated failures:

- Ylva is listed as unavailable;
- one store cache is lost;
- the southern signal arrives late;
- the declared lead must be relieved.

If Ylva intervenes in every response, the routes function but remain `managed`. If she permits correction and accepts being overruled by current conditions, the atlas becomes genuinely shared.

## Fail-Forward

- **One corridor remains closed:** the other two still prepare the finale; its front gains casualties or a harder route.
- **Residue destroys a cache:** the team duplicates remaining supplies at greater cost.
- **Local passage is refused:** a longer public route preserves consent.
- **A map is lost:** an independent team reconstructs its own layer, proving the purpose of duplication.
- **Ylva keeps the master:** the finale remains joinable through other assets but loses `ylva_living_route_atlas`.
- **Party defeat:** route workers withdraw along the already secured segment; one corridor enters the finale under pressure.

## Rewards

- **Controlled Blast Arrow**, account-wide.
- `ylva_living_route_atlas`
- three trained route teams reflected during [[The Dead March]] and [[The Last Marker]].
- Act III preparation assets based on completed corridors.

## Navigation

- [[Ylva Companion Campaign]]
- [[Ylva Winter-Track]]
- [[Ylva Rescue Hunter Package]]
- [[The Open Thaw]]
- [[The Dead March]]
- [[The Last Marker]]
- [[Upper Grenz]]
- [[Frostfenn March]]
