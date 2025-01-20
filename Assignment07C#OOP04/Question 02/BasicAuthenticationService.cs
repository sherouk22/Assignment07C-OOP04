using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment07C_OOP04.Question_02
{
       public class BasicAuthenticationService : IAuthenticationService
    {

        public string Username { get; set; }
        public string Password { get; set; }

        public string Role {  get; set; }


        public BasicAuthenticationService(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
        public BasicAuthenticationService(string username, string password)
        {
        }

        public  bool AuthenticateUser(string Username, string Password)
        {
            if (Username == this.Username && Password == this.Password)
                return true;
            else
                return false;
        }

         public bool AuthorizeUser(string Username, string Role)
        {
            if (Username == this.Username && Role == this.Role)
                return true;
            else
                return false;
        }
    }
}
    