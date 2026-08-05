using CliTaskTracker.Task;

namespace CliTaskTracker.UserInput.UserRequests;

using Task = CliTaskTracker.Task.Task;

public class DeleteRequest : UserRequest
{
    public int Id { get; }

    public DeleteRequest(int id)
    {
        Action = UserAction.Delete;
        Id = id;
    }

    public override void ExecuteRequest(ITaskContext context)
    {
        Task task = context.DeleteTask(Id);
        
        Console.WriteLine($"Successfully deleted task '{task.Description}' with ID {task.Id}");
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} => {nameof(Id)}: {Id}";
    }
}
