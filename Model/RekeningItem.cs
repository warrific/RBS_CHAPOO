using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class RekeningItem
    {
        public int aantal { get; private set; }
        public string naam { get; private set; }
        public float prijs { get; private set; }

        public RekeningItem(int aantal, string naam, float prijs)
        {
            this.aantal = aantal;
            this.naam = naam;
            this.prijs = prijs;
        }
    }
}
        
