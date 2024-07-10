using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasics
{
    class ArrayDemo
    {
        public void setArray()
        {
            //id array
            //direct method
            int[] arr1 = { 1, 2, 3 };
            //size
            int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("\nUSING FOR LOOP");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.WriteLine("\nUSING FOREACH");
            foreach (int a in arr2)
            {
                Console.WriteLine(a + " ");
            }
            //2d array
            int[,] arr3 =
            {
                { 20, 30, 40
                },
                { 50, 60, 70
                },
                { 80, 90, 100
                }
            };
            Console.WriteLine("\nUSING FOR LOOP 2D ARRAY");
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    Console.Write(arr3[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\nUSING FOREACH 2D ARRAY");
            foreach (int b in arr3)
            {
                Console.Write(b + " ");
            }
            //jagged array: variation in column
            int[][] ja = new int[3][];
            ja[0] = new int[] { 2, 3, 4 };
            ja[1] = new int[] { 5, 6, 7, 8 };
            ja[2] = new int[] { 7, 8 };
            Console.WriteLine("\nUSING FORLOOP IN JAGGED ARRAY");
            for (int i = 0; i < ja.Length; i++)
            {
                for (int j = 0; j < ja[i].GetLength(0); j++)
                {
                    Console.Write(ja[i][j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\nUSING FOREACH LOOP IN JAGGED ARRAY");
            foreach (int[] i in ja)
            {
                foreach (int j in i)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
