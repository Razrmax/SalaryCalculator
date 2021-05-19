using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NL_Net_Salary_Calculator.Models
{
    public interface IDeductable
    {
        public void CalculateDeductables(double baseAmount);
    }
}
