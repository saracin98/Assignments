using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Builder
{
    public class Profile
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Profile()
        {

        }
        public Profile(ProfileBuilder p)
        {
            Name = p.Name;
            Email = p.Email;
            Phone = p.Phone;
        }

        public string ToString()
        {
            return $"Name: {Name},\nEmail: {Email},\nPhone: {Phone}";
        }
    }
}
