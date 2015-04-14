using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASWERP.Models
{
    public class AssetsHandoverVM
    {
        public string Id { get; set; }
        public int AccessId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string GroupManagerName { get; set; }

        public DateTime? HandoverBy { get; set; }
        public DateTime? RecordedBy { get; set; }
        public DateTime? ReceivedBy { get; set; }
        public DateTime? AcknowledgedBy { get; set; }

        public List<AssetHandoverDetails> Details { get; set; }
    }
}
