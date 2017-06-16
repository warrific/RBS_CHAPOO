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
        public string opmerking { get; set; }
        public Status status_item { get; private set; }                       // Word enum

        public BestelItem(int id_in, MenuItem item_in, int aantal_in, string opmerking_in, Status status_item_in)
        {
            id = id_in;
            menuItem = item_in;
            aantal = aantal_in;
            opmerking = opmerking_in;
            status_item = status_item_in;
        }
    }
}
