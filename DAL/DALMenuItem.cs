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

        public Model.MenuItem GetForID(int klantId)
        {
            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Klanten WHERE Id = @Id", dbConnection);
            command.Parameters.AddWithValue("@Id", klantId);
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
            int id = (int)reader["id"];
            string naam = (string)reader["Naam"];
            int prijs = (int)reader["Prijs"];
            int voorraad = (int)reader["Voorraad"];
            Categorie categorie = (Categorie)(int)reader["Categorie"];
            string shortname = (string)reader["shortname"];

            return new Model.MenuItem(id, naam, prijs, voorraad, categorie, shortname);
        }
    }
}
