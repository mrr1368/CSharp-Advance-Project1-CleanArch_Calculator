using CSharp_basic_Project1_CleanArch_Calculator.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services.InputProcessor
{
    public class InputProcessor(ICalculateEngine calculateEngine)
    {
        private readonly ICalculateEngine _calculateEngine = calculateEngine;

        private static readonly char[] Operator = { '+', '-', '*', '/' };

        public event Action<string>? ExitProcess;

        private readonly StringBuilder _input = new();
        private string _result = string.Empty;

        public void AddInput(string input)
        {
            switch (input)
            {
                case "ENTER": Calculate(); break;
                case "BACK": HandleBackSpace(); break;
                case "DEL": DeleteInput(); DeleteResult(); break;
                case "ESCAPE": ExitApp(); break;
            }

            if (_input.Length > 20) return;

            if (CanAddInput(input))
            {
                if (char.IsDigit(input[0]) || input == "." || Operator.Contains(input[0])) _input.Append(input);
            }
        }

        private string Calculate()
        {
            return _result = _calculateEngine.Evaluate(_input.ToString());
        }

        private void HandleBackSpace()
        {
            if (_input.Length > 0)  _input.Remove(_input.Length -1, 1);
        }

        private void DeleteInput()
        {
            _input.Clear();
        }

        private void DeleteResult()
        {
            _result = string.Empty;
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
            if (string.IsNullOrEmpty(_input.ToString())) return !string.IsNullOrEmpty(input) && char.IsDigit(input[0]);

            char lastChar = _input[^1];

            if (input == ".")
            {
                int lastOperatorIndex = _input.ToString().LastIndexOfAny(Operator);

                string lastNumberPart = lastOperatorIndex == -1 ? _input.ToString() : _input.ToString()[(lastOperatorIndex + 1)..];

                if (lastNumberPart.Contains('.')) return false; 

                if (lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/') _input.Append('0');

                return true;
            }

            if (_input.Length > 0 && char.IsDigit(_input[0])) return true;

            if (Operator.Contains(input[0]))
            {
                if (Operator.Contains(lastChar)) return false;

                return true;
            }

            return false;
        }
    }
}
