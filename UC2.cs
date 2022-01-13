using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectAssignment
{
    class UC2
    {
        public void EmpDailyWage()
        {
                int empRatePerHr = 20;
                int empHrs = 8;
                int salary = (empRatePerHr * empHrs);
                Console.WriteLine("Employee Daily Wage is " + salary);
 
        }
    }
}