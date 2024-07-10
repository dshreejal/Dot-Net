using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Calculate
    {
        private int num1;
        private int num2;

        // method to set the data
        public void setCalc(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        // method to calculate the sum of num1 and num2 and display the result
        public void calcSum()
        {
            int sum = num1 + num2;
            Console.WriteLine("Sum of " + num1 + " and " + num2 + " is " + sum);
        }

        // method to calculate the multiplication of num1 and num2 and returns the result
        public int calcMulti()
        {
            return num1 * num2;
        }

        // method to calculate the difference between num1 and num2 and display the result
        public void calcDifference()
        {
            int diff = num1 - num2;
            Console.WriteLine("Difference of " + num1 + " and " + num2 + " is " + diff);
        }

    }
}
