 💼 Payroll Console Application (C#)

A simple console-based Employee Payroll Management System built using C#.  
This project demonstrates OOP concepts, salary calculation logic, and menu-driven application flow without using a database.

---

📌 Project Overview

This application allows users to:

- Add Employees
- View Employees
- Add Salary Details
- Process Payroll
- Calculate Gross Salary, Deductions, and Net Salary

All data is stored in memory using a `List<Employee>`.

---

 🏗️ Project Structure
PayrollConsoleApp
│
├── Employee.cs # Model class
├── PayrollService.cs # Business logic (salary calculations)
└── Program.cs # Console UI & menu logic

---

 🧠 Concepts Used

- Object-Oriented Programming (OOP)
- Classes & Objects
- Constructors
- Properties
- Lists (Collection)
- Lambda Expressions
- Reference Types
- Separation of Concerns
- Basic Financial Calculations

---

 👨‍💼 Employee Model

Each employee contains:

- EmployeeId
- Name
- Department
- Address
- Basic Salary
- HRA
- Allowances
- Bonus
- PF %
- Tax %

---

 💰 Salary Calculation Logic

 1️⃣ Gross Salary
Gross = Basic + HRA + Allowances + Bonus

 2️⃣ PF Deduction
PF Amount = BasicSalary × (PF / 100)

 3️⃣ Tax Deduction
Tax Amount = Gross × (TaxPercent / 100)

4️⃣ Total Deductions
Total Deductions = PF Amount + Tax Amount

5️⃣ Net Salary
Net Salary = Gross - Total Deductions


---

 ▶️ How to Run

1. Open the project in Visual Studio
2. Build the solution
3. Run the application
4. Follow the menu options

---

 📋 Application Menu
--- Payroll System ---

Add Employee

View Employees

Add Salary Details

Process Payroll

Exit

---

 ⚠️ Important Notes

- Data is stored temporarily in memory
- Closing the application will erase all data
- No database or file persistence is used in this version

---

 🚀 Future Improvements

- Add JSON file storage (data persistence)
- Add MySQL database integration
- Add input validation
- Add exception handling
- Convert to WPF GUI version
- Implement proper layered architecture
- Add reports and payslip generation

---

🎯 Learning Objective

This project was built to:

- Understand reference types
- Separate business logic from UI logic
- Prepare for database-backed payroll systems
- Strengthen core C# fundamentals

---

 👨‍💻 Author

Built as part of C# learning and system design practice.
