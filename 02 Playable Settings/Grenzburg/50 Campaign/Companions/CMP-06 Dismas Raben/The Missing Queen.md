---
type: quest
status: draft
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg", "Grenz Lowlands"]
culture: ["Eclessian", "Korrheim"]
related_factions: ["Blackjack Corps"]
appears_in: ["Grenzburg"]
needs: []
tags: [narrative-rewrite]
quest_class: companion
act: act-3
availability_window: ["Early Spring", "Open Spring"]
repeatability: one-shot
cutoff_result: forfeited
world_state_outputs: ["dismas_bond_episode", "dismas_bond_move_upgrade", "dismas_missing_queen_given", "spring_cut_route_state"]
reward_unlocks: ["Called Back: Two Signals", "Missing Queen Given"]
required_locations: ["Grenz Lowlands", "Cold Spring Cut", "Ash Road"]
blocking_status: blocked
architecture_status: migrated
companion_content_role: relationship
relationship_variant: bond
companion_campaign_stage: relationship
quest_owner: "Dismas Raben"
quest_sequence: 7
companion_id: "CMP-06"
main_sequence: 0
story_gate: relationship
estimated_hours: 0.5
gameplay_pillars: [traversal, labour, conversation, reflection]
required_states: ["dismas_relationship_commitment: bond-committed", "dismas_act2_finale_played"]
optional_state_inputs: ["dismas_chimney_count", "dismas_charge_filed_state", "toll_precedent_state"]
companion_required: "Dismas Raben"
duo_quest: false
pause_points: []
relationship_gate: "Male player; dismas_relationship_commitment: bond-committed"
autonomous_deadline: "The Deep Muster"
autonomous_resolution: "The episode closes without relationship penalty; its upgrade and safeguard are not earned"
changed_reentry: "Summer dialogue acknowledges the uncut route without replaying it"
persistence_scope: character-persistent
emotional_rewrite_status: cleared
dialogue_status: pending-rewrite
remote_claim_status: compliant
archetype_pressure: "A positive shared object that survives after the authority they opposed is gone."
emotional_function: "Cut a route against nobody, and give away the card he has kept out of every game."
pleasure_beat: "Two men with billhooks, a spring nobody has mapped, and half a day saved for strangers forever."
care_beat: "Call me back; I will come. Said once, in daylight, with a tool in each hand."
player_archetype_hooks: ["Jock", "Nerd", "Rebel", "Goofball", "Grey"]
---
# The Missing Queen

## Quest Function

Dismas's sworn-bond episode for a male player, and the answer to the question his own file poses: **what do two men who define themselves by refusal have left when the thing they opposed is gone?**

The answer is a shortcut. No villain, no theft, no vigil, no test.

## Hook

Between the Ash Road and the Lowland reed track there is a cold spring in a fold of ground, and between them there is half a day of walking that does not need to exist.

Dismas proposes cutting the route. Not against a toll, not around a checkpoint, not to evade anyone — **for no reason except that half a day is half a day, and carters will use it forever, and nobody will know who made it.**

> **Dismas:** No one is stopping us. That is the entire novelty.

## The Work

A day of ordinary labour with billhooks, a mattock, and rope: brush cleared, a bank cut down, three stones moved, a ford's approach graded, one deadfall dragged out of the way.

Every vocation completes it. Fighter and Paladin strength shortens the bank work; Slayer and Free Running find the line faster; Hunter reads the drainage; Warlock can dry a footing without replacing the digging. The player may lead half the day.

Travellers pass twice and are simply travellers.

## The Rules on the Post

At the far end they set a marker post, and on it the keeping-rules — the thing neither man has ever done for anything:

- who clears it in spring;
- who is welcome on it (everyone);
- that it carries no toll, ever, and that anyone charging one may be told this post says so;
- that it is nobody's.

They argue about the wording for twenty minutes. The player writes the final version.

## The Rite

At dusk, sitting on the cut bank, Dismas produces his deck and takes the queen out of his coat — not from the deck; from his coat, where it has lived since [[The Decorative Fence]] and for eleven years before that.

It is his route-marker. It is the thing he leaves at bad turns for people he will never meet. It is also, and he does not say this, the card he keeps out of every hand he plays.

> **Dismas:** Seven roads have one of these on them. This is the last one I have.
>
> *(He turns it over once.)*
>
> **Dismas:** Take it. If I go somewhere and do not come back, you will know how to find where I turned.

The player gives something in return: a return signal — a call, a mark, a whistle — that either man may sound and neither may overrule. Executor picks the form; the rule is that it is *the player's* invention and Dismas accepts it without editing.

Then the oath, which is the campaign in two lines:

> **Dismas:** Call me back.
>
> **Player:** I will come.

They explicitly become sworn brothers. No ring, no rank, no ordination, no ceremony beyond two men, a post, and a card.

The player may accept, ask for plainer words, or decline without losing ordinary friendship.

## What the Card Costs Him

`dismas_missing_queen_given` records that the deck is now permanently incomplete, and he never replaces the card.

He plays with a short deck for the rest of the campaign and complains about it constantly, which is how a man who cannot say *I gave you something that mattered* says it.

**In a resolved summer,** the player may return it — see [[Passing Through Slowly]] — and he deals the first complete hand of the campaign, and neither of them mentions what that means.

## Rewards

- **Called Back: Two Signals** — either sworn brother may signal the other out of an overcommitted position, and the upgraded move allows the signal to be answered while the caller is already withdrawing;
- `dismas_missing_queen_given` — one Act III safeguard, equal and exclusive with the romance's, preventing one extraction or exhaustion failure at Three Horn;
- bond-specific summer dialogue;
- the Cold Spring Cut appears on the player's map and in ambient carter traffic for the rest of the game.

The permanent perk **No Blind Turn** is earned only after a resolved or compromised [[The Road That Answers]].

## Cutoff

Beginning [[The Deep Muster Main Quest|The Deep Muster]] closes the window. A Lowlands work party finishes the cut badly the following year. He does not punish the player; the rite, the upgrade, and the safeguard are lost.

## Navigation

- [[Dismas Field Familiarity and Relationships]] · [[Dismas Companion Campaign]]
- [[No Railing]] · [[Tuesday]] · [[The Road That Answers]] · [[Passing Through Slowly]]
