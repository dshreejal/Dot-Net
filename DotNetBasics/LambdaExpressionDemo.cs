using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 /*
  * Lambda experssion is like a anonymous function except that it doesnot have data type.
  * It uses => symbol which has two part: left side of symbol is inout and right right of symbol is expression or statement
  * symbol => expression or statement
*/

namespace DotNetBasics
{
    class LambdaExpression
    {
        public void setExpression()
        {
            List <int> num1 = new List<int> () { 30,40,50,60,1};
            //using lambda expression to find wether the given number is even or odd
            var result = num1.Select(x => (x % 2) == 0); 

            foreach(var res in result)
            {
                Console.WriteLine(res);
            }
            List<int> list = num1.FindAll((x => (x % 2) == 0));
            foreach(var res1 in list)
            {
                Console.WriteLine (res1);
            }
        }
    }

    //lambda expression in class
    class Employees
    {
        private int id;
        private string name;
        private string deapartment;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name { get { return name; } set { name = value; } }

        public string Department { get {  return deapartment; } set {  deapartment = value; } }


    }
}
