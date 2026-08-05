using CliTaskTracker.Files;
using CliTaskTracker.Task;
using CliTaskTracker.UserInput;
using CliTaskTracker.UserInput.UserRequests;

namespace CliTaskTracker;

public class CliTaskTrackerApp
{
    private const string FileName = ".todotasks.json";
    
    static void Main(string[] args)
    {
        try
        {
            var filePath = Path.Join(Directory.GetCurrentDirectory(), FileName);
            
            var userActionValidator = new UserActionValidator();
            var actionArgsValidator = new ActionArgsValidator();
            var userAction = userActionValidator.GetUserAction(args[0]);
            var userRequest = actionArgsValidator.ValidateActionArgs(userAction, [.. args.Skip(1)]);
            
            var taskContext = new TaskContext(new FileHandler(filePath));

            userRequest.ExecuteRequest(taskContext);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
} 