using System;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputProcessor
{
    /// <summary>
    /// Handles the process of exiting the application.
    /// </summary>
    public class ExitProcessor
    {
        /// <summary>
        /// Event triggered when an exit request is made.
        /// </summary>
        public event Action? ExitRequested;

        /// <summary>
        /// Triggers the exit process by invoking the ExitRequested event.
        /// </summary>
        public void ExitApp()
        {
            // Invoke the ExitRequested event to notify that the application should exit
            ExitRequested?.Invoke();
        }
    }
}
