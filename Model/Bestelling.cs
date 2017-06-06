using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Bestelling
    {
        int id;
        public List<BestelItem> lijstBestelItem { get; private set; }
        public Tafel tafel { get; private set; }
        public Werknemer werknemer { get; private set; }
        DateTime opname;

        public Bestelling()
        {

        }

        public int BerekenTotaalPrijs()
        {
            return 0;
        }

        public void ToonAlleBestelItems()
        {

        }
    }
}
