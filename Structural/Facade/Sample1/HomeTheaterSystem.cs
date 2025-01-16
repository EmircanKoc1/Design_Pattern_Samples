namespace Structural.Facade.Sample1;

public class HomeTheaterSystem
{
    private readonly Television _television;
    private readonly SoundSystem _soundSystem;
    private readonly Lights _lights;
    private readonly Blinds _blinds;

    public HomeTheaterSystem(Television television, SoundSystem soundSystem, Lights lights, Blinds blinds)
    {
        _television = television;
        _soundSystem = soundSystem;
        _lights = lights;
        _blinds = blinds;
    }

    public void StartHomeTheaterSystem()
    {
        _blinds.RollDown();
        _lights.TurnOff();
        _television.TurnOn();
        _soundSystem.TurnOn();

    }

    public void FinishHomeTheaterSystem()
    {

        _blinds.RollUp();
        _lights.TurnOn();
        _television.TurnOff();
        _soundSystem.TurnOff();
    }


}
