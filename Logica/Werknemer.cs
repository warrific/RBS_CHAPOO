﻿using System.Collections.Generic;
using DAL;

namespace Logica
{
    public class Werknemer
    {

        public List<Model.Werknemer> GetAll()
        {
            DALWerknemer dalwerknemer = new DALWerknemer();
            return dalwerknemer.GetAll();
        }

        public Model.Werknemer GetWerknemer(int code)
        {
            DALWerknemer dalitem = new DALWerknemer();

            return dalitem.GetWerknemer(code);
        }

        public  Logica.Werknemer BedieningKiestTafel (string persoonid)
        {
                
            Logica.Werknemer id = new Logica.Werknemer();

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
    }
}

