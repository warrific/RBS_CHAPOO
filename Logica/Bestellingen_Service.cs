using System.Collections.Generic;
using Model;
using DAL;
using System.Linq;
using System;

namespace Logica
{
    public class Bestellingen_Service
    {
        public List<Bestelling> make_listbestelling(string filterOpStatus)
        {
            // Roept DALitem.GetAll aan
            Bestelling_DAO DALitem = new Bestelling_DAO();
            List<Bestelling> bestellingen_lijst = new List<Bestelling>();

            if (bestellingen_lijst.Count != DALitem.GetCount())
            {
                bestellingen_lijst = DALitem.GetAllWithStatus(filterOpStatus);
                return bestellingen_lijst;
            }
            else
            {
                return bestellingen_lijst;
            }
        }

        public void meld_gereed(int order_id, string item_naam)
        {
            BestelItem_DAO DALitem = new BestelItem_DAO();
            MenuItem_DAO DALitem_naam = new MenuItem_DAO();

            // Naam omzetten naar een ID
            int item_id = DALitem_naam.GetIdForName(item_naam);

            // DAL laag aanroepen en waardes mee geven om gereed te melden
            DALitem.MeldGereed(order_id, item_id);
        }

        public int GetOrderId(int tafelNr)
        {
            DAL.Bestelling_DAO DALITem = new DAL.Bestelling_DAO();
            return DALITem.GetId(tafelNr);
        }

        public int GetCountOrderId()
        {
            DAL.Bestelling_DAO dalBestelling = new DAL.Bestelling_DAO();
            return dalBestelling.GetCount();
        }

        public void StuurBestelItemNaarDatabase(List<BestelItem> lijstBestelItem)
        {
            DAL.Bestelling_DAO dalBestelling = new Bestelling_DAO();
            foreach (BestelItem item in lijstBestelItem)
            {
                dalBestelling.ZetBestelItemsInDatabase(item);
            }
        }
        public bool ControleerOfTafelAlBestellingHeeft(Tafel tafel)
        {
            Bestelling_DAO dalBestelling = new Bestelling_DAO();
            int aantal = dalBestelling.ControleerOfTafelAlBestellingHeeft(tafel);

            if( aantal == 1)
            {
                return true;
            }
            return false;
        }

        public int GetBestellingIdByTafelNummer(Tafel tafel)
        {
            Bestelling_DAO dalBestelling = new Bestelling_DAO();

            List<Bestelling> lijstBestellingen = dalBestelling.GetAll();

            foreach(Bestelling bestelling in lijstBestellingen)
            {
                if(bestelling.Tafel.Id == tafel.Id)
                {
                    return bestelling.Id;
                }
            }
            return 0;
        }

        public void RekenBestellingAf(Bestelling bestelling)
        {
            Bestelling_DAO dal = new Bestelling_DAO();
            dal.RekenAf(bestelling);
        }
    }
}
