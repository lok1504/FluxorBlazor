using Fluxor;
using Fluxor.Blazor.Web.Components;
using FluxorBlazor.Shared;
using Microsoft.AspNetCore.Components;

namespace FluxorBlazor.Client.Features.UserFeedback;

public partial class UserFeedback : FluxorComponent
{
    [Inject]
    protected IState<UserFeedbackState> UserFeedbackState { get; set; }

    [Inject]
    protected IDispatcher Dispatcher { get; set; }

    private UserFeedbackModel Model => UserFeedbackState.Value.Model;

    private void HandleValidSubmit()
    {
        Dispatcher.Dispatch(new UserFeedbackSubmitAction(UserFeedbackState.Value.Model));
    }

    private void HandleReset()
    {
        Dispatcher.Dispatch(new UserFeedbackResetAction());
    }
}
