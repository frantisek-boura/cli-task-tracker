namespace CliTaskTracker.Files;

public class CouldNotHandleFileException : Exception
{
    public CouldNotHandleFileException() { }
    public CouldNotHandleFileException(string message) : base(message) { }
    public CouldNotHandleFileException(string message, Exception inner) : base(message, inner) { }
}