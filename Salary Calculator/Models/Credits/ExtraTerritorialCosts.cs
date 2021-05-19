using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NL_Net_Salary_Calculator.Models
{
    public class ExtraTerritorialCosts : ICredits
    {
        public double DeductableCosts { get; private set; }
        public double MinimumWages { get; private set; }
        public double ETCosts { get; private set; }

        public ExtraTerritorialCosts(double baseAmount, double minimumWages, double eTCosts)
        {
            MinimumWages = minimumWages;
            ETCosts = eTCosts;
        }

        public void CalculateCredits(double baseAmount)
        {
            if (MinimumWages >= baseAmount)
            {
                DeductableCosts = 0;
            }
            else
            {
                DeductableCosts = baseAmount * 0.3;
                if (DeductableCosts > baseAmount - MinimumWages)
                {
                    DeductableCosts = baseAmount - MinimumWages;
                }
            }
        }
    }
}
