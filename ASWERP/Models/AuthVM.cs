using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASWERP.Models
{
    public class AuthVM
    {
        public string Guid { get; set; }
        public string Login { get; set; }
        public string Hash { get; set; }
        public List<string> Roles { get; set; }
    }
}
