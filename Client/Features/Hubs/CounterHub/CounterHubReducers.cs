using Fluxor;

namespace FluxorBlazor.Client.Features.Hubs.CounterHub;

public static class CounterHubReducers
{
    [ReducerMethod]
    public static CounterHubState OnSetConnected(
        CounterHubState state, CounterHubSetConnectedAction action)
    {
        return state with
        {
            Connected = action.Connected
        };
    }
}
