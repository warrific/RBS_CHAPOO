using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Model;

namespace DAL
{
    public class DALBestelling
    {
        // List
        public List<Bestelling> bestellingen = new List<Bestelling>();

        protected SqlConnection dbConnection;

        public DALBestelling()
        {
            string connString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            dbConnection = new SqlConnection(connString);
        }

        public List<Bestelling> GetAll()
        {
            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Bestelling", dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            // Items inlezen
            while (reader.Read())
            {
                Bestelling item = Readitem(reader);
                bestellingen.Add(item);
            }

            reader.Close();
            dbConnection.Close();

            return bestellingen;
        }

        public Bestelling GetForID(int bestelId)
        {
            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Bestelling WHERE order_id = @Id", dbConnection);
            command.Parameters.AddWithValue("@Id", bestelId);
            SqlDataReader reader = command.ExecuteReader();

            Bestelling item = null;

            if (reader.Read())
            {
                item = Readitem(reader);
            }

            reader.Close();
            dbConnection.Close();

            return item;
        }

        private Bestelling Readitem(SqlDataReader reader)
        {
            // Haalt alles op dat nodig is voor de bestelling, ook alle onderligende tabellen. Dit gebeurt aan de hand van de ID's (GetForID)

            // Aanroepen wat nodig is
            DALBestelItem getitems = new DALBestelItem();
            DALTafel gettafel = new DALTafel();
            DALWerknemer getwerknemer = new DALWerknemer();
            List<BestelItem> items_list = new List<BestelItem>();

            int order_id = (int)reader["order_id"];
            items_list = getitems.GetAllForID(order_id);                                        // Vraagt aan DALBestelItem.GetForID alle informatie over het item aan de hand van order_id
            int tafel_id = (int)reader["tafel_id"];
            Tafel tafel = gettafel.GetForID(tafel_id);                                              // Informatie ophalen aan de hand van DALTafel.GetForID("tafel_id")
            string status = (string)reader["status"];
            int werknemer_id = (int)reader["persoon_id"];
            Werknemer persoon = getwerknemer.GetForID(werknemer_id);                                      // zelfde verhaal als tafel "persoon_id"
            double totaalprijs = (float)(double)reader["totaal_prijs"];
            string betaalmethode = (string)reader["betaal_methode"];
            double fooi = (float)(double)reader["fooi"];
            DateTime opname = DateTime.Now;

            return new Bestelling(order_id, items_list, tafel, status, persoon, totaalprijs, betaalmethode, fooi, opname);
        }
        /*
        void GetId() { }
        void GetOpname() { }
        void GetBestelItems() { }
        void GetTafel() { }
        void GetWerknemer() { }
        public void GetAllBestellingen() { }
        */
    }
}
