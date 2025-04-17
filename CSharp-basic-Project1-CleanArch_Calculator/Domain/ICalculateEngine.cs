using System;

namespace CSharp_basic_Project1_CleanArch_Calculator.Domain
{
    /// <summary>
    /// Represents a calculation engine responsible for evaluating mathematical expressions.
    /// </summary>
    public interface ICalculateEngine
    {
        /// <summary>
        /// Evaluates the given mathematical expression and returns the result as a string.
        /// </summary>
        /// <param name="input">The mathematical expression as a string (e.g., "2 + 2 * 5").</param>
        /// <returns>The result of the evaluation as a string.</returns>
        string Evaluate(string input);
    }
}
