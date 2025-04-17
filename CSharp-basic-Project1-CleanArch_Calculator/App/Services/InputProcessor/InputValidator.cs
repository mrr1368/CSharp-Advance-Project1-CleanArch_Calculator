using System;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputProcessor
{
    public class InputValidator
    {
        private const string Operators = "+-*/";

        public bool CanAddInput(string currentInput, string newInput)
        {
            if (string.IsNullOrEmpty(currentInput))
                return !string.IsNullOrEmpty(newInput) && char.IsDigit(newInput[0]);

            char lastChar = currentInput[^1];

            if (newInput == ".")
            {
                int lastOperatorIndex = currentInput.LastIndexOfAny(Operators.ToCharArray());

                string lastNumberPart = lastOperatorIndex == -1
                    ? currentInput
                    : currentInput[(lastOperatorIndex + 1)..];

                if (lastNumberPart.Contains('.')) return false;

                if (Operators.Contains(lastChar)) return false;

                return true;
            }

            if (currentInput.Length > 0 && char.IsDigit(currentInput[0])) return true;

            if (Operators.Contains(newInput[0]))
            {
                if (Operators.Contains(lastChar)) return false;

                return true;
            }

            return false;
        }
    }
}
