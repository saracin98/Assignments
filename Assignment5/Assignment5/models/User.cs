using Assignment5.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.models
{
    class User
    {
        public int Id { get; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(int id, string username, string password)
        {
#line default
            string u = username + "TEST";

            try
            {
                if (username == null)
                {
                    throw new InvalidCredentialsException();
                }
                UserRepository.Accounts.ForEach(u =>
                {
                    if (u.Username.Equals(username))
                    {
                        throw new AlreadyUsedException();
                    }
                });
            }
            catch (AlreadyUsedException ex)
            {
                UserRepository.Log(ex);
                ex.AlreadyUsedMessage(username);
            }
            catch (InvalidCredentialsException ex)
            {
                UserRepository.Log(ex);
                ex.NullMessage();
            }
            catch(Exception ex)
            {
                UserRepository.Log(ex);
                throw;
            }
            finally
            {
                Id = id;
                Username = username;
                Password = password;
#if DEBUG 
                Console.WriteLine(u);
#endif
            }
        }
    }
}
