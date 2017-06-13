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
        public MenuItem item { get; private set; }
        public int aantal { get; private set; }
        public string opmerking { get; private set; }
        public string status { get; private set; }                       // Word enum

        public BestelItem(int id_in, MenuItem item_in, int aantal_in, string opmerking_in, string status_in)
        {
            id = id_in;
            item = item_in;
            aantal = aantal_in;
            opmerking = opmerking_in;
            status = status_in;
        }
    }
}
