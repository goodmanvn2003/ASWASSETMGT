using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASWERP.Models
{
    public class Auth
    {
        public const string ROLE_CAN_MANAGE_PROVIDER = "CanManageProvider";
        public const string ROLE_CAN_MANAGE_ASSETS = "CanManageAssets";
        public const string ROLE_CAN_MANAGE_AUTHENTICATORS = "CanManageAuthenticators";
        public const string ROLE_CAN_MANAGE_ASSIGNMENTS = "CanManageAssignments";
        public const string ROLE_CAN_MANAGE_EMPLOYEES = "CanManageEmployees";
        public const string ROLE_CAN_EXPORT_IMPORT_DOCUMENTS = "CanExportImportDocuments";

        public string LoginId { get; set; }
        public List<string> LoginRoles { get; set; }

        public bool HasRole(string roleName)
        {
            bool _result = false;

            if (LoginRoles != null)
            {
                if (LoginRoles.Any())
                {
                    if (LoginRoles.Contains(roleName))
                    {
                        _result = true;
                    }
                }
            }

            return _result;
        }
    }
}
