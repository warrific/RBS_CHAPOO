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
        private BestellingsStatus status;
        public BestellingsStatus Status { get { return status; } set { if (status == BestellingsStatus.Open || status == BestellingsStatus.Gereed || status == BestellingsStatus.Voltooid) { status = value; } } }
        public Werknemer werknemer { get; private set; }
        public double totaalprijs { get; private set; }
        public string betaalmethode { get; private set; }
        public double fooi { get; private set; }
        public DateTime opname { get; private set; }
        
        public Bestelling ()
        { }

        public Bestelling(int id_in, List<BestelItem> bestel_items_in, Tafel tafel_in, BestellingsStatus status_in, Werknemer werknemer_in, double totaalprijs_in, string betaalmethode_in, double fooi_in, DateTime opname_in)
        {
            id = id_in;
            bestel_items = bestel_items_in;
            tafel = tafel_in;
            status = status_in;
            werknemer = werknemer_in;
            totaalprijs = totaalprijs_in;
            betaalmethode = betaalmethode_in;
            fooi = fooi_in;
            opname = opname_in;
        }

        // Dit kan volgensmij ook in de property zelf?
        // TO DO: DIT MOET IN LOGICA
        public int BerekenTotaalPrijs()
        {
            return 0;
        }
    }
}
