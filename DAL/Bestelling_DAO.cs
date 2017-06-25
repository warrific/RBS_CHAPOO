using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using Model;
using System.Data;

namespace DAL
{
    public class Bestelling_DAO
    {
        // List
        public List<Bestelling> bestellingen = new List<Bestelling>();

        protected SqlConnection dbConnection;

        public Bestelling_DAO()
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

        protected Bestelling Readitem(SqlDataReader reader)
        {
            // Haalt alles op dat nodig is voor de bestelling, ook alle onderligende tabellen. Dit gebeurt aan de hand van de ID's (GetForID)

            // Aanroepen wat nodig is
            BestelItem_DAO getitems = new BestelItem_DAO();
            Tafel_DAO gettafel = new Tafel_DAO();
            Werknemer_DAO getwerknemer = new Werknemer_DAO();
            List<BestelItem> items_list = new List<BestelItem>();

            int order_id = (int)reader["order_id"];
            items_list = getitems.GetAllForID(order_id);                                        // Vraagt aan DALBestelItem.GetForID alle informatie over het item aan de hand van order_id
            int tafel_id = (int)reader["tafel_id"];
            Tafel tafel = gettafel.GetForID(tafel_id);                                              // Informatie ophalen aan de hand van DALTafel.GetForID("tafel_id")
            Status status_order = (Status)(int)reader["status"];
            int werknemer_id = (int)reader["persoon_id"];
            Werknemer persoon = getwerknemer.GetForID(werknemer_id);                                      // zelfde verhaal als tafel "persoon_id"
            double totaalprijs = (float)(double)reader["totaal_prijs"];
            string betaalmethode = "open";//(string)reader["betaal_methode"];
            double fooi = (float)(double)reader["fooi"];
            string opname;
            try
            {
                opname = (string)reader["datum"];
            }
            catch
            {
                opname = "";
            }

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

            return item.Id;
        }

        public int GetIdOfUncompletedOrder(int tafelNr)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Bestelling WHERE tafel_id = @Id AND NOT status = 3", dbConnection);
            command.Parameters.AddWithValue("@Id", tafelNr);
            SqlDataReader reader = command.ExecuteReader();

            Bestelling item = null;

            if (reader.Read())
            {
                item = Readitem(reader);
            }
            reader.Close();
            dbConnection.Close();

            return item.Id;
        }

        public void ZetBestellingInDatabase(Bestelling bestelling)
        {
            dbConnection.Open();

            string dbString =   "INSERT INTO Bestelling (tafel_id, persoon_id, totaal_prijs, betaal_methode, fooi, status, datum) " +
                                "VALUES (@tafelid, @persoonid, @totaal, @betaal, @fooi, @status, @datum)";

            SqlCommand command = new SqlCommand(dbString, dbConnection);

            command.Parameters.AddWithValue("@tafelid", bestelling.Tafel.Id);
            command.Parameters.AddWithValue("@persoonid", bestelling.Werknemer.Id);
            command.Parameters.AddWithValue("@totaal", bestelling.Totaalprijs);
            command.Parameters.AddWithValue("@betaal", bestelling.Betaalmethode);
            command.Parameters.AddWithValue("@fooi", bestelling.Fooi);
            command.Parameters.AddWithValue("@status", (int)bestelling.Status_order);
            command.Parameters.AddWithValue("@datum", bestelling.Opname.ToString());

            command.ExecuteNonQuery();

            dbConnection.Close();
        }

        public void ZetBestelItemsInDatabase(BestelItem item, int orderId)
        {
            dbConnection.Open();

            string dbString = "INSERT INTO Bestelling_item (order_id, item_id, aantal, opmerking, status) " +
                                "VALUES (@orderid, @item_id, @aantal, @opmerking, @status)";

            SqlCommand command = new SqlCommand(dbString, dbConnection);

            command.Parameters.AddWithValue("@orderid", orderId);
            command.Parameters.AddWithValue("@item_id", item.MenuItem.Id);
            command.Parameters.AddWithValue("@aantal", item.Aantal);
            command.Parameters.AddWithValue("@opmerking", item.Opmerking);
            command.Parameters.AddWithValue("@status", item.Status_item);

            command.ExecuteScalar();

            dbConnection.Close();
        }

        public int ControleerOfTafelAlBestellingHeeft(Tafel tafel)
        {
            dbConnection.Open();

            string dbString =   "SELECT COUNT(status) " +
                                "FROM Bestelling " +
                                "WHERE tafel_id = @tafelid AND NOT status = 3";

            SqlCommand command = new SqlCommand(dbString, dbConnection);

            command.Parameters.AddWithValue("@tafelid", tafel.Id);

            int count = (int)command.ExecuteScalar();

            dbConnection.Close();

            return count;
        }

        public void RekenAf(Bestelling bestelling)
        {
            dbConnection.Open();

            string dbString = "UPDATE Bestelling SET totaal_prijs = @totaalprijs, fooi = @fooi, opmerking = @opmerking, betaal_methode = @betaalmethode WHERE order_id = @id AND betaal_methode = 'open'";

            SqlCommand command = new SqlCommand(dbString, dbConnection);

            command.Parameters.AddWithValue("@id", bestelling.Id);
            command.Parameters.AddWithValue("@totaalprijs", bestelling.Totaalprijs);
            command.Parameters.AddWithValue("@fooi", bestelling.Fooi);
            command.Parameters.AddWithValue("@opmerking", bestelling.Opmerking);
            command.Parameters.AddWithValue("@betaalmethode", bestelling.Betaalmethode);

            command.ExecuteScalar();

            dbConnection.Close();
        }
    }
}
