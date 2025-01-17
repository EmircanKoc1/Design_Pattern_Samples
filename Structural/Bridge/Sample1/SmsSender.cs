namespace Structural.Bridge.Sample1
{
    public class SmsSender : INotifyMethod
    {
        public void Send(string message, Guid userId)
        {
            Console.WriteLine($"The sms has been sent to the user with ID {userId}");

        }
    }
}
