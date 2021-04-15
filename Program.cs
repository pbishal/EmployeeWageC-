using System;

namespace EmployeeWageComputation
{
    class Program
    {
       public class EmpWageBuilderObject
        {
            public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME= 2;

            private string company;
            private int empRatePerHour;
            private int numOfWorkingDays;
            private int maxHoursPerMonth;
            private int totalEmpWage;

            public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
            {
                this.company = company;
                this.empRatePerHour = empRatePerHour;
                this.numOfWorkingDays = numOfWorkingDays;
                this.maxHoursPerMonth = maxHoursPerMonth;
            }
            public void computeEmpWage()
            {
                //variables
                int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
                //computation
                while(totalEmpHrs<=this.maxHoursPerMonth && totalWorkingDays<this.numOfWorkingDays)
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
                    Console.WriteLine("Total Emp Wage for company:" + company + "is:" + totalEmpWage);
                }
                totalEmpWage = totalEmpHrs * this.empRatePerHour;
                Console.WriteLine("total emp wage for company:" + company + "is:" + totalEmpWage);
            }
            public string toString()
            {
                return "Total Emp Wage for company:" + this.company + "is:" + this.totalEmpWage;
            }

        }
        static void Main(string[] args)
        {
            EmpWageBuilderObject dmart = new EmpWageBuilderObject("Dmart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            dmart.computeEmpWage();
            Console.WriteLine(dmart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}






