using CSharp_basic_Project1_CleanArch_Calculator.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace CSharp_basic_Project1_CleanArch_Calculator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            services.RegisterServices();

            var serviceProvider = services.BuildServiceProvider();

            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }
    }
}