using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class Payroll
    {
        public void CalculateTotalSalary(double baseSalary,double incomeTax,out double totalSalary)
        {
            double amountOfIncomeTax = (baseSalary * incomeTax) / 100;
            totalSalary = (baseSalary - amountOfIncomeTax);
        }
    }
}
