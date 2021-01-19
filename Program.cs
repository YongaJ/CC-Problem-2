using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_EmployeeHierarchySearch
{
    class Program
    {
        static void Main(string[] args)
        {

            var userText = Console.ReadLine();
            var results = new GetEmployees();

            results.GetReportingEmployees(userText);

            Console.ReadLine();

            


        }
    }
}
