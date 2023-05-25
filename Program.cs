using System;

namespace EmployeeWageUsingOOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeAttendance employee = new EmployeeAttendance();
            employee.CheckEmployeeAttendance();

            EmployeeWage employee1 = new EmployeeWage();
            employee1.CheckEmployeeWage();

            PartTimeEmployeeWage part = new PartTimeEmployeeWage();
            part.CheckPartTimeEmployeeWage();
        }
    }
}
