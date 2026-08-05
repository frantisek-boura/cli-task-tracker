namespace CliTaskTracker.Files;

public class InvalidTaskFileFormat : Exception
{
    public InvalidTaskFileFormat() { }
    public InvalidTaskFileFormat(string message) : base(message) { }
    public InvalidTaskFileFormat(string message, Exception inner) : base(message, inner) { }
}