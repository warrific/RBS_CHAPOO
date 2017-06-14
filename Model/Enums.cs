using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    // De categorieen in MenuItem
    public enum Categorie
    {
        Diner = 1, Lunch, Drank, Alcohol
    }

    // De subcategorien in database tabel MenuKaart
    public enum SubCategorie
    {
        Voorgerecht = 1, HoofdGerecht, Nagerecht, Tussengerecht, Nonalcoholisch, Alcoholisch
    }

    // Status van onderandere orders
    public enum Status
    {
        Open = 1, Gereed, Voltooid
    }

    // Status van de tafel
    public enum Status_tafel
    {
        Vrij = 1, Bezet
    }
}
