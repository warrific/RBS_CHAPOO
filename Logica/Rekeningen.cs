﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Windows.Forms;

namespace Logica
{
    public class Rekeningen
    {
        private List<RekeningItem> rekening;


        public Rekeningen(int tafelNr)
        {
            Bestellingen bestelling = new Bestellingen();
            int order_id = bestelling.GetOrderId(tafelNr);
            DALRekeningItem dal = new DALRekeningItem();
            rekening = dal.GetRekening(order_id);
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
                totaalPrijs += item.prijs;
            }
            return totaalPrijs; 
        }

        public double GetBtw()
        {
            double btwTarief = 0;
            foreach (RekeningItem item in rekening)
            {
                btwTarief += item.prijs * item.btw;
            }
            return btwTarief;
        }

        public double BtwBedrag()
        {
            return 0;
        }

        public double GetTotaalprijs(double fooi, double subtotaal, double btwBedrag)
        {
            return subtotaal + fooi + btwBedrag;
        }  
    }
}

