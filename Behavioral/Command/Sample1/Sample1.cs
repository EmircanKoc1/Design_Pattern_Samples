namespace Behavioral.Command.Sample1;

public class MusicPlayer : IMusicPlayer
{
    private bool isPlaying;

    public void Pause()
    {
        if (isPlaying)
        {
            Console.WriteLine("The music has been paused");
            isPlaying = false;
        }
        else
        {
            Console.WriteLine("The music has been played");
            isPlaying = true;
        }

    }


    public void Play()
    {
        if (isPlaying)
        {
            Console.WriteLine("The music is already played");
        }
        else
        {
            Console.WriteLine("The music has been already played");
            isPlaying = true;
        }


    }


    public void Stop()
    {
        if (isPlaying)
        {
            Console.WriteLine("The music has been stopped");
            isPlaying = false;
        }
        else
        {
            Console.WriteLine("The music is already stopped");
        }
    }
}
