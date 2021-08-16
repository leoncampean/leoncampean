// <copyright file="ITimeService.cs" company="Principal33">
// Copyright (c) Principal33. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldWebApp.Services
{
    public interface ITimeService
    {
        public DateTime GetCurrentDate();
    }
}