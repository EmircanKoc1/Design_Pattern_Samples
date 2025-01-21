namespace Behavioral.Mediator.Sample1;

using System.Collections.Generic;

public class AirCraftControlTower : IAirCraftControlTower
{
    private readonly ICollection<IAirCraft> _airCrafts;

    public AirCraftControlTower()
    {
        _airCrafts = new HashSet<IAirCraft>();
    }

    public void RegisterAirCraft(IAirCraft airCraft)
        => _airCrafts.Add(airCraft);

    public void UnregisterAirCraft(IAirCraft airCraft)
        => _airCrafts.Remove(airCraft);

    public void SendMessage(IAirCraft sender, string message)
    {
        foreach (var aircraft in _airCrafts)
        {
            if (!sender.Equals(aircraft))
            {
                aircraft.ReceiveMessage($"From {sender.GetType().Name}: {message}");
            }
        }
    }
}
