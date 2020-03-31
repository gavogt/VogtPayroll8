﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll8
{
    class PayrollConsoleReader
    {
        public Employee ReadEmployeeFromConsole()
        {
            var empName = "0";
            var hoursWorked = 0;
            var payrate = 0m;
            do
            {
                Console.Write("Enter employee's name or 0 to quit: ");
                empName = Console.ReadLine();
                if (empName == "0")
                {
                    Console.Clear();
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);

                }

                Console.Write("Enter hours worked: ");
                hoursWorked = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter employee's pay rate: ");
                payrate = Convert.ToDecimal(Console.ReadLine());

            } while (empName != "0");


            return new Employee(empName, hoursWorked, payrate);

        }
    }
}