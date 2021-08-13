using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldWebApp.Controllers
{
    public interface IWeatherControllerSettings
    {
        string Longitude { get; set; }
        string Latitude { get; set; }
        string ApiKey { get; set; }
    }
}