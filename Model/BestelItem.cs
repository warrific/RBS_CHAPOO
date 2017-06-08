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

        public BestelItem()
        {
            //..
        }

        public void ToonAlleMenuItems()
        {

        }
    }
}
