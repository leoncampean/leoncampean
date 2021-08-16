// <copyright file="WeatherControllerSettings.cs" company="Principal33">
// Copyright (c) Principal33. All rights reserved.
// </copyright>

using HelloWorldWebApp.Controllers;
using Microsoft.Extensions.Configuration;

namespace HelloWorldWeb
{
    public class WeatherControllerSettings : IWeatherControllerSettings
    {
        public WeatherControllerSettings(IConfiguration configurationSettings)
        {
            Longitude = configurationSettings["WeatherForecast:Longitude"];
            Latitude = configurationSettings["WeatherForecast:Latitude"];
            ApiKey = configurationSettings["WeatherForecast:ApiKey"];
        }

        public string Longitude { get; set; }

        public string Latitude { get; set; }

        public string ApiKey { get; set; }
    }
}