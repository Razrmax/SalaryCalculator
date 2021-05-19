using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NL_Net_Salary_Calculator.Models
{
    public class Tax : IDeductable
    {
        public double TaxAmount { get; private set; }

        public Tax(double annualGrossIncome)
        {
            TaxBrackets.HigherBracket = new Bracket(68507, 49.50, 0);
            TaxBrackets.LowerBracket = new Bracket(0, 37.10, 0);
        }
        
        public void CalculateDeductables(double annualGrossIncome)
        {
            double currentTaxRate = annualGrossIncome > TaxBrackets.HigherBracket.Threshold ? TaxBrackets.HigherBracket.Rate : TaxBrackets.LowerBracket.Rate;
            TaxAmount = annualGrossIncome * currentTaxRate / 100;
        }
    }
}
