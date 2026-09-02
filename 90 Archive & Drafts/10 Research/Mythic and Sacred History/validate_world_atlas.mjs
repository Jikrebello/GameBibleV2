import fs from 'node:fs';
import path from 'node:path';
import { execFileSync } from 'node:child_process';

const root = process.cwd();
const slash = p => p.replaceAll('\\', '/');
const walk = dir => fs.readdirSync(dir, {withFileTypes: true}).flatMap(e =>
  ['.git', '.obsidian', 'node_modules'].includes(e.name) ? [] :
  e.isDirectory() ? walk(path.join(dir, e.name)) :
  e.name.endsWith('.md') ? [slash(path.relative(root, path.join(dir, e.name)))] : []);
const files = walk(root);
const read = p => fs.readFileSync(p, 'utf8').replaceAll('\r\n', '\n');
const byName = new Map();
for (const p of files) {
  const key = path.basename(p, '.md').toLowerCase();
  byName.set(key, [...(byName.get(key) || []), p]);
}
const changed = execFileSync('git', ['-c', 'core.safecrlf=false', 'diff', '--name-only', '-z'], {encoding:'utf8'}).split('\0').filter(Boolean).map(slash);
const added = execFileSync('git', ['ls-files', '--others', '--exclude-standard', '-z'], {encoding:'utf8'}).split('\0').filter(Boolean).map(slash);
const touched = [...new Set([...changed, ...added])].filter(p=>p.endsWith('.md'));
const links = s => [...s.matchAll(/\[\[([^\]\n]+)\]\]/g)].map(m=>m[1].split('|')[0].trim());
const cache = new Map();
const body = p => {if(!cache.has(p))cache.set(p,read(p)); return cache.get(p);};
const quote = String.fromCharCode(96);
const cleanHeading = s => s.replace(/[*_]/g,'').replaceAll(quote,'').trim().toLowerCase();
const broken = [];
const malformed = [];
for (const p of touched) {
  const s = body(p);
  if (!/^---\n[\s\S]*?\n---(?:\n|$)/.test(s)) malformed.push({p, problem:'frontmatter missing'});
  if (/^\s*undefined\s*$|\[object Object\]|^#{1,6}\s*$/m.test(s)) malformed.push({p, problem:'generation artifact'});
  let old = '';
  if(!added.includes(p)) {try {old=execFileSync('git',['show','HEAD:'+p],{encoding:'utf8',maxBuffer:5e6});} catch{}}
  const previous = new Set(links(old));
  for (const target of new Set(links(s))) {
    if(previous.has(target))continue;
    const hash = target.indexOf('#');
    const name = (hash<0 ? target : target.slice(0,hash)).replace(/\.md$/i,'');
    const fragment = hash<0 ? '' : target.slice(hash+1);
    const direct = name ? [name+'.md',slash(path.join(path.dirname(p),name+'.md'))] : [p];
    let candidates = direct.filter(f=>files.includes(f));
    if(!candidates.length&&name)candidates=byName.get(name.toLowerCase())||[];
    if(!candidates.length){broken.push({p,target,problem:'file'});continue;}
    if(fragment.startsWith('^')) {
      if(!candidates.some(f=>body(f).split('\n').some(l=>l.trim()===fragment)))
        broken.push({p,target,problem:'block'});
    } else if(fragment) {
      if(!candidates.some(f=>[...body(f).matchAll(/^#{1,6}\s+(.+)$/gm)].some(m=>cleanHeading(m[1])===cleanHeading(fragment))))
        broken.push({p,target,problem:'heading'});
    }
  }
}
const history='01 Canon Reference/History/';
const garden=body(history+'10 Chronology and Control/The Historical Seed Garden.md');
const mythFiles=files.filter(p=>p.startsWith(history+'80 Myths and Legendary Histories/G-'));
const gardenIds=[...garden.matchAll(/^\^garden-g(\d{2})\s*$/gm)].map(m=>Number(m[1]));
const articleIds=mythFiles.map(p=>Number(path.basename(p).match(/^G-(\d+)/)[1]));
const expected=Array.from({length:75},(_,i)=>i+1).join(',');
const ledger=body(history+'10 Chronology and Control/World Historical Atlas - Integration and Coverage Ledger.md');
const leadBlock=ledger.split('## Reviewed identifier register')[1]?.split('## Reserve closure')[0]||'';
const leadRows=[...leadBlock.matchAll(/^\| ([A-Z0-9-]+) \|/gm)].map(m=>m[1]);
const reserveBlock=ledger.split('## Reserve closure')[1]?.split('## Unnumbered material')[0]||'';
const reserveStatuses=[...reserveBlock.matchAll(new RegExp('\\| '+quote+'([^'+quote+']+)'+quote+' \\|','g'))].map(m=>m[1]);
const tests={
  garden75: gardenIds.length===75 && gardenIds.sort((a,b)=>a-b).join(',')===expected,
  articles75: articleIds.length===75 && articleIds.sort((a,b)=>a-b).join(',')===expected,
  gardenAtlasLinks75: (garden.match(/\*Atlas article:\*/g)||[]).length===75,
  sourceIdentifiers315: leadRows.length===315 && new Set(leadRows).size===315,
  reserve204: reserveStatuses.length===204 && reserveStatuses.every(s=>['integrate','graft','reject','protected-dormant'].includes(s)),
  lives14: files.filter(p=>p.startsWith(history+'80 Myths and Legendary Histories/GS-')).length===14,
  unknownHistories6: files.filter(p=>p.startsWith(history+'80 Myths and Legendary Histories/UH-')).length===6,
  heavenlyEpisodes12: files.filter(p=>p.startsWith(history+'80 Myths and Legendary Histories/')&&/\/(?:HC|OBA)-N/.test(p)).length===12,
  archfiends18: files.filter(p=>p.startsWith(history+'90 Distant and Otherworld Histories/AF-')).length===18,
  newLinksResolve: broken.length===0,
  frontmatterAndArtifacts: malformed.length===0,
  noDuplicatedUnknownCapsules: files.filter(p=>p.startsWith(history+'80 Myths and Legendary Histories/UH-')).every(p=>!/^# UH-/m.test(body(p)))
};
const shell=body('01 Canon Reference/Magic & Systems/40 Rune and Shell Magic/Shell Anchors and Extraction.md');
const anchorTable=shell.split('## The Fourteen Active Anchors')[1].split('## Platform Anatomy')[0];
tests.shellAnchors14=(anchorTable.match(/^\| (?:Vorthara|Ironvale|Qahirid Covenant|Thalmyria) \|/gm)||[]).length===14;
const atlasStart=history+'World Historical Atlas MOC.md';
const reached=new Set();const queue=[atlasStart];
while(queue.length) {
  const p=queue.shift();if(reached.has(p))continue;reached.add(p);
  for(const target of links(body(p))) {
    const name=target.split('#')[0].replace(/\.md$/i,'');
    const candidates=byName.get(name.toLowerCase())||[];
    for(const candidate of candidates)if(!reached.has(candidate))queue.push(candidate);
  }
}
const unreachableHistory=files.filter(p=>p.startsWith(history)&&!reached.has(p));
tests.allHistoryReachable=unreachableHistory.length===0;
const expectedPortals=["01 Canon Reference/History/20 Prehistory/Creation and the First Rebellions.md","01 Canon Reference/History/30 Exodus and First Civilizations/Age of Chains.md","01 Canon Reference/History/30 Exodus and First Civilizations/Age of Exodus.md","01 Canon Reference/History/30 Exodus and First Civilizations/Age of Scattering.md","01 Canon Reference/History/30 Exodus and First Civilizations/Age of Hearths and First Kings.md","01 Canon Reference/History/30 Exodus and First Civilizations/Age of City-States.md","01 Canon Reference/History/30 Exodus and First Civilizations/Age of Stars.md","01 Canon Reference/History/40 Atherian Imperial Age/Atherian Imperial Age.md","01 Canon Reference/History/50 Redeemer and Conversion/The Age of the Redeemer.md","01 Canon Reference/History/50 Redeemer and Conversion/The Conversion of the Empire.md","01 Canon Reference/History/50 Redeemer and Conversion/The Long Frontier and the First Unsealing.md","01 Canon Reference/History/60 Fall and Successor Empires/The Fall and the Long Reconquest.md","01 Canon Reference/History/60 Fall and Successor Empires/The Great Split — Two Crowns, One Fire.md","01 Canon Reference/History/70 Later History and Present Day/High Noon and the Qarath Disaster.md","01 Canon Reference/History/70 Later History and Present Day/The Age of Held Proofs.md","01 Canon Reference/History/90 Distant and Otherworld Histories/Distant Lands and Otherworld Histories.md"];
tests.eraPortals16=expectedPortals.length===16&&expectedPortals.every(p=>reached.has(p));
const expectedCultures=["01 Canon Reference/Peoples and Cultures/Ahl-e-Ahd/70 History and Conflicts/Historical Spine of the Covenant.md","01 Canon Reference/Peoples and Cultures/Atherian Empire/70 History and Conflicts/Historical Atlas of Atheria.md","01 Canon Reference/Peoples and Cultures/Ättar/70 History and Conflicts/Historical Spine of the Ättar.md","01 Canon Reference/Peoples and Cultures/Eclessia/70 History and Conflicts/Historical Atlas of Eclessia.md","01 Canon Reference/Peoples and Cultures/Folk/70 History and Conflicts/Historical Spine of the Folk.md","01 Canon Reference/Peoples and Cultures/Jirahar/70 History and Conflicts/Historical Spine of the Jirahar.md","01 Canon Reference/Peoples and Cultures/Nsizwa/70 History and Conflicts/Historical Atlas of the Nsizwa.md","01 Canon Reference/Peoples and Cultures/Sestaran Concord/70 History and Conflicts/Historical Spine of the Sestaran Concord.md","01 Canon Reference/Peoples and Cultures/Tarkhan/70 History and Conflicts/Historical Spine of the Tarkhan.md","01 Canon Reference/Peoples and Cultures/Thalmyric Empire/70 History and Conflicts/Historical Atlas of Thalmyria.md","01 Canon Reference/Peoples and Cultures/Velian/70 History and Conflicts/Historical Atlas of the Velians.md"];
tests.cultureHistories11=expectedCultures.length===11&&expectedCultures.every(p=>reached.has(p));
tests.legacyHistoryMapping67=(ledger.split('## Earlier history shelf')[1].split('## Research-dossier destinations')[0].match(/^\| \[\[/gm)||[]).length===67;
tests.sourceDossiers57=(ledger.split('## Research-dossier destinations')[1].split('## Reviewed identifier register')[0].match(/^\| \[\[/gm)||[]).length===57;
const report={tests,changedMarkdown:touched.length,newMarkdown:added.filter(p=>p.endsWith('.md')).length,broken,malformed,unreachableHistory};
console.log(JSON.stringify(report,null,2));
process.exitCode=Object.values(tests).every(Boolean)?0:1;
