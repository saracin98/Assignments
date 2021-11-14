using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11.Proxy
{
    public class UserProxy : IUser
    {
        private User _user;

        public UserProxy(string role)
        {
            _user = new User(role);
        }

        public string Role { get; set; }

        public string CreateProfile()
        {
            return _user.Role.Equals("user") ? _user.CreateProfile() : "Can not create a profile";
        }

        public string NotifyCompany()
        {
            return _user.Role.Equals("admin") ? _user.CreateProfile() : "Only admins can notify companies";
        }

        public string SendResume()
        {
            return _user.Role.Equals("user") ? _user.CreateProfile() : "Can not send resume";
        }
    }
}
