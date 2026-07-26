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
tags: [narrative-rewrite]
quest_class: companion
act: act-2
availability_window: ["Deep Winter", "Early Spring"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["bernard_act2_chapter_resolved", "bernard_act2_result", "bernard_act2_finale_played", "bernard_direction", "bernard_paladin_unlocked", "bernard_relationship_commitment", "bernard_relationship_paths_closed", "bernard_white_flame_kindling", "petra_ilev_response", "long_watch_return_open", "lantern_relief_mission_state"]
reward_unlocks: ["Paladin", "Mercy Between Blows", "Burden Shared", "Shared Ember", "No One Alone"]
required_locations: ["Mercy Hospital", "Paupers' Cloister", "West Refuge Hall", "Outer Winter Camps", "Tann Gate Casualty Lane"]
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
story_gate: reckoning
estimated_hours: 2.25
gameplay_pillars: [investigation, relief-logistics, rescue, defence, social-reckoning]
required_states: ["bernard_act1_chapter_resolved", "bernard_act2_readiness_viable", "winter_siege_active"]
optional_state_inputs: ["bernard_four_fires_plan", "bernard_breach_casualty_lane_secured", "bernard_mercy_heat_plan", "bernard_long_watch_kit_provenance", "bernard_open_store_procedure_practiced", "bernard_accountability_plan", "mika_food_state", "church_rank", "blackjack_rank", "city_in_siege_result", "lantern_ward_condition"]
field_experience_gate: []
companion_required: "Bernard Valeon"
duo_quest: true
pause_points: ["Relief Inventory Witnessed", "Field Infirmary Reached"]
relationship_gate: "No relationship required; commitment requires Trusted approval and personal completion"
preparation_inputs: ["bernard_four_fires_plan", "bernard_breach_casualty_lane_secured", "bernard_mercy_heat_plan", "bernard_long_watch_kit_provenance", "bernard_open_store_procedure_practiced"]
preparation_threshold: "2 of 5"
autonomous_deadline: "Ghor at the Gate"
autonomous_resolution: "Bernard saves the patients and genuinely kindles White Flame, but admits a withheld salve only afterward; Petra accepts restitution without forgiveness and the player unlocks nothing"
changed_reentry: "Embers After Snow"
ensemble_inputs: ["Ylva Winter-Track", "Ilyana Veshkar", "Zafir ibn Samad"]
identity_hooks: []
encounter_deck: []
persistence_scope: regional-milestone
postgame_season: ""
emotional_rewrite_status: preserve
dialogue_status: pending-rewrite
archetype_pressure: "Warmth becomes evasion: test whether Bernard can remain funny and loving while accepting specific judgement."
emotional_function: "Keep Petra, declared reserve, field service, and White Flame without acquittal"
pleasure_beat: "Food, absurdity, road stories, children laughing, and companionship without ceremony."
care_beat: "Bernard feeds, shelters, steadies, and tells the truth about what he takes or withholds."
player_archetype_hooks: []
---
# Embers Without Excuse

## Quest Function

Bernard's Act II finale returns the people and institution he harmed to the foreground. It is not a hunt for a hidden villain and does not reveal that his dismissal was corrupt. The [[Thalmyric Military Orders#Order of the Long Watch|Order of the Long Watch]] judged him fairly after [[The Froststep Evacuation]]. Its winter relief mission gives him an opportunity to tell the truth, work beside an injured survivor, and spend a needed reserve openly when concealment would be easier.

The White Flame answers during service. It confirms neither Bernard's innocence nor any entitlement to reinstatement.

The closed quest uses the player and Bernard only. [[Matej Solin]], [[Petra Ilev]], Long Watch carers, patients, and rescued soldiers are temporary NPCs outside the companion limit.

## Unlock and Staging

Once any two Act II assets in [[Bernard Companion Campaign]] are secured, the quest unlocks at [[Cathedral Close#Anchor Locations|Mercy Hospital]] while the winter siege is active. A Kedravan relief train has reached Grenzburg under Watch-Captain Matej Solin. Bernard recognizes its lamp pennants before he sees Petra Ilev driving the lead sled.

Matej asks Bernard to help carry a declared reserve to an isolated field infirmary near Tann Gate. He does not offer pardon, bargain for silence, or pretend that ordinary relief work is a trial designed around Bernard. Petra may refuse to speak to Bernard, but she continues the mission.

The tracked docket displays Viable, Prepared, or Strongly Prepared readiness. Accepting the departure warning dismisses the other active companions. It names the risk of Grobi attack, the patients who cannot move, and the possibility that the reserve will have to be spent before the party reaches its planned destination. It also states that allowing the chapter to resolve autonomously permanently forfeits the Paladin unlock, romance, sworn bond, and finale rewards for this playthrough.

## Preparation in Play

| Asset | Concrete advantage |
|---|---|
| `bernard_four_fires_plan` | supplies a tested shelter-consolidation and fuel-release plan |
| `bernard_breach_casualty_lane_secured` | opens a known route through damaged Lantern Ward |
| `bernard_mercy_heat_plan` | protects one hospital heat or evacuation objective |
| `bernard_long_watch_kit_provenance` | gives Matej a complete, honest account of Bernard's issued and owned equipment |
| `bernard_open_store_procedure_practiced` | establishes witnessed reserve purpose and release conditions before pressure begins |

Two assets permit the relief mission. Three make every principal patient, route, and store objective achievable through strong play. Four or five protect one objective from a single logistical failure without confessing for Bernard or forcing Petra's response.

## Principal Cast

- [[Bernard Valeon]]: wants to prove he can be trusted and must learn that proof is not the immediate task.
- [[Matej Solin]]: Bernard's former commander, fair in the original inquiry and unwilling to confuse mercy with exemption.
- [[Petra Ilev]]: relief driver whose frost-damaged hands are a permanent consequence of Bernard's concealed stores.
- **Sister Hanne Wolkert:** Eclessian field-infirmary keeper who needs supplies more urgently than institutional diplomacy.
- **Vek One-Ear:** Grobi file-leader directing a local assault against the casualty lane. He serves Ghor's war but knows nothing of Bernard.

## The Declared Reserve

The mission carries four sealed relief units, each witnessed by Matej, Petra, Bernard, and the player:

1. warming oil and braziers;
2. bandages, needles, and cleaning spirits;
3. concentrated broth and salt;
4. blankets and warming salve.

They are intended for two hospitals and the Tann Gate infirmary. Any unit may be opened early, redirected, lost, or delivered. The inventory remains visible throughout the quest. There is no hidden optimal stockpile that punishes the player for treating present patients.

## Pressure States

### Infirmary Heat: 3 to 0

- **3:** the stove, treatment table, and rear shelter remain usable.
- **2:** the walking wounded begin moving supplies and expose themselves to attack.
- **1:** frost and smoke threaten the immobile patients; one reserve unit is needed immediately.
- **0:** the building must be evacuated during combat. Patients remain rescuable, but injuries and district losses increase.

### Grobi Pressure: 0 to 4

Pressure rises through delay, alarms, lost routes, and failed defence positions. It determines enemy preparation and the safety of the return path, not whether the quest continues.

### Bernard's Reserve State

`declared`, `hesitated`, `concealed`, or `spent-openly` records whether Bernard names what remains and accepts witness when scarcity becomes frightening.

## Beginning: A Count Made Aloud

At Mercy Hospital the player checks the load, chooses the first route, and hears the facts of Froststep from Petra rather than only from Bernard. She describes numb hands, a saw waiting beside the stove, and Bernard's initial denial. She does not accuse him of deaths that did not occur.

Bernard may confess before the assembled carers, speak privately to Petra with a witness, or postpone the conversation until after delivery. The player cannot demand forgiveness or use a social check to make Petra accept contact.

Matej carries a short letter from [[Hospice-Mother Radena Vosk]]. It says the hospice has enough blankets this winter and asks Bernard to stop trying to repay childhood shelter by secretly possessing every future need. The letter is support, not absolution.

### Pause Point: Relief Inventory Witnessed

The quest may pause after the reserve is counted and a route selected. Resuming reforms the duo at Mercy Hospital with the recorded load intact.

## The Three Routes

All routes are viable for every vocation and provide different pressures:

### Casualty Lane

The direct route through Lantern Ward is shortest but exposed to Grobi skirmishers and frightened refugee traffic. Social authority can clear the lane; physical defence can hold it; careful escorting can preserve both people and supplies.

### Covered Walk

A Church service walk joins the Paupers' Cloister to the wall hospital. It is partially collapsed after [[The City in Siege]]. Ordinary climbing, bracing, and carrying work open it. Slayer gains an exposed shortcut, but no vocation is required.

### Drainage Causeway

The frozen riverworks offer concealment and unstable footing. Tracking or Underworld knowledge identifies safe ice; any character can test poles, ropes, and marked edges. A failed crossing loses time or one unprotected supply unit rather than ending the mission.

Each route contains evidence of a second Grobi group moving toward the field infirmary. The attack is a military opportunity, not a scheme aimed at Bernard.

## Middle: The Field Infirmary

The duo reaches a timber-and-canvas hospital holding twenty-three patients, including five who cannot walk. Its heating fuel was consumed during the breach, and its rear exit is blocked by a collapsed handcart.

Sister Hanne asks to open the warming oil and blankets immediately. Petra supports her. Bernard begins to argue that the supplies were counted for multiple sites, then catches himself. The player can help him name the fear, order the stores opened, or permit him to delay.

If the player delays, one patient deteriorates and Bernard privately moves a salve packet into his armour lining. The visible hand movement triggers the Compulsion System. Interrupting him creates `hesitated`; allowing concealment creates `concealed` and a later confrontation. The packet cannot vanish from the quest.

### Pause Point: Field Infirmary Reached

After the first unit is opened or withheld, the quest may pause. The patients remain stable at the recorded Heat state until the duo resumes at the infirmary.

## The Grobi Assault

Vek One-Ear attacks in three linked beats:

1. sling teams target the stove vent and treatment lanterns;
2. shield-runners force the casualty lane while cutters attack the rear canvas;
3. Vek leads a push for the medicine sled, intending to seize supplies for Ghor's wounded.

The player and Bernard can hold the infirmary, conduct a staged evacuation, or move the patients into the covered walk and counterattack. Environmental options include water barrels, canvas releases, cart braces, wall bells, and the declared reserve itself.

Every vocation can:

- free the blocked rear exit through ordinary interaction;
- carry or direct patients;
- defend one of the two attack faces;
- signal the wall post;
- help Bernard move the immobile patients.

Vocation advantages change speed, route, and enemy control. None gates survival.

## The White-Flame Moment

At the crisis point, a roof spar falls across the treatment area as smoke and fear break the evacuation line. Bernard places his issued sword down, loops the prayer rope around his left hand, and spends the remaining warming reserve without asking whether another hospital might later deserve it more.

He says the Last Ember prayer over the living and asks them to stand if they can. The White Flame kindles through the brazier and his plated side, holding smoke and panic away long enough for the player to clear the route. It stabilizes the wounded, restores courage, and briefly protects the evacuation. It does not heal Petra's hands, replace expended stores, or erase Bernard's culpability.

If Bernard concealed the salve, he must produce it before the kindling can hold. If the player encourages continued concealment, the rescue still proceeds through ordinary effort, but the miracle does not manifest and Paladin unlock waits until the post-battle confession.

## End: What Petra Is Owed

After Vek is killed, captured, or driven away, the mission returns to Mercy Hospital or the Paupers' Cloister according to damage. Bernard gives a complete account of Froststep and the present reserve before Matej, Petra, and the local carers.

Petra's response depends on Bernard's conduct and remains hers:

- **Forgives:** she sees sustained truth and freely chooses renewed personal contact.
- **Restitution accepted:** she accepts the work and record but does not forgive or resume friendship.
- **No further contact:** she acknowledges the confession and asks Bernard to stay away.
- **Condemns concealment:** renewed lying confirms that he remains unsafe with stores.

No Charisma, Diplomacy, or White-Flame display overrides her response.

Matej may open a future petition for Long Watch reinstatement. It is an available destination, not a reward granted now. Bernard must still finish his Grenzburg service and demonstrate accountable practice in [[The Open Hospice]].

## Relationship Commitment

After the public reckoning, a player at **Trusted** approval who personally completed this finale receives one of four scenes:

- **Romance, female player:** Bernard asks whether care can be accepted without becoming debt and whether the pair should pursue a romantic relationship. The freely given prayer-rope bead and private intimacy belong to [[Enough for Two]], not this commitment scene.
- **Sworn bond, male player:** Bernard asks whether the pair should pursue an exceptional platonic brotherhood grounded in truth, return, and service. The sworn-brother rite belongs to [[Watch Until Morning]], not this commitment scene.
- **Continued friendship:** the player declines commitment without approval loss.
- **Refusal:** a major unresolved violation or low approval leaves the relationship professional.

Romance and bond commit after this scene. Their initial duo moves are defined in [[Bernard Field Familiarity and Relationships]]. Romance is upgraded by [[Enough for Two]]; sworn bond is upgraded by [[Watch Until Morning]]. Friendship remains capable of reaching Bernard's strongest moral resolution.

## Information Redundancy

- The infirmary threat is revealed by route tracks, wall signals, wounded runners, and captured skirmish equipment.
- Froststep is established through Bernard, Petra, Matej's inquiry copy, and Radena's letter.
- The reserve count exists on seals, sled marks, Petra's slate, and the player's visible quest state.
- Every evacuation route is identified by Sister Hanne, wall diagrams, local signs, or direct exploration.

## Fail-Forward Results

- A lost reserve unit worsens Infirmary Heat but another route or local substitute remains.
- If Vek captures the sled, the duo can retake it, trade distance for patients, or complete the evacuation without it.
- If the infirmary burns, all surviving patients move to the cloister and `lantern_relief_mission_state` records the loss.
- If the duo is defeated, Matej's rear detail recovers them after the Grobi take supplies and wound patients.
- If Bernard conceals an item on a player-completed route, the physical Paladin form and account unlock still complete, but its White-Flame techniques begin dimmed until a named confession-and-repair scene before [[The Open Hospice]].
- If the seasonal cutoff passes before commitment, the mission resolves through Bernard's autonomous route. Its spring aftermath cannot restore the missed player unlocks.

## Outputs

- `bernard_act2_chapter_resolved`: played, autonomous, or aftermath;
- `bernard_act2_result`: accountable, costly, compromised, or broken;
- `bernard_act2_finale_played`: true or false;
- `bernard_direction`: truthful, uncertain, or withholding;
- `bernard_paladin_unlocked`: field-kindled, confession-kindled, or physical-form-sacred-dimmed;
- `bernard_relationship_commitment`: romance-committed, bond-committed, friendship, refused, or unavailable;
- `bernard_relationship_paths_closed`: open or missed-act-2;
- `bernard_white_flame_kindling`: field-infirmary, post-confession, absent, or distorted-by-rumour;
- `petra_ilev_response`: forgives, restitution-only, no-contact, or condemns-concealment;
- `long_watch_return_open`: open, deferred, or closed;
- `lantern_relief_mission_state`: complete, depleted, displaced, or failed-forward.

## Companion and Faction Reactivity

- Zafir respects the witnessed inventory but rejects Bernard's claim that mercy can be more exact than terms.
- Ashira asks whether an unmeasurable gift can be trusted; Bernard answers that its fruits can still be judged.
- The Church may report the kindling, but cannot certify Bernard innocent or take custody of his vocation.
- Brina uses the transparent reserve as a model for debtor-company stores.
- Koss attempts to frame the expended stock as negligence if his Blackjack line remains predatory.

## Rewards and Unlocks

- personal completion unlocks the player [[Paladin]] vocation for the current playthrough and the account; unresolved concealment leaves its sacred techniques visibly dimmed until repair;
- unlocks Bernard's improved **Mercy Between Blows** and **Burden Shared**;
- unlocks the committed relationship duo move when applicable;
- opens Long Watch, Open Lamp, and travelling future paths;
- establishes a visible White-Flame response without changing legal responsibility.

Autonomous completion grants none of these player progression rewards.

## Autonomous Resolution and Embers After Snow

If the player commits to [[Ghor at the Gate]] without joining this finale, Bernard undertakes the relief mission using the preparation already secured. On the default route he saves the field-infirmary patients and genuinely kindles White Flame through courageous service, then admits that he withheld one salve packet:

- Petra accepts restitution but does not forgive or resume friendship;
- the mission finishes depleted or displaced;
- Bernard remains `uncertain`;
- the player does not unlock Paladin;
- romance and sworn bond close permanently for the playthrough.

Truthful influence and strong preparation can improve the patient, reserve, and mission states without restoring the missed player unlocks. Withholding and poor preparation can cause serious injuries, prevent kindling, and trigger a warned departure conflict. Bernard cannot die autonomously.

The spring aftermath **Embers After Snow** permits confession, store repair, and restored personal sacred coherence. It cannot unlock Paladin, romance, sworn bond, **Shared Ember**, **No One Alone**, or any missed finale reward.

## Navigation

- [[Bernard Valeon]]
- [[Bernard Companion Campaign]]
- [[The Froststep Evacuation]]
- [[Matej Solin]]
- [[Petra Ilev]]
- [[Hospice-Mother Radena Vosk]]
- [[Bernard Field Familiarity and Relationships]]
- [[Bernard Long Watch Greatsword Package]]
- [[Bernard Compulsion and Accountability System]]
- [[Four Fires]]
- [[Enough for Two]]
- [[Watch Until Morning]]
- [[The Open Hospice]]
- [[Companion Field Familiarity and Duo Quest Standard]]
- [[Narrative State Register]]
- [[Companions MOC]]
