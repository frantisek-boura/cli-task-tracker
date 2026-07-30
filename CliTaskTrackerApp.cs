using CliTaskTracker.userinputhandler;

namespace CliTaskTracker;

public class CliTaskTrackerApp 
{
    static void Main(string[] args)
    {
        try
        {
            UserInputHandler userInputHandler = new UserInputHandler();
            UserAction userAction = userInputHandler.GetUserAction(args[0]);
            Console.WriteLine(userAction);
        }
        catch (InvalidUserActionException e)
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