(function () {
    'use strict';
    const api = window.worldEgg = window.worldEgg || {};
    let reference, articleId, root, abort;
    const value = (object, name) => object?.[name] ?? object?.[name[0].toUpperCase() + name.slice(1)];
    const textNodes = element => {
        const nodes = [], walker = document.createTreeWalker(element, NodeFilter.SHOW_TEXT, {
            acceptNode(node) {
                const parent = node.parentElement;
                if (!parent || parent.closest('script,style,button,textarea,input,select,[aria-hidden="true"]')) return NodeFilter.FILTER_REJECT;
                return node.data.length ? NodeFilter.FILTER_ACCEPT : NodeFilter.FILTER_REJECT;
            }
        });
        while (walker.nextNode()) nodes.push(walker.currentNode);
        return nodes;
    };
    const rawText = element => textNodes(element).map(node => node.data).join('');
    function boundaryOffset(element, container, offset) {
        let total = 0;
        for (const node of textNodes(element)) {
            if (node === container) return total + Math.min(offset, node.data.length);
            total += node.data.length;
        }
        try {
            const range = document.createRange(); range.selectNodeContents(element); range.setEnd(container, offset);
            return range.toString().length;
        } catch { return -1; }
    }
    function selectionAnchor() {
        const selection = window.getSelection();
        if (!selection || selection.rangeCount !== 1 || selection.isCollapsed || !root) return null;
        const range = selection.getRangeAt(0);
        const common = range.commonAncestorContainer.nodeType === Node.ELEMENT_NODE ? range.commonAncestorContainer : range.commonAncestorContainer.parentElement;
        if (!common || !root.contains(common)) return null;
        let start = boundaryOffset(root, range.startContainer, range.startOffset), end = boundaryOffset(root, range.endContainer, range.endOffset);
        if (start < 0 || end <= start) return null;
        const full = rawText(root);
        while (start < end && /\s/.test(full[start])) start++;
        while (end > start && /\s/.test(full[end - 1])) end--;
        if (end <= start || end - start > 6000) return null;
        const exactText = full.slice(start, end), selectedText = exactText.replace(/\s+/g, ' ').trim();
        if (!selectedText) return null;
        const rect = range.getBoundingClientRect();
        return {
            exactText, selectedText,
            prefix: full.slice(Math.max(0, start - 180), start),
            suffix: full.slice(end, Math.min(full.length, end + 180)),
            startOffset: start, endOffset: end,
            x: Math.max(12, Math.min(innerWidth - 130, rect.right + 8)),
            y: Math.max(12, Math.min(innerHeight - 52, rect.bottom + 7))
        };
    }
    function notifySelection() {
        const anchor = selectionAnchor();
        reference?.invokeMethodAsync('SelectionChanged', anchor).catch(() => {});
    }
    function isReviewControl(target) {
        return target instanceof Element && target.closest('.selection-comment-button,.review-panel') !== null;
    }
    function clearMarks() {
        if (!root) return;
        for (const mark of root.querySelectorAll('mark[data-review-comment]')) mark.replaceWith(document.createTextNode(mark.textContent || ''));
        root.normalize();
    }
    function locate(full, comment) {
        const anchor = value(comment, 'anchor') || {}, exact = value(anchor, 'exactText') || '';
        if (!exact) return null;
        const stored = Number(value(anchor, 'startOffset'));
        if (Number.isInteger(stored) && stored >= 0 && full.slice(stored, stored + exact.length) === exact) return { start: stored, end: stored + exact.length };
        const prefix = value(anchor, 'prefix') || '', suffix = value(anchor, 'suffix') || '';
        let best = null, index = full.indexOf(exact);
        while (index >= 0) {
            let score = 0;
            if (prefix && full.slice(Math.max(0, index - prefix.length), index) === prefix) score += 3;
            if (suffix && full.slice(index + exact.length, index + exact.length + suffix.length) === suffix) score += 3;
            if (Number.isFinite(stored)) score -= Math.min(2, Math.abs(index - stored) / 10000);
            if (!best || score > best.score) best = { start: index, end: index + exact.length, score };
            index = full.indexOf(exact, index + 1);
        }
        return best;
    }
    function wrapSegment(node, start, end, id) {
        if (end <= start) return;
        const range = document.createRange(); range.setStart(node, start); range.setEnd(node, end);
        const mark = document.createElement('mark'); mark.className = 'review-highlight'; mark.dataset.reviewComment = id;
        range.surroundContents(mark);
    }
    function apply(comments) {
        if (!root) return;
        clearMarks();
        const items = Array.isArray(comments) ? comments : (Array.isArray(comments?.$values) ? comments.$values : []);
        const full = rawText(root), ranges = items
            .filter(comment => !value(comment, 'resolved'))
            .map(comment => ({ comment, range: locate(full, comment) }))
            .filter(item => item.range)
            .sort((a, b) => b.range.start - a.range.start);
        for (const item of ranges) {
            const id = String(value(item.comment, 'id')), nodes = textNodes(root); let cursor = 0;
            for (const node of nodes) {
                const nodeStart = cursor, nodeEnd = cursor + node.data.length; cursor = nodeEnd;
                if (nodeEnd <= item.range.start || nodeStart >= item.range.end) continue;
                wrapSegment(node, Math.max(0, item.range.start - nodeStart), Math.min(node.data.length, item.range.end - nodeStart), id);
            }
        }
    }
    api.annotations = {
        attach(dotnetReference, id, comments) {
            this.detach(); reference = dotnetReference; articleId = id;
            root = document.querySelector(`article[data-document-id="${CSS.escape(id)}"]`);
            if (!root) return;
            apply(comments); abort = new AbortController(); const signal = abort.signal;
            document.addEventListener('pointerup', event => {
                if (isReviewControl(event.target)) return;
                setTimeout(notifySelection, 0);
            }, { signal });
            document.addEventListener('keyup', event => {
                if (isReviewControl(event.target)) return;
                if (event.key.startsWith('Arrow') || event.key === 'Shift') setTimeout(notifySelection, 0);
            }, { signal });
            root.addEventListener('click', event => {
                const mark = event.target instanceof Element ? event.target.closest('mark[data-review-comment]') : null;
                if (mark) reference?.invokeMethodAsync('OpenReviewComment', mark.dataset.reviewComment).catch(() => {});
            }, { signal });
        },
        refresh(comments) { apply(comments); },
        clearSelection() { window.getSelection()?.removeAllRanges(); reference?.invokeMethodAsync('SelectionChanged', null).catch(() => {}); },
        focusComment(id) { document.querySelector(`[data-review-card="${CSS.escape(id)}"]`)?.scrollIntoView({ block: 'nearest', behavior: 'smooth' }); },
        detach() { abort?.abort(); abort = null; clearMarks(); reference = null; root = null; articleId = null; }
    };
})();
