---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Old Market", "Ledger Quays"]
culture: ["Eclessian", "Virelian"]
related_factions: ["Blackjack Corps", "Medori Bank"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-3
availability_window: ["Spring Reclamation"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["elara_coalition_ready", "velescar_instruction_state", "coalition_delegate_state", "elara_spokesperson_state"]
reward_unlocks: ["The Last Claim preparation"]
required_locations: ["Iron Ledger Counting-House", "Hall of Petitions", "Old Market", "Ledger Quays"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-operation
companion_campaign_stage: act-3
quest_owner: "Elara Velescar"
quest_sequence: 8
companion_id: "CMP-01"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: preparation
relationship_variant: ""
preparation_inputs: []
preparation_threshold: ""
encounter_deck: []
postgame_season: ""
estimated_hours: 1
gameplay_pillars: [diplomacy, escort, defense, social, investigation]
required_states: ["elara_act2_resolution"]
optional_state_inputs: ["elara_bellandi_escrow_access", "winter_company_roster_state", "four_hearth_compact_form", "underworld_branch_low_lantern"]
companion_required: "Elara Velescar"
duo_quest: false
pause_points: ["Instructions Authenticated", "Delegates Assembled"]
autonomous_deadline: "The Deep Muster Main Quest"
autonomous_resolution: "Elara protects the hearing but edits incompatible instructions into a settlement she can lead."
changed_reentry: "No Lady of Velescar begins with fewer enforceable household terms."
ensemble_inputs: ["Ashira bath Melan", "Bernard Valeon", "Dismas Raben", "Ilyana Veshkar", "Tavio Meran", "Zafir ibn Samad", "Ylva Winter-Track"]
identity_hooks: ["Peasant/Labour", "Nobility", "Merchant/Craft", "Scholarly", "Underworld"]
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
archetype_pressure: "Elara must create a room in which absent and local claimants retain their own words, even when their demands resist her elegant synthesis."
emotional_function: "Make shared social power playable through protection, translation, and restraint."
pleasure_beat: "Building an unlikely coalition that becomes capable of outmaneuvering paid agents."
care_beat: "Elara protects delegates' right to speak badly, privately, or not through her."
player_archetype_hooks: ["Cheerleader", "Tomboy", "Goth", "Bohemian", "Jock", "Nerd", "Rebel", "Goofball", "Grey"]
persistence_scope: regional-persistent
---
# The Hands That Hold It

## Premise

[[Claims-Factor Marco Bellandi]] receives authenticated instructions from Velescar's sixty-three households. They do not speak with one voice.

Some demand individual title to worked land. Some want a cooperative holding. Some want burial goods returned before any land settlement. Several refuse Elara's money. Others explicitly require it. None appoints her their spokesperson.

Local people must make those remote terms enforceable before the Old Tithe Vault is opened. Vardek's Grenzburg agents plan to substitute a clean “household consent” copy and abduct three local delegates who can challenge it.

## Cast

- **Mira Spoke:** Grenzburg carter and daughter of a Virelian emigrant household, chosen to present transport and remittance terms;
- **Olek Sar:** burial conservator holding an authenticated custody instruction;
- **Hanne Wirth:** cooperative organizer who refuses noble sponsorship;
- [[Claims-Factor Marco Bellandi]]: authenticates but does not merge instructions;
- [[Elara Velescar]]: has the access and social force to protect the coalition, but no right to own it.

None is a returning figure from Elara's former life.

## Beginning: The Unedited Packet

At the Iron Ledger Counting-House, Bellandi lays out three bundles:

1. authenticated household instructions;
2. Vardek's polished consolidation;
3. a damaged courier copy proving local interference.

Elara reads the Vardek version aloud beautifully. Hanne asks her to read the households' contradictions with the same patience.

The player must:

- authenticate seals, route marks, or testimony;
- choose whether originals remain with Bellandi, divided custodians, or public escrow;
- notify the three local delegates without exposing their routes.

Every vocation can contribute through ordinary navigation, protection, observation, or social preparation.

## Middle: Three Hands

The operation opens three tasks in any order:

### The carter

Mira's wagon is boxed in at Old Market by a staged debt seizure. The party can expose the false writ, pull the wagon through a service lane, rally market witnesses, or physically break the encirclement without killing clerks.

### The conservator

Olek's workshop is entered from the roof while somebody creates a loud disturbance below. The party protects fragile burial records during a vertical fight and identifies which tubes may legally travel.

### The organizer

Hanne refuses Elara's escort after Elara announces it publicly. The player can establish a discreet route, let Low Lanterns provide cover, or create a visible decoy while Hanne travels independently.

Failure does not erase a delegate. It wounds, delays, exposes, or changes how their instruction reaches the hearing.

## The Substitution Attempt

At Hall of Petitions, local agents trigger a fire alarm and swap one packet while hired abductors move through the emptying galleries.

The sequence combines:

- identifying the false packet;
- choosing which delegate the active party protects;
- directing the coalition's own prepared defenders;
- a pursuit through petition stacks and public stairs;
- preserving unedited instructions under water and ash.

Elara's instinct is to summarize the confusion in one persuasive address. If she does, she can win the room while flattening the terms. If she gives each delegate their authority, the hearing is slower, untidier, and harder for Vardek's agents to own.

## End: The Coalition Speaks

The final scene is not a vote on Elara's redemption. It determines whether the coalition exists independently:

- **ready:** all three delegates and remote terms remain materially capable of action;
- **functional:** one term is represented through authenticated proxy;
- **curated:** Elara's synthesis wins but she retains agenda control;
- **broken:** agents divide custody and the finale begins as a recovery race.

Bellandi records only what is legally established. When Elara asks what he thinks she ought to do, he answers:

> “That question is not in my portfolio.”

## Fail-Forward

- A stolen packet reappears in the Old Tithe Vault as leverage.
- An abducted delegate leaves route evidence and remains rescuable in the Act III finale.
- Public violence reduces hearing legitimacy but creates witnesses.
- Destroyed originals can be proved through divided copies at the cost of one settlement option.
- If the player withdraws, Elara saves the visible hearing and edits the least compatible terms.

## Archetype Chemistry

- Cheerleader/Jock can hold a public room and must yield the centre afterward.
- Tomboy/Rebel defend delegates against ceremony but may underestimate procedural protection.
- Goth/Nerd preserve contradiction and risk treating living speakers as texts.
- Bohemian/Goofball create decoys and unexpected alliances, with trust dependent on follow-through.
- Grey receives a complete practical route based on divided custody and named escorts.

## Outputs and Rewards

- `elara_coalition_ready`: ready, functional, curated, or broken;
- `velescar_instruction_state`: original, divided-copy, substituted, or partly lost;
- `coalition_delegate_state`: individual state for Mira, Olek, and Hanne;
- `elara_spokesperson_state`: supporting, shared, controlling, or disavowed;
- possible `elara_direction` movement;
- Act III asset `elara_coalition_ready`;
- preparation toward **The Last Claim**.

## Navigation

- [[Elara Companion Campaign]]
- [[Claims-Factor Marco Bellandi]]
- [[No Lady of Velescar]]
- [[Crown Heights#Anchor Locations|Hall of Petitions]]
- [[The Hands That Hold It]]
