using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Base
    {
        private int id;
        public Base(int id)
        {
            this.id = id;
            Console.WriteLine(id);
        }
    }

    class Derived : Base
    {
        public Derived(int id) : base(id) { }
    }
}
