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

        public List<Bestelling> make_listbestelling()
        {
            DALBestelling DALitem = new DALBestelling();
            return DALitem.GetAll();
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
