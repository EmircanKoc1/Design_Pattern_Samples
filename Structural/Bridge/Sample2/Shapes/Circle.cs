using Structural.Bridge.Sample2.Colors;

namespace Structural.Bridge.Sample2.Shapes;

public class Circle : Shape
{
    public Circle(IColor color) : base(color)
    {
    }

    public override void Draw()
    {
        Console.WriteLine($"The circle is drawn , color : {_color.Color}");
    }
}
