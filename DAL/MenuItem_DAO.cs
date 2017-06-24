using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using Model;
using System.Data;

namespace DAL
{
    public class MenuItem_DAO
    {
        protected SqlConnection dbConnection;

        public MenuItem_DAO()
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

        public int GetLastId()
        {
            dbConnection.Open();

            SqlCommand command = new SqlCommand("SELECT MAX(item_id) FROM Menuitem", dbConnection);

            int id = 0;

            id = (int)command.ExecuteScalar();

            dbConnection.Close();

            return id;
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

        public void ToevoegenMenu(int menukaart, string naam, string korteNaam, string prijs)
        {
            dbConnection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Menuitem VALUES (@Naam, 0, @Prijs, @Kaart, @Shortname)", dbConnection);
            command.Parameters.AddWithValue("@Naam", naam);
            command.Parameters.AddWithValue("@Kaart", menukaart);
            command.Parameters.AddWithValue("@Prijs", prijs);
            command.Parameters.AddWithValue("@Menukaart", menukaart);
            command.Parameters.AddWithValue("@Shortname", korteNaam);

            SqlDataReader reader = command.ExecuteReader();

            reader.Close();
            dbConnection.Close();
        }

        public void ToevoegenMenu2(int id, int subcategorie)
        {
            dbConnection.Open();
            
            SqlCommand command = new SqlCommand("INSERT INTO Menukaart VALUES (@Id, @Subcategorie)", dbConnection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Subcategorie", subcategorie);

            SqlDataReader reader = command.ExecuteReader();

            reader.Close();
            dbConnection.Close();
        }

        public void WijzigenMenu(int id, int menukaart, string naam, string korteNaam, string prijs)
        {
            dbConnection.Open();

            SqlCommand command = new SqlCommand("UPDATE Menuitem SET naam = @Naam, prijs = @Prijs, category = @Kaart, shortname = @Shortname WHERE item_id = @Id", dbConnection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Naam", naam);
            command.Parameters.AddWithValue("@Kaart", menukaart);
            command.Parameters.AddWithValue("@Prijs", prijs);
            command.Parameters.AddWithValue("@Menukaart", menukaart);
            command.Parameters.AddWithValue("@Shortname", korteNaam);

            SqlDataReader reader = command.ExecuteReader();

            reader.Close();
            dbConnection.Close();
        }

        public void WijzigenMenu2(int id, int subcategorie)
        {
            dbConnection.Open();

            SqlCommand command = new SqlCommand("UPDATE Menukaart SET subcategorie = @Subcategorie WHERE item = @Id", dbConnection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Subcategorie", subcategorie);

            SqlDataReader reader = command.ExecuteReader();

            reader.Close();
            dbConnection.Close();
        }

        public void VerwijderenMenu(int id)
        {
            dbConnection.Open();

            SqlCommand command = new SqlCommand("DELETE FROM Menuitem WHERE item_id = @Id", dbConnection);
            command.Parameters.AddWithValue("@Id", id);

            SqlDataReader reader = command.ExecuteReader();

            reader.Close();
            dbConnection.Close();
        }

        public void VerwijderenMenu2(int id)
        {
            dbConnection.Open();

            SqlCommand command = new SqlCommand("DELETE FROM Menukaart WHERE item = @Id", dbConnection);
            command.Parameters.AddWithValue("@Id", id);

            SqlDataReader reader = command.ExecuteReader();

            reader.Close();
            dbConnection.Close();
        }

        private MenuItem Readitem(SqlDataReader reader)
        {
            MenuKaart_DAO getkaart = new MenuKaart_DAO();

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
            dbConnection.Open();

            //string SB = "SELECT * " + 
            //            "FROM Menuitem " + 
            //            "JOIN Menukaart ON MenuItem.item_id = Menukaart.item " +
            //            "WHERE category = @dcategory AND subcategorie = @dsubcategory";

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * ");
            sb.Append("FROM Menuitem ");
            sb.Append("JOIN Menukaart ON MenuItem.item_id = Menukaart.item ");
            sb.Append("WHERE category = @dcategory AND subcategorie = @dsubcategory");


            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, dbConnection);

            SqlParameter dcategory = new SqlParameter("@dcategory", SqlDbType.Int);
            SqlParameter dsubcategory = new SqlParameter("@dsubcategory", SqlDbType.Int);
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

            dbConnection.Close();

            return lijstMenuItem;
        }

        public int GetIdForName(string item_naam)
        {
            int item_id = 0;

            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT [item_id] FROM Menuitem WHERE naam = @Naam", dbConnection);
            command.Parameters.AddWithValue("@Naam", item_naam);
            SqlDataReader reader = command.ExecuteReader();

            // Item id ophalen
            while (reader.Read())
            {
                item_id = (int)reader["item_id"];
            }

            reader.Close();
            dbConnection.Close();

            return item_id;
        }

        public void BewerkVoorraad(MenuItem item, int aantalBesteld)
        {
            dbConnection.Open();

            string dbString =   "UPDATE Menuitem " +
                                "SET voorraad = @nieuw " +
                                "WHERE item_id = @itemid";

            SqlCommand command = new SqlCommand(dbString, dbConnection);

            command.Parameters.AddWithValue("@nieuw", item.Voorraad - aantalBesteld);
            command.Parameters.AddWithValue("@itemid", item.Id);

            command.ExecuteNonQuery();

            dbConnection.Close();
        }
    }
}
