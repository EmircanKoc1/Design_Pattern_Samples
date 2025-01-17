namespace Structural.Flyweight.Sample1;

//extrinsic state
public class Tree
{
    public Tree(TreeType type, double height, double width, int ppositionX, int positionY, int positionZ)
    {
        Type = type;
        Height = height;
        Width = width;
        PositionX = ppositionX;
        PositionY = positionY;
        PositionZ = positionZ;
    }

    public TreeType Type { get; }
    public double Height { get; }
    public double Width { get; }

    public int PositionX { get; }
    public int PositionY { get; }
    public int PositionZ { get; }


}

