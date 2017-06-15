using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logica
{
    public class RestaurantOverzicht
    {
        public List<Bestelling_weergave> bar_lijst = new  List<Bestelling_weergave>();
        public List<Bestelling_weergave> keuken_lijst ;

        public List<RestaurantOverzicht> overzicht_lijst = new List<RestaurantOverzicht>();
        //overzicht_lijst = bar_lijst.Zip(keuken_lijst, (bar, keuken) =>
        //                              new { bar.id, bar.tafel_nummer, bar.aantal, bar.order, bar.opmerking, bar.bediening, bar.status, keuken.id, keuken.tafel_nummer, keuken.aantal, keuken.order, keuken.opmerking, keuken.bediening, keuken.status })
        //                         .ToList();

        //IEnumerable both = bar_lijst.OfType<object>().Concat(keuken_lijst.OfType<object>());
        
        //public List<RestaurantOverzicht> GetStatussen (List<Bestelling_weergave>bar_lijst ,List<Bestelling_weergave> keuken_lijst)
        //{
        //    List<RestaurantOverzicht> status_lijst = new List<RestaurantOverzicht>() ;

        //    // De lijsten samenvoegen 
        //    keuken_lijst.AddRange(bar_lijst);

        //    foreach( Bestelling_weergave list_item in keuken_lijst)
        //    {
                
        //    }

           // int i = 0;
           //// foreach ( Bestelling_Weergave list_item in //make_listbestelling)
           // {
           //     for (int m = 0; m < list_item.bestel_items.Count; m++)
           //     {
           //         // Voor overzicht even los en nit in new Bestelling_weergave()
           //         id = bestellingen_lijst[i].id;
           //         tafel_nummer = list_item.tafel.Id;
           //         bediening = list_item.werknemer.naam;
           //         aantal = list_item.bestel_items[m].aantal;
           //         order = list_item.bestel_items[m].menuItem.naam;
           //         opmerking = list_item.bestel_items[m].opmerking;
           //         status = list_item.bestel_items[m].status_item;

                    
           //         // Check welke lijst gevuld moet worden en wat hier in moet (actueel of historie)
           //         if ((list_item.bestel_items[m].menuItem.categorie == Categorie.Drank || list_item.bestel_items[m].menuItem.categorie == Categorie.Alcohol)&& (list_item.bestel_items[m].status_item == Status.Open) == status_actueel)
           //         {
           //             bar_lijst.Add(new Bestelling_weergave(id, tafel_nummer, aantal, order, opmerking, bediening, status));
           //         }
           //         else if ((list_item.bestel_items[m].menuItem.categorie == Categorie.Diner || list_item.bestel_items[m].menuItem.categorie == Categorie.Lunch) && (list_item.bestel_items[m].status_item == Status.Open) == status_actueel)
           //         {
           //             keuken_lijst.Add(new Bestelling_weergave(id, tafel_nummer, aantal, order, opmerking, bediening, status));
           //         }
           //     }

           //     i++;
           // }

       // }
    }
}
