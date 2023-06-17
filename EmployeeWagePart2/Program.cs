﻿using System;
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
                    "\n3)Part Time Wage\n4)Using Switch Case\n5)Wage for Month\n6)Wages for Month and Hours" +
                    "\n7)Refactor Class and Method\n8)Multiple Companies\n9)Wage for Each Company\n" +
                    "10)Multiple Companies in Array");
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
                    case 5:
                        WageForMonth wageForMonth=  new WageForMonth();
                        wageForMonth.EmployeeWage();
                        break;
                    case 6:
                        WageMonthHours wagemonthhours=new WageMonthHours();
                        wagemonthhours.EmployeeWage();
                        break;
                    case 7:
                        RefactorClassMethod refactorClassMethod=new RefactorClassMethod();
                        refactorClassMethod.EmployeeWage();
                        break;
                    case 8:
                        MultipleCompany multipleCompany=new MultipleCompany();
                        multipleCompany.EmployeeWage("D Mart", 30, 24, 150);
                        multipleCompany.EmployeeWage("IOCL", 80, 28,120 );
                        break;
                    case 9:
                        EmpBuilder dmart = new EmpBuilder("DMart",15,24,192);
                        dmart.computeEmpWage();
                        Console.WriteLine(dmart.ToString());
                        break;
                    case 10:
                        EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();
                        empWageBuilderArray.addCompanyEmpWage("DMart", 20, 2, 10);
                        empWageBuilderArray.addCompanyEmpWage("Reliance", 10, 4, 20);
                        empWageBuilderArray.computeEmpWage();
                        break;
                    case 11:
                        EmpWageBuilderArray1 empWageBuilderArray1 = new EmpWageBuilderArray1();
                        empWageBuilderArray1.addCompanyEmpWage("DMart", 20, 2, 10);
                        empWageBuilderArray1.addCompanyEmpWage("Reliance", 10, 4, 20);
                        empWageBuilderArray1.computeEmpWage();
                        break;
                }
            }
           
            
        }
    } 
}