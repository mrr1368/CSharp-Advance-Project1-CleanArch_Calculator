using CSharp_basic_Project1_CleanArch_Calculator.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services
{
    public class ComputeCalculateEngine : ICalculatorEngine
    {
        public string Evaluate(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return "Error : Input Must-Not Empty";
            }
            try
            {
                var result = new DataTable().Compute(input, null);
                return result?.ToString() ?? "Error : Input Is Not Correct.";
            }
            catch (Exception ex)
            {
                return "Error : " + ex.Message;
            }
        }
    }
}
