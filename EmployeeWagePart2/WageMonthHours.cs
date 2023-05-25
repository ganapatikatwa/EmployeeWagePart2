using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagePart2
{
    public class WageMonthHours
    {
        public void EmployeeWage()
        {
            //constants
            int day = 1;
            int parttime = 1;
            int fulltime = 2;
            int wageperhr = 20;
            int maxworkingdays = 20;
            int maxworkinghrs = 100;
            //variables
            int empwage = 0;
            int emphrs = 0;
            int totalwage = 0;
            int totalworkingdays = 0;
            int totalhrs = 0;
            //Using while loop to iterate/check the condition is satisfied or not
            while(totalhrs<=maxworkinghrs && totalworkingdays<=maxworkingdays)
            {
                totalworkingdays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case 1:
                        emphrs = 8;
                        
                        break;
                    case 2:
                        emphrs = 16;
                        
                        break;
                    default:
                        
                        break;
                }
                empwage = emphrs * wageperhr;
                Console.WriteLine("One day Employee wage--"+empwage);
                totalhrs += emphrs;
              
            }
            totalwage = totalhrs*wageperhr;
            Console.WriteLine("Total Wage of the Employee for Month--"+totalwage);
        }
    }
}
