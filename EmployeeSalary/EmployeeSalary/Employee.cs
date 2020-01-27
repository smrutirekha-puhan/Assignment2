using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public abstract class Employee
    {
        public int EmpId;
        public string EmpName;
        public string Designation;
        public int Exp;
        public double AnnualSal;
        public DateTime Date;

        public abstract double CalculateSalary();

    }


    public class HR : Employee
        {
            private double basicsalary;
        

        public override double CalculateSalary()
        {
            double basicsalary = 8000;
            int Exp = 4;
            return basicsalary * 1000 * (Exp);
        }

        
    }

        public class Developer : Employee
        {
            private double basicsalary1;

        public override double CalculateSalary()
            {
            double basicsalary1 = 8000;
            int Exp = 5;
            return basicsalary1 * 2000 * Exp;
            }
        }



    

}
