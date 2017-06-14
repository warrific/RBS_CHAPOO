using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Werknemer
    {
       // int id;
       // Functie functie;
       // string naam;
       // string wachtwoord;

      //  public Werknemer()
      //  {

      //  }

        //members van Werknemer
        private int id;
        public int Id { get { return id; } set { id = value; } }
        public Functie functie;
        public string naam;
        private string wachtwoord;
        public string Wachtwoord { get { return this.wachtwoord; } set { if ((wachtwoord.Length == 4)) { this.wachtwoord = value; } } }

        //bool properties voor set-members

        public bool Setid(int in_id)
        {
            if ((in_id > 0))
            {
                this.id = in_id;
                return true;
            }
            return false;
        }

        public bool Setfunctie(Functie in_functie)
        {
            if ((in_functie == Functie.Bediening || in_functie == Functie.Bar || in_functie == Functie.Eigenaar || in_functie == Functie.Kok || in_functie == Functie.Sommelier))
            {
                this.functie = in_functie;
                return true;
            }
            return false;
        }

        public bool Setnaam(string in_naam)
        {
            if ((in_naam != " "))
            {
                this.naam = in_naam;
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
            id = in_id;
            functie = in_functie;
            naam = in_naam;
            wachtwoord = in_wachtwoord;


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