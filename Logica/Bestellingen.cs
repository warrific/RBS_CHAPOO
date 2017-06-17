using System.Collections.Generic;
using Model;
using DAL;

namespace Logica
{
    public class Bestellingen
    {
        // Public omdat de UI klassen er bij moeten kunnen
        public List<Bestelling_weergave> bar_lijst = new List<Bestelling_weergave>();
        public List<Bestelling_weergave> keuken_lijst = new List<Bestelling_weergave>();

        public List<Bestelling_weergave> make_listbestelling_weergave(bool status_actueel, bool is_drinken)
        {
            // Initialiseren
            int id = 0;
            int tafel_nummer = 0;
            int aantal = 0;
            string order = "";
            string opmerking = "";
            string bediening = "";
            Status status;

            DALBestelling DALitem = new DALBestelling();

            int i = 0;
            foreach (Bestelling list_item in make_listbestelling())
            {
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

                    
                    // Check welke lijst gevuld moet worden en wat hier in moet (actueel of historie)
                    if ((list_item.Bestel_items[m].MenuItem.Categorie == Categorie.Drank || list_item.Bestel_items[m].MenuItem.Categorie == Categorie.Alcohol)&& (list_item.Bestel_items[m].Status_item == Status.Open) == status_actueel)
                    {
                        bar_lijst.Add(new Bestelling_weergave(id, tafel_nummer, aantal, order, opmerking, bediening, status));
                    }
                    else if ((list_item.Bestel_items[m].MenuItem.Categorie == Categorie.Diner || list_item.Bestel_items[m].MenuItem.Categorie == Categorie.Lunch) && (list_item.Bestel_items[m].Status_item == Status.Open) == status_actueel)
                    {
                        keuken_lijst.Add(new Bestelling_weergave(id, tafel_nummer, aantal, order, opmerking, bediening, status));
                    }
                }

                i++;
            }
            
            // Check welke van de lijsten we moeten terug geven
            if (is_drinken)
            {
                return bar_lijst;
            }
            else
            {
                return keuken_lijst;
            }
        }

        public List<Bestelling> bestellingen_lijst = new List<Bestelling>();

        public List<Bestelling> make_listbestelling()
        {
            // Roept DALitem.GetAll aan
            DALBestelling DALitem = new DALBestelling();

            if(bestellingen_lijst.Count != DALitem.GetCount())
            {
                bestellingen_lijst = DALitem.GetAll();
                return bestellingen_lijst;
            }
            else
            {
                return bestellingen_lijst;
            }
        }

        public void meld_gereed(int order_id, string item_naam)
        {
            DALBestelItem DALitem = new DALBestelItem();
            DALMenuItem DALitem_naam = new DALMenuItem();

            // Naam omzetten naar een ID
            int item_id = DALitem_naam.GetIdForName(item_naam);

            // DAL laag aanroepen en waardes mee geven om gereed te melden
            DALitem.MeldGereed(order_id, item_id);
        }

        public int GetOrderId(int tafelNr)
        {
            DALBestelling DALITem = new DALBestelling();
            return DALITem.GetId(tafelNr);
        }

        public int GetCountOrderId()
        {
            DALBestelling dalBestelling = new DALBestelling();
            return dalBestelling.GetCount();
        }

        public void StuurBestelItemNaarDatabase(BestelItem item)
        {
            DALBestelling dalBestelling = new DALBestelling();
            dalBestelling.ZetBestelItemsInDatabase(item);
        }
        public bool ControleerOfTafelAlBestellingHeeft(Model.Tafel tafel)
        {
            DALBestelling dalBestelling = new DALBestelling();
            int aantal = dalBestelling.ControleerOfTafelAlBestellingHeeft(tafel);

            if( aantal == 1)
            {
                return true;
            }
            return false;
        }

        public int GetBestellingIdByTafelNummer(Model.Tafel tafel)
        {
            DAL.DALBestelling dalBestelling = new DALBestelling();

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
    }
}
