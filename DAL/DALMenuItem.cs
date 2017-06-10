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
        // Standaard info uit mini project, aanpassen
        protected SqlConnection dbConnection;

        public DALMenuItem()
        {
            string connString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            dbConnection = new SqlConnection(connString);
        }

        public List<Model.MenuItem> GetAll()
        {
            // List
            List<Model.MenuItem> items = new List<Model.MenuItem>();

            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM MenuItem", dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            // Klanten inlezen
            while (reader.Read())
            {
                Model.MenuItem item = Readitem(reader);
                items.Add(item);
            }

            reader.Close();
            dbConnection.Close();

            return items;
        }

        public Model.MenuItem GetForID(int itemId)
        {
            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM MenuItem WHERE Id = @Id", dbConnection);
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

        private Model.MenuItem Readitem(SqlDataReader reader)
        {
            int id = (int)reader["item_id"];
            string naam = (string)reader["naam"];
            int voorraad = (int)reader["voorraad"];
            double prijs = (float)(double)reader["prijs"];
            Categorie categorie = (Categorie)(int)reader["category"];
            string shortname = (string)reader["shortname"];

            return new Model.MenuItem(id, naam, prijs, voorraad, categorie, shortname);
        }
    }
}
