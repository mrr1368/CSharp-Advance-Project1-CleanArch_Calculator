using CSharp_basic_Project1_CleanArch_Calculator.App.Services.CalculateEngine;
using CSharp_basic_Project1_CleanArch_Calculator.App.Services.DisplayManager;
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
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<Form1>();
            services.AddSingleton<InputEventHandler>();
            services.AddSingleton<KeyboardInputHandler>();
            services.AddSingleton<ButtonInputHandler>();
            services.AddSingleton<InputProcessor>();
            services.AddSingleton<DisplayManager>();
            services.AddSingleton<ICalculateEngine, ComputeCalculateEngine>();

            services.AddSingleton<InputProcessorTest>();
            services.AddSingleton<InputValidator>(); 
            services.AddSingleton<ExitProcessor>(); 
        }
    }
}
