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
    }
}
