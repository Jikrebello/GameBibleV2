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
tags: [game-ready]
quest_class: companion
act: act-3
availability_window: ["Early Spring", "Open Spring", "Muster Crisis"]
repeatability: one-shot
cutoff_result: resolves-offscreen
world_state_outputs: ["bernard_west_refuge_neutral_claim", "west_refuge_hall_state", "west_refuge_sponsor_terms", "first_patient_groups_state", "bernard_drill_result"]
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
required_states: ["bernard_act2_chapter_resolved", "muster_known"]
optional_state_inputs: ["church_line_outcome", "blackjack_line_outcome", "four_hearth_compact_form", "lantern_ward_damage", "underways_route_access"]
field_experience_gate: []
companion_required: "Bernard Valeon"
duo_quest: false
pause_points: ["Temporary Use Declared"]
relationship_gate: ""
relationship_variant: ""
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "The Deep Muster"
autonomous_resolution: "See Companion Autonomy and Act Convergence; untracked content uses stable-colleague treatment."
changed_reentry: "The sponsor arrangement persists into The Open Hospice and cannot be renegotiated inside the finale"
ensemble_inputs: ["Zafir ibn Samad", "Ylva Winter-Track", "Ilyana Veshkar"]
identity_hooks: []
grounded_rewrite_status: approved
external_stakes: ["returned property", "road-school safety", "winter shelter access", "patient survival"]
banter_priority: contextual
player_interest_gate: none
missed_arc_treatment: changed-reentry
encounter_deck: []
persistence_scope: district-persistent
postgame_season: ""
emotional_rewrite_status: cleared
dialogue_status: approved
remote_claim_status: compliant
archetype_pressure: "Warmth becomes evasion: test whether Bernard can remain funny and loving while accepting specific judgement."
emotional_function: "Keep neutral refuge stakes; replace procedural sponsorship emphasis with people Bernard knows, jokes with, and must defend without hiding stores"
pleasure_beat: "Food, absurdity, road stories, children laughing, and companionship without ceremony."
care_beat: "Bernard feeds, shelters, steadies, and tells the truth about what he takes or withholds."
player_archetype_hooks: []
---
# Beds Before Banners

## Quest Function

This is Bernard's short Act III operation, and it is a **drill.** Before Mercy Hospital and the sponsors will back a mixed hospice, Brina and Sister Hanne require a demonstration: West Refuge Hall must run a full admission-and-care cycle **without Bernard touching it.**

Sister Hanne's terms, delivered without ceremony:

> “If you are the hospice, it dies the first week you are tired.”

The sponsors attend as observers. What the drill proves determines the roles they are given, which is how this piece still produces `bernard_west_refuge_neutral_claim` — the hall earns bounded shared use by demonstrating it can be run by more than one person.

Four groups hold legitimate but incomplete claims, and none is fraudulent:

- the Duke needs an overflow casualty station;
- the Church needs beds beyond Mercy Hospital;
- Chapel-Folk households retain refuge use;
- the Blackjacks need space for debtors and dependants displaced by the dead march.

The hall is not full of abstract constituencies. Bernard already knows everyone doing the work:

- **Hannel Klee** is assigning straw ticks and refuses to become “the girl Bernard once cleared”;
- **Neda Volk** is testing the rear door with an injured shoulder she has not reported;
- **Olof Reed-Kin** has brought two Chapel-Folk carriers Bernard fed during winter;
- **Sister Hanne Wolkert** has the patient list, the drill, and no patience for another sponsor's banner.

Their affection makes it harder, not easier. A room full of people who love him is the worst possible place to discover he is replaceable.

## Beat One: Sabotage by Helpfulness

Bernard does not refuse the drill. He undermines its premise, cheerfully, in a dozen small ways — and this is **feigned incompetence**, the Hidden Heavyweight's oldest exit, played warm enough that nobody but the player sees it:

- only he knows where the good kettle is, and he says so as a joke;
- the stove “only draws for me,” which is true, because he has never shown anyone the trick;
- his tally handwriting “can't be taught,” offered with a self-deprecating flourish;
- he cannot possibly explain the winter store-rotation, it's all in his head, he'd only confuse them.

The drill starts failing in Bernard-shaped holes. Every one of them is a place where he made himself the only door.

The player may name it privately, name it publicly, or let it run. Naming it publicly costs him standing in front of people who adore him; letting it run means the drill fails on its own, slower and worse.

## Beat Two: The Resentment

Mid-drill, benched, exhausted, watching other people do his work badly — a carer asks him a reasonable question about the flue for the third time.

**He snaps.** One flash of something that has never been allowed out: not cruelty, not rage, just the register of a man who is tired of being the one who carries, and who has never once been given permission to say so, least of all by himself.

It is unfair, it lands on somebody who did not deserve it, and there is no theft to return afterward.

The repair is harder than any confession in his campaign, because there is nothing funny available and nothing to give back. He has to apologize with no object in his hands. Whether he does — and whether he says the true reason or a charming one — moves `bernard_direction`.

## The Hall Requirements

The drill has to produce a working hall:

- a temporary use agreement;
- one safe water line;
- two marked exits;
- a first admission test involving actual patients.

## Operation States

### Hall Integrity: 0-3

Integrity improves through roof bracing, cistern clearance, and rear-door access. A low state does not close the hall but reduces safe capacity.

### Sponsor Reach

Each sponsor may be `bounded`, `preferred`, `controlling`, or `withdrawn`. Bounded support supplies a practical role without owning admission.

### Drill Integrity: 0-3

Integrity measures how much of the hall runs without Bernard. It falls when he takes a station back, when a Bernard-shaped hole stops the work, and when a sponsor is allowed to route a decision through him personally.

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

### Teach the Stove

The stove that "only draws for Bernard" has a trick: a damper sequence he worked out in his first winter and never wrote down. Somebody else has to be able to do it by tonight.

The task is teaching, and it is harder for him than lifting. He may demonstrate it once and let Hannel or a carer fail twice and get it; he may take the stove back "just for tonight"; or he may write the sequence on the wall beside it, which is the answer and takes him four minutes and costs him something he cannot name.

Dialogue, charm, and a good story about a hospice goose cannot substitute for the damper sequence.

## First Admission

Before the negotiation can remain theoretical, three arrivals reach the hall:

- two wounded marchers, one of whom carried the Long Table during the winter fire;
- Mika Reed-Kin with a feverish younger cousin and no intention of surrendering the child's food bag;
- a guarded Folk prisoner whom Olof recognizes as the person who once opened a winter track for refugees.

Security conditions differ. The admission rule remains need first, with custody handled separately. The player determines beds, guards, and sponsor duties without deciding that one patient class is morally disposable.

Bernard knows something human about every arrival. That knowledge may help him welcome them; it does not permit him to hide their property, alter custody, or promise a bed he has not counted.

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
- teach, brace, carry, or organize without the drill routing through one person;
- establish neutral use through evidence and emergency authority.

Technical, social, stealth, and cultural abilities change method and cost rather than access.

## Fail-Forward Results

- A failed sponsor negotiation creates preferred access instead of closing the hall.
- A lost water line requires carried water and lower capacity.
- A drill that only worked because Bernard stepped in leaves the hall dependent, and the finale opens with him already carrying it.
- If residue enters during the operation, the first patients remain rescuable and the hall can reopen after damage.
- If the party is defeated, one sponsor secures the building and writes its own narrower terms.

## Outputs

- `bernard_west_refuge_neutral_claim`: true or false;
- `west_refuge_hall_state`: ready, reduced, damaged, or occupied;
- `west_refuge_sponsor_terms`: bounded, ducal, church, Blackjack, Folk-priority, or fractured;
- `first_patient_groups_state`: all-admitted, divided, displaced, or harmed;
- `bernard_drill_result`: ran-without-him, ran-with-prompting, dependent, or failed.

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
