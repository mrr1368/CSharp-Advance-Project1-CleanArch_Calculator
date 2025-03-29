using CSharp_basic_Project1_CleanArch_Calculator.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services
{
    public class ComputeCalculateEngine : ICalculateEngine
    {
        public string Evaluate(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "Error: Input cannot be empty.";
            try
            {
                var result = new DataTable().Compute(input, null);
                return result?.ToString() ?? "Error: Unable to compute expression.";
            }
            catch (Exception)
            {
                return "Error: Calculation failed.";
            }
        }
    }
}
