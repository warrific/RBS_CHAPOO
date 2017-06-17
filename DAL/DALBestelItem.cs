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
    public class DALBestelItem
    {
        protected SqlConnection dbConnection;

        public DALBestelItem()
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

        public BestelItem GetForID(int orderid)
        {
            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Bestelling_item WHERE order_id = @Id", dbConnection);
            command.Parameters.AddWithValue("@Id", orderid);
            SqlDataReader reader = command.ExecuteReader();

            BestelItem item = null;

            if (reader.Read())
            {
                item = Readitem(reader);
            }

            reader.Close();
            dbConnection.Close();

            return item;
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

            // Klanten inlezen
            while (reader.Read())
            {
                Model.BestelItem item = Readitem(reader);
                items.Add(item);
            }

            reader.Close();
            dbConnection.Close();

            return items;
        }
        
        public void MeldGereed(int order_id, int item_id)
        {
            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("UPDATE Bestelling_item SET status = 2 WHERE order_id = @Id AND item_id = @item_id", dbConnection);            // Moet nog update worden
            command.Parameters.AddWithValue("@Id", order_id);
            command.Parameters.AddWithValue("@item_id", item_id);

            // Commando uitvoeren
            command.ExecuteScalar();

            dbConnection.Close();
        }

        private BestelItem Readitem(SqlDataReader reader)
        {
            DALMenuItem get_menu_item = new DALMenuItem();

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

            command.Parameters.AddWithValue("@orderid", item.id);
            command.Parameters.AddWithValue("@itemid", item.menuItem.id);

            command.ExecuteNonQuery();

            dbConnection.Close();
        }
    }
}
