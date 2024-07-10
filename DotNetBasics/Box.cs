using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasics
{
    internal class Box
    {
        private int length;
        private int breadth;
        private int height;

        public Box()
        {
            this.length = 0;
            this.breadth = 0;
            this.height = 0;
        }

        public Box(int length, int breadth, int height)
        {
            this.length = length;
            this.breadth = breadth;
            this.height = height;
        }

        //method that doesnot return value
        public void calcArea()
        {
            int result = this.length * this.breadth * this.height;
            Console.WriteLine("The Area of Box is: " + result);
        }

        //method that return value
        public int getArea()
        {
            return this.length * this.breadth * this.height;
        }
    }
}
