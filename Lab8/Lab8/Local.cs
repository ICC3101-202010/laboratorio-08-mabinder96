using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public abstract class Local
    {
        protected string type;
        protected string ownerName;
        protected int identifier;
        protected string attentionTime;
        protected dynamic other;

        public string OwnerName { get => ownerName; set => ownerName = value; }
        public int Identifier { get => identifier; set => identifier = value; }
        public string AttentionTime { get => attentionTime; set => attentionTime = value; }
        public dynamic Other { get => other; set => other = value; }
        public string Type { get => type; set => type = value; }
    }
}
