---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Longlake Ward", "Longlake Country"]
culture: ["Folk", "Chapel-Folk", "Thalmyric"]
related_factions: ["Bent Oak", "Lakewatch fishers", "Order of the Long Watch"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-1
availability_window: ["Open Autumn", "Early Winter"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["bernard_act1_chapter_resolved", "bernard_act1_result", "bernard_direction", "road_school_state", "chapel_children_state", "mika_food_state", "wounded_bear_state", "bent_oak_refuge_state"]
reward_unlocks: ["Shelter at My Back", "Long Watch rescue augment"]
required_locations: ["Bent Oak Chapel", "Lake Road Cairn", "Reedmile Chapel", "Pikehook Marsh", "Bent-Oak Refuge"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-finale
companion_campaign_stage: act-1
quest_owner: "Bernard Valeon"
quest_sequence: 3
companion_id: "CMP-05"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: operation
estimated_hours: 1.75
gameplay_pillars: [exploration, conversation, reconnaissance, rescue, survival]
required_states: ["bernard_introduction_complete", "bernard_act1_readiness_viable"]
optional_state_inputs: ["bernard_road_school_wagon_recovered", "bernard_longlake_route_secured", "bernard_service_injury_claim_supported", "bernard_pikehook_snare_line_mapped", "bernard_hunger_named_early", "chapel_folk_trust", "folk_rank_admitted", "longlake_passage_rule"]
field_experience_gate: []
companion_required: "Bernard Valeon"
duo_quest: true
pause_points: ["Reedmile Lesson Complete", "Children Sheltered"]
relationship_gate: "No relationship required; no unresolved departure conflict"
relationship_variant: ""
preparation_inputs: ["bernard_road_school_wagon_recovered", "bernard_longlake_route_secured", "bernard_service_injury_claim_supported", "bernard_pikehook_snare_line_mapped", "bernard_hunger_named_early"]
preparation_threshold: "2 of 5"
autonomous_deadline: "The Last Convoy"
autonomous_resolution: "See Companion Autonomy and Act Convergence; untracked content uses stable-colleague treatment."
changed_reentry: "The Road Afterward"
ensemble_inputs: ["Dismas Raben", "Ylva Winter-Track"]
identity_hooks: []
grounded_rewrite_status: approved
external_stakes: ["returned property", "road-school safety", "winter shelter access", "patient survival"]
banter_priority: essential
player_interest_gate: none
missed_arc_treatment: changed-reentry
encounter_deck: []
persistence_scope: regional-milestone
postgame_season: ""
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
archetype_pressure: "Warmth becomes evasion: test whether Bernard can remain funny and loving while accepting specific judgement."
emotional_function: "Keep Mika, the children, wounded bear, and Bernard's unforced heroism"
pleasure_beat: "Food, absurdity, road stories, children laughing, and companionship without ceremony."
care_beat: "Bernard feeds, shelters, steadies, and tells the truth about what he takes or withholds."
player_archetype_hooks: []
---
# Little Hands, Long Road

## Quest Function

Bernard's Act I finale is a warm Chapel-Folk road-school journey interrupted by an ordinary wounded bear. It lets the player see him teach, joke, cook, and become a hero to children without revealing a conspiracy or escalating into metaphysical lore.

The full party is the player and Bernard. [[Oda Reed-Way]] and seven children travel as temporary NPCs outside the companion limit. Grouped movement, teaching stops, and shelter behavior prevent the quest from becoming seven fragile escort routines.

## Unlock and Staging

Once any two Act I assets in [[Bernard Companion Campaign]] are secured, Oda invites Bernard to help lead an autumn road-school trip from Bent Oak Chapel in [[Longlake Ward]] to [[Bent-Oak Refuge]]. Bernard asks the player to come because the children need two adults who can carry, climb, and respond if the road changes.

The tracked docket displays Viable, Prepared, or Strongly Prepared readiness. Accepting at Bent Oak Chapel dismisses the other active companions. The departure warning names the route, expected weather, the presence of children, and the transformed Early Winter conditions.

## Preparation in Play

| Asset | Concrete advantage |
|---|---|
| `bernard_road_school_wagon_recovered` | restores full packs, the refuge bell, and a sound fallback wagon |
| `bernard_longlake_route_secured` | provides alerted road households and a reliable alternate crossing |
| `bernard_service_injury_claim_supported` | gives families confidence that an injury will not become concealed debt |
| `bernard_pikehook_snare_line_mapped` | reveals the bear's likely route and a safe child-withdrawal line |
| `bernard_hunger_named_early` | lets Bernard recognize his own food anxiety before Mika's count |

Two assets permit the expedition. Three make every principal material objective achievable through strong play. Four or five provide one safeguard against injury, lost stores, or failed withdrawal without deciding Bernard's truthfulness.

## The Seven Children

The group is individually countable, but three children own major beats:

- **Mika Reed-Kin, eleven:** hides two food portions for a younger foster sibling left in the city;
- **Ansel Pike, twelve:** reads tracks well and initially treats knowledge as control;
- **Tova Ash-Bent, nine:** curious, slow on steep ground, and physically saved by Bernard during the bear crisis.

The other four supply questions, songs, paired tasks, and injury or trust states without carrying mandatory clues.

## Journey Purpose

The children are learning:

- how to read refuge marks and route bells;
- what one night's shelter promises and what it does not;
- how to count food without publicly shaming hunger;
- how to identify flood, ice, and animal sign;
- why Chapel-Folk prayer does not erase Folk ancestry or local road custom;
- how to leave an accurate message for the next traveller.

No faction uses the trip to recruit the children or stage propaganda.

## Vocation Access

Every player vocation can lead the grouped journey, read redundant danger signs, shelter the children, and resolve the bear encounter. Vocation tools provide safer preparation or faster reactions without becoming mandatory rescue keys.

## Pressure States

### Group Readiness: 3 to 0

Readiness falls through ignored cold, rushed lessons, separated pairs, lost packs, or failed first aid.

- **3:** children move in pairs and repeat instructions accurately.
- **2:** one child tires or loses equipment; Oda shortens a lesson.
- **1:** the group reaches the bear sequence scattered or frightened.
- **0:** Oda shelters the main group early while Bernard and the player conduct the final rescue under worse conditions.

Readiness affects injury and available bear solutions, never whether a child dies off-screen.

### Bear Stress: 0 to 3

The bear is an ordinary adult injured by a spring snare left from illegal hunting.

- **0:** distant sign; it avoids the group.
- **1:** pain and food scent draw it toward the road.
- **2:** noise, pursuit, or crowding makes it charge defensively.
- **3:** the bear reaches the shelter yard and must be driven off or killed before treatment is possible.

## Beginning: Bent Oak Chapel

The children divide food, route bells, chalk, bandages, and lesson boards. The player may inspect the count, help assign pairs, or let Oda handle logistics. Every starting vocation receives a useful but optional preparation:

- Fighter or a high-Strength character can carry shelter braces;
- Slayer can inspect roof and path anchors;
- Hunter can prepare animal-sign lessons;
- Warlock can demonstrate safe non-combat warmth under supervision;
- Medium can distinguish an animal track from projected fear without manifesting human imprints;
- any vocation can carry supplies, learn the route, and complete every later solution.

Bernard teaches a deliberately bad marching song to make the children call out the correct refuge rules between verses.

## Middle: The Lake Road Cairn

At the cairn, the children practice leaving a route message. Ansel finds a broad bear print and correctly identifies weight, direction, and an uneven rear step. He incorrectly concludes that knowledge makes the animal safe to follow.

The player may reinforce caution, dismiss the sign, or inspect further. Broken brush, blood on a root, and old iron scent independently reveal injury. Missing all three advances Bear Stress but does not remove later warnings.

## The Count, and What Is In Bernard's Pack

**Bernard carries an undeclared portion. In every route, played or autonomous.** He put it in his own pack at Bent Oak before anyone was watching, out of the same reflex that filled a bakehouse floor — bread and a twist of salt, for later, in case. The taking precedes the player's agency; the concealment does not.

If `bernard_hunger_named_early` was earned in **The Spare Blanket**, he names it at the Lake Road Cairn count. It is a small, real shame in front of children, the count comes right, and the cost is nonzero and survivable — **and Mika watches an adult say it out loud.** This is the moment that asset was always trying to buy.

If it was not earned, the midday count is wrong *because of him*, and nobody knows it. The shelter decision — push past Reedmile or wait out the weather — gets made on bad numbers. The group moves late into the marsh; the separation happens at a worse place on the road; a child goes hungry a night that nobody planned for. **The Froststep chain in miniature: the paper was consistent with itself.**

## Mika's Hidden Food

At the midday count, two more portions are missing, and this time it is not him.

Bernard notices Mika's stiff pocket and asks Oda for a private interval rather than naming the child before the group. Mika has hidden the food for a younger foster sibling who believes the school trip receives better meals.

**The mirror can distort.** Which version of this scene the player gets depends on what is in Bernard's own pack:

- **He declared at the cairn.** Mika may self-report before anyone asks — she has seen it done, once, by an adult, and it did not destroy him. If she does, the scene is about a household food solution rather than a confession.
- **He is still carrying his.** He has to handle a child's concealment while concealing his own, and the quest forks on whether he says *mine first* — one sentence, in front of Oda and a child, at real cost — or manages Mika honestly-but-hypocritically, which works, and which the player can see working.

The player may support private truth and a separate household food request; a returned portion with Oda authorizing the other as a declared gift; public discipline; or concealment and a false count.

Bernard favors privacy joined to an actual food solution. He does not tell Mika that taking is harmless, and he does not reveal his full history to make the child comfort him.

The best response preserves Mika's dignity, restores the count, and sends a named portion home through ordinary refuge stores. It cannot be reached while Bernard is lying about his own pack.

## Reedmile Chapel

At Reedmile Chapel the group learns the difference between a road reader, a priest, and a household elder. Bernard is asked to demonstrate the Last Ember prayers and says plainly that he is not ordained. He offers a prayer for safe travel without turning it into a sacrament or performance.

The children find a snapped route bell and a second patch of blood. Repairing the bell, leaving an alternate warning, or notifying the refuge all reduce later risk.

### Pause Point: Reedmile Lesson Complete

The quest may pause before entering the marsh-road section. The group waits safely at the chapel and no pressure advances during unrelated play.

## Pikehook Marsh

The road skirts [[Grenzburg Worldspace Location Register#Longlake Country|Pikehook Marsh]]. The injured bear has raided a discarded food wrap and become entangled again in the dragging snare chain.

The player and Bernard can:

- take the raised road and use bells or noise to move the group away;
- track the chain and mark a wide bypass;
- prepare fire, barriers, or thrown food to redirect the bear;
- approach the snare only after sheltering the children;
- kill the bear if it charges and no safer protection remains.

Every approach receives visible breath, blood, chain noise, disturbed reeds, and the bear's escape line as concrete information.

## The Separation

A rotten side rail collapses under Tova as the bear reaches the road. Bernard crosses the attack line, takes the child's weight against his plated side, and braces the greatsword between Tova and the animal. This is his fixed hero beat; it does not require White Flame or a particular player vocation.

The player controls the wider resolution:

- drive the bear off through noise, fire, space, and an open retreat route;
- kill it in direct defence;
- shelter the children, restrain the animal at distance, cut the snare, and withdraw;
- lose control of the yard, causing injuries and forcing Oda to seal the refuge doors while the duo recovers the scattered group.

Freeing the bear before securing the children is reckless and can worsen injuries. Killing it to protect the group is not treated as moral failure. Unnecessarily tormenting it or using children as bait creates a major conflict.

### Pause Point: Children Sheltered

Once all seven are inside Bent-Oak Refuge, the player may pause before dealing with the wounded animal or damaged stores outside.

## End: The Refuge Supper

Every child survives. Poor outcomes may produce bites, sprains, fear, lost packs, or lasting distrust, but no child dies through an off-screen timer or failed dialogue check.

At supper:

- Tova retells Bernard's rescue with increasing physical impossibility;
- Ansel admits that correct tracks did not make him responsible for the bear;
- Mika's household food solution is either recorded, concealed, or refused;
- Oda assesses whether the road school should continue;
- Bernard accepts thanks without calling danger proof that he is good.

**And the count is reconciled at the table, out loud, by Oda.** If Bernard concealed his portion, this is where it lands: the shortfall traced back to the pack in front of seven children who trusted the number, one of whom went hungry for a night because of it, and one of whom is Mika. He is not shouted at. Oda simply reads the corrected count and does not look at him, and Tova asks why they were short, and somebody has to answer her.

The confession, if it comes here, costs more than any other version in the campaign — because the audience is children, the stake was a night's food, and the object was the size of a fist.

If the bear survives, local hunters monitor it and remove the abandoned snare line. If it dies, useful meat and hide are accounted under refuge custom without turning the animal into a trophy monster.

## Information Redundancy

- Bear injury appears through track, blood, chain sound, broken brush, and Reedmile warning.
- Mika's reason appears through the hidden portions, foster roll, sibling message, or private admission.
- The safe shelter route is known through Oda's map, route bells, cairn marks, or lake-road knowledge.
- Every separated child is located through partner count, voice, tracks, or fixed shelter behavior.

## Fail-Forward Results

- Low readiness increases injuries and reduces available nonlethal time.
- A broken road bell makes the winter route less safe until repaired later.
- Lost food reduces Bent-Oak Refuge's opening winter reserve but does not starve the children.
- If the bear escapes while injured, hunters establish a bounded follow-up rather than respawning the quest.
- If the duo is downed, Oda gets the main group behind the refuge wall while Bernard's fixed interposition preserves Tova; injuries and bear state worsen.

## Outputs

- `bernard_act1_chapter_resolved`: played, autonomous, or aftermath;
- `bernard_act1_result`: protected, costly, compromised, or broken;
- `bernard_direction`: truthful, uncertain, or withholding;
- `road_school_state`: continued, restricted, suspended, or celebrated;
- `chapel_children_state`: safe, lightly-injured, seriously-injured, or frightened;
- `mika_food_state`: supported-openly, returned-with-help, publicly-shamed, or concealed;
- `wounded_bear_state`: driven-off, freed, killed-in-defence, escaped-injured, or tormented;
- `bent_oak_refuge_state`: prepared, depleted, damaged, or distrusting.

## Relationship Movement

The quest lets Bernard be admired without making admiration absolution. Protecting Mika from shame while restoring truth supports **Trusted** approval. Concealing the food or humiliating the child creates a named disagreement.

Completion opens [[A Blade Freely Given]]. **The Child's Portion** now concludes that friendship episode and is available regardless of romance interest.

## Seasonal Transformation

In Early Winter the group travels by sled over the established lake road. The bear remains active because pain and the dragging snare prevented denning. Snow makes signs clearer but shelter timing harsher. The same choices and outcomes remain available.

## Rewards and Unlocks

- Bernard gains the improved **Shelter at My Back** interposition;
- the Long Watch rescue augment enters the custom-part library;
- Bent-Oak Refuge becomes a stable rest and dialogue site according to outcome;
- Chapel-Folk road-school and child summer scenes unlock;
- qualitative approval and the friendship episode.

## Autonomous Resolution and The Road Afterward

If the player commits to [[The Last Convoy]] without joining this finale, Bernard travels with Oda using the preparation already secured. On the default route he carries an undeclared food reserve and delays naming the danger:

- all seven children survive with avoidable minor injuries;
- the bear reaches the shelter line and is killed in necessary defence;
- the road school continues under winter restriction;
- Bernard admits the reserve after the crisis and remains `uncertain`.

Truthful influence and at least three assets can produce an autonomous morally successful rescue with permanent supply or wagon loss. Poor preparation or withholding can cause a serious nonfatal injury and suspend the school. Bernard cannot die and no child dies unseen.

The winter aftermath **The Road Afterward** permits compensation, bell repair, removal of the remaining snare line, and a later admission. It cannot reverse injuries, restore the bear, replay the journey, or grant the missed progression rewards.

## Navigation

- [[Bernard Valeon]]
- [[Bernard Companion Campaign]]
- [[Oda Reed-Way]]
- [[Bent-Oak Refuge]]
- [[Bernard Field Familiarity and Relationships]]
- [[Bernard Long Watch Greatsword Package]]
- [[Predators and Oversized Fauna]]
- [[A Blade Freely Given]]
- [[Companion Field Familiarity and Duo Quest Standard]]
- [[Companions MOC]]
