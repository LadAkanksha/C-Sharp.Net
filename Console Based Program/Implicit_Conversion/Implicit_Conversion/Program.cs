using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1999;
            long l = i;
            float f = l;
            double d = f;

            Console.WriteLine("Int Value:" + i);
            Console.WriteLine("Long value:" + l);
            Console.WriteLine("Float value:" + f);
            Console.WriteLine("Double value:" + d);
     
            Console.ReadKey();
        }
    }
}
