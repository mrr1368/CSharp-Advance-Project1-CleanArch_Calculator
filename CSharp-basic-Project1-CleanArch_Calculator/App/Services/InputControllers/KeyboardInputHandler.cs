using CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputControllers
{
    /// <summary>
    /// Handles keyboard input for the calculator.
    /// This class listens for key presses and forwards the corresponding input to the input processor.
    /// </summary>
    public class KeyboardInputHandler
    {
        private readonly InputProcessor.InputProcessor _inputProcessor;

        /// <summary>
        /// Event that triggers when the exit process is requested.
        /// </summary>
        public event Action? ExitHandler;

        /// <summary>
        /// Constructor to inject the input processor dependency.
        /// </summary>
        /// <param name="inputProcessor">An instance of the input processor to handle input processing.</param>
        public KeyboardInputHandler(InputProcessor.InputProcessor inputProcessor)
        {
            _inputProcessor = inputProcessor;
            _inputProcessor.ExitProcess += OnExit;
        }

        /// <summary>
        /// Handles the keyboard input by converting the key pressed into a corresponding input string.
        /// It then sends the input to the input processor for further processing.
        /// </summary>
        /// <param name="keyCode">The key pressed on the keyboard.</param>
        /// <returns>Returns true if the input was successfully processed, false otherwise.</returns>
        public bool KeyboardManager(Keys keyCode)
        {
            string input = ConvertKeyToInput(keyCode);

            if (string.IsNullOrEmpty(input)) return false;

            // Forward the input to the input processor for further handling
            _inputProcessor.AddInput(input);

            return true;
        }

        /// <summary>
        /// Converts the key code to the corresponding input string.
        /// </summary>
        /// <param name="keycode">The key code of the pressed key.</param>
        /// <returns>A string representing the corresponding input.</returns>
        private static string ConvertKeyToInput(Keys keycode) => keycode switch
        {
            Keys.D0 or Keys.NumPad0 => "0",
            Keys.D1 or Keys.NumPad1 => "1",
            Keys.D2 or Keys.NumPad2 => "2",
            Keys.D3 or Keys.NumPad3 => "3",
            Keys.D4 or Keys.NumPad4 => "4",
            Keys.D5 or Keys.NumPad5 => "5",
            Keys.D6 or Keys.NumPad6 => "6",
            Keys.D7 or Keys.NumPad7 => "7",
            Keys.D8 or Keys.NumPad8 => "8",
            Keys.D9 or Keys.NumPad9 => "9",
            Keys.Decimal => ".",
            Keys.Add => "+",
            Keys.Subtract => "-",
            Keys.Multiply => "*",
            Keys.Divide => "/",
            Keys.Enter => "ENTER",
            Keys.Back => "BACK",
            Keys.Delete => "DEL",
            Keys.Escape => "ESCAPE",
            Keys.Space => string.Empty,
            _ => string.Empty,
        };

        /// <summary>
        /// Triggers the exit handler event when exit is requested.
        /// </summary>
        public void OnExit()
        {
            ExitHandler?.Invoke();
        }
    }
}
