using FluxorBlazor.Shared;

namespace FluxorBlazor.Client.Features.UserFeedback;

public class UserFeedbackSubmitSuccessAction { }

public class UserFeedbackSubmitFailureAction
{
    public string ErrorMessage { get; }

    public UserFeedbackSubmitFailureAction(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }
}

public class UserFeedbackSubmitAction
{
    public UserFeedbackModel UserFeedbackModel { get; }

    public UserFeedbackSubmitAction(UserFeedbackModel userFeedbackModel)
    {
        UserFeedbackModel = userFeedbackModel;
    }
}

public class UserFeedbackResetAction { }