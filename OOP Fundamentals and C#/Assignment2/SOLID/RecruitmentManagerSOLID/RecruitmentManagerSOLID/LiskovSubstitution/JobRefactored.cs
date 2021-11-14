using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagerSOLID.LiskovSubstitution
{
    class JobRefactored : Company
    {
        public override void GetDescription()
        {
            Console.WriteLine("Company description is in Job footer");
        }
    }
}
