namespace CliTaskTracker.userinputhandler.UserRequests;

public abstract class UserRequest 
{
    public UserAction Action { get; set; }

    public abstract void ExecuteRequest();

}
    