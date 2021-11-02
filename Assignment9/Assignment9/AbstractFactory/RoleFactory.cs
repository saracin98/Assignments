using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.AbstractFactory
{
    abstract class RoleFactory
    {
        public abstract IRole GetEmployee(string UserType);

        public static RoleFactory CreateUserFactory(string RoleType)
        {
            return RoleType.Equals("admin") ? new AdminFactory() : new UserFactory();
            
        }
    }
}
