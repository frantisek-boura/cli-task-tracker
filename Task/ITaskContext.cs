namespace CliTaskTracker.Task;

public interface ITaskContext
{
    List<Task> Tasks { get; }
    
    Task CreateTask(string description);
    Task UpdateTask(int id, string description);
    Task DeleteTask(int id);
    Task MarkDone(int id);
    Task MarkInProgress(int id);
}