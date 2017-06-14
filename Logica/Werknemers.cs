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
        public List<Model.Werknemer> make_list()
        {
            DALWerknemer DAOWerknemer = new DALWerknemer();
            return DAOWerknemer.GetAll();
        }
        
        public void ToevoegenWerknemer(string naam, string functie, int code)
        {
            DALWerknemer DAOWerknemer = new DALWerknemer();
            int id = DAOWerknemer.GetLastId() + 1;
            DAOWerknemer.ToevoegenWerknemer(id, naam, functie, code);
        }
        public void WijzigenWerknemer(int id, string naam, string functie)
        {
            DALWerknemer DAOWerknemer = new DALWerknemer();
            DAOWerknemer.WijzigenWerknemer(id, naam, functie);
        }
        public void VerwijderenWerknemer(int id)
        {
            DALWerknemer DAOWerknemer = new DALWerknemer();
            DAOWerknemer.VerwijderenWerknemer(id);
        }
    }
}
