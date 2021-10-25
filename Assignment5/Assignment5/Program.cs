using Assignment5.models;
using System;
using System.Diagnostics;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("asd");
            UserRepository.AddUser(new User(1,"user", "pass"));
            UserRepository.AddUser(new User(2,"user", "pass"));
            UserRepository.AddUser(new User(3, null, "pass"));

            UserRepository.ErrorsLog.ForEach(e => Console.WriteLine(e.StackTrace));
        }
    }
}
