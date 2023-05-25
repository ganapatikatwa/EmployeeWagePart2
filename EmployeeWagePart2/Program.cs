using System;
namespace EmployeeWagePart2
{
    public class Pragram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem Part 2");
            Console.WriteLine("Check whether employee is Present or Absent");
            //Creating Object of the class to call in Main method
            //because method is non static
            EmployeeAttendance employeeAttendance=new EmployeeAttendance();
            employeeAttendance.EmpAttendance();
        }
    } 
}