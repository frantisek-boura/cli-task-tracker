using CliTaskTracker.Task;

namespace CliTaskTracker.UserInput.UserRequests;

using Task = CliTaskTracker.Task.Task;

public class CreateRequest : UserRequest
{
    public string Description { get; }
    
    public CreateRequest(string description)
    {
        Action = UserAction.Create;
        Description = description;
    }

    public override void ExecuteRequest(ITaskContext context)
    {
        Task task = context.CreateTask(Description);

        Console.WriteLine($"Successfully created task '{task.Description}' with ID {task.Id}");
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} => {nameof(Description)}: {Description}";
    }
}