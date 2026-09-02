window.worldEgg = {
    prefersDark() {
        try { const saved = localStorage.getItem('worldegg.theme'); if (saved) return saved === 'dark'; } catch { }
        return window.matchMedia('(prefers-color-scheme: dark)').matches;
    },
    setTheme(dark) { try { localStorage.setItem('worldegg.theme', dark ? 'dark' : 'light'); } catch { } },
    async articleReady(resetScroll, id, preferences, storageKey) {
        if (preferences) this.reading?.apply(preferences, storageKey);
        if (resetScroll) {
            const fragment = decodeURIComponent(location.hash.slice(1));
            if (fragment) document.getElementById(fragment)?.scrollIntoView();
            else window.scrollTo({ top: 0, behavior: 'instant' });
        }
        if (!window.mermaid) { this.reading?.startArticle(id, resetScroll); return; }
        mermaid.initialize({ startOnLoad: false, securityLevel: 'strict', theme: document.querySelector('.site-shell')?.dataset.theme === 'dark' ? 'dark' : 'neutral', suppressErrorRendering: true });
        for (const diagram of document.querySelectorAll('.article-prose pre.mermaid:not([data-processed])')) {
            const source = diagram.textContent;
            try { await mermaid.run({ nodes: [diagram] }); }
            catch { diagram.textContent = 'Diagram could not be drawn. Original source:\n\n' + source; diagram.classList.add('diagram-error'); }
        }
        this.reading?.startArticle(id, resetScroll);
    }
};
document.addEventListener('keydown', event => {
    if (document.querySelector('dialog[open]')) return;
    const editing = event.target instanceof Element && (event.target.closest('input,textarea,select,[contenteditable="true"]') !== null);
    if (((event.ctrlKey || event.metaKey) && event.key.toLowerCase() === 'k') || (event.key === '/' && !editing && !event.altKey && !event.ctrlKey && !event.metaKey)) {
        const search = document.querySelector('.quick-find input');
        if (search) { event.preventDefault(); search.focus(); search.select(); }
    }
});
