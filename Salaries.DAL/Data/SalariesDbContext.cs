using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Salaries.DAL.Entities;
using Salaries.DAL.Entities.Persons;

namespace Salaries.DAL.Data
{
    public class SalariesDbContext: IdentityDbContext<User>
    {
        public SalariesDbContext(DbContextOptions<SalariesDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<HoursCounter> HoursCounters { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Rate> Rates { get; set; }
        
    }
}
