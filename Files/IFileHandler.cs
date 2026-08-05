namespace CliTaskTracker.Files;

using Task = CliTaskTracker.Task.Task;

public interface IFileHandler
{
    List<Task> LoadTasks();
    void SaveTasks(List<Task> tasks);
}