using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logica
{
    class MenuItems
    {
        public void print_all()
        {
            DALMenuItem DALitem = new DALMenuItem();
            foreach (Model.MenuItem item in DALitem.GetAll())
            {

            }
        }
    }
}
