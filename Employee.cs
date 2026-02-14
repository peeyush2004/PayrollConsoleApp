using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollConsoleApp
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }

        public double BasicSalary { get; set; }
        public double HRA { get; set; }
        public double Allowances { get; set; }
        public double Bonus { get; set; }

        public double PF { get; set; }
        public double TaxPercent { get; set; }

        public Employee(int id, string name, string department, string address) {
            EmployeeId = id;
            Name = name;
            Department = department;
            Address = address;
        }



    }
}
