using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagerSOLID.SingleResponsability
{
    public class ProfileService
    {
        public void CreateProfile(string name, string email)
        {
            ProfileDTO profile = new ProfileDTO(name, email);

            ProfileDB.AddProfile(profile);
            Console.WriteLine($"Profile with name {name} created");

            Console.WriteLine($"Look at this profile {profile.ToString()}");
        }
    }
}
