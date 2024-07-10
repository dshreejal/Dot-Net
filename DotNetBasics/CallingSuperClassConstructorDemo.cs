using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasics
{
    public class Student
    {
        private int id;
        private string name;
        private string faculty;

        //default constructor:
        public Student()
        {
            Console.WriteLine("\n\nDefault constructor of student:\n");

        }

        public Student(int id, string name, string faculty)
        {
            this.id = id;
            this.name = name;
            this.faculty = faculty;
        }

        public void displayStudent()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name" + name);
            Console.WriteLine("Faculty:" + faculty);
        }
    }

    public class Captain: Student
    {
        public string res;

        public Captain() : base()
        {
            Console.WriteLine("\n\nDefault cons of captain:\n");
        }

        public Captain(string res, int id, string name, string faculty) : base(id, name, faculty)
        {
            this.res = res;
        }

        public void displayCaptain()
        {
            Console.WriteLine("Res is: " + res);
        }
    }


}
