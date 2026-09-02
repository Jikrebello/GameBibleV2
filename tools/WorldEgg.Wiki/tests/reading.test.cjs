const test = require('node:test');
const assert = require('node:assert/strict');
const fs = require('node:fs');
const path = require('node:path');
const vm = require('node:vm');
const core = require('../wwwroot/reading-core.js');
const id = '01 Canon Reference/Test/Ättar.md';

test('stored preferences are bounded and malformed data has usable defaults', () => {
    assert.deepEqual(core.preferences({theme:'script',textSize:100,width:'huge',previews:false}), {theme:'system',textSize:24,width:'standard',restorePosition:false,navigationCollapsed:false,previews:false});
    assert.equal(core.parse('{bad').preferences.textSize, 18);
    assert.deepEqual(core.parse('{"bookmarks":"not a list"}').bookmarks, []);
});
test('bookmarks retain Unicode, deduplicate paths, and reject unsafe or non-article entries', () => {
    const pages = core.savedPages([{id,title:'Ättar',updatedUtc:'bad'}, {id,title:'Duplicate'}, {id:'../private.md',title:'Bad'}, {id:'01 Canon Reference/../secret.md',title:'Bad'}, {id:'01 Canon Reference/map.svg',title:'Not article'}], 100);
    assert.equal(pages.length, 1); assert.equal(pages[0].title, 'Ättar'); assert.equal(pages[0].updatedUtc, '1970-01-01T00:00:00.000Z');
});
test('previews recognize only local, explicit article URLs and preserve fragments', () => {
    const target = core.previewTarget('/wiki?path=' + encodeURIComponent(id) + '#a-promise', 'http://localhost:5271');
    assert.deepEqual(target, {id,fragment:'a-promise'});
    assert.equal(core.previewTarget('https://elsewhere.test/wiki?path=' + encodeURIComponent(id), 'http://localhost:5271'), null);
    assert.equal(core.previewTarget('/resolve?target=Shared', 'http://localhost:5271'), null);
    assert.equal(core.previewTarget('/wiki?path=../../secret.md', 'http://localhost:5271'), null);
    assert.equal(core.previewTarget('/wiki?path=' + encodeURIComponent(id) + '#%bad', 'http://localhost:5271'), null);
});
test('fit and zoom preserve the focal point and enforce zoom limits', () => {
    const fit = core.fitImage(2000, 1000, 1000, 600);
    assert.ok(fit.scale < .5); assert.ok(fit.x >= 0 && fit.y >= 0);
    const zoom = core.zoomImage(fit, 2, 500, 300);
    assert.equal((500 - zoom.x) / zoom.scale, (500 - fit.x) / fit.scale);
    assert.equal(core.zoomImage(fit, 10000, 0, 0).scale, 16);
    assert.equal(core.zoomImage(fit, 0, 0, 0, .1).scale, .1);
});
test('position restoration is opt-in and never overrides section links or manual reloads', () => {
    assert.equal(core.shouldRestore(false, true, ''), false); assert.equal(core.shouldRestore(true, true, '#chapter'), false); assert.equal(core.shouldRestore(true, false, ''), false); assert.equal(core.shouldRestore(true, true, ''), true);
    assert.equal(core.restoreTarget({ratio:.4,offset:30}, 1000, 600, 100), 530);
    assert.equal(core.restoreTarget({ratio:.4,offset:30}, 1000, null, 100), 400);
    assert.equal(core.restoreTarget({ratio:99}, 1000, null, 100), 1000);
});

function storageHarness() {
    const data = new Map(); let blocked = false;
    const localStorage = {getItem:key => data.get(key) ?? null, setItem:(key,value) => {if (blocked) throw Error('Quota');data.set(key,value);}, removeItem:key=>data.delete(key)};
    const document = {documentElement:{dataset:{}},addEventListener(){},querySelector(){return null;},querySelectorAll(){return [];}};
    const window = {worldEgg:{},worldEggReadingCore:core,matchMedia:()=>({matches:false,addEventListener(){}}),addEventListener(){}};
    vm.runInNewContext(fs.readFileSync(path.join(__dirname,'../wwwroot/reading.js'),'utf8'),{window,document,localStorage,URL,Map,Set,Date,Math,setTimeout,clearTimeout,AbortController,console});
    return {data,api:window.worldEgg,block(){blocked=true;}};
}
test('browser storage round-trips preferences and lists without a filesystem writer', () => {
    const h = storageHarness(); const value = {preferences:{theme:'dark',textSize:21,width:'wide'},bookmarks:[{id,title:'Ättar',updatedUtc:new Date(0).toISOString()}]};
    assert.equal(h.api.reading.save('vault-a',value),true); const loaded = h.api.reading.load('vault-a');
    assert.equal(loaded.preferences.theme,'dark'); assert.equal(loaded.bookmarks[0].id,id); assert.equal(h.api.reading.load('vault-b').bookmarks.length,0);
});
test('blocked writes do not erase readable saved pages and report storage failure', () => {
    const h = storageHarness(); h.api.reading.save('vault',{bookmarks:[{id,title:'A saved page'}]}); h.block();
    assert.equal(h.api.reading.load('vault').bookmarks.length,1); assert.equal(h.api.reading.load('vault').storageAvailable,false); assert.equal(h.api.reading.save('vault',{}),false);
});
test('existing theme preference migrates without replacing an existing reading preference', () => {
    const h = storageHarness(); h.data.set('worldegg.theme','dark'); assert.equal(h.api.reading.load('new-vault').preferences.theme,'dark');
    h.api.reading.save('new-vault',{preferences:{theme:'light'}}); assert.equal(h.api.reading.load('new-vault').preferences.theme,'light');
});
test('print stylesheet removes application controls and keeps source and article material', () => {
    const css = fs.readFileSync(path.join(__dirname,'../wwwroot/reading.css'),'utf8'); const print = css.slice(css.indexOf('@media print'));
    for (const selector of ['.masthead','.library-nav','.article-actions','.article-preview','.image-viewer','.section-permalink']) assert.ok(print.includes(selector));
    assert.match(print,/display:none!important/); assert.match(print,/\.print-source\{display:block/); assert.match(print,/\.article-prose\{font-size:11pt/); assert.match(css,/@media\(prefers-reduced-motion:reduce\)/);
});
test('body, muted text and link palette meet normal-text contrast in both themes', () => {
    function luminance(hex) { const rgb=hex.match(/[a-f0-9]{2}/gi).map(x=>parseInt(x,16)/255).map(x=>x<=.04045?x/12.92:((x+.055)/1.055)**2.4);return rgb[0]*.2126+rgb[1]*.7152+rgb[2]*.0722; }
    const css = fs.readFileSync(path.join(__dirname,'../wwwroot/wiki.css'),'utf8');
    for (const marker of ['.site-shell{--paper:', '.site-shell[data-theme=dark]{--paper:']) {
        const start=css.indexOf(marker); const rule=css.slice(start,css.indexOf('}',start)); const color=name=>rule.match(new RegExp('--'+name+':(#[0-9a-f]+)'))[1];
        for (const name of ['ink','muted','link','accent']) { const a=luminance(color(name)); const b=luminance(color('paper')); assert.ok((Math.max(a,b)+.05)/(Math.min(a,b)+.05)>=4.5,marker+name); }
    }
});
