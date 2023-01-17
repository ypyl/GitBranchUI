namespace GitBranchUI;

public class Commit : BaseCommit
{
    public Commit(string id, Branch branch, BaseCommit previous)
        : base(id, branch)
    {
        Previous = previous;
    }
    public BaseCommit Previous { get; }
}
