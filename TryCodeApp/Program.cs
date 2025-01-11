#region Factory Sample 1

using Creational.Factory.Sample1;
using Creational.Factory.Sample1.Enums;
using Creational.Factory.Sample1.Models;
using Creational.FactoryMethod.Sample1;

var userEventFactory = new UserEventFactory();

//var userEvent = userEventFactory.CreateUserEvent(UserEventType.UserCreated);
var userEvent = userEventFactory.CreateUserEvent(UserEventType.UserDeleted);

if (userEvent is UserCreatedEvent userCreatedEvent)
{
    Console.WriteLine(userCreatedEvent.Id);
    Console.WriteLine(userCreatedEvent.Name);
    Console.WriteLine(userCreatedEvent.Age);
    Console.WriteLine(userCreatedEvent.CreatedAt);
}
else
{
    Console.WriteLine("UserEvent is not UserCreatedEvent");
}


#endregion

#region Factory method sample 1

//SpiderMaster? spiderMaster = new SmallSpiderMaster();
SpiderMaster? spiderMaster = new BigSpiderMaster();


spiderMaster.ThrowAWeb();

#endregion