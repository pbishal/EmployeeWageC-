using System;

namespace EmployeeWageComputation
{
    class Program
    {
        public const int EMP_RATEPER_HR = 20;
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int WORKING_DAYS = 20;
        static void Main(string[] args)
        {
            //local variables
            int empWage = 0;
            int empHrs = 0;
            int totalEmpWage = 0;
            int hrs = 0;
            int workingDays = 1;
            //int empRatePerHr = 20;
            //constant

            //inbuilt class
            Random random = new Random();
            for (int day = 0; day < WORKING_DAYS; day++)
            {
                int employeeCheck = random.Next(0, 3);
                switch (employeeCheck)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        break;

                    case PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }

                //computation
                empWage = EMP_RATEPER_HR * empHrs;
                Console.WriteLine("per day employee wage" + empWage);
                totalEmpWage += empWage;
                
            }
            Console.WriteLine("Employee wage for 20 days" + totalEmpWage);
            Console.ReadLine();

        }
    }
}