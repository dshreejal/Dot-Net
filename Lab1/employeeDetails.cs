using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class EmployeeDetails
    {
        protected int empId;
        protected string empName;
        protected char empGender;
        protected string empAddress;
        protected string empPosition;

        // Constructor to set the details
        public EmployeeDetails(int empId, string empName, char empGender, string empAddress, string empPosition)
        {
            this.empId = empId;
            this.empName = empName;
            this.empGender = empGender;
            this.empAddress = empAddress;
            this.empPosition = empPosition;
        }

        // Method to display the details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Employee ID: {empId}");
            Console.WriteLine($"Name: {empName}");
            Console.WriteLine($"Gender: {empGender}");
            Console.WriteLine($"Address: {empAddress}");
            Console.WriteLine($"Position: {empPosition}");
        }
    }

    class SalaryInfo : EmployeeDetails
    {
        // Additional data member
        private double salary;

        // Constructor to set the value of salary
        public SalaryInfo(int empId, string empName, char empGender, string empAddress, string empPosition, double salary)
            : base(empId, empName, empGender, empAddress, empPosition)
        {
            this.salary = salary;
        }

        // Method to calculate tax and display the final salary
        public void CalcTax()
        {
            double tax = 0;
            if (salary <= 400000)
            {
                tax = salary * 0.01;
            }
            else if (salary > 400000 && salary <= 800000)
            {
                tax = salary * 0.1;
            }
            else
            {
                tax = salary * 0.2;
            }

            double finalSalary = salary - tax;

            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Tax: {tax}");
            Console.WriteLine($"Final Salary: {finalSalary}");
        }
    }
}
