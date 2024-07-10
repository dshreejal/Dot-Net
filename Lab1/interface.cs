using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    interface IPerson
    {
        void Greetings();
    }

    class Ram : IPerson
    {
        public void Greetings()
        {
            Console.WriteLine("Hello, I am Shreejal.");
        }
    }
}
