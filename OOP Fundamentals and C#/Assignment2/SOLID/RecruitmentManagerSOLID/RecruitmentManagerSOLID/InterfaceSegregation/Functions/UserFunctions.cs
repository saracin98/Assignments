using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagerSOLID.InterfaceSegregation
{
    class UserFunctions : IPerson
    {
        public void SendDesiredSalary()
        {
            throw new NotImplementedException();
        }

        public void SendJobDescription()
        {
            Console.WriteLine("Job description has been sent");
        }
    }
}
