using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagerSOLID.SingleResponsability
{
    public class ProfileRepository
    {
        public void Create(ProfileDTO p)
        {
            ProfileDB.AddProfile(p);
            Console.WriteLine($"Profile with name {p.Name} created");
        }
    }
}
