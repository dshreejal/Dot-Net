using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//inheritance is a process of acquiring properties of one class by another class. It is used to reuse code and to reduce code redundancy
//Its types are
// 1. Single Level : if one or more child inherits one parent
// 2. Multi Level: if first class gets inherited by second and second class gets inherited by third and so on.
// 3. Multiple : if one child class can inherit more than one parent. (only possible using interface)

namespace DotNetBasics
{
    class Employee
    {
        private int eid;
        private string name;
        private string address;
        private string department;

        //method to set instance variable
        public void setEmp(int eid, string name, string address, string department)
        {
            this.eid = eid;
            this.name = name;
            this.address = address;
            this.department = department;
        }

        public void displayEmployee()
        {
            Console.WriteLine("Id is :" + this.eid);
            Console.WriteLine("Name is :" + this.name);
            Console.WriteLine("Address is :" + this.address);
            Console.WriteLine("Department is :" + this.department);
        }
    }

    //creating child class that will inherit Employee class
    
    //Teacher is child, Employee is parent
    class Teacher: Employee
    {
        private string specialization;
        private string salary;

        //method to initialzie teacher

        public void setTeacher(string specialization, string salary)
        {
            this.specialization = specialization;
            this.salary = salary;
        }

        public void displayTeacher()
        {
            Console.WriteLine("Specialization is :" + this.specialization);
            Console.WriteLine("Salary is: " + this.salary);
         }
    }
}
