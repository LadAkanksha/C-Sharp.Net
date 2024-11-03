using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Reference_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string value = null;
                if (value.Length == 0)
                {
                    Console.WriteLine(value);
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
