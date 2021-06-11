using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Salaries.DAL.Entities.Interfaces;

namespace Salaries.DAL.Entities.Persons
{
    public class Employee : Person, IEmployee
    {
        public Guid DepartmentId { get; set; }
        public Position Position { get; set; }
        public HoursCounter HoursCounter { get; set; }
        public ICollection<Salary> Salaries { get; set; }

        public void AddWeeklyHours(double regularHours, double weekendHours, double holidayHours)
        {
            throw new NotImplementedException();
        }

        public void CalculateSalary()
        {
            throw new NotImplementedException();
        }

        public void AddSalary(Salary salary)
        {
            throw new NotImplementedException();
        }
    }
}