using CSharp_basic_Project1_CleanArch_Calculator.Domain;
using System;
using System.Data;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services.CalculateEngine
{
    /// <summary>
    /// A concrete implementation of <see cref="ICalculateEngine"/> that evaluates mathematical expressions using DataTable.
    /// </summary>
    public class ComputeCalculateEngine : ICalculateEngine
    {
        /// <summary>
        /// Evaluates a mathematical expression and returns the result as a string.
        /// </summary>
        /// <param name="input">The mathematical expression in string format (e.g., "3 + 5 * 2").</param>
        /// <returns>The result of the calculation as a string.</returns>
        /// <exception cref="InvalidExpressionException">
        /// Thrown when the input is null, empty, has a syntax error, attempts division by zero, or any other evaluation error occurs.
        /// </exception>
        public string Evaluate(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new InvalidExpressionException("Input cannot be empty.");

            try
            {
                var result = new DataTable().Compute(input, null);
                return result?.ToString() ?? string.Empty;
            }
            catch (SyntaxErrorException)
            {
                throw new InvalidExpressionException("Invalid expression syntax.");
            }
            catch (DivideByZeroException)
            {
                throw new InvalidExpressionException("Division by zero is not allowed.");
            }
            catch (Exception ex)
            {
                throw new InvalidExpressionException($"Unknown error during calculation: {ex.Message}");
            }
        }
    }
}
