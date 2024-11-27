using Fluxor;
using System.Net.Http.Json;

namespace FluxorBlazor.Client.Features.UserFeedback;

public class UserFeedbackEffects(HttpClient httpClient)
{
    [EffectMethod]
    public async Task SubmitUserFeedback(UserFeedbackSubmitAction action, IDispatcher dispatcher)
    {
        var response = await httpClient.PostAsJsonAsync("Feedback", action.UserFeedbackModel);

        if (response.IsSuccessStatusCode)
        {
            dispatcher.Dispatch(new UserFeedbackSubmitSuccessAction());
        }
        else
        {
            dispatcher.Dispatch(new UserFeedbackSubmitFailureAction(response.ReasonPhrase));
        }
    }
}
