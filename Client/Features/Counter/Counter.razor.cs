using Fluxor;
using Fluxor.Blazor.Web.Components;
using FluxorBlazor.Client.Features.Hubs.CounterHub;
using Microsoft.AspNetCore.Components;

namespace FluxorBlazor.Client.Features.Counter;

public partial class Counter : FluxorComponent
{
    [Inject]
    protected IDispatcher Dispatcher { get; set; }

    [Inject]
    protected IState<CounterState> CounterState { get; set; }

    [Inject] 
    protected IState<CounterHubState> CounterHubState { get; set; }


    private void IncrementCount()
    {
        Dispatcher.Dispatch(new CounterIncrementAction());
    }

    private void SaveCount()
    {
        Dispatcher.Dispatch(new CounterPersistStateAction(CounterState.Value));
    }

    private void LoadCount()
    {
        Dispatcher.Dispatch(new CounterLoadStateAction());
    }

    private void ClearCount()
    {
        Dispatcher.Dispatch(new CounterClearStateAction());
    }

    private void SendCount()
    {
        Dispatcher.Dispatch(new CounterHubSendCountAction(CounterState.Value.CurrentCount));
    }
}
