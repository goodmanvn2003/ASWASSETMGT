using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASWERP.Models
{
    public class AssetHandoverDetails
    {
        public int No { get; set; }
        public string AssetDescription { get; set; }
        public string AssetName { get; set; }
        public string Quantity { get; set; }
        public string Location { get; set; }
        public string Remarks { get; set; }
    }
}
