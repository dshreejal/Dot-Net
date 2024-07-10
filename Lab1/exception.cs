using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class ExceptionHandling
    {
        static int a = 10;
        static int b = 0;
        public void Divide()
        {
            try
            {
                int result = a / b;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero exception caught");
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
        }
    }
}
