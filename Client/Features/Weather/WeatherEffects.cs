using Fluxor;
using FluxorBlazor.Shared;
using System.Net.Http.Json;

namespace FluxorBlazor.Client.Features.Weather;

public class WeatherEffects
{
    private readonly HttpClient Http;

    public WeatherEffects(HttpClient http)
    {
        Http = http;
    }

    [EffectMethod(typeof(WeatherLoadForecastsAction))]
    public async Task LoadForecasts(IDispatcher dispatcher)
    {
        var forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        dispatcher.Dispatch(new WeatherSetForecastsAction(forecasts));
    }
}
