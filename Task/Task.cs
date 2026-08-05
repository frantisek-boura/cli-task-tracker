namespace CliTaskTracker.Task;

public record Task {
    public int Id { get; set; }
    public string Description { get; set; } = "";
    public TaskStatus Status { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; init; } = DateTime.Now;
}    
    