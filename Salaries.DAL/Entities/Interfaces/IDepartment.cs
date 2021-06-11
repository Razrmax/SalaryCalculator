using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salaries.DAL.Entities.Interfaces
{
    internal interface IDepartment
    {
        public ICollection<Department> GetAll();
        public void AddEmployee(Guid Id);
        public void RemoveEmployee(Guid Id);
    }
}
