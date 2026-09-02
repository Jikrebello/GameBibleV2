using AngleSharp.Dom;
using AngleSharp.Html.Parser;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace WorldEgg.Wiki.Components;

// Walk only the ancestors of collection markers; all other HTML remains the sanitized renderer output.
// This keeps a collection inside a list or callout structurally intact while mounting a real Blazor table.
public sealed class ArticleBody : ComponentBase
{
    [Parameter] public string Html { get; set; } = "";
    private string? _loaded;
    private INode[] _nodes = [];
    protected override void OnParametersSet()
    {
        if (_loaded == Html) return;
        _loaded = Html; var parser = new HtmlParser(); var document = parser.ParseDocument("");
        _nodes = parser.ParseFragment(Html, document.Body!).ToArray();
        foreach (var root in _nodes.OfType<IElement>())
        {
            foreach (var table in root.QuerySelectorAll("table").Prepend(root).Where(e => e.LocalName == "table").ToArray())
            {
                var wrapper = document.CreateElement("div"); wrapper.ClassName = "prose-table-scroll"; wrapper.SetAttribute("tabindex", "0"); wrapper.SetAttribute("role", "region"); wrapper.SetAttribute("aria-label", "Scrollable article table");
                var index = Array.IndexOf(_nodes, table);
                if (index >= 0) { _nodes[index] = wrapper; wrapper.AppendChild(table); }
                else if (table.Parent is { } parent) { parent.ReplaceChild(wrapper, table); wrapper.AppendChild(table); }
            }
        }
    }
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var budget = 30;
        foreach (var node in _nodes) Render(builder, node, ref budget);
    }
    private static void Render(RenderTreeBuilder builder, INode node, ref int budget)
    {
        builder.OpenRegion(0);
        if (node is IElement element)
        {
            if (element.ClassList.Contains("base-embed") && element.GetAttribute("data-base-id") is { } id)
            {
                if (budget-- > 0) { builder.OpenComponent<BaseTable>(1); builder.AddAttribute(2, nameof(BaseTable.Id), id); builder.CloseComponent(); }
                else builder.AddContent(3, "Collection embed limit reached. Open the collection separately.");
            }
            else if (element.QuerySelector(".base-embed[data-base-id]") is not null)
            {
                builder.OpenElement(4, element.LocalName);
                builder.AddMultipleAttributes(5, element.Attributes.Select(a => new KeyValuePair<string, object>(a.Name, a.Value)));
                foreach (var child in element.ChildNodes) Render(builder, child, ref budget);
                builder.CloseElement();
            }
            else builder.AddMarkupContent(6, element.OuterHtml);
        }
        else if (node is IText text) builder.AddContent(7, text.Data);
        builder.CloseRegion();
    }
}
