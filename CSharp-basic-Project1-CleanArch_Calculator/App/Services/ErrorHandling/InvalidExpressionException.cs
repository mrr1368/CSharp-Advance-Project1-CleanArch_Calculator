using System;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services.ErrorHandling
{
    /// <summary>
    /// Custom exception class for handling invalid mathematical expressions.
    /// </summary>
    public class InvalidExpressionException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidExpressionException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public InvalidExpressionException(string message) : base(message) { }
    }
}
