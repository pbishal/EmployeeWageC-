using System;

namespace EmployeeWageComputation
{
    class Program
    {
        public class EmpWageBuilderArray
        {
            public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME = 2;

            private int numOfCompany = 0;
            private CompanyEmpWage[] companyEmpWgeArray;

            public EmpWageBuilderArray()
            {
                this.companyEmpWgeArray = new CompanyEmpWage[5];
            }

            public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
            {
                companyEmpWgeArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
                numOfCompany++;
            }

            public void computeEmpwage()
            {
                for (int i = 0; i < numOfCompany; i++)
                {
                    companyEmpWgeArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWgeArray[i]));
                    Console.WriteLine(this.companyEmpWgeArray[i].toString());
                }
            }

            private int computeEmpWage(CompanyEmpWage companyEmpWage)
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
                        case IS_FULL_TIME:
                            empHrs = 8;
                            break;

                        case IS_PART_TIME:
                            empHrs = 4;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }
                    totalEmpHrs += empHrs;
                    Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs :" + empHrs);
                }
                return totalEmpHrs * companyEmpWage.empRatePerHour;
            }

        }
        public class CompanyEmpWage
        {
            public string company;
            public int empRatePerHour;
            public int numOfWorkingDays;
            public int maxHoursPerMonth;
            public int totalEmpWage;

            public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
            {
                this.company = company;
                this.empRatePerHour = empRatePerHour;
                this.numOfWorkingDays = numOfWorkingDays;
                this.maxHoursPerMonth = maxHoursPerMonth;
            }
            public void setTotalEmpWage(int totalEmpWage)
            {
                this.totalEmpWage = totalEmpWage;
            }

            public string toString()
            {
                return "total emp wage for company :" + this.company + "is:" + this.totalEmpWage;
            }
        }
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpwage();
        }
    }
}






