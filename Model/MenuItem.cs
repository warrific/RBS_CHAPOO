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
        public Categorie categorie { get; set; }
        public string kaartType { get; private set; }               // Moet dit opgenomen worden in list?
        public string shortname { get; private set; }

        public MenuItem(int id_in, string naam_in, double prijs_in, int voorraad_in, int categorie_in, string shortname_in)
        {
            id = id_in;
            naam = naam_in;
            prijs = prijs_in;
            voorraad = voorraad_in;
            categorie = (Categorie)categorie_in;
            shortname = shortname_in;
        }

        public void ToonAlleMenuItems()
        {

        }
    }
}
