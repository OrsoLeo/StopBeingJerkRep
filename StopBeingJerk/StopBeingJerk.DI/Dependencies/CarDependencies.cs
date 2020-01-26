﻿using Microsoft.Extensions.DependencyInjection;
using StopBeingJerk.ApplicationLogic.CarManagement;

namespace StopBeingJerk.DI.Dependencies
{
    public class CarDependencies
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            services.AddTransient<ICarService, CarService>();
        }
    }
}