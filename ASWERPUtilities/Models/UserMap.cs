using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

using ASWERPModels.Models;

namespace ASWERPUtilities.Models
{
    public sealed class UserMap : CsvClassMap<User>
    {
        public UserMap()
        {
            Map(m => m.ACID);
            Map(m => m.Name);
        }
    }
}
