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
        public List<Bestelling> make_listbestelling_dranken(List<Bestelling> bestellingen_lijst)
        {
            List<Model.Bestelling> dranken_lijst = new List<Model.Bestelling>();

            int i = 0;
            foreach (Model.Bestelling list_item in bestellingen_lijst)
            {
                if (list_item.bestel_items.categorie == Categorie.Drank)
                {
                    dranken_lijst[i] = bestellingen_lijst[i];
                }
                i++;
            }

            return dranken_lijst;
        }

        public List<Bestelling> make_listbestelling()
        {
            // Roept DALitem.GetAll aan
            DALBestelling DALitem = new DALBestelling();
            return DALitem.GetAll();
        }
    }
}
