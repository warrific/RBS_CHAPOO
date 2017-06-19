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
        public Categorie Categorie { get; private set; }
        public SubCategorie Subcategorie { get; private set; }
        public string Shortname { get; private set; }

        public MenuItem(int id_in, string naam_in, double prijs_in, int voorraad_in, string shortname_in, Categorie categorie_in, SubCategorie subcategorie_in)
        {
            Id = id_in;
            Naam = naam_in;
            Prijs = prijs_in;
            Voorraad = voorraad_in;
            Categorie = categorie_in;
            Shortname = shortname_in;
            Subcategorie = subcategorie_in;
        }
    }
}
