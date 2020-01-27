using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EmployeeSalary.Employee;

namespace EmployeeSalary
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp = new HR();
            Employee emp2 = new Developer();

            Console.WriteLine("HR Salary :" + emp.CalculateSalary());
            Console.WriteLine("Developer Salary :" + emp2.CalculateSalary());

            Console.ReadKey();

        }
    }
}
