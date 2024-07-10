using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Registration registration = new Registration();
            registration.CreateTable();
            registration.InsertData();
            registration.DisplayData();
            registration.UpdateData();
            registration.DeleteData();
            registration.DisplayMaleFromNepal();

            Console.ReadKey();

        }
    }
}
