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
        public double prijs { get; private set; }
        public double btw { get; private set; }



        public RekeningItem(int aantal, string naam, double prijs, double btw)
        {
            this.aantal = aantal;
            this.naam = naam;
            this.prijs = prijs;
            this.btw = btw;
        }
    }
}
        
