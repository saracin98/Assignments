using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagerSOLID.InterfaceSegregation.FunctionsRefactored
{
    class UserFunctionsRefactored : IUser
    {
        public void SendJobDescription()
        {
            Console.WriteLine("Job description has been sent");
        }
    }
}
