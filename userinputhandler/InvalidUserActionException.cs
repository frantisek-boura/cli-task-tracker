namespace CliTaskTracker.userinputhandler;

public class InvalidUserActionException : Exception
{
    public InvalidUserActionException() { }
    public InvalidUserActionException(string message) : base(message) { }
    public InvalidUserActionException(string message, Exception inner) : base(message, inner) { }
}