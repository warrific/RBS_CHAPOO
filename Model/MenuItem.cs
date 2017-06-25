using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuItem
    {
        private int voorraadOpslag;

        public int Id { get; private set; }
        public string Naam { get; private set; }
        public double Prijs { get; private set; }
        public int Voorraad
        {
            get
            {
                return voorraadOpslag;
            }
            set
            {
                if (voorraadOpslag + value >= 0)
                {
                    voorraadOpslag = value;
                }
            }
        }
        public MenuKaart menuKaart { get; private set; }
        public Categorie categorie { get; private set; }
        public string Shortname { get; private set; }

        public MenuItem(int id_in, string naam_in, double prijs_in, int voorraad_in, string shortname_in, MenuKaart categorie_in, Categorie subcategorie_in)
        {
            Id = id_in;
            Naam = naam_in;
            Prijs = prijs_in;
            Voorraad = voorraad_in;
            menuKaart = categorie_in;
            Shortname = shortname_in;
            categorie = subcategorie_in;
        }
    }
}
