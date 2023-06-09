﻿using System;

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

            UsingSwitchCase switchCase = new UsingSwitchCase();
            switchCase.CheckUsingSwitchCase();

            EmployeeWageForMonth employee2 = new EmployeeWageForMonth();
            employee2.CheckEmployeeWageForMonth();

            EmployeeDayMonthCalculation employeeDay = new EmployeeDayMonthCalculation();
            employeeDay.CheckEmployeeDayMonthCalculation();
        }
    }
}
