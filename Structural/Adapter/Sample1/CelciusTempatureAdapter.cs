namespace Structural.Adapter.Sample1
{
    public interface ICelciusTemperatureService
    {
        void SetTemperature(double temp);
    }

    public interface IFahrenheitTemperatureService
    {
        void SetTemperature(double temp);
    }

    public class FahrenheitTemperatureService : IFahrenheitTemperatureService
    {
        public void SetTemperature(double fahrenheit)
        {
            Console.WriteLine($"Fahrenheit value ({fahrenheit}) is added to the DB ");
        }
    }


    public class CelciusToFahrenheitAdapter : ICelciusTemperatureService
    {
        private readonly IFahrenheitTemperatureService _temperatureService;

        public CelciusToFahrenheitAdapter(IFahrenheitTemperatureService temperatureService)
        {
            _temperatureService = temperatureService;
        }

        public void SetTemperature(double celcius)
        {
            var fahrenheit = ConvertCelsiusToFahrenheit(celcius);
            _temperatureService.SetTemperature(fahrenheit);

        }

        private double ConvertCelsiusToFahrenheit(double celsius)
         => (9.0 / 5) * celsius + 32;



    }
}
