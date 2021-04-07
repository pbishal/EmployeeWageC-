using System;

namespace EmployeeWageComputation
{
    class Program
    {
        public const int EMP_RATEPER_HR = 20;
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        static void Main(string[] args)
        {
            //local variables
            int empWage = 0;
            int empHrs = 0;
            //int empRatePerHr = 20;
            //constant

            //inbuilt class
            Random random = new Random();
            int employeeCheck = random.Next(0, 3);

            Console.WriteLine("Random value" + employeeCheck);

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
            Console.WriteLine("Employee wage per day" + empWage);
            Console.ReadLine();
        }

    }
}
