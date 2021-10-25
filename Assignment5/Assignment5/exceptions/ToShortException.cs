using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.exceptions
{
    class ToShortException : InvalidCredentialsException
    {
        public ToShortException()
        {

        }
        public void ToShortMessage(string password)
        {
            Console.WriteLine($"Password '{password}' is to short!");
        }
    }
}
