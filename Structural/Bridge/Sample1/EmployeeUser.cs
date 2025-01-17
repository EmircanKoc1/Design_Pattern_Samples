namespace Structural.Bridge.Sample1
{
    public class EmployeeUser : User
    {
        public EmployeeUser(INotifyMethod notifyMethod) : base(notifyMethod)
        {
        }

        public override void Notify(string message, Guid id)
        {
            _notifyMethod.Send(message, id);
        }
    }
}
