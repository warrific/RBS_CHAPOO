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
        public BestelItem bestel_items { get; private set; }
        public Tafel tafel { get; private set; }
        public string status { get; private set; }
        public Werknemer werknemer { get; private set; }
        public double totaalprijs { get; private set; }
        public string betaalmethode { get; private set; }
        public double fooi { get; private set; }
        public DateTime opname { get; private set; }

        public Bestelling(int id_in, BestelItem bestel_items_in, Tafel tafel_in, string status_in, Werknemer werknemer_in, double totaalprijs_in, string betaalmethode_in, double fooi, DateTime opname_in)
        {
            id = id_in;
            bestel_items = bestel_items_in;
            tafel = tafel_in;
            status = status_in;
            werknemer = werknemer_in;
            totaalprijs = totaalprijs_in;
            betaalmethode = betaalmethode_in;
            opname = opname_in;
        }

        // Dit kan volgensmij ook in de property zelf?
        public int BerekenTotaalPrijs()
        {
            return 0;
        }
    }
}
