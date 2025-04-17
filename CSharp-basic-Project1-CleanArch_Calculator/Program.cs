using CSharp_basic_Project1_CleanArch_Calculator.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace CSharp_basic_Project1_CleanArch_Calculator
{
    /// <summary>
    /// The main entry class of the application.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point of the calculator application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initializes application configuration (e.g., high DPI settings, default font)
            ApplicationConfiguration.Initialize();

            // Create a new service collection for dependency injection
            var services = new ServiceCollection();

            // Register all services and dependencies
            services.RegisterServices();

            // Build the service provider from registered services
            var serviceProvider = services.BuildServiceProvider();

            // Run the main form using dependency injection
            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }
    }
}
