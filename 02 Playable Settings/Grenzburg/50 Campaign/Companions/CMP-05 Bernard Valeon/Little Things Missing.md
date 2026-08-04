---
type: quest
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Old Market", "Cathedral Close", "Lantern Ward"]
culture: ["Thalmyric", "Kedravan", "Eclessian"]
related_factions: ["Blackjack Corps", "Medori Bank", "Church of Grenzburg"]
appears_in: ["Grenzburg"]
needs: []
tags: [game-ready]
quest_class: companion
act: act-1
availability_window: ["Early Autumn", "Open Autumn"]
repeatability: one-shot
cutoff_result: transforms
world_state_outputs: ["bernard_introduction_complete", "bernard_direction", "bernard_compulsion_disclosed", "bernard_accountability_plan", "little_things_returned", "kitchen_helper_state", "koss_bernard_leverage"]
reward_unlocks: ["Hands Declared", "Things Not Mine", "Enough for Tonight"]
required_locations: ["Blackjack Yard", "Red Stag Inn", "Mercy Hospital", "Old Market", "Lantern Market"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: introduction
companion_campaign_stage: introduction
quest_owner: "Bernard Valeon"
quest_sequence: 1
companion_id: "CMP-05"
faction_line: ""
faction_branch: ""
chapter_id: ""
main_sequence: 0
story_gate: investigation
estimated_hours: 1.5
gameplay_pillars: [investigation, social, pursuit, traversal, consequence]
required_states: ["bernard_recruited", "bernard_first_outing_complete"]
optional_state_inputs: ["blackjack_rank_admitted", "church_rank_admitted", "underworld_rank_admitted", "brina_trust"]
field_experience_gate: []
companion_required: "Bernard Valeon"
duo_quest: false
pause_points: ["First Cache Opened", "Handcart Route Found"]
relationship_gate: ""
relationship_variant: ""
preparation_inputs: []
preparation_threshold: ""
autonomous_deadline: "The Last Convoy"
autonomous_resolution: "See Companion Autonomy and Act Convergence; untracked content uses stable-colleague treatment."
changed_reentry: "The Early Winter forwarding version permits restitution but cannot recreate the original owner circuit"
ensemble_inputs: ["Elara Velescar", "Dismas Raben", "Zafir ibn Samad"]
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
emotional_function: "Keep the real relapse, wrongful suspicion, handcart recovery, and specific restitution"
pleasure_beat: "Food, absurdity, road stories, children laughing, and companionship without ceremony."
care_beat: "Bernard feeds, shelters, steadies, and tells the truth about what he takes or withholds."
player_archetype_hooks: []
---
# Little Things Missing

## Quest Function

Bernard's introductory case is a city investigation without a hidden mastermind. He has relapsed, every missing object is something he took, and a kitchen helper is about to carry the blame. The quest teaches [[Bernard Compulsion and Accountability System]] through recovery, pursuit, return, and confession rather than turning the condition into a mystery about whether Bernard is secretly innocent.

The normal field party remains available. Bernard owns every confession and accountability decision; other companions may help with access, pursuit, or witness work but cannot speak for him.

## Opening: The Wrong Spoon

The first scene is the Yard breakfast before the accusation. Bernard is losing an argument with a bent frying pan, has named the porridge “Grey Duke,” and is persuading Hannel to judge a contest in which every answer is plainly invented.

When he empties his boot to shake out a stone, the Red Stag's pewter spoon falls onto the table.

Hannel laughs first. Bernard does too, one beat too long. Then Brina says the hospital key is also missing and a pilgrim's clasp has been found beside Hannel's apron hook.

Bernard puts the spoon down where everybody can see it.

> “No joke. Not for this. She did not take that spoon.”

The transition matters: the player meets the warmth people would be afraid to lose, then watches Bernard choose whether to use it as cover.

## Unlock and Staging

Bernard asks to speak at the [[Blackjack Yard]] after one meaningful shared outing, as defined by [[Bernard Companion Campaign]]. He has found an Old Market soup spoon inside his issued boot and knows he did not put it there for cleaning.

At the same time, Mercy Hospital has reported a missing medicine-cup key, the Red Stag is missing several small guest objects, and **Hannel Klee**, a sixteen-year-old kitchen helper, has been confined after a pilgrim's carved clasp was found near her apron hook.

The party may prepare for social access, city traversal, and one short physical pursuit; no combat loadout is required.

## Immediate Situation

Bernard remembers taking the spoon and one food parcel. After checking the way he has folded his spare shirt, he admits there are probably other objects and three possible hiding places. He asks the player to help recover everything before fear makes him invent another explanation.

The missing set consists of:

- a pewter soup spoon from the Red Stag;
- the small key to Mercy Hospital's warming-cup cabinet;
- a carved antler cloak clasp belonging to a travelling Chapel-Folk grandmother;
- a flint wheel from a drover's lamp kit;
- a bone needle case belonging to a Blackjack mender;
- a child's red mitten and two wrapped food portions;
- three low-value buttons and a smooth pantry token whose owners are not yet known.

None is valuable enough to explain a resale scheme. Together they establish the pattern of comfort, use, and feared shortage.

## Principal Cast

- [[Bernard Valeon]]: knows he relapsed and is afraid that one admission will make every accusation true.
- **Hannel Klee:** kitchen helper and recent refugee, angry that poverty makes her the obvious suspect.
- **Sister Greta Mahl:** Mercy Hospital store steward, willing to protect patients and evidence but not conceal the missing key.
- **Tomas Brunn:** refuse contractor whose handcart unknowingly collected one of Bernard's caches.
- [[Captain Valdemar Koss]]: benefits from recording every loss against Bernard but did not cause the thefts.

## Pressure States

### Owners Depart: 4 to 0

Time advances through long delay, retreat from a closed section, a failed pursuit, or an unresolved public disturbance.

- **4-3:** every owner remains reachable through ordinary routes.
- **2:** the drover and Chapel-Folk traveller move toward Lake Gate.
- **1:** the mitten's family boards a westbound cart and Hannel's hearing begins.
- **0:** returns require forwarding through West Refuge Hall; Hannel is dismissed unless Bernard has already cleared her.

### Disclosure State

`private`, `witnessed`, `public`, or `concealed` controls later trust. It records how Bernard names the act, not whether the objects physically return.

## Beginning: The Locker and the Hook

The party first inspects Bernard's open kit area and the kitchen hook where Hannel's apron hung.

Three independent facts clear Hannel:

1. the clasp carries wool fibers from Bernard's issued blanket, not her apron;
2. Bernard recognizes the folded paper he used around it;
3. the apron hook is public and the clasp was placed beside rather than inside Hannel's belongings.

Bernard may admit ownership immediately, give sealed testimony to Brina, or ask for enough time to recover the whole set before speaking. The player cannot fabricate evidence that Hannel stole anything.

The first cache lies behind a loose board near the Yard kitchen. It contains the clasp, flint wheel, mitten, and food. Opening it establishes that Bernard remembers making the hiding place and chose not to name the urge.

### Pause Point: First Cache Opened

The quest may pause after Hannel is provisionally cleared and the first owners are identified. Bernard waits at the Yard; pressure does not advance through unrelated free play until resumption.

## Middle: Retracing the Day

Bernard's route crossed the Red Stag, Mercy Hospital, Old Market, and the Yard. The party can reconstruct the remaining caches through any two clues at each stage:

- flour from the Red Stag cellar on Bernard's spare cuff;
- a medicine-cabinet chalk mark on the pantry token;
- a bent nail matching the underside of an Old Market bench;
- Bernard's memory of counting doorways after the urge;
- witnesses who remember him stopping to repair a strap or carry a patient.

The Red Stag cache yields the needle case and buttons. Returning the spoon there may be handled privately, before witnesses, or through payment without admission. The owner accepts compensation but remains entitled to know who took it if the act was witnessed.

At Mercy Hospital, the warming-cup key is no longer in its niche. Staff had to force the cabinet, delaying warm fluids but causing no death or permanent injury. This is the first present-day consequence that resembles Froststep, and Bernard must resist making his shame the most urgent patient in the room.

## The Refuse Handcart

Tomas Brunn cleared the broken bench beneath Bernard's third cache and loaded the concealed bundle into a refuse handcart bound for Lantern Market sorting. The party identifies the cart through:

- the bench's square iron nail;
- grey wrapping caught under the cart rail;
- a Market sweeper's route slate;
- Bernard admitting that the bundle includes the missing hospital key.

### Pause Point: Handcart Route Found

The player may pause before pursuit. Resuming places the party at the Old Market route fork with the current Owners Depart state.

## Pursuit Through Old Market

The pursuit runs through closing stalls, a stair lane, a laundry bridge, and the descent toward Lantern Market. No villain drives it; Brunn does not know the bundle matters and is trying to finish before curfew.

The player can:

- catch the cart through ordinary sprinting and vaulting;
- use social authority to halt the street ahead;
- take a roof or service-lane shortcut;
- follow the cart to the sorting yard after losing sight of it.

Failure advances Owners Depart and scatters the bundle across the sorting yard. The key remains recoverable through search, witness, or Brunn's load count.

## End: The Return Circuit

The recovered objects are returned through a short player-directed circuit. Each owner has an independent response:

- the grandmother values the name of the taker more than repayment;
- the drover accepts immediate replacement but reports the theft if Bernard lies;
- the Blackjack mender asks Bernard to repair two communal kits as restitution;
- the mitten's child wants the mitten, not a better replacement;
- Mercy Hospital requires the key, a duplicate, and a witnessed store procedure.

No dialogue roll converts every owner into one response. Cultural knowledge and prior standing change privacy, timing, and local trust.

## Decision: How Bernard Names It

### Public confession

Bernard clears Hannel before the Yard and names every object. Koss gains factual leverage but loses the ability to imply a wider conspiracy. Owners receive the clearest account.

### Witnessed private return

Brina, Greta, and each affected owner witness the relevant admission. Bernard avoids public spectacle while maintaining an accountable record. Koss can still add legitimate replacement costs, not invented losses.

### Quiet concealment

The objects return through anonymous payment or placement. Hannel can still be cleared through physical evidence, but Bernard's concealment remains and later systemic cues become harder to read.

### False blame

Supporting Hannel's punishment or assigning the acts to an invented thief creates an immediate major conflict. Bernard may accept the lie in fear, but the companion line enters Strained and requires repair before [[The Wagon in the Reeds]] can lead into his Act I finale.

## Information Redundancy

- Hannel is cleared through fibers, Bernard's wrapping, his admission, or route witnesses.
- Every cache has physical sign, Bernard memory, and one external witness path.
- The hospital key remains recoverable through cart trail, load slate, or sorting-yard search.
- Owners can be found through the Red Stag register, market witnesses, West Refuge Hall, or Blackjack equipment rolls.

No failed check can make the relapse unknowable or permanently lose a required object.

## Vocation Access

Every player vocation can investigate the caches, protect Hannel's testimony, recover the handcart bundle, and complete the return circuit. Movement, social, or knowledge advantages change speed and privacy rather than access.

## Fail-Forward Results

- If the cart reaches sorting, the bundle scatters and return takes longer.
- If an owner departs, West Refuge Hall forwards the item with lower trust.
- If the key is damaged, a duplicate is commissioned and Bernard owes its labor.
- If Hannel is dismissed, she can be restored through later testimony but loses wages and trust.
- If the party is defeated during a street disturbance, Brina retrieves them while the cart advances.

## Outputs

- `bernard_introduction_complete`: completed, autonomous, or aftermath;
- `bernard_direction`: truthful, uncertain, or withholding;
- `bernard_compulsion_disclosed`: denied, partial, full, or public;
- `bernard_accountability_plan`: none, private, witnessed, or coercive;
- `little_things_returned`: complete, partial, compensated, or concealed;
- `kitchen_helper_state`: cleared, restored-late, dismissed, or blamed;
- `koss_bernard_leverage`: bounded, factual, inflated, or repudiated.

## Relationship Movement

Honest return without humiliation moves Bernard toward **Open** or **Trusted**. Public spectacle for its own sake may reduce openness even when confession remains necessary. Concealment creates a named conflict rather than invisible approval loss.

Completion opens **Enough for Tonight** and [[The Wagon in the Reeds]]. The conversation expresses interest or friendship but does not commit either relationship path.

## Seasonal Transformation

If autumn closes first, the owners disperse and Hannel's dismissal has already occurred. The Early Winter version begins with forwarding routes, appeal, and a Lantern Market recovery. Every object remains returnable, but trust and wages cannot be perfectly restored.

## Rewards and Unlocks

- [[Bernard Compulsion and Accountability System]] becomes fully active;
- the Things Not Mine pouch and owner records unlock;
- Bernard gains **Hands Declared**, improving self-report cues and return interactions;
- Bernard offers witnessed item-return service at supported hubs;
- qualitative approval and first relationship-interest scene.

## Navigation

- [[Bernard Valeon]]
- [[Bernard Companion Campaign]]
- [[Bernard Field Familiarity and Relationships]]
- [[Bernard Compulsion and Accountability System]]
- [[Bernard Long Watch Greatsword Package]]
- [[The Wagon in the Reeds]]
- [[Companion Field Familiarity and Duo Quest Standard]]
- [[Narrative State Register]]
- [[Companions MOC]]
