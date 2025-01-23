namespace Behavioral.ChainOfResponsibility.Sample1;

public interface IImageProcessor
{
    void Process(int quality);
    void SetNextProcessor(IImageProcessor processor);
}
