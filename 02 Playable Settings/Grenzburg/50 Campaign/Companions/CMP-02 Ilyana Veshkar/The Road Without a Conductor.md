---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Grenz Lowlands"]
culture: ["Sermoran"]
related_factions: ["Blackjack Corps", "The Salt-Reed Company"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-1
availability_window: ["Open Autumn", "Late Autumn"]
repeatability: one-shot
cutoff_result: resolves-offscreen
world_state_outputs: ["ilyana_celia_safe", "celia_orsani_state", "celia_viol_state", "reed_cart_state", "lowlands_bandit_state", "ilyana_direction"]
reward_unlocks: ["Repairing Line", "instrument field repair"]
required_locations: ["Blackjack Yard", "Three Mills Reach", "Lowland Reed Road", "Abandoned Drying Barn"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: operation
companion_campaign_stage: act-1
quest_owner: "Ilyana Veshkar"
quest_sequence: 2
companion_id: "CMP-02"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: preparation
estimated_hours: 0.75
gameplay_pillars: [tracking, rescue, skirmish, escort, social]
required_states: ["ilyana_introduction_complete"]
optional_state_inputs: ["three_mills_state", "roads_worth_saving_result", "ilyana_cases_secured", "dismas_recruited", "hunter_training"]
field_experience_gate: []
companion_required: "Ilyana Veshkar"
duo_quest: false
pause_points: ["Celia Located"]
relationship_gate: ""
relationship_variant: ""
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "The Last Convoy"
autonomous_resolution: "Celia reaches Grenzburg injured while her viol and repair chest remain with the bandits"
changed_reentry: "The property may be recovered from an altered winter road camp but does not restore the Act I asset"
ensemble_inputs: ["Dismas Raben", "Bernard Valeon", "Elara Velescar"]
identity_hooks: ["Sermoran", "Wilderness", "Merchant/Craft", "Drifter/Vagabond"]
encounter_deck: ["Grenz Lowlands Autumn Road"]
persistence_scope: regional-persistent
postgame_season: ""
---
# The Road Without a Conductor

## Quest Function

This Act I operation brings [[Celia Orsani]] into the playable world and tests whether Ilyana can organize a rescue without treating Celia as a subordinate upon recovery.

## Hook

A damaged reed-cart reaches [[Three Mills Reach]] carrying one of Celia's instrument strings and a note addressed to Customs Hall. Human road bandits attacked the cart, took Celia, her viol, and her repair chest, then moved toward an abandoned drying barn.

The bandits do not serve Morante, the Folk, or Ghor. They saw valuable foreign instruments and a traveller without protection.

## Beginning: What the Cart Shows

Evidence includes:

- blood on the driver's side but none in the passenger well;
- a cut harness and deliberately dropped tuning pegs;
- wheel marks leaving the main road;
- Celia's repair cipher on three fence posts;
- a surviving carter at Three Mills.

No failed check loses the trail. Checks reveal speed, numbers, hostage condition, and shortcuts.

Ilyana immediately begins assigning pursuit roles. The player may accept the plan, ask the party, or require her to name which parts are requests. Her response contributes to direction without delaying rescue.

## Middle: The Drying Barn

Celia is alive and treating the wounded carter who was captured with her. The bandits have not recognized the viol's harmonic function but are trying to open its resonant housing.

Approaches:

- follow Celia's peg trail to the rear loft;
- negotiate an exchange using ordinary goods or false valuation;
- cut the horse line and isolate the road patrol;
- enter through the drying vents;
- attack the front while another party member reaches the captives.

Celia refuses Ilyana's first whispered instruction to play a mending line during the escape. She has a hand injury and does not consent to perform under Ilyana's command.

The rescue remains fully possible through:

- ordinary medicine;
- carrying the injured;
- opening a cart route;
- fighting a controlled withdrawal;
- recovering repair supplies.

If her refusal is respected, Celia may independently choose to play after reaching cover. That choice is hers and provides a bonus, not the only success route.

### Pause Point

After Celia and the carter reach the rear yard, the quest may pause before pursuit or property recovery.

## End: Property or Pursuit

The bandit leader flees with the viol while a second group overturns the reed-cart to block the road. The party chooses priorities:

- protect Celia and the injured carter;
- recover the viol;
- recover the repair chest;
- capture the leader.

Strong preparation and ordinary party coordination can achieve all objectives. Losing one changes later instrument and antagonist states.

## Choices

- Respect Celia's refusal and build another plan.
- Pressure her through danger, friendship, or claim of necessity.
- Return her instrument immediately.
- Hold it as evidence or "for safety" against her wishes.
- Let her decide whether to speak with Ilyana at the Yard.

Celia cannot be persuaded to forgive in this quest.

## Fail-Forward

- Celia is always recoverable, but may arrive injured or Strained.
- A lost viol appears in [[Reeds Under Ice]] or an altered bandit camp.
- A lost repair chest makes one Act I finale mechanism harder.
- An escaped leader reinforces the Eel Bridge bandits for payment, without becoming a universal mastermind.
- Party defeat causes Three Mills road workers to drive off the bandits after property is lost.

## Rewards

- `ilyana_celia_safe` when Celia reaches Grenzburg with her agency protected.
- **Repairing Line:** Ilyana can stabilize one damaged friendly instrument, signal device, or light mechanism during field interaction.
- Act I preparation for [[No Song by Command]].

## Navigation

- [[Ilyana Companion Campaign]]
- [[Celia Orsani]]
- [[Three Mills Reach]]
- [[No Song by Command]]

