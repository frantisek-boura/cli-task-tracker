namespace CliTaskTracker.UserInput.UserRequests;

using TaskStatus = CliTaskTracker.Task.TaskStatus;

public class ListRequest : UserRequest
{
    public TaskStatus? TaskStatus { get; set; }

    public ListRequest(TaskStatus? taskStatus)
    {
        Action = UserAction.Delete;
        TaskStatus = taskStatus;
    }

    public override void ExecuteRequest()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} => {nameof(TaskStatus)}: {TaskStatus}";
    }
}
