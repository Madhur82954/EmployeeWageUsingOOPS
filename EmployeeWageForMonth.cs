using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageUsingOOPS
{
    internal class EmployeeWageForMonth
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public void CheckEmployeeWageForMonth()
        {
            int emphrs = 0;
            int empwage = 0;
            int totalempWage = 0;

            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();

                int empcheck = random.Next(0, 3);

                switch (empcheck)
                {
                    case IS_PART_TIME:
                        emphrs = 4;
                        break;
                    case IS_FULL_TIME:
                        emphrs = 8;
                        break;
                    default:
                        emphrs = 0;
                        break;

                }
                empwage = emphrs * EMP_RATE_PER_HOUR;
                totalempWage += empwage;
                Console.WriteLine("Employee wage = " + empwage);
            }
            Console.WriteLine("Total Emp Wage = " + totalempWage);
        }
    }
}
