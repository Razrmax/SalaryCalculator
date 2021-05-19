using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NL_Net_Salary_Calculator.Models
{
    public class Salary
    {
        public double GrossSalary { get; set; }
        public double NetSalary { get; internal set; }
        public double BasePerHourRate { get; set; }
        public List<Rate> Rates { get; private set; }

        public Salary()
        {
            BasePerHourRate = 10.10;
            Rates = new List<Rate> { new Rate ("Overtime", 1.25), new Rate ("Shift Allowance", 1.17),
            new Rate ("Holiday", 2.0), new Rate("Weekend", 1.5)};
        }
    }

    public struct Rate
    {
        public string RateName { get; private set; }
        public double RateMultiplier { get; private set; }

        public Rate(string rateName, double rateMultiplier)
        {
            RateName = rateName;
            RateMultiplier = rateMultiplier;
        }
    }
}
