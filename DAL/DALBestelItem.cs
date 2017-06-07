using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

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
/*
        public List<Klant> GetAll()
        {
            // List
            List<Klant> klanten = new List<Klant>();

            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Klanten", dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            // Klanten inlezen
            while (reader.Read())
            {
                Klant klant = ReadKlant(reader);
                klanten.Add(klant);
            }

            reader.Close();
            dbConnection.Close();

            return klanten;
        }

        public Klant GetForID(int klantId)
        {
            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Klanten WHERE Id = @Id", dbConnection);
            command.Parameters.AddWithValue("@Id", klantId);
            SqlDataReader reader = command.ExecuteReader();

            Klant klant = null;

            if (reader.Read())
            {
                klant = ReadKlant(reader);
            }

            reader.Close();
            dbConnection.Close();

            return klant;
        }

        private Klant ReadKlant(SqlDataReader reader)
        {
            int id = (int)reader["id"];
            string voornaam = (string)reader["Voornaam"];
            string achternaam = (string)reader["Achternaam"];
            string email = (string)reader["EmailAdres"];

            return new Klant(id, voornaam, achternaam, email);
        }
*/
    }
}
