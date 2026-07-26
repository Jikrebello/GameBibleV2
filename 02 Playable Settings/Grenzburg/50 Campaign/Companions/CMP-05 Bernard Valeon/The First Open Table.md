---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg"]
culture: ["Thalmyric", "Kedravan", "Eclessian", "Chapel-Folk"]
related_factions: ["Blackjack Corps", "Order of the Long Watch", "Church of Grenzburg"]
appears_in: ["Grenzburg"]
needs: []
tags: [narrative-rewrite]
quest_class: companion
act: summer
availability_window: ["Playable Summer"]
repeatability: one-shot
cutoff_result: remains-available
world_state_outputs: ["bernard_summer_coda", "first_open_table_state"]
reward_unlocks: ["Bernard summer destination scene"]
required_locations: ["Blackjack Yard", "Open Lamp Hospice", "West Refuge Hall"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: summer-coda
companion_campaign_stage: summer
quest_owner: "Bernard Valeon"
quest_sequence: 10
companion_id: "CMP-05"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: summer-aftermath
estimated_hours: 0.5
gameplay_pillars: [conversation, reflection]
required_states: ["companion_summer_codas_unlocked"]
optional_state_inputs: ["bernard_arc_outcome", "bernard_sacrifice_state", "bernard_future_path", "open_lamp_hospice_state", "bernard_summer_destination", "bernard_owned_sword_state", "bernard_owned_greatsword_name", "petra_ilev_response", "bernard_relationship_commitment", "bernard_romance_episode", "bernard_bond_episode", "private_feast_state", "cairnside_shelter_state"]
field_experience_gate: []
companion_required: ""
duo_quest: false
pause_points: []
relationship_gate: ""
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: ""
autonomous_resolution: ""
changed_reentry: "The coda reflects the fixed Act III outcome and cannot reopen it"
ensemble_inputs: []
identity_hooks: []
encounter_deck: []
persistence_scope: campaign-persistent
postgame_season: summer
emotional_rewrite_status: preserve
dialogue_status: pending-rewrite
archetype_pressure: "Warmth becomes evasion: test whether Bernard can remain funny and loving while accepting specific judgement."
emotional_function: "Keep ordinary hospitality as the final demonstration of accountability"
pleasure_beat: "Food, absurdity, road stories, children laughing, and companionship without ceremony."
care_beat: "Bernard feeds, shelters, steadies, and tells the truth about what he takes or withholds."
player_archetype_hooks: []
---
# The First Open Table

## Quest Function

This is Bernard's summer coda. It demonstrates the care practice, destination, relationship, and sword state already established by the campaign. It creates no new moral test and cannot repair or worsen his final outcome.

The coda uses the ordinary party when Bernard remains available. If he departed or `bernard_sacrifice_state` is `chosen`, it becomes a changed encounter with the people carrying his work.

## Shared Premise

A first postwar meal is served beside an open patient and store board. Every version includes:

- food offered without a new debt;
- named store custodians or an honest acknowledgement that they were never established;
- people from more than one wartime group;
- a visible place for Bernard's prayer rope, sword, or absence;
- no claim that White Flame erased Froststep.

## Destination Variants

### Open Lamp

At [[Open Lamp Hospice]], Bernard admits the first ordinary summer patients and sits at the table while other carers serve one course. A resolved hospice uses mixed staff and bounded sponsor roles. A compromised hospice displays the institution controlling its stores.

### Long Watch

The meal becomes a departure supper before Bernard joins a Long Watch road company. Matej receives a complete field inventory. Petra appears only if her established response permits it.

### Travelling Hospitaller

Bernard and a committed female romantic partner prepare a declared road kit while named staff assume the hospice or Yard service. The scene does not imply that romance abandoned existing patients.

### Blackjack Infirmary

This is the default autonomous destination. Brina holds the store keys and Bernard performs real care within her open procedure. He can name that arrangement as useful and incomplete.

### Continued Service

Bernard remains an ordinary Blackjack companion. The table is a company meal and casualty review rather than a new institution.

### Broken or Departed

Bernard's place is empty. Brina, Hannel, Oda, or a surviving carer explains what was preserved and what Bernard refused to repair. The player cannot summon him back through the coda.

### Sacrificed

The table includes the people saved by his explicit final stand. The prayer rope and sword are handled according to the final scene. Memorial dialogue records both his service and his culpability without posthumous absolution.

## Open Hand

If Bernard completed [[The Open Hospice]] with a resolved outcome and owns the gifted sword, he names it **Open Hand** during the coda or the preceding final scene.

The name describes a weapon used to keep shelter open and a hand no longer closed around hidden provision. It does not turn the blade into a relic. Every other outcome leaves the sword unnamed without undoing the gift.

## Relationship Variants

- A romance completed through [[Enough for Two]] reflects the private feast, freely given bead, **Kept in the Light**, and **Shared Ember: Warmth Returned** where earned. A committed romance that missed the episode remains real but does not invent those memories or rewards in summer.
- A sworn bond completed through [[Watch Until Morning]] reflects Cairnside Shelter, the service cords left on its beam, **Last Watch**, and **No One Alone: Two Bearers** where earned. A committed bond that missed the episode remains real but does not retroactively perform the sworn-brother rite.
- Friendship receives the complete destination, sword, and accountability scenes.
- Missed relationship content is not recreated in summer.

## Outcome Record

- `bernard_summer_coda`: complete, changed-encounter, memorial, or missed;
- `first_open_table_state`: open-lamp, long-watch, travelling, Blackjack, company, absent, or memorial;

## Vocation and Access

No player vocation, faction rank, romance, or cultural identity gates the coda. Origin and background knowledge change food, prayer, and road-story dialogue only.

## Navigation

- [[Bernard Companion Campaign]]
- [[Bernard Valeon]]
- [[The Open Hospice]]
- [[Enough for Two]]
- [[Watch Until Morning]]
- [[Bernard Field Familiarity and Relationships]]
- [[Open Lamp Hospice]]
- [[Blackjack Yard]]
- [[Companions MOC]]
