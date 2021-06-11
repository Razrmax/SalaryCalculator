using System.Collections.Generic;
using System.Linq;
using Salaries.DAL.Entities.Interfaces;
using Salaries.DAL.Models;

namespace Salaries.DAL.Entities.Creditables
{
    public class GeneralTaxCredit : ICalculatable
    {
        public TaxCreditBrackets TaxCreditBrackets { get; }
        internal double Amount { get; set; }

        public GeneralTaxCredit()
        {
            var brackets = new List<Bracket> { new Bracket(0, 2837, 0), new Bracket(21403, 5.977, 2837), new Bracket(68507, 0, 0) };
            TaxCreditBrackets = new TaxCreditBrackets(brackets);
        }

        public void Calculate(double weeklySalary)
        {
            if (weeklySalary > TaxCreditBrackets.Brackets.ElementAt(2).Threshold)
            {
                Amount = 0;
            }
            else if (weeklySalary > TaxCreditBrackets.Brackets.ElementAt(1).Threshold)
            {
                Amount = TaxCreditBrackets.Brackets.ElementAt(1).CumulativeAmount - (weeklySalary - TaxCreditBrackets.Brackets.ElementAt(0).Threshold) * TaxCreditBrackets.Brackets.ElementAt(1).Rate / 100;
            }
            else
            {
                Amount = TaxCreditBrackets.Brackets.ElementAt(0).Rate;
            }
        }
    }
}
