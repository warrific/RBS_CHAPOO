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
            int id = 0;
            int tafel_nummer = 0;
            int aantal = 0;
            string order = "";
            string opmerking = "";
            string bediening = "";
            string status = "";

            DALBestelling DALitem = new DALBestelling();

            int i = 0;
            foreach (Model.Bestelling list_item in make_listbestelling())
            {
                for (int m = 0; m < list_item.bestel_items.Count; m++)
                {
                    id = bestellingen_lijst[i].id;
                    tafel_nummer = list_item.tafel.tafel_id;
                    bediening = list_item.werknemer.naam;
                    aantal = list_item.bestel_items[m].aantal;
                    order = list_item.bestel_items[m].item.naam;
                    opmerking = list_item.bestel_items[m].opmerking;
                    status = list_item.bestel_items[m].status;

                    if (list_item.bestel_items[m].item.KaartType == Categorie.Drank || list_item.bestel_items[m].item.KaartType == Categorie.Alcohol)
                    {
                        dranken_lijst.Add(new Bestelling_dranken(id, tafel_nummer, aantal, order, opmerking, bediening, status));
                    }
                }

                
                
                i++;
            }
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

        public void meld_gereed()
        {

        }
    }
}
