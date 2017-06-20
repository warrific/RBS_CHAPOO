using System.Collections.Generic;
using Model;
using DAL;

namespace Logica
{
    public class Bestelitems_Service
    {
        public List<BestelItem> GetBestellingItems(int order_id)
        {
            BestelItem_DAO DALItem = new BestelItem_DAO();
            return DALItem.GetAllForID(order_id);
        }

        public void VerwijderBestelItemUitDB(BestelItem item)
        {
            DAL.BestelItem_DAO dalBestelItem = new BestelItem_DAO();
            dalBestelItem.VerwijderBestelItemUitDatabase(item);
        }
    }
}
