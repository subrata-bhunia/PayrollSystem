// Ex : 6.1 (ii)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Payroll payroll = new Payroll();
            Table table = new Table();
            Console.Write("Enter Base Salary :");
            double baseSalary = Convert.ToDouble(Console.ReadLine());
            double incomeTax;
            if (baseSalary > 250000)
            {
                Console.Write("Enter Income Tax(%) :");
                incomeTax = Convert.ToDouble(Console.ReadLine());
                payroll.CalculateTotalSalary(baseSalary, incomeTax, out double totalSalary);
                string[] col = { "Base Salary", "Income Tax", "Total Salary","Payble Tax Amount" };
                string[] data = { baseSalary+"", incomeTax+"%", totalSalary+"",(baseSalary-totalSalary)+"" };
                table.ViewTable(col, data);
            }
            else
            {
                Console.WriteLine("Your Base Salary < 250k .");
                Console.WriteLine("Total Salary is {0}", baseSalary);
            }
        }
    }
}
