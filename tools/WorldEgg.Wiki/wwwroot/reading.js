(function () {
    'use strict';
    const core = window.worldEggReadingCore;
    const api = window.worldEgg;
    let storageKey = document.documentElement.dataset.readingKey || 'worldegg.reading';
    let preferences = core.preferences();
    let themeReference;
    const media = window.matchMedia('(prefers-color-scheme: dark)');
    const dark = () => preferences.theme === 'dark' || (preferences.theme === 'system' && media.matches);
    const safeInvoke = (reference, method, ...args) => reference?.invokeMethodAsync(method, ...args).catch(() => {});
    let articleId = null;
    let positionTimer;
    const positionsKey = () => storageKey + '.positions';
    function positions() { try { const value = JSON.parse(localStorage.getItem(positionsKey()) || '{}'); return value && typeof value === 'object' && !Array.isArray(value) ? value : {}; } catch { return {}; } }
    function rememberPosition() {
        if (!preferences.restorePosition || !articleId) return;
        const article = document.querySelector('article[data-document-id]');
        if (!article || article.dataset.documentId !== articleId) return;
        const header = document.querySelector('.masthead')?.getBoundingClientRect().height || 92;
        const headings = Array.from(article.querySelectorAll('h2[id],h3[id],h4[id]'));
        const anchor = headings.filter(h => h.getBoundingClientRect().top <= header + 20).at(-1);
        const maximum = Math.max(0, document.documentElement.scrollHeight - innerHeight);
        const all = positions();
        all[articleId] = { anchor: anchor?.id || '', offset: anchor ? scrollY + header - (anchor.getBoundingClientRect().top + scrollY) : 0, ratio: maximum ? Math.min(1, scrollY / maximum) : 0, updatedAt: Date.now() };
        const trimmed = Object.fromEntries(Object.entries(all).filter(([id, p]) => core.validId(id) && p && typeof p === 'object').sort((a, b) => (b[1].updatedAt || 0) - (a[1].updatedAt || 0)).slice(0, 80));
        try { localStorage.setItem(positionsKey(), JSON.stringify(trimmed)); } catch { }
    }
    api.reading = {
        load(key) {
            storageKey = key;
            let state = core.snapshot({});
            try {
                const raw = localStorage.getItem(key); state = core.parse(raw);
                if (!raw) { const legacy = localStorage.getItem('worldegg.theme'); if (['light', 'dark'].includes(legacy)) state.preferences.theme = legacy; }
                localStorage.setItem(key + '.probe', '1'); localStorage.removeItem(key + '.probe'); return state;
            } catch { return { ...state, storageAvailable: false }; }
        },
        save(key, value) { try { localStorage.setItem(key, JSON.stringify(core.snapshot(value))); return true; } catch { return false; } },
        apply(value, key) { storageKey = key; preferences = core.preferences(value); if (!preferences.previews) api.previews.dismiss(); return dark(); },
        attach(reference) { themeReference = reference; },
        detach() { themeReference = null; },
        startArticle(id, resetScroll) {
            clearTimeout(positionTimer); articleId = id;
            if (!core.shouldRestore(preferences.restorePosition, resetScroll, location.hash)) return;
            const saved = positions()[id]; if (!saved) return;
            const header = document.querySelector('.masthead')?.getBoundingClientRect().height || 92;
            const anchor = typeof saved.anchor === 'string' ? document.getElementById(saved.anchor) : null;
            const top = anchor ? anchor.getBoundingClientRect().top + scrollY : null;
            const target = core.restoreTarget(saved, Math.max(0, document.documentElement.scrollHeight - innerHeight), top, header);
            if (target !== null) window.scrollTo({ top: target, behavior: 'instant' });
        },
        async copy(text) {
            try { await navigator.clipboard.writeText(text); return true; }
            catch {
                const focused = document.activeElement;
                const input = document.createElement('textarea'); input.value = text; input.setAttribute('aria-label', 'Source path'); input.style.cssText = 'position:fixed;left:-10000px;top:0'; document.body.append(input); input.select();
                let success = false; try { success = document.execCommand('copy'); } catch { } input.remove(); focused?.focus(); return success;
            }
        },
        print() { window.print(); }
    };
    media.addEventListener('change', () => { if (preferences.theme === 'system') safeInvoke(themeReference, 'SetEffectiveDark', dark()); });
    window.addEventListener('scroll', () => { clearTimeout(positionTimer); positionTimer = setTimeout(rememberPosition, 300); }, { passive: true });
    window.addEventListener('pagehide', rememberPosition);
    document.addEventListener('click', event => {
        if (event.target instanceof Element && event.target.closest('a[href]')) rememberPosition();
        for (const details of document.querySelectorAll('.reading-settings[open]')) if (!details.contains(event.target)) details.open = false;
    });
    document.addEventListener('keydown', event => {
        if (event.key !== 'Escape') return;
        const settings = document.querySelector('.reading-settings[open]'); if (settings) { settings.open = false; settings.querySelector('summary')?.focus(); }
    });
    let printDetails = [];
    window.addEventListener('beforeprint', () => { printDetails = Array.from(document.querySelectorAll('.article-prose details:not([open])')); for (const d of printDetails) d.open = true; });
    window.addEventListener('afterprint', () => { for (const d of printDetails) d.open = false; printDetails = []; });

    let previewReference, previewAbort, hoverTimer, hideTimer, trigger, suppressed, generation = 0;
    function hidePreview() {
        clearTimeout(hoverTimer); clearTimeout(hideTimer);
        trigger?.removeAttribute('aria-describedby'); safeInvoke(previewReference, 'HidePreview', ++generation); trigger = null;
    }
    function schedulePreview(anchor) {
        if (!preferences.previews || anchor === suppressed || anchor.closest('#article-preview,.article-toc,.article-actions,.pagination,.base-table,.section-permalink')) return;
        const target = core.previewTarget(anchor.href, location.origin); if (!target) return;
        if (trigger === anchor) { clearTimeout(hideTimer); return; }
        hidePreview(); trigger = anchor;
        hoverTimer = setTimeout(() => { if (!trigger?.isConnected) return; safeInvoke(previewReference, 'ShowPreview', target.id, target.fragment, ++generation); }, 450);
    }
    api.previews = {
        attach(reference) {
            this.detach(); previewReference = reference; previewAbort = new AbortController(); const signal = previewAbort.signal;
            const enter = event => { const node = event.target instanceof Element ? event.target : null; if (node?.closest('#article-preview')) { clearTimeout(hideTimer); return; } const anchor = node?.closest('a[href]'); if (anchor) schedulePreview(anchor); };
            const leave = event => {
                const destination = event.relatedTarget instanceof Element ? event.relatedTarget : null;
                if (destination?.closest('#article-preview') || destination?.closest('a[href]') === trigger) return;
                if (event.target instanceof Element && (event.target.closest('a[href]') === trigger || event.target.closest('#article-preview'))) { clearTimeout(hoverTimer); hideTimer = setTimeout(hidePreview, 160); suppressed = null; }
            };
            document.addEventListener('pointerover', enter, { signal }); document.addEventListener('focusin', enter, { signal });
            document.addEventListener('pointerout', leave, { signal }); document.addEventListener('focusout', leave, { signal });
            document.addEventListener('keydown', e => { if (e.key === 'Escape') this.dismiss(); }, { signal });
            document.addEventListener('click', e => { if (e.target instanceof Element && !e.target.closest('#article-preview')) this.dismiss(); }, { signal });
            window.addEventListener('scroll', hidePreview, { passive: true, signal }); window.addEventListener('resize', hidePreview, { signal });
        },
        position() {
            const card = document.getElementById('article-preview'); if (!card || !trigger?.isConnected || suppressed === trigger || !preferences.previews) { if (card) hidePreview(); return; }
            const rect = trigger.getBoundingClientRect(); const box = card.getBoundingClientRect(); const inset = 12;
            card.style.left = Math.max(inset, Math.min(rect.left, innerWidth - box.width - inset)) + 'px';
            card.style.top = Math.max(inset, Math.min(rect.bottom + 10, innerHeight - box.height - inset)) + 'px';
            trigger.setAttribute('aria-describedby', 'article-preview');
        },
        dismiss() { suppressed = trigger; hidePreview(); },
        detach() { previewAbort?.abort(); hidePreview(); previewReference = null; }
    };

    let imageReference, imageAbort, imageTrigger, imageObserver, imageState = { scale: 1, x: 0, y: 0 }, fitScale = 1;
    let dragged = null;
    const viewport = () => document.getElementById('image-viewport');
    const image = () => document.getElementById('enlarged-image');
    function paint() {
        const img = image(); if (!img) return;
        img.style.transform = `translate(${imageState.x}px, ${imageState.y}px) scale(${imageState.scale})`;
        const output = document.getElementById('image-zoom'); if (output) output.textContent = `${Math.round(imageState.scale * 100)}%`;
    }
    api.images = {
        attach(reference) {
            this.detach(); imageReference = reference; imageAbort = new AbortController(); const signal = imageAbort.signal;
            document.addEventListener('click', e => {
                if (e.button !== 0 || e.ctrlKey || e.metaKey || e.shiftKey || e.altKey) return;
                const anchor = e.target instanceof Element ? e.target.closest('a.image-enlarge') : null;
                if (!anchor) return; const url = new URL(anchor.href, location.origin); const id = url.searchParams.get('path');
                if (url.origin !== location.origin || url.pathname !== '/asset' || !core.validId(id)) return;
                e.preventDefault(); imageTrigger = anchor; api.previews.dismiss(); safeInvoke(imageReference, 'ShowImage', id, anchor.querySelector('img')?.alt || anchor.textContent);
            }, { signal });
            const dialog = document.getElementById('image-viewer'); const port = viewport();
            dialog?.addEventListener('cancel', e => { e.preventDefault(); safeInvoke(imageReference, 'CloseImage'); }, { signal });
            port?.addEventListener('pointerdown', e => { if (e.button !== 0 || !image()) return; dragged = { id: e.pointerId, x: e.clientX, y: e.clientY }; port.setPointerCapture(e.pointerId); port.classList.add('is-dragging'); }, { signal });
            port?.addEventListener('pointermove', e => { if (!dragged || dragged.id !== e.pointerId) return; this.pan(e.clientX - dragged.x, e.clientY - dragged.y); dragged.x = e.clientX; dragged.y = e.clientY; }, { signal });
            const release = () => { dragged = null; port?.classList.remove('is-dragging'); };
            port?.addEventListener('pointerup', release, { signal }); port?.addEventListener('pointercancel', release, { signal });
            port?.addEventListener('wheel', e => { e.preventDefault(); const rect = port.getBoundingClientRect(); imageState = core.zoomImage(imageState, e.deltaY < 0 ? 1.15 : 1 / 1.15, e.clientX - rect.left, e.clientY - rect.top, fitScale / 4); paint(); }, { signal, passive: false });
            port?.addEventListener('keydown', e => {
                const actions = { '+': () => this.zoom(1.25), '=': () => this.zoom(1.25), '-': () => this.zoom(.8), '0': () => this.fit(), ArrowLeft: () => this.pan(50, 0), ArrowRight: () => this.pan(-50, 0), ArrowUp: () => this.pan(0, 50), ArrowDown: () => this.pan(0, -50) };
                if (actions[e.key]) { e.preventDefault(); actions[e.key](); }
            }, { signal });
        },
        open() {
            const dialog = document.getElementById('image-viewer'); if (!dialog || !image()) return;
            document.getElementById('image-error').hidden = true;
            if (!dialog.open) dialog.showModal(); document.body.classList.add('image-viewer-open');
            const img = image(); img.onerror = () => { document.getElementById('image-error').hidden = false; };
            img.onload = () => this.fit(); if (img.complete && img.naturalWidth) this.fit(); else if (img.complete) document.getElementById('image-error').hidden = false;
            viewport()?.focus(); imageObserver?.disconnect(); imageObserver = new ResizeObserver(() => this.fit()); imageObserver.observe(viewport());
        },
        close() { imageObserver?.disconnect(); dragged = null; document.getElementById('image-viewer')?.close(); document.body.classList.remove('image-viewer-open'); imageTrigger?.focus(); },
        fit() {
            const img = image(), port = viewport(); if (!img?.naturalWidth || !port) return;
            img.style.width = img.naturalWidth + 'px'; img.style.height = img.naturalHeight + 'px';
            imageState = core.fitImage(img.naturalWidth, img.naturalHeight, port.clientWidth, port.clientHeight); fitScale = imageState.scale; paint();
        },
        zoom(factor) { const port = viewport(); if (!port) return; imageState = core.zoomImage(imageState, factor, port.clientWidth / 2, port.clientHeight / 2, fitScale / 4); paint(); },
        actual() { this.zoom(1 / imageState.scale); },
        pan(x, y) { imageState.x += x; imageState.y += y; paint(); },
        detach() { imageAbort?.abort(); imageObserver?.disconnect(); this.close(); imageReference = null; }
    };
})();