using CliTaskTracker.Files;

namespace CliTaskTracker.Task;

public class TaskContext : ITaskContext
{
    public List<Task> Tasks { get; }
    
    private readonly IFileHandler _fileHandler;

    public TaskContext(IFileHandler fileHandler)
    {
        _fileHandler = fileHandler;
        Tasks = _fileHandler.LoadTasks();
    }

    public Task CreateTask(string description)
    {
        int maxId = Tasks.Select(t => t.Id).DefaultIfEmpty(0).Max<int>() + 1;
        Task task = new Task
        {
            Id = maxId,
            Description = description,
            Status = TaskStatus.Todo
        };
        
        Tasks.Add(task);
        _fileHandler.SaveTasks(Tasks);

        return task;
    }

    public Task UpdateTask(int id, string description)
    {
        Task task = FindTaskById(id);
        
        task.Description = description;
        _fileHandler.SaveTasks(Tasks);

        return task;
    }

    public Task DeleteTask(int id)
    {
        Task task = FindTaskById(id);
        
        bool success = Tasks.Remove(task);
        _fileHandler.SaveTasks(Tasks);

        return task;
    }

    public Task MarkDone(int id)
    {
        Task task = FindTaskById(id);
        
        task.Status = TaskStatus.Done;
        _fileHandler.SaveTasks(Tasks);

        return task;
    }

    public Task MarkInProgress(int id)
    {
        Task task = FindTaskById(id);
        
        task.Status = TaskStatus.InProgress;
        _fileHandler.SaveTasks(Tasks);

        return task;
    }

    private Task FindTaskById(int id)
    {
        Task? task = Tasks.Find(t => t.Id == id);
        
        return task ?? throw new TaskDoesntExistException($"Task with id {id} doesn't exist");
    }
}