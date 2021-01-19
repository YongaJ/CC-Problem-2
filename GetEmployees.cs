using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_EmployeeHierarchySearch
{
    public class GetEmployees
    {
        public List<Employee> GetReportingEmployees(string userText)
        {
            var empl = new List<Employee>()
            {
              new Employee {EmpId = 001, Hierarchy = 1, Name = "Jason", inManagement = true},
              new Employee {EmpId = 002, Hierarchy = 2, Name = "Jody", inManagement = true},
              new Employee {EmpId = 003, Hierarchy = 3, Name = "Stanton", inManagement = false},
              new Employee {EmpId = 004, Hierarchy = 3, Name = "Andries", inManagement = true},
              new Employee {EmpId = 005, Hierarchy = 4, Name = "Roscoe", inManagement = false},

            };

            var listcheck = empl.Select(x => x.Name).ToList();
            int doesNotExist = 0;


            #region if name exists
            foreach (var name in listcheck)
            {
                if(name == userText)
                {
                    doesNotExist++;
                }
            }

            if (doesNotExist < 1)
            {
                Console.WriteLine(userText + " Does not exist. Please check spelling and try again...");
                return null;
            }

            #endregion
            List<Employee> lineManagerList = new List<Employee>();
            var EmpCount = empl.Count();

            int index = 0;


            for (int i = 0; i < empl.Count; i++)
            {
                if (empl[i].Name == userText)
                {
                    index = i;
                    break;
                }
            }

            if (empl[index].inManagement)
            {
                for (int i = index + 1; i < empl.Count; i++)
                {
                    lineManagerList.Add(empl[i]);
                }
                Console.WriteLine();
                Console.WriteLine("Below people report to {0}", userText);
                Console.WriteLine();

                for (int i = 0; i < lineManagerList.Count; i++)
                {
                    Console.WriteLine(lineManagerList[i].Name);
                }
            }
            else
            {
                Console.WriteLine("{0} is not a line manager", userText);
            }

            return null;
        }
    }
}
