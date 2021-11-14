using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagerSOLID.OpenClose.ManageProfileRefactored
{
    class ManageProfileRefactored
    {
        public void ViewProfile(List<Person> people)
        {
            foreach(var p in people)
            {
                p.ViewProfile();
            }
        }
    }
}
