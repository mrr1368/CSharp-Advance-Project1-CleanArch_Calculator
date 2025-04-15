using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services.ErrorHandling
{
    public class InvalidExpressionException : Exception
    {
        public InvalidExpressionException(string message) : base(message) { }
    }

}
