using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NL_Net_Salary_Calculator.Models
{
    public class TaxCredit : ICredits
    {
        public LaborTaxCredit laborTaxCredit { get; private set; }
        public GeneralTaxCredit generalTaxCredit { get; private set; }

        public TaxCredit(double grossIncomePerWeek)
        {
            double grossAnnualIncome = grossIncomePerWeek * 13.04;
            laborTaxCredit = new LaborTaxCredit(grossAnnualIncome);
            generalTaxCredit = new GeneralTaxCredit(grossAnnualIncome);
        }

        public void CalculateCredits(double baseAmount)
        {
            double grossAnnualIncome = baseAmount * 13.04;
            laborTaxCredit = new LaborTaxCredit(grossAnnualIncome);
            generalTaxCredit = new GeneralTaxCredit(grossAnnualIncome);
        }
    }
}
