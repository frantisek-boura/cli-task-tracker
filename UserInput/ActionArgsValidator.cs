using System.ComponentModel.Design;
using System.Runtime.InteropServices.ComTypes;
using CliTaskTracker.UserInput.UserRequests;
using TaskStatus = CliTaskTracker.task.TaskStatus;

namespace CliTaskTracker.UserInput;

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
    /// <exception cref="NotEnoughActionArgumentsException">User entered less than the required amount of arguments</exception>
    /// <exception cref="InvalidArgumentFormatException">User entered an incorrectly formatted argument</exception>
    public UserRequest ValidateActionArgs(UserAction userAction, params string[] args)
    {
        try
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
        catch (IndexOutOfRangeException)
        {
            throw new NotEnoughActionArgumentsException($"Not enough argumenst entered for action ${userAction}");
        }
        catch (FormatException)
        {
            throw new InvalidArgumentFormatException($"Invalid argument format.");
        }
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