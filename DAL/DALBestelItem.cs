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
            List<Model.BestelItem> items = new List<Model.BestelItem>();

            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Bestelling_item", dbConnection);
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

        public Model.BestelItem GetForID(int orderid)
        {
            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Bestelling_item WHERE order_id = @Id", dbConnection);
            command.Parameters.AddWithValue("@Id", orderid);
            SqlDataReader reader = command.ExecuteReader();

            Model.BestelItem item = null;

            if (reader.Read())
            {
                item = Readitem(reader);
            }

            reader.Close();
            dbConnection.Close();

            return item;
        }

        private Model.BestelItem Readitem(SqlDataReader reader)
        {
            DALMenuItem get_menu_item = new DALMenuItem();

            int id = (int)reader["order_id"];
            MenuItem menu_item = get_menu_item.GetForID((int)reader["item_id"]);            // Haal item id op uit database, geef deze aan DALMenuItem.GetForID en krijg return
            int aantal = (int)reader["aantal"];
            string opmerking = (string)reader["opmerking"];

            return new Model.BestelItem(id, menu_item, aantal, opmerking);
        }
    }
}
