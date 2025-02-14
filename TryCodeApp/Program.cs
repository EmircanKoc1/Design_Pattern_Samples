﻿

using Behavioral.ChainOfResponsibility.Sample1;
using Behavioral.Command.Sample1;
using Behavioral.Interpreter.Sample1;
using Behavioral.Iterator.Sample1;
using Behavioral.Mediator.Sample1;
using Behavioral.Memento.Sample1;
using Behavioral.Memento.Sample2;
using Behavioral.Observable.Sample1;
using Behavioral.State.Sample1;
using Behavioral.Strategy.Sample1;
using Behavioral.TemplateMethod.Sample1;
using Behavioral.Visitor.Sample1;
using Creational.Builder.Sample1;
using Creational.Factory.Sample1;
using Creational.Factory.Sample1.Enums;
using Creational.Factory.Sample1.Models;
using Creational.FactoryMethod.Sample1;
using Creational.ObjectPool.Sample1;
using Creational.Prototype.Sample1;
using Creational.Singleton.Sample1;
using Structural.Adapter.Sample1;
using Structural.Bridge.Sample1;
using Structural.Bridge.Sample2.Colors;
using Structural.Bridge.Sample2.Shapes;
using Structural.Composite.Sample1;
using Structural.Decorator.Sample1;
using Structural.Facade.Sample1;
using Structural.Flyweight.Sample1;
using Structural.Proxy.Sample1;
using SCS = Structural.Composite.Sample1;

#region Abstract Design Pattern sample 1
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

#region Flyweight Design Pattern sample 1

TreeManager treeManager = new TreeManager();
Forest smallForest = new Forest("SmallForest", null);

treeManager.PlantTree(
    smallForest,
    height: 22.3D,
    width: 10.2D,
    positionX: 11,
    positionY: 12,
    positionZ: -33,
    name: "cherry",
    isFruitTree: true,
    bodyColor: "brown",
    leafColor: "brown");

treeManager.PlantTree(
    smallForest,
    height: 22.3D,
    width: 10.2D,
    positionX: 11,
    positionY: 12,
    positionZ: -33,
    name: "cherry",
    isFruitTree: true,
    bodyColor: "brown",
    leafColor: "brown");


treeManager.PlantTree(
    smallForest,
    height: 22.3D,
    width: 10.2D,
    positionX: 11,
    positionY: 12,
    positionZ: -33,
    name: "cherry",
    isFruitTree: false,
    bodyColor: "brown",
    leafColor: "pink");

treeManager.PlantTree(
    smallForest,
    height: 22.3D,
    width: 10.2D,
    positionX: 11,
    positionY: 12,
    positionZ: -33,
    name: "oak",
    isFruitTree: false,
    bodyColor: "white",
    leafColor: "brown");


treeManager.PlantTree(
    smallForest,
    height: 22.3D,
    width: 10.2D,
    positionX: 11,
    positionY: 12,
    positionZ: -33,
    name: "oak",
    isFruitTree: false,
    bodyColor: "white",
    leafColor: "brown");


#endregion

#region Bridge Design Pattern sample 1

INotifyMethod smsNotify = new SmsSender();
INotifyMethod mailNotify = new MailSender();

AdminUser adminUser = new AdminUser(smsNotify);
AdminUser adminUser2 = new AdminUser(mailNotify);

EmployeeUser employeeUser = new EmployeeUser(mailNotify);
EmployeeUser employeeUser2 = new EmployeeUser(smsNotify);

employeeUser.Notify("hello", Guid.NewGuid());
employeeUser2.Notify("hello", Guid.NewGuid());
adminUser.Notify("hello", Guid.NewGuid());
adminUser2.Notify("hello", Guid.NewGuid());



#endregion

#region Bridge Design Pattern sample 2

IColor hexaRed = new HexColor("FFFFFF");
IColor rgbRed = new RGBColor(255, 0, 0);

Shape circle = new Circle(hexaRed);
Shape circle2 = new Circle(rgbRed);
Shape rectangle = new Rectangle(rgbRed);
Shape rectangle2 = new Rectangle(hexaRed);


circle.Draw();
circle2.Draw();
rectangle.Draw();
rectangle2.Draw();



#endregion

#region Composite Design Pattern sample 1

SCS.Object box1 = new SCS.Box([new Entity("Fish"), new Entity("Tree"), new Entity("Toy")]);
SCS.Object box2 = new SCS.Box([new Entity("Toy"), box1]);

box2.ReviewInnerObjects();



#endregion


#region Strategy Design Pattern sample 1
var fileUploader = new FileUploaderContext();


fileUploader.SetFileUploadStrategy(new AzureBlobFileUploadStrategy());
fileUploader.UploadFile(new byte[] { 1, 2, 3 });


fileUploader.SetFileUploadStrategy(new AWSS3FileUploadStrategy());
fileUploader.UploadFile(new byte[] { 4, 5, 6 });

#endregion

#region Observer Design Pattern

ISubject sender = new NotificationMessagePublisher(new List<ICustomObserver>());
ICustomObserver smsObserver = new SMSObserver();
ICustomObserver mailObserver = new EmailObserver();
ICustomObserver logObserver = new LogObserver();

sender.Subcribe(smsObserver);
sender.Subcribe(mailObserver);
sender.Subcribe(logObserver);

sender.Notify("Emircan");

sender.Unsubcribe(smsObserver);

sender.Notify("Koç");
#endregion

#region Iterator Design Pattern sample 1

PersonAggregate people = new PersonAggregate([
    new("Emircan","Koç",22),
    new("Ahmet","Kılıç",11),
    new ("Hilal","Bıyıklı",23)]);

IIterator peopleIterator = people.GetIterator();

while (peopleIterator.MoveNext())
{
    if (peopleIterator.Current is Person person)
    {
        Console.WriteLine(person);
    }
    else
        Console.WriteLine("Current variable is not a person");

}
//The Following example does not work because the iterator's reset method is not called
while (peopleIterator.MoveNext())
{
    if (peopleIterator.Current is Person person)
    {
        Console.WriteLine(person);
    }
    else
        Console.WriteLine("Current variable is not a person");

}
peopleIterator.Reset();
//The Following example work because the iterator's reset method is called
while (peopleIterator.MoveNext())
{
    if (peopleIterator.Current is Person person)
    {
        Console.WriteLine(person);
    }
    else
        Console.WriteLine("Current variable is not a person");

}


#endregion

#region Template Method Design Pattern sample 1

DataProcessor apiProcessor = new APIDataProccessor();
Console.WriteLine("Processing data from API:");
apiProcessor.Process();

Console.WriteLine();


DataProcessor dbProcessor = new DBDataProcessor();
Console.WriteLine("Processing data from Database:");
dbProcessor.Process();
#endregion

#region Mediator Design Pattern sample 1

Console.WriteLine();
IAirCraftControlTower controlTower = new AirCraftControlTower();

IAirCraft helicopter = new Helicopter(controlTower);
IAirCraft passengerPlane = new PassengerPlane(controlTower);
IAirCraft jet = new Jet(controlTower);

helicopter.SendMessage("Requesting clearance to land.");
passengerPlane.SendMessage("Holding position at 10,000 feet.");
jet.SendMessage("Preparing for takeoff.");

#endregion

#region Command Design Pattern sample 1

Console.WriteLine();

IMusicPlayer player = new MusicPlayer();
IMusicCommand playCommand = new PlayCommand(player);
IMusicCommand stopCommand = new StopCommand(player);
IMusicCommand pauseCommand = new PauseCommand(player);

playCommand.Execute();
pauseCommand.Execute();
pauseCommand.Execute();
stopCommand.Execute();

#endregion

#region Memento Design Pattern sample 1 

var editor = new TextEditor();
var history = new EditorHistory();

editor.CurrentText = "Merhaba, Dünya!";
history.SaveHistory(editor.SaveState());

editor.CurrentText = "Merhaba, Tasarım Desenleri!";
history.SaveHistory(editor.SaveState());

editor.CurrentText = "Son değişiklik yapıldı.";
Console.WriteLine($"Mevcut Metin: {editor.CurrentText}");

editor.RestoreState(history.Undo());
Console.WriteLine($"Geri Alındı: {editor.CurrentText}");

editor.RestoreState(history.Undo());
Console.WriteLine($"Geri Alındı: {editor.CurrentText}");


#endregion

#region Memento Design Pattern sample 2
GameCharacter? gameCharacter = new GameCharacter
{
    CharacterType = CharacterType.Warrior,
    Health = 100,
    AttackPower = 50,
    ExperiencePoints = 2000
};

GameSaveManager saveManager = new();

saveManager.Save(gameCharacter.Save());

Console.WriteLine(gameCharacter);
Console.WriteLine();

gameCharacter.AttackPower += 100;
gameCharacter.Health -= 30;

saveManager.Save(gameCharacter.Save());
Console.WriteLine(gameCharacter);
Console.WriteLine();

gameCharacter.RestoreCharacter(saveManager.Undo());
Console.WriteLine(gameCharacter);
Console.WriteLine();

//gameCharacter.CharacterType = CharacterType.Archer;
//saveManager.Save(gameCharacter.Save());

gameCharacter.RestoreCharacter(saveManager.Redo());
Console.WriteLine(gameCharacter);
Console.WriteLine();




#endregion

#region Chain of Responsibility Design Pattern sample 1

IImageProcessor lowQualityProcessor = new LowQualityImageProcessor();
IImageProcessor mediumQualityProcessor = new MediumQualityImageProcessor();
IImageProcessor highQualityProcessor = new HighQualityImageProcessor();


lowQualityProcessor.SetNextProcessor(mediumQualityProcessor);
mediumQualityProcessor.SetNextProcessor(highQualityProcessor);


Console.WriteLine("Processing images...");

lowQualityProcessor.Process(500);  // LowQualityImageProcessor will process
lowQualityProcessor.Process(800);  // MediumQualityImageProcessor  will process
lowQualityProcessor.Process(1200); // HighQualityImageProcessor  will  process
#endregion

#region Visitor Design Pattern sample 1

Console.WriteLine();

ICharacter warrior = new Warrior();
ICharacter mage = new Mage();
ICharacter floorBoss = new FloorBoss();


IVisitor healthVisitor = new HealthVisitor();
IVisitor damageVisitor = new DamageVisitor();
IVisitor healthDebuffVisitor = new HealtDebuffVisitor();



Console.WriteLine(warrior);
Console.WriteLine(mage);
Console.WriteLine(floorBoss);
Console.WriteLine();

warrior.AcceptVisitor(damageVisitor);
warrior.AcceptVisitor(damageVisitor);

warrior.AcceptVisitor(healthVisitor);

mage.AcceptVisitor(damageVisitor);

floorBoss.AcceptVisitor(healthDebuffVisitor);


Console.WriteLine(warrior);
Console.WriteLine(mage);
Console.WriteLine(floorBoss);

#endregion

#region State Design Pattern sample 1
Console.WriteLine();
var machine = new VendingMachine([new(1, 12), new(2, 20), new(3, 5)]);



//machine.InsertMoney(4);
machine.InsertMoney(12);

machine.SelectProduct(1);


machine.BuyProduct();


Console.WriteLine(machine.ReturnMoney());
#endregion

#region Interpreter Design Pattern sample1

IExpression number1 = new NumberExpression(3);
IExpression number2 = new NumberExpression(2);
IExpression number3 = new NumberExpression(7);

IExpression addEx = new AddExpression(number1, number2);
IExpression subEx = new SubtractExpression(addEx, number3);
Console.WriteLine(subEx.Interpret());



#endregion
