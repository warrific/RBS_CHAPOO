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
        public List<Model.Werknemer> GetAll()
        {
            Werknemer_DAO dalwerknemer = new Werknemer_DAO();
            return dalwerknemer.GetAll();
        }

        public Model.Werknemer GetWerknemer(int code)
        {
            Werknemer_DAO dalitem = new Werknemer_DAO();

            return dalitem.GetWerknemer(code);
        }

        public Model.Werknemer GetWerknemerByName(string name)
        {
            Werknemer_DAO dalWerknemer = new Werknemer_DAO();
            List<Model.Werknemer> lijstWerknemers = dalWerknemer.GetAll();

            foreach(Model.Werknemer werknemer in lijstWerknemers)
            {
                if(werknemer.Naam == name)
                {
                    return werknemer;
                }
            }

            return null;
        }

        public bool WachtwoordOngeldig(string password, out Model.Werknemer modelWerknemer)
        {
            modelWerknemer = GetWerknemer(int.Parse(password));
            
            return modelWerknemer == null;
         
        }

        public  Logica.Werknemer_Service BedieningKiestTafel (string persoonid)
        {
                
            Logica.Werknemer_Service id = new Logica.Werknemer_Service();

            Status_tafel status_tafel = new Status_tafel();
            if(status_tafel == Status_tafel.Vrij)
            {
                    
            } 

            return  id;
         }
        //  public string check_werknemer (List<Werknemer>werknemers, string invoer_wachtwoord)
        // {
        //      string naam_werknemer = "";
        //      DALLogin loginCheck = new DALLogin ();
        //      DALWerknemer werknemer = new DALWerknemer();
        //      if (int.Parse(invoer_wachtwoord) == loginCheck.GetPassword(invoer_wachtwoord))
        //      {

        // naam_werkgever = werknemer.werknemers[0].naam;  

        //          return naam_werkgever;
        //     }

        //     else
        //     {
        //        naam_werkgever = "";
        //        return naam_werkgever;
        //    }
        // }
        public List<Model.Werknemer> make_list()
        {
            Werknemer_DAO DALWerknemer = new Werknemer_DAO();
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
                        Werknemer_DAO DALWerknemer = new Werknemer_DAO();
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
                    Werknemer_DAO DALWerknemer = new Werknemer_DAO();
                    DALWerknemer.WijzigenWerknemer(id, naam, functie);
                    return "";
                }
                else return "Functie onjuist";
            }
            else return "Naam niet ingevuld";
        }
        public void VerwijderenWerknemer(int id)
        {
            Werknemer_DAO DALWerknemer = new Werknemer_DAO();
            DALWerknemer.VerwijderenWerknemer(id);
        }
    }
}

