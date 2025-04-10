using CSharp_basic_Project1_CleanArch_Calculator.App.Services;
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
            services.AddSingleton<InputEventHandler>();
            services.AddSingleton<KeyboardInputHandler>();
            services.AddSingleton<ButtonHandler>();
            services.AddSingleton<InputProcessor>();
            services.AddSingleton<ICalculateEngine, ComputeCalculateEngine>();
        }
    }
}
