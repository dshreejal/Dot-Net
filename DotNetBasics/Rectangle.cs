using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasics
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
    }
}
