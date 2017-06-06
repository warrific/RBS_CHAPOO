using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class BestelItem
    {

        int id;
        string naam;
        double prijs;
        int voorraad;
        Categorie categorie;


        public int aantal { get; private set; }
        public List<MenuItem> lijstMenuItems { get; private set; }
        public string commentaar { get; private set; }

        public BestelItem()
        {

        }

        public void ToonAlleMenuItems()
        {

        }
    }
}
