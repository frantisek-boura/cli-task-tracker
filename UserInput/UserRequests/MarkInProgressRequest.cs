namespace CliTaskTracker.UserInput.UserRequests;

public class MarkInProgressRequest : UserRequest
{
    public int Id { get; set; }

    public MarkInProgressRequest(int id)
    {
        Action = UserAction.Delete;
        Id = id;
    }

    public override void ExecuteRequest()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} => {nameof(Id)}: {Id}";
    }
}
