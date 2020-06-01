using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class AddRecreacionEventArgs : EventArgs
    {
        public string OwnerName { get; set; }
        public string AttentionTime { get; set; }
        public int Identifier { get; set; }

    }
}
