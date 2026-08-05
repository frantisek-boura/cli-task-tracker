using CliTaskTracker.Task;

namespace CliTaskTracker.UserInput.UserRequests;

using Task = CliTaskTracker.Task.Task;

public class UpdateRequest : UserRequest
{
    public int Id { get; }
    public string Description { get; }

    public UpdateRequest(int id, string description)
    {
        Action = UserAction.Update;
        Id = id;
        Description = description;
    }

    public override void ExecuteRequest(ITaskContext context)
    {
        Task task = context.UpdateTask(Id, Description);
        
        Console.WriteLine($"Successfully updated task '{task.Description}' with ID {task.Id}");
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} => {nameof(Id)}: {Id}, {nameof(Description)}: {Description}";
    }
}