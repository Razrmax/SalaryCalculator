using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Salaries.DAL.Entities.Persons
{
    public class User: IdentityUser
    {
        [MaxLength(35)]
        public string FirstName { get; set; }

        [MaxLength(35)]
        public string LastName { get; set; }
    }
}
