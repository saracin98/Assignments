using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.exceptions
{
    class AlreadyUsedException : InvalidCredentialsException
    {
        public AlreadyUsedException()
        {
                
        }
        public void AlreadyUsedMessage(string username)
        {
            Console.WriteLine($"Username {username} already exists!");           
        }
    }
}
