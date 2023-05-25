using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageUsingOOPS
{
    internal class EmployeeDayMonthCalculation
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HRS_PER_MONTH = 10;
        public void CheckEmployeeDayMonthCalculation()
        {
            int emphrs = 0;
            int totalemphrs = 0;
            int totalworkingdays = 0;

            while (totalemphrs <= MAX_HRS_PER_MONTH && totalworkingdays < NUM_OF_WORKING_DAYS)
            {
                totalworkingdays++;
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
                totalemphrs += emphrs;
                Console.WriteLine("Days# " + totalworkingdays + " Emp Hrs :" + emphrs);
            }
            int totalempwage = totalemphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage = " + totalempwage);
        }
    }
}
