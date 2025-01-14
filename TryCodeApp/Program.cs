#region Abstract Design Pattern sample 1

using Creational.Builder.Sample1;
using Creational.Factory.Sample1;
using Creational.Factory.Sample1.Enums;
using Creational.Factory.Sample1.Models;
using Creational.FactoryMethod.Sample1;
using Creational.Prototype.Sample1;
using Creational.Singleton.Sample1;

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

#region Builder pattern sample 1

//IComputerBuilder builder = new ComputerBuilder();   
ComputerBuilder builder = new ComputerBuilder();

builder.SetSSD("samsung evo 970", 1024);
builder.SetGPU("rtx 4050", 6);
builder.SetRAM("SK Hynix", 16);
builder.SetCPU("İntel core i7 10750H", 6, 12);

var computer = builder.BuildComputer();

Console.WriteLine(computer);

#endregion

#region Singleton Pattern sample 1

WindowOptions? windowOption = Settings.WindowOptions;

windowOption.PanelType = "OLED";
windowOption.Height = 1080;
windowOption.Width = 1920;

Console.WriteLine(windowOption);

#endregion

#region Prototype Design pattern sample 1

Product product = new Product()
{
    Name = "Iphone 15 pro",
    Price = 80_000,
    ComplexDefiner = new ComplexDefiner()
    {
        Id = Guid.NewGuid(),
        CreatedAt = DateTime.Now,
    }
};

Console.WriteLine();
Console.WriteLine(product);
Console.WriteLine();

if (product.Clone() as Product is Product product2)
{
    product2.Name = "Samsung s24";
    product2.Price = 30_000;

    if (product2.ComplexDefiner is ComplexDefiner complexDefiner)
    {
        complexDefiner.Id = Guid.NewGuid();
        complexDefiner.CreatedAt = DateTime.Now.AddHours(10);
    }

    Console.WriteLine(product);
    Console.WriteLine();
    Console.WriteLine(product2);
}



#endregion