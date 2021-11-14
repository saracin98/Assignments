using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.AbstractFactory
{
    class Admin : IRole
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string GetRole()
        {
            return "I'm an admin";
        }
    }
}
