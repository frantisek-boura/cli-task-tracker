using CliTaskTracker.userinputhandler;
using CliTaskTracker.userinputhandler.UserRequests;

namespace CliTaskTracker;

public class CliTaskTrackerApp 
{
    static void Main(string[] args)
    {
        try
        {
            var userActionValidator = new UserActionValidator();
            var actionArgsValidator = new ActionArgsValidator();
            var userAction = userActionValidator.GetUserAction(args[0]);
            var userRequest = actionArgsValidator.ValidateActionArgs(userAction, args.Skip(1).ToArray());
            Console.WriteLine(userRequest.ToString());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        // 1. argumenty
        // foreach (string s in args)
        // {
        //     Console.WriteLine(s); 
        // }
        //
        // 2. current working directory
        //Console.WriteLine(Directory.GetCurrentDirectory());
        Console.WriteLine("Hello World!");
    }
} 