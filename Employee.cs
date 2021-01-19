using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_EmployeeHierarchySearch
{
    public class Employee
    {
        public string Name { get; set; }
        public int Hierarchy { get; set; }
        public int EmpId { get; set; }
        public bool inManagement { get; set; }
    }
}
