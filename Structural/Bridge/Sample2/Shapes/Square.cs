using Structural.Bridge.Sample2.Colors;

namespace Structural.Bridge.Sample2.Shapes;

public class Square : Shape
{
    public Square(IColor color) : base(color)
    {
    }

    public override void Draw()
    {
        Console.WriteLine($"The square is drawn , color : {_color.Color}");

    }
}
