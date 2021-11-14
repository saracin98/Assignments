using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.exceptions
{
    class InvalidCredentialsException : Exception
    {
        public InvalidCredentialsException()
        {
        }

        public void NullMessage()
        {
            Console.WriteLine($"Username is null");
        }
    }
}
