namespace Behavioral.Command.Sample1;

public class PlayCommand : IMusicCommand
{
    protected readonly IMusicPlayer _musicPlayer;
    public PlayCommand(IMusicPlayer musicPlayer) => _musicPlayer = musicPlayer ?? throw new ArgumentNullException("The  IMusic player can not be null");

    public void Execute() => _musicPlayer.Play();
}
