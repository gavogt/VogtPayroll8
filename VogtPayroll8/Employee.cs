using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll8
{
    class Employee
    {
        private string _empName;
        private int _empHoursWorked;
        private decimal _empPayrate;

        public Employee(string empname, int empHoursWorked, decimal empPayrate)
        {
            _empName = empname;
            _empHoursWorked = empHoursWorked;
            _empPayrate = empPayrate;
        }

        public void DisplayEmpInfo()
        {
            CalcGrossPay();
        }

        public decimal CalcGrossPay()
        {
            if (_empHoursWorked > 40)
            {
                Console.WriteLine($"Gross Pay: {_empPayrate * 40:C2}");
                Console.WriteLine($"(overtime pay): {CalcOvertimePay():C2}");
                return _empPayrate * 40 + CalcOvertimePay();

            }
            else
            {
                Console.WriteLine($"Gross Pay: {_empPayrate * 40:C2}");
                return _empHoursWorked * _empPayrate;

            }
        }

        public decimal CalcOvertimePay()
        {
            int baseHours = 40;
            return ((1.5m * _empHoursWorked) * (_empHoursWorked - baseHours));

        }

        public void DisplayEmployeeInfo(Employee emp)
        {
            CalcGrossPay();

        }
    }
}
