using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using Model;

namespace DAL
{
    public class BestelItem_DAO
    {
        protected SqlConnection dbConnection;

        public BestelItem_DAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            dbConnection = new SqlConnection(connString);
        }

        public List<BestelItem> GetAll()
        {
            // List
            List<BestelItem> items = new List<BestelItem>();

            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Bestelling_item", dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            // Klanten inlezen
            while (reader.Read())
            {
                BestelItem item = Readitem(reader);
                items.Add(item);
            }

            reader.Close();
            dbConnection.Close();

            return items;
        }

        public List<BestelItem> GetAllForID(int orderid)
        {
            // List
            List<BestelItem> items = new List<BestelItem>();

            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Bestelling_item WHERE order_id = @Id", dbConnection);
            command.Parameters.AddWithValue("@Id", orderid);
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                Model.BestelItem item = Readitem(reader);
                items.Add(item);
            }

            reader.Close();
            dbConnection.Close();

            return items;
        }

        
        public List<Bestelling_weergave> GetAllWeergave(int cat1, int cat2, int status)
        {
            // List
            List<Bestelling_weergave> items = new List<Bestelling_weergave>();
            
            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command;

            command = new SqlCommand(
                    "SELECT b.order_id, b.item_id, o.tafel_id, b.aantal, m.naam, b.opmerking, p.naam AS persoon, b.status, o.datum, m.category " +
                    "FROM Bestelling_item AS b " +
                    "INNER JOIN Menuitem AS m ON b.item_id = m.item_id " +
                    "INNER JOIN Bestelling AS o ON b.order_id = o.order_id " +
                    "INNER JOIN Medewerker AS p ON o.persoon_id = p.persoon_id " +
                    "WHERE b.status = @status AND m.category = @cat1 OR b.status = @status AND m.category = @cat2", dbConnection);

            command.Parameters.AddWithValue("@status", status);
            command.Parameters.AddWithValue("@cat1", cat1);
            command.Parameters.AddWithValue("@cat2", cat2);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Bestelling_weergave item = ReaditemWeergave(reader);
                items.Add(item);
            }

            reader.Close();
            dbConnection.Close();

            return items;
        }
        
        private Bestelling_weergave ReaditemWeergave(SqlDataReader reader)
        {
            int id = (int)reader["order_id"];
            int tafelnummer = (int)reader["tafel_id"];
            int aantal = (int)reader["aantal"];
            string order = (string)reader["naam"];
            string opmerking = (string)reader["opmerking"];
            string bediening = (string)reader["persoon"];
            Status status_item = (Status)(int)reader["status"];
            string order_date = ((string)reader["datum"]).Substring(9, 6);

            return new Bestelling_weergave(id, tafelnummer, aantal, order, opmerking, bediening, status_item, order_date);
        }

        public void MeldGereed(int order_id, int item_id)
        {
            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("UPDATE TOP (1) Bestelling_item SET status = 2 WHERE order_id = @Id AND item_id = @item_id", dbConnection);            // Moet nog update worden
            command.Parameters.AddWithValue("@Id", order_id);
            command.Parameters.AddWithValue("@item_id", item_id);

            // Commando uitvoeren
            command.ExecuteScalar();

            dbConnection.Close();
        }

        private BestelItem Readitem(SqlDataReader reader)
        {
            MenuItem_DAO get_menu_item = new MenuItem_DAO();

            int id = (int)reader["order_id"];
            MenuItem menu_item = get_menu_item.GetForID((int)reader["item_id"]);            // Haal item id op uit database, geef deze aan DALMenuItem.GetForID en krijg return
            int aantal = (int)reader["aantal"];
            string opmerking = (string)reader["opmerking"];
            Status status_item = (Status)(int)reader["status"];

            return new BestelItem(id, menu_item, aantal, opmerking, status_item);
        }

        public void VerwijderBestelItemUitDatabase(BestelItem item)
        {
            dbConnection.Open();

            string dbString =   "DELETE FROM Bestelling_item " +
                                "WHERE order_id = @orderid AND item_id = @itemid";
            SqlCommand command = new SqlCommand(dbString, dbConnection);

            command.Parameters.AddWithValue("@orderid", item.Id);
            command.Parameters.AddWithValue("@itemid", item.MenuItem.Id);

            command.ExecuteNonQuery();

            dbConnection.Close();
        }
    }
}
