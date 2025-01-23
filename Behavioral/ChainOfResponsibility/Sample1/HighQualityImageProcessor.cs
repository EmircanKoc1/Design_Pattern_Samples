namespace Behavioral.ChainOfResponsibility.Sample1;

public class HighQualityImageProcessor : ImageProccessor
{
    public override void Process(int quality)
    {
        Console.WriteLine($"An image of size {quality} image has been processed by HighQualityImageProcessor");
    }
}
