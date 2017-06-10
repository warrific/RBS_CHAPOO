using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logica
{
    public class Tafel
    {
       

        public TafelStatus VeranderTafelStatus(int bedrag)
        {  
            if(bedrag > 0)
            {
            TafelStatus tafel1 = TafelStatus.vrij;
            return tafel1;
            }

            else
            {
            TafelStatus tafel1 = TafelStatus.bezet;
            return tafel1;
            }    
        }

     

     //   public BestelStatus VeranderBestellingStatus(Functie functie, int druktBtn1, int druktBtn2 )
     //   {
            
     //       BestelStatus Bstatus = new BestelStatus ();
            
        //       if((druktBtn1 = (int)Functie.Kok)  (druktBtn1 = (int)(Functie.Bar)))  
        //       {
        //         Bstatus = BestelStatus.InBewerking;
        //       }

         //      else if ((druktBtn2 = (int)Functie.Kok)) || ((druktBtn2= (int)Functie.Bar)))
         //      {     
         //          Bstatus = BestelStatus.Gereed;
         //      }
                
          //      else if (Functie.Bediende = druktBtn1)
          //      {
           //         Bstatus = BestelStatus.Besteld;
           //     }
                
           //    else if(Functie.Bediende = druktBtn2)            
          //    {
           //     Bstatus = BestelStatus.Bediend;
            //    }

            //     return Bstatus;
       //  }


                               
        public void print_all()
        {
            DALTafel DALitem = new DALTafel();
            foreach (Model.Tafel item in DALitem.GetAll())
            {
                //Console.WriteLine("{0} {1} {2} {3}", item.naam, item.prijs, item.voorraad, item.shortname);
            }
        }
    }
}
