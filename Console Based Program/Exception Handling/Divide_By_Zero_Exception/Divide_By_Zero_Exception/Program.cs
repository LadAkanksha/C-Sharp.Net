using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_By_Zero_Exception
{
    class Program
    {
        int result;
        Program()
        {
            result = 0;
        }
        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught:" + e);
            }
            finally
            {
                Console.WriteLine("Result : " + result);
            }
        }
        static void Main(string[] args)
        {
            Program d = new Program();
            d.division(25, 0);
            Console.ReadKey();
        }
    }
}
