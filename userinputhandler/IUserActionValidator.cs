namespace CliTaskTracker.userinputhandler;

public interface IUserActionValidator
{
    UserAction GetUserAction(string argument1);
}