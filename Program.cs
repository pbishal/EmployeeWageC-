using System;

namespace EmployeeWageComputation
{
    class Program
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATEPER_HR = 20;
        public const int WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 50;

        public static void computeEmpWage()
        {
            //local variables
            int empWage = 0;
            int empHrs = 0;
            int totalEmpWage = 0;
            int hrs = 0;
            int workingDays = 1;

            //inbuilt class
            Random random = new Random();
            while (hrs < MAX_WORKING_HRS && workingDays <= MAX_WORKING_HRS)
            {
                workingDays++;
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
                hrs += empHrs;
                Console.WriteLine("per day employee wage" + empWage);
                totalEmpWage += empWage;

            }

            Console.WriteLine("Employee wage for" + workingDays + "days" + totalEmpWage);
            Console.WriteLine("Working hes" + hrs);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            computeEmpWage();
        }
    }
}