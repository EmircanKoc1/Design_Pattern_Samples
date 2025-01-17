using Structural.Bridge.Sample2.Colors;

namespace Structural.Bridge.Sample2.Shapes;

public abstract class Shape
{
    protected readonly IColor _color;
    protected Shape(IColor color)
    {
        _color = color;
    }

    public abstract void Draw();

}
