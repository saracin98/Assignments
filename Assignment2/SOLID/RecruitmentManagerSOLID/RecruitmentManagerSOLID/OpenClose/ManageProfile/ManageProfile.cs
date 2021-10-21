using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagerSOLID.OpenClose.ManageProfile
{
    class ManageProfile
    {
        public void ViewProile(List<object> profiles)
        {
            foreach(var p in profiles)
            {
                if(p is User)
                {
                    User user = (User)p;
                    Console.WriteLine($"{user.Username} has role {user.Role}");
                }
                else
                {
                    Candidate candidate = (Candidate)p;
                    Console.WriteLine($"Candidate has the following resume {candidate.Resume}");
                }
            }
        }
    }
}
