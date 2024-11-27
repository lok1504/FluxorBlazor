using Fluxor;
using FluxorBlazor.Shared;

namespace FluxorBlazor.Client.Features.UserFeedback;

public class UserFeedbackFeature : Feature<UserFeedbackState>
{
    public override string GetName() => "UserFeedback";

    protected override UserFeedbackState GetInitialState()
    {
        return new UserFeedbackState
        {
            Submitting = false,
            Submitted = false,
            ErrorMessage = string.Empty,
            Model = new UserFeedbackModel()
        };
    }
}
