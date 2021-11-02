using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11.Proxy
{
    class User : IUser
    {
        public string Role { get ; set; }

        public User(string role)
        {
            Role = role;
        }

        public string CreateProfile()
        {
            return "Profile was created";
        }

        public string NotifyCompany()
        {
            return "Company was notified";
        }

        public string SendResume()
        {
            return "Resume was sent";
        }
    }
}
