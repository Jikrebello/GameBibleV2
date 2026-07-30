---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Hammer Ward", "Lantern Ward"]
culture: ["Vortharan", "Sestaran", "Eclessian"]
related_factions: ["Blackjack Corps", "Medori Bank", "Red Brass Bench"]
appears_in: ["Grenzburg"]
needs: []
tags: [narrative-rewrite]
quest_class: companion
act: act-1
availability_window: ["Early Autumn", "Open Autumn"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["tavio_campaign_tracked", "tavio_fifth_ring_evidence", "tavio_cheating_admitted", "tavio_direction", "tavio_insert_state", "koss_fifth_ring_interest", "hella_dorn_trust"]
reward_unlocks: ["Proof Reader", "Visible Overproof Warning"]
required_locations: ["Blackjack Yard", "Great Forge", "Hammer Ward", "Muster Green"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: introduction
companion_campaign_stage: introduction
quest_owner: "Tavio Meran"
quest_sequence: 1
companion_id: "CMP-07"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: introduction
estimated_hours: 1.0
gameplay_pillars: [investigation, equipment-proof, social-reckoning, controlled-combat]
required_states: ["tavio_recruited"]
optional_state_inputs: ["hammer_ward_access", "warlock_hall_access", "blackjack_reform_state"]
field_experience_gate: ["one meaningful outing with Tavio"]
companion_required: "Tavio Meran"
duo_quest: false
pause_points: ["Fifth Ring Secured", "Control Proof Filed"]
relationship_gate: ""
relationship_variant: ""
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "The Last Convoy"
autonomous_resolution: "Hella secures the ring after Koss attempts to requisition it; Tavio admits only an equipment violation and begins Act I managed"
changed_reentry: "The Cracked Batch"
ensemble_inputs: ["Ilyana Veshkar", "Ylva Winter-Track", "Zafir ibn Samad"]
identity_hooks: ["Sestaran", "Vortharan", "Military", "Merchant/Craft", "Scholarly", "Warlock"]
encounter_deck: []
persistence_scope: regional-milestone
postgame_season: ""
emotional_rewrite_status: preserve
dialogue_status: pending-rewrite
archetype_pressure: "Competition becomes worth: test whether Tavio can stop, lose, or need help without surrendering athletic joy."
emotional_function: "Keep the Fifth Ring, Tavio's knowledge, unsafe hardware, and public first crack in the champion story"
pleasure_beat: "Competition, crowds, food, physical effort, ridiculous prizes, and celebrating improvement."
care_beat: "Tavio trains beside people, celebrates their effort, and calls a halt before glory spends their bodies."
player_archetype_hooks: []
---
# The False Ring

## Quest Function

Tavio's introduction establishes the Fifth Ring as physical evidence, names his knowing use of it, introduces [[Proof-Mistress Hella Dorn]], and activates the campaign's proof, stop-authority, and accountability language.

This is a normal-party case. Tavio must be present, but other companions remain available.

## Trigger

After one meaningful outing, a routine equipment return at the [[Blackjack Yard]] makes Tavio's proof gauntlet ring when no relation is loaded. Quartermaster Brina halts the issue line and sends the gauntlet to the Great Forge.

[[Captain Valdemar Koss]] wants the hidden capacity tested for military use. Tavio claims the old insert must have remained inside the gauntlet after his championship.

Hella recognizes a deliberate concealed housing. She cannot yet prove when Tavio knew about it.

## Beginning: Inventory Before Spectacle

The party secures:

- Tavio's gauntlet;
- three filed championship proof rings;
- the concealed Fifth Ring;
- the Blackjack intake sheet;
- a damaged strip of red arena lining;
- Koss's provisional requisition.

The player may:

- place the ring under Hella's independent custody;
- allow Koss a bounded observation role;
- involve Warlock Hall;
- ask Brina to hold it as debtor equipment;
- destroy its live capacity after recording the physical evidence.

Koss cannot simply steal it if the player loses a social check. A failed objection gives him an official test position and raises pressure later.

## Middle: Four Tests and One Lie

Hella stages four non-lethal tests in Hammer Ward:

1. **Housing measure:** the insert fits only a gauntlet modified before the championship.
2. **Maker scar:** the cut matches Seraf Pellan's proof-broker stamp.
3. **Heat memory:** the ring carried a full fourth relation during the Lio bout.
4. **Control demonstration:** three legal marks can be loaded, Broken, Braced, and Yielded without using the insert.

During the control demonstration — three legal marks, loaded, Broken, Braced, Yielded — an observant player can notice Tavio's right hand at the top of the third load. Not a fumble; a fine tremor, there and gone.

He laughs it off before anyone else looks: cold hands, old glove, the Grenzburg damp, a joke about Vortharan winters being a rumour. It is the Lovable Captain register doing exactly what it is for, and it works.

*(Tremor beat 1 of 4. Narrative only; see [[Tavio Lancewright Package]].)*

Then an old strain line in the test frame fails. The party must:

- clear apprentices;
- catch or vent the directional force;
- stop a swinging proof weight;
- prevent Koss's observers from loading the Fifth Ring.

Every starting vocation has an answer through guarding, mobility, ranged intervention, Warlock counter-script, or Medium distraction.

## Information Routes

The truth has redundant sources:

- maker scar and invoice sequence;
- heat memory in the metal;
- the gauntlet's pre-bout modification;
- footage or written bout cadence;
- Tavio's old seconding card;
- a folded Red Brass instruction beneath the lining.

**And one more, which is not about the ring.** The bout cadence — on the seconding card, in the written exchange rhythm, in any surviving bill — shows **Lio ahead when the discharge came.** Two exchanges up, on Tavio's own count, in his own hand.

Nobody in the scene remarks on it. Hella has no professional interest in it and Koss cannot sell it. It sits in the evidence, discoverable, months before Tavio ever says out loud why he did it. A player who notices has the motive before the confession; a player who does not gets it in Act II and should feel the earlier page turn over in their memory.

Sestaran or Merchant/Craft knowledge identifies the endorsement form. Military or Warlock knowledge identifies why a fourth load endangers everyone sharing the field. Insight catches Tavio describing the ring's behaviour too precisely for someone who forgot it.

## Reckoning

Tavio first admits he knew the insert existed. Pressed further, he admits he knew it exceeded the filed proof and chose to use it.

The player may:

- insist on a complete statement;
- accept a witnessed private admission pending protected evidence;
- allow a partial public statement while preserving the full record;
- encourage concealment;
- let Koss classify the ring as military property.

The player cannot make Tavio innocent. The meaningful question is whether his first act in Grenzburg protects the truth, the Bench, or the dangerous device.

## End

The Fifth Ring may be:

- preserved inert as evidence;
- preserved live under Hella's custody;
- destroyed after full documentation;
- requisitioned by Koss;
- retained disabled by Tavio under a named custodian.

Any result can continue the campaign. Preserved physical evidence supplies `tavio_fifth_ring_evidence`; destruction requires strong documentation to supply the same preparation asset.

## Fail-Forward

- Test-frame failure: apprentices are injured or equipment is lost, but the fracture exposes the fourth-load architecture.
- Koss gains custody: the player may recover the ring through the Blackjack line; copies of the measure remain.
- Tavio lies: Hella's test still establishes the hardware, and his direction begins managed or overproof.
- Evidence is damaged: maker scar, heat memory, and old filings provide alternate routes.
- Party defeat during containment: forge crews clear the room and Hella files a harsher restriction.

## Rewards

- **Proof Reader:** Tavio calls out visibly unsafe fittings.
- visible overproof warning in Tavio's companion interface;
- Act I preparation asset `tavio_fifth_ring_evidence`;
- access to [[The Signed Measure]];
- tracked [[Tavio Companion Campaign]].

## Navigation

- [[Tavio Companion Campaign]]
- [[Tavio Meran]]
- [[Lancewright]]
- [[Proof-Mistress Hella Dorn]]
- [[Red Brass Bench]]
- [[The Signed Measure]]
