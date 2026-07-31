using System.ComponentModel.Design;
using System.Runtime.InteropServices.ComTypes;
using CliTaskTracker.userinputhandler.UserRequests;
using TaskStatus = CliTaskTracker.task.TaskStatus;

namespace CliTaskTracker.userinputhandler;

public class ActionArgsValidator : IActionArgsValidator
{
    private const string ListTodoArg = "todo";
    private const string ListInProgressArg = "in-progress";
    private const string ListDoneArg = "done";
    
    /// <summary>
    /// Verifies CLI input arguments based on chosen action.
    /// </summary>
    /// <param name="userAction">UserAction enum based on the first CLI input argument</param>
    /// <param name="args">The rest of CLI input arguments</param>
    /// <exception cref="InvalidActionArgumentException">User entered invalid action</exception>
    /// <exception cref="InvalidUserActionException">An undefined UserAction value is passed</exception>
    /// <exception cref="IndexOutOfRangeException">User entered less than the required amount of arguments</exception>
    /// <exception cref="FormatException">User entered invalid numerical argument(s)</exception>
    public UserRequest ValidateActionArgs(UserAction userAction, params string[] args)
    {
        return userAction switch
        {
            UserAction.Create => new CreateRequest(args[0]),
            UserAction.Update => new UpdateRequest(int.Parse(args[0]), args[1]),
            UserAction.Delete => new DeleteRequest(int.Parse(args[0])),
            UserAction.MarkDone => new MarkDoneRequest(int.Parse(args[0])),
            UserAction.MarkInProgress => new MarkInProgressRequest(int.Parse(args[0])),
            UserAction.List => ValidateListRequest(args),
            _ => throw new InvalidUserActionException($"Invalid user action: ${userAction}")
        };
    }

    private static ListRequest ValidateListRequest(params string[] args)
    {
        if (args.Length == 0) return new ListRequest(null);

        TaskStatus taskStatus = args[0].Trim().ToLower() switch
        {
            ListTodoArg => TaskStatus.Todo,
            ListInProgressArg => TaskStatus.InProgress,
            ListDoneArg => TaskStatus.Done,
            _ => throw new InvalidActionArgumentException($"Invalid list action argument: {args[0].Trim()}")
        };

        return new ListRequest(taskStatus);
    }
}