namespace Creational.Factory.Sample1.Models;

public class UserDeletedEvent : IUserEvent
{
    public Guid Id { get; set; }
    public DateTime DeletedAt { get; set; }
}


