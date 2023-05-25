using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagePart2
{
    public class EmployeeAttendance
    {
        public void EmpAttendance()
        {
            //UC1--Employee Present or Absent
            int fulltime = 1;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if(empcheck==fulltime)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
