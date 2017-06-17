using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logica
{
    public class Bestelitems
    {
        public List<BestelItem> GetBestellingItems(int order_id)
        {
            DALBestelItem DALItem = new DALBestelItem();
            return DALItem.GetAllForID(order_id);
        }

        public void VerwijderBestelItemUitDB(BestelItem item)
        {
            DAL.DALBestelItem dalBestelItem = new DALBestelItem();
            dalBestelItem.VerwijderBestelItemUitDatabase(item);
        }
    }
}
