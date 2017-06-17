using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Werknemer
    {
        //members van Werknemer
        public int Id { get; private set; }
        public Functie Functie { get; private set; }
        public string Naam { get; private set; }
        public string Wachtwoord { get; private set; }

        //bool properties voor set-members
        public bool Setid(int in_id)
        {
            if ((in_id > 0))
            {
                this.Id = in_id;
                return true;
            }
            return false;
        }

        public bool Setfunctie(Functie in_functie)
        {
            if ((in_functie == Functie.Bediening || in_functie == Functie.Bar || in_functie == Functie.Eigenaar || in_functie == Functie.Kok || in_functie == Functie.Sommelier))
            {
                this.Functie = in_functie;
                return true;
            }
            return false;
        }

        public bool Setnaam(string in_naam)
        {
            if ((in_naam != " "))
            {
                this.Naam = in_naam;
                return true;
            }
            return false;
        }

        //constructor Werknemer
         public Werknemer()
         {
         
         }

         public Werknemer(int in_id, Functie in_functie, string in_naam, string in_wachtwoord)
{
            Id = in_id;
            Functie = in_functie;
            Naam = in_naam;
            Wachtwoord = in_wachtwoord;


            // exceptions van de contructor Werknemer

            string errorMessage = "";

            if (Setid(in_id) == false)
                errorMessage = errorMessage + "verkeerde id: " + in_id;

            if (Setfunctie(in_functie) == false)
       {
                errorMessage = errorMessage + "verkeerde functie: " + in_functie;
            }

            if (Setnaam(in_naam) == false)
        {
                errorMessage = errorMessage + "  " + in_naam;
            }

            if (errorMessage != "")
            {
                throw new Exception("Werknemer construction failed "
                + errorMessage);
            }
        }
    }
}