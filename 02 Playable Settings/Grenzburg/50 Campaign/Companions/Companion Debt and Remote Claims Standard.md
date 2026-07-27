---
type: reference
status: canon
canon_level: local
visibility: author-only
era: ["Present Day"]
region: ["Grenzburg"]
culture: ["Sestaran", "Fiorenzian"]
related_factions: ["Blackjack Corps", "Medori Bank"]
appears_in: ["Grenzburg"]
needs: []
aliases: ["Remote Claims Doctrine"]
tags: [game-ready, production-control, companion-control]
---
# Companion Debt and Remote Claims Standard

This note controls how all eight companion debts enter, change, and end inside the Grenzburg game.

## Core Rule

Medori owns or administers each companion's enforceable claim. The Bank is therefore the local legal counterparty even when the original wrong, injured person, employer, court, order, family, or institution remains abroad.

No person from a companion's former life physically enters the base-game worldspace.

The past may remain active through:

- authenticated correspondence;
- unanswered letters and explicit refusals of contact;
- sworn testimony carried by neutral couriers;
- remote settlement instructions;
- institutional judgements and account records;
- property, equipment, scores, patterns, or other material consequences;
- local agents who never become a substitute victim or source of forgiveness.

The rule prevents eight distant casts from converging on a small frontier duchy. It does not make the past unreal or let a companion escape consequences by leaving home.

## Local Portfolio

[[Claims-Factor Marco Bellandi]] manages the eight companion files from the Iron Ledger Counting-House under [[Ledger-Master Lucia Medori]].

Bellandi may:

- authenticate the Bank's ownership and the underlying claim;
- reject charges that are unsupported by the purchased instrument;
- receive remote instructions and refusals;
- administer restitution escrow;
- recognize service, payment, judgement, or political settlement;
- restructure, satisfy, transfer, or close an account within delegated authority.

Bellandi may not:

- forgive a companion on behalf of an injured person;
- declare a companion morally resolved;
- compel a remote person to answer;
- invent personal liability from a useful confession;
- add Koss's field losses to an unrelated claim without written authority;
- turn player approval, romance, sworn friendship, or temperament into legal evidence.

Lucia controls policy and exceptional authority. [[Quartermaster Brina Kest]] may advocate, witness, and organize collective relief. [[Captain Valdemar Koss]] may submit charges but cannot silently alter Bellandi's portfolio.

## Two Independent Judgements

Every companion has a **legal debt state** and a **personal direction state**.

| Legal debt state | Meaning |
|---|---|
| `owned` | Medori holds and enforces the purchased claim |
| `under-review` | ownership, charges, satisfaction, or remedy is being examined |
| `restructured` | the claim remains, but term, payment, service, or beneficiary has changed |
| `satisfied` | the recognized obligation has been met and personal service ends |
| `voided` | the claim is unenforceable or extinguished without satisfaction |
| `collective-settlement` | a company, ducal, cooperative, or public settlement replaces individual enforcement |

A resolved person may remain legally owned under a bad institutional outcome. A compromised or broken person may satisfy a legally valid account without becoming admirable. Neither combination is a writing error.

## Portfolio Rhythm

Bellandi appears only where the account itself changes:

1. an initial file review or disputed charge;
2. a substantial mid-campaign remedy, restructuring, or escrow decision;
3. a final settlement in a companion finale, summer coda, or [[Accounts of the Living]].

He does not attach a Bank rider to ordinary companion work. Most personal quests concern the person, the company, and Grenzburg rather than their paperwork.

## Remote Agency

Remote people and institutions retain agency.

- They may accept money while refusing reconciliation.
- They may reject direct contact.
- They may disagree among themselves.
- They may specify a material remedy without supplying emotional closure.
- Silence is a valid response and is never converted into consent.
- A Bank receipt proves only what it names.

No Medium imprint, Bard performance, patron, Menhir route, or supernatural mechanism is used as remote communication.

## Required Companion Properties

Every companion bible records:

- `remote_claim_anchor`;
- `past_contact_mode: remote-only`;
- `debt_manager: Claims-Factor Marco Bellandi`;
- the companion-specific legal debt state key;
- a personal direction key owned by that companion's campaign.

Quest notes that still require a past person to arrive use `remote_claim_status: pending-migration` and remain excluded from implementation-ready views. Compliant quests use `remote_claim_status: compliant`.

## Navigation

- [[Claims-Factor Marco Bellandi]]
- [[Companion Remote Claims Compliance Register]]
- [[Companion Campaign Architecture]]
- [[Companion Constitution]]
- [[Narrative State Register]]
- [[Companions MOC]]

