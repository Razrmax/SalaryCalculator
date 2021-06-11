using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Salaries.DAL.Entities.Creditables;
using Salaries.DAL.Entities.Interfaces;
using Salaries.DAL.Models;

namespace Salaries.DAL.Entities.Deductables
{
    public class Tax : IAmountable
    {
        public double Amount { get; set; }
        private readonly TaxBrackets _taxBrackets;

        public Tax()
        {
            _taxBrackets = new TaxBrackets()
            {
                HigherBracket = new Bracket(68507, 49.50, 0),
                LowerBracket = new Bracket(0, 37.10, 0),
            };
        }

        public void Calculate(double weeklySalary)
        {
            double currentTaxRate = weeklySalary > _taxBrackets.HigherBracket.Threshold
                ? _taxBrackets.HigherBracket.Rate
                : _taxBrackets.LowerBracket.Rate;
            Amount = weeklySalary * currentTaxRate / 100;
        }
    }
}