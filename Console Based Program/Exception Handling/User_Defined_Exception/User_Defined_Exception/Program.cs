using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Defined_Exception
{
    class UserDefineException : Exception
    {
        public UserDefineException(string str)
        {
            Console.WriteLine(str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            UserDefineException M = new UserDefineException("User Define Exception");
            try
            {
                throw M;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }

}
