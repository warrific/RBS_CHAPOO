using System.Collections.Generic;
using Model;
using DAL;

namespace Logica
{
    public class Rekeningen
    {
        public List<RekeningItem> getRekening(int order_id)
        {
            DALRekeningItem dal = new DALRekeningItem();
            return dal.GetRekening(order_id);
        }
    }
}

