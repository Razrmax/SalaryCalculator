using System.Collections.Generic;
using System.Linq;
using Salaries.DAL.Entities.Interfaces;
using Salaries.DAL.Models;

namespace Salaries.DAL.Entities.Creditables
{
    public class LaborTaxCredit : ICalculatable
    {
        public TaxCreditBrackets TaxCreditBrackets { get; }
        internal double Amount { get; set; }

        public LaborTaxCredit()
        {
            TaxCreditBrackets = new TaxCreditBrackets(new List<Bracket> { new Bracket(10108, 4.581, 0), new Bracket(21835, 28.771, 463), new Bracket(35652, 2.663, 3837), new Bracket(105736, 6, 4205) });
        }

        public void Calculate(double weeklySalary)
        {
            if (weeklySalary > TaxCreditBrackets.Brackets.ElementAt(3).Threshold)
                Amount = 0;
            if (weeklySalary > TaxCreditBrackets.Brackets.ElementAt(1).Threshold)
                Amount = TaxCreditBrackets.Brackets.ElementAt(3).CumulativeAmount - (weeklySalary - TaxCreditBrackets.Brackets.ElementAt(2).Threshold) * TaxCreditBrackets.Brackets.ElementAt(3).Rate / 100;
            else if (weeklySalary > TaxCreditBrackets.Brackets.ElementAt(1).Threshold)
                Amount = TaxCreditBrackets.Brackets.ElementAt(2).CumulativeAmount + (weeklySalary - TaxCreditBrackets.Brackets.ElementAt(1).Threshold) * TaxCreditBrackets.Brackets.ElementAt(2).Rate / 100;
            else if (weeklySalary > TaxCreditBrackets.Brackets.ElementAt(0).Threshold)
                Amount = TaxCreditBrackets.Brackets.ElementAt(1).CumulativeAmount + (weeklySalary - TaxCreditBrackets.Brackets.ElementAt(0).Threshold) * TaxCreditBrackets.Brackets.ElementAt(1).Rate / 100;
            else
                Amount = weeklySalary * TaxCreditBrackets.Brackets.ElementAt(0).Rate;
        }
    }
}
