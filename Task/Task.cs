namespace CliTaskTracker.Task;

public class Task
{
    public required int Id { get; set; }
    public required string Description { get; set; }
    public required TaskStatus Status { get; set; }
    public DateTime CreatedAt { get; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}