namespace Behavioral.Mediator.Sample1;

public class Jet : IAirCraft
{
    private readonly IAirCraftControlTower _controlTower;

    public Jet(IAirCraftControlTower controlTower)
    {

        _controlTower = controlTower ?? throw new ArgumentException("The Control Tower can not be null");
        _controlTower.RegisterAirCraft(this);
    }

    public void SendMessage(string message)
    {
        Console.WriteLine($"Jet sending message: {message}");
        _controlTower.SendMessage(this, message);
    }

    public void ReceiveMessage(string message)
    {
        Console.WriteLine($"Jet received message: {message}");
    }
}
