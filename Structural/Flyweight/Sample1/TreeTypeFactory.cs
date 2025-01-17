namespace Structural.Flyweight.Sample1;

//flyweight factory
public class TreeTypeFactory
{
    private readonly IDictionary<string, TreeType> _treeTypes = null!;

    public TreeTypeFactory()
    {
        _treeTypes = new Dictionary<string, TreeType>();
    }

    public TreeType GetTreeType(string name, bool isFruitTree, string leafColor, string bodyColor)
    {

        string key = string.Concat(name, isFruitTree, leafColor, bodyColor);
        if (_treeTypes.ContainsKey(key))
        {
            return _treeTypes[key];
        }
        _treeTypes.Add(key, new TreeType(name, isFruitTree, bodyColor, leafColor));
        return _treeTypes[key];

    }

}

