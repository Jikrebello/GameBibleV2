import fs from 'node:fs';
import path from 'node:path';
import crypto from 'node:crypto';
import assert from 'node:assert/strict';
import { execFileSync } from 'node:child_process';

// Content-maintenance utility; this is independent of the wiki application.
const root = process.cwd();
const control = '01 Canon Reference/History/10 Chronology and Control/';
const ledgerPath = control + 'World Historical Atlas - Integration and Coverage Ledger.md';
const inventoryPath = control + 'World Encyclopedia - Article and Research Inventory.md';
const programmePath = control + 'World Encyclopedia - Revision and Expansion Programme.md';
const guidePath = control + 'World Egg Encyclopedia - Editorial Style Guide.md';
const baselinePath = 'tools/WorldEgg.Wiki/App_Data/encyclopedia-package-one-baseline.json';
const reportPath = 'tools/WorldEgg.Wiki/App_Data/encyclopedia-package-one-validation.json';
const entrances = [
  '01 Canon Reference/History/World Historical Atlas MOC.md',
  'Ahl-e-Ahd/The Ahl-e-Ahd Overview.md', 'Atherian Empire/The Atherian Empire Overview.md',
  'Ättar/Ättar Overview.md', 'Eclessia/Eclessia Overview.md', 'Folk/The Folk Overview.md',
  'Jirahar/The Jirahar Overview.md', 'Nsizwa/The Nsizwa Overview.md',
  'Sestaran Concord/The Sestaran Concord Overview.md', 'Tarkhan/The Tarkhan Tribes Overview.md',
  'Thalmyric Empire/Thalmyric Empire Overview.md', 'Velian/Velian Culture Overview.md',
].map(p => p.startsWith('01 ') ? p : '01 Canon Reference/Peoples and Cultures/' + p);
const read = p => fs.readFileSync(path.join(root, p), 'utf8');
const hash = p => crypto.createHash('sha256').update(fs.readFileSync(path.join(root, p))).digest('hex');
function files(dir) {
  return fs.readdirSync(path.join(root, dir), { withFileTypes: true }).flatMap(e => {
    const p = dir + '/' + e.name;
    return e.isDirectory() ? files(p) : [p];
  });
}
const trees = fs.readdirSync(root, { withFileTypes: true }).filter(e => e.isDirectory() && /^\d\d /.test(e.name)).map(e => e.name);
const content = () => trees.flatMap(files).sort();
const fm = text => text.match(/^---\r?\n[\s\S]*?\r?\n---(?:\r?\n|$)/)?.[0] ?? '';
const cell = s => String(s).replaceAll('|', '\\|').replaceAll('\n', ' ');
const wiki = (p, label = path.posix.basename(p, '.md')) => `[[${p}|${label}]]`;

function table(text, header) {
  const lines = text.split(/\r?\n/);
  const start = lines.findIndex(l => l.startsWith(header));
  assert(start >= 0, `Missing table: ${header}`);
  const rows = [];
  for (const line of lines.slice(start + 2)) {
    if (!line.startsWith('|')) break;
    // Protect display-label pipes in wikilinks before splitting Markdown cells.
    rows.push(line.replace(/\[\[[\s\S]*?\]\]/g, w => w.replaceAll('|', '\u0001'))
      .split('|').slice(1, -1).map(s => s.trim().replaceAll('\u0001', '|')));
  }
  return rows;
}

const culturePackage = { 'Ahl-e-Ahd': 6, 'Atherian Empire': 2, 'Ättar': 5, Eclessia: 4,
  Folk: 5, Jirahar: 6, Nsizwa: 7, 'Sestaran Concord': 4, Tarkhan: 6, 'Thalmyric Empire': 4, Velian: 6 };
function packageFor(p, text = '') {
  const n = path.posix.basename(p);
  if (entrances.includes(p)) return 1;
  if (/World Encyclopedia|Editorial Style Guide|World Historical Atlas MOC|Timeline MOC|Integration and Coverage Ledger/.test(n)) return 1;
  if (/Protected Questions|Continuity|Soul Routing|Image, Soul/.test(n)) return 8;
  if (/Last Houses|Cypress|Country Beneath the Rains|Distant Human|Nsizwa/.test(n)) return 7;
  if (/^GS-\d+/.test(n)) return Number(n.match(/^GS-(\d+)/)[1]) <= 10 ? 3 : 4;
  if (/^UH-\d+/.test(n)) return { 1: 8, 2: 2, 3: 2, 4: 3, 5: 4, 6: 4 }[Number(n.match(/^UH-(\d+)/)[1])];
  if (/^HC-|Heavenly|Great Saints and Sinners/.test(n)) return 8;
  if (/Peoples in the World Historical Atlas|Additional Mortal Lives/.test(n)) return 2;
  if (p.includes('/History/20 Prehistory/')) return 8;
  if (p.includes('/History/30 Exodus and First Civilizations/')) return /Exodus|Sojourn|Unbinding/.test(n) ? 8 : 2;
  if (p.includes('/History/40 Atherian Imperial Age/')) return 2;
  if (p.includes('/History/50 Redeemer and Conversion/')) return 3;
  if (p.includes('/History/60 Fall and Successor Empires/')) return /Invasion and the Fall/.test(n) ? 3 : 4;
  const c = p.match(/Peoples and Cultures\/([^/]+)/)?.[1];
  if (c) return culturePackage[c] ?? 9;
  if (p.includes('/90 Distant and Otherworld Histories/')) return 8;
  if (p.includes('/80 Myths and Legendary Histories/')) {
    const date = text.match(/\*\*When[^\n]*|era:[^\n]*|Date[^\n]*/)?.[0] ?? text.slice(0, 1500);
    return inferredPackage(date + ' ' + text.slice(0, 1100));
  }
  if (/The Grey Sweat|Reconquest|Great Split|Held Proofs|High Noon|Qarath|Present-Day|Freeflame|Korrheim Accord/.test(n)) return 4;
  if (/Atherian|Age of Stars|City-States|Hearths|Two Fissions|Scattering|First Kings/.test(n)) return 2;
  if (/Redeemer|Conversion|Long Frontier|Underground|Unsealing|Covenant/.test(n)) return 3;
  if (/Creation|Rebellion|Giant|Chains|Exodus|Glass Sojourn|Saints and Sinners|Heaven|Menhir|Idol|Patron|Infernal|Shell|Nythalum|Dragon|Cosmology/.test(p)) return 8;
  if (p.includes('/60 Fall and Reconquest/') || p.includes('/70 Later History and Present Day/')) return 4;
  if (p.includes('/50 Redeemer and Conversion/')) return 3;
  return 9;
}
function inferredPackage(s) {
  if (/Nsizwa|Last Houses|Cypress|distant mountain|Beneath the Rains/i.test(s)) return 7;
  if (/Giant|Chains|Unbinding|Exodus|Glass Sojourn/i.test(s)) return 8;
  if (/Scattering|Hearths|City-States|Stars|\bBR\b/i.test(s)) return 2;
  if (/Underground|Conversion|Long Frontier|Redeemer/i.test(s)) return 3;
  if (/Glory/i.test(s)) return 2;
  if (/Fall|Reconquest|Split|High Noon|Grey Sweat|Reformation|Present|1360/i.test(s)) return 4;
  return 8;
}

function snapshot() {
  assert(!fs.existsSync(path.join(root, baselinePath)), 'Baseline already exists; never overwrite the starting state.');
  const all = content();
  const texts = Object.fromEntries([...entrances, ledgerPath, guidePath].map(p => [p, read(p)]));
  const audit = 'tools/WorldEgg.Wiki/App_Data/pass-three-compatibility.json';
  const data = { timestamp: new Date().toISOString(), head: execFileSync('git', ['rev-parse', 'HEAD'], { encoding: 'utf8' }).trim(),
    workingState: execFileSync('git', ['status', '--short'], { encoding: 'utf8' }),
    hashes: Object.fromEntries(all.map(p => [p, hash(p)])), texts,
    audit: fs.existsSync(path.join(root, audit)) ? JSON.parse(read(audit)) : null };
  fs.mkdirSync(path.dirname(path.join(root, baselinePath)), { recursive: true });
  fs.writeFileSync(path.join(root, baselinePath), JSON.stringify(data, null, 2));
  console.log(JSON.stringify({ snapshot: baselinePath, files: all.length, capturedTexts: Object.keys(texts).length, head: data.head }));
}

function inventory() {
  const canonical = files('01 Canon Reference').filter(p => p.endsWith('.md'));
  const docs = new Map(canonical.map(p => [p, read(p)]));
  const research = files('90 Archive & Drafts/10 Research').filter(p => p.endsWith('.md'));
  function resolve(ref, candidates = canonical) {
    const target = ref.match(/\[\[([^\]|#]+)/)?.[1];
    assert(target, `No linked destination in ${ref}`);
    const hits = candidates.filter(p => p === target || p === target + '.md' || path.posix.basename(p, '.md') === target);
    assert.equal(hits.length, 1, `Expected one destination for ${target}: ${hits.join(', ')}`);
    return hits[0];
  }
  function explicit(ref, candidates = canonical) {
    return ref.replace(/\[\[([^\]]+)\]\]/g, (_, inside) => {
      const [link, label] = inside.split('|');
      const [title, ...fragments] = link.split('#');
      const p = resolve(`[[${title}]]`, candidates);
      return wiki(p + (fragments.length ? '#' + fragments.join('#') : ''), label ?? title);
    });
  }
  const ledger = read(ledgerPath);
  const garden = table(ledger, '| Garden ID |');
  const sources = table(ledger, '| Source dossier |');
  const identifiers = table(ledger, '| Source ID |');
  const reserves = table(ledger, '| Reserve entry |');
  assert.equal(garden.length, 75); assert.equal(sources.length, 57);
  assert.equal(identifiers.length, 315); assert.equal(reserves.length, 204);
  const gardenHomes = new Map(garden.map(r => [resolve(r[1]), { package: inferredPackage(r.slice(2, 6).join(' ')), row: r }]));
  function primary(p) { return tidewood(p) ? 5 : gardenHomes.get(p)?.package ?? packageFor(p, docs.get(p)); }
  function related(p, pkg) {
    const c = p.match(/Peoples and Cultures\/([^/]+)/)?.[1];
    const result = new Set([pkg]);
    if (pkg === 1) result.add(c ? culturePackage[c] : 9);
    if (c === 'Atherian Empire' || c === 'Velian') result.add(3);
    if (c && ['Folk', 'Ättar', 'Jirahar', 'Ahl-e-Ahd', 'Tarkhan'].includes(c)) result.add(2);
    if (pkg === 7) result.add(8);
    const metadata = fm(docs.get(p) ?? '');
    const regionalPackages = [[/Folk|Ättar|Tidewood|Gale-Crown|Green March/, 5], [/Jirahar|Ahdari|Ahl-e-Ahd|Tarkhan|Velian|Covenant/, 6], [/Ecless|Thalmy|Sestara|Vesari/, 4], [/Nsizwa|Last Houses|Country Beneath/, 7]];
    for (const [pattern, number] of regionalPackages) if (pattern.test(metadata)) result.add(number);
    if (p.includes('/Creatures/') || p.includes('/Magic & Systems/')) result.add(8);
    if (/Peoples in the World Historical Atlas|Additional Mortal Lives/.test(p)) [3, 4, 5, 6, 7, 8].forEach(n => result.add(n));
    if (/^GS-/.test(path.posix.basename(p))) result.add(8);
    if (/Saint|Sinner|Menhir|Idol|Patron|Infernal|Shell|Nythalum/.test(p)) {
      result.add(8); result.add(3); result.add(4);
    }
    result.delete(pkg);
    return [...result].sort().join(', ') || '—';
  }
  const tidewood = p => p.includes('/Tidewood Coast/') || /\/(History of the Tidewood Coast|The Court of Salt and Teeth)\.md$/.test(p);
  const sourceByHost = new Map();
  for (const r of sources) {
    const p = resolve(r[1]);
    sourceByHost.set(p, [...(sourceByHost.get(p) ?? []), explicit(r[0], research)]);
  }
  const lines = [
    '---', 'type: reference', 'status: canon', 'canon_level: core', 'visibility: author-only',
    'era: [All Eras]', 'region: []', 'culture: []', 'related_factions: []', 'appears_in: []', 'needs: []',
    'aliases: []', 'tags: [world-historical-atlas, editorial-control]', '---',
    '# World Encyclopedia — Article and Research Inventory', '',
    `Companion to ${wiki(programmePath)}. Generated by the content-maintenance inventory command; the schedule describes required work, not a claim that every article has already received close editorial review.`, '',
    'Every canonical Markdown article has one primary package. Related packages are cross-reading obligations, not duplicate assignments. The research tables preserve the integration ledger’s decisions verbatim; their overlapping control records are not additional historical events. Entries marked protected remain protected when their package is delivered. Grafts develop their linked host.', '',
    `Coverage: **${canonical.length} current canonical articles; 75 Garden destinations; 57 source dossiers; 315 reviewed identifiers; 204 distinct reserve records.**`, '',
    'Source precedence: controlling canon → final collision ruling → source-fidelity hardening → human-coherence ruling → approved narrative voice. The integration ledger identifies the incorporated version. Comparative studies without a selected descendant supply reference only.', '',
    '## Article schedule', '',
    'Work is assigned by subject and article function: overview/history/region development receives both voice and depth work; supporting reference prose receives voice revision, with its recorded needs included; received tales and approved Tidewood prose are preserved. Individual contradictions discovered during a scheduled package must be recorded before changing a fact.', '',
  ];
  const counts = {};
  for (const area of [...new Set(canonical.map(p => p.split('/')[1]))].sort()) {
    lines.push(`### ${area}`, '', '| Article / existing destination | Work | Primary package | Related packages | Controlling sources and incorporated revisions | Dependency / boundary |', '|---|---|---|---|---|---|');
    for (const p of canonical.filter(p => p.split('/')[1] === area).sort()) {
      const text = docs.get(p), meta = fm(text), pkg = primary(p);
      counts[pkg] = (counts[pkg] ?? 0) + 1;
      const author = /visibility: author-only/.test(meta);
      const technical = author && /Register|Ledger|Review|Framework|Continuity|Doctrine|Boundaries|MOC|Index|Concordance|Protected Questions|Style Guide|Programme|Inventory|Seed Garden|Spine of the Known World/.test(path.posix.basename(p));
      const received = /^G-\d+|^HC-/.test(path.posix.basename(p)) || /Monomyth|Religious Myths/.test(p);
      const development = /Overview|Historical|History|60 Realms|Foundations|Daily Life|Lives of|Wider World/.test(p);
      const work = tidewood(p) ? 'preservation — approved Tidewood' : entrances.includes(p) ? 'voice revision — Package 1 completed; depth in related package' : technical || received ? 'preservation — controls / received text; framing reviewed in package' : development ? 'both — voice and historical explanation' : 'voice revision; expansion of recorded needs only';
      const needs = meta.match(/needs:\s*([\s\S]*?)(?=\n[a-z_]+:|\n---)/)?.[1]?.trim();
      let dependency = needs && needs !== '[]' ? `Existing need: ${needs.replaceAll('\n', ' ')}` : received ? 'Preserve tale, identity and established truth level; expand surrounding history only.' : author ? 'Preserve controlling rulings; record substantive reconciliation separately.' : 'Existing article and linked supporting history are the factual baseline; no open choice asserted by this inventory.';
      if (p.includes('Protected Questions')) dependency = 'Protected Weirds, erasures, sovereign changes and post-1360 outcomes remain unresolved.';
      const parents = [...text.matchAll(/\[\[([^\]|#]*(?:Historical Spine|Historical Atlas|Canon Register)[^\]|#]*)(?:#[^\]|]*)?(?:\|[^\]]*)?\]\]/g)].map(m => m[0]);
      const resolvedParents = [...new Set(parents)].filter(r => { try { resolve(r); return true; } catch { return false; } }).slice(0, 3).map(r => explicit(r));
      const evidence = [...resolvedParents, ...(sourceByHost.get(p) ?? [])].join('; ') || 'Current article and its cited canon; ' + wiki(ledgerPath, 'incorporated Atlas rulings');
      lines.push(`| ${wiki(p)} | ${work} | ${pkg} | ${related(p, pkg)} | ${evidence} | ${cell(dependency)} |`);
    }
    lines.push('');
  }
  lines.push('## Seventy-five Garden destinations', '', '| ID | Established article | Primary package | Related packages | Date / sequence; region; bearer | Authority retained |', '|---|---|---|---|---|---|');
  for (const r of garden) {
    const p = resolve(r[1]), pkg = primary(p);
    lines.push(`| ${r[0]} | ${explicit(r[1])} | ${pkg} | ${related(p, pkg)} | ${r.slice(2, 5).map(cell).join('; ')} | ${cell(r[6])} |`);
  }
  lines.push('', '## Source-dossier destinations', '', '| Source dossier | Established destination | Primary package | Required work / incorporated use |', '|---|---|---|---|');
  for (const r of sources) lines.push(`| ${explicit(r[0], research)} | ${explicit(r[1])} | ${primary(resolve(r[1]))} | ${cell(r[2])}; preserve research, develop selected host only. |`);
  lines.push('', '## Reviewed research identifiers', '', '| Source ID | Lead / identity | Established destination | Primary package | Final ruling / work | Dependency and authority |', '|---|---|---|---|---|---|');
  for (const r of identifiers) lines.push(`| ${r[0]} | ${cell(r[1])} | ${explicit(r[4])} | ${primary(resolve(r[4]))} | ${cell(r[3])}; ${/protected|reject/.test(r[3]) ? 'preservation' : 'voice and explanation at established host'} | ${cell(r[5])}; ${/protected/.test(r[3]) ? 'do not establish the withheld fact' : 'final identity and placement are already incorporated'} |`);
  lines.push('', '## Reserve closure carried forward', '', '| Reserve entry | Earlier status | Final ruling retained | Established destination | Primary package | Action in delivery |', '|---|---|---|---|---|---|');
  for (const r of reserves) lines.push(`| ${cell(r[0])} | ${cell(r[1])} | ${cell(r[2])} | ${explicit(r[3])} | ${primary(resolve(r[3]))} | ${/protected|reject/.test(r[2]) ? 'Preserve the explicit boundary; no resurrection of a rejected identity.' : /graft/.test(r[2]) ? 'Enrich this host; do not create a second event or biography.' : 'Develop the already selected event at this destination.'} |`);
  lines.push('', '## Unnumbered material and complete research coverage', '',
    'The eighteen lesser Giant polities and five ancient actor positions belong to **Lesser Crowns of the Giant Age** (Package 8). The twelve Praise entries retain their existing four standalone / eight graft destinations through the reviewed identifier table. The twenty Primarch source studies retain fourteen Great Saints and Sinners, four ordinary mortal traditions, and two protected erased-person studies; earthly contexts are developed in Packages 3–4, independent afterlives in Package 8. The sixteen former heavenly holds retain fourteen local traditions and two protected commission proposals in Package 8.', '',
    'All other source comparisons linked by the research MOC retain reference status unless the Atlas ledger already assigns a descendant. The 57-dossier register is the authoritative inventory of mapped dossiers. Superseded drafts, raw comparisons and earlier seed matrices remain unchanged in the research archive; none receives a new canonical identity through this schedule.', '',
    '## Package counts', '', '| Package | Primary article assignments |', '|---|---|',
    ...Object.keys(counts).sort().map(k => `| ${k} | ${counts[k]} |`), '',
    `Inventory regenerated from ${wiki(ledgerPath)}. Run the inventory command after adding a canonical article so the schedule remains complete.`, '');
  fs.writeFileSync(path.join(root, inventoryPath), lines.join('\n'));
  console.log(JSON.stringify({ inventory: inventoryPath, canonical: canonical.length, garden: garden.length, sources: sources.length, identifiers: identifiers.length, reserves: reserves.length, counts }));
}

async function check() {
  const baseline = JSON.parse(read(baselinePath));
  const allowed = new Set([...entrances, ledgerPath, guidePath]);
  const changed = Object.keys(baseline.hashes).filter(p => !fs.existsSync(path.join(root, p)) || hash(p) !== baseline.hashes[p]);
  assert.deepEqual(changed.filter(p => !allowed.has(p)), [], 'Unrelated source files changed');
  for (const p of entrances) {
    assert.equal(fm(read(p)), fm(baseline.texts[p]), `Frontmatter changed: ${p}`);
    const oldBlocks = baseline.texts[p].match(/\^[a-z0-9-]+\s*$/gm) ?? [];
    for (const b of oldBlocks) assert(read(p).includes(b.trim()), `Lost stable block ${p}: ${b}`);
  }
  const inv = read(inventoryPath), current = files('01 Canon Reference').filter(p => p.endsWith('.md'));
  const articleSection = inv.split('## Article schedule')[1].split('## Seventy-five Garden destinations')[0];
  for (const p of current) assert.equal(articleSection.split('\n').filter(line => line.startsWith(`| [[${p}|`)).length, 1, `Missing/duplicate article assignment: ${p}`);
  const issueKeys = audit => (audit.IndexIssues ?? []).map(i => JSON.stringify([i.Kind, i.Source, i.Target, i.Detail])).sort();
  const baselineIssues = issueKeys(baseline.audit);
  const afterAudit = JSON.parse(read('tools/WorldEgg.Wiki/App_Data/pass-three-compatibility.json'));
  const afterIssues = issueKeys(afterAudit);
  const changedIssues = [...afterIssues.filter(i => !baselineIssues.includes(i)), ...baselineIssues.filter(i => !afterIssues.includes(i))];
  assert.equal(changedIssues.length, 0, 'Changed compatibility diagnostics: ' + changedIssues.join('\n'));
  assert.equal(afterAudit.FatalReaderErrors, 0);
  assert.deepEqual(afterAudit.SourceFilesChangedDuringAudit, []);
  const http = await Promise.all(entrances.map(async p => {
    const response = await fetch('http://localhost:5271/wiki?path=' + encodeURIComponent(p));
    assert.equal(response.status, 200, `HTTP failure: ${p}`);
    const html = (await response.text()).replace(/&#x([a-f0-9]+);/gi, (_, n) => String.fromCodePoint(parseInt(n, 16)))
      .replace(/&#([0-9]+);/g, (_, n) => String.fromCodePoint(Number(n))).replaceAll('&amp;', '&');
    const title = read(p).match(/^# (.+)$/m)[1].trim();
    assert(html.includes(title), `Rendered title missing: ${p}`);
    return { path: p, status: response.status, titlePresent: true };
  }));
  const report = { changed, newContent: content().filter(p => !(p in baseline.hashes)), canonicalArticles: current.length,
    entrances: entrances.length, metadataPreserved: true, unrelatedSourcesUnchanged: true,
    baselineIssues, afterIssues, diagnosticsUnchanged: true, noRenderingErrors: true, http };
  fs.writeFileSync(path.join(root, reportPath), JSON.stringify(report, null, 2));
  console.log(JSON.stringify({ ...report, baselineIssues: undefined, afterIssues: undefined }));
}
const command = process.argv[2];
if (command === 'snapshot') snapshot();
else if (command === 'inventory') inventory();
else if (command === 'check') await check();
else throw new Error('Use snapshot, inventory or check.');
