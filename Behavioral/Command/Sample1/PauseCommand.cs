namespace Behavioral.Command.Sample1;

public class PauseCommand : IMusicCommand
{
    protected readonly IMusicPlayer _musicPlayer;
    public PauseCommand(IMusicPlayer musicPlayer) => _musicPlayer = musicPlayer ?? throw new ArgumentNullException("The  IMusic player can not be null");

    public void Execute() => _musicPlayer.Pause();

}
