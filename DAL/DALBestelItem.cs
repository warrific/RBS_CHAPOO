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
    class DALBestelItem
    {
        // Standaard info uit mini project, aanpassen
        protected SqlConnection dbConnection;

        public DALBestelItem()
        {
            string connString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            dbConnection = new SqlConnection(connString);
        }

        public List<Model.BestelItem> GetAll()
        {
            // List
            List<Model.BestelItem> items = new List<Model.BestelItem>();

            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM MenuItem", dbConnection);
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

        public Model.BestelItem GetForID(int klantId)
        {
            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Klanten WHERE Id = @Id", dbConnection);
            command.Parameters.AddWithValue("@Id", klantId);
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
            int id = (int)reader["id"];
            string naam = (string)reader["Naam"];
            int prijs = (int)reader["Prijs"];
            int voorraad = (int)reader["Voorraad"];
            Categorie categorie = (Categorie)(int)reader["Categorie"];


            return new Model.BestelItem(id, naam, prijs, voorraad, categorie);
        }

    }
}
