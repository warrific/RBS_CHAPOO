﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bestelling
    {
        public int Id { get; private set; }
        public List<BestelItem> Bestel_items { get; private set; }
        public Tafel Tafel { get; private set; }
        public Status Status_order { get; private set; }
        public Werknemer Werknemer { get; private set; }
        public double Totaalprijs { get; private set; }
        public string Betaalmethode { get; private set; }
        public double Fooi { get; private set; }
        public string Opname { get; private set; }
        public string Opmerking { get; private set; }

        public Bestelling() 
        { }

        public Bestelling(int id, double totaalPrijs, string betaalMethode, string opmerking, double fooi)
        {
            this.Id = id;
            this.Totaalprijs = totaalPrijs;
            this.Betaalmethode = betaalMethode;
            this.Opmerking = opmerking;
            this.Fooi = fooi;
        }

        public Bestelling(int id_in, List<BestelItem> bestel_items_in, Tafel tafel_in, Status status_order_in, Werknemer werknemer_in, double totaalprijs_in, string betaalmethode_in, double fooi_in, string opname_in)
        {
            Id = id_in;
            Bestel_items = bestel_items_in;
            Tafel = tafel_in;
            Status_order = status_order_in;
            Werknemer = werknemer_in;
            Totaalprijs = totaalprijs_in;
            Betaalmethode = betaalmethode_in;
            Fooi = fooi_in;
            Opname = opname_in;
        }

        public Bestelling(List<BestelItem> bestel_items_in, Tafel tafel_in, Status status_order_in, Werknemer werknemer_in, double totaalprijs_in, string betaalmethode_in, double fooi_in, string opname_in)
        {
            Bestel_items = bestel_items_in;
            Tafel = tafel_in;
            Status_order = status_order_in;
            Werknemer = werknemer_in;
            Totaalprijs = totaalprijs_in;
            Betaalmethode = betaalmethode_in;
            Fooi = fooi_in;
            Opname = opname_in;
        }

        // Dit kan volgensmij ook in de property zelf?
        // TO DO: DIT MOET IN LOGICA
        public int BerekenTotaalPrijs()
        {
            return 0;
        }
    }
}
