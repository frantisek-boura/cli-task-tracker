namespace CliTaskTracker.userinputhandler;

public class UserInputHandler : IUserInputHandler
{
    private const string AddArg = "add";
    private const string UpdateArg = "update";
    private const string DeleteArg = "delete";
    private const string ListArg = "list";
    private const string MarkDoneArg = "mark-done";
    private const string MarkInProgressArg = "mark-in-progress";
        
    /// <summary>
    /// Checks if the first cli input argument is valid and returns respective enum.
    /// </summary>
    /// <param name="argument1">First CLI input argument</param>
    /// <returns>UserAction</returns>
    /// <exception cref="InvalidUserActionException">User entered invalid action</exception>
    public UserAction GetUserAction(string argument1)
    {
        return argument1.ToLower().Trim() switch
        {
            AddArg => UserAction.Create,
            UpdateArg => UserAction.Update,
            DeleteArg => UserAction.Delete,
            ListArg => UserAction.List,
            MarkDoneArg => UserAction.MarkDone,
            MarkInProgressArg => UserAction.MarkInProgress,
            _ => throw new InvalidUserActionException($"Invalid action entered: {argument1}")
        };
    }

    /// <summary>
    /// Verifies CLI input arguments based on chosen action .
    /// </summary>
    /// <param name="userAction">UserAction enum based on the first CLI input argument</param>
    /// <param name="args">The rest of CLI input arguments</param>
    /// <exception cref="InvalidUserActionException">User entered invalid action</exception>
    public void VerifyUserActionParams(UserAction userAction, params string[] args)
    {
        switch (userAction)
        {
            case UserAction.Create:
                break;
            case UserAction.Update:
                break;
            case UserAction.Delete:
                break;
            case UserAction.List:
                break;
            case UserAction.MarkDone:
                break;
            case UserAction.MarkInProgress:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(userAction), userAction, null);
        }
    }

    private void VerifyAddUserActionParams()
    {
        
    }
}