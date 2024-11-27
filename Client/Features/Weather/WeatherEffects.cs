using Fluxor;
using FluxorBlazor.Client.Features.Counter;
using FluxorBlazor.Shared;
using System.Net.Http.Json;

namespace FluxorBlazor.Client.Features.Weather;

public class WeatherEffects
{
    private readonly HttpClient Http;
    private readonly IState<CounterState> CounterState;

    public WeatherEffects(HttpClient http, IState<CounterState> counterState)
    {
        Http = http;
        CounterState = counterState;
    }

    [EffectMethod(typeof(WeatherLoadForecastsAction))]
    public async Task LoadForecasts(IDispatcher dispatcher)
    {
        var forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        dispatcher.Dispatch(new WeatherSetForecastsAction(forecasts));
    }

    [EffectMethod(typeof(CounterIncrementAction))]
    public async Task LoadForecastsOnIncrement(IDispatcher dispatcher)
    {
        if (CounterState.Value.CurrentCount % 10 == 0)
        {
            dispatcher.Dispatch(new WeatherLoadForecastsAction());
        }
    }
}
