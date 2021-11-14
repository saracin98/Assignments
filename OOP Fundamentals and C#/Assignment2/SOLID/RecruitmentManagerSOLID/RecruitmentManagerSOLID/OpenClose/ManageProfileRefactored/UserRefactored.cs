using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagerSOLID.OpenClose.ManageProfileRefactored
{
    class UserRefactored : Person
    {
        public string Username { get; set; }
        public string Role { get; set; }
        public UserRefactored(string username, string role)
        {
            Username = username;
            Role = role;
        }
        public void ViewProfile()
        {
            Console.WriteLine($"{Username} has role {Role}");
        }
    }
}
