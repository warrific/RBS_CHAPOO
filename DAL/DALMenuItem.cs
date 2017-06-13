using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Model;
using System.Data;
using System.Data.SqlTypes;

namespace DAL
{
    public class DALMenuItem
    {
        protected SqlConnection dbConnection;

        public DALMenuItem()
        {
            string connString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            dbConnection = new SqlConnection(connString);
        }

        public List<MenuItem> GetAll()
        {
            // List
            List<MenuItem> items = new List<MenuItem>();

            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM MenuItem", dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            // Items inlezen
            while (reader.Read())
            {
                MenuItem item = Readitem(reader);
                items.Add(item);
            }

            reader.Close();
            dbConnection.Close();

            return items;
        }

        public MenuItem GetForID(int itemId)
        {
            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM MenuItem WHERE item_id = @Id", dbConnection);
            command.Parameters.AddWithValue("@Id", itemId);
            SqlDataReader reader = command.ExecuteReader();

            Model.MenuItem item = null;

            if (reader.Read())
            {
                item = Readitem(reader);
            }

            reader.Close();
            dbConnection.Close();

            return item;
        }

        public void WijzigVoorraad(int itemId, int aantal, bool optellen)
        {

            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command;
            if (optellen)
                command = new SqlCommand("UPDATE Menuitem SET voorraad += @Aantal WHERE item_id = @Id", dbConnection);
            else
                command = new SqlCommand("UPDATE Menuitem SET voorraad -= @Aantal WHERE item_id = @Id", dbConnection);
            command.Parameters.AddWithValue("@Id", itemId);
            command.Parameters.AddWithValue("@Aantal", aantal);
            SqlDataReader reader = command.ExecuteReader();

            reader.Close();
            dbConnection.Close();
        }

        private MenuItem Readitem(SqlDataReader reader)
        {
            DALMenuKaart getkaart = new DALMenuKaart();

            int id = (int)reader["item_id"];
            string naam = (string)reader["naam"];
            int voorraad = (int)reader["voorraad"];
            double prijs = (float)(double)reader["prijs"];
            string shortname = (string)reader["shortname"];
            Categorie categorie = (Categorie)(int)reader["category"];
            SubCategorie subcategorie = (SubCategorie)getkaart.GetTypeForID(id);

            return new MenuItem(id, naam, prijs, voorraad, shortname, categorie, subcategorie);
        }


        // filtert de DB Menu items en stuurt een lijst terug met alle gefilterde menu items
        public List<MenuItem> FilterByCategories(Categorie categorie, SubCategorie subCategorie)
        {
            DALConnection dalConnect = new DALConnection();
            SqlConnection connection = dalConnect.OpenConnectieDB();

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * ");
            sb.Append("FROM Menuitem ");
            sb.Append("JOIN Menukaart ON MenuItem.item_id = Menukaart.item ");
            sb.Append("WHERE category = @dcategory AND subcategorie = @dsubcategory");

            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, connection);

            SqlParameter dcategory = new SqlParameter("@dcategory", System.Data.SqlDbType.Int);
            SqlParameter dsubcategory = new SqlParameter("@dsubcategory", System.Data.SqlDbType.Int);
            dcategory.Value = (int)categorie;
            dsubcategory.Value = (int)subCategorie;

            command.Parameters.Add(dcategory);
            command.Parameters.Add(dsubcategory);

            command.Prepare();

            SqlDataReader reader = command.ExecuteReader();

            List<MenuItem> lijstMenuItem = new List<MenuItem>();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string naam = reader.GetString(1);
                int voorraad = reader.GetInt32(2);
                double prijs = (float)reader.GetDouble(3);
                int category = reader.GetInt32(4);
                string shortname = reader.GetString(5);
                int subcategory = reader.GetInt32(8);
                MenuItem menuItem = new MenuItem(id, naam, prijs, voorraad, shortname, (Categorie)category, (SubCategorie)subcategory);

                lijstMenuItem.Add(menuItem);
            }

            dalConnect.sluitConnectieDB(connection);

            return lijstMenuItem;
        }
    }
}
