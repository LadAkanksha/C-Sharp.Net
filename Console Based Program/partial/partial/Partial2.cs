using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial
{
    public partial class PartialClass
    {
        public string getCompleteName()
        {
            return firstName + " " + lastName;
        }
    }
}
