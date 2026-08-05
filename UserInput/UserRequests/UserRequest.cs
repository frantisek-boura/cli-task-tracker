using CliTaskTracker.Task;

namespace CliTaskTracker.UserInput.UserRequests;

public abstract class UserRequest 
{
    public UserAction Action { get; protected set; }

    public abstract void ExecuteRequest(ITaskContext context);

}
    