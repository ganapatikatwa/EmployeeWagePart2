using System;
namespace EmployeeWagePart2
{
    public class Pragram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem Part 2");
            while(true)
            {
                Console.WriteLine("Select the choice\n1)Employee Present or Absent\n2)Employee Daily Wage" +
                    "\n3)Part Time Wage\n4)Using Switch Case");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        //Creating Object of the class to call in Main method
                        //because method is non static
                        EmployeeAttendance employeeAttendance = new EmployeeAttendance();
                        employeeAttendance.EmpAttendance();
                        break;

                    case 2:
                        EmployeeWage employeeWage=new EmployeeWage();
                        employeeWage.EmpWage();
                        break;

                    case 3:
                        PartTimeWage partTimeWage=new PartTimeWage();
                        partTimeWage.EmployeeWage();
                        break;
                    case 4:
                        SwitchCase switchCase=new SwitchCase();
                        switchCase.EmployeeWage();
                        break;
                }
            }
           
            
        }
    } 
}