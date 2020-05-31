using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Cine : Local
    {
        private int numberOfRooms;

        public Cine(string ownerName, int identifier, string attentionTime, int numberOfRooms)
        {
            this.ownerName = ownerName;
            this.identifier = identifier;
            this.attentionTime = attentionTime;
            this.numberOfRooms = numberOfRooms;
        }

        public int NumberOfRooms { get => numberOfRooms; set => numberOfRooms = value; }
    }
}
