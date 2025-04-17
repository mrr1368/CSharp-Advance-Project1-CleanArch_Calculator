using CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputHandler;
using CSharp_basic_Project1_CleanArch_Calculator.App.Services.DisplayManagers;
using CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputControllers;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputEventHandler
{
    public class InputEventHandler
    {
        private readonly KeyboardInputHandler _keyboardInputHandler;
        private readonly ButtonInputHandler _buttonInputHandler;
        private readonly DisplayManager _displayManager;

        public event Action<string, string>? OnDataProcessed;
        public event Action? OnExitRequested;

        public InputEventHandler(KeyboardInputHandler keyboardInputHandler, ButtonInputHandler buttonInputHandler,
                                 DisplayManager displayManager)
        {
            _keyboardInputHandler = keyboardInputHandler;
            _buttonInputHandler = buttonInputHandler;
            _displayManager = displayManager;
            _keyboardInputHandler.ExitHandler += ExitApplication;
        }


        public void KeyDownEventHandler(object? sender, KeyEventArgs e)
        {
            if (_keyboardInputHandler.KeyboardManager(e.KeyCode))
            {
                ProcessData();
            }
        }

        public void ButtonHandler(object? sender, EventArgs e)
        {
            if (sender == null)
            {
                MessageBox.Show("Error: The sender cannot be null. Please try again.",
                        "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            _buttonInputHandler.ButtonManager(sender);
            ProcessData();
        }

        private void ProcessData()
        {
            string inputData = _displayManager.DisplayInputData();
            string resultData = _displayManager.DisplayResultData();
            OnDataProcessed?.Invoke(inputData, resultData);
        }

        public void ExitApplication()
        {
            OnExitRequested?.Invoke();
        }
    }
}
