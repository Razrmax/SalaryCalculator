using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salaries.DAL.Entities.Interfaces
{
    public interface ICalculatable
    {
        public void Calculate(double weeklySalary);
    }
}
