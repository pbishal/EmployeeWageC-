using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
         //local variables
         int empWage = 0;
         int empHrs = 0;
         int empRatePerHr = 20;
         //constants
         int PRESENT = 1;
         int EMP_RATEPER_HR = 20;

         //inbuilt class
         Random random = new Random();
         int employeeCheck = random.Next(0, 2);

         Console.WriteLine("Random value" + employeeCheck);
         if (employeeCheck == PRESENT)
         {
            empHrs = 8;
         }
         else
         {
            empHrs = 0;
         }

         empWage = EMP_RATEPER_HR * empHrs;
         Console.WriteLine("Employee wage per day" + empWage);
         Console.ReadLine();
        }
    }
}
