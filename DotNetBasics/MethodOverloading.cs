using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasics
{
    internal class MethodOverloading
    {
        //method overloading refers to having more than one method that has same name but different number of parameter

        public void calc()
        {
            Console.WriteLine("this is default calc");
        }

        public void calc(int x, int y)
        {
            int result = x + y;
            Console.WriteLine("The sum is: " + result);
        }

        //if number of parameters are same then their datatype should be different
        public void calc(double x, double y)
        {
            double result = x - y;
            Console.WriteLine("The difference is: "+ result);
        }

        //method with return type
        public int calc(int x, int y, int z)
        {
            return (x * y * z);
        }
    }
}
