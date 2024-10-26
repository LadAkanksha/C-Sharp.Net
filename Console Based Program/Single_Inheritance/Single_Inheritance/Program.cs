using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inheritance
{
    class Employee
    {
        public float salary = 40000;
    }
    class Programmer : Employee
    {
        public float bouns = 10000;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Programmer p1 = new Programmer();
            Console.WriteLine("Salary: " + p1.salary);
            Console.WriteLine("Bonus: " + p1.bouns);
            Console.ReadKey();
        }
    }
}
