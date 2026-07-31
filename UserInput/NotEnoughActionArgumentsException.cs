namespace CliTaskTracker.UserInput;

public class NotEnoughActionArgumentsException : Exception
{
    public NotEnoughActionArgumentsException() { }
    public NotEnoughActionArgumentsException(string message) : base(message) { }
    public NotEnoughActionArgumentsException(string message, Exception inner) : base(message, inner) { }
}