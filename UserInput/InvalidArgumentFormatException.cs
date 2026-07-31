namespace CliTaskTracker.UserInput;

public class InvalidArgumentFormatException : Exception
{
    public InvalidArgumentFormatException() { }
    public InvalidArgumentFormatException(string message) : base(message) { }
    public InvalidArgumentFormatException(string message, Exception inner) : base(message, inner) { }
}
