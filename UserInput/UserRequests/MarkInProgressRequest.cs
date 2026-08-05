using CliTaskTracker.Task;

namespace CliTaskTracker.UserInput.UserRequests;

using Task = CliTaskTracker.Task.Task;

public class MarkInProgressRequest : UserRequest
{
    public int Id { get; }

    public MarkInProgressRequest(int id)
    {
        Action = UserAction.Delete;
        Id = id;
    }

    public override void ExecuteRequest(ITaskContext context)
    {
        Task task = context.MarkInProgress(Id);
        
        Console.WriteLine($"Successfully marked task with ID {task.Id} as In Progress");
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} => {nameof(Id)}: {Id}";
    }
}
