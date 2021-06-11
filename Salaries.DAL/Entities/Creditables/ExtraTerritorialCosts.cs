using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Salaries.DAL.Entities.Interfaces;
using Salaries.DAL.Models;

namespace Salaries.DAL.Entities.Creditables
{
    public class ExtraTerritorialCosts : IAmountable
    {
        public double Amount { get; set; }
        public double MinimumWages { get; private set; }
        public double ETCosts { get; private set; }

        public ExtraTerritorialCosts(double minimumWages, double eTCosts)
        {
            MinimumWages = minimumWages;
            ETCosts = eTCosts;
        }

        public void Calculate(double weeklySalary)
        {
            if (MinimumWages >= weeklySalary)
            {
                Amount = 0;
            }
            else
            {
                Amount = weeklySalary * 0.3;
                if (Amount > weeklySalary - MinimumWages)
                {
                    Amount = weeklySalary - MinimumWages;
                }
            }
        }
    }
}
