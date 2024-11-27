using FluxorBlazor.Shared;

namespace FluxorBlazor.Client.Features.Weather;

public class WeatherSetInitializedAction { }

public class WeatherLoadForecastsAction { }

public class WeatherSetForecastsAction
{
    public WeatherForecast[] Forecasts { get; }

    public WeatherSetForecastsAction(WeatherForecast[] forecasts)
    {
        Forecasts = forecasts;
    }
}