using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //for file handling

namespace DotNetBasics
{
     class FileDemo
    {
        public void writeFile()
        {
            //to create a file for writing streamWriter is used
            StreamWriter sw = new StreamWriter("D://abc.txt");
            Console.WriteLine("Enter text to enter");
            string data = Console.ReadLine();
            sw.WriteLine(data);
            sw.Flush(); //clear buffer and write to stream
            sw.Close();
        }

        public void readFile()
        {
            StreamReader sr = new StreamReader("D://abc.txt");
            string data = sr.ReadLine();
            while(data != null)
            {
                Console.WriteLine(data);
                data = sr.ReadLine();
            }
            sr.Close();

        }
    }
}
