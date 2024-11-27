using Blazored.Toast.Services;
using Fluxor;
using Fluxor.Blazor.Web.Components;
using FluxorBlazor.Client.Features.Counter;
using FluxorBlazor.Client.Features.Weather;
using Microsoft.AspNetCore.Components;

namespace FluxorBlazor.Client.Shared;

public partial class NavMenu : FluxorComponent
{
    [Inject]
    protected IState<CounterState> CounterState { get; set; }

    [Inject]
    protected IState<WeatherState> WeatherState { get; set; }

    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;
    private string WeatherItemClass => WeatherState.Value.Loading ? "font-weight-bold" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }
}
