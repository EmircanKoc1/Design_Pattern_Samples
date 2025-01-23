namespace Behavioral.ChainOfResponsibility.Sample1;

public class LowQualityImageProcessor : ImageProccessor
{
    public override void Process(int quality)
    {
        if (quality < 720)
            Console.WriteLine($"An image of size {quality} image has been processed by LowQualityImageProcessor");
        else
            nextProcessor?.Process(quality);
    }
}
