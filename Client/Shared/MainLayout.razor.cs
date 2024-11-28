using Fluxor;
using FluxorBlazor.Client.Features.Hubs.CounterHub;
using Microsoft.AspNetCore.Components;

namespace FluxorBlazor.Client.Shared;

public partial class MainLayout : LayoutComponentBase
{
    [Inject]
    protected IDispatcher Dispatcher { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        Dispatcher.Dispatch(new CounterHubStartAction());
    }
}
