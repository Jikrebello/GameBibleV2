---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Ledger Quays", "Tannward", "Longlake Ward"]
culture: ["Sermoran", "Eclessian", "Folk"]
related_factions: ["Blackjack Corps", "Church of Grenzburg"]
appears_in: ["Grenzburg"]
needs: []
tags: [companion-campaign]
quest_class: companion
act: act-3
availability_window: ["Open Spring", "Muster Crisis"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["ilyana_field_cases_state", "ilyana_distributed_score_state", "longlake_signal_case_state", "mercy_signal_case_state", "tannward_signal_case_state", "hammer_signal_case_state", "blackjack_signal_case_state"]
reward_unlocks: ["Distributed Score", "independent field ensembles"]
required_locations: ["Blackjack Yard", "Customs Hall", "Tannward", "Ferry Yard", "Bridge Vaults"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-operation
companion_campaign_stage: act-3
quest_owner: "Ilyana Veshkar"
quest_sequence: 8
companion_id: "CMP-02"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: preparation
estimated_hours: 0.75
gameplay_pillars: [escort, defence, field-testing, traversal, delegation]
required_states: ["ilyana_act2_chapter_resolved", "open_spring"]
optional_state_inputs: ["ilyana_winter_signal_code", "winter_casualty_refrain_state", "ledger_quays_condition", "tannward_condition", "longlake_ward_condition"]
field_experience_gate: []
companion_required: "Ilyana Veshkar"
duo_quest: false
pause_points: ["Five Cases Assigned"]
relationship_gate: ""
relationship_variant: ""
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "The Deep Muster"
autonomous_resolution: "See Companion Autonomy and Act Convergence; untracked content uses stable-colleague treatment."
changed_reentry: "Surviving district crews build rough replacements; the missed operation does not replay after the dead march."
ensemble_inputs: ["Zafir ibn Samad", "Elara Velescar", "Ashira bath Melan"]
identity_hooks: ["Sermoran", "Folk", "Scholarly", "Merchant/Craft", "Military", "Peasant/Labour"]
grounded_rewrite_status: approved
external_stakes: ["five district evacuation teams", "portable signal equipment", "civilian routes during the dead march", "a score usable after its author leaves"]
banter_priority: contextual
player_interest_gate: none
missed_arc_treatment: changed-reentry
encounter_deck: ["Grenzburg Spring Dead-March Signs"]
persistence_scope: city-persistent
postgame_season: ""
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
archetype_pressure: "Ilyana must release an unfinished work to people who will alter it and receive credit for what they add."
emotional_function: "Replace archive escort with a living civic project that can continue without Ilyana at its centre."
pleasure_beat: "Five crews play their incompatible versions at once, producing one terrible minute followed by a surprisingly strong common close."
care_beat: "Ilyana leaves her best spare mouthpiece in the least prestigious district case without announcing the gift."
player_archetype_hooks: []
---
# Every Case Its Owner

## Quest Function

This Act III normal-party operation distributes five portable signal cases before the dead march reaches Grenzburg's northern routes. Each case belongs to the crew that will carry, repair, revise, and use it.

The quest is not an archive hearing. It asks whether a useful creative work can survive its founder's absence.

## The Five Cases

Ilyana has built a modular field score from winter experience. The physical cases contain reeds, bells, chalk, signal cloth, simple tuning plates, repair tools, and one district-specific part.

| Case | Crew | Priority |
|---|---|---|
| Longlake | ferrymen and Chapel-Folk road callers | crossing and withdrawal |
| Mercy | litter teams and carers | casualty pace and route closure |
| Tannward | wall runners and engineers | breach and fire warnings |
| Hammer | vent crews and forge hands | heat, gas, and structural danger |
| Blackjack | mobile recovery teams | rally, search, and extraction |

The crews helped write their parts. Ilyana still calls the whole composition hers in casual speech.

## Hook

The first disciplined residue movements enter the city underways while the five cases are due for field delivery. Old cargo marks draw residue toward the Bridge Vaults, and ordinary thieves believe the brass tuning plates can be sold as warlock metal.

Neither threat knows or cares about Ilyana's personal history.

## Beginning: Release the Draft

Each crew requests one final change:

- Longlake wants fewer notes that carry badly over water;
- Mercy wants authority to stop all music around unstable patients;
- Tannward wants the fire call separated from the breach call;
- Hammer wants a visual confirmation for deafened workers;
- the Blackjacks want a phrase that any frightened recruit can remember.

Ilyana can publish the current version, delay for perfection, or let each crew amend its own case. The player can test calls from obstructed positions and identify genuine technical conflicts. No social statistic determines authorship.

### Pause Point: Five Cases Assigned

The quest may pause once custody, routes, and revision authority are recorded.

## Middle: Five Deliveries, Three Routes

The normal party cannot personally carry all five cases. It chooses two direct deliveries and prepares three independent routes.

Approaches include:

- public streets with wall protection;
- the bonded warehouse passage;
- Bridge Vault service routes;
- a Low Lantern handoff;
- boat and ferry transfer.

During the operation:

- residue follows an old portage mark toward whichever case takes the vault route;
- thieves attempt one brass-plate seizure;
- a frightened courier deviates from the plan for a valid reason;
- one district crew changes its call before Ilyana can approve it.

Zafir can test release authority, Elara can identify substituted containers, and Ashira can read residue behavior. None becomes the project's owner.

## End: The Work Continues Elsewhere

At the final delivery, a Muster alarm forces all five crews to answer from different parts of the city. Ilyana hears revisions she did not write and cannot reach three of the teams.

The common close succeeds if custody and safety phrases were clear, even if the performance is untidy. A centralized score sounds cleaner but can fail when Ilyana is interrupted.

Ilyana can:

- credit each crew and publish a shared technical core;
- retain her name as principal composer while granting field revision rights;
- demand approval for every future alteration;
- reclaim cases whose versions no longer please her.

The quest ends on work, not a speech. The Hammer crew asks for a replacement strap and the Mercy team is already using its case.

## Fail-Forward

- A lost case produces a rough local replacement and weakens one finale asset.
- Stolen tuning plates create a later black-market encounter.
- A harmed courier survives but one district route begins late.
- Residue entering the wrong underpass causes local damage without changing its non-conscious nature.
- Party defeat saves the crews while two cases and their authored refinements are lost.

## Rewards

- `ilyana_field_cases_state`: distributed, centralized, incomplete, or reclaimed.
- **Distributed Score:** optional local counter-lines can continue after Ilyana is silenced or displaced.
- `ilyana_common_score_partitioned` is retained as a compatibility state and now means that the common technical core and local contributions are separately credited.
- Act III preparation for [[The Last Common Measure]].

## Navigation

- [[Ilyana Companion Campaign]]
- [[The Free Refrain]]
- [[The Last Common Measure]]
- [[Grenzburg City Anchor Register#Cross-City Anchors|River Boom Towers]]
- [[Grenzburg City Districts Overview|Grenzburg City]]
