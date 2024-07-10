using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Exception is any kind if error that disturb the normal flow of program. if exception occur then whole program is stopped. to deal with such error exception handling mechanism is required
1. try: use to surround a code that can cause error
2. catch: use to handle a exception thrown from try
3. throw: use to throw own exception
4. finally: this block is always executed whether exception occur or not
*/

namespace DotNetBasics
{
    class ExceptionHandling
    {
        public void setData()
        {
            Console.WriteLine("Enter 1st Number: ");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number: ");
            int y = Int32.Parse(Console.ReadLine());
            try
            {
                int div = x / y;
                Console.WriteLine("Division is: " + div);
            }catch(DivideByZeroException ex)
            {
                Console.WriteLine("Cannot DIvide " + ex);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally{
                Console.WriteLine("Code Executed");
            }
            Console.WriteLine("Out of try-catch");


        }
    }
}
