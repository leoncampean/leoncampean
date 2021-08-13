using HelloWorldWebApp.Controllers;

namespace HelloWorldWebApp
{
    public class WeatherControllerSettings : IWeatherControllerSettings
    {
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string ApiKey { get; set; }
    }
}