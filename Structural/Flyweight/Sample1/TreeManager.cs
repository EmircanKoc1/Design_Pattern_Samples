namespace Structural.Flyweight.Sample1;

public class TreeManager
{
    private readonly TreeTypeFactory _treeTypeFactory;
    public TreeManager()
    {
        _treeTypeFactory = new();
    }
    public void PlantTree(Forest forest, Tree tree)
    {
        forest.AddTree(tree);
        LogPlantDetails(forest, tree);
    }

    public void PlantTree(Forest forest,
        double height,
        double width,
        int positionX,
        int positionY,
        int positionZ,
        string name,
        bool isFruitTree,
        string? bodyColor,
        string leafColor)
    {

        TreeType treeType = _treeTypeFactory.GetTreeType(name, isFruitTree, leafColor, bodyColor);
        Tree tree = new Tree(treeType, height, width, positionX, positionY, positionZ);
        forest.AddTree(tree);
        PlantTree(forest, tree);
    }

    private void LogPlantDetails(Forest forest, Tree tree)
    {
        var plantDetails =
      $"""
        forest name : {forest.Name}
        tree type id : {tree.Type.Id}
        tree name : {tree.Type.Name}
        is fruit tree: {tree.Type.IsFruitTree}
        leaf color : {tree.Type.LeafColor}
        body color : {tree.Type.BodyColor}
        height  : {tree.Height}
        width  : {tree.Width}
        positionX : {tree.PositionX}
        positionY : {tree.PositionY}
        positionZ : {tree.PositionZ}
        """;

        Console.WriteLine($"\nThe tree is planted , details : {plantDetails}\n");
    }

}

