using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Restaurante : Local
    {
        private bool exclusiveTable;

        public Restaurante(string ownerName, int identifier, string attentionTime, bool exclusiveTable)
        {
            this.ownerName = ownerName;
            this.identifier = identifier;
            this.attentionTime = attentionTime;
            this.exclusiveTable = exclusiveTable;
        }

        public bool ExclusiveTable { get => exclusiveTable; set => exclusiveTable = value; }
    }
}
