using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.FactoryMethod
{
    interface IPerson
    {
        string Name { get; set; }
        string Email { get; set; }
        void SendResume();
    }
}
