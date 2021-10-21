using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagerSOLID.LiskovSubstitution
{
    class Company
    {
        public virtual void GetDescription()
        {
            Console.WriteLine("This is a COMPOANY description!");
        }
    }
}