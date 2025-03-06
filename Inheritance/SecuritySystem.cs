using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    sealed class SecuritySystem
    {
        public bool AuthenticateUser(string username, string password)
        {
            // Authentication logic here
            return username == "admin" && password == "password";
        }
    }
}
