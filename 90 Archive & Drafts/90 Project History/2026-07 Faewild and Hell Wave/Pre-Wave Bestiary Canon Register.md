---
type: reference
status: canon
canon_level: core
visibility: author-only
era: []
region: []
culture: []
related_factions: []
appears_in: []
needs: []
aliases: [Bestiary Canon Register]
tags: [core-canon]
---
# Bestiary Framework — Creatures of the World Egg

This is the authoritative **Bestiary Canon Register**. It controls how creature families are classified, what their properties mean, and how the bestiary expands. Pathfinder categories may be used in creator research, but they never override World Egg cosmology.

## Governing Rules

1. **Origin first.** Every creature has one primary source ecology even when it now lives elsewhere.
2. **Continuity answers what persists.** Intelligence, memory, and a human soul are separate questions. [[The Image, Soul, and Creaturely Continuity]] controls all rulings.
3. **The Material remains ordinary.** Most encounters are animals, weather, disease, human violence, residue, or practical hazards.
4. **A family needs an ecology.** A monster must have signs, needs, pressures, lifecycle, and consequences beyond combat.
5. **Objective morality remains legible.** Predation, slavery, corruption, and soul violation do not become morally neutral because their perpetrators are culturally complex.
6. **No accidental nations.** Broad creature variety does not require a new nonhuman state for every intelligent family.
7. **System neutral.** Threat ranks describe narrative and encounter function, not a ruleset or challenge rating.

## Origin Sections

| Folder | Primary origin | Coverage target |
|---|---|---:|
| `10 Material and Residue` | Material biology and post-mortem residue | 34 entries |
| `20 Faewild and Menhir` | Menhir courts, place-law, and mythic fauna | 30 entries |
| `30 Shadowlands and Idols` | vice ecologies, counterfeits, hunger, and fear | 24 entries |
| `40 Astral Drift and Patrons` | Drift ecologies, route parasites, and rented stability | 18 entries |
| `50 Elemental Shell` | Shell patterns, seams, leakspawn, and bindings | 18 entries |
| `60 Heaven and Soul-Road` | created angels, manifested saints, and soul-road offices | 16 entries |
| `70 Hell and Abyss` | damned transformations, Depth fauna, and refusal wounds | 24 entries |
| `80 Ancient and Crafted Legacies` | constructs, fleshworks, and dead-imperial remnants | 28 entries |
| `90 Cross-Cutting Conditions` | modifiers that alter creatures from another family | 12 entries |

The target is approximately 200 registry entries represented through 45–60 family dossiers, standalone recurring creatures, and compact variants. It is a coverage target, not a quota.

## Encounter Pyramid

- **Mundane:** animals, vermin, human opponents, ordinary residue, terrain, disease, and common crafted defenses. This should remain the broad base.
- **Aligned:** a layer or ancient system materially shapes the threat, but the encounter remains locally comprehensible.
- **Cosmological:** the creature can alter a region, soul-route, court, or plane-level condition. These encounters must remain rare enough to retain weight.

## Rank Ladder

- **Nuisance:** dangerous through numbers, circumstance, contamination, or surprise.
- **Standard:** a recurring encounter for prepared local professionals.
- **Specialist:** requires specific knowledge, equipment, or a countermeasure.
- **Elite:** changes the plan of an expedition, company, or settlement.
- **Apex:** dominates an ecology or regional crisis.
- **Unique:** an individual whose history and defeat conditions require a dedicated dossier.

A family may contain several ranks. `rank` records the dossier's most useful band or bands; it is not a fixed biological caste.

## Controlled Creature Properties

| Property | Controlled values or use |
|---|---|
| `origin_layer` | `material`, `faewild`, `shadowlands`, `astral`, `shell`, `heaven`, `hell`, `abyss`, `crafted`, `mixed` |
| `continuity` | `human-soul`, `retained-human-soul`, `bound-human-soul`, `created-spirit`, `residue`, `wrath-rewritten-life`, `drift-rewritten-life`, `biological-pattern`, `court-law`, `idol-pattern`, `shell-pattern`, `constructed-pattern`, `giant-memory`, `infrastructure-office`, `abyssal-wound` |
| `intelligence` | `mindless`, `animal`, `cunning`, `sapient`, `sovereign` |
| `moral_agency` | `none`, `limited`, `full` |
| `encounter_tier` | `mundane`, `aligned`, `cosmological` |
| `rank` | `nuisance`, `standard`, `specialist`, `elite`, `apex`, `unique`; use a list when a family spans ranks |
| `creature_family` | Canonical family name, normally matching a hub or family dossier |
| `habitats` | List of physical or metaphysical habitats |
| `encounter_roles` | List such as predator, controller, infiltrator, siege, hazard, guardian, skirmisher, or social |
| `related_magic` | List of systems that create, bind, expose, or counter the creature |
| `catalogued_forms` | Every distinct reusable form covered by the dossier; standalone creatures list themselves |

## Continuity Controls Defeat

- `human-soul`: death normally routes the person.
- `retained-human-soul`: break the retaining lien or condition, not only the body.
- `bound-human-soul`: release the prisoner without destroying the soul.
- `created-spirit`: break the present manifestation or commission-body; the spirit itself persists unless authorial canon establishes a greater judgement.
- `residue`: disperse or settle the animating memory, appetite, or place-anchor.
- `wrath-rewritten-life` and `drift-rewritten-life`: defeat the living being and any external propagation mechanism; no soul routes afterward.
- `court-law`: break, satisfy, displace, or overwrite the law that gives the being form.
- `idol-pattern`: starve, expose, or sever the vice ecology that reproduces it.
- `shell-pattern`: interrupt elemental coherence, binding, or seam conditions.
- `constructed-pattern`: disable the script, engine, command structure, or body.
- `giant-memory`: destroy or separate every vessel through which the memory reconstructs itself.
- `infrastructure-office`: remove or lawfully replace the office, not merely its current manifestation.
- `abyssal-wound`: close the breach or contradiction that lets the creature recur.

## Family Rulings Already Locked

- [[Grobi Overview|Grobi]] are Wrath-rewritten life, not humans with damaged souls. Trolls are the rare stable fifth stage.
- [[Drakes Overview|Drakes]] are Menhir court-fauna. They are not Greed's followers and are not true dragons.
- [[True Dragons]] are unique Abyssal catastrophes, not a color-coded animal family.
- [[Vampire Origins|Vampires]] are humans whose real souls are held by Giant-derived blood liens.
- [[Ghouls]] are residue-born intelligences aligned with Gluttony's appetite economy; the original human soul has departed.
- [[Egg White Ecology|Driftkin]] are Drift-rewritten descendants of humans, without routable human souls.
- [[True Angels Overview|True angels]] are created heavenly spirits; [[Manifested Saints Overview|manifested saints]] are redeemed human souls. [[The Boatman]] is a unique created angel, while impersonal road mechanisms use `infrastructure-office`.
- A devil is a contractual mantle or office, not a biological species.

## Aberration Is a Diagnostic Tag

`Aberration` is not an origin section. It records a violation of body, identity, memory, space, time, ecology, or death. A Vortharan fleshwork, Astral route predator, or Nythalum machine may all be aberrant for different reasons while remaining in their true source folders.

## Creator and Public Names

Creator references may use recognizable terms such as angel, hydra, sphinx, troll, or elemental. Public canon should prefer regional names, folklore, disputed classifications, and the language of the culture encountering the creature. Pathfinder-specific names remain in [[Bestiary Translation Concordance|the authorial concordance]].

## Required Dossier Anatomy

Every mature family or creature dossier must state:

- the distinct forms catalogued by the dossier;
- origin and continuity;
- ecology and lifecycle;
- intelligence and moral agency;
- signs before contact;
- habitats and lair logic;
- encounter roles and tactics;
- weaknesses and permanent defeat;
- materials, remains, or salvage value;
- faction use and legal or religious response;
- regional names;
- at least three story uses.

## Navigation

- [[Bestiary MOC]]
- [[Bestiary Translation Concordance]]
- [[The Image, Soul, and Creaturely Continuity]]
- [[The Mundane Layer — Residue, Vermin, and the Delver Trade]]
- [[Creature Conditions and Templates]]
- [[The World Egg Cosmology]]
