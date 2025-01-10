namespace Creational.Factory.Sample1.Models;

public class UserCreatedEvent : IUserEvent
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime DeletedAt { get; set; }
}


