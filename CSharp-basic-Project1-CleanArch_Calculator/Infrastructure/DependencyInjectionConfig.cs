using CSharp_basic_Project1_CleanArch_Calculator.App.Services.CalculateEngine;
using CSharp_basic_Project1_CleanArch_Calculator.App.Services.DisplayManagers;
using CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputControllers;
using CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputEventHandler;
using CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputHandler;
using CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputProcessor;
using CSharp_basic_Project1_CleanArch_Calculator.Domain;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharp_basic_Project1_CleanArch_Calculator.Infrastructure
{
    /// <summary>
    /// Provides extension methods for configuring dependency injection services.
    /// </summary>
    public static class DependencyInjectionConfig
    {
        /// <summary>
        /// Registers all required services and dependencies for the application.
        /// </summary>
        /// <param name="services">The service collection to which the dependencies are added.</param>
        public static void RegisterServices(this IServiceCollection services)
        {
            // UI
            services.AddSingleton<Form1>();

            // Input & Event Handling
            services.AddSingleton<InputEventHandler>();
            services.AddSingleton<KeyboardInputHandler>();
            services.AddSingleton<ButtonInputHandler>();

            // Logic Processing
            services.AddSingleton<InputProcessor>();
            services.AddSingleton<DisplayManager>();
            services.AddSingleton<InputValidator>(); 
            services.AddSingleton<ExitProcessor>();

            // Engine
            services.AddSingleton<ICalculateEngine, ComputeCalculateEngine>();
        }


    }
}
