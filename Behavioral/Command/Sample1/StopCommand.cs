namespace Behavioral.Command.Sample1;

public class StopCommand : IMusicCommand
{
    protected readonly IMusicPlayer _musicPlayer;
    public StopCommand(IMusicPlayer musicPlayer) => _musicPlayer = musicPlayer ?? throw new ArgumentNullException("The  IMusic player can not be null");
    public void Execute() => _musicPlayer.Stop();

}
