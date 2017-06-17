using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Text.RegularExpressions;

namespace Logica
{
    public class Werknemers
    {
        public List<Model.Werknemer> make_list()
        {
            DALWerknemer DALWerknemer = new DALWerknemer();
            return DALWerknemer.GetAll();
        }
        
        public string ToevoegenWerknemer(string naam, string functie, int code)
        {
            if (naam != "")
            {
                if (Enum.IsDefined(typeof(Functie), functie))
                {
                    if (code.ToString().Length == 4)
                    {
                        DALWerknemer DALWerknemer = new DALWerknemer();
                        List<int> codes = new List<int>();

                        codes = DALWerknemer.GetCodes();

                        foreach (int DBCode in codes) //Check of code niet bestaat
                        {
                            if (DBCode == code)
                            {
                                return "Code bestaat al";
                            }
                        }

                        int id = DALWerknemer.GetLastId() + 1;
                        DALWerknemer.ToevoegenWerknemer(id, naam, functie, code);
                        return "";
                    }
                    else return "Code foute lengte"; 
                }
                else return "Functie niet ingevuld";
            }
            else return "Naam niet ingevuld";
        }
        public string WijzigenWerknemer(int id, string naam, string functie)
        {
            if (naam != "")
            {
                if (Enum.IsDefined(typeof(Functie), functie))
                {
                    DALWerknemer DALWerknemer = new DALWerknemer();
                    DALWerknemer.WijzigenWerknemer(id, naam, functie);
                    return "";
                }
                else return "Functie onjuist";
            }
            else return "Naam niet ingevuld";
        }
        public void VerwijderenWerknemer(int id)
        {
            DALWerknemer DALWerknemer = new DALWerknemer();
            DALWerknemer.VerwijderenWerknemer(id);
        }
    }
}
