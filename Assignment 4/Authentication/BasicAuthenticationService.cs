using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4.Authentication
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        

        public bool AuthenticateUser(string username, string password)
        {
            if (username == "Admin" && password == "Password")
            {
                return true;
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (username == "Admin" && role == "Admin")
            {
                return true;
            }
            return false;
        }
    }
}
