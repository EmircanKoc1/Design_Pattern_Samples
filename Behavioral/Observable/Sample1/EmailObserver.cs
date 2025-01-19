namespace Behavioral.Observable.Sample1
{
    public class EmailObserver : ICustomObserver
    {
        public void HandleMessage(string message)
        {
            Console.WriteLine($"The  email has been sent , email content : {message}");

        }
    }



}
