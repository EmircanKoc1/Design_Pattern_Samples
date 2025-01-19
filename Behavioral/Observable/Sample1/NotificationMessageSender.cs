namespace Behavioral.Observable.Sample1
{
    public class NotificationMessagePublisher : ISubject
    {
        private readonly ICollection<ICustomObserver> _observers;

        public NotificationMessagePublisher(ICollection<ICustomObserver> observers)
        {
            _observers = observers ?? throw new ArgumentNullException(nameof(observers));
        }

        public void Notify(string message)
        {
            foreach (ICustomObserver observer in _observers) observer.HandleMessage(message);
        }

        public void Subcribe(ICustomObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unsubcribe(ICustomObserver observer)
        {
            _observers.Remove(observer);
        }
    }



}
