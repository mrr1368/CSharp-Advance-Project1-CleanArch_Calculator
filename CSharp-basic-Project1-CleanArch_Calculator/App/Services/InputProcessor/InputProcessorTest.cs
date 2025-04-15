using CSharp_basic_Project1_CleanArch_Calculator.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputProcessor
{
    public class InputProcessorTest
    {
        private readonly ICalculateEngine _calculateEngine;
        private readonly InputValidator _inputValidator;
        private readonly ExitProcessor _exitProcessor;

        private readonly StringBuilder _input = new();
        private string _result = string.Empty;

        public event Action<string>? ExitProcess;

        public InputProcessorTest(ICalculateEngine calculateEngine, InputValidator inputValidator, ExitProcessor exitProcessor)
        {
            _calculateEngine = calculateEngine;
            _inputValidator = inputValidator;
            _exitProcessor = exitProcessor;

            _exitProcessor.ExitRequested += OnExitRequested;
        }

        public void AddInput(string input)
        {

            if (_input.Length > 20) return;

            switch (input)
            {

                case "DEL": DeleteInput(); DeleteResult(); break;

                case "BACK": HandleBackSpace(); break;

                case "ENTER": Calculate(); break;

                case "ESC": _exitProcessor.ExitApp(); break;
            }

            if (_inputValidator.CanAddInput(_input.ToString(), input))
            {
                HashSet<string> operators = new() { "+", "-", "*", "/" };

                if (char.IsDigit(input[0]) || input == "." || operators.Contains(input)) _input.Append(input);
            }
        }

        private string Calculate() => _result = _calculateEngine.Evaluate(_input.ToString());
        private void HandleBackSpace() => _input.Remove(_input.Length - 1, 1);
        private void DeleteInput() => _input.Clear();
        private void DeleteResult() => _result = string.Empty;

        private void OnExitRequested() => ExitProcess?.Invoke("EXIT");

        public string GetInput() => _input.ToString();
        public string GetResult() => _result.ToString();
    }
}
