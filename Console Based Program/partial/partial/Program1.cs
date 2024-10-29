using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial
{
    class Program1
    {
        static void Main(string[] args)
        {
            PartialClass obj = new PartialClass();
            obj.FirstName = "Akanksha Lad";
            obj.LastName = "Lad";
            Console.WriteLine("Your Full Name is : " + obj.getCompleteName());
            Console.ReadKey();
        }
    }
}
