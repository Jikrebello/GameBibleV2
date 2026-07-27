---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Longlake Ward"]
culture: ["Eclessian", "Chapel-Folk", "Thalmyric", "Folk"]
related_factions: ["Blackjack Corps", "Church of Grenzburg", "Duchy of Grenzburg", "Four-Hearth Compact"]
appears_in: ["Grenzburg"]
needs: []
tags: [narrative-rewrite]
quest_class: companion
act: act-3
availability_window: ["Early Spring", "Open Spring", "Muster Crisis"]
repeatability: one-shot
cutoff_result: resolves-offscreen
world_state_outputs: ["bernard_west_refuge_neutral_claim", "west_refuge_hall_state", "west_refuge_sponsor_terms", "first_patient_groups_state", "west_refuge_rank_tablet_state"]
reward_unlocks: ["Neutral Hall Claim", "West Refuge preparation"]
required_locations: ["West Refuge Hall", "Longlake Ward", "Grenzburg Underways"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-operation
companion_campaign_stage: act-3
quest_owner: "Bernard Valeon"
quest_sequence: 8
companion_id: "CMP-05"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: preparation
estimated_hours: 0.75
gameplay_pillars: [social, exploration, protection, environmental-puzzle]
required_states: ["bernard_act2_chapter_resolved", "unending_muster_active"]
optional_state_inputs: ["church_resolution", "blackjack_resolution", "folk_compact_state", "lantern_ward_condition", "underways_route_access"]
field_experience_gate: []
companion_required: "Bernard Valeon"
duo_quest: false
pause_points: ["Temporary Use Declared"]
relationship_gate: ""
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "The Deep Muster"
autonomous_resolution: "West Refuge becomes a narrow sponsor ward; the neutral-claim asset is lost"
changed_reentry: "The sponsor arrangement persists into The Open Hospice and cannot be renegotiated inside the finale"
ensemble_inputs: ["Zafir ibn Samad", "Ylva Winter-Track", "Ilyana Veshkar"]
identity_hooks: []
encounter_deck: []
persistence_scope: district-persistent
postgame_season: ""
emotional_rewrite_status: reframe
dialogue_status: pending-rewrite
archetype_pressure: "Warmth becomes evasion: test whether Bernard can remain funny and loving while accepting specific judgement."
emotional_function: "Keep neutral refuge stakes; replace procedural sponsorship emphasis with people Bernard knows, jokes with, and must defend without hiding stores"
pleasure_beat: "Food, absurdity, road stories, children laughing, and companionship without ceremony."
care_beat: "Bernard feeds, shelters, steadies, and tells the truth about what he takes or withholds."
player_archetype_hooks: []
---
# Beds Before Banners

## Quest Function

This is Bernard's short Act III operation. It secures the right and physical capacity to use West Refuge Hall for mixed patients before [[The Open Hospice]] begins.

Four groups possess legitimate but incomplete claims. The problem is not solved by discovering that three are fraudulent:

- the Duke needs an overflow casualty station;
- the Church needs beds beyond Mercy Hospital;
- Chapel-Folk households retain refuge use;
- the Blackjacks need space for debtors and dependants displaced by the dead march.

The player must create bounded shared use without making one institution owner of care.

## Hook

Bernard finds all four groups hanging their sign or banner on the same hall. A Qianglong rank tablet recovered from a recent residue patrol has also begun activating command patterns beneath the floor.

The hall requires:

- a temporary use agreement;
- one safe water line;
- two marked exits;
- removal or severance of the rank tablet;
- a first admission test involving actual patients.

## Operation States

### Hall Integrity: 0-3

Integrity improves through roof bracing, cistern clearance, and rear-door access. A low state does not close the hall but reduces safe capacity.

### Sponsor Reach

Each sponsor may be `bounded`, `preferred`, `controlling`, or `withdrawn`. Bounded support supplies a practical role without owning admission.

### Command Stirring: 0-3

Disturbing the undercroft, delaying after activation, or treating residue as persuadable increases the Muster response.

## Beginning: Four Signs on One Door

The normal field party hears each claim before work begins.

- The ducal sergeant offers shields and carpenters.
- A Church hospital steward offers medicines and clinicians.
- Chapel-Folk readers offer household carriers and refuge knowledge.
- Brina offers debtor labor, carts, and public store boards.

The player may accept help from all, some, or none. No faction rank is required to establish temporary emergency use under ordinary city authority.

### Pause Point: Temporary Use Declared

Once initial roles are stated, the operation may pause. Sponsors and hall conditions remain fixed until resumption.

## Middle: Make the Hall Usable

Three tasks may be tackled in any order:

### Water Below

Open the cistern through the public cellar or an underways inspection passage. The deeper passage may establish `bernard_underways_evacuation_route` if independently explored and marked.

### Two Ways Out

Clear the rear cart door and brace the gallery stair. Ordinary tools and labor suffice; vocation abilities offer speed and safer shortcuts.

### The Rank Tablet

The tablet is a non-conscious command mechanism calling residue toward an obsolete replacement station. It may be:

- physically removed after supports are secured;
- broken and its fragments separated;
- detuned through a warlock counter-script;
- isolated behind a collapsed service wall.

Dialogue, burial rites, and Binder authority cannot make it a consenting person.

## First Admission

Before the negotiation can remain theoretical, three arrivals reach the hall:

- two wounded marchers;
- a feverish debtor child and guardian;
- a guarded Folk prisoner injured during a road clash.

Security conditions differ. The admission rule remains need first, with custody handled separately. The player determines beds, guards, and sponsor duties without deciding that one patient class is morally disposable.

## End: The Neutral Claim

The strongest agreement grants temporary mixed-patient use through the Muster crisis:

- civil security remains ducal;
- sacraments and clinical service do not create Church ownership;
- Chapel-Folk shelter practice remains respected;
- Blackjack labor and carts create no new treatment debt;
- every sponsor term expires or returns for public review.

Sponsor-controlled and reduced agreements remain playable and materially useful.

## Vocation Access

Every player vocation can:

- clear the cistern and exits through ordinary interaction;
- defend patients and workers;
- disable the tablet through physical separation and environmental collapse;
- establish neutral use through evidence and emergency authority.

Technical, social, stealth, and cultural abilities change method and cost rather than access.

## Fail-Forward Results

- A failed sponsor negotiation creates preferred access instead of closing the hall.
- A lost water line requires carried water and lower capacity.
- An intact tablet strengthens the later assault.
- If residue enters during the operation, the first patients remain rescuable and the hall can reopen after damage.
- If the party is defeated, one sponsor secures the building and writes its own narrower terms.

## Outputs

- `bernard_west_refuge_neutral_claim`: true or false;
- `west_refuge_hall_state`: ready, reduced, damaged, or occupied;
- `west_refuge_sponsor_terms`: bounded, ducal, church, Blackjack, Folk-priority, or fractured;
- `first_patient_groups_state`: all-admitted, divided, displaced, or harmed;
- `west_refuge_rank_tablet_state`: severed, removed, isolated, or active.

## Autonomous Resolution

Without the player, Bernard accepts whichever sponsor can open the hall fastest. The ward saves people but gives that sponsor preferred admission and store control. The neutral claim is lost before the finale.

## Rewards

- the Act III preparation asset;
- a persistent West Refuge Hall state;
- practical support for the Open Hospice without determining its moral result.

## Navigation

- [[Bernard Companion Campaign]]
- [[Bernard Valeon]]
- [[The Open Hospice]]
- [[Longlake Ward#Anchor Locations|West Refuge Hall]]
- [[Grenzburg Underways]]
- [[Corpse Residue]]
- [[Atherian Ward and Trial Engines]]
- [[Companions MOC]]
