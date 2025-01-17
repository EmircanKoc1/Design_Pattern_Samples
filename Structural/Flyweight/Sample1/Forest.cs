namespace Structural.Flyweight.Sample1;

//context
public class Forest
{
    public string Name { get; set; }
    public List<Tree> Trees = null!;

    public Forest(string? name, List<Tree>? trees)
    {

        Name = name ?? "undefined";
        Trees = trees ?? new List<Tree>();
    }

    public void AddTree(Tree tree)
    {
        Trees.Add(tree);
    }

}

