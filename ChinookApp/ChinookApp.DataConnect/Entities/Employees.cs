﻿using System;
using System.Collections.Generic;

namespace ChinookApp.DataConnect.Entities
{
    public partial class Employees
    {
        public Employees()
        {
            EmpDetails = new HashSet<EmpDetails>();
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Ssn { get; set; }
        public int? DeptId { get; set; }

        public virtual Department Dept { get; set; }
        public virtual ICollection<EmpDetails> EmpDetails { get; set; }
    }
}
