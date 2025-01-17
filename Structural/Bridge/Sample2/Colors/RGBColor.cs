namespace Structural.Bridge.Sample2.Colors;

public class RGBColor : IColor
{
    public RGBColor(byte red, byte green, byte blue)
    {
        Color = $"rgb({red},{green},{blue})";
    }

    public string Color { get; }
}
