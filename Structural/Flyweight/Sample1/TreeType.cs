namespace Structural.Flyweight.Sample1;

//intrinsic state
public class TreeType
{
    public Guid Id { get; }
    public string Name { get; }
    public bool IsFruitTree { get; }
    public string? BodyColor { get; }
    public string LeafColor { get; }

    public TreeType(string name, bool isFruitTree, string? bodyColor, string leafColor)
    {
        Id = Guid.NewGuid();
        Name = name;
        IsFruitTree = isFruitTree;
        BodyColor = bodyColor;
        LeafColor = leafColor;
    }

}

