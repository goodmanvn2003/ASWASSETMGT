using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASWERP.Models
{
    public class ModDateTimePicker : DateTimePicker
    {
        public string Identifier { get; set; }
        public int CurrentColumn { get; set; }
        public int CurrentRow { get; set; }
        public int CurrentCell { get; set; }
    }
}
