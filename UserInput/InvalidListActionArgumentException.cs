namespace CliTaskTracker.UserInput;

public class InvalidListActionArgumentException : Exception
{
    public InvalidListActionArgumentException() { }
    public InvalidListActionArgumentException(string message) : base(message) { }
    public InvalidListActionArgumentException(string message, Exception inner) : base(message, inner) { }
}