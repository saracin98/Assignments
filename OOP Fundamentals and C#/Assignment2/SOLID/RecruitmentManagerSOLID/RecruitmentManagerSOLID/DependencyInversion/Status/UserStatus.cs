using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagerSOLID.DependencyInversion
{
    class UserStatus
    {
        public string SetStatus(string candidate, string status)
        {
            return $"{candidate} is {status}";
        }
    }
}
