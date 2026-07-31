namespace CliTaskTracker.UserInput.UserRequests;

public class CreateRequest : UserRequest
{
    public string Description { get; set; }
    
    public CreateRequest(string description)
    {
        Action = UserAction.Create;
        Description = description;
    }

    public override void ExecuteRequest()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} => {nameof(Description)}: {Description}";
    }
}