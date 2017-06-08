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
        Categorie categorie;

        public string naam
        {
            get; private set;
        }


        public int aantal { get; private set; }
        public string commentaar { get; private set; }

        public BestelItem(int id_in, string naam_in, double prijs_in, int voorraad_in, Categorie categorie_in)
        {
            id = id_in;
            naam = naam_in;
            prijs = prijs_in;
            voorraad = voorraad_in;
            categorie = categorie_in;
        }

        public void ToonAlleMenuItems()
        {

        }
    }
}
