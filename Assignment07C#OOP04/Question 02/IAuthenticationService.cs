using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment07C_OOP04.Question_02
{
    public interface IAuthenticationService
    {
        public bool AuthenticateUser (string Username, string Password);
        public bool AuthorizeUser(string Username, string Role);
    }
}
