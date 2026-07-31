namespace CliTaskTracker.userinputhandler.UserRequests;

public class DeleteRequest : UserRequest
{
    public int Id { get; set; }

    public DeleteRequest(int id)
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
