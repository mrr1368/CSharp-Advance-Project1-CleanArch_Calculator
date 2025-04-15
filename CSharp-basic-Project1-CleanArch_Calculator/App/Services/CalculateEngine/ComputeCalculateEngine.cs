using CSharp_basic_Project1_CleanArch_Calculator.Domain;
using System;
using System.Data;

namespace CSharp_basic_Project1_CleanArch_Calculator.App.Services.CalculateEngine
{
    public class ComputeCalculateEngine : ICalculateEngine
    {
        public string Evaluate(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new InvalidExpressionException("ورودی نمی‌تواند خالی باشد.");

            try
            {
                var result = new DataTable().Compute(input, null);
                return result?.ToString() ?? string.Empty;
            }
            catch (SyntaxErrorException)
            {
                throw new InvalidExpressionException("ساختار عبارت اشتباه است.");
            }
            catch (DivideByZeroException)
            {
                throw new InvalidExpressionException("تقسیم بر صفر مجاز نیست.");
            }
            catch (Exception ex)
            {
                throw new InvalidExpressionException($"خطای ناشناخته در محاسبه: {ex.Message}");
            }
        }
    }
}
