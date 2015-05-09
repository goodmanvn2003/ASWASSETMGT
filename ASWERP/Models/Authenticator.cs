using ASWERPModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ASWERP.Models
{
    public class Authenticator
    {
        public static List<AuthenticatorRoleVM> Roles = new List<AuthenticatorRoleVM>()
        {
            new AuthenticatorRoleVM() { Id = "CMP", Role = Auth.ROLE_CAN_MANAGE_PROVIDER, Name = "Can Manage Provider" },
            new AuthenticatorRoleVM() { Id = "CMA", Role = Auth.ROLE_CAN_MANAGE_ASSETS, Name = "Can Manage Assets" },
            new AuthenticatorRoleVM() { Id = "CMU", Role = Auth.ROLE_CAN_MANAGE_AUTHENTICATORS, Name = "Can Manage Authenticators" },
            new AuthenticatorRoleVM() { Id = "CMS", Role = Auth.ROLE_CAN_MANAGE_ASSIGNMENTS, Name = "Can Manage Assignments" },
            new AuthenticatorRoleVM() { Id = "CME", Role = Auth.ROLE_CAN_MANAGE_EMPLOYEES, Name = "Can Manage Employees" },
            new AuthenticatorRoleVM() { Id = "CEI", Role = Auth.ROLE_CAN_EXPORT_IMPORT_DOCUMENTS, Name = "Can Export and Import Documents" }
        };

        public string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public bool DoAuthentication(string userName, string passwords)
        {
            var _authenticated = Loader.GetAuthenticators().Any(x => x.Login.Trim() == userName.Trim() && x.Hash.ToLower() == CalculateMD5Hash(passwords.Trim()).ToLower());
            var _authenticatedUser = Loader.GetAuthenticators().FirstOrDefault(x => x.Login.Trim() == userName.Trim() && x.Hash.ToLower() == CalculateMD5Hash(passwords.Trim()).ToLower());

            if (_authenticated)
            {
                Program.CurrentUser = new Auth()
                {
                    LoginId = _authenticatedUser.Guid,
                    LoginRoles = _authenticatedUser.Roles
                };

                return true;
            }  
            else
                return false;
        }
    }
}
