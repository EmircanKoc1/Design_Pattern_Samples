namespace Behavioral.Observable.Sample1
{
    public class SMSObserver : ICustomObserver
    {
        public void HandleMessage(string message)
        {
            Console.WriteLine($"The SMS message has been sent , message : {message}");
        }
    }



}
