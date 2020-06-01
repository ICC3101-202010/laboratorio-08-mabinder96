using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Restaurante : Local
    {

        public Restaurante(string ownerName, int identifier, string attentionTime, dynamic other)
        {
            this.ownerName = ownerName;
            this.identifier = identifier;
            this.attentionTime = attentionTime;
            this.Other = other;
            this.Type = "Restaurante";
        }

    }
}
