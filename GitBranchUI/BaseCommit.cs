namespace GitBranchUI;

public class BaseCommit
{
    public BaseCommit(string id, Branch branch)
    {
        Id = id;
        Branch = branch;
        Created = DateTime.UtcNow;
    }
    public string Id { get;}

    public Branch Branch { get;}

    public DateTime Created { get; }
}
