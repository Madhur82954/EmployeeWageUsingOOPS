﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageUsingOOPS
{
    internal class EmployeeWage
    {
        public void CheckEmployeeWage()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            int emphrs = 0;
            int empwage = 0;

            Random random = new Random();

            int empcheck = random.Next(0, 2);
            if (empcheck == IS_FULL_TIME)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;
            }
            empwage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage = " + empwage);
        }
    }
}
