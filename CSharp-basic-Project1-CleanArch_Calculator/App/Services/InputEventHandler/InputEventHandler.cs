using CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputHandler;
using CSharp_basic_Project1_CleanArch_Calculator.App.Services.DisplayManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputEventHandler
{
    public class InputEventHandler(KeyboardInputHandler keyboardInputHandler, ButtonInputHandler buttonInputHandler,
                                       DisplayManager displayManager)
    {
        private readonly KeyboardInputHandler _keyboardInputHandler = keyboardInputHandler;
        private readonly ButtonInputHandler _buttonInputHandler = buttonInputHandler;
        private readonly DisplayManager _displayManager = displayManager;

        public event Action<string, string>? OnDataProcessed;

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
    }
}
