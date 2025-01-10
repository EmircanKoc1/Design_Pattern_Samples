namespace Creational.Factory.Sample1.Models;

public class UserUpdatedEvent : IUserEvent
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public DateTime UpdatedAt { get; set; }
}


