using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagePart2
{
    public class PartTimeWage
    {
        public void EmployeeWage()
        {
            //constants
            int parttime = 1;
            int fulltime = 2;
            int wageperhr = 20;

            //variables
            int empwage = 0;
            int emphrs = 0;

            Random random= new Random();
            int empcheck = random.Next(0, 3);
            if(empcheck==parttime)
            {
                emphrs = 8;
                empwage = emphrs * wageperhr;
                Console.WriteLine("Employee Part Time Wage--" + empwage);
            }
            else if(empcheck==fulltime)
            {
                emphrs = 16;
                empwage = emphrs * wageperhr;
                Console.WriteLine("Employee Full Time Wage--" + empwage);
            }
            else
            {
                emphrs = 0;
                empwage = emphrs * wageperhr;
                Console.WriteLine("Employee is Absent");
            }
           

           
        }
    }
}
