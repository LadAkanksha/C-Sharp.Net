using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Weekdays;
            Weekdays = new string[] { "Sunday", "Monday", "Tuesday", "Wednsday", "Thursday", "Friday", "Saturday" };
            foreach (string days in Weekdays)
            {
                Console.WriteLine(days);
            }
            Console.ReadKey();

        }
    }
}
