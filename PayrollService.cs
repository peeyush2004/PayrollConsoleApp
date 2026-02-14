using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollConsoleApp
{
    public class PayrollService
    {
        public double CalculateGross(Employee emp)
        {
            return emp.BasicSalary + emp.HRA + emp.Allowances + emp.Bonus;
        }

        public double CalculateTotalDeductions(Employee emp) {
            double pfAmount = emp.BasicSalary * emp.PF / 100;
            double gross = CalculateGross(emp);
            double taxAmount = gross * (emp.TaxPercent / 100);
            return pfAmount + taxAmount;
        }

        public double CalculateNetSalary(Employee emp) {
            double gross = CalculateGross(emp);
            double deductions = CalculateTotalDeductions(emp);

            return gross - deductions;
        }
    }
}
