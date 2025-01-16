#region Abstract Design Pattern sample 1

using Creational.Builder.Sample1;
using Creational.Factory.Sample1;
using Creational.Factory.Sample1.Enums;
using Creational.Factory.Sample1.Models;
using Creational.FactoryMethod.Sample1;
using Creational.ObjectPool.Sample1;
using Creational.Prototype.Sample1;
using Creational.Singleton.Sample1;
using Structural.Adapter.Sample1;
using Structural.Decorator.Sample1;
using Structural.Facade.Sample1;
using Structural.Proxy.Sample1;

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


#region Object Pool Design Pattern sample 1

var bulletPool = new BulletPool(2);
var bullet1 = bulletPool.GetBullet();
var bullet2 = bulletPool.GetBullet();
var bullet3 = bulletPool.GetBullet();
var bullet4 = bulletPool.GetBullet();

if (bullet1 is Bullet bulletX)
    Console.WriteLine(bulletX);
else
    Console.WriteLine("Bullet1 is null");

if (bullet2 is Bullet bulletY)
    Console.WriteLine(bulletY);
else
    Console.WriteLine("Bullet2 is null");

if (bullet3 is Bullet bulletZ)
    Console.WriteLine(bulletZ);
else
    Console.WriteLine("Bullet3 is null");

bulletPool.ReturnBullet(bullet2!);
bullet4 = bulletPool.GetBullet();

if (bullet4 is Bullet bulletA)
    Console.WriteLine(bulletA);
else
    Console.WriteLine("Bullet4 is null");






#endregion


#region Adapter Design Pattern sample1

IFahrenheitTemperatureService fahrenheitTemperatureService = new FahrenheitTemperatureService();
ICelciusTemperatureService celciusTemperatureService = new CelciusToFahrenheitAdapter(fahrenheitTemperatureService);

celciusTemperatureService.SetTemperature(22);


#endregion

#region Proxy Design Pattern sample1

//IMatService matService = new MatService();
//IMatService matServiceLogProxy = new MatServiceLogProxy(matService);
//IMatService matServiceValidationProxy = new MatServiceValidationProxy(matServiceLogProxy);

//matServiceValidationProxy.Divide(10, 2);

IMatService matServiceProxyChain = new MatServiceLogProxy(new MatServiceValidationProxy(new MatService()));

matServiceProxyChain.Sum(20, 3);
//matServiceProxyChain.Divide(8, 0);//throw exception
matServiceProxyChain.Divide(12, 4);

#endregion

#region Facade Design Pattern sample 1

HomeTheaterSystem homeTheaterSystem = new HomeTheaterSystem(
    television: new Television(),
    soundSystem: new SoundSystem(),
    lights: new Lights(),
    blinds: new Blinds());

homeTheaterSystem.StartHomeTheaterSystem();
homeTheaterSystem.FinishHomeTheaterSystem();

#endregion

#region Decorator Design Pattern sample 1

ICoffee espresso = new Coffee();

ICoffee flatWhite = new CoffeeMilkDecorator(espresso);
ICoffee macchiato = new CoffeeMilkFoamDecorator(espresso);

Console.WriteLine(flatWhite.GetDescription() + flatWhite.GetCost());
Console.WriteLine(macchiato.GetDescription() + macchiato.GetCost());


#endregion