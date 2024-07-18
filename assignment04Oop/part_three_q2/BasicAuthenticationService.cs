using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment04Oop.part_three_q2
{
    internal class BasicAuthenticationService : IAuthenticationService
    {

        private string[] usernames = { "saeed", "ahmed" };
        private string[] passwords = { "123", "456" };
        private string[] roles = { "admin", "user" };

        public bool AuthenticateUser(string username, string password)
        {
            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i] == username && passwords[i] == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i] == username && roles[i] == role)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
