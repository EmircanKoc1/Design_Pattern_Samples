namespace Structural.Bridge.Sample1
{
    public class MailSender : INotifyMethod
    {
        public void Send(string message, Guid userId)
        {
            Console.WriteLine($"The mail has been sent to the user with ID {userId}");
        }
    }
}
