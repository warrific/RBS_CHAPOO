using System.Collections.Generic;
using Model;
using DAL;
using System.Windows.Forms;

namespace Logica
{
    public class Rekeningen_Service
    {
        private List<RekeningItem> rekening;
        public int OrderId { get; private set; }

        public Rekeningen_Service(int tafelNr)
        {
            Bestellingen_Service bestelling = new Bestellingen_Service();
            OrderId = bestelling.GetOrderId(tafelNr);
            RekeningItem_DAO dal = new RekeningItem_DAO();
            rekening = dal.GetRekening(OrderId);
        }
        public List<RekeningItem> getRekening()
        {
            return rekening;
        }

        public double GetSubtotaalPrijs()
        {
            double totaalPrijs = 0;
            foreach (RekeningItem item in rekening)
            {
                totaalPrijs += item.Prijs * item.Aantal;
            }
            return totaalPrijs; 
        }

        public double GetBtw()
        {
            double btwTarief = 0;
            foreach (RekeningItem item in rekening)
            {
                btwTarief += item.Prijs * item.Btw;
            }
            return btwTarief;
        }

        public double GetTotaalprijs(double fooi, double subtotaal, double btwBedrag)
        {
            return subtotaal + fooi + btwBedrag;
        }  
    }
}

