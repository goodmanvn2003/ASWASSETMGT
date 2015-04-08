using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASWERP.Models
{
    public class Authenticator
    {
        private string DefaultUserName
        {
            get
            {
                return "admin";
            }
        }

        private string DefaultPasswords
        {
            get
            {
                return "mran$aswigs";
            }
        }

        public bool DoAuthentication(string userName, string passwords)
        {
            if (userName == DefaultUserName && passwords == DefaultPasswords)
                return true;
            else
                return false;
        }
    }
}
