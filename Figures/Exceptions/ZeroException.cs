using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Exceptions
{
    public class ZeroValueException : Exception
    {
        public ZeroValueException() : base("Value cannot be less zero or equal zero")
        {

        }
    }
}
