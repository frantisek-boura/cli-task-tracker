using CliTaskTracker.Task;

namespace CliTaskTracker.UserInput.UserRequests;

using TaskStatus = CliTaskTracker.Task.TaskStatus;

public class ListRequest : UserRequest
{
    public TaskStatus? TaskStatus { get; }

    public ListRequest(TaskStatus? taskStatus)
    {
        Action = UserAction.Delete;
        TaskStatus = taskStatus;
    }

    public override void ExecuteRequest(ITaskContext context)
    {
        context.Tasks.Where(t => TaskStatus == null || t.Status == TaskStatus).ToList().ForEach(t =>
        {
            Console.WriteLine($"{t.Status} - {t.Id}: {t.Description}");
        });
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} => {nameof(TaskStatus)}: {TaskStatus}";
    }
}
