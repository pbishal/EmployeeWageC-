using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            int present = 1;
            Random randomValue = new Random();
            int employeeCheck = randomValue.Next(0, 2);

            Console.WriteLine("Random value" + employeeCheck);

            if (employeeCheck == present)
                 Console.WriteLine("Employee is present");
            else
                 Console.WriteLine("Employee is absent");

            Console.ReadLine();

        }
    }
}
