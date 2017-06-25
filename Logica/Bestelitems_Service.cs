using System.Collections.Generic;
using Model;
using DAL;

namespace Logica
{
    public class BestelItems_Service
    {
        public List<BestelItem> GetBestellingItems(int order_id)
        {
            BestelItem_DAO DALItem = new BestelItem_DAO();
            return DALItem.GetAllForID(order_id);
        }

        public BestelItem CheckOfLijstAlMenuItemHeeft(List<BestelItem> lijstBestelItems, MenuItem menuItem)
        {
            foreach(BestelItem item in lijstBestelItems)
            {
                if(item.MenuItem.Id == menuItem.Id)
                {
                    return item;
                }
            }

            return null;
        }

        public bool CheckAantal(BestelItem item, MenuItem menuItem)
        {
            if(menuItem.Voorraad <= item.Aantal)
            {
                return true;
            }
            return false;
        }

        public void VerhoogAantal(List<BestelItem> lijstBestelItems, MenuItem menuItem)
        {
            foreach(BestelItem item in lijstBestelItems)
            {
                if(item.MenuItem.Id == menuItem.Id)
                {
                    item.Aantal++;
                }
            }
        }

        public void VerwijderBestelItemUitDB(BestelItem item)
        {
            DAL.BestelItem_DAO dalBestelItem = new BestelItem_DAO();
            dalBestelItem.VerwijderBestelItemUitDatabase(item);
        }


        public void VerlaagAantal(List<BestelItem> lijstBestelItem, MenuItem menuItem)
        {
            for (int i = 0; i < lijstBestelItem.Count; i++)
            {
                if (lijstBestelItem[i].MenuItem.Shortname == menuItem.Shortname)
                {
                    lijstBestelItem[i].Aantal--;

                    if (lijstBestelItem[i].Aantal == 0)
                    {
                        lijstBestelItem.RemoveAt(i);
                    }
                }
            }
        }
    }
}
