using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_Out_Of_Range_Exception
{
    internal class Program : System.Exception
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            try
            {
                Console.WriteLine(arr[7]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("An exception has occured" + e.Message);
                Console.ReadKey();
            }
        }
    }
}
