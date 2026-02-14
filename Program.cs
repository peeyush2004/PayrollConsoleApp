using System.ComponentModel;
using System.Diagnostics;

namespace PayrollConsoleApp
{
    internal class Program
    {
        static List<Employee> employees = new List<Employee>();
        static PayrollService payrollservice = new PayrollService();
        static int employeeCounter = 1;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- Payroll System ---");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. View Employees");
                Console.WriteLine("3. Add Salary Details");
                Console.WriteLine("4. Process Payroll");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;

                    case 2:
                        ViewEmployees();
                        break;

                    case 3:
                        AddSalaryDetails();
                        break;

                    case 4:
                        ProcessPayroll();
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddEmployee()
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Department: ");
            string department = Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            string address = Console.ReadLine();

            Employee emp = new Employee(employeeCounter++, name, department, address);
            employees.Add(emp);

            Console.WriteLine("Employee added successfully");
        }

        static void ViewEmployees()
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID :{emp.EmployeeId}, Name :{emp.Name}, Department :{emp.Department}, Address :{emp.Address}");
            }
        }

        static void AddSalaryDetails()
        {
            Console.WriteLine("Enter Employee ID:");
            int empId = Convert.ToInt32(Console.ReadLine());

            Employee emp = employees.Find(e => e.EmployeeId == empId);

            if (emp == null)
            {
                Console.WriteLine("Employee not found");
                return;
            }
            Console.WriteLine("Enter Basic Salary:");
            emp.BasicSalary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter HRA:");
            emp.HRA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Allowances:");
            emp.Allowances = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Bonus:");
            emp.Bonus = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter PF %: ");
            emp.PF = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Tax %: ");
            emp.TaxPercent = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Salary details added successfully");
        }

        static void ProcessPayroll()
        {
            Console.WriteLine("Enter Employee ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Employee emp = employees.Find(e => e.EmployeeId == id);

            if (emp == null)
            {
                Console.WriteLine("Employee not found");
                return;
            }

            double grossSalary = payrollservice.CalculateGross(emp);
            double totalDeductions = payrollservice.CalculateTotalDeductions(emp);
            double netSalary = payrollservice.CalculateNetSalary(emp);

            Console.WriteLine($"Payroll for Employee ID: {emp.EmployeeId}, Name: {emp.Name}");
            Console.WriteLine($"Gross Salary: {grossSalary}");
            Console.WriteLine($"Total Deductions: {totalDeductions}");
            Console.WriteLine($"Net Salary: {netSalary}");

            Console.ReadKey();


        }
    }
}
