using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Boboom.Js;
using Boboom.Math;

namespace Boboom.Dom;

public class BoDomService
{
    public BoJsModule Anchor { get; init; }
    public BoDomService(IJSRuntime jsRuntime)
    {
        var assembly = typeof(BoDomService).Assembly;
        Anchor = new BoJsModule(jsRuntime, assembly, "anchor.js");
    }

    public async ValueTask<BoPosition> GetPosition(IJSObjectReference element)
    {
        return await Anchor.InvokeAsync<BoPosition>("getPosition", element);
    }

    public async ValueTask<BoPosition> GetPosition(ElementReference element)
    {
        return await Anchor.InvokeAsync<BoPosition>("getPosition", element);
    }

    public async ValueTask SetPosition(IJSObjectReference element, double x, double y)
    {
        await Anchor.InvokeVoidAsync("setPosition", element, x, y);
    }

    public async ValueTask SetPosition(ElementReference element, double x, double y)
    {
        await Anchor.InvokeVoidAsync("setPosition", element, x, y);
    }

    public async ValueTask SetPosition(IJSObjectReference element, BoPosition position)
    {
        await SetPosition(element, position.X, position.Y);
    }

    public async ValueTask SetPosition(ElementReference element, BoPosition position)
    {
        await SetPosition(element, position.X, position.Y);
    }

    public async ValueTask<BoSize> GetSize(IJSObjectReference element)
    {
        return await Anchor.InvokeAsync<BoSize>("getSize", element);
    }

    public async ValueTask<BoSize> GetSize(ElementReference element)
    {
        return await Anchor.InvokeAsync<BoSize>("getSize", element);
    }

    public async ValueTask SetSize(IJSObjectReference element, BoSize size)
    {
        await Anchor.InvokeVoidAsync("setSize", element, size);
    }

    public async ValueTask SetSize(ElementReference element, BoSize size)
    {
        await Anchor.InvokeVoidAsync("setSize", element, size);
    }

    public async ValueTask<BoSize> GetContentSize(ElementReference element)
    {
        return await Anchor.InvokeAsync<BoSize>("getContentSize", element);
    }

    public async ValueTask<BoSize> GetContentPosition(ElementReference element)
    {
        return await Anchor.InvokeAsync<BoSize>("getContentPosition", element);
    }
}
