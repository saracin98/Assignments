using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11.Proxy
{
    interface IUser
    {
        public string Role { get; set; }
        public string SendResume();
        public string NotifyCompany();
        public string CreateProfile();
    }
}
