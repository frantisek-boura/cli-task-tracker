using CliTaskTracker.userinputhandler.UserRequests;

namespace CliTaskTracker.userinputhandler;

public interface IActionArgsValidator
{
    UserRequest ValidateActionArgs(UserAction userAction, params string[] args);
}