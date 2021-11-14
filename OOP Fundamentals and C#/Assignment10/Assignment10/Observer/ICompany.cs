using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10.Observer
{
    public interface ICompany
    {
        string Name { get; set; }
        void AddUser(IUser user);
        void Notify();
    }
}
