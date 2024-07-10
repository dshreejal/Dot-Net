using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating...");
        }
    }

    // Single-level inheritance
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking...");
        }
    }

    // Multi-level inheritance
    class Chiuaua : Dog
    {
        public void SmallBark()
        {
            Console.WriteLine("Chiuaua is barking...");
        }
    }
}
