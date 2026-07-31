namespace CliTaskTracker.userinputhandler.UserRequests;

public class UpdateRequest : UserRequest
{
    public int Id { get; set; }
    public string Description { get; set; }

    public UpdateRequest(int id, string description)
    {
        Action = UserAction.Update;
        Id = id;
        Description = description;
    }

    public override void ExecuteRequest()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} => {nameof(Id)}: {Id}, {nameof(Description)}: {Description}";
    }
}