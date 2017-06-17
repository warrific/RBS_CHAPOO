using System.Collections.Generic;
using Model;
using DAL;

namespace Logica
{
    public class MenuItems
    {
        public List<MenuItem> make_list()
        {
            DALMenuItem DALitem = new DALMenuItem();
            return DALitem.GetAll();
        }

        public void WijzigVoorraad(int id, int aantal, bool optellen)
        {
            DALMenuItem DALitem = new DALMenuItem();
            DALitem.WijzigVoorraad(id, aantal, optellen);
        }
        
        public List<MenuItem> HaalFilterdeLijstOp(Categorie categorie, SubCategorie subcategorie)
        {
            DALMenuItem dalMenuItem = new DALMenuItem();
            List<MenuItem> lijstMenuItems = new List<MenuItem>();
            foreach(MenuItem item in dalMenuItem.FilterByCategories(categorie, subcategorie))
            {
                lijstMenuItems.Add(item);
            }
            return lijstMenuItems;
        }

        public double BerekenTotaalBestelItem(BestelItem bestelItem)
        {
            return bestelItem.MenuItem.Prijs * bestelItem.Aantal;
        }

        public double BerekenTotaalBestelling(List<BestelItem> lijstBestelItem)
        {
            double totaal = 0;
            foreach(BestelItem item in lijstBestelItem)
            {
                totaal += item.MenuItem.Prijs * item.Aantal;
            }

            return totaal;
        }

        public void StuurBestellingNaarDatabase(Bestelling bestelling)
        {
            DALBestelling dalBestelling = new DALBestelling();
            dalBestelling.ZetBestellingInDatabase(bestelling);
        }

        public int GetVoorraad(MenuItem item)
        {
            DALMenuItem dalMenuItem = new DALMenuItem();

            List<MenuItem> lijstMenuItems = dalMenuItem.GetAll();

            int voorraad = 0;

            foreach(MenuItem dbItem in lijstMenuItems)
            {
                if (item == dbItem)
                    dbItem.Voorraad = voorraad;
            }

            return voorraad;
        }

        public void BewerkVoorraad(MenuItem item, int aantalBesteld)
        {
            DALMenuItem dalMenuItem = new DALMenuItem();
            dalMenuItem.BewerkVoorraad(item, aantalBesteld);
        }
    }
}
