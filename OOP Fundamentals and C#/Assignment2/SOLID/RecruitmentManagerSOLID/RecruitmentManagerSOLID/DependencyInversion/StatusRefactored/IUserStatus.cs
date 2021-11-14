using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagerSOLID.DependencyInversion.StatusRefactored
{
    interface IUserStatus
    {
        string SetStatus(string candidate, string status);
    }
}
