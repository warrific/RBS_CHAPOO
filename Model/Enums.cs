namespace Model
{
    // De categorieen in MenuItem
    public enum MenuKaart
    {
        Diner = 1, Lunch, Drank, Alcohol
    }

    // De subcategorien in database tabel MenuKaart
    public enum Categorie
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

    // Functie vd medewerker
    public enum Functie
    {
        Bediening, Bar, Eigenaar, Kok, Sommelier
    }
}
