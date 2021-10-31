using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.FactoryMethod
{
    interface IPersonFactory
    {
        IPerson CreatePerson(string name, string email);
    }
}
