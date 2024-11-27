using Fluxor;

namespace FluxorBlazor.Client.Features.Weather;

public static class WeatherReducers
{
    [ReducerMethod(typeof(WeatherSetInitializedAction))]
    public static WeatherState OnSetInitialized(WeatherState state)
    {
        return state with
        {
            Initialized = true
        };
    }

    [ReducerMethod(typeof(WeatherLoadForecastsAction))]
    public static WeatherState OnLoadForecasts(WeatherState state)
    {
        return state with
        {
            Loading = true
        };
    }

    [ReducerMethod]
    public static WeatherState OnSetForecasts(WeatherState state, WeatherSetForecastsAction action)
    {
        return state with
        {
            Forecasts = action.Forecasts,
            Loading = false
        };
    }
}
