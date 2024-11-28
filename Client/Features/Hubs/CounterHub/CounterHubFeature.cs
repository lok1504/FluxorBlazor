using Fluxor;

namespace FluxorBlazor.Client.Features.Hubs.CounterHub;

public class CounterHubFeature : Feature<CounterHubState>
{
    public override string GetName() => "CounterHub";

    protected override CounterHubState GetInitialState()
    {
        return new CounterHubState
        {
            Connected = false
        };
    }
}
