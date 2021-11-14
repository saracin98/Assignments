using Assignment5.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class UserRepository
    {
        public static List<User> Accounts = new();
        public static List<Exception> ErrorsLog = new(); 
        public static void AddUser(User user)
        {
            Accounts.Add(user);
        }

        public static void Log(Exception exception)
        {
            ErrorsLog.Add(exception);
        }
    }
}
