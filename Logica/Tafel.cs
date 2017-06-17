using System.Collections.Generic;
using DAL;
using Model;

namespace Logica
{
    public class Tafel
    {

        // Haalt de benodigde gegevens uit de Database

           
            public List<Model.Tafel> GetAll()
            {
                DALTafel daltafel = new DALTafel();
                return daltafel.GetAll();
            }

        // Als er op afrekenen gedrukt wordt dan kan een tafel vrij gegeven worden.

        public Status_tafel VeranderTafelStatus(int bedrag)
        {  
            if(bedrag > 0)
            {
                Status_tafel tafel1 = Status_tafel.Vrij;
            return tafel1;
            }

            else
            {
                Status_tafel tafel1 = Status_tafel.Bezet;
            return tafel1;
            }  
        }


        // Als een tafel vrij is dan is lopen er geen bestellingen en is er dus bediend.
        
        public Status VeranderBestellingStatus (Status_tafel tafel)
        {
            Status verandering_status = Status.Gereed;

            if(tafel == Status_tafel.Vrij)
            {
              verandering_status = Status.Voltooid;
            }

            return verandering_status;
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
