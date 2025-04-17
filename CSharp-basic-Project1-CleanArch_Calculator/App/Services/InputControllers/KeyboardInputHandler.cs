using CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputControllers
{
    public class KeyboardInputHandler
    {
        private readonly InputProcessor.InputProcessor _inputProcessor;
        public event Action? ExitHandler;

        public KeyboardInputHandler(InputProcessor.InputProcessor inputProcessor)
        {
            _inputProcessor = inputProcessor;
            _inputProcessor.ExitProcess += OnExit;
        }

        public bool KeyboardManager(Keys keyCode)
        {
            string input = ConvertKeyToInput(keyCode);

            if (string.IsNullOrEmpty(input)) return false;

            _inputProcessor.AddInput(input);

            return true;
        }

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

        public void OnExit()
        {
            ExitHandler?.Invoke();
        }
    }
}
