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
    }
}
