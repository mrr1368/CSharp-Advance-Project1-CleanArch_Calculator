using System;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputProcessor
{
    public class ExitProcessor
    {
        public event Action? ExitRequested;

        public void ExitApp()
        {
            ExitRequested?.Invoke();
        }
    }
}
