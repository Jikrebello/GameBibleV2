(function (root, factory) {
    const api = factory();
    if (typeof module === 'object' && module.exports) module.exports = api;
    else root.worldEggReadingCore = api;
})(globalThis, function () {
    'use strict';
    const roots = ['00 Start Here', '01 Canon Reference', '02 Playable Settings', '03 Stories & In-World Texts', '90 Archive & Drafts', '99 Templates'];
    function validId(id) {
        return typeof id === 'string' && id.length > 0 && id.length <= 1024 && !/[\\\u0000]/.test(id) && !id.split('/').some(p => p === '..' || p === '.') && roots.some(r => id.startsWith(r + '/'));
    }
    function preferences(value) {
        const p = value && typeof value === 'object' ? value : {};
        return { theme: ['light', 'dark'].includes(p.theme) ? p.theme : 'system', textSize: Number.isFinite(p.textSize) ? Math.min(24, Math.max(16, Math.round(p.textSize))) : 18,
            width: ['narrow', 'wide'].includes(p.width) ? p.width : 'standard', restorePosition: p.restorePosition === true, navigationCollapsed: p.navigationCollapsed === true, previews: p.previews !== false };
    }
    function savedPages(value, limit) {
        const seen = new Set();
        return (Array.isArray(value) ? value : []).filter(x => {
            if (!x || !validId(x.id) || !x.id.toLowerCase().endsWith('.md') || typeof x.title !== 'string' || !x.title.length || x.title.length > 400 || seen.has(x.id.toLowerCase())) return false;
            seen.add(x.id.toLowerCase()); return true;
        }).slice(0, limit).map(x => ({ id: x.id, title: x.title, updatedUtc: Number.isFinite(Date.parse(x.updatedUtc)) ? new Date(x.updatedUtc).toISOString() : new Date(0).toISOString() }));
    }
    function snapshot(value) {
        const s = value && typeof value === 'object' ? value : {};
        return { preferences: preferences(s.preferences), bookmarks: savedPages(s.bookmarks, 100), recent: savedPages(s.recent, 40), storageAvailable: s.storageAvailable !== false };
    }
    function parse(value) { try { return snapshot(JSON.parse(value || '{}')); } catch { return snapshot({}); } }
    function previewTarget(href, origin) {
        try { const url = new URL(href, origin); const id = url.searchParams.get('path'); if (url.origin !== new URL(origin).origin || url.pathname !== '/wiki' || !validId(id) || !id.toLowerCase().endsWith('.md')) return null; return { id, fragment: decodeURIComponent(url.hash.slice(1)) }; } catch { return null; }
    }
    function fitImage(width, height, viewportWidth, viewportHeight) {
        const scale = Math.min(1, Math.max(0.001, Math.min((viewportWidth - 24) / Math.max(1, width), (viewportHeight - 24) / Math.max(1, height))));
        return { scale, x: (viewportWidth - width * scale) / 2, y: (viewportHeight - height * scale) / 2 };
    }
    function zoomImage(state, factor, cx, cy, minimum = 0.01) {
        const scale = Math.max(minimum, Math.min(16, state.scale * factor)); const ratio = scale / state.scale;
        return { scale, x: cx - (cx - state.x) * ratio, y: cy - (cy - state.y) * ratio };
    }
    function restoreTarget(saved, maximum, anchorTop, header) {
        if (!saved || typeof saved !== 'object') return null;
        const ratio = Number.isFinite(saved.ratio) ? Math.max(0, Math.min(1, saved.ratio)) : 0;
        const position = Number.isFinite(anchorTop) && Number.isFinite(saved.offset) ? anchorTop + Math.max(-200, Math.min(100000, saved.offset)) - header : maximum * ratio;
        return Math.max(0, Math.min(maximum, position));
    }
    function shouldRestore(enabled, resetScroll, fragment) { return enabled === true && resetScroll === true && !fragment; }
    return { validId, preferences, savedPages, snapshot, parse, previewTarget, fitImage, zoomImage, restoreTarget, shouldRestore };
});