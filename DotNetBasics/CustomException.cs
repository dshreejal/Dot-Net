using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 create a class by inheriting superclass Exception and call the constructor with error message
*/

namespace DotNetBasics
{
    class AgeException: Exception
    {
        public AgeException(string msg) : base(msg) { }
    }
    class CustomException
    {
        public void setAge(int age)
        {
            if(age < 16)
            {
                throw new AgeException("Age cannot be less than 16");
            }
            else
            {
                Console.WriteLine("Welcome");
            }
        }
    }
}
