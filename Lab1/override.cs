using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Parent
    {
        public virtual void Display()
        {
            Console.WriteLine("Parent's Display() method");
        }
    }

    class Child : Parent
    {
        public override void Display()
        {
            Console.WriteLine("Child's Display() method");
        }
    }
}
