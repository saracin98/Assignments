using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.AbstractFactory
{
    interface IRole
    {
        string Name { get; set; }
        string Email { get; set; }

        string GetRole();
    }
}
