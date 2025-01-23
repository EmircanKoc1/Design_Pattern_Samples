namespace Behavioral.ChainOfResponsibility.Sample1;
public class MediumQualityImageProcessor : ImageProccessor
{
    public override void Process(int quality)
    {
        if (quality < 1024)
            Console.WriteLine($"An image of size {quality} image has been processed by MediumQualityImageProcessor");
        else
            nextProcessor?.Process(quality);

    }
}
