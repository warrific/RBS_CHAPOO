using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuItem
    {
        public int id { get; private set; }
        public string naam { get; private set; }
        public double prijs { get; private set; }
        public int voorraad { get; private set; }
        public Categorie categorie { get; private set; }

        public string shortname { get; private set; }
        public SubCategorie subCategorie { get; private set; }

        public MenuItem(int id_in, string naam_in, double prijs_in, int voorraad_in ,Categorie categorie_in ,string shortname_in, SubCategorie subCategorie)
        {
            id = id_in;
            naam = naam_in;
            prijs = prijs_in;
            voorraad = voorraad_in;
            categorie = categorie_in;
            shortname = shortname_in;
            this.subCategorie = subCategorie;
        }

        public MenuItem(int id, string naam, double prijs, int voorraad, string shortname, Categorie categorie)
        {
            this.id = id;
            this.naam = naam;
            this.prijs = prijs;
            this.voorraad = voorraad;
            this.shortname = shortname;
            this.categorie = categorie;
        }

        public void ToonAlleMenuItems()
        {

        }
    }
}
