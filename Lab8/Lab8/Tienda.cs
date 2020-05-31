using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Tienda : Local
    {
        private List<string> categories;
        public Tienda(string ownerName, int identifier, string attentionTime, List<string> categories)
        {
            this.ownerName = ownerName;
            this.identifier = identifier;
            this.attentionTime = attentionTime;
            this.categories = categories;
        }

        public List<string> Categories { get => categories; set => categories = value; }
    }
}
