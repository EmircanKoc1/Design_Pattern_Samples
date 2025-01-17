using Structural.Bridge.Sample2.Colors;

namespace Structural.Bridge.Sample2.Shapes;

public class Rectangle : Shape
{
    public Rectangle(IColor color) : base(color)
    {
    }

    public override void Draw()
    {
        Console.WriteLine($"The rectangle is drawn , color : {_color.Color}");

    }
}
