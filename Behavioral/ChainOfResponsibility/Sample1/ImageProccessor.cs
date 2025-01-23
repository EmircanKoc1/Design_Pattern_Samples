namespace Behavioral.ChainOfResponsibility.Sample1;

public abstract class ImageProccessor : IImageProcessor
{
    protected IImageProcessor? nextProcessor;
    public abstract void Process(int quality);

    public void SetNextProcessor(IImageProcessor processor)
    {
        nextProcessor = processor ?? throw new ArgumentNullException("Image processor cannot be null!");
    }
}
