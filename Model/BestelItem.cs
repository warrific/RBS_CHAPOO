using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BestelItem
    {
        int id;
        double prijs;
        int voorraad;

        public Categorie categorie
        {
            get; private set;
        }

        public string kaartType
        {
            get; private set;
        }

        public string naam
        {
            get; private set;
        }


        public int id { get; private set; }
        public MenuItem item { get; private set; }
        public int aantal { get; private set; }
        public string opmerking { get; private set; }

        public BestelItem(int id_in, MenuItem item_in, int aantal_in, string opmerking_in)
        {
            id = id_in;
            item = item_in;
            aantal = aantal_in;
            opmerking = opmerking_in;
        }
    }
}
