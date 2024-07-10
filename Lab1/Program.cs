using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("14. Lambda Expression");
            LambdaExpression lambda = new LambdaExpression();
            lambda.setExpression();

            Console.ReadKey();
        }
    }
}
