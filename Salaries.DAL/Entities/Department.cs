using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Salaries.DAL.Entities.Interfaces;

namespace Salaries.DAL.Entities
{
    internal class Department : Entity, IDepartment
    {
        public string Name { get; set; }
        public ICollection<Guid> EmployeesIds { get; private set; }

        public ICollection<Department> GetAll()
        {
            throw new NotImplementedException();
        }

        public void AddEmployee(Guid Id)
        {
            EmployeesIds.Add(Id);
        }

        public void AddEmployee(ICollection<Guid> Ids)
        {
            foreach (var id in Ids)
            {
                EmployeesIds.Add(id);
            }
        }

        public void RemoveEmployee(Guid Id)
        {
            EmployeesIds.Remove(Id);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
