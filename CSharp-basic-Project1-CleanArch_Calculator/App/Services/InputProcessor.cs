
using CSharp_basic_Project1_CleanArch_Calculator.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services
{
    public class InputProcessor(ICalculateEngine calculateEngine)
    {
        private readonly ICalculateEngine _calculateEngine = calculateEngine;

        public event Action<string>? ExitProcess;

        private StringBuilder _input = new();
        private string _result = string.Empty;

        public void AddInput(string input)
        {
            switch (input)
            {
                case "ENTER": Calculate(); break;
                case "BACKSPACE": HandleBackSpace(); break;
                case "DELETE": DeleteInput(); break;
                case "ESCAPE": ExitApp(); break;
            }

            if (input.Length > 20) return;

            if (CanAddInput(input))
            {
                HashSet<string> operators = new() { "+", "-", "*", "/" };
                if (char.IsDigit(input[0]) || input == "." || operators.Contains(input)) _input.Append(input);
            }


        }

        private string Calculate()
        {
            return _result = _calculateEngine.Evaluate(_input.ToString());
        }

        private void HandleBackSpace()
        {
            if (_input.Length > 0)  _input.Remove(-1, 1);
        }

        private void DeleteInput()
        {
            _input.Clear();
        }

        private void ExitApp()
        {
            ExitProcess?.Invoke("EXIT");
        }

        public string GetInput()
        {
            return _input.ToString();
        }

        public string GetResult()
        {
            return _result.ToString();
        }

        private bool CanAddInput(string input)
        {
            if (char.IsDigit(_input[0])) return true;
            if (string.IsNullOrEmpty(_input.ToString())) return char.IsDigit(input[0]);

            char lastChar = _input[_input.Length - 1];

            if (input == ".")
            {
                int lastOperatorIndex = _input.ToString().LastIndexOfAny(new char[] { '+', '-', '*', '/' });

                string lastNumberPart = (lastOperatorIndex == -1) ? _input.ToString() : _input.ToString().Substring(lastOperatorIndex + 1);

                if (lastNumberPart.Contains(".")) return false;

                if (lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/') _input.Append("0");

                return true;
            }

            if(input == "+" || input == "-" || input == "*" || input == "/")
            {
                if (lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/') return false;

                return true;
            }

            return false;
        }
    }
}
