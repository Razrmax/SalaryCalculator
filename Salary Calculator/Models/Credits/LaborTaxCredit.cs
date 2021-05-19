using System.Collections.Generic;
using System.Linq;

namespace NL_Net_Salary_Calculator.Models
{
    public class LaborTaxCredit : GeneralTaxCredit
    {
        public LaborTaxCredit(double annualGrossIncome)
        {
            TaxCreditBrackets = new TaxCreditBrackets(new List<Bracket> { new Bracket(10108, 4.581, 0), new Bracket(21835, 28.771, 463), new Bracket(35652, 2.663, 3837), new Bracket(105736, 6, 4205) });
        }

        public new void CalculateCredits(double annualGrossIncome)
        {
            if (annualGrossIncome > TaxCreditBrackets.Brackets.ElementAt(3).Threshold)
                TaxCreditAmount = 0;
            if (annualGrossIncome > TaxCreditBrackets.Brackets.ElementAt(1).Threshold)
                TaxCreditAmount = TaxCreditBrackets.Brackets.ElementAt(3).CumulativeAmount - (annualGrossIncome - TaxCreditBrackets.Brackets.ElementAt(2).Threshold) * TaxCreditBrackets.Brackets.ElementAt(3).Rate / 100;
            else if (annualGrossIncome > TaxCreditBrackets.Brackets.ElementAt(1).Threshold)
                TaxCreditAmount = TaxCreditBrackets.Brackets.ElementAt(2).CumulativeAmount + (annualGrossIncome - TaxCreditBrackets.Brackets.ElementAt(1).Threshold) * TaxCreditBrackets.Brackets.ElementAt(2).Rate / 100;
            else if (annualGrossIncome > TaxCreditBrackets.Brackets.ElementAt(0).Threshold)
                TaxCreditAmount = TaxCreditBrackets.Brackets.ElementAt(1).CumulativeAmount + (annualGrossIncome - TaxCreditBrackets.Brackets.ElementAt(0).Threshold) * TaxCreditBrackets.Brackets.ElementAt(1).Rate / 100;
            else
                TaxCreditAmount = annualGrossIncome * TaxCreditBrackets.Brackets.ElementAt(0).Rate;
        }
    }
}
