using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Logica
{
    public class Login
    {
         
             public  bool check_wachtwoord (string invoer_wachtwoord)
             {
          
                DALLogin loginCheck = new DALLogin ();
                if (int.Parse(invoer_wachtwoord) == loginCheck.GetPassword(invoer_wachtwoord))
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
