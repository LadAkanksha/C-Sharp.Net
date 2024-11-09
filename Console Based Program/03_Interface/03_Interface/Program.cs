using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Interface
{
    interface ITestInterface1
    {
        void Add(int num1, int num2);
    }

    public class ImplementationClass : ITestInterface1
    {
        //Interface Method Implementation
        public void Add(int num1, int num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
        }
        //This method purely belongs to ImplementationClass
        public void Sub(int num1, int num2)
        {
            Console.WriteLine($"Divison of {num1} and {num2} is {num1 - num2}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ITestInterface1 obj = new ImplementationClass();
            obj.Add(10, 20);

            Console.ReadKey();
        }
    }
}
