using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bestelling_weergave
    {
        public int Id { get; private set; }
        public int Tafel_nummer { get; private set; }
        public int Aantal { get; private set; }
        public string Order { get; private set; }
        public string Opmerking { get; private set; }
        public string Bediening { get; private set; }
        public Status Status_item { get; private set; }
        public string order_date { get; private set; }


    public Bestelling_weergave(int id_in, int tafel_nummer_in, int aantal_in, string order_in, string opmerking_in, string bediening_in, Status status_item_in, string order_date_in)
        {
            Id = id_in;
            Aantal = aantal_in;
            Order = order_in;
            Opmerking = opmerking_in;
            Bediening = bediening_in;
            Tafel_nummer = tafel_nummer_in;
            Status_item = status_item_in;
            order_date = order_date_in;
        }
    }
}
