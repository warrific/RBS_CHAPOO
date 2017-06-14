using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BestelItem
    {
        public int id { get; private set; }
        public MenuItem menuItem { get; private set; }
        public int aantal { get; set; }
        public string opmerking { get; private set; }
        public BestellingsStatus status { get; private set; }                       // Word enum

        public BestelItem(int id_in, MenuItem item_in, int aantal_in, string opmerking_in, BestellingsStatus status_in)
        {
            id = id_in;
            menuItem = item_in;
            aantal = aantal_in;
            opmerking = opmerking_in;
            status = status_in;
        }
    }
}
