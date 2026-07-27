---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Cathedral Close", "Lantern Ward", "Outer Winter Camps"]
culture: ["Thalmyric", "Kedravan", "Eclessian"]
related_factions: ["Order of the Long Watch", "Church of Grenzburg", "Blackjack Corps", "Grobi"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-2
availability_window: ["Deep Winter", "Early Spring"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["bernard_act2_chapter_resolved", "bernard_act2_result", "bernard_act2_finale_played", "bernard_direction", "bernard_paladin_unlocked", "bernard_relationship_commitment", "bernard_relationship_paths_closed", "bernard_white_flame_kindling", "petra_ilev_response", "long_watch_return_open", "lantern_relief_mission_state"]
reward_unlocks: ["Paladin", "Mercy Between Blows", "Burden Shared", "Shared Ember", "No One Alone"]
required_locations: ["Mercy Hospital", "Paupers' Cloister", "Outer Winter Camps", "Tann Gate Casualty Lane"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-finale
companion_campaign_stage: act-2
quest_owner: "Bernard Valeon"
quest_sequence: 6
companion_id: "CMP-05"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: confrontation
estimated_hours: 2.25
gameplay_pillars: [rescue, defense, social-conflict, boss, choice]
required_states: ["bernard_act1_chapter_resolved", "bernard_act2_readiness_viable", "winter_strands_open"]
optional_state_inputs: ["bernard_long_table_network", "bernard_breach_casualty_lane_secured", "bernard_mercy_heat_plan", "bernard_long_watch_kit_provenance", "bernard_open_store_procedure_practiced", "bernard_accountability_plan", "mika_food_state", "western_breach_state"]
field_experience_gate: []
companion_required: "Bernard Valeon"
duo_quest: true
pause_points: ["Relief Inventory Witnessed", "Field Infirmary Reached"]
relationship_gate: "No relationship required; commitment requires Trusted approval and personal completion"
relationship_variant: ""
preparation_inputs: ["bernard_long_table_network", "bernard_breach_casualty_lane_secured", "bernard_mercy_heat_plan", "bernard_long_watch_kit_provenance", "bernard_open_store_procedure_practiced"]
preparation_threshold: "2 of 5"
autonomous_deadline: "Ghor at the Gate"
autonomous_resolution: "Bernard saves the patients and genuinely kindles White Flame, but admits a withheld salve only afterward; Petra's authenticated response follows the restitution record and the player unlocks nothing."
changed_reentry: "Ashes in the Storebook"
ensemble_inputs: ["Ylva Winter-Track", "Ilyana Veshkar", "Zafir ibn Samad"]
identity_hooks: ["Military", "Peasant/Labour", "Mystic/Religious", "Merchant/Craft"]
encounter_deck: []
persistence_scope: regional-milestone
postgame_season: ""
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
archetype_pressure: "Bernard can save an infirmary and still owe the truth; neither courage nor laughter may hurry the account."
emotional_function: "Let local carers know and love Bernard before he declares a frighteningly useful reserve under attack."
pleasure_beat: "Bernard turns grim casualty drills into memorable names, bad songs, and a team that can move without him."
care_beat: "He spends what is needed now, stays with the most frightened patients, and accepts a remote judgement he cannot charm."
player_archetype_hooks: ["Cheerleader", "Tomboy", "Goth", "Bohemian", "Jock", "Nerd", "Rebel", "Goofball", "Grey"]
---
# Embers Without Excuse

## Premise

Grenzburg carers stage a relief run to an isolated Tann Gate field infirmary. The supplies include a declared emergency reserve and an authenticated Froststep settlement packet delivered by [[Claims-Factor Marco Bellandi]].

Bernard must carry both. The packet gives him no reunion and no scene in which to win forgiveness. It records what [[Petra Ilev]], [[Matej Solin]], and [[Hospice-Mother Radena Vosk]] have chosen to say from Kedrava. The relief run gives him present work among people who already know him well enough to laugh with him and judge him.

White Flame may kindle during the defence. It proves only that courageous, coherent service occurred.

## Party and Staging

The quest begins at [[Cathedral Close#Anchor Locations|Mercy Hospital]] when any two Act II assets are held. Accepting the warned departure forms the fixed player-plus-Bernard duo. Sister Hanne Wolkert, local carers, patients, and rescued soldiers are temporary quest actors outside the companion limit.

The warning states:

- the infirmary may require evacuation;
- the reserve may be needed before its planned destination;
- the Grobi know the casualty lane;
- autonomous resolution permanently closes the player Paladin unlock and Bernard's relationship paths.

## Preparation

| Asset | Use |
|---|---|
| `bernard_long_table_network` | supplies known cooks, porters, shelter signals, and receiving rooms |
| `bernard_breach_casualty_lane_secured` | opens a route through damaged Lantern Ward |
| `bernard_mercy_heat_plan` | preserves one deep-cold ward during evacuation |
| `bernard_long_watch_kit_provenance` | establishes exactly what Bernard owns, borrows, and owes |
| `bernard_open_store_procedure_practiced` | makes purpose, quantity, and release condition visible before departure |

Two permit the mission. Three make every patient, route, and store objective achievable. Four or five protect one material objective from a single failure.

## The Remote Packet

Bellandi opens the packet before Bernard, the player, Brina, and Sister Hanne.

- Matej supplies the certified Froststep inquiry and confirms that Bernard's dismissal was fair.
- Radena writes that the hospice has enough blankets and asks Bernard to stop repaying childhood shelter by trying to possess every future need.
- Petra does not address Bernard personally. Her standing instruction selects one of three outcomes from the actual restitution record: accept without reconciliation, redirect her share to winter-road care, or close contact.

The player may ask Bellandi to verify seals, beneficiaries, or payment. No dialogue option contacts Petra, interprets silence as consent, or treats the packet as the emotional climax.

## Beginning: A Count Made Aloud

The duo and local carers count four relief units:

1. warming oil and braziers;
2. bandages, needles, and cleaning spirits;
3. broth concentrate and salt;
4. blankets and warming salve.

Bernard tries to lighten the procedure with names for each bundle. The joke works until Hanne asks whether he has anything else.

He does: one packet of salve and two lamp-oil flasks retained after the Long Table fire. Their existence is useful. Their status depends on whether he reported them earlier.

- **Declared:** they enter the count before departure.
- **Hesitated:** he names them after Hanne asks.
- **Discovered:** the player or Zafir's prior assist exposes the weight.
- **Concealed:** Bernard keeps them until a later search.

No choice destroys the mission. It changes trust and direction.

### Pause Point: Relief Inventory Witnessed

The quest may pause after the load, route, and witnesses are fixed.

## Middle: The Casualty Lane

The duo chooses one of three complete routes:

- the prepared Lantern breach lane, fast but exposed;
- the Paupers' Cloister service route, crowded and structurally damaged;
- the outer camp trench, slow but useful for rescuing stranded carriers.

On the way, two events force present-tense care:

1. a cart overturns beneath probing arrows, trapping a carer and scattering one relief unit;
2. smoke drives walking wounded into the route while an immobile patient remains behind.

Bernard is excellent here. He remembers names, gives frightened people ridiculous jobs they can complete, and uses his body as a shield. The player sees why people love him before the reserve decision returns.

Every vocation can protect, carry, repair, scout, suppress, or reroute. Vocation advantages change cost and speed, never access.

## The Infirmary

The building has three failing systems:

- stove and smoke draw;
- treatment room and rear shelter;
- east door and casualty lane.

The player and Bernard may stabilize two immediately. Preparation can preserve all three.

Sister Hanne asks to open the warming oil and salve now. Bernard begins, “If the next room is worse...” and stops. The player can answer firmly, gently, practically, or not at all. Bernard must speak the actual release.

His strongest line is not eloquent:

> “Open it. Write that I was afraid. Open it anyway.”

## Assault and White Flame

Vek One-Ear's Grobi file attacks to seize medicine and prisoners for Ghor's host. Vek has no connection to Froststep.

The fight moves through:

1. a yard defence while carers move the walking wounded;
2. a smoke-filled treatment room;
3. a breach where Bernard must choose between pursuing Vek and holding an evacuation corridor.

At maximum pressure, Bernard offers the Last Ember over the living:

> “I am not a priest. I can pray, and I can stay.”

If his present conduct remains coherent, White Flame catches along the brazier and his plated side. It steadies panic, holds smoke back, and briefly protects the evacuation. It does not heal Petra, replenish stores, or answer the legal claim.

## End: A Record That Does Not Love Him

Back at Mercy Hospital, Bernard gives the local carers a complete account of the reserve and signs Bellandi's transmission.

Petra's existing instruction determines the response:

- `accepted-no-reconciliation`;
- `redirected-to-road-care`;
- `contact-closed`.

Bernard may be hurt, relieved, or both. He may not use the White Flame as an appeal. The player can remain, refuse intimacy, offer friendship, or open the eligible romance or bond commitment after the work is complete.

## Failure and Re-entry

- Lost supplies cause a ward evacuation and future scarcity, not mission collapse.
- A failed route rescue injures a named carer and removes one finale safeguard.
- Defeat lets local teams recover the duo after the Grobi take one unit and wound patients.
- Concealment discovered after the fight moves Bernard toward `withholding` even if everybody survives.
- Missing the quest opens **Ashes in the Storebook**, which permits later restitution but not Paladin or relationship unlocks.

## Outputs and Rewards

Record the mission, reserve, patient, Petra-response, direction, and relationship states in frontmatter.

Personal ethical completion unlocks [[Paladin]] for the current campaign and account, improves **Mercy Between Blows** and **Burden Shared**, and opens **Shared Ember** or **No One Alone** after eligible commitment.

## Navigation

- [[Bernard Companion Campaign]]
- [[Bernard Valeon]]
- [[The Long Winter Table]]
- [[The Froststep Evacuation]]
- [[Petra Ilev]]
- [[Claims-Factor Marco Bellandi]]
- [[The Open Hospice]]
- [[Paladin]]
- [[Narrative State Register]]
