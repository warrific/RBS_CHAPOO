using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logica
{
    public class Bestellingen
    {
        public List<Bestelling_dranken> dranken_lijst = new List<Bestelling_dranken>();

        public List<Bestelling_dranken> make_listbestelling_dranken()
        {
            DALBestelling DALitem = new DALBestelling();

            int i = 0;
            foreach (Model.Bestelling list_item in make_listbestelling())
            {
                dranken_lijst[i].id = bestellingen_lijst[i].id;
                dranken_lijst[i].tafel_nummer = list_item.tafel.tafel_id;
                for (int m = 0; m < list_item.bestel_items.Count; m++)
                {
                    dranken_lijst[i].aantal = list_item.bestel_items[m].aantal;
                    dranken_lijst[i].order = list_item.bestel_items[m].item.naam;
                    dranken_lijst[i].opmerking = list_item.bestel_items[m].opmerking;
                }

                dranken_lijst[i].bediening = list_item.werknemer.naam;
                i++;
            }

                /*
                int i = 0;
                foreach (Model.Bestelling list_item in make_listbestelling())
                {
                    for (int m = 0; m < list_item.bestel_items.Count; m++)
                    {
                        if (list_item.bestel_items[m].item.categorie == Categorie.Drank)
                        {
                            dranken_lijst[i] = DALitem.bestellingen[i];
                        }
                    }


                    i++;
                }
                */

                return dranken_lijst;
        }

        public List<Bestelling> bestellingen_lijst = new List<Bestelling>();

        public List<Bestelling> make_listbestelling()
        {
            // Roept DALitem.GetAll aan
            DALBestelling DALitem = new DALBestelling();

            if(!DALitem.bestellingen.Any())
            {
                bestellingen_lijst = DALitem.GetAll();
                return bestellingen_lijst;
            }
            else
            {
                return bestellingen_lijst;
            }
        }
    }
}
