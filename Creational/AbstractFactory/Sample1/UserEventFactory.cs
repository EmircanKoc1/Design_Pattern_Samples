using Creational.Factory.Sample1.Enums;
using Creational.Factory.Sample1.Models;

namespace Creational.Factory.Sample1;

public class UserEventFactory
{
    public IUserEvent CreateUserEvent(UserEventType eventType)
    {
        return eventType switch
        {
            UserEventType.UserCreated => new UserCreatedEvent(),
            UserEventType.UserUpdated => new UserUpdatedEvent(),
            UserEventType.UserDeleted => new UserDeletedEvent(),
            _ => throw new Exception("Event Type is undefined")
        };

    }

}


