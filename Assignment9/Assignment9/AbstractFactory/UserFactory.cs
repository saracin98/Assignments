using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.AbstractFactory
{
    class UserFactory : RoleFactory
    {
        public override IRole GetEmployee(string UserType)
        {
            throw new NotImplementedException();
        }
    }
}
