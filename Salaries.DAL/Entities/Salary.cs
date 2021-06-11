using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salaries.DAL.Entities
{
    public class Salary : Entity
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
}
