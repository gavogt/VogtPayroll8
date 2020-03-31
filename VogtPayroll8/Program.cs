using System;

namespace VogtPayroll8
{
    class Program
    {
        static void Main(string[] args)
        {
            Run(new PayrollConsoleReader());
        }

        public static void Run(PayrollConsoleReader payrollConsoleReader)
        {
            Employee emp = default;

            emp = payrollConsoleReader.ReadEmployeeFromConsole();


        }
    }
}
