namespace Behavioral.Mediator.Sample1;

public interface IAirCraftControlTower
{
    void SendMessage(IAirCraft sender, string message);
    void RegisterAirCraft(IAirCraft airCraft);
    void UnregisterAirCraft(IAirCraft airCraft);
}
