﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bestelling_weergave
    {
        public int id { get; set; }
        public int tafel_nummer { get; set; }
        public int aantal { get; set; }
        public string order { get; set; }
        public string opmerking { get; set; }
        public string bediening { get; set; }
        public Status status_item { get; set; }

        public Bestelling_weergave(int id_in, int tafel_nummer_in, int aantal_in, string order_in, string opmerking_in, string bediening_in, Status status_item_in)
        {
            id = id_in;
            aantal = aantal_in;
            order = order_in;
            opmerking = opmerking_in;
            bediening = bediening_in;
            tafel_nummer = tafel_nummer_in;
            status_item = status_item_in;
        }

        // Dit kan volgensmij ook in de property zelf?
        // TO DO: DIT MOET IN LOGICA
        public int BerekenTotaalPrijs()
        {
            return 0;
        }
    }
}