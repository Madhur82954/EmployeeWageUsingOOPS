using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageUsingOOPS
{
    internal class UsingSwitchCase
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public void CheckUsingSwitchCase()
        {
            int emphrs = 0;
            int empwage = 0;

            Random random = new Random();

            int empcheck = random.Next(0, 2);
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
            Console.WriteLine("Employee wage = " + empwage);
        }
    }
}
