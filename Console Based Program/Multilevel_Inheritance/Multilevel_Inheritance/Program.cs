using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_Inheritance
{
    class A
    {
        public void show()
        {
            Console.WriteLine("Welcome BCS-III");
        }
    }
    class B : A
    {
        public void display()
        {
            Console.WriteLine("Welcome BCS-III Batch I");
        }
    }
    class C : A
    {
        public void print()
        {
            Console.WriteLine("Welcome BCS-III Batch II");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.show();
            b.display();

            C c = new C();
            c.show();
            c.print();
            Console.ReadKey();
        }
    }
}
