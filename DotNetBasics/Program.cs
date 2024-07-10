using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box();
            Box b2 = new Box(10, 20, 30);

            Console.WriteLine("Area of Box b1: ");
            b1.calcArea();

            Console.WriteLine("Area of Box b2: ");
            int result = b2.getArea();
            Console.WriteLine(result);

            Console.WriteLine("Example of Properties");
            Rectangle r1 = new Rectangle();

            //calling set of length and breadth
            r1.Length = 10;
            r1.Breadth = 10;

            //calling get of Length and Breadth
            Console.WriteLine("length is: " + r1.Length);
            Console.WriteLine("breadth is: " + r1.Breadth);



            Console.WriteLine("Example on method overlaoding");

            MethodOverloading c1 = new MethodOverloading();

            //calling 1st method;
            c1.calc();
            c1.calc(2, 3);
            c1.calc(10.0, 5.0);
            int data = c1.calc(1, 2, 3);
            Console.WriteLine("Multiplication is: " + data);


            //Single Level Inheritance example
            Console.WriteLine("Single Level Inheritacne example");

            //creating object of child
            Teacher t1 = new Teacher();
            t1.setEmp(1, "John Doe", "Kathmandu", "CSIT");

            Console.WriteLine("\nEmployee details: ");
            t1.displayEmployee();

            //setting Teacher details
            t1.setTeacher("Computer Science", "50000");
            t1.displayTeacher();

            //creating object of parent
            Employee e1 = new Employee();
            Console.WriteLine("\nEmployee details :");
            e1.setEmp(2, "Ram Thapa", "Pokhara", "Programming");
            e1.displayEmployee();


            //multilevel Inheritance:
            Console.WriteLine("\n*********** Example on multilevel inheritance **************\n");

            //creating object of electric bike:
            ElectricBike eb = new ElectricBike();
            //using grandparent (two wheeler properties):
            eb.Reg = 2;
            eb.Name = "P10";
            eb.Brand = "Yatri";

            //using property of child( bike)
            eb.Cc = "--";
            eb.FuelCapacity = "--";

            //using property of own (Electric Bike)
            eb.Range = "300km";
            Console.WriteLine("Reg: " + eb.Reg);
            Console.WriteLine("Name: " + eb.Name);
            Console.WriteLine("Brand: " + eb.Brand);
            Console.WriteLine("CC: " + eb.Cc);
            Console.WriteLine("Fuel: " + eb.FuelCapacity);
            Console.WriteLine("Range:" + eb.Range);

            //creating object of parent(bike)

            Bike bk = new Bike();
            bk.Reg = 3;
            bk.Name = "Pulsar";
            bk.Brand = "Yamaha";
            bk.Cc = "220";
            bk.FuelCapacity = "15l";

            Console.WriteLine("\n\nReg: " + bk.Reg);
            Console.WriteLine("Name: " + bk.Name);
            Console.WriteLine("Brand: " + bk.Brand);
            Console.WriteLine("CC: " + bk.Cc);
            Console.WriteLine("Fuel: " + bk.FuelCapacity);

            Console.WriteLine("\nExample of Calling Super Class Constructor");

            // Creating an instance of Captain, which will call the Student constructor implicitly
            Captain c = new Captain("Some Result", 123, "John Doe", "Computer Science");

            // Displaying information using Captain's method
            c.displayCaptain();
            c.displayStudent();


            Console.WriteLine("\nExample of method overriding in class\n");

            Solutions solutions = new Solutions();
            solutions.calc1();
            solutions.calc2(1, 2);

            Console.WriteLine("\nExample of exception handling");
            ExceptionHandling ex = new ExceptionHandling();

            ex.setData();

            Console.WriteLine("\nExample of custom exception");

            CustomException customEx = new CustomException();


            try
            {
                customEx.setAge(0);
            }
            catch (AgeException a)
            {
                Console.WriteLine(a);
            }

            //File handling
            Console.WriteLine("\nExample of file handling");
            FileDemo f = new FileDemo();

            f.writeFile();
            f.readFile();

            //Array Demo
            Console.WriteLine("\nExample of Arrays:");
            ArrayDemo arr = new ArrayDemo();
            arr.setArray();

            //Lambda Expression
            Console.WriteLine("\nExample of Lambda Expression");
            LambdaExpression l1 = new LambdaExpression();
            l1.setExpression();

            Console.WriteLine("\nUsing lambda expression in class");
            //creating list of object and arrranging in ascending order
            List<Employees> em = new List<Employees>()
            {
                new Employees{
                Id = 1,
                Name="ram",
                Department = "it"},

                new Employees
                {
                    Id = 2,
                    Name = "shyam",
                    Department = "hr"
                }
            };
            var sortByName = em.OrderBy(e => e.Name);
            foreach (var re in sortByName)
            {
                Console.WriteLine("Id is " + re.Id + " Name is " + re.Name);
            }

            Console.ReadKey();
        }
    }
}
