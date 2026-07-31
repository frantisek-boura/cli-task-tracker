namespace CliTaskTracker.UserInput;

public interface IUserActionValidator
{
    UserAction GetUserAction(string argument1);
}