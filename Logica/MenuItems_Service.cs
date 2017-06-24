using System.Collections.Generic;
using System;

using Model;
using DAL;

namespace Logica
{
    public class MenuItems_Service
    {
        public List<MenuItem> make_list()
        {
            MenuItem_DAO DALitem = new MenuItem_DAO();
            return DALitem.GetAll();
        }

        public void WijzigVoorraad(int id, int aantal, bool optellen)
        {
            MenuItem_DAO DALItem = new MenuItem_DAO();
            DALItem.WijzigVoorraad(id, aantal, optellen);
        }

        public void ToevoegenMenu(string menukaart, string subcategorie, string naam, string korteNaam, string prijs)
        {
            MenuItem_DAO DALItem = new MenuItem_DAO();
            
            int category = (int)Enum.Parse(typeof(Categorie), menukaart);
            int sub = (int)Enum.Parse(typeof(SubCategorie), subcategorie);

            DALItem.ToevoegenMenuitem(category, naam, korteNaam, prijs);

            int id = DALItem.GetIdForName(naam);

            DALItem.ToevoegenSubcategorie(id, sub);
        }

        public void WijzigenMenu(int id, string menukaart, string subcategorie, string naam, string korteNaam, string prijs)
        {
            float floatPrijs;
            bool isFloat = float.TryParse(prijs, out floatPrijs);
            MenuItem_DAO DALItem = new MenuItem_DAO();

            int category = (int)Enum.Parse(typeof(Categorie), menukaart);
            int sub = (int)Enum.Parse(typeof(SubCategorie), subcategorie);
                                
            DALItem.WijzigenMenuitem(id, category, naam, korteNaam, prijs, sub);
        }

        public void VerwijderenMenu(int id)
        {
            MenuItem_DAO DALItem = new MenuItem_DAO();

            DALItem.VerwijderenMenuitem(id);
        }

        public List<MenuItem> HaalFilterdeLijstOp(Categorie categorie, SubCategorie subcategorie)
        {
            MenuItem_DAO dalMenuItem = new MenuItem_DAO();
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

        public void StuurBestellingNaarDatabase(Model.Bestelling bestelling)
        {
            DAL.Bestelling_DAO dalBestelling = new DAL.Bestelling_DAO();
            dalBestelling.ZetBestellingInDatabase(bestelling);
        }

        public int GetVoorraad(MenuItem item)
        {
            MenuItem_DAO dalMenuItem = new MenuItem_DAO();

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
            MenuItem_DAO dalMenuItem = new MenuItem_DAO();
            dalMenuItem.BewerkVoorraad(item, aantalBesteld);
        }
    }
}
