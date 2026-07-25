---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Upper Grenz", "Grenzburg"]
culture: ["Ättar", "Grey-Wolf", "Eclessian"]
related_factions: ["Blackjack Corps", "Medori Bank"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-1
availability_window: ["Open Autumn"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["ylva_recruited", "ylva_campaign_tracked", "ylva_fourth_marker_restored", "ylva_injury_disclosed", "ylva_direction", "southbound_watch_roster_state", "diverted_carters_state"]
reward_unlocks: ["Winter Route Read", "Ylva Recruitment"]
required_locations: ["Southbound Muster Camp", "Tann Crossing", "Fourth Marker Cut"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: introduction
companion_campaign_stage: introduction
quest_owner: "Ylva Winter-Track"
quest_sequence: 1
companion_id: "CMP-03"
faction_line: ""
faction_branch: ""
chapter_id: "MC-04"
main_sequence: 4
story_gate: "The Southbound Muster"
estimated_hours: 1.0
gameplay_pillars: [route-investigation, rescue, ranged-combat, staffing-choice]
required_states: ["southbound_muster_started"]
optional_state_inputs: ["military_knowledge", "wilderness_knowledge", "blackjack_reform_state"]
field_experience_gate: []
companion_required: "Ylva Winter-Track"
duo_quest: false
pause_points: ["Carters Recovered", "Fourth Marker Restored"]
relationship_gate: ""
relationship_variant: ""
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "The Last Convoy"
autonomous_resolution: "Ylva restores the marker alone, rescues the carters after one injury, and enters Act I managed"
changed_reentry: "Relay After Frost"
ensemble_inputs: ["Bernard Valeon", "Dismas Raben", "Ilyana Veshkar"]
identity_hooks: ["Ättar", "Folk", "Military", "Wilderness", "Drifter/Vagabond", "Hunter"]
encounter_deck: ["Upper Grenz road bandits", "autumn route failure"]
persistence_scope: regional-milestone
postgame_season: ""
---
# The Fourth Marker

## Quest Function

This is Ylva's recruitment case inside [[The Southbound Muster]]. It introduces her rescue-first Hunter role, exposes the staffing abuse attached to her debt, and makes the player's first meaningful choice about her: help distribute the watch or reward her for surviving an impossible one.

It uses the normal field party. Ylva accompanies the group as a required temporary specialist until recruitment is resolved.

## Trigger

At the Southbound Muster camp, the route board lists four simultaneous watches under the same name:

1. convoy head at Tann Crossing;
2. rear freight watch;
3. Black Fir weather relay;
4. an omitted marker covering the side road from Fourth Marker Cut.

[[Captain Valdemar Koss]] cut the fourth scout from the roster and told Ylva to "use her judgement." She signed all four lines rather than force another debtor onto the route.

The omitted marker then stops answering. Two supply carts follow its false all-clear and disappear.

## Beginning: Four Watches, One Scout

At the route board the player can establish:

- Koss removed a paid position after its equipment had already been issued;
- Ylva copied the marker's signal onto her own slate;
- the fourth watch lies beyond any credible line of sight;
- Ylva has wrapped a bleeding side beneath her coat;
- the missing carts carried food, lamp caps, and bridge wedges rather than treasure.

Military or Merchant/Craft knowledge exposes the altered roster. Wilderness or Hunter knowledge shows that no runner could physically maintain all four points. Insight notices Ylva bracing one side whenever she draws.

Confronting Koss now secures a written record but costs departure time. Going immediately preserves the rescue window. Brina can receive the evidence either way.

## Middle: The Diverted Road

The party follows three redundant signs:

- a wheel rut crossing the declared road;
- a flare cap placed upside down;
- Ylva's original cut mark scraped from a birch;
- flour spilled through a split cart seam;
- a driver who escaped into reeds and left strips of harness leather.

Missing a trail check changes the approach rather than losing the quest. The player reaches the captured marker from:

- the exposed road, fastest and most visible;
- a drainage shelf, slower but protected;
- a timber loading line, requiring ordinary climbing and one controlled descent.

All starting vocations can use every route. Hunter and Slayer gain faster positioning, while other vocations receive combat or protection advantages.

## The Road Band

Seven human deserter-bandits seized the marker and inverted its signal. They intend to strip the carts, recruit one driver by force, and send the empty teams onward so the loss looks like panic.

They are not agents of Koss, Grobi, Folk, or a wider conspiracy. They saw an unstaffed road and chose to exploit it.

The encounter supports:

- a direct attack;
- a signal feint that draws two sentries away;
- release of the cart teams before combat;
- negotiation for the captives followed by pursuit;
- a nonlethal stop if the player has suitable tools.

Failure or retreat causes the bandits to move, not execute the captives. The flour trail and a wounded draft animal reveal their fallback camp.

## Rescue Priority

During the fight, one cart begins rolling toward a washed-out edge while a driver remains tied beneath it. Ylva moves to catch the cart despite her injury.

The player may:

- help stop the cart;
- cut the freight loose and save the driver;
- direct another companion or freed carter to the brake;
- secure the driver first and let the supplies fall;
- pursue the bandit leader while Ylva handles the cart.

Saving cargo is possible with preparation and fast play, but life is the controlling priority. Ylva's reaction distinguishes shared action from praise for taking the whole load herself.

## End: The Missing Name

At the restored marker, the player decides how the returning watch is staffed:

- publish the altered roster and assign a mixed relief team;
- place the fourth watch under ducal road staff;
- let Brina create a Blackjack rotation;
- accept Koss's private promise to "manage it";
- allow Ylva to keep the extra watch.

Ylva must also answer for her concealed injury. The player can ask her to report it, report the physical fact without speaking for her motives, or reward the concealment.

She joins the Blackjacks as a selectable companion after the marker is restored or the carters are safely returned.

## Information Routes

The staffing truth has redundant evidence:

- the route board scrape;
- the issued fourth signal kit;
- Koss's amended roster;
- Brina's equipment count;
- driver testimony;
- Ylva's copied watch slate.

No social failure can erase it. Failure changes who accepts the evidence and whether Koss retains control of the replacement.

## Fail-Forward

- **Late departure:** the carts move to the fallback camp and one driver is injured.
- **Lost trail:** the escaped driver's signs lead to the same conflict from a worse angle.
- **Cart falls:** the driver remains rescuable; food and bridge wedges are lost.
- **Bandit leader escapes:** the marker is restored, but later road encounters gain a prepared survivor.
- **Ylva collapses:** the party carries her to Tann Crossing and her concealed injury becomes public.
- **Koss keeps staffing authority:** Brina records the abuse and the fourth marker remains an Act I preparation asset only if the player secures an actual relief rotation.

## Rewards

- Ylva becomes recruitable.
- `ylva_campaign_tracked`
- `ylva_fourth_marker_restored` when a real watch is staffed.
- **Winter Route Read:** Ylva warns about one severe-weather or staffing hazard during ordinary travel.
- access to [[A Signal Shared]].

## Navigation

- [[Ylva Companion Campaign]]
- [[Ylva Winter-Track]]
- [[The White-Sled Rescue]]
- [[The Southbound Muster]]
- [[Blackjack Yard]]
- [[A Signal Shared]]
