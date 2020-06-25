using System;
using System.Collections.Generic;

namespace ChinookApp.DataConnect.Entities
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employees>();
        }

        public int DeptId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
    }
}
