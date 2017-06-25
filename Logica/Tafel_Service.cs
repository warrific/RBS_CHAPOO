using System.Collections.Generic;
using DAL;
using Model;

namespace Logica
{
    public class Tafel_Service
    {
        // maak een lijst met alleen de TafelId's om eventueel door te geven aan de bestellingenlijst
   
        public bool CheckTafelNr(int tafelnr)
        {
            Tafel_DAO daltafel = new Tafel_DAO();

            if ( tafelnr == daltafel.GetID(tafelnr))
            {
                return true;
            }
            
            else
            {
                return false;
            }
        }
    }
}
