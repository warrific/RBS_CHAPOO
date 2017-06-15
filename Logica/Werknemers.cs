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
        
        public string ToevoegenWerknemer(string naam, string functie, int code)
        {
            if (code.ToString().Length == 4)
            {
                DALWerknemer DAOWerknemer = new DALWerknemer();
                List<int> codes = new List<int>();

                codes = DAOWerknemer.GetCodes();

                foreach (int DBCode in codes) //Check of code niet bestaat
                {
                    if (DBCode == code)
                    {
                        return "Code bestaat al!";
                    }
                }

                int id = DAOWerknemer.GetLastId() + 1;
                DAOWerknemer.ToevoegenWerknemer(id, naam, functie, code);
                return "";
            }
            else
                return "Code foute lengte";
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
