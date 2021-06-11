using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Salaries.DAL.Entities.Interfaces;
using Salaries.DAL.Models;

namespace Salaries.DAL.Entities.Creditables
{
    public class TaxCredit : IAmountable
    {
        public LaborTaxCredit LaborTaxCredit { get; private set; }
        public GeneralTaxCredit GeneralTaxCredit { get; private set; }
        public double Amount { get; set; }

        public TaxCredit()
        {
        }

        public void Calculate(double weeklySalary)
        {
            double annualIncome = weeklySalary * 52.177;
            LaborTaxCredit = new LaborTaxCredit();
            GeneralTaxCredit = new GeneralTaxCredit();
            LaborTaxCredit.Calculate(annualIncome);
            GeneralTaxCredit.Calculate(annualIncome);
            Amount = Math.Round((LaborTaxCredit.Amount + GeneralTaxCredit.Amount) / 52.177, 2);
        }
    }
}
