﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salaries.DAL.Entities.Persons
{
    public class Person : Entity
    {
        public string FirstName { get;  set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
