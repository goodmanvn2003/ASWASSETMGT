using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASWERPModels
{
    public class AssetVM
    {
        public const string ID_PREFIX = "ASWAS";
        public const string COMPUTERNAME_PREFIX = "ASW";

        public string Id { get; set; }
        public int AccessId { get; set; }
        public string EmployeeName { get; set; }
        public string XLite { get; set; }
        public string ComputerName { get; set; }
        public string EmailAddress { get; set; }
        public string ComputerType { get; set; }
    }
}
