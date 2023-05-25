using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageUsingOOPS
{
    internal class EmployeeAttendance
    {
        public void CheckEmployeeAttendance()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();

            int empcheck = random.Next(0, 2);

            if (empcheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
