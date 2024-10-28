using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Dimensional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Book = new string[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\nEnter Book Name For {0}.Row and {1}.column :", i + 1, j + 1);
                    Book[i, j] = Console.ReadLine();
                }
            }
            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine("All The Elements of Book Array is => \n");
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("{0}.{1} - {2}\t", i + 1, j + 1, Book[i, j]);
                }
            }
            Console.ReadKey();

        }
    }
}
