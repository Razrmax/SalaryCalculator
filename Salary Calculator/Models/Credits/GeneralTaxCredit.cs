using System.Collections.Generic;
using System.Linq;

namespace NL_Net_Salary_Calculator.Models
{
    public class GeneralTaxCredit : ICredits
    {
        public TaxCreditBrackets TaxCreditBrackets { get; protected set; }
        public double TaxCreditAmount { get; protected set; }

        public GeneralTaxCredit(double annualGrossIncome)
        {
            var brackets = new List<Bracket> { new Bracket(0, 2837, 0), new Bracket(21403, 5.977, 2837), new Bracket(68507, 0, 0) };
            TaxCreditBrackets = new TaxCreditBrackets(brackets);
            CalculateCredits(annualGrossIncome);
        }

        public GeneralTaxCredit()
        {
        }

        public virtual void CalculateCredits(double annualGrossIncome)
        {
            if (annualGrossIncome > TaxCreditBrackets.Brackets.ElementAt(2).Threshold)
                TaxCreditAmount = 0;
            else if (annualGrossIncome > TaxCreditBrackets.Brackets.ElementAt(1).Threshold)
                TaxCreditAmount = TaxCreditBrackets.Brackets.ElementAt(1).CumulativeAmount - (annualGrossIncome - TaxCreditBrackets.Brackets.ElementAt(0).Threshold) * TaxCreditBrackets.Brackets.ElementAt(1).Rate / 100;
            else TaxCreditAmount = TaxCreditBrackets.Brackets.ElementAt(0).Rate;
        }
    }
}
