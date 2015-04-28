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
            new AuthenticatorRoleVM() { Id = "CMP", Role = "CanManageProvider", Name = "Can Manage Provider" },
            new AuthenticatorRoleVM() { Id = "CMA", Role = "CanManageAssets", Name = "Can Manage Assets" },
            new AuthenticatorRoleVM() { Id = "CMU", Role = "CanManageAuthenticators", Name = "Can Manage Authenticators" },
            new AuthenticatorRoleVM() { Id = "CMS", Role = "CanManageAssignments", Name = "Can Manage Assignments" },
            new AuthenticatorRoleVM() { Id = "CME", Role = "CanManageEmployees", Name = "Can Manage Employees" },
            new AuthenticatorRoleVM() { Id = "CEI", Role = "CanExportImportDocuments", Name = "Can Export and Import Documents" }
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

            if (_authenticated)
                return true;
            else
                return false;
        }
    }
}
