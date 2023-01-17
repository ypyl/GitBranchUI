namespace GitBranchUI;
public class Branch
{
    public Branch(string name)
    {
        Name = name;
        Created = DateTime.UtcNow;
    }

    public string Name { get; }
    public DateTime Created { get; }
}
