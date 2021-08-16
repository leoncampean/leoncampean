// <copyright file="IWeatherControllerSettings.cs" company="Principal33">
// Copyright (c) Principal33. All rights reserved.
// </copyright>

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