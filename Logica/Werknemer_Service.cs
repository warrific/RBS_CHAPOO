using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logica
{
    public class Werknemer_Service
    {
        public List<Model.Werknemer> make_list()
        {
            Werknemer_DAO DALWerknemer = new Werknemer_DAO();

            return DALWerknemer.GetAll();
        }

        public Model.Werknemer GetWerknemer(int code)
        {
            Werknemer_DAO dalitem = new Werknemer_DAO();

            return dalitem.GetWerknemer(code);
        }

        public bool WachtwoordOngeldig(string password, out Model.Werknemer modelWerknemer)
        {
            modelWerknemer = GetWerknemer(int.Parse(password));
            
            return modelWerknemer == null;
        }
        
        public bool IsUniekeCode(int code)
        {
            Werknemer_DAO DALWerknemer = new Werknemer_DAO();
            List<int> codes = new List<int>();

            codes = DALWerknemer.GetCodes();

            // Check of code al bestaat in DB
            foreach (int DBCode in codes) 
            {
                if (DBCode == code)
                {
                    return false;
                }
            }
            return true;
        }

        public void ToevoegenWerknemer(string naam, string functie, int code)
        {
            Werknemer_DAO DALWerknemer = new Werknemer_DAO();
            
            DALWerknemer.ToevoegenWerknemer(naam, functie, code);
        }

        public void WijzigenWerknemer(int id, string naam, string functie)
        {
            Werknemer_DAO DALWerknemer = new Werknemer_DAO();

            DALWerknemer.WijzigenWerknemer(id, naam, functie);
        }

        public void VerwijderenWerknemer(int id)
        {
            Werknemer_DAO DALWerknemer = new Werknemer_DAO();

            DALWerknemer.VerwijderenWerknemer(id);
        }
    }
}

