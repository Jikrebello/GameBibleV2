---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg"]
culture: ["Eclessian"]
related_factions: ["Duchy of Grenzburg", "Blackjack Corps", "Low Lanterns", "Black Bell", "Bloody-Sun Host"]
appears_in: ["Grenzburg"]
needs: []
aliases: []
tags: [game-ready]
quest_class: main
act: act-2
availability_window: ["Deep Winter"]
repeatability: one-shot
cutoff_result: persists
world_state_outputs: ["winter_knives_state", "granary_culvert_state", "counterattack_route"]
required_locations: ["Lantern Ward", "Grenzburg Underways", "Old Granary Culvert", "Quarry Galleries", "South Granary"]
blocking_status: blocked
quest_owner: "Grenzburg Main Campaign"
quest_sequence: 0
companion_id: ""
faction_line: ""
faction_branch: ""
chapter_id: "MQ-13"
main_sequence: 13
story_gate: investigation
estimated_hours: 1.5
gameplay_pillars: [investigation, infiltration, urban-combat, choice]
required_states: ["western_breach_state"]
optional_state_inputs: ["lantern_ward_damage", "blackjack_yard_state", "low_lantern_progress", "black_bell_progress", "skiv_intelligence_state"]
---
# Knives Behind the Walls

## Chapter Function

This is Act II's urban pursuit chapter. It makes clear that the Grobi broke Grenzburg's wall by force in [[The City in Siege]]; the human killers here merely exploit a wounded city. The investigation turns the repaired western breach from scenery into a contested military asset and creates the player's best optional route for the final counterattack.

## Trigger and Commitment

The chapter opens after the emergency wall has been closed and the missing shift at the South Granary fails to report. Beginning the descent into the Old Granary Culvert creates a short closed operation. It does not advance the season.

## Hook and Immediate Stake

Three wallwrights are found murdered with their tools removed, and a ration clerk has vanished with culvert keys. The killings are the work of the **Cinder Knives**, twelve paid human infiltrators led by former siege sapper **Otto Krell**. Skiv sold Krell a route sketch; Ghor promised loot and passage if the cell opens the culvert during the next assault.

Krell is neither a patriot nor a hidden mastermind. He has chosen payment, murder, and collaboration with an invading army because the siege makes those crimes profitable.

## Beginning: A City That Cannot Stop

The player examines the wallwright deaths while ordinary siege work continues around them. Three independent information routes point below the city:

- tool marks and lime dust connect the bodies to the Quarry Galleries;
- ration discrepancies reveal supplies moved into an abandoned granary vault;
- underworld witnesses identify a buyer seeking lamp oil, saws, and silent passage.

The missing clerk, **Elsbeth Kran**, left a reversed tally at each forced door. If the player misses those marks, a surviving wallwright or an underworld contact supplies the same route at the cost of one preparation step.

## Middle: The Cinder Knives

The pursuit crosses the Quarry Galleries, a ration cache, and the culvert's old sluice room. The player may:

- infiltrate through Low Lantern routes;
- descend with ducal engineers and hold against prepared ambushes;
- enter from the riverworks and fight upstream through freezing water;
- use Black Bell information to isolate individual killers, accepting that its witnesses expect a later reckoning.

Krell's cell has already cut two lock pins and fitted a concealed signal grate. Elsbeth is alive because only she knows which wheel opens the final flood door. Rescuing her gives the player the safest control sequence, but the mechanism can also be read, forced, or destroyed.

## End: Seal or Turn

Krell attempts to open the culvert when cornered. The player defeats the cell and then chooses the route's military state:

- **Stone-Sealed:** collapse and masonry make the passage unusable to both sides. This is safest for the city.
- **Flood-Sealed:** restore the sluices so any incoming force can be drowned. This preserves the works but requires engineers during the finale.
- **Turned Corridor:** conceal the repair, place ducal assault stores inside, and retain the culvert as a Blackjack counterattack route.

The final option creates the strongest offensive opening in [[Ghor at the Gate]], but a careless setup can expose the plan. The choice is presented with its risk before confirmation.

## Encounters and Opposition

- moving investigation through ration queues and damaged streets;
- a quarry-gallery stalking fight against paired infiltrators;
- trapped supply vault and hostage rescue;
- sluice-room confrontation with Krell and his remaining cell;
- optional defense of engineers while the route is sealed or converted.

## Information Paths

Physical evidence, civic records, and human testimony each identify the underways. Krell's pay notes, Skiv's private mark, and a captured signal lamp independently establish that the cell works for Ghor. No faction membership and no single social check are required.

## Choices and State Changes

- `winter_knives_state` records destroyed, captured, or leader-escaped.
- `granary_culvert_state` records stone-sealed, flood-sealed, turned, or damaged.
- `counterattack_route` records culvert, wall-sortie, or none-prepared; every campaign still receives a baseline sortie in MQ-15.

Captured killers can be tried by the city. Allowing Black Bell to execute prisoners strengthens that branch but is treated as a deliberate surrender of public judgement, not free efficiency.

## Fail-Forward Results

- Missed clues cost time and let the cell fortify a later chamber.
- A failed hostage approach wounds Elsbeth or destroys one control diagram, but never removes every way to operate the sluice.
- If Krell escapes, he appears during Ghor's final assault with one sabotage team.
- If the culvert opens briefly, a small Grobi force enters and must be cleared; the main army does not bypass the entire campaign.
- Destroying the works removes the counterattack shortcut but permanently protects the route.

## Companion Intersections

Elara and Tavio are strongest at infiltration and mechanism reading. Bernard presses for public trial; Ashira opposes terrorizing witnesses with human imprints; Ilyana understands the sapper plan; Dismas recognizes hired ambush discipline. No companion is required.

## Faction Advantages

Ducal engineers improve sealing, Blackjacks improve the turned corridor, Low Lanterns provide nonlethal access, and Black Bell identifies killers quickly at a political cost. Church workers can protect ration civilians while the party descends.

## Cutoff and Unlocks

Completion satisfies the urban requirement for [[Break the Southern Horn]]. The culvert remains in its chosen physical state through winter, the final assault, and summer.

## Navigation

- [[The City in Siege]]
- [[Grobi Host Fragmentation Matrix]]
- [[Break the Southern Horn]]
- [[Ghor at the Gate]]
- [[Main Campaign MOC]]
