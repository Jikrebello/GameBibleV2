---
type: quest
status: draft
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Grenzburg Underways", "Lantern Ward", "Longlake Ward"]
culture: ["Eclessian", "Korrheim"]
related_factions: ["Blackjack Corps", "Low Lanterns", "Medori Bank"]
appears_in: ["Grenzburg"]
needs: []
tags: [narrative-rewrite]
quest_class: companion
act: act-2
availability_window: ["Early Winter", "Deep Winter"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["dismas_passage_handoffs", "passage_state", "koss_leash_result", "dismas_low_lantern_terms", "dismas_direction"]
reward_unlocks: ["Underways passage", "named handoffs"]
required_locations: ["Grenzburg Underways", "Lantern Ward", "Longlake Ward", "Blackjack Yard"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: act-operation
companion_campaign_stage: act-2
quest_owner: "Dismas Raben"
quest_sequence: 5
companion_id: "CMP-06"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: preparation
relationship_variant: ""
estimated_hours: 1.0
gameplay_pillars: [traversal, logistics, protection, social, maintenance]
required_states: ["dismas_act1_chapter_resolved", "winter_siege_active"]
optional_state_inputs: ["underways_route_access", "lantern_ward_damage", "underworld_branch_low_lantern", "dismas_lask_task_kept"]
companion_required: "Dismas Raben"
duo_quest: false
pause_points: ["Passage Opened", "First Week Held"]
autonomous_deadline: "Ghor at the Gate"
autonomous_resolution: "The passage opens brilliantly and runs on Dismas alone until Koss exercises the contract, at which point he cedes the map rather than argue. Two wards keep a route; nobody else can hold it."
changed_reentry: "The passage survives as a Low Lantern asset with a toll on it, which he did not intend and cannot undo"
ensemble_inputs: ["Ilyana Veshkar", "Bernard Valeon", "Zafir ibn Samad", "Ylva Winter-Track"]
identity_hooks: ["Underworld", "Peasant/Labour", "Military", "Drifter/Vagabond"]
emotional_rewrite_status: cleared
dialogue_status: pending-rewrite
remote_claim_status: compliant
archetype_pressure: "Opening it is one night. Keeping it is three weeks. Test whether resistance can survive becoming infrastructure."
emotional_function: "Make maintenance the content, and let containment arrive wearing his own contract."
pleasure_beat: "A dead tunnel becoming a lifeline, torch discipline, and the smuggler as civic artery."
care_beat: "He trains people to run the route without him, and stands above ground doing nothing while it works."
player_archetype_hooks: ["Cheerleader", "Tomboy", "Goth", "Bohemian", "Jock", "Nerd", "Rebel", "Goofball", "Grey"]
persistence_scope: district-persistent
---
# Passage

## Quest Function

Dismas's Act II operation, and the audit's urban siege piece: **escape is easy and maintenance is not.**

It founds the guide network without anyone using the word, and it contains the first of the campaign's three containment scenes.

## Premise

The siege has cut Lantern Ward from Longlake Ward. The public lane is under fire, the river route is frozen wrong, and two wards' worth of people are separated from the hospital, the shelters, and each other.

Dismas knows a way: a dead freight tunnel under the Quarry Steps, closed since a collapse forty years ago, which is not on any map because it has not been an asset since before the Duchy cared.

Opening it is one glorious night. The quest is the **three weeks after.**

## Beginning: The Opening Night

The party clears, props, and lights the route: a collapse to crawl, a flooded section to divert, a shaft that needs a ladder that is not there. Combat is optional and shallow. Everything about it is fun and it is the last fun thing in the piece.

At the far end, people come through. Old women, a midwife, a soldier's family, four hundred pounds of flour on a hand sled.

### Pause Point: Passage Opened

## Middle: Three Weeks

The passage does not stay open on enthusiasm.

- **props rot** — the water table is higher than the survey said, and two supports need replacing every ten days;
- **water rises** — one section needs bailing on a schedule or it closes;
- **torch discipline slips** — three near-suffocations in the first week because somebody carried the wrong lamp;
- **handoffs fail** — the route needs a person at each end who knows who is coming and when, and being *that person* is unbelievably boring;
- **[[Mara Senn]] will not call it protected** without named handoffs, supplied stations, and a return signal — her bio's terms, enforced on screen. She is not being difficult. She has buried clients who used a route nobody was minding.

**The temptation is novelty.** At every failure, cutting a *new* route is easier, faster, and more interesting than fixing this one, and Dismas will propose exactly that, twice, with good reasons. Novelty is his version of flight and the quest never names it.

The player may train volunteers, build the roster, argue with Mara, or let it run on Dismas — who can hold it, personally, for about eleven days before he is grey.

## Koss's Leash

Somewhere in the second week, Koss finds out.

He exercises the contract. Publicly, by right, in the Yard, in front of the company: Dismas is a purchased-service asset, the passage is a Blackjack asset, and either he runs military cargo through it or he hands over the map.

**This is the one scene where the purchased service is felt from inside.** Not a metaphor, not a threat — a lawful instruction from a man who owns his labour, delivered in front of people who like him.

Options:

- **comply** — the cargo goes through, the route survives, and something in him goes quiet for a week;
- **slip it** — a false map, a longer route, a delay Koss cannot prove: works, and puts the passage's legality at risk if anyone checks;
- **make it cost** — comply loudly and make Koss own it publicly, invoking Brina, Bellandi, or the ward's own people, which does not free him and does change who watches Koss afterward;
- **refuse and go** — the exit is open, as always. It ends the operation and the wards keep a route nobody maintains.

Writes `koss_leash_result`. Moves direction more than any other single beat in Act II.

## End: The Night He Is Not Needed

If handoffs, stations, signals, and volunteers are real, there is a night in the third week when the passage runs a full shift — six crossings, a birth, forty pounds of coal — and **Dismas is above ground, doing nothing.**

He stands at the Quarry Steps in the cold, listening to a route work without him.

He experiences it as a kind of death, and the quest offers no consolation: no companion tells him it means he has grown, no line converts it into a lesson. He is simply, visibly bereft of the only thing that has ever made him necessary, and the passage is saving lives ten feet below him.

> **Dismas:** Good. That is — good.
>
> *(A long time.)*
>
> **Dismas:** I am going to go and find something broken.

### Pause Point: First Week Held

## Outputs

- `dismas_passage_handoffs`: named, partial, or none — Act II preparation;
- `passage_state`: community-held, Blackjack-held, Low-Lantern-tolled, or closed;
- `koss_leash_result`: complied, slipped, cost-him, or refused;
- `dismas_low_lantern_terms`: met or refused;
- `dismas_direction`.

## Fail-Forward

- A closed passage costs the wards a week and reopens at greater cost; nobody dies of it on screen.
- A Low-Lantern-tolled passage still moves people, and Dismas has to watch a route he opened become somebody's revenue.
- Refusing Mara's terms means the route is unprotected when a client is robbed in it, which is recoverable and remembered.
- If the player never trains anyone, the passage is his and only his, and Act III's network starts from nothing.

## PAIR Note

⟨PAIR⟩ The Ilyana winter foil beat — *they create an escape and a shelter; each tries to assign the maintenance to the other; they return together for the boring part* — stages inside or adjacent to this operation. Jointly owned; coordinate with [[Ilyana Rewrite Spec]] when her pass executes.

## Navigation

- [[Dismas Raben]] · [[Dismas Companion Campaign]]
- [[Mara Senn]] · [[Captain Valdemar Koss]] · [[Grenzburg Underways]]
- [[The Name on the Charge]] · [[Tuesday]]
