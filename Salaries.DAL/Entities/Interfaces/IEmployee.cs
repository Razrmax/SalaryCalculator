using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salaries.DAL.Entities.Interfaces
{
    public interface IEmployee
    {
        public void AddWeeklyHours(double regularHours, double weekendHours, double holidayHours);
        public void CalculateSalary();
        public void AddSalary(Salary salary);
    }
}
