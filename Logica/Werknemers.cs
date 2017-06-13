using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logica
{
    public class Werknemers
    {
        public List<Werknemer> make_list()
        {
            DALWerknemer DALitem = new DALWerknemer();
            return DALitem.GetAll();
        }
        public void ToevoegenWerknemer(string naam, string functie, int code)
        {
            DALWerknemer DALitem = new DALWerknemer();
            int id = DALitem.GetLastId() + 1;
            DALitem.ToevoegenWerknemer(id, naam, functie, code);
        }
    }
}
