using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bestelling
    {
        public int id { get; private set; }
        public List<BestelItem> bestel_items { get; private set; }
        public Tafel tafel { get; private set; }
        public Status status_order { get; private set; }
        public Werknemer werknemer { get; private set; }
        public double totaalprijs { get; private set; }
        public string betaalmethode { get; private set; }
        public double fooi { get; private set; }
        public DateTime opname { get; private set; }
    }
}
