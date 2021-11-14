using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagerSOLID.DependencyInversion.StatusRefactored
{
    class UserStatusRefactored : IUserStatus
    {
        public string SetStatus(string candidate, string status)
        {
            return $"{candidate} is {status}";
        }
    }
}
