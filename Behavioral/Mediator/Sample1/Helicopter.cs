namespace Behavioral.Mediator.Sample1;

using System;

public class Helicopter : IAirCraft
{
    private readonly IAirCraftControlTower _controlTower;

    public Helicopter(IAirCraftControlTower controlTower)
    {
        _controlTower = controlTower ?? throw new ArgumentException("The Control Tower can not be null");
        _controlTower.RegisterAirCraft(this);
    }

    public void SendMessage(string message)
    {
        Console.WriteLine($"Helicopter sending message: {message}");
        _controlTower.SendMessage(this, message);
    }

    public void ReceiveMessage(string message)
    {
        Console.WriteLine($"Helicopter received message: {message}");
    }
}
