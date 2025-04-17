using System;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputProcessor
{
    /// <summary>
    /// Validates the input string based on the allowed calculation rules.
    /// Ensures that inputs follow the correct syntax and operations.
    /// </summary>
    public class InputValidator
    {
        private const string Operators = "+-*/";

        /// <summary>
        /// Checks if a new input can be added to the current input.
        /// Ensures that the input adheres to mathematical rules such as:
        /// - Digits can be added
        /// - Operators should not be placed consecutively
        /// - Decimal points can be used only once per number
        /// </summary>
        /// <param name="currentInput">The current input string.</param>
        /// <param name="newInput">The new input character to be added.</param>
        /// <returns>True if the new input is valid, otherwise false.</returns>
        public bool CanAddInput(string currentInput, string newInput)
        {
            // If current input is empty, new input must be a digit
            if (string.IsNullOrEmpty(currentInput))
                return !string.IsNullOrEmpty(newInput) && char.IsDigit(newInput[0]);

            char lastChar = currentInput[^1];  // Get the last character of the current input

            // Handle decimal point ('.') input validation
            if (newInput == ".")
            {
                int lastOperatorIndex = currentInput.LastIndexOfAny(Operators.ToCharArray());
                string lastNumberPart = lastOperatorIndex == -1
                    ? currentInput
                    : currentInput[(lastOperatorIndex + 1)..];

                // Check if the last number part already contains a decimal point
                if (lastNumberPart.Contains('.')) return false;

                // Ensure that the last character is not an operator before adding a decimal
                if (Operators.Contains(lastChar)) return false;

                return true;
            }

            // If the current input starts with a digit, allow adding digits
            if (currentInput.Length > 0 && char.IsDigit(currentInput[0])) return true;

            // Validate operator input: disallow consecutive operators
            if (Operators.Contains(newInput[0]))
            {
                if (Operators.Contains(lastChar)) return false;
                return true;
            }

            return false; // Default case: invalid input
        }
    }
}
