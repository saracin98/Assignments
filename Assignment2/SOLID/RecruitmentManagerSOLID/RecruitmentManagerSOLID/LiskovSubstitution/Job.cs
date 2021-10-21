using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagerSOLID.LiskovSubstitution
{
    class Job :Company
    {
        public override void GetDescription()
        {
            Console.WriteLine("This is a JOB description");
        }
    }
}
