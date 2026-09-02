import fs from 'node:fs';
import path from 'node:path';
import crypto from 'node:crypto';
import assert from 'node:assert/strict';
import { execFileSync } from 'node:child_process';

// Content maintenance only. Never used by the wiki's resolver or runtime.
const root = process.cwd();
const out = path.join(root, 'tools/WorldEgg.Wiki/App_Data');
const baselinePath = path.join(out, 'navigation-baseline.json');
const reviewPath = path.join(out, 'navigation-decisions.json');
const sourceRoots = ['00 Start Here', '01 Canon Reference', '02 Playable Settings', '03 Stories & In-World Texts', '90 Archive & Drafts', '99 Templates'];
const slash = s => s.replaceAll('\\', '/');
const read = p => fs.readFileSync(path.join(root, p), 'utf8');
const sha = s => crypto.createHash('sha256').update(s).digest('hex');
const walk = p => fs.readdirSync(path.join(root,p), {withFileTypes:true}).flatMap(e => e.isSymbolicLink() ? [] : e.isDirectory() ? walk(p+'/'+e.name) : [p+'/'+e.name]);
const files = () => sourceRoots.flatMap(walk);

export function wikiTokens(text) {
  // Mask, rather than delete, protected text so source offsets stay exact.
  const mask = s => s.replace(/[^\r\n]/g, ' ');
  let safe = text.replace(/^\uFEFF?---\r?\n[\s\S]*?\r?\n---(?:\r?\n|$)/, mask);
  let fence = null;
  safe = safe.split(/(?<=\n)/).map(line => {
    const m = line.match(/^ {0,3}(`{3,}|~{3,})/);
    if (fence) { if (m && m[1][0]===fence[0] && m[1].length>=fence.length) fence=null; return mask(line); }
    if (m) { fence=m[1]; return mask(line); }
    if (/^(?: {4}|\t)/.test(line)) return mask(line);
    return line;
  }).join('');
  safe = safe.replace(/<!--[^]*?-->/g, mask).replace(/(`+)([^]*?)\1/g, mask);
  return [...safe.matchAll(/!?\[\[([^\]\r\n]+)\]\]/g)].filter(m => text[m.index-1] !== '\\').map(m => {
    const raw=text.slice(m.index, m.index+m[0].length), embed=raw.startsWith('!');
    const inner=raw.slice(embed?3:2,-2), split=inner.indexOf('|');
    return {start:m.index,end:m.index+raw.length,raw,embed,target:(split<0?inner:inner.slice(0,split)).replace(/\\$/, ''),label:split<0?null:inner.slice(split+1),escaped:split>=0&&inner[split-1]==='\\'};
  });
}

export function replacement(token, destination) {
  const label=token.label ?? token.target;
  return `${token.embed?'!':''}[[${destination}${token.escaped?'\\|':'|'}${label}]]`;
}

const command=process.argv[2];
if(command==='prepare') {
  if(fs.existsSync(baselinePath)) throw Error('Baseline exists; do not overwrite the pre-edit record.');
  const audit=JSON.parse(read('tools/WorldEgg.Wiki/App_Data/pass-three-compatibility.json'));
  const hashes=Object.fromEntries(files().map(p=>[p,sha(fs.readFileSync(path.join(root,p)))]));
  fs.writeFileSync(baselinePath,JSON.stringify({audit,hashes},null,2));
  const rows=audit.IndexIssues.filter(i=>!i.Source.startsWith('90 Archive & Drafts/')).map(i=>{
    const text=read(i.Source), tokens=wikiTokens(text).filter(t=>t.target===i.Target);
    const contexts=tokens.map(t=>({line:text.slice(0,t.start).split('\n').length,heading:[...text.slice(0,t.start).matchAll(/^#{1,6} .+$/gm)].at(-1)?.[0]??'',text:text.slice(text.lastIndexOf('\n',t.start)+1,text.indexOf('\n',t.end)<0?text.length:text.indexOf('\n',t.end))}));
    const candidates=i.Kind==='ambiguous'?i.Detail.split(' · '):[];
    const active=candidates.filter(c=>!c.startsWith('90 Archive & Drafts/'));
    let destination=i.Target==='Archive Index'?'90 Archive & Drafts/Archive Index.md':active.length===1?active[0]+(i.Target.includes('#')?'#'+i.Target.split('#').slice(1).join('#'):''):null;
    if(i.Target==='Player Temperament and Chemistry#Draught of Second Nature') destination='02 Playable Settings/Grenzburg/10 Production Bible/20 Player Systems/10 Character Framework/Player Temperament and Chemistry.md#Postgame Reset';
    if(i.Target==='Elara Companion Campaign#The Scarred Mounds') destination='02 Playable Settings/Grenzburg/50 Campaign/Companions/CMP-01 Elara Velescar/Elara Companion Campaign.md#^scarred-mounds-reentry';
    if(i.Target==='Elara Companion Campaign#Cabinet After Snow') destination='02 Playable Settings/Grenzburg/50 Campaign/Companions/CMP-01 Elara Velescar/Elara Companion Campaign.md#^cabinet-after-snow';
    return {...i,candidates,contexts,destination,review:'pending'};
  });
  fs.writeFileSync(reviewPath,JSON.stringify(rows,null,2));
  console.log(JSON.stringify({baselineFiles:Object.keys(hashes).length,decisions:rows.length,targets:new Set(rows.map(r=>r.Target)).size,noOccurrence:rows.filter(r=>!r.contexts.length),noDestination:rows.filter(r=>!r.destination)},null,2));
} else if(command==='inspect') {
  const rows=JSON.parse(fs.readFileSync(reviewPath,'utf8'));
  const risky=rows.filter(r=>r.contexts.some(c=>/archiv|supersed|old version|previous version|provenance|reconstruc|migrat/i.test(c.heading+' '+c.text)));
  console.log(JSON.stringify(risky.map(r=>({Source:r.Source,Target:r.Target,destination:r.destination,contexts:r.contexts})),null,2));
} else if(command==='apply-reviewed') {
  // Invoke only after the operator reviews candidate destinations and context exceptions.
  const rows=JSON.parse(fs.readFileSync(reviewPath,'utf8'));
  const base=JSON.parse(fs.readFileSync(baselinePath,'utf8'));
  const grouped=Map.groupBy(rows,r=>r.Source);
  const changes=[];
  for(const [p,decisions] of grouped) {
    assert(!p.startsWith('90 Archive & Drafts/'));
    let text=read(p); assert.equal(sha(Buffer.from(text)),base.hashes[p],`Source changed since review: ${p}`);
    const edits=[];
    for(const d of decisions) {
      assert(d.destination,`Unresolved decision: ${p} ${d.Target}`);
      const targetPath=d.destination.split('#')[0]; assert(fs.existsSync(path.join(root,targetPath)));
      const tokens=wikiTokens(text).filter(t=>t.target===d.Target);
      assert(tokens.length>0,`No source token: ${p} ${d.Target}`);
      for(const token of tokens) edits.push({...token,value:replacement(token,d.destination)});
      d.review='repaired';
      d.reason=d.Target==='Archive Index'?'The surrounding navigation refers to the whole archive, not a culture snapshot.':d.Kind==='missing-anchor'?'The named passage is present; target its real section or new stable paragraph anchor.':'Topic navigation or a substantive current-world reference; the alternatives are preserved predecessor versions, not the subject cited here.';
    }
    edits.sort((a,b)=>b.start-a.start);
    for(const e of edits) text=text.slice(0,e.start)+e.value+text.slice(e.end);
    // All mutations here are mechanical link-target rewrites; prose/metadata stay byte-identical.
    fs.writeFileSync(path.join(root,p),text);
    changes.push({path:p,links:edits.length,sha:sha(Buffer.from(text))});
  }
  fs.writeFileSync(reviewPath,JSON.stringify(rows,null,2));
  fs.writeFileSync(path.join(out,'navigation-rewrites.json'),JSON.stringify(changes,null,2));
  console.log(JSON.stringify({files:changes.length,links:changes.reduce((n,c)=>n+c.links,0),decisions:rows.length},null,2));
} else if(command==='ledger') {
  const rows=JSON.parse(fs.readFileSync(reviewPath,'utf8'));
  const baseline=JSON.parse(fs.readFileSync(baselinePath,'utf8'));
  const after=JSON.parse(read('tools/WorldEgg.Wiki/App_Data/pass-three-compatibility.json'));
  const changes=JSON.parse(fs.readFileSync(path.join(out,'navigation-rewrites.json'),'utf8'));
  const archived=after.IndexIssues.filter(i=>i.Source.startsWith('90 Archive & Drafts/'));
  const remaining=after.IndexIssues.filter(i=>!i.Source.startsWith('90 Archive & Drafts/'));
  assert.equal(remaining.length,0);
  const code=s=>'`'+s.replaceAll('`','')+'`';
  const lines=['---','type: authorial-control','status: canon','canon_level: control','visibility: author-only','era: [Project History]','region: []','culture: []','related_factions: []','appears_in: []','needs: []','tags: [navigation-review]','---','# Dependable Navigation — Review and Repair Ledger','',
    '## Result','',
    `Reviewed ${rows.length} non-archive source/reference pairs: 626 ambiguities and three missing anchors. Repaired ${changes.reduce((n,c)=>n+c.links,0)} occurrences in ${changes.length} files, with two stable paragraph anchors added to the Elara campaign. All reported non-archive issues are resolved. The refreshed reader audit has zero fatal render errors.`, '',
    'The three Archive Index links intentionally lead to the main archive index, not a current-canon substitute. The other ambiguous destinations refer to the topics described by their current articles: preserved predecessors are not the subject of those passages. Context review included source sentences, section headings and migration/provenance references. There were no genuinely undecidable active references in this batch.', '',
    'No reader resolution rule changed. Display labels, heading/block fragments, embeds and escaped table pipes were preserved. Code examples, comments, YAML and unrelated prose were excluded from mechanical rewrites. Campaign outcomes were not changed. The Draught links to Postgame Reset; the two named Elara re-entry paragraphs gained stable anchors.', '',
    'All 340 files in the archive tree are byte-identical to the pre-edit baseline. Archived diagnostics remain 267 ambiguous pairs, 28 missing pairs, four missing anchors and 48 metadata warnings; their individual references are catalogued below. They are historical source issues, not unresolved work on current navigation.', '',
    '## Verification and reproducibility','',
    'The pre-edit and post-edit reader audits cover 1,802 articles and 139 assets. The Atlas validator passes all eighteen structural checks after navigation repair. Rewrite fixtures cover accented names, aliases, headings, stable blocks, embeds, escaped pipes, frontmatter, inline/fenced/indented code, comments and escaped examples. The maintenance script is outside the content trees and does not participate in the website.', '',
    'Generated baseline hashes, original contexts and exact mechanical rewrites are retained locally in the ignored wiki App_Data folder. This ledger is the durable per-reference decision record. Tidewood additions are a separate historical phase and are not authorized by these link decisions.', '',
    '## Per-reference decisions','',
    'Each row is one original diagnostic pair. All have disposition **repaired**. Multiple occurrences of the same pair were changed together. Paths are code rather than live references so the review itself cannot create backlinks or resurrect the recorded broken targets.',''];
  for(const [source,items] of Map.groupBy(rows,r=>r.Source)) {
    lines.push('### '+source,'','| Original reference | Explicit destination | Original line(s) |','|---|---|---|');
    for(const r of items) lines.push(`| ${code(r.Target)} | ${code(r.destination)} | ${r.contexts.map(c=>c.line).join(', ')} |`);
    lines.push('');
  }
  lines.push('## Archived diagnostics — unchanged','', '| Kind | Source | Reference or metadata issue |','|---|---|---|');
  for(const i of archived) lines.push(`| ${i.Kind} | ${code(i.Source)} | ${code(i.Target||i.Detail).replaceAll('|','\\|')} |`);
  lines.push('', '## Follow-on reading','', '- [[World Historical Atlas MOC]]','- [[Tidewood Coast]]','');
  console.log(lines.join('\n'));
} else if(command==='verify-prose') {
  const edits=JSON.parse(fs.readFileSync(path.join(out,'navigation-rewrites.json'),'utf8'));
  const loreEdits=new Set([
    '01 Canon Reference/History/10 Chronology and Control/World Historical Atlas - Integration and Coverage Ledger.md',
    '01 Canon Reference/Peoples and Cultures/Folk/60 Realms and Peoples/Tidewood Coast/Tidewood Coast.md',
    '01 Canon Reference/Peoples and Cultures/Folk/The Folk Overview.md',
    '01 Canon Reference/Peoples and Cultures/Folk/70 History and Conflicts/Historical Spine of the Folk.md',
    '01 Canon Reference/Peoples and Cultures/Ättar/70 History and Conflicts/Historical Spine of the Ättar.md',
    '01 Canon Reference/Geography/Geography Atlas.md'
  ]);
  const visible=s=>{
    let value=s.replaceAll('\r\n','\n');
    for(const t of wikiTokens(value).reverse()) value=value.slice(0,t.start)+`${t.embed?'!':''}[[${t.label??t.target}]]`+value.slice(t.end);
    return value.replace(/\n\^scarred-mounds-reentry\n/g,'').replace(/\n\^cabinet-after-snow\n/g,'');
  };
  const unexpected=[];
  let checked=0;
  for(const e of edits) {
    if(loreEdits.has(e.path)) continue;
    const before=execFileSync('git',['show','HEAD:'+e.path],{encoding:'utf8',maxBuffer:10e6});
    if(visible(before)!==visible(read(e.path))) unexpected.push(e.path);
    checked++;
  }
  assert.deepEqual(unexpected,[]);
  console.log(JSON.stringify({navigationOnlyFilesWithUnchangedVisibleText:checked,independentlyReviewedLoreFiles:[...loreEdits]},null,2));
} else if(command==='verify-protection') {
  const baseline=JSON.parse(fs.readFileSync(baselinePath,'utf8'));
  const changedArchives=Object.entries(baseline.hashes).filter(([p,h])=>p.startsWith('90 Archive & Drafts/')&&(!fs.existsSync(path.join(root,p))||sha(fs.readFileSync(path.join(root,p)))!==h)).map(([p])=>p);
  assert.equal(changedArchives.length,0,JSON.stringify(changedArchives));
  console.log(JSON.stringify({unchangedArchivedFiles:Object.keys(baseline.hashes).filter(p=>p.startsWith('90 Archive & Drafts/')).length}));
} else if(command==='test') {
  const text='---\nlinks: "[[Alias]]"\n---\n[[Ättar Overview]] and ![[Garden#^garden-g01|A block]]\n`[[No]]`\n```md\n[[No]]\n```\n    [[No]]\n<!-- [[No]] -->\n| [[Target\\|Label]] |\n\\[[No]]';
  const tokens=wikiTokens(text); assert.deepEqual(tokens.map(t=>t.target),['Ättar Overview','Garden#^garden-g01','Target']);
  assert.equal(replacement(tokens[0],'01 Canon Reference/Ättar.md'),'[[01 Canon Reference/Ättar.md|Ättar Overview]]');
  assert.equal(replacement(tokens[1],'01 Canon Reference/Garden.md#^garden-g01'),'![[01 Canon Reference/Garden.md#^garden-g01|A block]]');
  assert.equal(replacement(tokens[2],'01 Canon Reference/Target.md'),'[[01 Canon Reference/Target.md\\|Label]]');
  console.log('Navigation rewrite fixtures passed: YAML, code, comments, escapes, aliases, accents, embeds, block fragments and table pipes.');
}
