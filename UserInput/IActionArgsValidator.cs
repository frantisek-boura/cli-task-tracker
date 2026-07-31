using CliTaskTracker.UserInput.UserRequests;

namespace CliTaskTracker.UserInput;

public interface IActionArgsValidator
{
    UserRequest ValidateActionArgs(UserAction userAction, params string[] args);
}