using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services
{
    public class KeyboardInputHandler
    {
        public void KeyboardManager(Keys keyCode, bool isShiftPressed)
        {
            string input = ConvertKeyToInput(keyCode, isShiftPressed);
            //TODO 
        }

        private string ConvertKeyInpu(Keys keycode) => keycode switch
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
            Keys.Back => "BACKSPACE",
            Keys.Delete => "DELETE",
            Keys.Escape => "ESCAPE",
             _ => string.Empty,
        };

        private string ConvertKeyToInput(Keys keyCode, bool isShiftPressed)
        {
            switch (keyCode)
            {
                case Keys.D0: return "0";
                case Keys.D1: return "1";
                case Keys.D2: return "2";
                case Keys.D3: return "3";
                case Keys.D4: return "4";
                case Keys.D5: return "5";
                case Keys.D6: return "6";
                case Keys.D7: return "7";
                case Keys.D8: return "8";
                case Keys.D9: return "9";

                case Keys.NumPad0: return "0";
                case Keys.NumPad1: return "1";
                case Keys.NumPad2: return "2";
                case Keys.NumPad3: return "3";
                case Keys.NumPad4: return "4";
                case Keys.NumPad5: return "5";
                case Keys.NumPad6: return "6";
                case Keys.NumPad7: return "7";
                case Keys.NumPad8: return "8";
                case Keys.NumPad9: return "9";
                case Keys.Decimal: return ".";

                case Keys.Add: return "+";
                case Keys.Subtract: return "-";
                case Keys.Multiply: return "*";
                case Keys.Divide: return "/";

                case Keys.Enter: return "ENTER";
                case Keys.Back: return "BACKSPACE";
                case Keys.Delete: return "DELETE";
                case Keys.Escape: return "ESCAPE";

                default: return string.Empty;
            }
        }
    }
}
