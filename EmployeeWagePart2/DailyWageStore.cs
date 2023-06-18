using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagePart2
{
    public interface IComputeEmpWage3
    {
        public void addCompanyEmpWage3(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        public void computeEmpWage3();

    }
    public class EmpWageBuilderArray3 : IComputeEmpWage3
    {
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;


        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;


        public EmpWageBuilderArray3()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void addCompanyEmpWage3(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }

        public void computeEmpWage3()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage3(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].tostring());
            }
        }

        public int computeEmpWage3(CompanyEmpWage companyEmpWage)
        {
            //variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //computation
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#" + totalWorkingDays + "EmpHrs : " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
        public class CompanyEmpWage
        {
            public string company;
            public int empRatePerHour;
            public int numOfWorkingDays;
            public int maxHoursPerMonth;
            public int totalEmpWage;

            public CompanyEmpWage(string company, int empRatePerHour, int nunumOfWorkingDays, int maxHoursPerMonth)
            {
                this.company = company;
                this.empRatePerHour = empRatePerHour;
                this.numOfWorkingDays = nunumOfWorkingDays;
                this.maxHoursPerMonth = maxHoursPerMonth;
            }
            public void setTotalEmpWage(int totalEmpWage)
            {
                this.totalEmpWage = totalEmpWage;
            }
            public string tostring()
            {
                return "Total Emp Wage for Company : " + this.company + " is " + this.totalEmpWage;
            }

        }
        public interface IEmployeeWage
        {
            public void addCompanyEmpWage3(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
            public int computeEmpWage3(CompanyEmpWage companyEmpWage);
            public void computeEmpWage3();

        }
    }
}
