using CSharp_basic_Project1_CleanArch_Calculator.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputProcessor
{
    /// <summary>
    /// Processes the user input, handles validation, and performs calculations.
    /// </summary>
    public class InputProcessor
    {
        private readonly ICalculateEngine _calculateEngine;
        private readonly InputValidator _inputValidator;
        private readonly ExitProcessor _exitProcessor;

        private readonly StringBuilder _input = new();
        private string _result = string.Empty;

        /// <summary>
        /// Event triggered when the exit process is requested.
        /// </summary>
        public event Action? ExitProcess;

        /// <summary>
        /// Initializes a new instance of the <see cref="InputProcessor"/> class.
        /// </summary>
        /// <param name="calculateEngine">The calculation engine used for evaluating input.</param>
        /// <param name="inputValidator">Validates the input before processing.</param>
        /// <param name="exitProcessor">Handles the exit process.</param>
        public InputProcessor(ICalculateEngine calculateEngine, InputValidator inputValidator, ExitProcessor exitProcessor)
        {
            _calculateEngine = calculateEngine;
            _inputValidator = inputValidator;
            _exitProcessor = exitProcessor;

            _exitProcessor.ExitRequested += OnExitRequested;
        }

        /// <summary>
        /// Adds a new input to the calculation string based on user action.
        /// </summary>
        /// <param name="input">The input to be added (e.g., numbers, operators, or commands).</param>
        public void AddInput(string input)
        {
            // Handle special commands like delete, backspace, enter, or escape
            switch (input)
            {
                case "DEL": DeleteInput(); DeleteResult(); break;
                case "BACK": HandleBackSpace(); break;
                case "ENTER": Calculate(); break;
                case "ESCAPE": _exitProcessor.ExitApp(); break;
            }

            // Limit input to 20 characters
            if (_input.Length > 20) return;

            // Validate and add the input if it's allowed
            if (_inputValidator.CanAddInput(_input.ToString(), input))
            {
                var operators = new HashSet<string> { "+", "-", "*", "/" };

                // Allow digits, decimal point, and operators
                if (char.IsDigit(input[0]) || input == "." || operators.Contains(input)) _input.Append(input);
            }
        }

        /// <summary>
        /// Performs the calculation based on the current input string.
        /// </summary>
        /// <returns>The result of the calculation as a string.</returns>
        private string Calculate() => _result = _calculateEngine.Evaluate(_input.ToString());

        /// <summary>
        /// Clears the current input string.
        /// </summary>
        private void DeleteInput() => _input.Clear();

        /// <summary>
        /// Clears the calculation result.
        /// </summary>
        private void DeleteResult() => _result = string.Empty;

        /// <summary>
        /// Triggers the exit process when the exit is requested.
        /// </summary>
        private void OnExitRequested() => ExitProcess?.Invoke();

        /// <summary>
        /// Gets the current input string.
        /// </summary>
        /// <returns>The current input string.</returns>
        public string GetInput() => _input.ToString();

        /// <summary>
        /// Gets the current result of the calculation.
        /// </summary>
        /// <returns>The result as a string.</returns>
        public string GetResult() => _result.ToString();

        /// <summary>
        /// Handles the backspace key by removing the last character from the input.
        /// </summary>
        private void HandleBackSpace()
        {
            if (_input.Length > 0)
                _input.Remove(_input.Length - 1, 1);
        }
    }
}
