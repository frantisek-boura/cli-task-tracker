namespace CliTaskTracker.UserInput;

public class InvalidActionArgumentException : Exception
{
    public InvalidActionArgumentException() { }
    public InvalidActionArgumentException(string message) : base(message) { }
    public InvalidActionArgumentException(string message, Exception inner) : base(message, inner) { }
}