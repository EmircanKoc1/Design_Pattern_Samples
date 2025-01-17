namespace Structural.Bridge.Sample2.Colors;

public class HexColor : IColor
{
    public HexColor(string colorCode)
    {
        if (colorCode.Length < 6) throw new ArgumentException("color code should not be shorter 6 characters");
        Color = $"#{colorCode}";
    }

    public string Color { get; }
}
