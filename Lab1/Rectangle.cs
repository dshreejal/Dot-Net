using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Rectangle
    {
        //properties is used to initialize instacne variable
        //and return value of instance variable
        //It is same like getter and setter method
        //set is used to intialize instance variable
        private int length;
        private int breadth;

        //using properties
        public int Length
        {
            get { return length; }
            set { this.length = value; }
        }

        public int Breadth
        {
            get { return breadth; }
            set { this.breadth = value; }
        }

        public Rectangle(int length, int breadth) {
            this.length = length;
            this.breadth = breadth;
        }

        public void calcArea()
        {
            int result = length * breadth;
            Console.WriteLine("The Area is: " + result);
        }
    }
}
