using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Shape
    {
        // Instance variables
        private double length;
        private double breadth;
        private double height;

        // Default constructor setting length, breadth, and height to 0
        public Shape()
        {
            length = 0;
            breadth = 0;
            height = 0;
        }

        // Constructor with two parameters for length and breadth
        public Shape(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
            height = 0; // Setting height to 0
        }

        // Constructor with three parameters for length, breadth, and height
        public Shape(double length, double breadth, double height)
        {
            this.length = length;
            this.breadth = breadth;
            this.height = height;
        }

        // Method to calculate and display the area of a rectangle
        public void CalcAreaRectangle()
        {
            double area = length * breadth;
            Console.WriteLine("Area of rectangle: " + area);
        }

        // Method to calculate and display the volume of a box
        public void CalcVolumeBox()
        {
            double volume = length * breadth * height;
            Console.WriteLine("Volume of box: " + volume);
        }
    }
}
