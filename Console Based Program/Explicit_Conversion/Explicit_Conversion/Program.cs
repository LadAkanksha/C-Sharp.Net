using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 8526.45;
            float f = (float)d;
            long l = (long)f;
            int i = (int)l;
            Console.WriteLine("Value in Double type : " + d);
            Console.WriteLine("Value in Float type : " + f);
            Console.WriteLine("Value in Long type : " + l);
            Console.WriteLine("Value in Int type : " + i);
            Console.ReadKey();
        }
    }
}
