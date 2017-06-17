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
        public float Prijs { get; private set; }

        public RekeningItem(int aantal, string naam, float prijs)
        {
            this.Aantal = aantal;
            this.Naam = naam;
            this.Prijs = prijs;
        }
    }
}
        
