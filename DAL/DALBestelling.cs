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

        public int GetCount()
        {
            int count = 0;
            // Connectie opzetten

            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(order_id) FROM Bestelling", dbConnection);

            count = (int)command.ExecuteScalar();
            
            dbConnection.Close();

            return count;
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
            Status status_order = (Status)(int)reader["status"];
            int werknemer_id = (int)reader["persoon_id"];
            Werknemer persoon = getwerknemer.GetForID(werknemer_id);                                      // zelfde verhaal als tafel "persoon_id"
            double totaalprijs = (float)(double)reader["totaal_prijs"];
            string betaalmethode = (string)reader["betaal_methode"];
            double fooi = (float)(double)reader["fooi"];
            DateTime opname = DateTime.Now;

            return new Bestelling(order_id, items_list, tafel, status_order, persoon, totaalprijs, betaalmethode, fooi, opname);
        }

        public int GetId(int tafelNr)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Bestelling WHERE tafel_id = @Id", dbConnection);
            command.Parameters.AddWithValue("@Id", tafelNr);
            SqlDataReader reader = command.ExecuteReader();

            Bestelling item = null;

            if (reader.Read())
            {
                item = Readitem(reader);
            }
            reader.Close();
            dbConnection.Close();

            return item.id;
        }

        public void ZetBestellingInDatabase(Bestelling bestelling)
        {
            dbConnection.Open();

            string dbString =   "INSERT INTO Bestelling (order_id, tafel_id, persoon_id, totaal_prijs, betaal_methode, fooi, status) " +
                                "VALUES (@orderid, @tafelid, @persoonid, @totaal, @betaal, @fooi, @status)";

            SqlCommand command = new SqlCommand(dbString, dbConnection);

            command.Parameters.AddWithValue("@orderid", bestelling.id);
            command.Parameters.AddWithValue("@tafelid", bestelling.tafel.Id);
            command.Parameters.AddWithValue("@persoonid", bestelling.werknemer.Id);
            command.Parameters.AddWithValue("@totaal", bestelling.totaalprijs);
            command.Parameters.AddWithValue("@betaal", bestelling.betaalmethode);
            command.Parameters.AddWithValue("@fooi", bestelling.fooi);
            command.Parameters.AddWithValue("@status", (int)bestelling.status_order);

            command.ExecuteNonQuery();

            dbConnection.Close();
        }

        public void ZetBestelItemsInDatabase(BestelItem item)
        {
            int count = GetCount();


            dbConnection.Open();

            string dbString = "INSERT INTO Bestelling_item (order_id, item_id, aantal, opmerking, status) " +
                                "VALUES (@orderid, @item_id, @aantal, @opmerking, @status)";

            SqlCommand command = new SqlCommand(dbString, dbConnection);

            command.Parameters.AddWithValue("@orderid", count);
            command.Parameters.AddWithValue("@item_id", item.menuItem.id);
            command.Parameters.AddWithValue("@aantal", item.aantal);
            command.Parameters.AddWithValue("@opmerking", item.opmerking);
            command.Parameters.AddWithValue("@status", item.status_item);

            command.ExecuteScalar();

            dbConnection.Close();
        }
    }
}
