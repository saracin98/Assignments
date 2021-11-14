using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.FactoryMethod
{
    class UserFactory : IPersonFactory
    {
        public IPerson CreatePerson(string name, string email)
        {
            return new User(name,email);
        }
    }
}
