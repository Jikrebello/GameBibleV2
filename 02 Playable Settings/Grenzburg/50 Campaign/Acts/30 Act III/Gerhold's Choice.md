---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Frostfenn March"]
culture: ["Eclessian", "Qianglong"]
related_factions: ["Duchy of Grenzburg", "Marcher Vanguard", "Blackjack Corps"]
appears_in: ["Grenzburg"]
needs: []
aliases: []
tags: [game-ready]
quest_class: main
act: act-3
availability_window: ["Open Spring"]
repeatability: one-shot
cutoff_result: persists
world_state_outputs: ["gerhold_command_severed", "gerhold_fate", "gerhold_loyalists_state", "muster_acceleration"]
required_locations: ["Grenzburg", "Upper Grenz", "Three Horn Depot", "Frostfenn March"]
blocking_status: blocked
quest_owner: "Grenzburg Main Campaign"
quest_sequence: 0
companion_id: ""
faction_line: ""
faction_branch: ""
chapter_id: "MQ-19"
main_sequence: 19
story_gate: investigation
estimated_hours: 2.0
gameplay_pillars: [investigation, pursuit, social-conflict, combat, boss]
required_states: ["deep_muster_approach_open"]
optional_state_inputs: ["ducal_progress", "marcher_charter_state", "tannbruck_survivors", "gerhold_prior_respect", "remaining_anchor_access"]
---
# Gerhold's Choice

## Chapter Function

This chapter resolves the campaign's human Act III antagonist without making him the cause of the awakening. Gerhold's decision is foreshadowed, investigated, and morally legible: he knowingly accepts the Muster because he wants an army that cannot flee, tire, age, or be released from service.

## Trigger and Commitment

Evidence from the outer works reveals a living officer's copied rank tablets. At the same time, body carts disappear from ducal recovery details and two marcher platoons march south under sealed orders that Pierre did not issue. The investigation remains open until the party leaves for Three Horn Depot.

## Beginning: The Missing Dead

The player follows three evidence lines, any two of which locate Gerhold:

- **Body carts:** casualty rolls show selected remains diverted away from burial and memorial stations.
- **Rank tablets:** Warlock Hall comparison identifies fresh copies made from Gerhold's winter command seals.
- **Missing soldiers:** survivors report Gerhold promising a garrison that will never again abandon a wall.

Gerhold's earlier heroism remains true. He held the winter line, protected subordinates, and earned trust. The evidence also makes clear that he now understands the formations are residue and that the Muster's command has no lawful limit.

## Middle: Three Horn Depot

The depot is active as an outer command store. Gerhold has brought forty to seventy living loyalists, several body carts, copied tablets, and captured command gear. Not all followers know his full intent.

The player can:

- expose the complete plan and offer uninformed soldiers safe custody;
- use ducal witnesses or prior marcher reforms to split the force;
- infiltrate the depot and destroy copied tablets before the confrontation;
- assault directly, accepting higher loyalist and prisoner casualties.

Gerhold has already spoken the acceptance and been recognized by the recurrence before the party arrives. Dialogue can save followers and reveal his reasoning; it cannot return him to innocence or prevent the fixed choice.

## End: The Commandant Without Discharge

Gerhold uses the accepted rank to command residue guards, redirect architecture, and repeatedly replace his armor from depot stores. He remains a living man physically altered by a command relationship, not a dragon host or trapped soul.

The fight requires breaking three command links while surviving Gerhold's direct martial pressure. Prior evidence and separated loyalists reduce his living support. Destroyed regional anchors remove their corresponding Muster assistance.

Gerhold is either:

- killed during the battle after refusing surrender; or
- defeated, stripped of active command, placed in due custody, publicly judged for murder, desecration, unlawful command, and treason, then executed.

There is no pardon, exile, secret recruitment, or redemptive return to service after his acceptance. The custody path preserves testimony and reduces rumor; it is not mercy without justice.

## Encounters and Opposition

- civic and military investigation across casualty systems;
- pursuit of a missing platoon on the Fenn Road;
- Three Horn Depot infiltration, negotiation, or assault;
- living-loyalist separation under pressure;
- command-link objectives;
- boss confrontation with Gerhold and residue guard.

## Information Paths

Every conclusion has redundant sources: rolls and bodies, tablets and workshop testimony, orders and soldier witnesses. The player can confront Gerhold with incomplete proof, but cannot lose the trail through one failed check.

## Choices and State Changes

- `gerhold_command_severed` becomes true.
- `gerhold_fate` records slain-in-battle or executed-after-custody.
- `gerhold_loyalists_state` records surrendered, scattered, killed, or committed.
- `muster_acceleration` records limited, severe, or catastrophic according to how long the accepted command operated and what equipment reached the depot.

## Fail-Forward Results

- Missed evidence makes it harder to separate loyalists but does not conceal the destination.
- A failed pursuit lets more equipment reach the depot.
- A failed appeal converts uncertain soldiers into frightened defenders rather than erasing the possibility of surrender later.
- If Gerhold defeats the party, surviving Blackjacks extract them after he sends the first dead-march order; the re-entry fight begins with all command links active.
- Capturing Gerhold but failing to preserve witnesses still ends in due judgement, though the public aftermath becomes more divided.

## Companion Intersections

Ilyana and Dismas receive the strongest command-accountability scenes. Bernard insists that former virtue does not erase chosen evil; Svala distinguishes loyalty from endless obedience; Ashira explains why copied voices are not persons. Elara, Tavio, and Zafir offer covert and technical approaches. No companion can talk Gerhold back after acceptance.

## Faction Advantages

Ducal and Church progress strengthen lawful custody and public evidence; Folk witnesses identify diverted remains; Blackjack progress supplies extraction; underworld records trace workshop purchases. None changes Gerhold's fixed moral and campaign result.

## Cutoff and Unlocks

Severing Gerhold removes the living command anchor but triggers the system's autonomous counteroffensive. The chapter unlocks [[The Dead March]]. Remaining regional anchors stay open until the player confirms the Dead March season gate.

## Navigation

- [[Sir Gerhold Brandt]]
- [[Three Horn Depot]]
- [[The Unending Muster]]
- [[The Dead March]]
- [[Main Campaign MOC]]
