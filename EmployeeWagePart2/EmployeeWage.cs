using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagePart2
{
    public class EmployeeWage
    {
        public void EmpWage()
        {
            //defined Constants
            int fulltime = 1;
            int waheperhr = 20;

            //variables
            int empwage = 0;
            int emphrs = 0;

            Random random = new Random();
            int empcheck = random.Next(0, 2);

            if (empcheck == fulltime)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;
            }
            empwage = emphrs * waheperhr;
            Console.WriteLine("Employee Wage is--"+empwage);
        }

       
    }
}
