namespace CliTaskTracker.userinputhandler;

public interface IUserInputHandler
{
    UserAction GetUserAction(string argument1);
    void VerifyUserActionParams(UserAction userAction, params string[] args);
}