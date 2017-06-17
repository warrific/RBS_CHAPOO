using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class RekeningItem
    {
        public int Aantal { get; private set; }
        public string Naam { get; private set; }
        public double Prijs { get; private set; }
        public double Btw { get; private set; }

        public RekeningItem(int aantal, string naam, double prijs, double btw)
        {
            this.Aantal = aantal;
            this.Naam = naam;
            this.Prijs = prijs;
            this.Btw = btw;
        }
    }
}
        
