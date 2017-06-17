using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            DALMenuItem DALItem = new DALMenuItem();
            DALItem.WijzigVoorraad(id, aantal, optellen);
        }

        public string ToevoegenMenu(string menukaart, string subcategorie, string naam, string korteNaam, string prijs)
        {
            if (Enum.IsDefined(typeof(Categorie), menukaart))
            {
                if (Enum.IsDefined(typeof(SubCategorie), subcategorie))
                {
                    if (naam != "")
                    {
                        if (korteNaam != "")
                        {
                            if (prijs != "")
                            {
                                DALMenuItem DALItem = new DALMenuItem();

                                int id = DALItem.GetLastId() + 1;
                                int category = (int)Enum.Parse(typeof(Categorie), menukaart);
                                int sub = (int)Enum.Parse(typeof(SubCategorie), subcategorie);
                                
                                DALItem.ToevoegenMenu(id, category, naam, korteNaam, prijs);
                                DALItem.ToevoegenMenu2(id, sub);
                                return "";
                            }
                            else return "prijs niet ingevuld";
                        }
                        else return "Korte naam niett ingevuld";
                    }
                    else return "Naam niet ingevuld";
                }
                else return "Subcategorie niet ingevuld";
            }
            else return "Menukaart niet ingevuld";
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
            return bestelItem.menuItem.prijs * bestelItem.aantal;
        }

        public double BerekenTotaalBestelling(List<BestelItem> lijstBestelItem)
        {
            double totaal = 0;
            foreach(BestelItem item in lijstBestelItem)
            {
                totaal += item.menuItem.prijs * item.aantal;
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
                    dbItem.voorraad = voorraad;
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
