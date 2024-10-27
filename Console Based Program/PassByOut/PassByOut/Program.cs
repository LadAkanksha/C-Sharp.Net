using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByOut
{
    class Program
    {
        static void square(out int val)
        {
            val = 5;
            val = val * val;
            Console.WriteLine("\nOut Value in Function : " + val);
        }
        static void Main(string[] args)
        {
            int Val;
            square(out Val);
            Console.WriteLine("\nValue After Function Call : " + Val);
            Console.ReadKey();
        }
    }
}
