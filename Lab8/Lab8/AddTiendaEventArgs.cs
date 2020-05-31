using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class AddTiendaEventArgs : EventArgs
    {
        public string OwnerName { get; set; }
        public string AttentionTime { get; set; }
        public int Identifier { get; set; }
        public List<string> Categories { get; set; }
    }
}
