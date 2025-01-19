namespace Behavioral.Observable.Sample1
{
    public class LogObserver : ICustomObserver
    {
        public void HandleMessage(string message)
        {
            Console.WriteLine($"The log message  has been added to the DB, log message : {message}");

        }
    }



}
