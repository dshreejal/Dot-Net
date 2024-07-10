using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// method overriding: if superclass and sub class have same method (same name, same return type and same parameter).
// to call overridden method of superclass from subclass base keyword is used.

//for method overriding, two keywords are used:
// 1. virtual: represent overiden method in super class
// 2. override: represnt overriden method in sub class

namespace DotNetBasics
{
    class Calcualtions
    {
        public virtual void calc1()
        {
            Console.WriteLine("Default method of calc");
        }

        public virtual void calc2(int x, int y) 
        { 
            Console.WriteLine("Sum is "+ (x+y));
        }
    }

    class Solutions: Calcualtions
    {
        public  override void calc1()
        {
            base.calc1();
            Console.WriteLine("Default method of sub class");
        }

        public  override void calc2(int x, int y)
        {
             base.calc2(x, y);
            Console.WriteLine("Sub Class Sum is " + (x + y));
        }
    }
}
