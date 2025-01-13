namespace Creational.Singleton.Sample1
{
    public class Settings
    {
        private static WindowOptions? _windowOptions;

        public static WindowOptions WindowOptions
            => _windowOptions ??= new WindowOptions();
    }



}

