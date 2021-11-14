using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Builder
{
    public class ProfileBuilder
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public ProfileBuilder(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }

        public Profile Build()
        {
            Profile profile = new Profile();
            profile.Name = Name;
            profile.Email = Email;
            profile.Phone = Phone;

            return profile;
        }
    }
}
