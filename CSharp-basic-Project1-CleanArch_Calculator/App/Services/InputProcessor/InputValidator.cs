using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputProcessor
{
    public class InputValidator
    {
        private static readonly char[] Operator = { '+', '-', '*', '/' };

        public bool CanAddInput(string currentInput, string newInput)
        {
            if (string.IsNullOrEmpty(currentInput))
                return !string.IsNullOrEmpty(newInput) && char.IsDigit(newInput[0]);

            char lastChar = currentInput[^1];

            if (newInput == ".")
            {
                int lastOperatorIndex = currentInput.LastIndexOfAny(Operator);

                string lastNumberPart = lastOperatorIndex == -1 ? currentInput : currentInput[(lastOperatorIndex + 1)..];

                if (lastNumberPart.Contains('.')) return false;

                if (lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/')
                    return false;

                return true;
            }

            if (currentInput.Length > 0 && char.IsDigit(currentInput[0])) return true;

            if (Operator.Contains(newInput[0]))
            {
                if (Operator.Contains(lastChar)) return false;

                return true;
            }

            return false;
        }
    }
}
