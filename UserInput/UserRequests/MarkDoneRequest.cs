using CliTaskTracker.Task;

namespace CliTaskTracker.UserInput.UserRequests;

using Task = CliTaskTracker.Task.Task;

public class MarkDoneRequest : UserRequest
{
    public int Id { get; }

    public MarkDoneRequest(int id)
    {
        Action = UserAction.Delete;
        Id = id;
    }

    public override void ExecuteRequest(ITaskContext context)
    {
        Task task = context.MarkDone(Id);
        
        Console.WriteLine($"Successfully marked task with ID {task.Id} as Done");
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} => {nameof(Id)}: {Id}";
    }
}
