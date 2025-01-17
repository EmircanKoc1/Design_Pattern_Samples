namespace Structural.Bridge.Sample1
{
    public abstract class User
    {
        protected readonly INotifyMethod _notifyMethod;

        protected User(INotifyMethod notifyMethod)
        {
            _notifyMethod = notifyMethod;
        }


        public abstract void Notify(string message, Guid id);

    }
}
