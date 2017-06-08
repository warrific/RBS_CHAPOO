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

        public void print_all()
        {
            DALMenuItem DALitem = new DALMenuItem();
            foreach (Model.MenuItem item in DALitem.GetAll())
            {
                //Console.WriteLine("{0} {1} {2} {3}", item.naam, item.prijs, item.voorraad, item.shortname);
            }
        }
    }
}
