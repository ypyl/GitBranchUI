namespace GitBranchUI;

public class Merge : BaseCommit
{
    public Merge(string id, Branch mergedFrom, Branch branch, BaseCommit previous)
        : base(id, branch)
    {
        MergedFrom = mergedFrom;
        Previous = previous;
    }

    public Branch MergedFrom { get; }
    public BaseCommit Previous { get; }
}
