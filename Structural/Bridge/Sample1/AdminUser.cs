namespace Structural.Bridge.Sample1
{
    public class AdminUser : User
    {
        public AdminUser(INotifyMethod notifyMethod) : base(notifyMethod)
        {
        }

        public override void Notify(string message, Guid id)
        {
            _notifyMethod.Send(message, id);
        }
    }
}
