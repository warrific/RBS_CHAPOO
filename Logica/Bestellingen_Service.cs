using System.Collections.Generic;
using Model;
using DAL;
using System.Linq;
using System;

namespace Logica
{
    public class Bestellingen_Service
    {
        List<Model.Bestelling> bestellingen_lijst = new List<Model.Bestelling>();

        public List<Bestelling_weergave> make_liststatus_weergave(List<Bestelling_weergave> bar_lijst, List<Bestelling_weergave> keuken_lijst)
        {
            
       // sorteer de bar_lijst en tafel_lijst naar tafelnr(van 1 naar 10)
            List<Bestelling_weergave> bar_sortedbyTafelNr = new List<Bestelling_weergave>();
            List<Bestelling_weergave> keuken_sortedbyTafelNr = new List<Bestelling_weergave>();
            var bar_sortedByTafelNr = bar_lijst.OrderBy(i => i.Tafel_nummer).ToList();
            var keuken_sortedByTafelNr = keuken_lijst.OrderBy(i => i.Tafel_nummer).ToList();

            return bar_sortedByTafelNr;
        }


        // TODO: Een lijst van maken
        public List<Bestelling_weergave> make_listbestelling_weergave(string filterOpStatus, string filterOpCategorie)
        {
            List<Bestelling_weergave> orderLijst = new List<Bestelling_weergave>();

            // Initialiseren
            int id = 0;
            int tafel_nummer = 0;
            int aantal = 0;
            string order = "";
            string opmerking = "";
            string bediening = "";
            Status status;
            string order_date = "";

            DAL.Bestelling_DAO DALitem = new DAL.Bestelling_DAO();

            int i = 0;
            foreach (Model.Bestelling list_item in make_listbestelling(filterOpStatus))
            {
                // Loop voor de bestel items die in de bestelling staan
                for (int m = 0; m < list_item.Bestel_items.Count; m++)
                {
                    // Voor overzicht even los en niet in new Bestelling_weergave()
                    id = bestellingen_lijst[i].Id;
                    tafel_nummer = list_item.Tafel.Id;
                    bediening = list_item.Werknemer.Naam;
                    aantal = list_item.Bestel_items[m].Aantal;
                    order = list_item.Bestel_items[m].MenuItem.Naam;
                    opmerking = list_item.Bestel_items[m].Opmerking;
                    status = list_item.Bestel_items[m].Status_item;
                    if (list_item.Opname != "")
                    {
                        order_date = list_item.Opname.Substring(9, 6);
                    }

                    orderLijst.Add(new Bestelling_weergave(id, tafel_nummer, aantal, order, opmerking, bediening, status, order_date));
                }

                i++;
            }

            return orderLijst;
        }

        

        public List<Model.Bestelling> make_listbestelling(string filterOpStatus)
        {
            // Roept DALitem.GetAll aan
            DAL.Bestelling_DAO DALitem = new DAL.Bestelling_DAO();

            if(bestellingen_lijst.Count != DALitem.GetCount())
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

        public void StuurBestelItemNaarDatabase(BestelItem item)
        {
            DAL.Bestelling_DAO dalBestelling = new DAL.Bestelling_DAO();
            dalBestelling.ZetBestelItemsInDatabase(item);
        }
        public bool ControleerOfTafelAlBestellingHeeft(Model.Tafel tafel)
        {
            DAL.Bestelling_DAO dalBestelling = new DAL.Bestelling_DAO();
            int aantal = dalBestelling.ControleerOfTafelAlBestellingHeeft(tafel);

            if( aantal == 1)
            {
                return true;
            }
            return false;
        }

        public int GetBestellingIdByTafelNummer(Model.Tafel tafel)
        {
            DAL.Bestelling_DAO dalBestelling = new DAL.Bestelling_DAO();

            List<Model.Bestelling> lijstBestellingen = dalBestelling.GetAll();

            foreach(Model.Bestelling bestelling in lijstBestellingen)
            {
                if(bestelling.Tafel.Id == tafel.Id)
                {
                    return bestelling.Id;
                }
            }
            return 0;
        }

        public void RekenBestellingAf(Model.Bestelling bestelling)
        {
            DAL.Bestelling_DAO dal = new DAL.Bestelling_DAO();
            dal.RekenAf(bestelling);
        }
    }
}
