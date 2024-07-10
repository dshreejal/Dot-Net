using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class LambdaExpression
    {
        public void setExpression()
        {
            List<int> num1 = new List<int>() { 30, 40, 50, 60, 1 };
            List<int> list = num1.FindAll((x => (x % 2) == 0));
            foreach (var res1 in list)
            {
                Console.WriteLine(res1);
            }
        }
    }
}
