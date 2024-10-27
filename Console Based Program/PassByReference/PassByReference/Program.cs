using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByReference
{
    class Program
    {
        static void square(ref int val)
        {
            val = val * val;
            Console.WriteLine("\nReference Value in Function : " + val);
        }
        static void Main(string[] args)
        {
            int Val = 10;
            Console.WriteLine("\nValue Before Calling The Function : " + Val);
            square(ref Val);
            Console.WriteLine("\nValue After Function Call : " + Val);
            Console.ReadKey();
        }
    }
}
