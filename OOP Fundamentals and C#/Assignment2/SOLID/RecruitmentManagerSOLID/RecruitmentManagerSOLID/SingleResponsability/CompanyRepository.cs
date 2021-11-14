using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagerSOLID.SingleResponsability
{
    public class CompanyRepository
    {
        public void NotifyCompany(ProfileDTO p) 
        {
            Console.WriteLine($"Look at this profile {p.ToString()}");
        }
    }
}
