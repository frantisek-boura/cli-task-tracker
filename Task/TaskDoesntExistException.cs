namespace CliTaskTracker.Task;

public class TaskDoesntExistException : Exception
{
    public TaskDoesntExistException() { }
    public TaskDoesntExistException(string message) : base(message) { }
    public TaskDoesntExistException(string message, Exception inner) : base(message, inner) { }
}