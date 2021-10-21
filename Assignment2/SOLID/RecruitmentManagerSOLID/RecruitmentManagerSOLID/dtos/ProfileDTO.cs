using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagerSOLID.SingleResponsability
{
    public class ProfileDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public ProfileDTO(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}";
        }
    }
}
