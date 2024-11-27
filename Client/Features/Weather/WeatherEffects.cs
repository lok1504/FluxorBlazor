using Fluxor;
using FluxorBlazor.Client.Features.Counter;
using FluxorBlazor.Shared;
using System.Net.Http.Json;

namespace FluxorBlazor.Client.Features.Weather;

public class WeatherEffects(HttpClient http, IState<CounterState> counterState)
{
    [EffectMethod(typeof(WeatherLoadForecastsAction))]
    public async Task LoadForecasts(IDispatcher dispatcher)
    {
        var forecasts = await http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        dispatcher.Dispatch(new WeatherSetForecastsAction(forecasts));
    }

    [EffectMethod(typeof(CounterIncrementAction))]
    public async Task LoadForecastsOnIncrement(IDispatcher dispatcher)
    {
        if (counterState.Value.CurrentCount % 10 == 0)
        {
            dispatcher.Dispatch(new WeatherLoadForecastsAction());
        }
    }
}
